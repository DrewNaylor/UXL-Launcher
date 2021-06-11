# UXL Launcher

An app launcher meant to launch Microsoft Office 2010, 2013, 2016, 2019 desktop software/apps, including ones from Office 365. Not associated with Microsoft.

| Overall project status | Master branch status |
|------------------------------------------------------------------------|----------------------------|
| [![Project Build status](https://ci.appveyor.com/api/projects/status/kfmjn85sp78xb398?svg=true)](https://ci.appveyor.com/project/DrewNaylor/uxl-launcher) | [![Master branch Build status](https://ci.appveyor.com/api/projects/status/kfmjn85sp78xb398/branch/master?svg=true)](https://ci.appveyor.com/project/DrewNaylor/uxl-launcher/branch/master) |

UXL Launcher (Unified eXecutable Launcher) allows you to launch most desktop Microsoft Office apps (Office 2010, 2013, 2016, and 2019 are supported [with the exception of Office 2010 Home and Student and Home and Business for now](https://github.com/DrewNaylor/UXL-Launcher/issues/70)) from one place instead of just using a folder with shortcuts to the apps, having a messy desktop with shortcuts, or trying to search through the Start menu for the app you want. Some apps, such as Skype, Skype for Business, Teams, Sway, and a few others aren't supported yet.

![](/UXL-Launcher/Resources/UXL-Standalone-Icon.png?raw=true)

UXL Launcher is the successor to "Drew's App Launcher," and the first stable release was version 3.0 to show the relationship between Drew's App Launcher (last official release is 2.8.x) and UXL Launcher (first official release was 3.0.)

Please be aware that UXL Launcher is unofficial and not made by Microsoft.

The readme continues after this notice.

```
UXL Launcher - UXL Launcher provides launchers for most Microsoft Office apps in one place.
Copyright (C) 2013-2021 Drew Naylor
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

  Licensed under the Apache License, Version 2.0 (the "License");
  you may not use this file except in compliance with the License.
  You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

  Unless required by applicable law or agreed to in writing, software
  distributed under the License is distributed on an "AS IS" BASIS,
  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
  See the License for the specific language governing permissions and
  limitations under the License.
```

Below is information on the icon set used in UXL Launcher.

```
applauncher-icons
By Drew Naylor. Licensed under CC BY 4.0.
Version 3.0

The applauncher-icons project provides most of the icons used in UXL Launcher,
with the exception of some icons. These include, but are not limited to, the
UXL Launcher logo and the About window banner.

Link to applauncher-icons project repository:
https://github.com/DrewNaylor/applauncher-icons

Link to applauncher-icons version 3.0 GitHub Releases page:
https://github.com/DrewNaylor/applauncher-icons/releases/tag/v3.0

The version of applauncher-icons used in UXL Launcher has been modified from the
original source. Namely, the smaller icons used in the UXL Launcher Quickmenu and
some menubar entries were resized from the original files.

No warranty is provided with applauncher-icons. Use at your own risk. Drew Naylor
is not responsible for any problems that use of applauncher-icons may cause.

This work is licensed under the Creative Commons Attribution 4.0 International License.
To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

Microsoft is not associated with either the applauncher-icons project or Drew Naylor
and does not condone this project.
```

Switching tabs with the scroll wheel is provided by `libscrollswitchtabs` and its full license is available in `LICENSE_Apache-2.0.txt`. Details:

```
libscrollswitchtabs
Copyright (C) 2020 Drew Naylor. Licensed under Apache License 2.0.
Version 0.1

libscrollswitchtabs allows you to switch tabs in the Windows Forms TabControl using the mouse scroll wheel, like many Linux applications.

libscrollswitchtabs is part of the drews-libs project.
Link to drews-libs project repository:
https://github.com/DrewNaylor/drews-libs

No warranty is provided with libscrollswitchtabs. Use at your own risk. Drew Naylor is not responsible for any problems that use of libscrollswitchtabs may cause.

Apache License 2.0 summary as it applies to libscrollswitchtabs:
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```

## A Note from the Developer - October 8, 2020

Most of this was copied-and-pasted from the commit message:

Version 3.4 Stable is having its version number increased to 4.0 since it seems like the changes would be better in a new major version. If they weren't that different I would keep it on 3.4, but the Options window changed so much and the defaults changing could be confusing if it's not a major version increase, so I increased it. Version 3.4 RC1 unintentionally turned out to be a preview of Version 4.0 even though it wasn't supposed to be a GNOME-style preview version. Changes intended for 3.5 are being moved to 4.1, and changes for 4.0 are being moved to 5.0.

UXL Launcher is moving into a new era with 4.0. Roughly four years for the 3.x series seems like a good lifespan. What's nice is that this project is using the same codebase in 4.x as it was in 3.x, so that it won't have to be rebuilt like it was from 2.x to 3.x.

While it seems like version 4.0 has few changes for a major version number increase, the changes it does have are enough to warrant the major version number being increased as I briefly mentioned earlier.

Version 2.x had four stable releases (2.6.1, 2.7, 2.8, and 2.8.1), and Version 3.x had five stable releases (3.0, 3.1, 3.2, 3.3, and 3.3.1). I'd like to have the 3.x series go for as long as it could have life in it, but I guess the whole "these changes are best for 4.0 but I'll do them for 3.4" ended up being a self-fulfilling prophecy. Funny how things work out that way.

Version 4.0 is like a midpoint between the familiar stuff in 3.x and the bigger changes in 5.x, if those bigger changes ever happen, that is. During 4.x, progress will be made toward ditching the built-in theme engine in favor of the one in the DLL, and the code that actually launches apps will hopefully be moved into a library so it can be re-used easily in different interfaces (if they ever exist). Moving the core code to libraries could allow for things like experimenting with UIs more easily.

I guess this can be changed to Stable now, as well. Still not ready until at least October 20, 2020, though.

<br>
<br>

## Screenshots

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

## Known Issues

[See all known issues.](https://github.com/DrewNaylor/UXL-Launcher/labels/known%20issue)
- CryptoPrevent Maximum protection settings block Windows PowerShell from running thus halting the build process. [(issue #52)](https://github.com/DrewNaylor/UXL-Launcher/issues/52)

- Statusbar text is cut off when using the Windows High Contrast White theme. [(issue #58)](https://github.com/DrewNaylor/UXL-Launcher/issues/58)

- Sometimes aaformMainWindow.vb (main app window) doesn't display properly in the Visual Studio Design view before building the project. [(issue #97)](https://github.com/DrewNaylor/UXL-Launcher/issues/97)

- If a UXL Launcher pinned shortcut on the taskbar is set to run minimized and "Hide When Minimized" is enabled in UXL Launcher, upon clicking the shortcut, the app will start, place the Quickmenu in the system tray, and highlight the pinned icon in the taskbar for a few seconds, then the highlight goes away. [(issue #120)](https://github.com/DrewNaylor/UXL-Launcher/issues/120)

- If the Options window or the About window are open, focus can be sent to the main window by using "Show UXL Launcher" in the Quickmenu and more About windows can be opened by navigating with the keyboard. [(issue #144)](https://github.com/DrewNaylor/UXL-Launcher/issues/144)

- Some text in the Options window isn't fully shown when running on a HiDPI device. [(issue #199)](https://github.com/DrewNaylor/UXL-Launcher/issues/199)

<br>
<br>

## System Requirements

### System Requirements for running UXL Launcher

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

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in UXL Launcher due to Visual Studio building problems. There may also be a warning message on first start about Windows Defender SmartScreen saying it "prevented an unrecognized app from starting. Running this app might put your PC at risk." You can click the "More info" link, then the "Run anyway" button if you want to use it, though this may not be allowed on corporate networks.

- Disk space, RAM, and CPU frequency requirements are based on the .Net Framework 4.6.1 requirements. UXL Launcher itself is quite small.

### Building UXL Launcher from Source: System Requirements and Guide

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
