---
layout: post
title: Javascript
date: 2017-08-17 2:56 +530
authors: Paramansh Singh, Suryateja B.V.
category: Javascript
tags:
- closures
- hoisting
---
# Introduction

Most of you reading this post might have a basic idea of programming. If you have spent some time learning JavaScript, you would 
have noticed that constructs like loops, conditionals etc are similar to the languages you have learnt before.

However, some topics in JavaScript might not seem obvious at the first glance. Here, we present you two such topics - **hoisting** and **closures**.  

We highly recommend you to try out the code snippets on your browser console. Open the developer tools and choose the Console tab. 


## Hoisting
Hoisting is one of the trickier concepts of JavaScript. Knowledge of hoisting will clarify most of your doubts pertaining 
to function expressions and function declarations.
 
Javascript interpreter runs twice through your code. In the first turn, the interpreter brings all the variable and function 
declarations to the top of your code. In the second turn, your code is executed.  

The word "hoist" means to raise something. For example, you _**hoist**_ a flag. Here, the interpreter _**hoists**_ all the 
variable and function declarations.  

Let us take a look at variable hoisting first. 

```javascript
console.log(notDefined); //outputs undefined
var notDefined = "Now I am defined";
console.log(notDefined); //outputs Now I a defined
```
( Allow typing multiple lines in the console, if there is any warning )  
Let's analyze this from the perspective of JS interpreter. In the first turn, we have to collect all the variable and function
declarations and hoist them. The code looks like this after the first turn:
```javascript
var notDefined;
console.log(notDefined); //outputs undefined
notDefined = "Now I am defined";
console.log(notDefined); //outputs Now I am defined
```
In the second turn, we run the code. We encounter `console.log(notDefined)` first. The variablen`notDefined` is declared, thanks 
to hoisting, but not defined. So we output `undefined`. In the next line, our variable is defined to "Now I am defined". And in 
the last statement, we log "Now I am defined" to the console.  

(If this doesn't make sense to you, just declare all the variables at the beginning of every scope to avoid bugs.) 

Now, let's jump into function hoisting. You need to know the difference between function declaration and function expression 
before we proceed further.
```javascript
function function_declaration() { console.log('foo') };
var function_expression = function () { console.log('bar') };
```
The names of the functions we have defined are `function_declaration` and `function_expression`. To call the function, we would
just say:
```javascript
function_declaration(); // outputs foo
function_expression(); // outputs bar
```
During first turn of interpretation, the function names are hoisted as expected. But, for function declarations, the definitions
are also hoisted! While for function expression, the definiton is evaluated during the second turn. This is the essential 
difference between function declaration and function expression with respect to hoisting.

Here are a few simple examples: 

```javascript
myFunction();
function myFunction() { console.log('I am function declaration') };
```
The output should be "I am function declaration". Why? Because the declaration (and the defintion) is hoisted to the beginning of 
the code:

```javascript
function myFunction() { console.log('I am function declaration') }; // hoisted
myFunction();
```
Now, what about this?

```javascript
myFunction_1();
var myFunction_1 = function () { console.log('I am function expression') };
```
The output is "TypeError: myFunction_1 is not a function". The above code is equivalent to:

```javascript
var myFunction_1;
myFunction_1();
myFunction_1 = function () { console.log('I am function expression') };
```
Calling myFunction_1 **after** the variable defintion would give the desired result:

```javascript
var myFunction_1 = function () { console.log('I am function expression') };
myFunction_1();
```
The output is "I am function expression", as expected.  

Let's wrap up function hoisting with another nice example: 

```javascript
example_function();
var example_function = function() { console.log('bar') };
function example_function() { console.log('foo') };
example_function();
```
On console, you must see "foo" logged first, and then "bar". Can you explain?  

Ok, let's wear the interpreter hat again. In the first run, we hoist all the variable and function declarations. Remember, 
function definitions are also hoisted along with function declarations. Our code looks like this now:
```javascript
function example_function() { console.log('foo') }; // function declaration hoisted
var example_function; // variable hoisted
example_function(); // first call
example_function = function() { console.log('bar') }; // variable defined
example_function(); // second call
```
Its code execution time! We see the first call to `example_function`. As of now, the definiton of `example_function` says 
`console.log('foo')`. So, we log "foo" to the console. Next, we define the variable `example_function` with `console.log('bar')`.
This overwrites the previous definiton. And in the second call, we log "bar" to the console. 


As we can see, hosting enables you to write the high-level logic code at the beginning of your source code and put 
the complex function declarations at the end.  
This helps in conveying your logic more precisely. (More importantly, you can now answer JS rookie interview questions pertaining
to hoisting :P)


## Closures
Closure is another important concept in JavaScript, and understanding this can be really helpful while building JavaScript 
applictions.
A closure is a combination of a function bundled together with references to its surrounding state ( **lexical environment** ).
That is, a closure gives you access to an outer function’s scope from an inner function. All this might sound a bit confusing 
but it is better understood as you read further.


Now we'll look at an example where we will actually see how these closures may be helpful.  
Take a simple example of implementing a counter function. It can be implemented easily by running the following code.
```javascript
var count = 0; // Global Variable
function counter(){
  count = count + 1;
  return count;
}
console.log(counter()) // outputs 1
console.log(counter()) // outputs 2
```
It seems to work perfectly and is pretty straight forward. Well, although this method might work for a small program but if 
you wish to write a large piece of code with many people contributing and using the same variable `counter`, you will surely 
run into a problem. 

The other possibility is using a local variable:

```javascript
function counter(){
  var count = 0; // local variable
  count = count + 1;
  return count;
}
```
In this case if you run ```console.log(counter())``` you will see that it always outputs 1. This is because our variable is 
always reassigned to 0 whenever we call the function.

Thats where closures come in.

We define the function in the following manner:
```javascript
function makeCounter() {
  var count = 0;
  function counter() {
  count = count + 1;
  return count;
}
  return counter;
}
```
Then we run the following commands:
```javascript
var doCount = makeCounter();
console.log(doCount()); // outputs 1
console.log(doCount()); // outputs 2
```
At first glance, it may not seem obvious that this code still works. In some programming languages, the local variables 
within a function exist only for the duration of that function's execution. So after `makeCounter()` is called the variable 
named `count` can get destroyed and may no longer be accessible. But in Javascript that's not the case.

This is beacause functions in JavaScript form closures ( functions along with the lexical environment ). This environment 
consists of any local variables that were in-scope at the time that the closure was created.

In this case when we call `makeCounter`, it creates a counter function and returns it along with an environment containing the 
free variable `count` (actual reference to the count variable, not a copy). 


In other words, it creates a **closure**. The 
function returned from `makeCounter` is stored in `doCount`. So whenever we call `doCount` it looks for a variable named 
`count` in the lexical environment and retrieves its value.

So this is basically what a closure is. There are many applications of closures and if you are interested you can 
read further in the [documentation](https://developer.mozilla.org/en/docs/Web/JavaScript/Closures)

### Additional resources

To brush up your concepts, you can go through the book [Head First Javascript](http://shop.oreilly.com/product/0636920027065.do)

There are many other features in JavaScript that we have not discussed. If interested in exploring you can see the following links:

[Difference between class and prototypal inheritance](https://medium.com/javascript-scene/master-the-javascript-interview-what-s-the-difference-between-class-prototypal-inheritance-e4cd0a7562e9) 


[Inheritance and the prototype chain](https://developer.mozilla.org/en/docs/Web/JavaScript/Inheritance_and_the_prototype_chain)


[Functional programming](https://medium.com/javascript-scene/master-the-javascript-interview-what-is-functional-programming-7f218c68b3a0)


