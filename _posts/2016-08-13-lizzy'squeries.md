---
layout: post
title: Lizzy's Queries
date: 2016-08-13 00:25:00 +530
author: Arjun Sinha
website:
category:
subsection: summerwpc
hidden: true
tags:
- competitive
categories:
- competitive


---
Lizzy's boss has made her in charge of the Palindrome Accentuator(abbreviated as PA) . Initially you have the string s . The PA does the following 2 operations on the string:  

**0 i x**  Change the character at the i<sup>th</sup> position to x.    

**1 l r**  Check whether the substring from l to r is a palindrome or not.  

Lizzy has to note down the readings for the boss for queries of type 2 . She is quite perplexed . Can you help her . 

More formally, you are given a string s and you have to perform the queries described above . For queries of type 2 , if the substring from l to r is palindrome output "Yes" and if it isn't output "No"(without quotes).  

**Inputs**  
The first line contains N and Q-the length of the string and the number of queries to be answered.The next line contains the string s of N characters.The next Q lines are either of the form **0 i x** or **1 l r** - denoting the queries described above.  

**Output**  
For each query of type 2 , output "Yes" or "No" accordingly , the answer for each query on a new line.  

**Constraints**    
1<=N<=10<sup>5</sup>  
1<=Q<=10<sup>5</sup>  
1<=i , l , r <=N    
All the characters in the input are lowercase letters from 'a' to 'z'.
