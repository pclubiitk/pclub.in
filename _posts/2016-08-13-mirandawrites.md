---
layout: post
title: Miranda Writes
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

image:
  url: 
---
Miranda lives in a city containing N junctions and M bidirectional roads between some pairs of these junctions.Miranda is a programming enthusiast - though in  her spare time she does make time for a bit of creative writing . She takes part in Individual Creative Penning Contest organized by the Annual Cultural Melange (ACM ICPC) . The competition is on Sunday and it is already Saturday . Miranda realizes she needs to buy K items for her competition tomorrow . Each of these K items can be found in exactly one junction in her city.  

Miranda has to starts from her school which is located in junction number 1 and ultimately must reach her home , in junction number N . On her way , Miranda must visit each of the K junctions that keep the materials required for her competition . Miranda can visit these K junctions in any order , and in doing so can cross a particular city multiple times if she needs to .   

You must find the minimum distance that Miranda must cover from her school to home such that she visits each of the K junctions atleast once.  

**Input**  
The first line contains the integers N,M and K.  
The next M lines are of the form : _u v c_ which denotes there is a bidirectional road joining u and v which is of length c.  
The next line contains K integers-the numbers of the junctions that Miranda has to visit on her path .  

**Output**  
Print a single integer-the answer to the problem stated above.  

**Constraints**  
2<=N<=400  
1<=M<=N*(N-1)/2    
0<=K<=15   
1<=u,v<=N,1<=c<=1000    
None of the K junctions that has the material that Miranda needs is 1 or N.
