# Known issues.

[See all known issues.](https://github.com/DrewNaylor/UXL-Launcher/labels/known%20issue)

- Launching Office 2013 installed via Office 365 on a 64-bit computer requires UXL Launcher to be set to 32-bit Windows. [(issue #43)](https://github.com/DrewNaylor/UXL-Launcher/issues/43)

- ~~If the user chooses to test their settings and Office Language Preferences can't be launched and they choose to open the Options window, a duplicate Options window spawns. [(issue #46)](https://github.com/DrewNaylor/UXL-Launcher/issues/46)~~ Fixed in [f697e75](https://github.com/DrewNaylor/UXL-Launcher/commit/f697e75552dd19e8d66db12e775adc559c87e953)

- CryptoPrevent Maximum protection settings block Windows PowerShell from running thus halting the build process. [(issue #52)](https://github.com/DrewNaylor/UXL-Launcher/issues/52)

- ~~If the main window is set to Always On Top and the user opens the Options window from the Quickmenu and clicks on a window behind the UXL Launcher window, the Options window will not be able to be interacted with until the user right-clicks on the Quickmenu icon again. [(issue #53)](https://github.com/DrewNaylor/UXL-Launcher/issues/53)~~ Fixed in [94edb9d](https://github.com/DrewNaylor/UXL-Launcher/commit/94edb9d042fb9e06c9244cda54ff83ae7bd6ab03) and [7875980](https://github.com/DrewNaylor/UXL-Launcher/commit/7875980c2c8c8c272d544146788e96f0fa9aad35)

- Statusbar text is cut off when using the Windows High Contrast White theme. [(issue #58)](https://github.com/DrewNaylor/UXL-Launcher/issues/58)

- Sometimes aaformMainWindow.vb (main UXL Launcher window) doesn't display properly in the Visual Studio Design view before building the project. [(issue #97)](https://github.com/DrewNaylor/UXL-Launcher/issues/97)

- If a UXL Launcher pinned shortcut on the taskbar is set to run minimized and "Hide When Minimized" is enabled in UXL Launcher, upon clicking the shortcut, the app will start, place the Quickmenu in the system tray, and highlight the pinned icon in the taskbar for a few seconds, then the highlight goes away. [(issue #120)](https://github.com/DrewNaylor/UXL-Launcher/issues/120)

- ~~UXL Launcher builds from AppVeyor may have text in the About window crammed together. [(issue #121)](https://github.com/DrewNaylor/UXL-Launcher/issues/121)~~ Fixed in [093d972](https://github.com/DrewNaylor/UXL-Launcher/commit/093d9722b3d3cfc4043543994b2d498772508a48)

- ~~If the main window is minimized, "Hide When Minimized" is enabled, and a program couldn't be found when using the Quickmenu to open a program, the error message won't be on top. [(issue #125)](https://github.com/DrewNaylor/UXL-Launcher/issues/125)~~ Needs verification; might not be an actual problem

- ~~Numbers such as 1.01.1 used for the UseThemeEngineVersion tag/element will crash UXL Launcher with an exception of System.InvalidCastException because it's trying to convert the value from a string to a decimal type. [(issue #126)](https://github.com/DrewNaylor/UXL-Launcher/issues/126)~~ Fixed in [9dc5474](https://github.com/DrewNaylor/UXL-Launcher/commit/9dc5474e2a4e11e3cbd98ba7e50d9c0550aadd0b)