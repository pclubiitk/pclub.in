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

Actually Functional Programming is much about abstraction and mathematical concepts. And that is what acts as an hindrance for programmers from learning it. But now many people are turning towards it due to many reasons, primarily the easiness of writing thread-safe(concurrent) code in functional languages. With that in mind, I have tried to cover some key ideas in this post, and have listed some resources at the last. Hoping it will help you! :)  
So let us first understand some key ideas behind functional programming:
* *Side effects*: Here, side effect imply any modification of some state by the function outside its scope. For example, modifying a global variable, I/O operations,etc.
e.g.
```
#include <stdio.h>
int main() {
    printf("Hello World");
}
```
This is a side effect as it involves interaction with the screen(outside fuction scope). Infact, all I/O operations are side effects.

* *Pure Functions(Referential Transparency)*: A pure function is one which does not have any side effects. All functional programming will revolve around same basic pure functions and composing those functions to get the required result.

* *Immutable data structures*: In FP, data structures are mostly immutable because it forces the functions to be pure. If data can not be changed, then there can not be any side effects. Immutability also proves to be very useful in writing concurrent code as you will see afterwards.

* *Order of evaluation*: Unlike imperative programming, order of evaluation does not really matter in FP, as no side effect is actually happening. And we can substitute a sub-expression with its whole implementation and there will be no changes. 

* *Lazy evaluation*: This is one of the wonderful features of FP. It enables us to hold an expression unevaluated unless there is an actual need of using it. It avoids repeated evaluation of same expressions.

So, In FP, programs are executed by just evaluating expressions(without changing state), not by executing statements(which change global state). For example,    
Fibonacci sequence(using imperative style):
```python
def fib1(n, first=0, second=1):
    while n != 0:
        n = n - 1
        first = second
        second = first + second
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
One can easily verify that no state is being changed in the second example. It also looks familiar(something like recursion), isn't it? In FP, most of the functions are indeed implemented through recursion.

### Getting Started
I would recommend you to first go through ~~scala~~ hashkell tutorials as they are better than scala in getting you started with functional programming. But after all, choice is yours.

### Hashkell
* [http://learnyouahaskell.com/chapters](http://learnyouahaskell.com/chapters)
* [http://learn.hfm.io/](http://learn.hfm.io/)
* [https://www.schoolofhaskell.com/](https://www.schoolofhaskell.com/)
* [book.realworldhaskell.org/read/](book.realworldhaskell.org/read/)

### Scala
* [https://www.manning.com/books/functional-programming-in-scala](https://www.manning.com/books/functional-programming-in-scala)
* [https://www.scala-lang.org/](https://www.scala-lang.org/)
* [https://twitter.github.io/scala_school/](https://twitter.github.io/scala_school/)
