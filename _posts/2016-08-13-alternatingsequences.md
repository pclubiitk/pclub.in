---
layout: post
title: Alternating Sequences
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
Given an array **a** of **N** integers a<sub>1</sub>, a<sub>2</sub>, a<sub>3</sub>, ...  a<sub>N</sub> you have to find the longest alternating sub-sequence of this array .  

An alternating sequence b<sub>1</sub>, b<sub>2</sub> ... b<sub>k</sub>, k>=1 is a sequence that has the 2 following properties:  
1.|b<sub>1</sub>|<|b<sub>2</sub>|<|b<sub>3</sub>|<.....<|b<sub>k</sub>|  
2. The signs alternate between adjacent elements, i.e, if b<sub>1</sub> > 0 then b<sub>2</sub><0, b<sub>3</sub> >0 and so on.
Alternatively, if b<sub>1</sub><0, then b<sub>2</sub>>0, b<sub>3</sub><0 and so on.

A sub sequence of array a is a sequence obtained by dropping some elements of the array **a**.  
[Here is the formal definition.](https://en.wikipedia.org/wiki/Subsequence)  

It is guaranteed that the array **a** contains no element equal to 0.

**Input**:

The first line contains a single integer **N**, denoting the size of the array.  
The next line contains **N** integers , denoting the array **a**.  

**Output**:

Print a single integer - the length of the longest alternating sub-sequence.  

**Constraints**:
1<=**N**<=5000  
|a<sub>i</sub>|<=10<sup>9</sup>, a<sub>i</sub> not equal to 0  