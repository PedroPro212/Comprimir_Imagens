; ---------------------------------
; Instalador ReduzAi
; ---------------------------------

[Setup]
AppId={{B7C92F4A-3D21-4E8F-A6C9-2D4F91C5E8B2}}
AppName=ReduzAí
AppVersion=1.0.0
AppPublisher=Programação Diária

DefaultDirName={autopf}\ReduzAi
DefaultGroupName=ReduzAí

OutputDir=C:\Users\Pedro\Desktop
OutputBaseFilename=Instalador_ReduzAi

SetupIconFile=C:\Codigos\Comprimir_Imagens\Sistema 2 - C#\ComprimirImagens\ComprimirImagens\Logo.ico
UninstallDisplayIcon={app}\Logo.ico

Compression=lzma
SolidCompression=yes

PrivilegesRequired=admin
WizardStyle=modern

; Permite apenas Windows 64 bits
ArchitecturesAllowed=x64
ArchitecturesInstallIn64BitMode=x64

; ---------------------------------
; IDIOMA
; ---------------------------------

[Languages]
Name: "portuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"

; ---------------------------------
; TAREFAS
; ---------------------------------

[Tasks]
Name: "desktopicon"; Description: "Criar atalho na área de trabalho"; GroupDescription: "Atalhos:"

; ---------------------------------
; ARQUIVOS
; ---------------------------------

[Files]

; Executável principal
Source: "C:\Codigos\Comprimir_Imagens\Sistema 2 - C#\ComprimirImagens\ComprimirImagens\bin\Release\ComprimirImagens.exe"; \
DestDir: "{app}"; Flags: ignoreversion

; DLLs necessárias (IMPORTANTE)
Source: "C:\Codigos\Comprimir_Imagens\Sistema 2 - C#\ComprimirImagens\ComprimirImagens\bin\Release\*.dll"; \
DestDir: "{app}"; Flags: ignoreversion

; Arquivos de configuração
Source: "C:\Codigos\Comprimir_Imagens\Sistema 2 - C#\ComprimirImagens\ComprimirImagens\bin\Release\*.config"; \
DestDir: "{app}"; Flags: ignoreversion

; Ícone
Source: "C:\Codigos\Comprimir_Imagens\Sistema 2 - C#\ComprimirImagens\ComprimirImagens\Logo.ico"; \
DestDir: "{app}"; Flags: ignoreversion

; ---------------------------------
; ATALHOS
; ---------------------------------

[Icons]

Name: "{group}\ReduzAí"; \
Filename: "{app}\ComprimirImagens.exe"; \
IconFilename: "{app}\Logo.ico"

Name: "{commondesktop}\ReduzAí"; \
Filename: "{app}\ComprimirImagens.exe"; \
Tasks: desktopicon; \
IconFilename: "{app}\Logo.ico"

; ---------------------------------
; EXECUTAR APÓS INSTALAÇÃO
; ---------------------------------

[Run]
Filename: "{app}\ComprimirImagens.exe"; \
Description: "Executar ReduzAí"; \
Flags: nowait postinstall skipifsilent

; ---------------------------------
; DESINSTALAÇÃO
; ---------------------------------

[UninstallDelete]
Type: filesandordirs; Name: "{app}"