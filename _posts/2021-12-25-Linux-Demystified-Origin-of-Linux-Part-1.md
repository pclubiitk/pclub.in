---
layout: post
title: "Linux Demystified"
date: 2021-12-25 19:44:00 +0530
author: Priydarshi Singh
website: https://dryairship.github.io
category: events
tags:
- linux
categories:
- events

image:
  url: /images/linux.webp
---

> Linux Demystified is a blog series by Programming Club IIT Kanpur, covering all the major components of a Linux distribution. This series is not an introduction on how to install/use Linux, nor a comparison between various Linux distributions, rather an explainer on what makes Linux so customizable and powerful. At the end of this series one would be able to customize their own OS, appreciate the differences and pick from the options available at every small level of an Operating System.  
> Although, a complete beginner would easily be able to go through all the blogs in this series, an amateur Linux user may better appreciate and relate to them.

### WHAT-da-F\*\*\*X!

Linus Torvalds (the creator of LINUX) had already considered the name Linux but found it egoistic. He initially wanted to call the OS FREAX (free + freak + ’X’ from Unix), even kept the name of the file as Freax for about a year.

Here we will talk about the origins, versions, and predecessors of present-day Linux systems. Our story begins way back in 1969 with the development of UNIX.

![](/images/0__vEtTa__8X__cTHNIF3.png)

### UNIX v0.0

Unix began as a platform for the Space Travel game. Ken Thompson and Dennis Ritchie’s (Yes, the creators of B and C) “Space Travel” implementation attracted notice. At first, the software had to be cross-compiled on a mainframe. The utility programs that they wrote to support hosting game development on the minicomputer itself became the core of Unix, The original spelling was “UNICS” (UNiplexed Information and Computing Service), which Ritchie later described as “a somewhat treacherous pun on Multics” that itself stood for MULTiplexed Information and Computing Service. The Unix tradition of lightweight development and informal methods also began at these roots.   
Multics had been a large project with thousands of pages of technical specifications written before the hardware arrived.   
The first running Unix code was brainstormed by three people and implemented by Ken Thompson in two days — on an obsolete machine designed to be a graphics terminal for a ‘real’ computer.

When Unix was first written, most OS developers believed an OS must be written in an assembly language to function effectively and access hardware. Unix was ground-breaking because it was written in a language ( C ) that was not an assembly language. The C language operates at a level that is just high enough to be portable to various computer hardware. Many publicly available Unix software is distributed as C programs that must be compiled before use. Many Unix programs follow C’s syntax. Unix system calls are regarded as C functions.

By the late 1970s, many universities/companies like the University of California, Microsoft Corporation started designing various variants of UNIX systems. _It was developing into a “closed source” operating system_.

### GNU/Linux

The concept of GNU started on Thanksgiving of 1983.

