---
layout: post
title: "Installing Ubuntu 18.04 In Latest Asus Rog PCs"
author: Mohit Kumar Singh
date: 2019-03-21 09:00:00 +530
subsection: installfest17
hidden: true
---

**Problem occurs due to loading of Nvidia Drivers during booting. Follow the following simple steps.**

1. When the grub boot loader menu is visible highlight “Try Ubuntu GNOME without installing” (use your up and down arrows)

2. Press “e” on your keyboard, this will allow you to edit the boot config.
You will be brought to a page where you can make some edits.

3. add the following right after the word “splash”\
    `nouveau.modeset=0 tpm_tis.interrupts=0 acpi_osi=Linux i915.preliminary_hw_support=1 idle=nomwait`

4. Press the “f10” key to boot into the installer

5. When the desktop load move your mouse into the upper left hand corner, when the app launcher shows itself click on the very top icon “Install Ubuntu GNOME 18.04 LTS”

6. Do not install third party software.

7. Then follow the steps to install Ubuntu.

8. After installation click “Keep trying Ubuntu”

9. Shut down (NOT RESTART) your computer, remove installation media, hit enter.

10. Hold down shift then press the power button to turn on your computer. (holding down shift while powering on will load the grub boot menu)

11. When the grub boot menu appears press “e” and make the changes in step 3.

12. Press “f10”

13. Once your back into the desktop open your terminal. Press `Ctrl+Alt+T` if touch pad is not working and enter:\
    `sudo gedit /etc/default/grub`

14. Find the line that reads ‘GRUB_CMDLINE_LINUX_DEFAULT=”quiet splash”‘ and change it to read\
    `‘GRUB_CMDLINE_LINUX_DEFAULT=”quiet splash nouveau.modeset=0 tpm_tis.interrupts=0 acpi_osi=Linux i915.preliminary_hw_support=1 idle=nomwait”‘`

15. Ignore this step if touchpad is working else add `i8042.reset` to read:\
    `‘GRUB_CMDLINE_LINUX_DEFAULT=”i8042.reset quiet splash nouveau.modeset=0 tpm_tis.interrupts=0 acpi_osi=Linux i915.preliminary_hw_support=1 idle=nomwait”‘`

16. Save the changes then exit gedit.

17. In your terminal run the command: sudo update-grub

18. Reboot your computer: sudo reboot.

19. The PC may hang at this point which means the OS doesn't support restart with dual boot.

20. Force switch off the PC from power button and on next boot follow steps 13-17 and add `acpi=force` in step 14/15 to read: \
    `‘GRUB_CMDLINE_LINUX_DEFAULT=”quiet splash nouveau.modeset=0 tpm_tis.interrupts=0 acpi_osi=Linux i915.preliminary_hw_support=1 idle=nomwait acpi=force”‘`

Enjoy UbuntuGNOME!!!!

**Next, we need to install Nvidia Drivers.**

1. Connect to a network

2. Remove all Nvidia installs(if any), run this command: \
    `sudo apt-get purge nvidia* & sudo apt autoremove & sudo apt auto-clean`

3. Open the file `sudo vim /etc/modprobe.d/blacklist.conf` and add these lines at the end:
    ```
    blacklist nouveau
    blacklist vga16fb
    blacklist rivafb
    blacklist nvidiafb
    blacklist rivatv
    blacklist amd76_edac
    alias nouveau off
    alias lbm-nouveau off
    options nouveau modeset=0
    ```

4. Add the PPA graphic drivers:\
    `sudo add-apt-repository ppa:graphics-drivers/ppa`

5. Check recommended drivers:\
    `ubuntu-drivers devices`

6. AutoInstall recommended drivers:\
    `sudo ubuntu-drivers autoinstall`

7. If secure boot is not switched off, while installing it asks for a password, enter and remember it. Shutdown the PC 
   (DONT RESTART).

8.  Go to step 11 if secure boot is already disabled else on grub menu select `system setup` to open boot manager.

9. Switch off secure boot (use right left arrow to switch tabs, enter to select and esc for back in boot manager):\
    `security tab->secure boot->secure boot controller-> disabled`

10. Press F10 to Save and exit.

11. Verify Nvidia installation (shows a nice table with nvidia hardware and driver specs):\
    `nvidia-smi`

12. Use "nvidia-X-server" from applications or following command to select profile for next boot (available profiles are intel and nvidia)\
    `sudo prime-select nvidia`

13. If you are not a beginner and wish to switch profiles without reboot use: https://github.com/matthieugras/Prime-Ubuntu-18.04.

**Potential Problems**

If anything goes wrong during driver installation, you are likely to get a black screen. In that case follow these steps to 
uninstall nvidia:

1. Try "Ctrl+Alt+F1". if console opens simply login and go to step 5 else force shutdown the PC.

2. Hold shift and power on the computer.

3. Select "advanced options" and then "recovery mode".

4. Select root and press enter key twice. You will be dropped in root shell.

5. Run this command\
    `apt purge nvidia*`

6. Reboot\
    `reboot`

7. You can either retry the above steps to install nvidia-drivers or use ubuntu with intel card.

Windows update which requires multiple restarts would be problem because grub selects ubuntu as default. This may lead to
crashing of windows. Switching OFF automatic updates is RECOMMENDED. In case, you want to do an update :

1. Make windows first boot option from boot manager.\
    `Grub->system setup->boot tab->change boot order(swap 1st and second option)`

2. Perform the update and shut down the PC.

3. Press `esc` repeatedly to open boot menu. Select `enter setup`.

4. Restore the boot tab to previous settings.

Source: https://jeremymdyson.wordpress.com/2016/04/27/ubuntugnome-16-04-on-asus-rog-gl552v/
