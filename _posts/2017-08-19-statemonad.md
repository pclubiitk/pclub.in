---
layout: post
title: "Understanding State Monad"
date: 2017-08-18
author: Parv Mor
category: Functional Programming
tags:
- Functional Programming
- Monads
---

### State Monad?

A `State Monad` is basically a monad that maintains the state of the environment. It is useful in composing functions that require a common shared state. This monad is a result of requirement of referential transparency otherwise we would require to modify the variables, which is simply restricted in a purely functional program. State of the environment is maintained in a very simple and intuitive manner: pass the state of the program between the functions that require a shared state.

For example, consider a function `f :: a -> b`. To pass the state around in this function we modify it to: `f' :: a -> (b, a)` where `b` is the result when  `a`(the initial state) was passed as an argument to `f` and the `a` in `(b, a)` is the final state after the computation with `f'`. 

Haskell, formalizes this by declaring a new type in record syntax as follows:
```
newtype State s a = State { runState :: (s -> (a, s)) }
```
Here  `State` is a constructor and when `runState` is applied to this type we get our `f'` .

To compose functions we define a `Monad`  on **State s**
```
instance Monad (State s) where
	return a = State $ \s -> (a, s)
	x >>= f  = State $ \s -> let (a, s') = runState x s in runState (f a) s'
```
See that `return a`  will always give you a function that takes a state and changes the value of function without modifying the state. The bind operator is a bit more involved. In general it is defined as:
```
(>>=) :: (Monad m) => m a -> (a -> m b) -> m b
```
Our `m` was `State s`. So, this looks like:
```
(>>=) :: (Monad (State s)) => State s a -> (a -> State s b) -> State s b
```
or, more generally
```
(>>=) :: (s -> (a, s)) -> (a -> s -> (b, s)) -> (s -> (b, s))
```
It is clear to see that when we run the state of result of bind with some initial state `s`, it is similar to the following:

 1. run the state of the first arg of `(>>=)` with this initial state `s` and get a result `(a, s')` where `a` is the computed value and `s'` is the new state.
 2. apply this value `a` to the second arg of `(>>=)` and run the state of the result with the new state `s'` to get a newer state `s''` and final result `b`.


Now, that we are clear with the definition of `State Monad` let's see an example:

```
import Control.Monad.State

seq' :: [State s a] -> State s [a]
seq' [] = return []
seq' (a:as) = do
	x <- a
	xs <- seq' as
	return (x:xs)
{-
get - takes the current state
put - changes the current state
-}
incrCount :: Int -> State Int Int
incrCount x = do
	n <- get
	put $ n + x
	return n

test :: IO ()
test = print $ runState (seq' [incrCount 1, incrCount 2, incrCount 3]) 3
```
Running, this with ghci gives us:
```
λ> test
([3, 4, 6], 9)
```
Why? First, understand what `seq'` does. In `[incrCount 1, incrCount 2, incrCount 3]` note that each of the element takes a state of its own. But we want to change it somehow to to have a common state. This is precisely the job of `seq'`. So, the return value of `seq'` here will be `State Int [Int]`.
So, when we execute test with an initial state 3 the following happens:

 1. `incrCount 1` gets the current state which is `3` and changes it to `4` with the computed value `3` (due to `return n`)
 2. `incrCount 2` gets the current state which is `4` and changes it to `6` with the computed value `4`
 3. `incrCount 3` gets the current state which is `6` and changes it to `9` with the computed value `6`

Hence, the final result of runState will be `([Int], Int)` which is `([3, 4, 6], 9)`.

Consider, a more involved problem: "Given a binary tree with nodes of unknown type(but can be compared for equality), assign natural numbers to them starting from 0. The nodes with same value should have same number".

```
import Control.Monad.State
import Data.List (elemIndex)

data Tree a = End | Node a (Tree a) (Tree a) deriving (Eq, Show)

numerifyTree :: (Eq a) => Tree a -> State [a] (Tree Int)
numerifyTree End = return End
numerifyTree (Node x l r) = do
	x' <- numerifyNode x
	l' <- numerifyTree l
	r' <- numerifyTree r
	return $ Node x' l' r'
  where
    numerifyNode :: (Eq a) => a -> State [a] Int
    numerifyNode x = do
	    assignedNumbers <- get
		case x `elemIndex` assignedNumbers of
		  Nothing -> do
		    put $ assignedNumbers ++ [x]
		    return $ length assignedNumbers
		  Just i -> return i
```

This example shows the power of `State Monad` and how it can be useful in tracking the common environment variable which is `[a]` over here, without violating the functional paradigms.
