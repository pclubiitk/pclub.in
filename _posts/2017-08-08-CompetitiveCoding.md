---
layout: post
title: "Competitive Coding: Getting Started"
date: 2017-08-08
author: Pushkar Dixit


tags: 
 - Competitive Programming
 - Introduction
categories:
 - Competitive programming
 
image:
  url: https://superiorstudents.files.wordpress.com/2017/05/book-wordle.png
---
 
# Learning the way to learn

<center>
  <img src="https://superiorstudents.files.wordpress.com/2017/05/book-wordle.png" style="width: 35%; margin-left: auto; margin-right: auto;">
</center>
 
Though this post doesn't really presents an introduction to fundamentals of competitive programming but highlights some extremely important points which can really mark the difference between a novice coder and a veteran. Sometimes learning the way to learn can be important, so these points can help you become a better learner at least because competitive coding is all about learning, learning and learning.


### Choose a suitable language and know your language well enough

Though there are plenty of options to choose from when it comes to choosing a language for development tasks, the truth is there are not many when you got to choose one for competitive programming. It's either C/C++ or JAVA. That's it. You need to go with one or the other. More than three-fourths of the coders use C/C++ so is advisable to go with it and try to use other languages python/JAVA only when a specific question demands it. Like 'Very Easy' type problems can be quickly coded in python so many experienced coders resort to python to make a quick submission for such problems in short contests. Never stick to a particular language like JAVA just for the sake you have been doing all your stuff in it from your school days and now are hating to switch to a different language. JAVA will certainly give you a hard time coding solutions because it's syntax is lengthier and that is enough to set your mood off. 
But JAVA too has lots of things to boast off as well. Even though it is slower, Java has powerful built-in libraries and APIs such as BigInteger/BigDecimal, GregorianCalendar, Regex, etc.Java programs are easier to debug with the virtual machine’s ability to provide a stack trace when it crashes (as opposed to core dumps or segmentation faults in C/C++).

*Suppose that a problem requires you to compute 25! (the factorial of 25). The answer is
very large: 15,511,210,043,330,985,984,000,000. This far exceeds the largest built-in primitive
integer data type (unsigned long long: 2<sup>64</sup>−1). As there is no built-in arbitrary-precision
arithmetic library in C/C++ as of yet, we would have needed to implement one from scratch.
The Java code, however, is exceedingly simple. In this case,
using Java definitely makes for shorter coding time.*

```
import java.util.Scanner;
import java.math.BigInteger;
	class Main { 
		public static void main(String[] args) {
			BigInteger fac = BigInteger.ONE;
			for (int i = 2; i <= 25; i++)
			fac = fac.multiply(BigInteger.valueOf(i)); // it is in the library!
			System.out.println(fac);
			}	
	}	
```

So if you are having a tool in your bag, learn to use it to the best of its ability. You ought to know what all your language can provide, like C++ has an amazing set of tools specifically built for implementation of various data structures and algorithms i.e. the 'Standard Template Library' while you'll have to waste a great deal of time implementing such stuff in C language from the very scratch. 

