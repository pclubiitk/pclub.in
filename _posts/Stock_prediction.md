---
layout: post
title: "Stock Prediction"
date: 2017-01-22 16:00:00 +0530
author: saketharsh
website: http://mlcoderss.github.io/ML-project/
category: Project
tags:
- summer16
- project
- ML
categories:
- project


---


# Stock Market Prediction using Machine Learning
### Summarised Description
This Project predicts closing value of a stock of a particular day in the Stock market, given its value of opening, maximum, minimum and volume of a stock transacted throughtout that day.
* The entire Code has been written in Torch and Lua
* This project implements the basic algorithms of Machine Learning.
* The Data Set used for training the Neural Network can be found [here](http://pages.swcp.com/stocks/).

### Dataset description
The Dataset has been taken from a [data repository] ,which contains details of more than one lakh stock transactions over the year. Our dataset just contains 20,232 stocks of which 10,232 has been used as Training Set and remaining as Validation Set. We have ignored dates and Company Tickers as they are not useful for us to calculate our desired output. One can see how we have done it in [stock_function.lua].
Our model contains two hidden layer.One has 70 neurons and other one has 50 neurons.  
This model applies [Tanh](https://github.com/torch/nn/blob/master/doc/transfer.md#tanh) function. 
Tanh is defined as f(x) = (exp(x)-exp(-x))/(exp(x)+exp(-x))
 We have used MSECriterion(Mean Squared Error) for our loss function. Since we are not intersted in backpropagation. One can find about this criterion [here](https://github.com/torch/nn/blob/master/doc/criterion.md).
The training set has been trained by "**step**" function.The code for it is simple and can be understood after going through the Turorials given above. We have used batches of **batch_size = 200** .
**eval** function gives us accuracy calculated after testing validation set with the parameters we got after training trainingset in "**step**" function.After iterating the same datasets for **200** times or (200 epochs) we have saved the final parameters of model in other file **model.net**. This helps us to use these parameters any other time without iterating over 200 times. This file has been used in files like [final_output.lua] and [graph_output.lua].


![ScreenShot](https://github.com/MLcoderss/ML-project/raw/master/Screenshot%201.png)



   
   
 
  
  ![ScreenShot](https://github.com/MLcoderss/ML-project/raw/master/Screenshot%203.png)
  
  ^ This is a screenshot of the deviation of our predicted values from the original data.


 Contributors:-  Aditya Katara    Palash Agarwal    Piyush Bansal    Saket Harsh
 Website : http://mlcoderss.github.io/ML-project/


[//]: # 
   [Torch]: <https://github.com/torch/torch7/wiki/Cheatsheet>
   [Andrew NG]: <https://www.coursera.org/instructor/andrewng>
   [Coursera]: <https://www.coursera.org/learn/machine-learning>
   [neural networks]: <http://neuralnetworksanddeeplearning.com/>
   [Michael Nelson]: <http://michaelnielsen.org/>
   [rnduja blog]: <http://rnduja.github.io/2015/10/13/torch-mnist/>
   [Dataset.txt]: <https://github.com/MLcoderss/ML-project/blob/master/Dataset.txt>
   [data repository]: <https://github.com/MLcoderss/ML-project/blob/master/sp500hst.txt>
   [stock_function.lua]: <https://github.com/MLcoderss/ML-project/blob/master/stock_function.lua>
   [core_function.lua]: <https://github.com/MLcoderss/ML-project/blob/master/core_function.lua>
   [optim]: <https://github.com/torch/optim>
   [optim.sgd]: <http://torch.ch/docs/five-simple-examples.html#4-using-the-optim-package>
   [final_output.lua]: <https://github.com/MLcoderss/ML-project/blob/master/final_output.lua>
   [graph_output.lua]: <https://github.com/MLcoderss/ML-project/blob/master/graph_output.lua>
   
