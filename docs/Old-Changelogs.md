These changelogs are from older versions of Drew's App Launcher before it was called UXL Launcher. I copied them from the Drew's App Launcher wiki for the most part. Because the 64-bit changelogs are so similar to the 32-bit version, I'm not going to copy them over, but [you can check them out](https://github.com/DrewNaylor/MSOfficeAppLauncherNext64/releases) if you like.

## This area contains the old changelogs from the 32-bit version of my app launcher.
All text is the same as the original text except for some formatting and fixing stuff Markdown doesn't like. Also, this list goes from old to new.

### 32-Bit Version History Window (before I used an HTML RSS feed.)

~~~~~~~~~~~~~~~~~~~~~~~~~~
32-Bit Edition:



VERSION 2.5


V. 2.5 Update 0: Added seperate "Version History" windows for both
	32-bit and 64-bit editions for times that updates cover only
	one edition.

____________

VERSION 2.4


V. 2.4 Update 3.1: Minor bug fixes. Added the "Version History" 
	pane for 32-bit.

V. 2.4 Update 2:   Added a few new features (not sure if it was both editions 
	or what.)

__________________

EARLY VERSIONS


V. 1.1.0.1: First version of this program that happened to be 32-bit.
~~~~~~~~~~~~~~~~~~~~~~~~~~


---

### 32-Bit Version History Column (the column which is deprecated on the About tab.)

~~~~~~~~~~~~~~~~~~~~~~~~~~
What's New


Version 2.5
----------------------------------------
Update 0: Getting ready to add some
	"secret" features

Version 2.4
----------------------------------------

32-Bit and 64-Bit Editions:
===============

Update 3.1 Minor bug fixes.

Update 3 changed the shortcut on my About page to work.

Update 2 added some new features.

64-Bit Edition:
===============

Update 3 changed some text in the About page.
Update 3 also added this column.
~~~~~~~~~~~~~~~~~~~~~~~~~~

---

## This area contains an old changelog from the 64-bit version of my app launcher.
All text is the same as the original text except for some formatting and fixing stuff Markdown doesn't like.

### 64-Bit Version History Column (the column which is deprecated on the About tab.)

~~~~~~~~~~~~~~~~~~~~~~~~~~
What's New


Version 2.5
----------------------------------------
Update 1: First version for 64-bit and 
	32-bit to have non-
	copyrighted icons. 
	Some other improvements
	and bug fixes as well.

Update 0: Getting ready to add some
	"secret" features

Version 2.4
----------------------------------------

32-Bit and 64-Bit Editions:
===============

Update 3.1 Minor bug fixes.

Update 3: Website link on About page now works.

Update 2 added some new features.

64-Bit Edition:
===============

Update 3 changed some text in the About page.
Update 3 also added this column.
~~~~~~~~~~~~~~~~~~~~~~~~~~

---

## Version 2.4.6012.2704 64-bit Changelog

This changelog is from an old version of Drew's App Launcher when it was still called "App Launcher Drew N. Edition for Microsoft Office 2010 ProPlus". Some of this changelog can be found in the old changelogs above, but there were a few changes in newer versions of this changelog that differ from this version that I wanted to preserve.

This was copied straight from the "Version History" column and includes the tabs that I put into the original text so that words wrapped to the next line.

At this point, I wrote the 64-bit vs. 32-bit as "Compiled for 64-bit systems with a 32-bit installation of Office 2010". If you're wondering about the version number, I was experimenting with having Visual Studio automatically change the version number on build. Additionally, this version's file version number is 2.4.2.0.

As I was digging in the files for this version, I discovered an `app.publish\Application Files\MSOfficeAppLauncher_2_4_2_8` folder and the app launcher EXE file version was 2.4.0.2, while the About tab reported "Version 2.4, Update 3".

Something else I could add is that this version had a large "About Window" button in the middle column that didn't do anything at this point. I was also going to work on an application launcher for use with common Mario 64 editing tools and this version was found in the Bin\Debug folder, but I never actually changed anything for it to be a Mario 64 editing tool launcher.

