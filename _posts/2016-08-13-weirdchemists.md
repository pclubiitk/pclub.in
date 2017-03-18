---
layout: post
title: Weird Chemists
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
You run a chemical laboratory which contains **N** beakers containing certain amount of solutions. The i<sup>th</sup> beaker contains a<sub>i</sub> ml of a reactant solution. There also **M** chemists waiting outside your laboratory. Each chemist has a parchment of paper which has 3 integers written on it. The i<sup>th</sup> chemist’s parchment contains 3 integers of the form: **l<sub>i</sub> r<sub>i</sub> x<sub>i</sub>**

It denotes that the i<sup>th</sup> chemist needs atleast x<sub>i</sub> ml of reactant solution but you can only take it from the bottles numbered l<sub>i</sub> to r<sub>i</sub>. If you are able to meet the i<sup>th</sup> chemists needs, he is happy . 

To put it more succinctly, to make the i<sup>th</sup> chemist happy, it should be possible to take some beakers from l<sub>i</sub> to r<sub>i</sub> such that the sum of their solutions is at least x<sub>i</sub>.

Print the number of chemists that returned happy after their transaction with you . 

Please note that a transaction with one chemist is independent of that with another chemist , that is the the values of the beakers doesn’t change for a new transaction. For each transaction consider that the values to be those that were there initially.  

**Input**: 

The first line contains 2 integers N and M.  
The next line contains N integers, the i<sup>th</sup> integer denoting a<sub>i</sub>.  
The next M lines are of the form: l<sub>i</sub> r<sub>i</sub> x<sub>i</sub>  

**Output**:

Output a single integer: the number of happy chemists.  

**Constraints**:

1<=N<= 10<sup>4</sup>  
1<=M<=1000  
1<=ai<=10<sup>4</sup>  
1<=l<sub>i</sub><=r<sub>i</sub><=N  
1<=x<sub>i</sub><=10<sup>9</sup>   
