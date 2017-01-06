---
layout: post
title: "Installing Ubuntu In Latest Asus Rog PCs"
author: Akash Kumar Dutta
subsection: installfest
hidden: true
---
**Problem occurs due to loading of Nvidia Drivers during booting. Follow the following simple steps.**
1. When the grub boot loader menu is visible highlight “Try Ubuntu GNOME without installing” (use your up and down arrows)
2. Press “e” on your keyboard, this will allow you to edit the boot config.
You will be brought to a page where you can make some edits.
3. add the following right after the word “splash”
    >nouveau.modeset=0 tpm_tis.interrupts=0 acpi_osi=Linux i915.preliminary_hw_support=1 idle=nomwait
4. Press the “f10” key to boot into the installer
5. When the desktop load move your mouse into the upper left hand corner, when the app launcher shows itself click on the very top icon “Install Ubuntu GNOME 16.04 LTS”
6. Do not install third party software.
7. Then follow the steps to install Ubuntu.
8. After installation click “Keep trying Ubuntu”
9. Shut down (NOT RESTART) your computer, remove installation media, hit enter.
10. Hold down shift then press the power button to turn on your computer. (holding down shift while powering on will load the grub boot menu)
11. When the grub boot menu appears press “e” and make the changes in step 3.
12. Press “f10”
13. Once your back into the desktop open your terminal and enter:
    >sudo gedit /etc/default/grub
14. Find the line that reads ‘GRUB_CMDLINE_LINUX_DEFAULT=”quiet splash”‘ and change it to read
    >‘GRUB_CMDLINE_LINUX_DEFAULT=”quiet splash nouveau.modeset=0 tpm_tis.interrupts=0 acpi_osi=Linux         i915.preliminary_hw_support=1 idle=nomwait”‘
15. Save the changes then exit gedit.
16. In your terminal run the command: sudo update-grub
17. Reboot your computer: sudo reboot.
Enjoy UbuntuGNOME!!!!

**Next, we need to install Nvidia Drivers.**
1. Connect to a network
2. Run the command: 
    >sudo apt-get update && sudo apt-get -y upgrade && sudo apt-get -y dist-upgrade
3. Remove all Nvidia installs(if any), run this command: 
    >sudo apt-get purge nvidia*
4. Run the command: 
    >sudo apt-get install nvidia-361-updates nvidia-prime
5. Reboot: 
    >sudo reboot
6. Once logged back in move your mouse to the upper left hand corner of your desktop and start typing “Nvidia”
7. Click on “NVIDIA X Server”
8. On the left side of the Nvidia X Server window you will see an option called “PRIME Profiles”.  This is were you         select which video card you would like to use.

Source: https://jeremymdyson.wordpress.com/2016/04/27/ubuntugnome-16-04-on-asus-rog-gl552v/


