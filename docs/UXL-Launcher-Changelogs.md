This wiki page contains the changelogs for UXL Launcher and acts as an archive. You can view the old changelogs [here](../wiki/old-changelogs). Each version header links to the corresponding release on GitHub.

## Table of Contents
- [Top](#top)
- [Table of Contents](#table-of-contents)
- [Changelogs](#changelogs)
  - [UXL Launcher Version 3.1 Stable](#uxl-launcher-version-31-stable---released-july-10-2018)
  - [UXL Launcher Version 3.1 Release Candidate 1](#uxl-launcher-version-31-release-candidate-1---released-june-28-2018)
  - [UXL Launcher Version 3.0 Stable](#uxl-launcher-version-30-stable---released-december-23-2016)
  - [UXL Launcher Version 3.0 Release Candidate 1](#uxl-launcher-version-30-release-candidate-1---released-december-9-2016)

## Changelogs

### [UXL Launcher Version 3.1 Stable](../releases/tag/v3.1) - Released July 10, 2018

Edit Oct 2, 2018: I've made an installer! Its checksum was added below and the file name is `UXL-Launcher_v3.1-Stable.exe`. The files included are the same as the ones in the zip file. I'll probably make an installer for 3.2 when it's out since most of the work is done now. The installer uses Inno Setup and was compiled [from this script](https://github.com/DrewNaylor/UXL-Launcher/blob/master/InstallerScripts/UXL-Launcher_v3.1-Stable.iss). Please note that this installer was tested on Windows 10, 1803, and Windows 7 SP1, and does <b>not</b> check for [.Net 4.6.1, so that'll have to be installed separately](https://www.microsoft.com/en-us/download/details.aspx?id=49981) if it isn't already. If you run into trouble with the installer, <b>please file an issue</b> on the [Issues tab](https://github.com/DrewNaylor/UXL-Launcher/issues) above.

\---------------------------------------------------

After an entire one and a half years (1.5 years/18 months) and almost two weeks of work with numerous delays (mostly from video editing, [HideSettingsPages](https://github.com/DrewNaylor/HideSettingsPages), and classes), the release of UXL Launcher Version 3.1 Stable is finally here! I was feeling generous, so I released it a few days early. I wanted to get this out sooner, but there were some delays as previously mentioned. Once this is released, I'll start working on [Version 3.2](https://github.com/DrewNaylor/UXL-Launcher/milestone/3) which should have [Office 2019 support](https://github.com/DrewNaylor/UXL-Launcher/issues/99).

Please enjoy this version and its changelog. I worked hard on both Version 3.1 and the changelog and there are several optimizations that might not be immediately obvious, such as using an RTF document in the About window instead of an embedded web browser and a bug fix for a [major issue that was discovered after the release of Version 3.0 Stable](https://github.com/DrewNaylor/UXL-Launcher/issues/53). Other changes include the implementation of a theme engine with custom theme support. Important links, including links for more information on specific topics, are in the changelog below, so I'll let you read it.

As of October 2, 2018, an installer is available if you want to avoid manually extracting zip files. It adds a shortcut in the Start Menu and on the desktop, if you want it to.

\---------------<br>
CHECKSUMS<br>
\~~~~~~~~~

MD5 checksums are no longer used for UXL Launcher as of Version 3.1 Stable. [More details](https://github.com/DrewNaylor/UXL-Launcher/issues/124).

You can use Windows PowerShell to confirm the hash of the main UXL Launcher EXE file by running 
`Get-FileHash .\UXL-Launcher.exe -Algorithm SHA256` in the folder you extracted the archive to and comparing the output to my sum listed below. [HowToGeek has a nice article on this](https://www.howtogeek.com/67241/htg-explains-what-are-md5-sha-1-hashes-and-how-do-i-check-them/), but the Windows section is a bit further down on the page.

To check the installer's hash, run `Get-FileHash .\UXL-Launcher_v3.1-Stable.exe -Algorithm SHA256` in Windows PowerShell.

SHA-256 sum for "UXL-Launcher.exe" in the archive:
732D53E2821D025A63EE612F93A17FA76620EF7AD239BF3866E9718F26ECE7C2

SHA-256 sum for "UXL-Launcher_v3.1-Stable.exe" (the installer attached to this release):
88506A1D8584A28247EF87DB304EFC3EC6E929AFCB333E782F18638FB354D06C

\---------------<br>
CHANGELOG<br>
\~~~~~~~~~

Below this text is the changelog. It compares UXL Launcher Version 3.0 Stable to UXL Launcher Version 3.1 Stable.

If you would like to look at the same comparison as I did while writing this changelog, you can do so here:
https://github.com/DrewNaylor/UXL-Launcher/compare/v3.0...v3.1
The link above will be active by the time this is posted, but I used a slightly different comparison since the one I linked to wasn't ready yet. However, the content was the same, so it shouldn't matter.

Many of the changes presented below have a related issue in the [Version 3.1 milestone](https://github.com/DrewNaylor/UXL-Launcher/milestone/2?closed=1), if you would like to look at a bit more detail than listed here. Not all of the changes listed in this changelog were linked to a related issue, so you may need to do a bit of digging in that milestone to find the related issues.

---

## UXL Launcher Version 3.1 Stable Changelog


- Added:
  - A basic theme engine (known as the "UXL Launcher Theme Engine") has been added to UXL Launcher.
    - Its version is currently Version 1.01. This number will increase when there's any change at all made to the theme engine and some changes can be avoided by the theme designers if the change causes problems with their custom theme.
    - This allows the user to change the colors on the main window and Quickmenu with either built-in or custom themes.
	- The theme engine is turned off by default (to retain the overall look of Version 3.0 so that it's not a jarring upgrade) and can be turned on from `Tools>Options...>Personalization tab>Enable UXL Launcher Theme Engine checkbox`. Enabling or disabling the theme engine requires an application restart. Currently, a manual application restart is required, though this may change in the future. Enabling or disabling the theme engine requires an app restart because I don't know of an easy way to enable or disable a custom professional toolbar renderer at runtime after one is enabled and I don't want things to break.
	- Themes can be configured from `Tools>Options...>Personalization tab` by selecting a theme from the theme list dropdown box, then clicking `Save`. A description of each theme is shown in a textbox on the left side of the Options window.
	- If you want to temporarily reset to using the Default theme until the next time the app starts or settings are saved in the Options window, you can use the `View>Revert to Default Theme` menu button, or press `Ctrl+0` (Control and the number "zero" at the same time). This button only shows up when the theme engine is enabled.
	- For companies who want to keep their computers locked down, support for custom themes can be disabled by changing the value of the `allowCustomThemes` setting in the config file from `True` to `False`. The user will be told that support for custom themes has been disabled and to contact their administrator if they try to choose a custom theme in the Options window. It may be a good idea to install UXL Launcher and its config file in a location away from regular users with write access, such as in a read-only folder in a network drive and have the config file hidden to prevent modification.
	- Currently, there are [six themes included with UXL Launcher](https://github.com/DrewNaylor/UXL-Launcher/wiki/List-of-UXL-Launcher-Themes) and the option to use your own theme or a theme downloaded from the Internet. If a particular custom theme becomes popular enough within the community, it may become a built-in theme if the theme designer gives permission.
	- You can use a custom theme by selecting `(Custom)` in the theme list drop down box, then clicking the `Browse...` button next to the custom theme path textbox and navigating to the file you want to use, or by pasting the custom theme file's path into the textbox. Currently, the `Browse...` file open dialog has filters for XML files, TXT files, and all other file types.
	- A wiki page on [how to make your own custom theme](https://github.com/DrewNaylor/UXL-Launcher/wiki/How-to-Make-a-Custom-Theme-for-UXL-Launcher) is available.
	- Theme engine output such as errors and theme file info can be shown by changing the value of the `debugmodeShowThemeEngineOutput` setting in the config file from `False` to `True`. It'll show up in the Visual Studio Immediate Window and any other configured debug listeners. Please be aware that this may cause the app to slow down if enabled.
	- Theme-related debug labels have been added to the main window.
  - Users can now opt to use a custom statusbar greeting personalized with their firstname or nickname.
    - This is configured under `Tools>Options...>Personalization tab>Use personalized statusbar greeting` and typing in a firstname or nickname into the textbox below the radio button, then clicking `Save`.
	- The resulting statusbar greeting will be in the format of `Welcome back to UXL Launcher, Firstname!` "Firstname" is where the user's configured firstname/nickname goes.
	- The name typed into this textbox will not be used to personally identify the user.
	- If necessary, you can use the `Clear` button to the right of the textbox to erase all content within the textbox and set focus to it for easier firstname/nickname changes.
  - Hide When Minimized (`View>Hide When Minimized`) allows the user to hide the main window and only use the Quickmenu to launch apps. Double-clicking on the Quickmenu icon or right-clicking the Quickmenu and clicking `Show UXL Launcher` will both show the main window again.
  - The titlebar text now includes information on whether the app build currently running is considered "Stable", "Git" (built from code and not ready for release), or any other status.
  - Information on the theme engine and applauncher-icons (most of the icons used in UXL Launcher) has been added to the About window.
  - The license has been added next to copyright text in the About window so that it's now easier to tell what license a particular component uses. In the case of UXL Launcher, it says, "Copyright (C) 2013-2018 Drew Naylor. Licensed under Gnu GPLv3+." If there's no copyright, it's next to the author's name. This is how applauncher-icons displays this: "By Drew Naylor. Licensed under CC BY 4.0."
  - A bunch of screenshots have been added to a wiki page linked from the readme.
  - Buttons that update based on current build status that link to the AppVeyor page for UXL Launcher have been added to the readme.
  - The UXL Launcher logo has been added to the readme.
  - Better code organization.
  - Information on how UXL Launcher and Drew Naylor are not associated with Microsoft and that Microsoft does not endorse this software has been added to the project.
  - Additional applications are now listed in the part of the boilerplate text that says that UXL Launcher is not to be confused with other apps. The new ones are "UX Launcher" (an Android launcher) and "Ulauncher" (a Linux app launcher).
  - applauncher-icons (most of the icons in use within this app) boilerplate text has been added to the readme.

\---------------------------------------------------------------------------------------------------------------

- Changed:
  - The readme and parts of the wiki have been improved since the release of UXL Launcher 3.0. This includes the addition of a ["Screenshots" page](https://github.com/DrewNaylor/UXL-Launcher/wiki/Screenshots) in the wiki and a [list of known Microsoft Office install locations](https://github.com/DrewNaylor/UXL-Launcher/wiki/List-of-Known-Microsoft-Office-Install-Locations).
  - UXL Launcher icon and About window banner has an updated border that's a bit easier to see.
  - [applauncher-icons](https://github.com/DrewNaylor/applauncher-icons) has been updated to [version 2.1](https://github.com/DrewNaylor/applauncher-icons/releases/tag/v2.1).
  - The UXL Launcher icon is now displayed on the readme.
  - Boilerplate text in the readme now uses the Markdown triple backtick (\```) for code blocks rather than the HTML \<code> tag.
  - Update readme instructions on building from source.
  - The `License` and `Acknowledgments` tabs in the About window now render their text with an RTF textbox instead of using a WebBrowser control. This improves performance considerably and reduces file size while also no longer requiring Internet Explorer to be installed to use UXL Launcher fully.
  - About window banner resolution increased from 256x512 to 512x1024.
  - Updated copyright years from 2013-2016 to 2013-2018.
  - The build date in the About window now has the new line in its text file that's created at build time removed when opening the window. This would allow text to be placed directly after the build date text.
  - About window information for UXL Launcher is now mostly read from a file resource in `My.Resources` rather than hardcoded in the About window's class. Shortly after the release candidate for Version 3.1 was made available, it was discovered that [AppVeyor builds and building directly from source hosted on GitHub made this text get jumbled up](https://github.com/DrewNaylor/UXL-Launcher/issues/121) due to Unix line endings, but this problem was fixed [several days later](https://github.com/DrewNaylor/UXL-Launcher/commit/093d9722b3d3cfc4043543994b2d498772508a48) when preparing the final cleanups and changes for UXL Launcher Version 3.1 Stable.
  - The `Office Language Preferences` button in the `Tools` menu now has an access key underscore under the first letter "f".
  - The flow layout panel used in the main window now uses the Windows `Window` system color rather than just white.
  - Statusbar text has been updated:
    - Old statusbar text: `Welcome to UXL, the Unified eXecutable Launcher! Click the buttons to launch the relevant app. Also, explore the UI.`
	- New statusbar text: `Welcome to UXL Launcher, the Unified eXecutable Launcher! Click the app names to launch them and explore the UI.`
  - Debug labels for the `Always On Top` feature have been moved to the `Extra Apps + Tools` groupbox to make room for the theme engine-related debug labels.
  - Debug labels have also been aligned vertically.
  - If you want to show the debug labels, you can change the value of `debugmodeShowLabels` in the config file from `False` to `True`. This change requires an app restart before they will be visible or hidden. This isn't something that changed; it's just something that may be useful. If the theme engine is enabled along with this setting, the debug labels for the theme engine will also be visible.
  - The `Microsoft Picture Manager` button had its text changed to `Microsoft Office Picture Manager`.
  - Many code regions and comments have been updated to be more clear.
  - Update Options window dialogs to state that some settings may require an application restart, such as enabling the theme engine.
  - Optimization is turned off for `Release` builds because I don't really need the speed and storage improvements. I'm not really sure what the benefit of using the `Release` builds would be over `Debug`, so for now, I'm just using `Debug` builds for distribution until I find out why I should use the `Release` configuration instead.
  - Each app launcher button now uses a single sub (block of code) that accepts arguments. Those arguments are the EXE file for the app (such as `EXCEL.EXE` for Microsoft Excel) and the "friendly name" for the app (the name most people would use to refer to an app, such as "Microsoft Excel"). This improves maintainability since all the important code relating to actually launching the app and handling errors is in one place. [More details](https://github.com/DrewNaylor/UXL-Launcher/issues/77).
  - File size for `UXL-Launcher.exe` has been reduced from 644 KB (Version 3.0) to 576 KB (Version 3.1).
  - Code that updates the `Always On Top` debug label has been moved to the code that updates debug labels instead of just copying it everywhere that particular debug label can update.
  - The About window "copyright notice" is now much more detailed about the fact that Microsoft owns their copyrights, trademarks, and registered trademarks. The copyright year for Microsoft's copyrights was also changed to be the current copyright year whenever Microsoft Office or Windows gets a new copyright year in new program versions.
  
\---------------------------------------------------------------------------------------------------------------

- Fixed:
  - If the main window is set to Always On Top and the user opens the Options window from the Quickmenu and clicks on a window behind the UXL Launcher window, the Options window will not be able to be interacted with until the user right-clicks on the Quickmenu icon again.
    - This was fixed by passing the name of the form that the new form is shown from when opening a new form (window).
	- More details and a video showing the bug [are available here](https://github.com/DrewNaylor/UXL-Launcher/issues/53).
  - `Always On Top` now continues to work as expected when opening the Options window or the About window; instead of setting the main window (form) to not be on top when these windows show up and returning to on top when they close, both the main window and the new windows stay on top. This problem was related to the other issue with `Always On Top` referenced above this item.
  - Markdown files such as the readme have been updated to look better after some of GitHub's changes that were made to better align GFM (GitHub Flavored Markdown) with regular Markdown. [A little more info](https://github.com/DrewNaylor/UXL-Launcher/issues/71) (I couldn't easily find the article that said that GitHub was changing how Markdown files were rendered).
  - If the user chooses to test their settings via "Options...>Test settings" and OfficeLangPrefs.exe can't be found, the main window will be sent to the back of the currently showing windows.
    - I don't know if this was a bug in Version 3.0 or not, but if it was, it's fixed now for anyone who ran into this problem.
	- [More details](https://github.com/DrewNaylor/UXL-Launcher/issues/110).
  - There was a typo in a code comment that had the text "textox" instead of the corrected "textbox".
  - This was mentioned in the "Changed" section above, but I think it's important enough to mention in the "Fixed" section, too: 
    - Opening the `About` window on a computer booted from a regular spinning hard drive is now much faster and doesn't hang as badly anymore, mainly because the `License` and `Acknowledgments` tabs no longer use an embedded WebBrowser control to display their files. They instead use an RTF textbox control.
	- I do know that the `Acknowledgments` tab RTF file header text still says "UXL Launcher Acknowledgements"; [I'll fix that in Version 3.2](https://github.com/DrewNaylor/UXL-Launcher/issues/123).
	- The second list item was only written because it would be improper grammar with only one subitem in a list.
	- Expecting another list item? [TOO BAD. THIS IS THE LAST ONE.](http://brawlinthefamily.keenspot.com/comic/151-witf/)

\---------------------------------------------------------------------------------------------------------------

- Removed:
  - `UXL-Standalone-Icon.png` was removed from app resources (My.Resources) because it's not actually used in UXL-Launcher.exe. It's still in the `Resources` folder, though, and is used on the project's [readme for GitHub](https://github.com/DrewNaylor/UXL-Launcher).
  - `Acknowledgments.html` and `gpl-3.0-standalone.html` were deleted because they were replaced with RTF documents.
  - An extra space was removed from between the copyright years and developer name in the About window text.

\---------------------------------------------------------------------------------------------------------------

- Deprecated:
  - The "View system info" button under `Tools>Options...>Advanced tab` will be replaced with a label that directly shows your Windows edition (32-bit or 64-bit) in version 3.2. [More info](https://github.com/DrewNaylor/UXL-Launcher/issues/115#issuecomment-395917017).
  - The two checkboxes under `Tools>Options...>General tab` for choosing your Office installation method (` I installed via Office 365/via MSI`) will be combined in version 3.2. [More info](https://github.com/DrewNaylor/UXL-Launcher/issues/100#issuecomment-395926431).

---

### [UXL Launcher Version 3.1 Release Candidate 1](../releases/tag/v3.1-rc1) - Released June 28, 2018

After an entire one and a half years (1.5 years/18 months) of work with numerous delays (mostly from video editing, [HideSettingsPages](https://github.com/DrewNaylor/HideSettingsPages), and classes), the release of UXL Launcher Version 3.1 Release Candidate 1 is finally here! If all goes well, this will be the final 3.1 Stable release with few modifications. If you notice any major bugs that aren't mentioned in the [Known Issues](https://github.com/DrewNaylor/UXL-Launcher/labels/known%20issue) or [bug list](https://github.com/DrewNaylor/UXL-Launcher/issues?q=is%3Aopen+is%3Aissue+label%3Abug), please [report them in the Issues tab](https://github.com/DrewNaylor/UXL-Launcher/issues/new) and I will get around to fixing them if they're easy to run into.

If all does go well and no major problems are discovered in Version 3.1 Release Candidate 1, UXL Launcher Version 3.1 Stable will be released on July 12, 2018. Likewise, if any additional changes are discovered, they'll be added to the Version 3.1 Stable changelog.

\---------------<br>
CHECKSUMS<br>
\~~~~~~~~~

You can use MD5Check to confirm the MD5 checksum listed below. http://www.angusj.com/delphi/
MD5 checksums are used for UXL Launcher because it can be easy to check for the end user.
### <b>HOWEVER, IN UXL Launcher Version 3.1 Stable, MD5 CHECKSUMS WILL NO LONGER BE PROVIDED. THIS RELEASE CANDIDATE (and any other Release Candidates for Version 3.1) WILL BE THE LAST VERSION TO PROVIDE AN MD5 CHECKSUM BECAUSE IT'S A WEAK STANDARD.</b> [More details](https://github.com/DrewNaylor/UXL-Launcher/issues/124).

If you want to use the SHA-256 sum instead (which you should do because an MD5 checksum won't be provided with UXL Launcher Version 3.1 Stable), you can use Windows PowerShell to confirm the hash by running 
`Get-FileHash .\UXL-Launcher.exe -Algorithm SHA256` in the folder you extracted the archive to and comparing the output to my sum listed below. [HowToGeek has a nice article on this](https://www.howtogeek.com/67241/htg-explains-what-are-md5-sha-1-hashes-and-how-do-i-check-them/), but the Windows section is a bit further down on the page.

MD5 sum for "UXL-Launcher.exe" in the archive:  18D12F8A9DAABDEBC1383555F67C7845

If you want to use an SHA-256 sum instead, here's an SHA-256 sum for "UXL-Launcher.exe" in the archive:
06E28217C001F78F1D74D1092FAD7F69F37724B81E3E523DF345981B383CF10D

\---------------<br>
CHANGELOG<br>
\~~~~~~~~~

Below this text is the changelog. It compares UXL Launcher Version 3.0 Stable to UXL Launcher Version 3.1 Release Candidate 1. When the final Version 3.1 Stable changelog is written, changes will be compared between that version and Version 3.0 Stable.

If you would like to look at the same comparison as I did while writing this changelog, you can do so here:
https://github.com/DrewNaylor/UXL-Launcher/compare/v3.0...v3.1-rc1
The link above will be active by the time this is posted, but I used a slightly different comparison since the one I linked to wasn't ready yet. However, the content was the same, so it shouldn't matter.

Many of the changes presented below have a related issue in the [Version 3.1 milestone](https://github.com/DrewNaylor/UXL-Launcher/milestone/2?closed=1), if you would like to look at a bit more detail than listed here. Not all of the changes listed in this changelog were linked to a related issue, so you may need to do a bit of digging in that milestone to find the related issues.

---

## UXL Launcher Version 3.1 Release Candidate 1 Changelog

- Added:
  - A basic theme engine (known as the "UXL Launcher Theme Engine") has been added to UXL Launcher.
    - Its version is currently Version 1.01. This number will increase when there's any change at all made to the theme engine and some changes can be avoided by the theme designers if the change causes problems with their custom theme.
    - This allows the user to change the colors on the main window and Quickmenu with either built-in or custom themes.
    - The theme engine is turned off by default and can be turned on from `Tools>Options...>Personalization tab>Enable UXL Launcher Theme Engine checkbox`. Enabling or disabling the theme engine requires an application restart. Currently, a manual application restart is required, though this may change in the future. Enabling or disabling the theme engine requires an app restart because I don't know of an easy way to enable or disable a custom professional toolbar renderer at runtime after one is enabled and I don't want things to break.
    - Themes can be configured from `Tools>Options...>Personalization tab` by selecting a theme from the theme list dropdown box, then clicking `Save`. A description of each theme is shown in a textbox on the left side of the Options window.
    - If you want to temporarily reset to using the Default theme until the next time the app starts or settings are saved in the Options window, you can use the `View>Revert to Default Theme` menu button, or press `Ctrl+0` (Control and the number "zero" at the same time). This button only shows up when the theme engine is enabled.
    - For companies who want to keep their computers locked down, support for custom themes can be disabled by changing the value of the `allowCustomThemes` setting in the config file from `True` to `False`. The user will be told that support for custom themes has been disabled and to contact their administrator if they try to choose a custom theme in the Options window. It may be a good idea to install UXL Launcher and its config file in a location away from regular users with write access, such as in a read-only folder in a network drive and have the config file hidden to prevent modification.
    - Currently, there are [six themes included with UXL Launcher](https://github.com/DrewNaylor/UXL-Launcher/wiki/List-of-UXL-Launcher-Themes) and the option to use your own theme or a theme downloaded from the Internet. If a particular custom theme becomes popular enough within the community, it may become a built-in theme if the theme designer gives permission.
    - You can use a custom theme by selecting `(Custom)` in the theme list drop down box, then clicking the `Browse...` button next to the custom theme path textbox and navigating to the file you want to use, or by pasting the custom theme file's path into the textbox. Currently, the `Browse...` file open dialog has filters for XML files, TXT files, and all other file types.
    - A wiki page on how to make your own custom theme is available [here](https://github.com/DrewNaylor/UXL-Launcher/wiki/How-to-Make-a-Custom-Theme-for-UXL-Launcher).
    - Theme engine output such as errors and theme file info can be shown by changing the value of the `debugmodeShowThemeEngineOutput` setting in the config file from `False` to `True`. It'll show up in the Visual Studio Immediate Window and any other configured debug listeners. Please be aware that this may cause the app to slow down if enabled.
    - Theme-related debug labels have been added to the main window.
  - Users can now opt to use a custom statusbar greeting personalized with their firstname or nickname.
    - This is configured under `Tools>Options...>Personalization tab>Use personalized statusbar greeting` and typing in a firstname or nickname into the textbox below the radio button, then clicking `Save`.
    - The resulting statusbar greeting will be in the style of `Welcome back to UXL Launcher, Firstname!`
    - The name typed into this textbox will not be used to personally identify the user.
    - If necessary, you can use the `Clear` button to the right of the textbox to erase all content within the textbox and set focus to it for easier firstname/nickname changes.
  - Hide When Minimized (`View>Hide When Minimized`) allows the user to hide the main window and only use the Quickmenu to launch apps. Double-clicking on the Quickmenu icon or right-clicking the Quickmenu and clicking `Show UXL Launcher` will both show the main window again.
  - The titlebar text now includes information on whether the app build currently running is considered "Stable", "Git" (built from code and not ready for release), or any other status.
  - Information on the theme engine and applauncher-icons (most of the icons used in UXL Launcher) has been added to the About window.
  - A bunch of screenshots have been added to a wiki page linked from the readme.
  - Buttons that update based on current build status that link to the AppVeyor page for UXL Launcher have been added to the readme.
  - The UXL Launcher logo has been added to the readme.
  - Better code organization.
  - Information on how UXL Launcher and Drew Naylor are not associated with Microsoft and that Microsoft does not endorse this software has been added to the project.
  - Additional applications are now listed in the part of the boilerplate text that says that UXL Launcher is not to be confused with other apps. The new ones are "UX Launcher" (an Android launcher) and "Ulauncher" (a Linux app launcher).
  - applauncher-icons (most of the icons in use within this app) boilerplate text has been added to the readme.

\---------------------------------------------------------------------------------------------------------------

- Changed:
  - The readme and parts of the wiki have been improved since the release of UXL Launcher 3.0. This includes the addition of a ["Screenshots" page](https://github.com/DrewNaylor/UXL-Launcher/wiki/Screenshots) in the wiki and a [list of known Microsoft Office install locations](https://github.com/DrewNaylor/UXL-Launcher/wiki/List-of-Known-Microsoft-Office-Install-Locations).
  - UXL Launcher icon and About window banner has an updated border that's a bit easier to see.
  - [applauncher-icons](https://github.com/DrewNaylor/applauncher-icons) has been updated to [version 2.1](https://github.com/DrewNaylor/applauncher-icons/releases/tag/v2.1).
  - The UXL Launcher icon is now displayed on the readme.
  - Boilerplate text in the readme now uses the Markdown triple backtick (\```) for code blocks rather than the HTML \<code> tag.
  - Update readme instructions on building from source.
  - The `License` and `Acknowledgments` tabs in the About window now render their text with an RTF textbox instead of using a WebBrowser control. This improves performance considerably and reduces file size while also no longer requiring Internet Explorer to be installed to use UXL Launcher fully.
  - About window banner resolution increased from 256x512 to 512x1024.
  - Updated copyright years from 2013-2016 to 2013-2018.
  - The build date in the About window now has the new line in its text file created at build time removed when opening the window. This would allow text to be placed directly after the build date text.
  - About window information for UXL Launcher is now mostly read from a file resource in `My.Resources` rather than hardcoded in the About window's class.
  - The `Office Language Preferences` button in the `Tools` menu now has an access key underscore under the first letter "f".
  - The flow layout panel used in the main window now uses the Windows `Window` system color rather than just white.
  - Statusbar text has been updated:
    - Old statusbar text: `Welcome to UXL, the Unified eXecutable Launcher! Click the buttons to launch the relevant app. Also, explore the UI.`
    - New statusbar text: `Welcome to UXL Launcher, the Unified eXecutable Launcher! Click the app names to launch them and explore the UI.`
  - Debug labels for the `Always On Top` feature have been moved to the `Extra Apps + Tools` groupbox to make room for the theme engine-related debug labels.
  - Debug labels have also been aligned vertically.
  - If you want to show the debug labels, you can change the value of `debugmodeShowLabels` in the config file from `False` to `True`. This change requires an app restart before they will be visible or hidden. This isn't something that changed; it's just something that may be useful. If the theme engine is enabled along with this setting, the debug labels for the theme engine will also be visible.
  - The `Microsoft Picture Manager` button had its text changed to `Microsoft Office Picture Manager`.
  - Many code regions and comments have been updated to be more clear.
  - Update Options window dialogs to state that some settings may require an application restart, such as enabling the theme engine.
  - Optimization is turned off for `Release` builds because I don't really need the speed and storage improvements. I'm not really sure what the benefit of using the `Release` builds would be over `Debug`, so for now, I'm just using `Debug` builds for distribution until I find out why I should use the `Release` configuration instead.
  - Each app launcher button now uses a single sub (block of code) that accepts arguments. Those arguments are the EXE file for the app (such as `EXCEL.EXE` for Microsoft Excel) and the "friendly name" for the app (the name most people would use to refer to an app, such as "Microsoft Excel"). This improves maintainability since all the important code relating to actually launching the app and handling errors is in one place. [More details](https://github.com/DrewNaylor/UXL-Launcher/issues/77).
  - File size for `UXL-Launcher.exe` has been reduced from 644 KB (Version 3.0) to 576 KB (Version 3.1).
  - Code that updates the `Always On Top` debug label has been moved to the code that updates debug labels instead of just copying it everywhere that particular debug label can update.
  
\---------------------------------------------------------------------------------------------------------------

- Fixed:
  - If the main window is set to Always On Top and the user opens the Options window from the Quickmenu and clicks on a window behind the UXL Launcher window, the Options window will not be able to be interacted with until the user right-clicks on the Quickmenu icon again.
    - This was fixed by passing the name of the form that the new form is shown from when opening a new form (window).
    - More details [are available here](https://github.com/DrewNaylor/UXL-Launcher/issues/53).
  - `Always On Top` now continues to work as expected when opening the Options window or the About window; instead of setting the main window (form) to not be on top when these windows show up and returning to on top when they close, both the main window and the new windows stay on top. This problem was related to the other issue with `Always On Top` referenced above this item.
  - Markdown files such as the readme have been updated to look better after some of GitHub's changes that were made to better align GFM (GitHub Flavored Markdown) with regular Markdown. [A little more info](https://github.com/DrewNaylor/UXL-Launcher/issues/71) (I couldn't easily find the article that said that GitHub was changing how Markdown files were rendered).
  - If the user chooses to test their settings via "Options...>Test settings" and OfficeLangPrefs.exe can't be found, the main window will be sent to the back of the currently showing windows.
    - I don't know if this was a bug in Version 3.0 or not, but if it was, it's fixed now for anyone who ran into this problem.
    - [More details](https://github.com/DrewNaylor/UXL-Launcher/issues/110).
  - There was a typo in a code comment that had the text "textox" instead of the corrected "textbox".
  - This was mentioned in the "Changed" section above, but I think it's important enough to mention in the "Fixed" section, too: 
    - Opening the `About` window on a computer booted from a regular spinning hard drive is now much faster, mainly because the `License` and `Acknowledgments` tabs no longer use an embedded WebBrowser control to display their files.
    - I do know that the `Acknowledgments` tab header text still says "UXL Launcher Acknowledgements"; [I'll fix that in Version 3.2](https://github.com/DrewNaylor/UXL-Launcher/issues/123).
    - The second list item was only written because it would be improper grammar with only one subitem in a list.
    - Expecting another list item? [TOO BAD. THIS IS THE LAST ONE.](http://brawlinthefamily.keenspot.com/comic/151-witf/)

\---------------------------------------------------------------------------------------------------------------

- Removed:
  - `UXL-Standalone-Icon.png` was removed from app resources (My.Resources) because it's not actually used in UXL-Launcher.exe. It's still in the `Resources` folder, though.
  - `Acknowledgments.html` and `gpl-3.0-standalone.html` were deleted because they were replaced with RTF documents.

\---------------------------------------------------------------------------------------------------------------

- Deprecated:
  - The "View system info" button under `Tools>Options...>Advanced tab` will be replaced with a label that directly shows your Windows edition (32-bit or 64-bit) in version 3.2. [More info](https://github.com/DrewNaylor/UXL-Launcher/issues/115#issuecomment-395917017).
  - The two checkboxes under `Tools>Options...>General tab` for choosing your Office installation method (` I installed via Office 365/via MSI`) will be combined in version 3.2. [More info](https://github.com/DrewNaylor/UXL-Launcher/issues/100#issuecomment-395926431).

---

### [UXL Launcher Version 3.0 Stable](../releases/tag/v3.0) - Released December 23, 2016

I am pleased to announce the release of UXL Launcher Version 3.0 Stable after three (3) months of work on this version alone! It's been almost three and a half years of work total on this app since I started working on Drew's App Launcher, the predecessor to UXL Launcher.

MD5 sum for "UXL-Launcher.exe" in the archive:  E79767D259E4D504C0F64EEA2FBFF923

You can use a tool [called MD5Check](http://www.angusj.com/delphi/) to compare the hashes.

Below this text is the changelog. It compares Drew's App Launcher version 2.8 to UXL Launcher version 3.0. UXL Launcher is the successor to Drew's App Launcher and was almost completely rewritten from scratch with very little code reused without modification from Drew's App Launcher.

---

UXL Launcher Version 3.0 Changelog:

## 
- Added:
  - Support for Office 2010 via 365, Office 2013, Office 2013 via MSI, Office 2016, and Office 2016 via 365.
  - Proper error handlers to tell the user that we can't find the specified program in the folder chosen in the Options window.
  - Context menu to the systemtray/notification icon for quicker launching of most of the apps.
  - Always On Top to keep the window on top of other windows that aren't set to Always On Top. Note that this is disabled temporarily when the Options window and About window are opened.
  - Settings tester button in Tools>Options window>Test settings button to make sure everything is configured properly.
  - Support for both 32-bit and 64-bit Windows installs in the same EXE file.
  - Proper About window with tabs for app info, License, and Acknowledgements.
  - Button to open the System Info page in the Control Panel in the Options window>Advanced tab.
  - Better organization with a menubar instead of a tab control.
  - Better code organization.
  - Link to the UXL Launcher wiki via Help>View Help Topics menubar entry which can be opened via Ctrl+F1.
  - Exit button via File>Exit menubar entry.
  - Banner to About window.
  - Part of the boilerplate License notice from the code to About window paragraph.
  - Support for HiDPI screens such as those found on the Surface Pro 4.
  - Debugging labels to the main window for developers and general debugging.
  - "Check for Updates" button in About window. This takes the user to the GitHub Releases feed.

## 
- Changed:
  - Attempt to conform to Microsoft's UX guidelines.
  - Brand-new icon that's visible at all the supported zoom levels in Windows Explorer.
  - Main window size is smaller and more efficient.
  - The Office Drive Location textbox in the Options window now accepts Backspace and lowercase letters. Note that it automatically changes lowercase letters to CAPITAL LETTERS when the user types in the box.
  - Moved the Options window and Office Language Preferences to the Tools menubar menu.
  - All the groupboxes on the main window have had their text changed.
  - Blue text in the Options window is now black.
  - Redesigned Options window.
  - Reorganized app category groupboxes to an order similar to how people usually list off the Office apps (ie. Word, Excel, PowerPoint, etc.)
  - Resized all the app icons on the main window to 50x50 pixels.

## 
- Removed:
  - Support for the internal changelog pages.
  - Support for Windows XP and Windows Vista
  - "Version History" column and buttons from About window.
  - Excess source code files that just add bloat.
  - "Notes" textbox from the About window.
  - Tab control on main window; replaced with menubar.
  - Drew's Modification Exception has been removed in favor of just the Gnu GPL v3+.

---

### [UXL Launcher Version 3.0 Release Candidate 1](../releases/tag/v3.0-rc1) - Released December 9, 2016

I am pleased to announce the release of UXL Launcher version 3.0 Release Candidate 1 after three (3) months of work! If all goes well this will be the final 3.0 Stable release with few modifications. If you notice any major bugs that aren't mentioned in the [Known Issues](https://github.com/DrewNaylor/UXL-Launcher/labels/known%20issue), please report them in the [Issues tab](https://github.com/DrewNaylor/UXL-Launcher/issues).

MD5 sum for "UXL-Launcher.exe" in the archive:  454239B22803EB951F3E86CC8F2F2811

You can use a tool [called MD5Check](http://www.angusj.com/delphi/) to compare the hashes.

Below this text is the changelog. It compares Drew's App Launcher version 2.8 to UXL Launcher version 3.0. UXL Launcher is the successor to Drew's App Launcher and was almost completely rewritten from scratch with very little code reused without modification from Drew's App Launcher.

---

UXL Launcher Version 3.0 Changelog:

## 
- Added:
  - Support for Office 2010 via 365, Office 2013, Office 2013 via MSI, Office 2016, and Office 2016 via 365.
  - Proper error handlers to tell the user that we can't find the specified program in the folder chosen in the Options window.
  - Context menu to the systemtray/notification icon for quicker launching of most of the apps.
  - Always On Top to keep the window on top of other windows that aren't set to Always On Top. Note that this is disabled temporarily when the Options window and About window are opened.
  - Settings tester button in Tools>Options window>Test settings button to make sure everything is configured properly.
  - Support for both 32-bit and 64-bit Windows installs in the same EXE file.
  - Proper About window with tabs for app info, License, and Acknowledgements.
  - Button to open the System Info page in the Control Panel in the Options window>Advanced tab.
  - Better organization with a menubar instead of a tab control.
  - Better code organization.
  - Link to the UXL Launcher wiki via Help>View Help Topics menubar entry which can be opened via Ctrl+F1.
  - Exit button via File>Exit menubar entry.
  - Banner to About window.
  - Part of the boilerplate License notice from the code to About window paragraph.
  - Support for HiDPI screens such as those found on the Surface Pro 4.
  - Debugging labels to the main window for developers and general debugging.
  - "Check for Updates" button in About window. This takes the user to the GitHub Releases feed.

## 
- Changed:
  - Attempt to conform to Microsoft's UX guidelines.
  - Brand-new icon that's visible at all the supported zoom levels in Windows Explorer.
  - Main window size is smaller and more efficient.
  - The Office Drive Location textbox in the Options window now accepts Backspace and lowercase letters. Note that it automatically changes lowercase letters to CAPITAL LETTERS when the user types in the box.
  - Moved the Options window and Office Language Preferences to the Tools menubar menu.
  - All the groupboxes on the main window have had their text changed.
  - Blue text in the Options window is now black.
  - Redesigned Options window.
  - Reorganized app category groupboxes to an order similar to how people usually list off the Office apps (ie. Word, Excel, PowerPoint, etc.)
  - Resized all the app icons on the main window to 50x50 pixels.

## 
- Removed:
  - Support for the internal changelog pages.
  - Support for Windows XP and Windows Vista
  - "Version History" column and buttons from About window.
  - Excess source code files that just add bloat.
  - "Notes" textbox from the About window.
  - Tab control on main window; replaced with menubar.
  - Drew's Modification Exception has been removed in favor of just the Gnu GPL v3+.