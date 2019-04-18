﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Public Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("UXL_Launcher.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Public Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Access() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Access", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\ansicpg1252\deff0\nouicompat\deflang1033{\fonttbl{\f0\fnil\fcharset0 Calibri;}{\f1\fnil\fcharset2 Symbol;}}
        '''{\*\generator Riched20 10.0.14393}\viewkind4\uc1 
        '''\pard\sl240\slmult1\qc\b\f0\fs10\lang9\par
        '''
        '''\pard\sl276\slmult1\qc\fs32 UXL Launcher Acknowledgements\b0\par
        '''
        '''\pard\sl360\slmult1\fs24\par
        '''
        '''\pard{\pntext\f1\&apos;B7\tab}{\*\pn\pnlvlblt\pnf1\pnindent0{\pntxtb\&apos;B7}}\fi-360\li720\sl360\slmult1 Original idea: God\par
        '''{\pntext\f1\&apos;B7\tab}Moral support: My mom, Nana, Mitty, and all my friend [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Acknowledgements_RTF() As String
            Get
                Return ResourceManager.GetString("Acknowledgements_RTF", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to applauncher-icons
        '''By Drew Naylor. Licensed under CC BY 4.0.
        '''Version 2.1
        '''
        '''The applauncher-icons project provides most of the icons used in UXL Launcher, with the exception of some icons. These include, but are not limited to, the UXL Launcher logo and the About window banner.
        '''
        '''Link to applauncher-icons project repository:
        '''https://github.com/DrewNaylor/applauncher-icons
        '''
        '''Link to applauncher-icons version 2.1 GitHub Releases page:
        '''https://github.com/DrewNaylor/applauncher-icons/releases/tag/v2.1
        '''
        '''T [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property ApplauncherIconsInfo_TXT() As String
            Get
                Return ResourceManager.GetString("ApplauncherIconsInfo_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to  - Codename &quot;(unknown for now)&quot;.
        '''</summary>
        Public ReadOnly Property appVersionCodename() As String
            Get
                Return ResourceManager.GetString("appVersionCodename", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 2019-04-18T06:46:58
        '''.
        '''</summary>
        Public ReadOnly Property BuildDate() As String
            Get
                Return ResourceManager.GetString("BuildDate", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Clip_Organizer() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Clip_Organizer", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property DARK_UXL_Launcher_Banner() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("DARK_UXL_Launcher_Banner", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Default Theme&lt;/Title&gt;
        '''  &lt;Description&gt;Default is the theme UXL Launcher ships with.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.0&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''  
        '''    &lt;Theme_Colors&gt;
        '''      
        '''      &lt;Button&gt;
        '''        &lt;BackColor&gt;Transparent&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;ControlText&lt;/ForeColor&gt;
        '''      &lt;/Button&gt;
        '''      
        '''      &lt;GroupBox&gt;
        '''        &lt;BackColor&gt;Transparent&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;ControlText&lt;/ForeColor&gt;
        '''      &lt;/GroupBox&gt;
        '''
        '''      &lt;FlowLayoutPanel&gt;
        '''        &lt;B [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property DefaultTheme_XML() As String
            Get
                Return ResourceManager.GetString("DefaultTheme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Excel() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Excel", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Eyesore 2&lt;/Title&gt;
        '''  &lt;Description&gt;Originally a test theme for UXL Launcher, Eyesore 2 is meant to be a spiritual successor to the Windows 3.1 Hotdog Stand theme, but worse.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.0&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''  
        '''    &lt;Theme_Colors&gt;
        '''      
        '''      &lt;Button&gt;
        '''        &lt;BackColor&gt;Maroon&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;White&lt;/ForeColor&gt;
        '''      &lt;/Button&gt;
        '''      
        '''      &lt;GroupBox&gt;
        '''        &lt;BackColor&gt;Green&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;Blue&lt;/For [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Eyesore2Theme_XML() As String
            Get
                Return ResourceManager.GetString("Eyesore2Theme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Eyesore&lt;/Title&gt;
        '''  &lt;Description&gt;Eyesore is a theme that&apos;s meant to be a tribute to Windows 3.1&apos;s Hot Dog Stand theme. The &quot;Eyesore&quot; theme and Drew Naylor are not associated with Microsoft Corporation in any way, shape, or form. Windows 3.1 and all related words are copyright and trademark/registered trademark Microsoft Corporation in the United States and other countries. All rights reserved to Microsoft Corp. for Microsoft Corp.&apos;s copyrights and trademarks/registered trademar [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property EyesoreTheme_XML() As String
            Get
                Return ResourceManager.GetString("EyesoreTheme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to {\rtf1\ansi\deff0\nouicompat{\fonttbl{\f0\fswiss Helvetica;}{\f1\fswiss\fcharset0 Helvetica;}{\f2\fnil Courier;}}
        '''{\colortbl ;\red0\green0\blue255;}
        '''{\*\generator Riched20 10.0.14393}\viewkind4\uc1 
        '''\pard\sa180\b\f0\fs28\lang9 GNU GENERAL PUBLIC LICENSE\par
        '''\b0\fs24 Version 3, 29 June 2007\par
        '''Copyright \f1\&apos;a9 2007 Free Software Foundation, Inc. &lt;{{\field{\*\fldinst{HYPERLINK &quot;http://fsf.org/&quot;}}{\fldrslt{http://fsf.org/\ul0\cf0}}}}\f1\fs24 &gt;\par
        '''\f0 Everyone is permitted to copy and distribute verbat [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property gpl_RTF() As String
            Get
                Return ResourceManager.GetString("gpl_RTF", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Infopath() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Infopath", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Git.
        '''</summary>
        Public ReadOnly Property isStable() As String
            Get
                Return ResourceManager.GetString("isStable", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Language_Settings() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Language_Settings", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Maudern&lt;/Title&gt;
        '''  &lt;Description&gt;Maudern is a simple, flat theme with a grey color scheme similar in appearance to rock coloration.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.0&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''
        '''  &lt;!-- &quot;UseThemeEngineVersion&quot; is used to specify the version of the
        '''  UXL Launcher Theme Engine to use in case there are changes in newer
        '''  versions of the theme engine that designers or developers don&apos;t want
        '''  to use. Version 1.01 is the oldest version number available [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property MaudernTheme_XML() As String
            Get
                Return ResourceManager.GetString("MaudernTheme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Microsoft_Query() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Microsoft_Query", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Onenote() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Onenote", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Outlook() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Outlook", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Picture_Manager() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Picture_Manager", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Powerpoint() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Powerpoint", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Publisher() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Publisher", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Return of the Night&lt;/Title&gt;
        '''  &lt;Description&gt;Based on the Test2 theme, &quot;Return of the Night&quot; is a purple theme best suited for those who like proper day/night cycles.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.0&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''  
        '''    &lt;Theme_Colors&gt;
        '''      
        '''      &lt;Button&gt;
        '''        &lt;BackColor&gt;MidnightBlue&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;White&lt;/ForeColor&gt;
        '''      &lt;/Button&gt;
        '''      
        '''      &lt;GroupBox&gt;
        '''        &lt;BackColor&gt;Indigo&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;White&lt;/Fo [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property ReturnOfNightTheme_XML() As String
            Get
                Return ResourceManager.GetString("ReturnOfNightTheme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Arr G. Bee&lt;/Title&gt;
        '''  &lt;Description&gt;Arr G. Bee is a theme that&apos;s influenced by the UXL Launcher logo.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.0&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''  
        '''    &lt;Theme_Colors&gt;
        '''      
        '''      &lt;Button&gt;
        '''        &lt;BackColor&gt;RoyalBlue&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;Lime&lt;/ForeColor&gt;
        '''        &lt;!-- The FlatStyle determines the &quot;depth&quot; of the buttons. This can be set
        '''        to either &quot;Flat&quot; or &quot;Standard&quot;. Anything else will be set to &quot;Standard&quot;.
        '''        Quotat [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property RGBTheme_XML() As String
            Get
                Return ResourceManager.GetString("RGBTheme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ----------------------------------------------------------------------------------------.
        '''</summary>
        Public ReadOnly Property separator() As String
            Get
                Return ResourceManager.GetString("separator", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Sharepoint_Workspace() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Sharepoint_Workspace", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Access() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Access", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Excel() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Excel", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Infopath() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Infopath", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Language_Settings() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Language_Settings", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Onenote() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Onenote", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Outlook() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Outlook", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Powerpoint() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Powerpoint", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Publisher() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Publisher", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Sharepoint() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Sharepoint", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property small_Word() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("small_Word", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 14,15,16,16nomsi.
        '''</summary>
        Public ReadOnly Property supportedOfficeVersionList() As String
            Get
                Return ResourceManager.GetString("supportedOfficeVersionList", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Ten Dark&lt;/Title&gt;
        '''  &lt;Description&gt;A dark theme similar to Windows 10&apos;s &quot;Dark Mode&quot;.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.0&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''
        '''  &lt;!-- &quot;UseThemeEngineVersion&quot; is used to specify the version of the
        '''  UXL Launcher Theme Engine to use in case there are changes in newer
        '''  versions of the theme engine that designers or developers don&apos;t want
        '''  to use. Version 1.01 is the oldest version number available and anything
        '''  smaller than that will automati [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property TenDarkTheme_XML() As String
            Get
                Return ResourceManager.GetString("TenDarkTheme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Copyright (C) 2013-2019 Drew Naylor. Licensed under Gnu GPLv3+.
        '''The copyright and license info is the same for the theme engine as it is for UXL Launcher itself as the theme engine is built into the same file as UXL Launcher.
        '''
        '''The UXL Launcher Theme Engine can make the UXL Launcher main window look slightly better and can also use custom themes.
        '''Please be aware that UXL Launcher and the UXL Launcher Theme Engine are both unofficial and not made by Microsoft.
        '''Note that the &quot;License&quot; tab contains only th [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property ThemeEngineInfo_TXT() As String
            Get
                Return ResourceManager.GetString("ThemeEngineInfo_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to 1.03.
        '''</summary>
        Public ReadOnly Property themeEngineVersion() As String
            Get
                Return ResourceManager.GetString("themeEngineVersion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Default,Eyesore,Eyesore2,Maudern,ReturnOfNight,RGB,TenDark,(Custom).
        '''</summary>
        Public ReadOnly Property themeList_TXT() As String
            Get
                Return ResourceManager.GetString("themeList_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Unsafe file extensions blocked from opening in &quot;File&gt;Open...&quot; menu. Source for some of them: https://www.howtogeek.com/137270/50-file-extensions-that-are-potentially-dangerous-on-windows/
        '''.EXE
        '''.PIF
        '''.APPLICATION
        '''.GADGET
        '''.MSI
        '''.MSP
        '''.COM
        '''.SCR
        '''.HTA
        '''.CPL
        '''.MSC
        '''.JAR
        '''.BAT
        '''.CMD
        '''.VBS
        '''.VBE
        '''.JS
        '''.JSE
        '''.WS
        '''.WSF
        '''.WSC
        '''.WSH
        '''.PS1
        '''.PS1XML
        '''.PS2
        '''.PS2XML
        '''.PSC1
        '''.PSC2
        '''.MSH
        '''.MSH1
        '''.MSH2
        '''.MSHXML
        '''.MSH1XML
        '''.MSH2XML
        '''.SCF
        '''.LNK
        '''.INF
        '''.REG
        '''.SWF
        '''.AHK.
        '''</summary>
        Public ReadOnly Property unsafeExtensions_TXT() As String
            Get
                Return ResourceManager.GetString("unsafeExtensions_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property uxl_icon_24x24() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("uxl_icon_24x24", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property UXL_Launcher_Banner() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("UXL_Launcher_Banner", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Copyright (C) 2013-2019 Drew Naylor. Licensed under Gnu GPLv3+.
        '''
        '''UXL Launcher provides launchers for most Microsoft Office apps in one place.
        '''Please be aware that UXL Launcher is unofficial and not made by Microsoft.
        '''Note that the &quot;License&quot; tab contains only the license for UXL Launcher. Other licenses are linked to from each component&apos;s information area below, if they are different.
        '''
        '''License notice:
        '''UXL Launcher is free software: you can redistribute it and/or modify it under the terms of the GNU Ge [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property UXLLauncherInfo_TXT() As String
            Get
                Return ResourceManager.GetString("UXLLauncherInfo_TXT", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property Word() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Word", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
