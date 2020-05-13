---
layout: post
title: "A Beginner's Guide To Bootstrap"
date: 2017-08-19
author: Lakshay Bandlish
website:
category: Starter Guide
tags:
- Bootstrap
- Web development
- Front-end

categories:
- Bootstrap
- webpage formatting

image:
  url: https://1.bp.blogspot.com/-oELmi1THp2g/WTu70oXq_YI/AAAAAAAADco/Ij3KkNbuN54YCMkNbgBG6zwY43XGyjm-gCLcB/w800-h800/bootstrap.jpg
---

## A BEGINNER’S GUIDE TO BOOTSTRAP:
_(This article assumes that you are acquainted with HTML and css. if not, Refer [this article](http://pclub.in/lecture/web%20development/2016/09/24/webdev1.html#disqus_thread) and practice some HTML, css before reading this.)_

_Bootstrap is an open-source free project. Here is the link to its [github repository](https://github.com/twbs/bootstrap) ._

### *Introduction:*
From the bootstrap official website [getbootstrap.com](www.getbootstrap.com),

>"Bootstrap is the most popular HTML, CSS, and JS framework for developing responsive, mobile first projects on the web.”


In simple words, bootstrap is a framework for front-end web development (in simpler words, designing webpages). Bootstrap is extensively used for formatting webpages. 


So what exactly does Bootstrap do? Well, bootstrap is a collection of .css and .js files (and some fonts), with well defined classes for constructing almost all types of website formatting effects. Let’s consider an example. Say you want to create a navigation bar on the top of your webpage with links like ‘home’, ’about’, ’team’, 'behind the scenes' etc. Bootstrap enables you to do this with a few lines of code (you will also have to link bootstrap css files for this to work in your webpage, more on that later.)-  

![navbar basic example](http://i.imgur.com/XdbJ25M.png)

The code for this is pretty basic:
```html
<nav class="navbar navbar-inverse">
    <div class="navbar-header">
      <a class="navbar-brand" href="#">WebSiteName</a>
    </div>
    <ul class="nav navbar-nav">
      <li class="active"><a href="#">Home</a></li>
      <li><a href="#">About</a></li>
      <li><a href="#">Team</a></li>
      <li><a href="#">Behind the scenes</a></li>
    </ul>
</nav>
```
Making the same navigation bar with css is quite difficult. But with bootstrap its pretty straightforward. Add ‘navbar-fixed-top’ as another class to nav html tag and now the navigation bar will remain fixed to the top of the webpage even if you scroll down the webpage, pretty much like [this site](https://trakt.tv/). Bootstrap has many such classes as navbar, and I will talk more about that later in this article.

### _Adding bootstrap to your webpage:_
You can do this by two methods, both of which are explained below:

* By Downloading bootstrap package.
* By Using CDNs (Content Delivery Networks)

#### By Downloading bootstrap package
_(This section has been picked up from [here](http://getbootstrap.com/getting-started/))_

You can install bootstrap using [bower](https://bower.io/)
```bash
$ bower install bootstrap
```
Using [npm](https://www.npmjs.com/) _(recommended for linux users)_
```bash
$ npm install bootstrap@3
```
Install with [composer](https://getcomposer.org/)
```bash
$ composer require twbs/bootstrap
```
These commands download bootstrap onto your system or server. Inside the bootstrap folder, the css files, js files and fonts are stored. These files contain the code that specifies the attributes of various classes that we can directly use in our html code. For eg., the bootstrap class navbar, that we used in the previous code has its attributes defined in the file bootstrap.min.css. This means that when we specify the class as navbar, the associated css attributes for it are extracted from bootstrap.min.css by the browser. But for this to happen, we need to specify that the css code be used from the bootstrap.min.css file. This is done by adding this file as stylesheet to the html code. The code for this is pretty trivial:

```html
<link rel="stylesheet" type="text/css" href="<path-to-file>/bootstrap.min.css">
```
With this line added to the code mentioned before, you can create your own page with a navbar.

#### By using CDNs

From [Webopedia](www.webopedia.com):
>"A content delivery network (CDN) is a system of distributed servers (network) that deliver pages and other Web content to a user, based on the geographic locations of the user, the origin of the webpage and the content delivery server."

We can use CDNs to import bootstrap files onto our program. One famous CDN is maxcdn, here is an example to import a bootstrap css file using maxcdn:

```html
<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css">
```

CDNs provide a very easy way to use bootstrap in webpages.

_You might have observed that many bootstrap files have .min.css or .min.js extensions. Well, these files are called minified files (and hence the min in the name). A minified css file is like any other css file except that it has been recreated in such a way that it occupies minimum space. All the unnecessary spaces, tabs, newlines and other formatting elements have been eliminated, such that these files can easily be interpreted by the browser but can't be easily read by humans._
<br/>


### _Some useful bootstrap components:_

* [Bootstrap buttons](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-buttons.php)
* [Bootstrap tables](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-tables.php)
* [Bootstraps lists and list groups](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-lists.php)
* [Bootstrap forms](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-forms.php)
* [Bootstrap Media objects](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-media-objects.php)
* [Bootstrap Icons](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-icons.php)
* [Bootstrap Panels](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-panels.php)
* [Bootstrap Jumbotron](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-jumbotron.php)
* [Bootstrap Modals](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-modals.php)
* [Bootstrap Dropdowns](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-dropdowns.php)
* [Bootstrap Tooltips](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-tooltips.php)
* [Bootstrap Popovers](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/bootstrap-popovers.php)


### _The Bootstrap Grid System:_

If there is one thing to which most of the popularity and utility of boootstrap  can be attributed to, then it has to be the grid system. This grid system is what helps bootstrap to create beautifully and elegantly formatted webpages for all screen sizes. Mobile ready webpages can be easily created using this grid system. This is how it works:

The grid system is based on a 12 column layout. This means all of the screen width is divided into 12 equal parts each pertaining to one column.  

The basic structure of any bootstrap grid is a collection of multiple rows containing multiple columns each. The number of columns in one row is independent of the number of columns in the other. All the rows are put into a divison with the 'container' class. The screen sizes have been divided into 4 main categories:
* large (lg)
* medium (md)
* small (sm)
* extra-small (xs)

The 4 column sizes corresponding to the size of the screens are:
* col-lg-1
* col-md-1
* col-sm-1
* col-xs-1  
_(Here the number 1 represents that 1 column is being taken into consideration)_

Now, the utility of dividing the screen into 12 columns is that, for defining a grid, we can assign a fixed number of columns to a grid component. This way the width of the screen can be divided among individual grid components.

Therefore, to form a grid of 3 elements that covers the entire width of the screen, we will need to provide 4 columns to each element (if we want all those elements to occupy equal size). The following code will work:

```html
<div class="container">
    <div class="row">
        <div class="col-md-4">First column group</div>
        <div class="col-md-4">Second column group</div>
        <div class="col-md-4">Third column group</div>
    </div>
</div>
```
_(col-md-4 assigns 4 columns of the medium-sized(md) screen to the First column group)_

![Imgur](http://i.imgur.com/mMBTYiE.png)

A very important feature of bootstrap grids is column wrapping. This means, that if you try to put more than 12 columns in a particular row, then the last columns will wrap and appear below the initial columns.

```html
<div class="container">
    <div class="row">
        <div class="col-md-4">First column group</div>
        <div class="col-md-4">Second column group</div>
        <div class="col-md-4">Third column group</div>
        <div class="col-md-4">Fourth column group</div>
        <div class="col-md-4">Fifth column group</div>
    </div>
</div>
```
![Imgur](http://i.imgur.com/ypLFOjH.png)

Open **[this link](https://www.tutorialrepublic.com/codelab.php?topic=bootstrap&file=three-column-grid-layouts-for-tablets-in-landscape-mode-and-desktops)** and see a similar code in action. Click on the button next to the "show output" button to open the output in a new tab. This is where you will see the true power of the grid system of bootstrap. Resize your browser window, and see how the columns wrap up. This is because you changed your screen size, and now its width isn't the old 12 col-md-1 columns. It has reduced and now the elements will wrap up. This is what makes bootstrap so powerful for web designers as they can now make webpages that are responsive and look good. It also makes webpages easy for the user to navigate through.

#### Using the bootstrap grid system to create mobile friendly webpages

```html
<div class="container">
    <div class="row">
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">First column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Second column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Third column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Fourth column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Fifth column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Sixth column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Seventh column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Eighth column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Ninth column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Tenth column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Eleventh column group</div>
        <div class="col-lg-3 col-md-4 col-sm-6 col-xs-12">Twelveth column group</div>
        
    </div>
</div>
```
Here we have declared multiple classes (col-lg-3, col-md-4, ..) for div. This ensures that a grid component occupies different number of columns on an extra small screen than a large screen. On a phone, only col-xs-12 will be considered as the class during column assignment to the grid component, while on a large screen, col-lg-3 will be considered. This is how mobile friendly pages can be created using bootstrap.

There is a lot more to grids, we can provide grid offsets, which can be used to leave blank space between different columns. We can also nest rows into columns.


### _Conclusion and Further Reading:_
Bootstrap is one of the easiest webpage development packages. It is a very useful package to accomplish almost any formatting task. I recommend that you read about all the bootstrap components I mentioned like buttons, forms, icons, and modals. When you are comfortable with the topics, start making your own webpages. It takes a great deal of practice to be a good front-end designer. Now, for some inspiration as to what you can create with bootstrap, check out this bootstrap [official link](http://expo.getbootstrap.com/), where you will find some amazing applications of bootstrap tools for creating some mind-blowing websites!
Here are some sources from where you can learn more about bootstrap:
* [Tutorial Replublic bootstrap](https://www.tutorialrepublic.com/twitter-bootstrap-tutorial/)
* [w3 schools bootstrap](https://www.w3schools.com/bootstrap/)
* [Official bootstrap documentation](https://getbootstrap.com/docs/4.0/getting-started/introduction/)    


>“Digital design is like painting, except the paint never dries.”  
>
>
> -- <cite style="text-align:right">Neville Brody</cite>
