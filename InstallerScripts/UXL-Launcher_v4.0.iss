; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "UXL Launcher"
#define MyAppVersion "4.0.0.0"
#define MyAppPublisher "Drew Naylor"
#define MyAppURL "https://github.com/DrewNaylor/UXL-Launcher"
#define MyAppUpdatesURL "https://github.com/DrewNaylor/UXL-Launcher/releases/latest"
#define MyAppHelpURL "https://github.com/DrewNaylor/UXL-Launcher/wiki"
#define MyAppExeName "UXL-Launcher.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{13D2774A-34D5-4941-B182-7A43B33CC4EE}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
AppVerName={#MyAppName} Version {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppHelpURL}
AppUpdatesURL={#MyAppUpdatesURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName=Drew Naylor
LicenseFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\LICENSE.txt
InfoBeforeFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\README for UXL Launcher.txt
InfoAfterFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\v4.0-stable_changelog-from_v3.3.txt
OutputDir=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher
OutputBaseFilename=UXL-Launcher_v4.0-Stable
SetupIconFile="C:\Users\Drew\Documents\Visual Studio 2015\Projects\UXL-Launcher\UXL-Launcher\Resources\UXL_Launcher_Icon_For_Windows.ico"
Compression=lzma
SolidCompression=yes
AppCopyright=Copyright 2013-2020 Drew Naylor. Licensed under the Gnu GPL v3+.
ShowLanguageDialog=no
UninstallDisplayIcon={uninstallexe}
MinVersion=0,6.1
CreateUninstallRegKey=yes
EnableDirDoesntExistWarning=True
DirExistsWarning=no
VersionInfoVersion=4.0.0.0
AlwaysShowGroupOnReadyPage=True
AlwaysShowDirOnReadyPage=True
DisableDirPage=auto
DisableProgramGroupPage=auto
WizardStyle=modern
WizardResizable=True

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\UXL-Launcher.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\README for UXL Launcher.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\source-code.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\v4.0-stable_changelog-from_v3.3.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\UXL-Launcher_upgrade.exe.config"; DestDir: "{app}"; DestName: "UXL-Launcher.exe.config"; Flags: ignoreversion
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\LICENSE_Apache-2.0.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "..\..\..\..\..\..\..\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\4_0-stable-UXL_Launcher\lib\*"; DestDir: "{app}\lib"; Flags: ignoreversion createallsubdirs recursesubdirs

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Messages]
UninstalledAll=%1 was successfully removed from your computer. Configuration files may still be present in (username)\AppData\Local\UXL_Launcher, where (username) is your user profile usually in C:\Users.
