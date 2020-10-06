If you are reading this in Notepad or another text editor, it displays best in Word Wrap view. Click on Format>Word Wrap on the top bar. Notepad++ users will find it under View>Word wrap.


UXL Launcher - Unified eXecutable Launcher -- Version 3.4 Release Candidate 1 - Codename "Changeth Arrangeth" -- 10/6/2020 (MM/DD/YYYY).

If you have any trouble, you might be able to find an answer on the wiki. It's linked at the end of this readme file. If not, you can submit a bug report at the "Report a problem" link at the end of this readme file. Your report will be labeled by the developers accordingly in a reasonable amount of time.

You can use Windows PowerShell to confirm the hash of the main UXL Launcher EXE file by running
"Get-FileHash .\UXL-Launcher.exe -Algorithm SHA256" in the folder you extracted the archive to and comparing the output to my sum listed below. HowToGeek has a nice article on this:
https://www.howtogeek.com/67241/htg-explains-what-are-md5-sha-1-hashes-and-how-do-i-check-them/ , but the Windows section is a bit further down on the page.

7-Zip also has a way to check file hashes in the "CRC SHA" dropdown in the file context menu. This project is not associated with 7-Zip.

To check the hash for other files, replace "UXL-Launcher.exe" with the appropriate file.

SHA-256 sum for "UXL-Launcher.exe" in the archive:
3FDB90F24EBFD512AE39436EE6A038E0D2954BE9FA5C996DB7CB7AEFA617CF15

SHA-256 sum for "lib\libscrollswitchtabs.dll" in the archive:
423A65849280D1F9665AD03094DD8648482E889CD4FA0F7AA4CA7AE8F087C7A7

SHA-256 sum for "UXL-Launcher.exe.config" in the archive:
6893BB5389DA7FFB63961CA35B4C7892B627181894F20950D93149277114CB7D


----------------
GENERAL NOTES
~~~~~~~~~~~~~~~~

--> The source code should be included in this archive in a Zip file called "source-code.zip".
--> Make sure to read the changelog included in this archive named "v3.4-rc1_changelog-from_v3.3-stable.txt". A lot of documentation is in this file since I have a hard time making good documentation unless I know exactly what to talk about. The changelog does have markdown so that it looks good on GitHub, but it shouldn't be too intrusive.
--> Before running UXL Launcher, please extract the entire archive to an easy-to-access location. It won't work correctly if it's temporarily extracted without its config file ("UXL-Launcher.exe.config").
--> If you find any bugs, please report them at the GitHub Issues page linked at the end of this document.
--> The documentation is linked at the end of this document, though it's not the best.
--> I am not responsible for any damage using my app may cause.

----------------
KNOWN ISSUES
~~~~~~~~~~~~~~~~

See all known issues: https://github.com/DrewNaylor/UXL-Launcher/labels/known%20issue

