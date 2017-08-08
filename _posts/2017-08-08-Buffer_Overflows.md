---
layout: post
title: "Buffer Overflows from scratch"
date: 2017-08-08
author: Abhishek Yadav
category: System security and Exploitation
tags:
- GDB
- Stack Layout
image:
    url: https://files.slack.com/files-pri/T3NG5QPT4-F6K3VQXHN/capture.png
---
### What is a Buffer and What are Buffer overflows ?

To keep it simple ; Buffer is a memory used temporarily to store output or input data 
while it is transferred.
From naive perspective, Buffer is just an array of a particular data type.

Buffer Overflow : It is a well known security exploit that requires a hacker to understand 
the memory layout of the system , So basically we try to access or overwrite specific 
memory addresses by taking the help of the Buffer (will be explained below) to make some
weird things happen.

### Stack Layout of System
Every function ( even main() ) has a Stack frame in the memory. 
When some function is called it creates a new stack frame just below
the stack frame of the previous function.
Lets take an example by considering a simple source code in C :

```c

#include <stdio.h>
int main ()
{
    char ch='A';
    char arr[10];
    scanf("%s",arr);
    printf("%c\n",ch);
    return 0;
}

```
Its memory layout would look something like this :-

![](https://files.slack.com/files-pri/T3NG5QPT4-F6K3VQXHN/capture.png) 

Note that the buffer goes from lower memory to higher memory location 
and the stack grows in reverse order.
Moreover there is a sequential allocation of memory to the variables onto the stack.
The variable which is declared earlier is at higher memory address and the one which 
is declared after is at lower memory address 
### Lets get some hands-on

From the above image we get a feel of what would happen if we try to 
overflow the array beyond 10 characters and then type a character of 
our choice we would do something weird.
Lets try :

{% highlight shell %} 
$ gcc buffer.c
$ ./a.out
abcdef
A
{% endhighlight %}

ALL OKAY TILL NOW  (as far is input is less than 10 characters)

Lets try a bigger input put 10 'a' and then a 'Z'

{% highlight shell %}
$ gcc buffer.c
$ ./a.out
aaaaaaaaaaZ
Z
{% endhighlight %} 

See ,It works exactly the way we wanted 

### More things that can be done  (GDB is a Prerequisite)

So far we have just updated the value of a variable by taking advantage 
of the sequential arrangement of the variables on the stack frame
WHAT NEXT !!!.
There is a plethora of things that can be done using this exploit 
It is one of the most dangerous exploits (even today). 
Be it shell code injection or executing a malicious code(that you can inject yourself :P).  

For these things you need to be thorough with the stack layout and memory allocation.
 

### A deeper look at the stack layout

Lets look at the stack layout once more:

![](https://files.slack.com/files-pri/T3NG5QPT4-F6K3VQXHN/capture.png)  

* Arguments: It has the parameters that are being passed to the function.
* Return address : it has the address to which the current function has to return after it complete its execution .
* old EBP : It has the base pointer of the function which called the current function.
* Exception Handler : Dont worry about this for now :P
* Local Variable : It has the values of all local variables being stored onto th stack.

You can find a detailed explanation of stack layout [here](http://www.tenouk.com/Bufferoverflowc/Bufferoverflow2a.html).
I will just tell you what to do ,you will have to figure out, how it is to be done, yourself.

All we have to do is rewrite the "Return address" of the current function to the address of the
desired function overflowing a buffer that is being declared in "Local Variables".
Use a debugger (GDB is quite good) to do the needful task.
You can literally redirect the order of execution of program to any function you want.

### References     

* To learn about GDB you can go [here](http://www.tutorialspoint.com/gnu_debugger/). 
* Read more about buffer overflows [Blog of Dhaval Kapil](https://dhavalkapil.com/blogs/Buffer-Overflow-Exploit/).
* Read about [ASLR](https://en.wikipedia.org/wiki/Address_space_layout_randomization) and [canaries](https://en.wikipedia.org/wiki/Stack_buffer_overflow#Stack_canaries), They are defense mechanisms to prevent Buffer Overflows.










