﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.6.0.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "Funcionalidad para autoguardar My.Settings"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=SERVIDOR-BD;Initial Catalog=colegio;Persist Security Info=True;User I"& _ 
            "D=colegio;Password=C0leg10")>  _
        Public ReadOnly Property colegioConnectionString() As String
            Get
                Return CType(Me("colegioConnectionString"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Colegio Santa Ana")>  _
        Public Property institucion() As String
            Get
                Return CType(Me("institucion"),String)
            End Get
            Set
                Me("institucion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Liberia, Guanacaste")>  _
        Public Property encabezado1() As String
            Get
                Return CType(Me("encabezado1"),String)
            End Get
            Set
                Me("encabezado1") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("2325-6566")>  _
        Public Property encabezado2() As String
            Get
                Return CType(Me("encabezado2"),String)
            End Get
            Set
                Me("encabezado2") = value
            End Set
        End Property
        
        <Global.System.Configuration.ApplicationScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=SERVIDOR-BD;Initial Catalog=colegio;Persist Security Info=True;User I"& _ 
            "D=colegio;Password=C0leg10")>  _
        Public ReadOnly Property colegioConnectionString1() As String
            Get
                Return CType(Me("colegioConnectionString1"),String)
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property impresora() As String
            Get
                Return CType(Me("impresora"),String)
            End Get
            Set
                Me("impresora") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Data Source=SERVIDOR-BD;Initial Catalog=colegio;Persist Security Info=True;User I"& _ 
            "D=sa;Password=123")>  _
        Public Property conexionSQL() As String
            Get
                Return CType(Me("conexionSQL"),String)
            End Get
            Set
                Me("conexionSQL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Admin() As String
            Get
                Return CType(Me("Admin"),String)
            End Get
            Set
                Me("Admin") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property msj1Cobro() As String
            Get
                Return CType(Me("msj1Cobro"),String)
            End Get
            Set
                Me("msj1Cobro") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property msj2Cobro() As String
            Get
                Return CType(Me("msj2Cobro"),String)
            End Get
            Set
                Me("msj2Cobro") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Hna. Mercedes Quirós Quirós")>  _
        Public Property Directora() As String
            Get
                Return CType(Me("Directora"),String)
            End Get
            Set
                Me("Directora") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Directora")>  _
        Public Property cargo() As String
            Get
                Return CType(Me("cargo"),String)
            End Get
            Set
                Me("cargo") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("Educar Evangelizado desde la Hospitalidad")>  _
        Public Property Slogan() As String
            Get
                Return CType(Me("Slogan"),String)
            End Get
            Set
                Me("Slogan") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("https://csalib.tk/app/colegio/colegio.xml")>  _
        Public Property ServActilizacion() As String
            Get
                Return CType(Me("ServActilizacion"),String)
            End Get
            Set
                Me("ServActilizacion") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("102500")>  _
        Public Property matricula() As Decimal
            Get
                Return CType(Me("matricula"),Decimal)
            End Get
            Set
                Me("matricula") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("102500")>  _
        Public Property prematricula() As Decimal
            Get
                Return CType(Me("prematricula"),Decimal)
            End Get
            Set
                Me("prematricula") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.colegio.My.MySettings
            Get
                Return Global.colegio.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