```
What's New
~~~~~~~~~~~~~~~~~~~~~~~~~~

Version 2.4
----------------------------------------

32-Bit and 64-Bit Editions:
===============

Update 3 changed the shortcut on my	About page to work.
Update 2 added some new features.

64-Bit Edition:
===============

Update 3 changed some text in the	About page.
Update 3 also added this column.
```

---

# Below are the changelogs from the Releases page.

---

## Drew's App Launcher version 2.6.1 32-bit:

This is the first version to:

- Be licensed under the Gnu GPL v3+ and Drew's Modification Exception, officially.
- Return to the "X.Y.Z" version numbering after I started the "X.Y. Update Z" system.
- Released after being uploaded to GitHub.
- Released as a public release. 

I recommend that you read the old changelogs in the Wiki.
Be sure to read the Readme file in the archive, too.

---

## Drew's App Launcher version 2.7 32-bit:

Just like with the 64-bit version, the new 2.7 release for my app launcher is here!

Below this text are the Zip file to extract and the source code! I will update this box with the changelog when I get that done. I will also create an installer in a few days.

There's a README file in the archive, so be sure to read it.

EDIT 3/3/2016: Alright. I got the changelog done. Here it is. I hope you like long changelogs!

Added:

++ Options window: User can now decide whether to view the changelog feed in the default browser or
using the old integrated page. This option is in the form of a checkbox and is automatically checked
by default. If this checkbox is unchecked, the "Version History" buttons on the About page will open a
small window with a WebBrowser control pointing to 
"C:\resources.drew_general\rss_feeds\drews-apps_office32launch-rss.html," or whatever the relevant file
is for that button. If the checkbox is checked, however, the buttons will simply point the
default browser to the RSS feed directly. The text for the checkbox changes depending on if
the checkbox is checked or not.

++ Options window: Added a "Clear" button to clear the Office Drive Location textbox.

++ Code changes: Added a "Region" around the Office application launcher code section to tuck it away
when modification isn't required.

++ Probably introduced a few bugs.


Modified or Changed:

// Options window: Moved portions of the UI down and resized the window to accommodate
the new changelog feed style thing option.

// Options window: Resized the bottom of the Office Drive Location groupbox up to reduce wasted space.

// Options window: Anchored the buttons at the bottom so that I don't have to try to make them perfectly
aligned with the bottom of the window when I resize it.

// Options window: A panel is now 2 pixels wider. Or taller.

// Options window: The buttons at the bottom of the window are slimmer to 
match the text on the button. Please let me know if this causes any problems.

// About tab: Updated the version number (obviously.)

// Code changes: Updated the changelog display code (Version History buttons on About tab) to accommodate
the new "changelog presentation" option.

// Code changes: Updated some code comments, such as "'Save the settings for the "Drive Selector" textbox
and other settings if I implement them," is now "'This is where to look up the drive for launching the
programs." The reason for this comment being changed in particular is because I put in a section for the 
changelog checkbox display thing option and it has its own code comment in the My.Settings section.


Removed:

-- Code changes: Removed every instance of "System.Diagnostics" from the code because it seems
like it could be a security risk, besides the fact that it doesn't seem to help with opening my 
websites. If I still have any "System.Diagnostics" in my code, please let me know.

-- Code changes: Removed excess code for the TextBox1_TextChanged event in the OptionsWindow32.vb file.
There was literally no actual code in that block.


Deprecated:

!! Support will be removed for the old internal changelog pages BY VERSION 3.0. Version 3.0 is planned
to be a stable version, and will not support the HTML RSS feed files. However, the "Version History"
buttons in the About tab will go straight to the feed on my website in the default browser.

!! Even though this is only stated in the application itself, the "Version History" textbox on the right
side of the About tab (not the "Version History" buttons which go to the RSS feed) will be removed in the
future, probably by the time version 3.0 is released. If you miss that column, don't worry because I
put all the old version history text on the Wiki on my GitHub repositories for the App Launcher. By
version 2.9 the textbox should state something along the lines of "This textbox will be removed by
version 3.0. If you would like to read the old changelogs for this application, please visit the Wiki
at <wiki address.>" If you look at that textbox in the application, you'll already notice that I don't
care about it at all, especially the formatting.

