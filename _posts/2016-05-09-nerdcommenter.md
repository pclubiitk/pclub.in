---
layout: post
title: "NERDCommenter"
date: 2016-05-09 23:35:20 +0530
author: Yash Srivastav
website: http://yashsriv.github.io
category: Vim
tags:
- vim
- tutorial
categories:
- tutorial
- vim

image:
  url: https://vim.sexy/img/Vimlogo.svg

---

# Plugin: [NERDCommenter](https://github.com/scrooloose/nerdcommenter)

[NERDCommenter](https://github.com/scrooloose/nerdcommenter) is an awesome
plugin for commenting code. It works primarily
in the normal mode and is aimed at more efficient coding and debugging.

What it does is allow you to comment out a line in any file using the
same keybindings. Let's say you want to have the shortcut to comment
out a line as `//` because that is easy to type. Now for a block of
code, you go to a particular line and press `//`, the line gets commented.
You press `//` again, the line gets uncommented into the `before` state.
This adds a very powerful tool to your workflow allowing you comment
out as well as comment in lines very fast. You could also type something
like `5//` to comment out 5 lines.

This is what would happen:

| Filetype | Before | After |
| :------: | :----: | :---: |
| C | `int a = 5;` | `//int a = 5;` |
| Python | `a = 5;` | `#a = 5;` |
| .vimrc | `set rnu` | `"set rnu` |

## Installation
For vim-plug, add the following line to your `.vimrc`:
{% highlight vim %}
Plug 'scrooloose/nerdcommenter'
{% endhighlight %}

## Configuration
Read the `README.md` as well as `:help commenter` for a complete description
of features. If you are wondering what is `<leader>`, it is a special `power-key`
in vim with default value `\`. You can change it to whatever you like. Now to get
the setting we discussed before, i.e., fast commenting out and in using `//`.

In the [README](https://github.com/scrooloose/nerdcommenter/blob/master/README.md),
you will find that `<leader>c<space>` has the behaviour we want
of toggling comments. So in order to have that same command for `//`, you will
need to map `//` to it:

{% highlight vim %}
nmap // <leader>c<space>
vmap // <leader>cs
" I map // to <leader>cs for sexy commenting instead of the normal
" It is my own setting and you may wish to change it to <leader>c<space> or <leader>ci
{% endhighlight %}

And now open up your favourite file and try this out. It is very efficient and something
very valuable to my current workflow. I have found myself pressing `//` on someone else's
machine to comment code ( which usually works in C :P ) many times.

## Further Reading

In order to understand, why we used `nmap`
you might want to [Learn Vimscript](http://learnvimscriptthehardway.stevelosh.com/).
Its not compulsory, but it allows you to modify vim to your settings more easily.
