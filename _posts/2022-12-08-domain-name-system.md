---
layout: post
title: "Domain Name System"
date: 2022-12-08 19:44:00 +0530
author: Priydarshi Singh
website: https://dryairship.github.io
category: events
tags:
- networking
categories:
- events

image:
  url: /images/dns.png
---

Have you ever wondered what happens when you type in a website on a web browser? And you must have observed that most websites end with .com, .in, .gov, .org, etc. What do these signify? To answer these questions, we need to understand the Domain Name System (or DNS). Let’s start with understanding how domain names are built.

### Domain Hierarchy

Every domain, like google.com or medium.com, is built hierarchically. Let’s have a look at how it’s done.

![](/images/0__mlJc1336f9UTM9vg.jpg)

The **Root Domain** is an empty string, and the (.) is generally omitted while searching for a website on a browser. DNS doesn’t require this terminating (.), i.e., (google.com.) is the same as (google.com).

**TLD(Top Level Domain)** is everything that follows the final dot of a domain name. For example, in the domain name ‘google.com,’ ‘.com’ is the TLD. Some common TLDs are Generic TLD(gTLD), Country-code TLD(ccTLD), etc.

*   **Generic TLDs (gTLDs)** comprise some common domain names seen on the web and refer to some purpose. For example, a _.com_ is used for commercial purposes, _.org_ for an organization, _.edu_ for education, and .gov for the government.
*   **Country-code TLDs (ccTLDs)** are reserved for use by countries, sovereign states, and territories. Some examples are _.in_ (India), _.uk_ (United Kingdom), _.au_ (Australia), and _.jp_ (Japan).

**_FUN FACT:_** _Did you ever notice that many piracy sites have a ‘.to’ or ‘.hn’ or similar tags in their domain names? These are actually ccTLDs. These are the most suitable TLDs for those sites as countries like Tonga (.to) or Honduras (.hn) either do not have any policy against such sites or any dedicated personnel/body to take these sites down._

**Second-Level Domain** is the part of a domain name or website address that comes before the TLD. For example, google in google.com is a second-level domain.

A **Subdomain** sits on the left-hand side of the Second-Level Domain, using a period to separate it. For example- documents in documents.google.com is a subdomain.

### **IP Addresses**

Every device on the internet has its unique address, called an IP address. An IP address consists of 4 sets of digits (hence also called IPv4) ranging from 0–255(each set is formed by 8 bits), separated by a period(.), and is represented as 204.56.10.259.

![](/images/0__EB1hoH6gfMLSby__M.jpg)

Every URL you visit on the internet is mapped to a similar IP address. In fact, the internet does not understand URLs like google.com or nwm.iitk.ac.in; what it understands are only IP addresses. Try putting [https://202.3.77.93](https://202.3.77.93) in your URL bar and see where it takes you. Despite this, we all know that we are not expected to remember any IP address; then, who does this bookkeeping?

Now, Let’s say you want to visit some website **xyz.com** that is hosted on some computer, and you don’t remember its IP address, but the Internet only understands IP addresses. Here, DNS comes to your rescue. The **Domain Name System** is a huge directory that keeps the records of every single domain name on the Internet and maps it with its IP address. Hence it acts as a translator and converts domain names into IP addresses so that the internet can understand them while increasing convenience for human users.

### DNS Query Route

Before going ahead, let’s understand about nameservers. A **nameserver** is a server where DNS software is installed and works as a directory that translates domain names into IP addresses.

![](/images/0__WwFt8IQNIL2PGdCW.jpg)

When a DNS request is made, the computer first checks its local cache to see if it has the website already stored. Frequently visited websites are stored in the computer’s local caches to reduce loading times. Similarly, multiple such caches are maintained at different levels to reduce the loading time as much as possible. If not, a request to a **Recursive DNS server** (also known as a **recursive resolver**) is made (step 1), which is usually provided by your ISP(Internet Service Provider). The Recursive DNS server also has a set of cached websites where your website might be found. If not, an expansive search begins to find the website with the help of root servers (step 2), and they redirect the search to the respective **TLD server** (steps 3 and 4), which stores the location of the **authoritative servers** of all websites with a given TLD (steps 5 and 6). Authoritative servers contain the website in its original form, with all original files and records being stored there; any server containing a cached version of a webpage is called a non-authoritative server. The search finally reaches its conclusion at the authoritative server, and the query returns to your browser (steps 7 and 8).

**_TRIVIA:_** _Some of you must have noticed that sometimes when the webmail becomes unresponsive (primarily while accessing it from a ‘Jio’ network), changing your ISP helps you access it. Every time this happens, something is wrong with your ISP’s Recursive DNS server._

**ACTIVITY:**

You can view the local DNS cache stored in your computer by using the following commands:

1.  **Windows:** Open your command prompt and enter the command “_ipconfig /displaydns._”
2.  **Mac:** Open the Terminal app, enter the command “_sudo discoveryutil udnscachestats_” or “_sudo discoveryutil mdnscachestats_” and input your password.
3.  **Linux:** Unfortunately for Linux users, Linux does not store the DNS cache automatically.

![](/images/0__m6CDVBdtfirGBo8Z.jpg)

### Proxy Server

Sometimes requests sent to an authoritative server are intercepted by other servers containing a cache of the original website. The difference between this cache and the one on your device (local cache) is that these are operated and maintained by the owner of the authoritative server and functions to reduce stress on the authoritative server by redirecting less traffic towards it. This is called a **transparent proxy server** and is an example of a proxy server.

A **proxy server** is an intermediary between a server providing a resource and a server that contains the resource and has a large number of applications in networking. Proxy servers are used from the user side to bypass firewalls and content restriction and on the server side to balance loads among many servers in a network, encrypt/decrypt data before processing, and to protect against OS-based attacks.

![](/images/0__yztqJsSHOIcItBUx.jpg)

### Conclusion

Hence, each DNS request traverses large amounts of physical distances in its search for the IP address. The search can span multiple countries and continents while locating and reaching the root server, TLD server, and authoritative server before the correct IP address is located to bring back to your browser just in a span of milliseconds. So the next time you sit in front of your browser frustrated waiting for a website to load, remember this and be patient :P.

**_References:_**

[https://tryhackme.com/room/dnsindetail](https://tryhackme.com/room/dnsindetail)  
[https://kripeshadwani.com/domain-name-hosting-expain/](https://kripeshadwani.com/domain-name-hosting-expain/)  
[https://www.educative.io/answers/what-is-dns-hierarchy](https://www.educative.io/answers/what-is-dns-hierarchy)  
[https://ipwithease.com/dns-proxy-detailed-explanation/](https://ipwithease.com/dns-proxy-detailed-explanation/)  
[https://kinsta.com/knowledgebase/what-is-a-nameserver/](https://kinsta.com/knowledgebase/what-is-a-nameserver/)  
[https://en.wikipedia.org/wiki/List\_of\_Internet\_top-level\_domains](https://en.wikipedia.org/wiki/List_of_Internet_top-level_domains)

**_Extra Readings:_**

[https://github.com/alex/what-happens-when](https://github.com/alex/what-happens-when) (Credits: Naman Gupta)

_Authors: Geetika, Varun Tokas  
Editor: Parinay Chauhan_