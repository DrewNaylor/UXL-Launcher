; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "UXL Launcher"
#define MyAppVersion "3.2.0.0"
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
AllowNoIcons=yes
LicenseFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\LICENSE.txt
InfoBeforeFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\README for UXL Launcher.txt
InfoAfterFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\v3.2-stable_changelog-from-v3.1.txt
OutputDir=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher
OutputBaseFilename=UXL-Launcher_v3.2-Stable
SetupIconFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-rc1-UXL_Launcher\UXL-Launcher.ico
Compression=lzma
SolidCompression=yes
AppCopyright=Copyright 2013-2019 Drew Naylor. Licensed under the Gnu GPL v3+.
ShowLanguageDialog=no
UninstallDisplayIcon={uninstallexe}
MinVersion=0,6.1
CreateUninstallRegKey=yes
EnableDirDoesntExistWarning=True
DirExistsWarning=no
VersionInfoVersion=3.2.0.0

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\UXL-Launcher.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\README for UXL Launcher.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\source-code.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\UXL-Launcher.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_2-stable-UXL_Launcher\v3.2-stable_changelog-from-v3.1.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

[Messages]
UninstalledAll=%1 was successfully removed from your computer. Configuration files may still be present in (username)\AppData\Local\UXL_Launcher, where (username) is your user profile usually in C:\Users.
