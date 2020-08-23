; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "Fallout 76 Quick Configuration"
#define MyAppPublisher "datasnake"
#define MyAppURL "https://www.nexusmods.com/fallout76/mods/546"
#define MyAppExeName "Fo76ini.exe"

#define ProjectVersion "1.8.1h1"
#define ProjectBaseDir "C:\Users\Thomas\Documents\Fallout 76 Quick Configuration - Project files"
#define ProjectGitDir "C:\Users\Thomas\Documents\Fallout 76 Quick Configuration - Project files\Fallout76-QuickConfiguration"

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{997D2843-19B3-4AB4-A879-8AC56ACA26D4}
AppName={#MyAppName}
AppVersion={#ProjectVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
LicenseFile={#ProjectGitDir}\LICENSE
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
PrivilegesRequiredOverridesAllowed=dialog
OutputDir={#ProjectBaseDir}\Files\Main Files\v{#ProjectVersion}
OutputBaseFilename=Setup_v{#ProjectVersion}
SetupIconFile={#ProjectBaseDir}\Fallout76-QuickConfiguration\Fo76ini\icon.ico
Compression=lzma
SolidCompression=yes
WizardStyle=modern
DisableWelcomePage=no

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "{#ProjectBaseDir}\Files\Main Files\v{#ProjectVersion}\v{#ProjectVersion}_bin\Fo76ini.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "{#ProjectBaseDir}\Files\Main Files\v{#ProjectVersion}\v{#ProjectVersion}_bin\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

