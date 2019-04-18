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

- Note that you might have problems with running this on corporate computers. The ClickOnce security settings are disabled in UXL Launcher due to Visual Studio building problems.

- Disk space, RAM, and CPU frequency requirements are based on the .Net Framework 4.6.1 requirements. UXL Launcher itself is quite small.

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