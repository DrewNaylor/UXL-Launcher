# What is UXL Launcher?

Project build status: [![Build status](https://ci.appveyor.com/api/projects/status/kfmjn85sp78xb398?svg=true)](https://ci.appveyor.com/project/DrewNaylor/uxl-launcher)

Master branch build status: [![Build status](https://ci.appveyor.com/api/projects/status/kfmjn85sp78xb398/branch/master?svg=true)](https://ci.appveyor.com/project/DrewNaylor/uxl-launcher/branch/master)



UXL Launcher (Unified eXecutable Launcher) is the successor to "Drew's App Launcher," and the first stable release was version 3.0 to show the relationship between Drew's App Launcher (last official release is 2.8.x) and UXL Launcher (first official release was 3.0.)

![](/UXL-Launcher/Resources/UXL-Standalone-Icon.png?raw=true)

UXL Launcher allows the user to launch Microsoft Office apps from one place instead of just using a folder with shortcuts to the apps.

Please be aware that UXL Launcher is unofficial and not made by Microsoft.

The readme continues after this notice.

```
UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
Copyright (C) 2013-2018 Drew Naylor
Microsoft Office and all related words are copyright
and trademark Microsoft Corporation. More details in the About window.
Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor
and does not endorse this software.
Any other companies mentioned own their respective copyrights/trademarks.
(Note that the copyright years include the years left out by the hyphen.)

This file is part of UXL Launcher
(Program is also known as "Unified eXecutable Launcher." Not to be confused with
other software titled "[Kindle] Unified Application Launcher",
"UX Launcher" [an Android launcher], or "Ulauncher" [a Linux app launcher].)

UXL Launcher is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

UXL Launcher is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with UXL Launcher.  If not, see <http://www.gnu.org/licenses/>.
```

Below is information on the icon set used in UXL Launcher.

```
applauncher-icons
By Drew Naylor. Licensed under CC BY 4.0.
Version 2.1

The applauncher-icons project provides most of the icons used in UXL Launcher, with the exception of some icons. These include, but are not limited to, the UXL Launcher logo and the About window banner.

Link to applauncher-icons project repository:
https://github.com/DrewNaylor/applauncher-icons

Link to applauncher-icons version 2.1 GitHub Releases page:
https://github.com/DrewNaylor/applauncher-icons/releases/tag/v2.1

The version of applauncher-icons used in UXL Launcher has been modified from the original source. Namely, the smaller icons used in the UXL Launcher Quickmenu and some menubar entries were resized from the original files.

No warranty is provided with applauncher-icons. Use at your own risk. Drew Naylor is not responsible for any problems that use of applauncher-icons may cause.

This work is licensed under the Creative Commons Attribution 4.0 International License. To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

Microsoft is not associated with either the applauncher-icons project or Drew Naylor and does not condone this project.
```

<br>
<br>

Screenshots:

![](/docs/images/uxl-launcher-3.0_screenshot.PNG?raw=true)
<br>
`^ Main UXL Launcher 3.0 window running on Windows 7.`

<br>

![](/docs/images/uxl-launcher-quickmenu_from-3.0_screenshot.PNG?raw=true)
<br>
`^ UXL Launcher Quickmenu - a context menu for its system tray icon that exposes a few functions.`

<br>

[More screenshots](https://github.com/DrewNaylor/UXL-Launcher/wiki/Screenshots)

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

- ~~If the user chooses to test their settings and Office Language Preferences can't be launched and they choose to open the Options window, a duplicate Options window spawns. [(issue #46)](https://github.com/DrewNaylor/UXL-Launcher/issues/46)~~ Fixed in [f697e75](https://github.com/DrewNaylor/UXL-Launcher/commit/f697e75552dd19e8d66db12e775adc559c87e953)

- CryptoPrevent Maximum protection settings block Windows PowerShell from running thus halting the build process. [(issue #52)](https://github.com/DrewNaylor/UXL-Launcher/issues/52)

- ~~If the main window is set to Always On Top and the user opens the Options window from the Quickmenu and clicks on a window behind the UXL Launcher window, the Options window will not be able to be interacted with until the user right-clicks on the Quickmenu icon again. [(issue #53)](https://github.com/DrewNaylor/UXL-Launcher/issues/53)~~ Fixed in [94edb9d](https://github.com/DrewNaylor/UXL-Launcher/commit/94edb9d042fb9e06c9244cda54ff83ae7bd6ab03) and [7875980](https://github.com/DrewNaylor/UXL-Launcher/commit/7875980c2c8c8c272d544146788e96f0fa9aad35)

- Statusbar text is cut off when using the Windows High Contrast White theme. [(issue #58)](https://github.com/DrewNaylor/UXL-Launcher/issues/58)

- Sometimes aaformMainWindow.vb (main UXL Launcher window) doesn't display properly in the Visual Studio Design view before building the project. [(issue #97)](https://github.com/DrewNaylor/UXL-Launcher/issues/97)

<br>
<br>

# System Requirements

## System Requirements for running UXL Launcher

To run UXL Launcher, your computer requires the following:

- [Microsoft .Net 4.6.1 Framework](https://www.microsoft.com/en-us/download/details.aspx?id=49981)

  - Ignore the ad on that page, scroll down, and click the orange Download button. Note that this is the web installer and it'll download its components after it's opened. May take a while to download.

- Windows versions: Windows 7 SP1, 8.1, 10.
  - Windows 8.0 is untested although it might work.

- Architectures: x86 (32-bit) and x64 (64-bit.)

- Hardware requirements: At least a 1.2 GHz CPU; 1 GB of RAM or more.

- Disk space:

  - 32-bit: 3 GB space free.
  - 64-bit: 3 GB space free.

- To properly view the License and Acknowledgements in the About window, you'll need Internet Explorer if you're using Version 3.0. Version 3.1 removes this requirement.

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in UXL Launcher due to Visual Studio building problems.

## Building UXL Launcher from Source: System Requirements and Guide

In addition to the requirements for simply running UXL Launcher, your computer requires the following software to build it from source code:

- [Microsoft Build Tools 2015](https://www.microsoft.com/en-us/download/details.aspx?id=48159)
  - If [Visual Studio 2015 Community](https://www.visualstudio.com/vs/older-downloads/) is installed, Microsoft Build Tools 2015 is not required for building UXL Launcher.
- [Windows PowerShell 5.0](https://www.microsoft.com/en-us/download/details.aspx?id=50395)
  - It may be necessary to read the Windows PowerShell 5.0 [install instructions](https://docs.microsoft.com/en-us/powershell/wmf/5.0/requirements) as the download page can be a bit confusing. The install instructions link has a table with the links needed for each version of Windows.
  - Windows 10 does not require PowerShell to be manually installed as it already has PowerShell 5.0.


~~If you would like to automatically build UXL Launcher from source, you can use my [UXL Autobuild Script](https://gist.github.com/DrewNaylor/22e3f1cded702fff494a46dabe643fde) (AKA UAS) Batch script to automatically download, build, and run the latest, bleeding-edge changes from the master branch. Do note, however, UAS isn't recommended for people who want stable software due to the fact that things may break at any time.~~ Please be aware that this script no longer works as of February 23, 2018, due to changes with GitHub's servers. See [here](https://gist.github.com/DrewNaylor/22e3f1cded702fff494a46dabe643fde#gistcomment-2367291). An alternate method to trying the latest changes from the master branch is by downloading the latest build's [artifacts from AppVeyor](https://ci.appveyor.com/project/DrewNaylor/uxl-launcher/build/artifacts). When the download has completed, extract the archive, then open the `Debug` folder. In this folder, double-click on `UXL-Launcher.exe`.

***

If you don't want to use a script (or download from AppVeyor) to build UXL Launcher, here's how to do it manually:

1. First, clone the Git repository by running: <code>git clone https://github.com/DrewNaylor/UXL-Launcher.git</code> or [download the Zip file for the master branch](https://github.com/DrewNaylor/UXL-Launcher/archive/master.zip) and remember where you saved your files.

2. Next, open the command prompt from the Start menu (`cmd.exe`) and type or copy/paste `cd C:\Program Files (x86)\MSBuild\14.0\Bin\` if you have a 64-bit Windows install or `cd C:\Program Files\MSBuild\14.0\Bin\` if you have a 32-bit Windows install. Press the Enter or Return key when it's pasted. Don't run `cmd.exe` from the Git Shell or else the next step won't work.

3. Third, type `msbuild.exe`, press the spacebar, and drag the `UXL-Launcher.vbproj` into the command prompt window and press the Enter or Return key.

4. And finally, once the project is done being built, you'll find the UXL Launcher EXE file in `UXL-Launcher\UXL-Launcher\bin\Debug` wherever you saved the files to earlier along with a config file, a PDB file, and an XML file.

## How to Modify the Source Code

In order to play around with the source code, it's recommended to install [Visual Studio 2015 Community](https://www.visualstudio.com/vs/) in addition to the software to run UXL Launcher. To poke around in the code, simply double-click the <code>UXL-Launcher.sln</code> file in the root of the Git repository.

Please be aware that you may need to build the project before forms show up properly in the designer. See [(issue #97)](https://github.com/DrewNaylor/UXL-Launcher/issues/97) for details.
