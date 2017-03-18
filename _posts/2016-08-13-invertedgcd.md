---
layout: post
title: Inverted GCD
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
Given an array a of N numbers , you have to find the number of pair of indices _i_ and _j_ that satisfy the following relation:    
1. i < j       
2. a<sub>i</sub> > a<sub>j</sub>  
3. gcd( a<sub>i</sub> , a<sub>j</sub> )=1  

**Input**  
The first line of the input contains a single integer N - denoting the size of the array.  
The next line contains N space separated integers denoting the array a.  

**Output**    
Output a single integer - the answer to the problem stated above.    

**Constraints**  
1<=N<=10<sup>5</sup>  
1<=a<sub>i</sub><=10<sup>5</sup>  