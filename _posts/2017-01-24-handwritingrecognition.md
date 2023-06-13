---
layout: post
title: "Handwriting Recognition using Machine Learning"
date: 2016-01-24 10:00:00 +0530
author: pritesh
website: http://prathamv28.guthub.io/
category: Project
tags:
- summer16
- project
categories:
- project

image:
  url: /images/mnist_100_digits.png

summary: "Using neural networks and optimization the model learns the similarities of the training datasets which have a common result"

---

# [Handwriting Recognition using Machine Learning](http://prathamv28.github.io/)

Handwriting recognition (or HWR[1]) is the ability of a computer to receive and interpret intelligible handwritten input from sources such as paper documents, photographs, touch-screens and other devices. Machine Learning is incorporated to solve this interesting problem. Using neural networks and optimization the model learns the similarities of the training datasets which have a common result. Spell corrector is also incorporated to increase accuracy upto 97%.

![image](http://neuralnetworksanddeeplearning.com/images/mnist_100_digits.png)


 The program was developed on Lua using Torch libraries like image, nn, optim, etc to detect Handwritten text. Given image of a paragraph as input it can segment various lines and then further each line into individual alphabets including spaces and further recognize them. To increase the accuracy of the output, a spell corrector was incorporated in the program. Using a million words from Sir. Arthur Conan Doyle ’s novel and words from dictionary, a database was created, through which recognized words were compared by applying methods like Bayes’ Theorem the correct word was replaced.

A database was made as a table in Torch using only images of alphabets android digits. In order to expand the database, letters were also rotated by +10 degrees and -10 degrees and added to the database hence constituting more than 10,000 training images. More than 500 images were also maintained as test images to check accuracy

Received the **Special Mention** during the Science & Technology Summer Camp 2016.

Website: [http://prathamv28.github.io/](http://prathamv28.github.io/)
LaTeX Report: [report.pdf](https://github.com/pritesh1996/Handwriting-Recognition/blob/master/Handwriting%20Recognition%20Report.pdf)
Github Wiki: [Simulati-ON Wiki](https://github.com/pritesh1996/Handwriting-Recognition/blob/master/README.md)

