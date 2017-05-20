---
layout: post
title: "AR navigation"
date: 2016-07-06 16:42:00 +0530
author: I M AI
category: 
tags: 
- summer16
- project
- augmented_reality
categories:
- project

image:
i
---

# [AR Navigation]

### About The Project
We tried out experimenting Augmented Reality as a summer project. Our aim was to design a navigation app which instead of showing top view of map shows directions on real time camera feed. This will have two fold benefits: 

* The users will not have to match roads and adjust map to understand where to go
* Since it shows real time camera feed the user can remain in real world while looking for directions preventing accidents
* Received the **Best Programming Club Project** during the Science & Technology Summer Camp 2016.

### Approach to inculcate AR in android app
Unlike infrared sensors we didn't have any means to calculate the exact distance of the real time objects in the mobiles so we switched to MATHEMATICS for our answers. OH! Technical Arts also played a key role in devising our strategy.
* We used GPS data combiined with mobiles orientation from Magnetic Compass to detect roads. Here Google Directions API came in handy to give the precise coordinates of the roads.
* We measured the relative motion of the user via gyroscope, accelerometer and GPS coordinates
* The Unity graphics were relayed on the camera feed via UNITY GAME ENGINE giving the graphics (navigating arrows) a psuedo-acceleration to look static on the ground.

### References
* [https://www.sitepoint.com/how-to-build-an-ar-android-app-with-vuforia-and-unity/](https://www.sitepoint.com/how-to-build-an-ar-android-app-with-vuforia-and-unity/)
* Android Documentation

-App Demo video link: [https://youtu.be/Cnm6HZRYHeg](https://youtu.be/Cnm6HZRYHeg)  