A post was released as “Free UNIX!” followed by  
“Starting this Thanksgiving I am going to write a complete Unix-compatible software system called GNU (for Gnu’s Not Unix), and give it away free to everyone who can use it. Contributions of time, money, programs and equipment are greatly needed \[[…](https://groups.google.com/g/net.unix-wizards/c/8twfRPM79u0/m/1xlglzrWrU0J)\]” (The whole post can be referred to [here](https://groups.google.com/g/net.unix-wizards/c/8twfRPM79u0/m/1xlglzrWrU0J).)

The writer of the post went forward to write several components for the project GNU himself, including GCC (the popular C Compiler) and GMake (GNU Make, an Automator), EMacs (Text editor, developed earlier), GNU Debugger and commonly used shell utilities including awk, grep, ls and make.

Till this point, all softwares had been made with commercialization implicit. A radical change is often perceived as crazy, and Stallman wasn’t the one who went without criticism.  
Stallman was thus deemed by many as a programming rebel that likens himself to the youthful idealist Che Guevara before 1954, wanting technology social justice without any accountability to anyone. Many would argue Stallman crossed the invisible line of future defiance at all cost when he opined when Steve Jobs died — “I’m not glad he’s dead, but I’m glad he’s gone.” A few years later, he began to openly encourage civil disobedience. Why Che Guevara Redux? Stallman is often accused of being an anarchist, which might not be accurate, but on the surface, it’s easy to relate to this analogy.  
Nevertheless, there is one obvious flaw in almost all of Stallman’s Public license demands; none of them have recourse or accountability.

GNU thus was Richard Stallman’s concept that guaranteed end users the freedom to run, study, share and modify any GNU Licensed software. GNU is composed wholly of free software, most licensed under the GNU Project’s own General Public License (GPL), and is a recursive acronym for “GNU’s Not Unix!”.  
Stallman was looking forward to creating a Kernel for an Open Source Operating System, the work for GNU Hurd (the GNU kernel) was only in progress, but Linus came up first with his kernel which completed the missing piece in the GNU Project.

Linux appeared to be Linus’ pet project at the start, more of a hobby, though one which required considerable skill. Linus built the entire Linux system from scratch. He wanted to build an open-source operating system too, for people to use, which at the time UNIX was not.  
As Linux grew, the GNU utilities began to be integrated with the Linux kernel. This resulted in what is called the GNU utilities-based OS, GNU software running on the Linux kernel. This model is followed by Linux distros today, which thus use a “GNU/Linux” system.

> The famous copypasta —

> I’d just like to interject for a moment. What you’re referring to as Linux, is in fact, GNU/Linux, or as I’ve recently taken to calling it, GNU plus Linux. Linux is not an operating system unto itself, but rather another free component of a fully functioning GNU system made useful by the GNU corelibs, shell utilities and vital system components comprising a full OS as defined by POSIX. Many computer users run a modified version of the GNU system every day, without realizing it. Through a peculiar turn of events, the version of GNU which is widely used today is often called “Linux,” and many of its users are not aware that it is basically the GNU system, developed by the GNU Project. There really is a Linux, and these people are using it, but it is just a part of the system they use. Linux is the kernel: the program in the system that allocates the machine’s resources to the other programs that you run. The kernel is an essential part of an operating system, but useless by itself; it can only function in the context of a complete operating system. Linux is normally used in combination with the GNU operating system: the whole system is basically GNU with Linux added, or GNU/Linux. All the so-called “Linux” distributions are really distributions of GNU/Linux.

### BSD

BSD stands for “[Berkeley Software Distribution](https://en.wikipedia.org/wiki/Berkeley_Software_Distribution),” It was initially a set of modifications to Bell Unix created at the University of California, Berkeley. It eventually grew into a complete operating system, and now there are multiple different BSDs.

Linux is just a kernel. Linux distributions have to bring together all the software required to create a complete Linux OS and combine it into a Linux distribution like Ubuntu, Mint, Debian, etc. In contrast, the BSDs are both a kernel and an operating system. For example, FreeBSD provides both the FreeBSD kernel and the FreeBSD operating system. It’s maintained as a single project.

Linux uses the GNU General Public License or GPL. If you modify the Linux kernel and distribute it, you must release the source code for your modifications.The BSDs use the BSD license. If you modify the BSD kernel or distribution and distribute it, you don’t have to release the source code at all. You’re free to do whatever you like with the BSD code, and you’re not obligated to release the source code, although you can do so if you want. Both are open-source but in different ways.

MacOS is a fork of BSD, which is why Apple is not obliged to release the source code.

### System V

In the 1980s and early-1990s, UNIX System V and the [Berkeley Software Distribution](https://en.wikipedia.org/wiki/Berkeley_Software_Distribution) (BSD) were the two major versions of UNIX. In fact, for years after divestiture, the Unix community was preoccupied with the first phase of the [Unix wars](https://en.wikipedia.org/wiki/Unix_wars) — an internal dispute, the rivalry between System V Unix and BSD Unix. The dispute had several levels, some technical and some cultural. The divide was roughly between longhairs and shorthairs; programmers and technical people tended to line up with Berkeley and BSD, more business-oriented types with AT&T and System V.

Throughout its development, though, System V was infused with features from BSD, while BSD variants such as DEC’s [Ultrix](https://en.wikipedia.org/wiki/Ultrix) received System V features. AT&T and Sun Microsystems worked together to merge System V with BSD-based [SunOS](https://en.wikipedia.org/wiki/SunOS) to produce [Solaris](https://en.wikipedia.org/wiki/Solaris_%28operating_system%29). Since the early 1990s, due to standardization efforts such as [POSIX](https://en.wikipedia.org/wiki/POSIX) and the success of Linux, the division between System V and BSD has become less critical.

### Conclusion

Although there are multiple UNIX based Operating Systems, Linux is the most popular due to the sheer size of the community using and maintaining it. Henceforth we will only be focusing on Linux throughout this series.

In the next blog we will talk about the steps involved during the boot of the Operating System. _Stay tuned._

Lastly, we welcome feedback, comments and suggestions.

**_References:_**

[https://wiki.archlinux.org/](https://wiki.archlinux.org/)  
[https://homepage.cs.uri.edu/~thenry/resources/unix\_art/ch02s01.html](https://homepage.cs.uri.edu/~thenry/resources/unix_art/ch02s01.html)  
[https://groups.google.com/g/net.unix-wizards/c/8twfRPM79u0/m/1xlglzrWrU0J](https://groups.google.com/g/net.unix-wizards/c/8twfRPM79u0/m/1xlglzrWrU0J)  
[https://www.gnu.org/gnu/linux-and-gnu.html](https://www.gnu.org/gnu/linux-and-gnu.html)

_Authors: Abhishek Shree, B Anshuman, Pratyush Gupta, Akhil Agrawal  
Editor: Naman Gupta  
Design: Aditya Subramanian_