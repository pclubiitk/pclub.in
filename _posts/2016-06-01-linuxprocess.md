---
layout: post
title: "Managing Processes in Linux"
date: 2016-06-1 18:06:00 +200
author: Anish Lamba
website: http://home.iitk.ac.in/~anishl/
tags:
- linux
- bash
categories:
- tutorial
---

# Managing Processes in Linux

### The `ps` command
Short for ***process status*** . Returns all *currently running processes* running on the system.

When called without arguments, information return can be a little useless.

To get a more clear picture we use `ps -aux` .

This tells `ps`  to return list of process from **all users**
We can also use `ps -ef` to view **all running process**
where `-e`is used to **display all processes** and `-f` is used to **display in full format listing**

To view all running processes that belongs to a particular user, we use `ps -f -u username1,username2`

**Note**: We can see processes limited to a set of users by seperating the usernames by a comma()
Often `ps aux | grep commandname` is used to get details of process with the given command

To see all proccesses in a tree structure we use `ps axjf`
Using this we get to know the parent processes (by getting an hierarchical structure)

### PIDs

Each process is assigned a *unique* **Process ID (PID)**

Each process also has a **Parent Process ID (PPID)**

To filter your searches with a specific **PID** use `ps -f -p PIDofProcess`

Similarly to filter by PPID use `ps -f --ppid PPIDofProcess`
Also you may get pid by `pidof commandname`

### Killing the process


#### The kill command

It is used to send a signal to a process or to kill a process

Basic Synatx is `kill -SIGNAL PID`

**Signals of our interest** : SIGTERM & SIGKILL

#### SIGTERM

`kill PID` will send a SIGTERM signal by default. The application can determine what to do once it receives a SIGTERM signal

It may stop the process immediately, may stop after a delay after cleaning resources or might run endlessly

`kill -SIGTERM PID` and `kill -15 PID` are same

#### SIGKILL (The Super Power)

Kind of Force Kill

Unlike SIGTERM , SIGKILL cannot be ignored by the process , even the process is not aware when SIGKILL signal is sent.

While there are rare cases where an external influence (like waiting I/O) may be the reason of ignoring SIGKILL. But it works in most cases !
`kill -SIGKILL PID` and `kill -9 PID` is same

Suppose your firefox is not responding and you decided to kill the process : ```kill -9 `pidof firefox` ```

#### The killall command

Too lazy to find the PID of a process ? Here have a look at the killall command

**Example (killing firefox)** : `killall -9 firefox`

**pkill command**
Almost the same as `kilall` command. The only difference being you don't have to provide the exact process name, partial process name will do.

**Beware you might also kill other process which you didn't intend to kill**
*Example (killing firefox)* : `pkill firef` will also do ! :D

#### The xkill command

If you are new to using **LINUX** or hate the bash, you may do it the GUI way :P

Simply  type `xkill` in the terminal and it will ask you to select a window whose client you wish to kill.

Fast if you have a GUI :P

*Have fun killing !!*

**Fin**