---

## Drew's App Launcher 2.8 (Snapshot Preview 1) 32-bit:

Quick note about the "Snapshot Previews;" they're prerelease versions of a future version of the software and don't represent the final release at all. They may be buggy or not have features that you expected would be in the final version. But that's OK if you just want to check out a binary release of where the code currently is instead of building it yourself!

Now that I got that out of the way, today (Saturday, May 21, 2016) I'm releasing a Snapshot Preview of version 2.8 of my app launcher! At the bottom of this page you will find Zip/Tar.Gz files with the source code as well as a Zip file (MSOAppLauncher32-Ver2.8-Preview1.zip) with the binary files precompiled! I recommend that you read the README file included in the archive for information on running the app launcher. Note that the source is available in the archive with the binaries.

Here's the changelog!

---

Added:

++ Options window: When the user clicks the "Clear" button to clear the textbox for typing in the drive location for Microsoft Office, the textbox is now selected automatically after it's cleared. Typing in a capital letter is still required.

--

Modified or Changed:

// Changed the License file a bit to make it look less confusing. I didn't touch the GPL at all; I only modified my Modification Exception and the text at the top of the document.

// The LICENSE file has been renamed to LICENSE.txt in the archive with the binaries so that people can read it easier on Windows-based devices.

// Updated copyright years from 2013-2015 to 2013-2016.

// Options window: If the user types in unacceptable characters into the textbox for drive location, the messagebox now mentions the "Clear" button.

// I changed the text of the "More Applications..." link to "Drew's GitHub Profile..." Now it takes the user to my GitHub profile instead of my drews-apps.weebly.com website. I also changed the text of the "Main Website..." link to "Drew's Main Website."

// I changed the support URL to the Issues page in this GitHub repo instead of my drews-apps.weebly.com website.

// I changed the size of some of the groupboxes and textboxes in the About tab.

// Changed the "Next" text in the titlebar to "Snapshot Preview." Also changed the sentence in the "Notes" groupbox that talks about the "Next" text in the titlebar to one that informs the user that the software they're currently using is prerelease.

// The "Version History" buttons on the About tab now take the user to my GitHub Releases feed instead of the drews-apps.weebly.com feed.

--

Removed:

-- I have disabled the Visual Studio hosting process for debugging because it was complaining about not having permission to delete the EXE files in the bin folder. As a result, I have also disabled the ClickOnce security settings.

-- Removed another instance of "System.Diagnostics," this time in the 'WaitForRSSChangelog.vb" file.

-- Deleted an extra Solution file that wasn't really doing anything.

---

## Internal Changelog Pages (internalpgs-2):

I made this release so that people could know to visit my GitHub profile just in case bloople.net ever goes down. Download the file titled "internal-changelog-pages.zip" below this text. After the 1.5 KB download is finished, extract the archive and follow the instructions in the included text file titled "where-to-find-internalpgs.txt." Note that this release does not contain a newer version of my app launcher although you can download the current source on Master below and build it yourself if you like. It's not stable yet, though.

---

## Drew's App Launcher version 2.8 (Release Preview 1) 32-bit:

For now, I'm not going to release a binary of 2.8 Release Preview 1. For those who were hoping for Snapshot Preview 2, this is just a renamed SP2. I just wasn't able to drop everything to make a preview release. Also, I'm not going to make a changelog for a few days. For now, you can go here to see the changes from SP1 to RP1: https://github.com/DrewNaylor/MSOfficeAppLauncherNext32/compare/v2.8-pre1...v2.8-pre2
There are a lot of merge commits in that comparison as well as commits not directly relating to the application.
Also note that this is the Release Candidate for version 2.8 but I forgot the proper term.

Update August 4, 2016: I've made the changelog. Here it is! There's also a Zip file with the binary at the bottom of this changelog as well.

This is the MD5 checksum of "MSOfficeAppLauncher.exe" in the Zip file:  BF0DF7FC01FA9E4790FA5EE0E7303418

