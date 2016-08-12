---
layout: post
title: Om Nom and Candies
date: 2016-08-13 00:25:00 +530
author: Arjun Sinha
website:
category:
tags:
- competitive
categories:
- competitive

image:
  url: 
---
There are **N** boxes. The i<sup>th</sup> box contains a<sub>i</sub> candies. The frog Om Nom is sitting in box number 1. Om Nom wants to collect as many candies as he can. However, Om Nom jumps in a peculiar fashion. Om Nom can jump from box number **j** to box number **i** only if _j divides i_. Whenever Om Nom lands in a box, he collects all the candies in that box. You have to report the maximum number of Candies that Om Nom can collect for all i from 1 to N if i is the last box that Om Nom visits.See the samples for more details.    

**Constraints**  
0<=a<sub>i</sub><=100000  
1<=N<=100000   

**Input**  
The first line contains the number N.  
The second line contains the array a , the i<sup>th</sup> integer denoting the number of candies in the i<sup>th</sup> box.  

**Output**  
Print N integers-the i<sup>th</sup> integer should be the maximum number of candies that Om Nom can collect if the i<sup>th</sup> box is his final box (i.e his sequence of jumps ends at i).  

