---
layout: post
title: "N-Body Simulation"
date: 2016-07-31 01:00:00 +0530
author: sagnikb
website: http://sagnikb.github.io/Simulati-ON/
category: 
tags: 
- summer16
- project
categories:
- project

image:
  url: http://raw.githubusercontent.com/sagnikb/Simulati-ON/master/Pics/simulation.jpg

---

# [N-body simulation](http://sagnikb.github.io/Simulati-ON/)

The N-body simulation is an interesting topic in Physics, and finds applications in astrophysics, biomoecular studies and other areas of science. Mathematical soultions of this problem are not possible, so numerical methods are necessary for visualisation. The problem basically involves several bodies with defined properties and also a well defined force that acts between each of these bodies, and involves studying how the system evolves with time. Parallel programming is used for increasing performance, and problems of this type are ideally suited for the parallel programming paradigm.

![image](http://raw.githubusercontent.com/sagnikb/Simulati-ON/master/Pics/simulation_sample.png)

^ This is a screenshot of a simulation in action with 5 bodies. The program works well with 20 bodies.

* OpenACC is used for parallel programming
* Gnuplot is used for visulisation of data
* Performance improvement over sequential code easily apparent
* Uses compiler pgcc. For testing of non parallel programs, the files can also be compiled using gcc

Received the **Best Research Project** during the Science & Technology Summer
Camp 2016.

Website: [http://sagnikb.github.io/Simulati-ON/](http://sagnikb.github.io/Simulati-ON/)  
LaTeX Report: [report.pdf](http://github.com/sagnikb/documentation/report.pdf)  
Github Wiki: [Simulati-ON Wiki](https://github.com/sagnikb/Simulati-ON/wiki)
