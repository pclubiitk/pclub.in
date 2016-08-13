---
layout: post
title: Introductory Workshop 2016
date: 2016-08-13 10:25:00 +530
author: Coordinators
website: pclub.in
category: pclub
tags:
- pclub
image:
  url:
---

# Introduction

Hi all, welcome to the Programming Club Introductory Workshop 2016!

## Terminal
Try opening Terminal (sometimes known as Command Line) from the top-left menus. You should find it in the 'System' applications.

Mind it, some operating systems like Ubuntu might have a shortcut for this, you can open it using `Ctrl+Alt+T`, but *not* in the CC machines.

This is where you should learn to do all stuff related to programming, since this gives you *unfathomable* power.

## Directory structure
Linux organizes files and folders in the following way:

- Files are kept inside folders
- You can enter and exit folders just like in Windows
- Folders are named in the following way: `/path-to-folder/folder-name`. This is what completely describes a folder (or a file).
- We will be using the word `directory` for folders. Please note this.

To play around with this, try to use the following commands:

| Command | Full form | Description |
| ls | list screen | List all the files and folders in current directory |
| cd | change directory | Enter a folder whose path is known |
| pwd | present working directory | Full name of the current folder you are in |
| ~ | tilde | Short form for your home folder |
| `Ctrl+c`(keyboard) | | Exit/Cancel the current command |
| exit | Exit | Exit the terminal |

## Gedit
We will be using `gedit` to write your programs. Find it from the applications menu and open it. Don't be scared, it's very much like `notepad` from Windows.

# Python

Try running `python` command in the terminal. You should see something like:

```
Python 2.7.10 (default, Jul  6 2016, 22:05:31) 
[GCC 4.9.3] on linux2
Type "help", "copyright", "credits" or "license" for more information.
>>> 
```

The `>>>` is the place where you type. Try typing the following:

- 2+2
- print "hello world!"
- print a (you should get an error)
- a = 4
- print a*2

## If/Else

Now that you know how to write simple things, let's proceed to something interesting.

Python reads spaces and tabs in your program as well. So for writing a complicated instruction for the computer, we will need to use multiple lines. We will `indent` the lines in such a way that the computer can understand that they are meant to be read together.

Try the following:

```python
a = 0
if a is not 0:
    print "a is not zero"
else:
    print "a is zero"
```

That's it! See?

## Loops

Now for some loopy-loops!

```python
a = 0
while a < 10:
    print a
    a = a + 1
```

## Reading input
You can read input from the user using something like this:

```
a = raw_input()
print "Hello mr. " + a

b = int(raw_input())
print b + 5
```

See what happens there?

# CodeChef!
Try this link [here](https://www.codechef.com/problems/TEST)

Can you solve this problem? Try writing a program for this! Please give it a try before you scroll down.

It's quite small! Here's the solution!

```
while True:
    x = int(raw_input())
    if x == 42:
        break
    print x
```

So you should now **certainly** create an account on CodeChef! Try submitting the solution there (don't forget to select Python when you submit). Happy coding!
