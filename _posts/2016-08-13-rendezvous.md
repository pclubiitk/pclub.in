---
layout: post
title: Rendezvous
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
The city Manyonok has **N** substations . The substation numbered 1 houses the mayor Alisa. Each substation has a chief who is in charge of the functioning of that particular substation.  Due to an emergency the Alisa has decided to call all her chiefs to substation number 1.   

There are **M** roads forming a road network between the **N** substations . Initially all the roads are closed . The cost of opening the road joining _u_ and _v_ is denoted by _c(u,v)_ . The mayor Alisa has to bear this cost.  

Alisa's city Manyonok , like many other cities are running a bit of a debt . As a result she wants you to find out the _minimum cost incurred by her_ for all the chiefs from substations 2 to N to come to substation number 1.  

**Constraints**  
1<=N<=100000  
1<=M<=100000  
1<=u,v<=N  
1<=c(u,v)<=10<sup>9</sup>  

**Input**  
The first line contains the integers N and M.  
The next M lines are of the form : u v c(u,v)  
It is guaranteed that the graph has no self-loops,multiple edges and is connected.

**Output**  
Print a single integer - the minimum cost incurred by Alisa so that all the chiefs can come to substation number 1.    



