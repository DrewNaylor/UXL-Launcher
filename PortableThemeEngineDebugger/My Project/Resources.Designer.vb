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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("PortableThemeEngineDebugger.Resources", GetType(Resources).Assembly)
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
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;UXL_Launcher_Theme&gt;
        '''  &lt;Title&gt;Return of the Night&lt;/Title&gt;
        '''  &lt;Description&gt;Based on the Test2 theme, &quot;Return of the Night&quot; is a purple theme best suited for those who like proper day/night cycles.&lt;/Description&gt;
        '''  &lt;Version&gt;v1.2&lt;/Version&gt;
        '''  &lt;Author&gt;Drew Naylor&lt;/Author&gt;
        '''
        '''  &lt;!-- &quot;UseThemeEngineVersion&quot; is used to specify the version of the
        '''  UXL Launcher Theme Engine to use in case there are changes in newer
        '''  versions of the theme engine that designers or developers don&apos;t want
        '''  to use. Version 1.01 is  [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property ReturnOfNightTheme_XML() As String
            Get
                Return ResourceManager.GetString("ReturnOfNightTheme_XML", resourceCulture)
            End Get
        End Property
    End Module
End Namespace
