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
        '''  Looks up a localized string similar to 2018-01-13T01:32:23
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
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Default Theme&lt;/Title&gt;
        '''  &lt;Description&gt;Default is the theme UXL Launcher ships with.&lt;/Description&gt;
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
        '''        &lt;BackColor&gt;Window&lt;/BackColor&gt; [rest of string was truncated]&quot;;.
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
        '''  &lt;Title&gt;Eyesore&lt;/Title&gt;
        '''  &lt;Description&gt;Eyesore is a theme that&apos;s meant to be a tribute to Windows 3.1&apos;s Hot Dog Stand theme.&lt;/Description&gt;
        '''  &lt;Author&gt;Original Hotdog Stand theme by Microsoft; implemented as UXL Launcher theme by Drew Naylor&lt;/Author&gt;
        '''  
        '''    &lt;Theme_Colors&gt;
        '''      
        '''      &lt;Button&gt;
        '''        &lt;BackColor&gt;LightGray&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;Black&lt;/ForeColor&gt;
        '''      &lt;/Button&gt;
        '''      
        '''      &lt;GroupBox&gt;
        '''        &lt;BackColor&gt;Red&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;White&lt;/Fore [rest of string was truncated]&quot;;.
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
        '''        &lt;ForeColor&gt;White&lt;/ForeColor&gt;
        '''      &lt;/GroupBox&gt; [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property ReturnOfNightTheme_XML() As String
            Get
                Return ResourceManager.GetString("ReturnOfNightTheme_XML", resourceCulture)
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
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Test2&lt;/Title&gt;
        '''  &lt;Description&gt;An improved test theme for UXL Launcher.&lt;/Description&gt;
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
        '''        &lt;ForeColor&gt;White&lt;/ForeColor&gt;
        '''      &lt;/GroupBox&gt;
        '''
        '''      &lt;FlowLayoutPanel&gt;
        '''        &lt;BackColor&gt;DarkViolet&lt;/BackColor&gt;
        '''        &lt;ForeColor&gt;Whit [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property Test2Theme_XML() As String
            Get
                Return ResourceManager.GetString("Test2Theme_XML", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Eyesore 2&lt;/Title&gt;
        '''  &lt;Description&gt;Originally a test theme for UXL Launcher, Eyesore 2 is meant to be a spiritual successor to the Windows 3.1 Hotdog Stand theme, but worse.&lt;/Description&gt;
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
        '''        &lt;ForeColor&gt;Blue&lt;/ForeColor&gt;
        '''      &lt;/GroupBox&gt;        ''' [rest of string was truncated]&quot;;.
        '''</summary>
        Public ReadOnly Property TestTheme_XML() As String
            Get
                Return ResourceManager.GetString("TestTheme_XML", resourceCulture)
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
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Public ReadOnly Property UXL_Standalone_Icon() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("UXL_Standalone_Icon", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
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
