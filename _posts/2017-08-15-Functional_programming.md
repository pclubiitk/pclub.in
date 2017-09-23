---
layout: post
title: "Introduction to Functional Programming"
date: 2017-08-15
author: Abhay Pratap Singh
category: Functional Programming
tags:
- Functional Programming
image:
    url: http://functionaltalks.org/images/site-logo.png
---
### What is Functional Programming?
According to wikipedia, it is defined as:  
"In computer science, functional programming is a programming paradigm—a style of building the structure and elements of computer programs—that treats computation as the evaluation of mathematical functions and avoids changing-state and mutable data."  
Didn't get it? No problem! Continue reading and at the end, atleast you will get to know what it is all about.  

Actually Functional Programming is much about abstraction and mathematical concepts. And that is what acts as an hindrance for programmers from learning it. But now many people are turning towards it due to many reasons, primarily the easiness of writing thread-safe(concurrent) code in functional languages. Another reason is that it helps one write modular and compositional code. With that in mind, I have tried to cover some key ideas in this post, and have listed some resources at the last. Hoping it will help you! :)  
So let us first understand some key ideas behind functional programming:

* *Side effects*: Here, side effect imply any modification of some state by the function outside its scope. For example, modifying a global variable, I/O operations,etc.
e.g.
```c
#include <stdio.h>
int main() {
    printf("Hello World");
}
```
This is a side effect as it involves interaction with the screen(outside fuction scope). Infact, all I/O operations are side effects.  

* *Immutable data structures*: In FP, data structures are mostly immutable because it forces the functions to be pure. If data can not be changed, then there can not be any side effects. Immutability also proves to be very useful in writing concurrent code as you will see afterwards.  
 
* *Pattern Matching*: Pattern matching allows you to check a given sequence of tokens for the constituents of some pattern in data structure. For example, here is a program for evaluating sum of an array.
```scala
def sum(a: List[Int], s): Int = a match {
    case Nil => s
    case x::xs => sum(xs,s+x)
}
```  
In the above example, if a is empty(Nil), then it simply returns s. Otherwise, it extracts first element x from a, apply the same function to remaining list and add x to s. This feature is very powerful as it allows you to check against any pattern of data structure.  

* *Pure Functions(Referential Transparency)*: A pure function is one which does not have any side effects. All functional programming will revolve around same basic pure functions and composing those functions to get the required result.
So, In FP, programs are executed by just evaluating expressions(without changing state), not by executing statements(which change global state). For example,    
Fibonacci sequence(using imperative style):  
```python
def fib1(n):
    first=0
    second=1
    while n != 1:
        n = n - 1
        temp = first + second
        first = second
        second=temp
    return first
```
Using functional style(in scala):
```scala
def fib2(n: Int): Int = {
    n match {
        case 0 => 0
        case 1 => 1
        case _ => fib1(n-1) + fib1(n-2)
    }
}
```
One can easily verify that no state is being changed in the second example. It also looks familiar(something like recursion), isn't it? In FP, most of the functions are indeed implemented through recursion as there are no loops in pure functional. But this will overflow for large n, so a technique called tail-end recursion, is usually preferred(discussed later). 

* *Tail-end recursion*: A recursive function is tail recursive when recursive call is the last statement to be executed in the function. In the previous scala example for fibonacci, if the last statement consisted of only one call to fib2, then it would have been tail-end recursive. For example, 
```scala
def fib3(n: Int, a: Int, b: Int): Int = {
    n match {
        case 1 => a
        case _ => fib(n-1, b, a+b)
    }
}
```
The above function is tail-end recursive. To get the n<sup>th</sup> fibonacci number, we have to call fib3(n,0,1). In scala, tail-end recursion are also optimized internally, so that it is equivalent to using loop. 

* *Order of evaluation*: Unlike imperative programming, order of evaluation does not really matter in FP, as no side effect is actually happening. And we can substitute a sub-expression with its whole implementation and there will be no changes. 

* *Lazy evaluation*: This feature enables us to hold an expression unevaluated unless there is an actual need of using it. It avoids repeated evaluation of same expression. Here is an example which shows effect of laziness.  
1.
```scala
val x = { print("World") }
print("Hello")
print(x)
```
Output:
```
WorldHello
```
2.
```scala
lazy val x = { print("World") } //lazy variable
print("Hello")
print(x)
```
Output:
```
HelloWorld
```
So, when we declared x variable lazy, then it was evaluated when there was need of it(in print(x)). But in previous example, it was evaluated before, hence the output. 

* *Higher Order Functions*: In FP, functions can also be passed as parameters and returned as result.It provides a flexible way to compose programs. 
```scala
def apply(f: Int => Int,a: Int): Int = {
    f(n)
}
```
Above apply function is taking a function, f and an integer, a as arguments and returning the value of f(n). If f was defined like 
```scala
def f(n:Int): Int = {
    n*n
}
```
Then apply(f,2) would have returned 4. This was a simple example of higher order functions. But they are widely used across FP as they allow for new ways of abstraction and also help in composing purely functional modules. 


### Getting Started
In this blog post, I have tried to only introduce you to the world of functional programming by briefing you about its features. For tutorials,I recommend that you first go through ~~scala~~ haskell tutorials as they are better than scala in getting you started with functional programming. But after all, choice is yours.

### Haskell
* [http://learnyouahaskell.com/chapters](http://learnyouahaskell.com/chapters)
* [http://learn.hfm.io/](http://learn.hfm.io/)
* [https://www.schoolofhaskell.com/](https://www.schoolofhaskell.com/)
* [http://book.realworldhaskell.org/read/](http://book.realworldhaskell.org/read/)

### Scala
* [https://www.manning.com/books/functional-programming-in-scala](https://www.manning.com/books/functional-programming-in-scala)
* [https://www.scala-lang.org/](https://www.scala-lang.org/)
* [https://twitter.github.io/scala_school/](https://twitter.github.io/scala_school/)
* [http://danielwestheide.com/scala/neophytes.html](http://danielwestheide.com/scala/neophytes.html)