[Follow this link to know more about STL](https://www.topcoder.com/community/data-science/data-science-tutorials/power-up-c-with-the-standard-template-library-part-1/)

### Do things the most efficient way

Let us consider the concepts of bit manipulation. Everyone that has been into programming for even a while knows there's something called bits, there's something called bitwise operators, but not many know how to use them. You need to understand the fact if something's there and then it's there for a reason, there are problems that can be efficiently solved with them so why not use them. 

Let's leave you thinking over this problem:

*An array consists of several numbers only one of which occurs exactly once while others occur exactly twice. Find the element that occurs exactly once most efficiently.*

### Refrain from starting to code before figuring out the complete solution (or atleast figuring out a plausible solution).

Never ever proceed to code without sketching out a rough solution to a problem in your mind as rushing to writing a solution will often land you in difficult spots when having written more than half of the code, you'll realise that almost everything is wrong with your solution. This will not only waste a great deal of your time but will also encourage you to move on to **more fun** things in your life.
 
### Come out of your comfort zone

Most of the novice or the mediocre coders tend to develop a comfort zone for themselves meaning by which they often start loving to solve problems of a particular category while almost always skip the ones belonging to a different category. This will lead them nowhere. It's always advisable to improve upon something you are not good at, becoming somewhat better at something you were already good at is not going to help you in the long run. What this habit will entail is the possibility of you having to search for questions that suit you in a random problem set shot at you and much to your horror there might not be any!!
 
### Don't fear the short contest format

Competitive contests should always be viewed as an opportunity to learn more than as an opportunity to build or improve upon one's rating. Learning is important and one will eventually realise this fact sooner or later. Don't fear performing poorly in the short contests, there may be times when even one problem does not clicks you but you will eventually get over that stage. Ultimately you'll have to face the short contest format at any national/internation programming contest, there's no escaping it.

### Try to read and understand others' code

Learning from others is always the best of all learning ways. So it is always advisable to go through the code of some high-rated coders and try to understand their intuitions behind the problem. You not only get to look at an approach to solving the problem but often you get to learn the way to write code neatly. You can always pick up the good things in a code and use them the next time you need them. All the more, the ability to understand code written by others would also help you in contributing to open source if you chose to diverge into that in future.
 
### Be patient

Patience, patience and patience is all that you'll require in this little world of competitive programming. Mind you, unlike the other fields of programming (like web development, open source, machine learning) this can take loads of your time, still leaving you with the petty thoughts of 'I still don't know anything'. This can happen and will happen. Don't quit. You'll eventually get there.

### A word of advice on The Online Platforms

There are many online platforms on the internet that have been specifically built for competitive programming. They let us compete,practise and learn. Though there are many platforms one could try yet some are more popular than others-

**Codechef**-
CodeChef is a non-profit educational initiative of Directi.It is a global competitive programming platform which supports over 50 programming languages and has a large community of programmers that helps students and professionals test and improve their coding skills.

**SPOJ**-
SPOJ (Sphere Online Judge) is an online judge system with over 315,000 registered users and over 20,000 problems. Tasks are prepared by its community of problem setters or are taken from previous programming contests. SPOJ allows advanced users to organize contests under their own rules and also includes a forum where programmers can discuss how to solve a particular problem.

**Codeforces**-
Codeforces is a Russian website dedicated to competitive programming.

If you are a beginner, then it's better to go for SPOJ as it has problems classified on basis of specific data structure/algorithm involved. Never rush into participating in contests because it will be of no use practically till you carry a good set of tools behind you to tackle the problems. 
*Beware*!! You must switch to codechef or codeforces only when you are ready to enter the competitive phase. The problems you'll see there might seem to be a little more advanced than required at first.

**Special Mention- GeekforGeeks**
 is something you're bound to come across if you are to stay in the world of competitive programming for a while. It is an excellent platform that contain articles on almost every topic (Algos, Data structures, Specific Problems) that can help you grasp a concept from the scratch. The articles not only include the brief idea but also the implementation details.
[http://www.geeksforgeeks.org/]

### Some prestigious competitions to target (to inspire you or to give you a sense of a goal)

**ACM-ICPC**
ACM International Collegiate Programming Contest (abbreviated as ACM-ICPC or ICPC) is an annual multi-tiered competitive programming competition among the universities of the world. The contest is sponsored by IBM. ICPC contests are team competitions. Current rules stipulate that each team consist of three students. Participants must be university students, who have had less than five years of university education before the contest. Students who have previously competed in two World Finals or five regional competitions are ineligible to compete again.
During each contest, the teams of three are given 5 hours to solve between 8 and 15 programming problems (with 8 typical for regionals and 12 for finals). They must submit solutions as programs in C, C++, Java or Python (although it is not guaranteed every problem is solvable in Python). Programs are then run on test data. If a program fails to give a correct answer, the team is notified and can submit another program.

**Facebook Hacker-Cup**
Facebook Hacker Cup is an international programming competition hosted and administered by Facebook. The competition began in 2011 as a means to identify top engineering talent for potential employment at Facebook.The competition consists of a set of algorithmic problems which must be solved in a fixed amount of time. Competitors may use any programming language and development environment to write their solutions.

**Codechef-Snackdown**
CodeChef SnackDown is an annual multi-round global programming tournament conducted by CodeChef. It aims to pit the best programming minds from across the globe against each other for the ultimate title of “SnackDown Champions”. It was conceived on the model of ICPC in its first edition in the year 2010 and catered to university students in India.
 
**Google Code-Jam**
Google Code Jam is an international programming competition hosted and administered by Google. The competition began in 2003 as a means to identify top engineering talent for potential employment at Google. The competition consists of a set of algorithmic problems which must be solved in a fixed amount of time. Competitors may use any programming language and development environment to obtain their solutions. From 2003 to 2007, Google Code Jam was deployed on Topcoder's platform and had quite different rule, since 2008 Google has developed their own dedicated infrastructure for the contest.

### Useful Links:
[Link 1](https://www.codechef.com/getting-started)*
[Link 2](https://www.hackerearth.com/practice/notes/getting-started-with-the-sport-of-programming/)

*Happy coding!!* 
 
*FYI- Cheers to team 'Faceless men' from IITK comprising of Sahil Grover,Shaswat Chaubey and Atanu Chakraborty for being among the 8 teams to represent India at ICPC World Finals 2017....*
 
 