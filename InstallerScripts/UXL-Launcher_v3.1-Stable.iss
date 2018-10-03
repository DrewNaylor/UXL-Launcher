; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "UXL Launcher"
#define MyAppVersion "3.1.0.0"
#define MyAppPublisher "Drew Naylor"
#define MyAppURL "https://github.com/DrewNaylor/UXL-Launcher"
#define MyAppUpdatesURL "https://github.com/DrewNaylor/UXL-Launcher/releases/latest"
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
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppUpdatesURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName=Drew Naylor
AllowNoIcons=yes
LicenseFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\LICENSE.txt
InfoBeforeFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\README for UXL Launcher.txt
InfoAfterFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\v3.1_changelog-from-v3.0.txt
OutputDir=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher
OutputBaseFilename=UXL-Launcher_v3.1-Stable
SetupIconFile=C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\UXL-Launcher.ico
Compression=lzma
SolidCompression=yes
AppCopyright=Copyright 2013-2018 Drew Naylor. Licensed under the Gnu GPL v3+.
ShowLanguageDialog=no
UninstallDisplayIcon={uninstallexe}
MinVersion=0,6.1

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\UXL-Launcher.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\LICENSE.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\README for UXL Launcher.txt"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\source-code.zip"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\UXL-Launcher.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "C:\DrewN Desktop Apps\Binaries\App Launcher Zip Files\uxl-launcher\3_1-stable-UXL_Launcher\v3.1_changelog-from-v3.0.txt"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
