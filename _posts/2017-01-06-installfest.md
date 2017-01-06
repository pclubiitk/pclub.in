---
layout: post
title: Linux Install Fest
date: 2017-01-06 20:25:00 +530
author: Coordinators
website: pclub.in
category: installfest
section: installfest
tags:
- linux
---

# Introduction

Hi all, welcome to the Programming Club Linux Install Fest 2017!

These are the list of posts for each individual OS:
{% for post in site.posts %}
  {% if post.subsection == page.section %}
  - [{{ post.title }}]({{post.url}})
  {% endif %}
{% endfor %}