- Launching Office 2013 installed via Office 365 on a 64-bit computer requires UXL Launcher to be set to 32-bit Windows. (issue #43)  https://github.com/DrewNaylor/UXL-Launcher/issues/43

- CryptoPrevent Maximum protection settings block Windows PowerShell from running thus halting the build process. (issue #52)  https://github.com/DrewNaylor/UXL-Launcher/issues/52

- Statusbar text is cut off when using the Windows High Contrast White theme. (issue #58) https://github.com/DrewNaylor/UXL-Launcher/issues/58

- Sometimes aaformMainWindow.vb (main UXL Launcher window) doesn't display properly in the Visual Studio Design view before building the project. (issue #97)  https://github.com/DrewNaylor/UXL-Launcher/issues/97

- If a UXL Launcher pinned shortcut on the taskbar is set to run minimized and "Hide When Minimized" is enabled in UXL Launcher, upon clicking the shortcut, the app will start, place the Quickmenu in the system tray, and highlight the pinned icon in the taskbar for a few seconds, then the highlight goes away. (issue #120) https://github.com/DrewNaylor/UXL-Launcher/issues/120

- If the Options window or the About window are open, focus can be sent to the main window by using "Show UXL Launcher" in the Quickmenu and more About windows can be opened by navigating with the keyboard. (issue #144) https://github.com/DrewNaylor/UXL-Launcher/issues/144

--------------------
SYSTEM REQUIREMENTS
~~~~~~~~~~~~~~~~~~~~

To run UXL Launcher, your computer requires the following:

- Microsoft .Net 4.6.1 Framework https://www.microsoft.com/en-us/download/details.aspx?id=49981

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

------------
HOW TO USE
~~~~~~~~~~~~

1. Extract this archive to a folder. I don't really want to mess around with making an installer.

2. Open the file titled "UXL-Launcher.exe". I recommend making a shortcut to the app on your desktop or taskbar for easy access.

3. If you're upgrading from a previous version, you'll be asked if you want to migrate your settings. If you choose not to, you can do it later from Tools>Options...>Maintenance and click the "Migrate settings" button.

4. If you run Office 2019 64-bit on a 64-bit Windows install and Office is installed to Drive C, skip to step 5. If you have a different configuration, open the Options window from Tools>Options... and configure your settings accordingly.

5. Click any of the buttons for the apps you have installed and it should start. Otherwise, you will get a "File Not Found" error message with the option to directly open the Options window, if you so choose. See step 4 above.

6. If you don't have a particular Office app installed, my app will give you a "File Not Found" warning. If you do not have Office installed but simply want to test my app, I have a package of dummy applications which is now available here: https://github.com/DrewNaylor/dummyOffice It's not recommended to use dummyOffice as it may cause problems with file associations due to filenames. There's some info in the dummyOffice repository linked above.

----------------------------------
CONTACT AND COPYRIGHT/LICENSING
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Drew's Main Website:      			https://drew-naylor.com/
Drew's GitHub profile:     			https://github.com/DrewNaylor
UXL Launcher GitHub repository:		https://github.com/DrewNaylor/UXL-Launcher
Report a problem:	  				https://github.com/DrewNaylor/UXL-Launcher/issues/new
Check for updates:					https://github.com/DrewNaylor/UXL-Launcher/releases/latest
UXL Launcher documentation:			https://github.com/DrewNaylor/UXL-Launcher/wiki

Email:                    			drewnaylor_apps -AT/- outlook.com




UXL Launcher - Unified eXecutable Launcher
Version 3.4.0.0 Release Candidate 1 - Codename "Changeth Arrangeth"
Copyright (C) 2013-2020 Drew Naylor. Licensed under Gnu GPLv3+.

UXL Launcher provides launchers for most Microsoft Office apps in one place.
Please be aware that UXL Launcher is unofficial and not made by Microsoft.
Note that the "License" tab contains only the license for UXL Launcher. Other licenses are linked to from each component's information area below, if they are different.

License notice:
UXL Launcher is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

UXL Launcher is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with UXL Launcher. If not, see <http://www.gnu.org/licenses/>.

Drew is not intending on infringing on Microsoft's copyrights, so UXL Launcher is only a shortcut application.

Copyright notice: Windows, Microsoft Windows, Office, Microsoft Office, Word, Excel, PowerPoint, and all related words and trademarks/registered trademarks owned by Microsoft in the United States and/or other countries are Copyright 2020 Microsoft Corporation. All Rights Reserved to Microsoft for Microsoft's copyrights, trademarks, and registered trademarks.
Any other companies mentioned own their respective copyrights/trademarks.
Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor and does not endorse this software.

----------------------------------------------------------------------------------------

UXL Launcher Theme Engine
Version 1.04
Copyright (C) 2013-2020 Drew Naylor. Licensed under Gnu GPLv3+.

The copyright and license info is the same for the theme engine as it is for UXL Launcher itself as the theme engine is built into the same file as UXL Launcher.

The UXL Launcher Theme Engine can make the UXL Launcher main window look slightly better and can also use custom themes.

Please be aware that UXL Launcher and the UXL Launcher Theme Engine are both unofficial and not made by Microsoft.

License notice:
UXL Launcher is free software: you can redistribute it and/or modify it under the terms of the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

UXL Launcher is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with UXL Launcher. If not, see <http://www.gnu.org/licenses/>.

Drew is not intending on infringing on Microsoft's copyrights, so UXL Launcher is only a shortcut application.

Copyright notice: Windows, Microsoft Windows, Office, Microsoft Office, Word, Excel, PowerPoint, and all related words and trademarks/registered trademarks owned by Microsoft in the United States and/or other countries are Copyright 2020 Microsoft Corporation. All Rights Reserved to Microsoft for Microsoft's copyrights, trademarks, and registered trademarks. Any other companies mentioned own their respective copyrights/trademarks. Microsoft is not affiliated with either the UXL Launcher project or Drew Naylor and does not endorse this software.

----------------------------------------------------------------------------------------

applauncher-icons
By Drew Naylor. Licensed under CC BY 4.0.
Version 3.0

The applauncher-icons project provides most of the icons used in UXL Launcher, with the exception of some icons. These include, but are not limited to, the UXL Launcher logo and the About window banner.

Link to applauncher-icons project repository:
https://github.com/DrewNaylor/applauncher-icons

Link to applauncher-icons version 3.0 GitHub Releases page
https://github.com/DrewNaylor/applauncher-icons/releases/tag/v3.0

The version of applauncher-icons used in UXL Launcher has been modified from the original source. Namely, the Office Language Preferences icon used in the UI was resized from the original files.

No warranty is provided with applauncher-icons. Use at your own risk. Drew Naylor is not responsible for any problems that use of applauncher-icons may cause.

This work is licensed under the Creative Commons Attribution 4.0 International License. To view a copy of this license, visit http://creativecommons.org/licenses/by/4.0/.

Microsoft is not associated with either the applauncher-icons project or Drew Naylor and does not condone this project.

----------------------------------------------------------------------------------------

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