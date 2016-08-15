---
layout: post
title: Monochrome Tree
date: 2016-08-07 11:25:00 +530
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
You have a tree _T_ (an undirected connected graph containing no cycles) of _N_ nodes rooted at node number *1*. Each node is painted either **White** or __Black__ . You intend to gift this tree to your girlfriend . However , your girlfriend is rather stubborn and will accept it only if it matches the color scheme the one that she has chosen .  

Being the responsible person that you are, you set on re-coloring your tree T. You can do 2 operations on the tree:  
**1.** Paint the i<sup>th</sup> node in the color of your choice,i.e,either black or white.  
**2.** Invert the colors of all the nodes in the subtree rooted at i , i.e, for all the nodes in i’s subtree (including i) , change the nodes colored white to black and change the nodes colored black to white.  

You want to please your girlfriend and also want to do the least possible work. Output the minimum number of operations that you have to perform to change the color scheme of your tree to the one that your girlfriend wants.  

**Constraints**  
1<=N<=100000  

**Input**  
The first line contains a single integer N denoting the number of nodes in the tree.  
The next N-1 lines contain 2 integers u , v  on each line denoting that there is an edge between u and v.  
The next line contains N integers,each integer is either 0 or 1. The i<sup>th</sup> integer denotes the color of the i<sup>th</sup> node. 0 denotes white and 1 denotes black.  
The next line contains N integers , each integer is either 0 or 1. The i<sup>th</sup> integer denotes the color your girlfriend wants the i<sup>th</sup> node to be painted . As above 0 denotes white and 1 denotes black.

**Output**  
Output a single integer:the minimum number of operations needed to performed by you to change the color scheme of your tree to the one your girlfriend wants.
