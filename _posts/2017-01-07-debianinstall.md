---
layout: post
title: "Install Fest: Debian"
date: 2017-01-07 00:57:00 +530
author: milindl
subsection: installfest17
hidden: true
image:
    url: https://i.imgur.com/LqVGmO0.png
---


# Installing Debian Jessie

This is almost the same for debian stretch. 

## References: 

1. Official [InstallationHowto](https://d-i.debian.org/manual/en.i386/apa.html)
2. [Turning off FastBoot](http://acer--uk.custhelp.com/app/answers/detail/a_id/37059/~/windows-10%3A-enable-or-disable-fast-startup)
3. Look at [turning off Secure Boot](https://technet.microsoft.com/en-in/library/dn481258.aspx)
4. Make some [free space](https://technet.microsoft.com/en-us/library/gg309169.aspx)

## Steps

1. Get bootable drive.
2. Make free space of at least 8 - 10 GB.
3. Turn off FastBoot and then Secure Boot.
4. Boot using the Installation USB.
5. Select "Graphical Install" or "Install"
![one](http://i.imgur.com/LqVGmO0.png)
6. Select language, location, keymap(American English works)
![two](http://i.imgur.com/BFPDHee.png)
7. Let it detect network hardware. If you're using a LAN cable with a properly
   configured router(recommended), it should detect DHCP automatically. If not, you
   can set it up manually(like you set for your room). LAN cable is still recommended, 
   since wireless may not work out of the box.
![three](http://i.imgur.com/8ec3Zkn.png)
8. Enter hostname (your choice).
9. Make a root(admin) password. You can leave this empty(which is absolutely OK, since the system
   then makes your user a 'sudo-er' (you can perform actions as root using 'sudo' command).
![four](http://i.imgur.com/ocd8NcX.png)
10. Setup your user. Enter name, username, password. 
11. Let the clock be setup and wait for the partioner to open.
12. Choose the 'Manual' method for partitioning. 
![five](http://i.imgur.com/1Esfyqr.png)
13. Select the partition with free space that you've just created in step 2. Select 'Automatically 
    Partition the free space' and proceed. Select 'All Files in new partition'. 
![six](http://i.imgur.com/lKYJsji.png)
14. Finish partitioning and write the changes to disk.
![seven](http://i.imgur.com/Y63c7tI.png)
15. Configure the package manager to not scan any extra CD/DVD.
16. You can select a network mirror if you want, but if you're using a DVD, it is not needed.
    If you do use one, select 'India' as your country and iitk as your mirror.
17. Choose whether you want to take part in a user survey.
18. Select the software you want to install (GNOME or another DE is recommended).
![nine](http://i.imgur.com/onZRZQa.png)
19. Choose whether to use nonfree and contrib software (you can, it usually helps).
![ten](http://i.imgur.com/x4AXqU2.png)
20. Install grub. It should detect MS Windows. If not, you can always set it up later
    (This won't erase Windows!) 
![eleven](http://i.imgur.com/dm8wzsX.png?1)
21. Choose your hard drive (usually /dev/sda) when choosing where to install grub.
![twelve](http://i.imgur.com/mIxydte.png?1)
22. Installation is complete, reboot.
