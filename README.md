# What is UXL Launcher?

UXL Launcher (Unified eXecutable Launcher) is the successor to "Drew's App Launcher," and the first stable release will be version 3.0 to show the relationship between Drew's App Launcher (last official release is 2.8.x) and UXL Launcher (first official release was 3.0.)

UXL Launcher allows the user to launch Microsoft Office apps from one place instead of just using a folder with shortcuts to the apps.

The readme continues after this notice.

<code>UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
Copyright (C) 2013-2017  Drew Naylor
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

# Known issues.

[See all known issues.](https://github.com/DrewNaylor/UXL-Launcher/labels/known%20issue)

- Launching Office 2013 installed via Office 365 on a 64-bit computer requires UXL Launcher to be set to 32-bit Windows. [(issue #43)](https://github.com/DrewNaylor/UXL-Launcher/issues/43)

- ~~If the user chooses to test their settings and Office Language Preferences can't be launched and they choose to open the Options window, a duplicate Options window spawns. [(issue #46)](https://github.com/DrewNaylor/UXL-Launcher/issues/46)~~ [Fixed in f697e75](https://github.com/DrewNaylor/UXL-Launcher/commit/f697e75552dd19e8d66db12e775adc559c87e953)

- CryptoPrevent Maximum protection settings block Windows PowerShell from running thus halting the build process. [(issue #52)](https://github.com/DrewNaylor/UXL-Launcher/issues/52)


# System Requirements for running UXL Launcher

To run UXL Launcher, your computer requires the following:

- [Microsoft .Net 4.6.1 Framework](https://www.microsoft.com/en-us/download/details.aspx?id=49981)

  - Ignore the ad on that page, scroll down, and click the orange Download button. May take a while to download.

- Windows versions: Windows 7 SP1, 8.1, 10.
  - Windows 8.0 is untested although it might work.

- Architectures: x86 (32-bit) and x64 (64-bit.)

- Hardware requirements: At least a 1.2 GHz CPU; 1 GB of RAM or more.

- Disk space:

  - 32-bit: 3 GB space free.
  - 64-bit: 3 GB space free.

- To properly view the License and Acknowledgements in the About window, you'll need Internet Explorer.

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in UXL Launcher due to Visual Studio building problems.
<br>
<br>
<br>
# System Requirements to build UXL Launcher from source

In addition to the requirements for simply running UXL Launcher, your computer requires the following software to build it from source code:

- [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159)
- [Windows PowerShell 5.0](https://www.microsoft.com/en-us/download/details.aspx?id=50395)

If [Visual Studio 2015 Community](https://www.visualstudio.com/vs/) is installed, Microsoft Build Tools 2015 is not required for building UXL Launcher.

If you would like to automatically build UXL Launcher from source, you can use my [UXL Autobuild Script](https://gist.github.com/DrewNaylor/22e3f1cded702fff494a46dabe643fde) (AKA UAS) Batch script to automatically download, build, and run the latest, bleeding-edge changes from the master branch. Do note, however, UAS isn't recommended for people who want stable software due to the fact that things may break at any time.

***

If you don't want to use a script to build UXL Launcher, here's how to do it manually:

1. First, clone the Git repository by running: <code>git clone https://github.com/DrewNaylor/UXL-Launcher.git</code> or [download the Zip file for the master branch](https://github.com/DrewNaylor/UXL-Launcher/archive/master.zip) and remember where you saved your files.

2. Next, open the command prompt from the Start menu (<code>cmd.exe</code>) and type or copy/paste <code>cd C:\Program Files (x86)\MSBuild\14.0\Bin\ </code> if you have a 64-bit Windows install or <code>cd C:\Program Files\MSBuild\14.0\Bin\ </code> if you have a 32-bit Windows install Press the Enter or Return key when it's pasted. Don't run <code>cmd.exe</code> from the Git Shell or else the next step won't work.

3. Third, type <code>msbuild.exe</code>, press the spacebar, and drag the <code>UXL-Launcher.vbproj</code> into the command prompt window and press the Enter or Return key.

4. And finally, once the project is done being built, you'll find the UXL Launcher EXE file in <code>UXL-Launcher\UXL-Launcher\bin\Debug </code> wherever you saved the files to earlier along with a config file, a PDB file, and an XML file.
<br>
<br>
<br>
# How to Modify the Source Code

In order to play around with the source code, it's recommended to install [Visual Studio 2015 Community](https://www.visualstudio.com/vs/) in addition to the software to run UXL Launcher. To poke around in the code, simply double-click the <code>UXL-Launcher.sln</code> file in the root of the Git repository.
