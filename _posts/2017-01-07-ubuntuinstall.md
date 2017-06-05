---
layout: post
title: "Install Fest: Ubuntu"
date: 2017-01-07 00:50:00 +530
author: Anmol Porwal
subsection: installfest17
hidden: true
---

## Ubuntu installation guide

* Insert the bootable USB stick, reboot the system and instruct the **BIOS** to boot from the USB by pressing a special function key (usually **F1**, **F2** **F9**, **F10**, **F12** or maybe **del** depending on your device) after the boot up a new grub screen should appear on the screen. From the menu select **Install Ubuntu** and press **Enter**.

* After this a completely functional Ubuntu system running in live-mode will start up. On the launcher on left side hit on the second icon from top, **Install Ubuntu 16.04 LTS**, and the installer utility will start. Choose language and hit **Continue**.
* In **Preparing to install ubuntu** click **Continue**.


 ![](https://s24.postimg.org/fc1lev4tx/1.png)
 
 
 
* In **Installation type** check the **Something else** option and hit on **Continue** button to proceed furthur.

 ![](https://s24.postimg.org/qcwqjvx2t/2.png)

* Now we create three partitions one for **_root_**, one for **_swap_** and other for **_home_**. To create the swap partition and the **_root_** partition select the free space (the shrink space from windows created earlier) and hit on the **+** icon below one by one. Swap partition is for when RAM gets depleted so if you have RAM greater than 8 GB, feel free to leave making the swap partition. On partition settings use the following configurations and hit **OK** to continue:
         
         Size = 4096 MB
         Location for the new partition = Beginning
         Mount = swap area

         Size = at least 20000 MB
         Type for the new partition = Primary
         Location for the new partition = Beginning
         Use as = EXT4 journaling file system
         Mount point = /

 ![](https://s24.postimg.org/oz53okxth/3.png)

 ![](https://s24.postimg.org/h7odq0to5/4.png)
 
* Create the **_home_** partition using the same steps as above. Use all the available free space left for home partition size. The partition settings should look like this:

         Size = all remaining free space
         Type for the new partition = Primary
         Location for the new partition = Beginning
         Use as = EXT4 journaling file system
         Mount point = /home

   ![](https://s24.postimg.org/69d47u52t/5.png) 

* Hit the **Install Now** button to apply changes and start the installation process. Again a pop-up window will appear, hit **Continue** to write changes to disc and the installation process will now begin.
* Next select a nearby city and hit **Continue**.
* Next select **keyboard layout** and hit **Continue**.
* Fill up the **Who are you?** window and hit **Continue**. From here installation process will run automatically till it reaches the end.
 ![](https://s24.postimg.org/fv6oo4w8l/6.png)


* After installation restart the system and choose **Ubuntu 16.04** from the **Grub** menu and now you can enjoy the vivid features of **Ubuntu**.
