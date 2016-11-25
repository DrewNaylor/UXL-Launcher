# What is UXL?

UXL (Unified eXecutable Launcher) is the successor to "Drew's App Launcher," and the first stable release will be version 3.0 to show the relationship between Drew's App Launcher (last official release is 2.8.x) and UXL (first official release will be 3.0.)

This software allows the user to launch Microsoft Office apps from one place instead of just using a folder with shortcuts to the apps.

The readme continues after this notice.

<code>UXL Launcher - Launchers for Microsoft Office apps in one place.
Copyright (C) 2013-2016  Drew Naylor
Microsoft Office and all related words are copyright
and trademark Microsoft Corporation.
(Note that the copyright years include the years left out by the hyphen.)</code>

<code>This file is part of UXL Launcher
(Program is also known as "Unified eXecutable Launcher." Not to be confused with
another software titled "[Kindle] Unified Application Launcher".)</code>

<code>UXL Launcher is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.</code>

<code>UXL Launcher is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.</code>

<code>You should have received a copy of the GNU General Public License
along with UXL Launcher.  If not, see <http://www.gnu.org/licenses/>.</code>

<br>
<br>

More information to come in the future! In the meantime, please check the repositories of Drew's App Launcher, linked here:

[Drew's App Launcher 32-bit](https://github.com/DrewNaylor/MSOfficeAppLauncherNext32)

[Drew's App Launcher 64-bit](https://github.com/DrewNaylor/MSOfficeAppLauncherNext64)

<br>
<br>

# Required software.

Please note that in addition to [Microsoft .Net Framework version 4.6.1 (web installer)](https://www.microsoft.com/en-us/download/details.aspx?id=49981), [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159) is required for compiling this software if Visual Studio 2015 is not installed on your computer. [Windows PowerShell 5.0](https://www.microsoft.com/en-us/download/details.aspx?id=50395) is also required to run some of the commands in the UXL Autobuild Script.

# UXL Autobuild Script

UXL Autobuild Script (or UAS) is a Batch script I made for developers and other people who want the latest changes from the Master branch right away. Note that I can't guarantee any stability by going this route rather than sticking with the stable releases, but if you want to use it anyway, I've made a [GitHub Gist with the code pasted into it](https://gist.github.com/DrewNaylor/22e3f1cded702fff494a46dabe643fde). To use the script, simply copy-and-paste the code into Notepad or your favorite text editor and save it as a ".bat" file. When you run the script it will tell you a bunch of important stuff as well as asking you if you want to run it, exit, or view the software required to build the project as written above.