You can use a tool [called MD5Check] (http://www.angusj.com/delphi/) to compare the hashes.

---

Drew's App Launcher version 2.8 Release Preview 1 changes since version 2.8 Snapshot Preview 1:

Added:

++  About tab: Added a link to this GitHub repo.

++  In the code, added a space to separate the single quote from the actual comment.

++  About tab: Added a button to take people to the wiki so that they can read the old changelogs since I'm removing the "Version History" textbox in 3.0.

++  Internal changelog pages: Added instructions telling people to visit my GitHub profile if they can't see the iframe.

++  README.md on GitHub: Added a section telling the user what the minimum recommended specifications are for running the software.

++  README.md on GitHub: Added manual compilation instructions for building from source.

++  About tab: Added blank lines between the text in the Notes box.

--

Modified or Changed:

//  When the project is built, there's a pre-build event which tells Windows PowerShell to put the current date and time in UTC into a file called "BuildDate.txt" in the Resources folder. On the About tab, the build date is now this text instead of being hard-coded by myself or other people. BuildDate.txt is also in the gitignore file.

//  The statusbar text has been changed due to another change below.

//  Both the 32-bit and the 64-bit editions now look visually identical apart from some text.

//  Replaced the text in the "Version History" column with instructions telling users to go to the wiki to read the old changelogs.

//  The text in the About and Notes textboxes are now rendered differently. Instead of typing in what I want to show up in the Designer, now the textboxes are programmatically filled with AppendText and Textbox1.Text code. This is to avoid the text getting jumbled up when building the project.

//  The text in the "Version History" textbox has been modified to be more clear.

//  Instead of using Shell to launch the Office applications, it now uses Process.Start which allows the software to appear on top of other windows instead of having to click on the taskbar button to bring them up. Note that if you use the dummyOffice suite and you're on Windows 8+ you'll have to right-click on every dummyOffice file and go into Properties and check the box that says to unblock the file and hit OK. That will have to be done on every file individually.

//  The changelogDisplayMode option has been renamed to deprecatedChangelogDisplayMode because I'm not going to support the internal changelog pages in version 3.0 or higher. It also works in reverse from what it used to be. Instead of the default having the checkbox checked, it's now unchecked. Also, the text in the Options window describing the option has been replaced with red text telling the user that the option will be removed in version 3.0. 

//  Updated nearly everything in the "Where is Microsoft Office located?" groupbox to be more friendly.

//  Changed important text in the AssmblyInfo.vb file.

//  Updated an overlooked piece of boilerplate text in the OptionsWindow.vb file in the 32-bit version.

//  Changed some text in the messagebox that pops up when the user types in illegal characters into the officeDriveLocation textbox in the Options window.

//  In the README.md file on GitHub, I put step numbers in the "How to get Up and Running with the Files in this Repo" section instead of just bullet points.

//  Updated the file "where-to-find-internalpgs.txt" so that it now tells the user about the recent changes with the changelogDisplayMode setting.

--

Removed:

--  Removed a useless TableLayoutPanel from the 32-bit version.

--  Removed scrollbars from the About window textboxes.

--  Removed code dealing with changing the checkboxChangelog text depending on if the checkbox is checked or not.

---

## Drew's App Launcher version 2.8 Stable - 32-bit

--
Version 2.8 of my app launcher is finally here! Until version 3.0, this is the biggest update yet. I hope you all enjoy the new release! I certainly enjoyed making it. If you're still using version 2.6.1 or below, make sure you upgrade because I'm not going to announce new versions on my Weebly blogs after version 2.8.

MD5 sum for "MSOfficeAppLauncher.exe" in the archive:  8F89A97E7E90D5B101382DDDC9384383

You can use a tool [called MD5Check] (http://www.angusj.com/delphi/) to compare the hashes.

Below this text is the changelog. It compares versions 2.7 and 2.8 Stable directly. Any changes made between previews will not be accounted for if they don't impact the final 2.8 release. If you want to review the changes directly, you can go here:  https://github.com/DrewNaylor/MSOfficeAppLauncherNext32/compare/v2.7...v2.8

---

Drew's App Launcher Version 2.8 Changelog:

--

Added:

++  In the (deprecated) internal changelog pages, I have added text informing the users to navigate to my GitHub profile if they can't see anything in the iframe.

++  Because the "Version History" textbox will be removed in 3.0, I have changed the text in the "Version History" textbox to inform the users of the wiki page with the old changelogs. I have also given the users a button they can click to navigate straight there.

++  I added a link to the GitHub repository in the About tab.

++  In the code, I added a space between the single-quote and the comment.

++  When the user clicks the "Clear Textbox" button in the Options window, the textbox is now set to be focused after clearing the textbox.

++  In the README.md file on GitHub, I've added a list of my minimum recommended specifications for running the software as well as a section guiding the users on how to compile it themselves.

--

Modified or Changed:

//  Instead of typing in the build date every time I make a release, the build date is now computed when the project is compiled. Due to this, Windows PowerShell is now a requirement for building this software.

//  I have updated my "Drew's Modification Exception" to make more sense and remove sections that are covered by the GPL v3+.

//  Copyright years have been updated from 2013-2015 to 2013-2016.

//  I have changed the support URL from my drews-apps.weebly.com website to the GitHub Issues page in this repository.

//  The statusbar text has been changed due to another change below.

//  Both the 32-bit and the 64-bit editions look almost identical visually apart from some text.

//  The text in the About and Notes textboxes are now rendered differently. Instead of typing in what I want to show up in the Designer, now the textboxes are programmatically filled with AppendText and Textbox1.Text code. This is to avoid the text getting jumbled up when building the project.

//  Instead of using Shell to launch the Office applications, it now uses Process.Start which allows the software to appear on top of other windows instead of having to click on the taskbar button to bring them up. Note that if you use the dummyOffice suite and you're on Windows 8+ you'll have to right-click on every dummyOffice file and go into Properties and check the box that says to unblock the file and hit OK. That will have to be done on every file individually.

//  Some text in the Notes textbox on the About tab has been updated to reflect other changes.

//  The changelogDisplayMode option has been renamed to deprecatedChangelogDisplayMode because I'm not going to support the internal changelog pages in version 3.0 or higher. It also works in reverse from what it used to be. Instead of the default having the checkbox checked, it's now unchecked. Also, the text in the Options window describing the option has been replaced with red text telling the user that the option will be removed in version 3.0.

//  Updated nearly everything in the "Where is Microsoft Office located?" groupbox to be more friendly.

//  Options window: If the user types in unacceptable characters into the textbox for drive location, the messagebox now mentions the "Clear Textbox" button.

//  I changed the text of the "More Applications..." link to "Drew's GitHub Profile..." Now it takes the user to my GitHub profile instead of my drews-apps.weebly.com website. I also changed the text of the "Main Website..." link to "Drew's Main Website."

//  Changed some important fields in the AssmeblyInfo.vb file.

//  Updated an overlooked piece of boilerplate text in the OptionsWindow.vb file in the 32-bit version.

//  Updated the file "where-to-find-internalpgs.txt" so that it now tells the user about the recent changes with the changelogDisplayMode setting (now known as deprecatedChangelogDisplayMode).

//  In the README.md file on GitHub, I put step numbers in the "How to get Up and Running with the Files in this Repo" section instead of just bullet points.

//  Added an ellipses to the "General Options" button because Microsoft says that's good UI design.

--

Removed:

--  Removed a useless TableLayoutPanel from the 32-bit edition.

--  Removed scrollbars from the About window textboxes.

--  Removed code dealing with changing the checkboxChangelog text depending on if the checkbox is checked or not.

--  I have disabled the Visual Studio hosting process for debugging because it was complaining about not having permission to delete the EXE files in the bin folder. As a result, I have also disabled the ClickOnce security settings.

--  Removed another instance of "System.Diagnostics," this time in the 'WaitForRSSChangelog.vb" file.

--  Deleted an extra Solution file from the 32-bit edition that wasn't really doing anything.