---
layout: post
title: Andrew and His Bike
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
Andrew recently bought a new motorbike and wants to try it out on the roads of TreeLand. As the name suggests, Treeland is in the shape of a Tree, i.e, **it is an undirected acyclic graph**. Treeland has _n_ junctions connected by _n-1_ roads. It is guaranteed that treeland is connected, i.e, any two junctions are reachable from each other. Andrew is at junction number 1. Andrew wants to ride his bike on a valid path from junction number 1 to another junction (he may even come back to junction number 1). A valid path is one which visits any given junction atmost 2 times.  

There is another constraint for the movement of Andrew on his bike. Let us root the tree at node number 1. Let d(u) be the distance of u from node number 1. Andrew is said to be going _down_ if he moves from an ancestor of u to u directly. Similarly Andrew is said to be going up if he moves from u to an ancestor of u directly.  

Initially when Andrew is at node 1 he moves in the downward direction. Later he may change his direction to upward. However he cannot change it back to downward, i.e, on a valid path Andrew's direction can change atmost once.     

For all v from 1 to n, tell Andrew the number of valid paths from junction numbered 1 to junction numbered v.  

Note that a path must involve Andrew crossing non zero number of edges. Thus, a path beginning at junction number 1 and ending at junction number 1, cannot be only the vertex 1. It must visit some another node and then return back to 1.  

**Input**  
The first line contains a number n denoting the number of junctions.  
The next n-1 lines contain a pair of integers u v denoting there is a road between junction numbered u and junction numbered v.  

**Output**  
Print n space separated integers where the v<sup>th</sup> integer denotes the number of valid paths from junction numbered 1 to junction numbered v.    

**Constraints**  
1<=n<=10<sup>5</sup>  
1<=u,v<=n  
There are no self-loops or multiple edges and it is guaranteed that the tree is connected.  

Note: A road between u and v means one can travel from u to v and vice versa.  
