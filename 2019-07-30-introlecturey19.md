---
layout: post
title: Introductory Workshop 2017
date: 2017-08-11 10:25:00 +530
author: Coordinators
website: pclub.in
category: pclub
tags:
- pclub
image:
  url:
---

# Introduction

Hello world!, welcome to the Programming Club Introductory Workshop 2019!

## Slack
First of all, please join our slack at [https://pclubiitk.slack.com](https://pclubiitk.slack.com)
and join the channel `#y19` to receive future notifications regarding events and other stuff
from slack announcements directly.

## Life@IITK
Programming Club worked extremely hard this summer to design your life @ IITK. We've brought together the various factes that will span your wonderful journey through 4 years.

## Terminal
What is going to be the useful part is to learn how to use the Linux terminal.

Try opening Terminal (sometimes known as Command Line) from the top-left menus. You should find it in the 'System' applications.

You'd see a _hacking-waala-box_.

The computer systems running today all run over such a thing. The graphics are mostly a farce, and a terminal is the one running things (Yes, really), and running the graphics as well. You can do everything you can do on a graphical system using this terminal (except of course the things requiring visual manipulation).

Mind it, some operating systems like Ubuntu might have a shortcut for this, you can open it using `Ctrl+Alt+T`, but *not* in the CC machines.

This is where you should learn to do all stuff related to programming, since this gives you *unfathomable* power.

## Directory structure
Linux organizes files and folders in the following way:

- Files are kept inside folders
- You can enter and exit folders just like in Windows`
- Folders are named in the following way: `/path-to-folder/folder-name`. This is what completely describes a folder (or a file).
- We will be using the word `directory` for folders. Please note this.

To play around with this, try to use the following commands:

```
$ ls

# Lists contents of current folder
```

```
$ cd Desktop

# Move to the folder named Desktop
```

```
$ cd ..

# Go Back to previous folder
```

```
$ cd ~

# Go back to home folder(where you start on opening a terminal)
```
```
$ touch try.txt

# Create a new file named try.txt




```


| Command | Full form | Description |
| ls | list screen | List all the files and folders in current directory |
| cd | change directory | Enter a folder whose path is known |
| pwd | present working directory | Full name of the current folder you are in |
| ~ | tilde | Short form for your home folder |
| `Ctrl+c`(keyboard) | | Exit/Cancel the current command |
| exit | Exit | Exit the terminal |

## VIM
We will be using `vim` to write your programs. Find it from the applications menu and open it. Don't be scared, it's very much like `notepad` from Windows.
```
$ vim try.txt

# Opens the file in vim
```

Type "An interesting programming activity"

If you are currently in insert or append mode, press 'ESC' key.

Press : (colon). The cursor should reappear at the lower left corner of the screen beside a colon prompt.

Type q! and press Enter key to save and exit
```
$ cat try.txt

# Displays the content of the file.
```


# Python Interpreter

Try running `python` command in the terminal. You should see something like:

```
Python 2.7.10 (default, Aug 12 2017, 22:05:31)
[GCC 4.9.3] on linux2
Type "help", "copyright", "credits" or "license" for more information.
>>> 
```

The `>>>` is the place where you type. Try typing the some of the
commands up like:

- 2+2
- print "hello world!"

# Python

Here are a few python expressions:

- `a = 2+2`
- `print "hello world!"`
- `print a`
- `print a*2`

Try typing all the above lines in vim and then saving the file as
`test.py`.

Now after saving the file, you will need to navigate to its location
from the terminal. Once you are in the folder containing `test.py` such
that `ls` shows `test.py` as one of the files, run:

```
$ python test.py
```

The output would be something like this:

```
hello world!
4
8
```


You used an *operator* in `a*2` - the multiplication operator. Other operators you need to try out are:

| \+ | Addition |
| \- | Subtraction |
| \* | Multiplication |
| /  | Division |
| \**| To the power of |

## If/Else

Now that you know how to write simple things, let's proceed to something interesting.

Python reads spaces and tabs in your program as well. So for writing a complicated
instruction for the computer, we will need to use multiple lines.
We will `indent` the lines in such a way that the computer can understand that
they are meant to be read together.

Try the following:

```python
a = 0
if a is not 0:
    print "a is not zero"
else:
    print "a is zero"
```

That's it! See?

Sometimes one condition isn't enough though. In that case, you are allowed to chain up multiple conditions using `and` and `or` like so:

```python
a = 0
b = 0
if a is 1 or b is a:
	print "Condition successful"
else:
	print "condition failed"
```

That's all good, but what if you want multiple checks on a variable? For example, let's say you want to do Action 1 if `a<10` and Action 2 if `a=10` and Action 3 when `a>10`, what then? This is where `if-elif-elif-elif-...-else` construct comes into the picture. Use it like this:

```python
a = 4
if a < 0:
	print "a is less than 0"
elif a >= 0 and a < 4:
	print "a is between 0 and 4"
elif a >= 4 and a < 10:
	print "a is between 4 and 10"
else:
	print "a is bigger than 10"
```

## Loops

Now for some loopy-loops!

```python
a = 0
while a < 10:
    print a
    a = a + 1
```

## Arrays

Now for some creative arrays!!

```python
a=[]
for i in range(0,10):
	a[i]=int(raw_input)
print(a)
```
## Functions

Now enough with the chit chat, we get to the real stuff now.
Comparing 3 values and prints the largest.

```python
def max(a,b,c):
	if a/b>1:
		a,b=b,a
	if b/c>1:
		b,c=c,b
	if a/c>1:
		a,c=c,a
	print(a)
print(max(3,2,5))
print(max(0,0,0))

```

## Reading input
You can read input from the user using something like this:

```python
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

```python
while True:
    x = int(raw_input())
    if x == 42:
        break
    print x
```

So you should now **certainly** create an account on CodeChef! Try submitting the solution there (don't forget to select Python when you submit). Happy coding!

# Follow up

Congrats on finishing up to here! If you're now pumped up for trying out some more challenges, try your hand at the following problems:

* [ATM](https://www.codechef.com/problems/HS08TEST)
* [Factorial](https://www.codechef.com/problems/FCTRL)
* [Enormous Input Test](https://www.codechef.com/problems/INTEST)
* [The Lead Game](https://www.codechef.com/problems/TLG)

*Note* C/C++/Java are commonly the preferred languages while participating in competitive contests. Recently, ACM ICPC has started allowing Python as well.


Now for something interesting.
P.S:-Attempt at your own risk.
* [Google Hacking Practice competitons](https://capturetheflag.withgoogle.com/#beginners/misc-satellite)
