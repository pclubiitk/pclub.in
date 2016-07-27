---
layout: post
title: "HTML5 Game Development"
date: 2016-07-27 16:05:20 +530
author: Akash Kumar Dutta
website: 
category:
tags:
- tutorial
- game dev
- html5

categories:
- tutorial

image:
  url: 
---
# HTML5 Game Development
For all those gaming nerds out there, there isn't a better way to develop your gaming skills but to start from scratch of how a game works and to build your own one!  
HTML 5 provides rich environment to create your games using Javascript and the html5 canvas object.


### PRE-REQUISITES
Well all you need is to know the basics of html and javascript. And of course a little bit of enthu in the pot is forever welcomed !  :)


### WHY NOT OTHER GAME-ENGINES ?  
We have hundreds of cool game engines in the market, to name few unity ,unreal engine, cryengine, source 2 etc. But here we focus on learning things from the scratch, in engines like these things are more  drag and drop and the essence of how things work from the basic fails to deliver. In this article we discuss things from the very basic !


### GAME CANVAS AND GAME COMPONENTS 
Without much ado, we talk about the canvas object in the html 5 that offers to us the work place for doing all our cool gaming stuffs. To note is that it is a container to hold the graphics content and nothing more. Everything that needs to be done must be defined beforehand unlike the game engines like unity which have predefined objects like planes, spheres etc.  
**Game Components**-We can draw rectangles, circles, lines using the 2D context of canvas object ( in layman's term - drawing in the canvas holder by using its 2 Dimensional object ).We can provide colors to fill , or use gradient colors , or even load images to make animations in the 2d context of canvas object.  
_Reference Code in js-_  
>var canvas=Document.createElement("canvas");  
document.appendChild(canvas);  
var context=canvas.getContext("2D);  
context.fillStyle="red";  
context.fillRect(10,20,30,40);

This creates a color filled red rectangle in the canvas at (10,20) coordinates of 30px as width and 40px as height.


### GAME COMPONENTS AND THEIR MOVEMENT
The importance of these objects is that they can be moved inside the canvas by redrawing them to different positions , this being done per frame ! A separate function is created which helps in drawing the components taking the position as arguments that is called many times a second to update the position of the game components.The position can incremented each time adding a constant or a uniformly increasing function to make the component move uniformly or accelerate respectively.  
The movement is triggered also by adding event handlers through javascript, like "keydown" , "keyup" for keyboard keys, which then can be recognised using the keyCode attribute of the event argument of event -handler function call (see attached reference code) .  
_Reference Code in js-_  
>window.addEventListener('keydown', function (e) {  
	    myGameArea.key = e.keyCode;  
    	})  
//for calling a function callMe at 50 every milliseconds ( or  
//better say 20 frames per second)  
//setInterval(callMe,50); 

Hence by knowing which key is pressed we can call the required functions for action to be taken.



### GAME OBSTACLES AND SCORE
Like other game components game obstacles are also game components but being generated at random coordinates of random shape, the code of which is much the same and i leave it to you :) .  
The score in most of the cases is decided by certain collision events or by the current frame from the beginning of the game.
Its very easy to ascertain the collision between objects exploiting the again the boundary coordinates, and the current frame can be known by ensuring a  counter that is incremented for the function that is called per frame.I leave the job for you to google out the way to write text in canvas element to display the score when needed.

### ALMOST THERE ! 
We  have known  everything to create our first simple html5 game with our own game arena and game components, game obstacles and score to compete !

### LONELY WITHOUT SOUNDS ?  
Well everyone loves the charm when there's music in the air ! Luckily we can have it too in case of html5 "audio" object . Not going into much detail , we can add sound using the following sample code link, which i leave you to dissect.

### LINKS AND FURTHER READING
* [adding sounds](http://home.iitk.ac.in/~akashdut/sounddev.txt)
* [udacity course on html5 game dev](https://www.udacity.com/course/html5-game-development--cs255)
* [udacity course on html5 canvas element](https://www.udacity.com/course/html5-canvas--ud292)
* [w3schools tutorial for html game](http://www.w3schools.com/games/default.asp)




