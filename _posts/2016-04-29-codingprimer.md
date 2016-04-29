---
layout: post
title: "A Coding Primer"
date: 2016-04-29 23:50:21 +530
author: Saksham Sharma
website: http://acehack.org
category: 
tags: 
- meta
- summer16
- tutorial
- git
categories:
- tutorial

image:
  url: https://i.ytimg.com/vi/aGujPFCKgdU/hqdefault.jpg

---

# Welcome to the Programming Club Summer Camp!

This post will serve as a list of things you should and should not do while you get into coding.
First off, coding is not this:

![](https://i.ytimg.com/vi/aGujPFCKgdU/hqdefault.jpg)

Well, not to begin with, atleast. It'll be plain, but we'll get there in a while :smile:

### So you've done ESC101?
Well, that's a start. But ESC has focussed on the algorithmic, and syntax part of programming. Most
of the programs you'd have written would have been less than 200 lines of code (LOC). We'll write thousands of lines together during the summers!

It's not as tough as you may think. Here we'll focus mostly on design of applications. The code is not going to be as challenging as in ESC, but the design phase is going to be new. Structuring large applications is a very important thing to be comfortable with.

Another requirement for most projects would be to use Linux and the Linux terminal. While the Game development ones, and the app development projects would be probably on Windows in all likeliness, we'd advise that you use Linux for all other projects.

In addition, you'd also need to learn a very important tool called *Git*. Often people do not realize it's importance till very late, and so, starting this year, all projects will be reviewed and hosted on a local Git.

There's another point which I would stress upon: The art of googling. Coming up on this soon.

Now enough with the chit chat, we get to the real stuff now.

### We're the Google generation!
Quite literally; a programmer's significant amount of time goes into googling away his/her troubles. This seems like a very abstract thing to say.

> I know how to Google! I've been using it for ages!

Well, here's the deal. By Googling, I mean knowing the right keywords to search for, and knowing what all information is superflous in an article, which links are useless, which paras will not help me find the solution faster; these things.

This comes by practice. If you cannot find a solution, Google more. You'll be inproving this skill. Getting everything on a platter is not what coding is about, and you will need to dig deep to find ways to accomplish tasks.

### The art of gisting!
Yes I coined a new word up there. The skill of absorbing information without having to spend 3 days trying to learn every single new thing; well I cannot stress enough on this skill's importance.

* You should have a clear aim in mind as to what you want to accomplish.

* Follow it up with a basic reading of what all possible packages/technologies/softwares you can use for that.

* Get hold of the basics of that technology. So if it is a web development framework, read the first 2 chapters of it's documentation.

* Set a small goal. For instance: I want a cool-looking top-bar for my website. Then read about how to do that (Google!). Do it, and keep seeing things which you do not know.

* Keep setting newer targets, and the moment you come across something new, read a little on it; only as much as is needed for your target. And implement it.

This way, you would be churning out code after code, and it'll be cool! You'll not be mugging things, or reading long long articles. The majority of your time would be spent actually implementing things.

So when people ask me how long it'll take to learn Python, I say half an hour. Because that is the amount of time you would need to learn enough to start on a goal. Once you're on a goal, you'll be learning along the way. There's no point spending days together on a thing for which you only need to know a little to implement.

### Linux
Well, Ubuntu would be great for 99% of Linux beginners out there, so go ahead and install it. Ask the coordinators for any help if needed. Go here -> [Ubuntu](http://www.ubuntu.com/)
You'd need to have an empty partition (disk drive) ready to be emptied completely, for this. If for some exceptional reasons, that is not manageable, try using VirtualBox.

What is going to be the useful part is to learn how to use the Linux terminal. Once you have Ubuntu installed, try pressing `Ctrl+Alt+T`. You'd see a *hacking-waala-box*. That's the terminal (Windows people know it as *Command Line*). The computer systems running today all run over such a thing. The graphics are mostly a farce, and a terminal is the one running things (Yes, really), and running the graphics as well. You can do everything you can do on a graphical system using this terminal (except of course the things requiring visual manipulation).

So coming to the point, terminal is a really useful thing to know. Here's an article you can follow up for this -> [UsingTheTerminal](https://help.ubuntu.com/community/UsingTheTerminal)

### Git
As mentioned before, Git is going to be invaluable. Git is a version control system, implying that it will manage your program's versions; keep it organized, clean and presentable; let you go back to older versions; visualize your progress on the project; and many more things.

To begin with, read some about Git and GitHub/Bitbucket/GitLab (*PLEASE* note that Git and GitHub are very different). Start here -> [Git Tutorial Atlassian](https://www.atlassian.com/git/tutorials/). Go with the first few chapters.

Git is an offline thing. It manages local versions of your code, so you do not have to keep folders like `code-5-may`, `code-10-may` and the likes. GitHub etc are online hosts for this. So if you want to work in a team on the same code, these websites will manage a centralized version of the code, and everyone can get copies of it and work together, and merge their work. Here's something to help you understand the part GitHub does -> [GitHub tutorial](https://guides.github.com/activities/hello-world/)

Oh, and do go here for some hands on -> [Git Tutorial](https://try.github.io/). This is a pretty cool tutorial.

### A Good coding style
A seasoned programmer can judge a coder by his code style. Some things off the top of my head:


- Do NOT write badly indented code. Most editors have an auto-indent feature. Make sure you indent your code all the time. Indent involves giving similar spaces to distinguish code blocks etc.

- Fix an indent width. Most commonly used is 4 spaces. Set your tabstop to 4 spaces.

- Fix whether to use tabs or spaces. Most editors will also have an option to convert all indent tabs to spaces. Do that to ensure uniformity.

- Do not leave useless lines in between.

- Use a fixed style of function definitions and curly braces. For instance, I prefer this one:


{% highlight c %}
int main() {
  // Code here
}
{% endhighlight %}

* Write ample comments. This is extremely important. But make sure you comment only at the useful places. Adding 2 numbers does not need a comment. Why you did that may need one.

Keep in mind that a clean code is more likely to be finally deployed. Mentors will not want to look at bad codes and fix them if need be. So it is up to you to ensure that your code is good to look at.

### Text Editors!
This may seem out of place here, but text editors are among the most important things on a programmer's machine. Be sure to configure one properly. I'll recommend `atom`, `sublime` for beginners. But if you want to reach the pinnacle of nerd-dom (No its not a bad thing, No it won't stop you from having fun), I cannot recommend Vim/Emacs enough. Go and google Vim, please do. It'll take weeks to configure properly, but it's worth it.

P.S. If you have some free time, also google for [Editor Holy Wars](https://en.wikipedia.org/wiki/Editor_war) and look at the Humor section there.

### Hacks in the code
By hacks I mean tricks which are out-of-place, but work. These are temporary solutions, and are likely to break when you least expect them to. Try to stay away from them as much as possible. If not possible, put a comment starting with `TODO` mentioning you have to fix it.

Also, placing code in random files is a hack too. For instance, for web development projects, you must not mix HTML/CSS/JS/PHP etc in the same file. Keep things logically separated. I made a sample website which demonstrates a good way of organizing your web code. Have a look at it once you're done with learning the basics of web development. Here -> [Webdev-basics](https://github.com/sakshamsharma/webdev-basic)

### Done?
We're just scratching the surface yet! Get ready to code! Feel free to contact the coordinators for any help regarding these. You've got the spark, let's get coding!
