'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.6407
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Namespace Properties


	<System.Runtime.CompilerServices.CompilerGeneratedAttribute> _
	<System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")> _
	Friend NotInheritable Partial Class Settings
		Inherits Global.System.Configuration.ApplicationSettingsBase

		Private Shared defaultInstance As Settings = DirectCast(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

		Public Shared ReadOnly Property [Default]() As Settings
			Get
				Return defaultInstance
			End Get
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("My First Form")> _
		Public Property FirstFormHeader() As String
			Get
				Return DirectCast(Me("FirstFormHeader"), String)
			End Get
			Set
				Me("FirstFormHeader") = value
			End Set
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("&Save")> _
		Public Property SaveButtonText() As String
			Get
				Return DirectCast(Me("SaveButtonText"), String)
			End Get
			Set
				Me("SaveButtonText") = value
			End Set
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("Normal")> _
		Public Property FormWindowState() As Global.System.Windows.Forms.FormWindowState
			Get
				Return CType(Me("FormWindowState"), Global.System.Windows.Forms.FormWindowState)
			End Get
			Set
				Me("FormWindowState") = value
			End Set
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("ControlText")> _
		Public Property FormForeColor() As Global.System.Drawing.Color
			Get
				Return CType(Me("FormForeColor"), Global.System.Drawing.Color)
			End Get
			Set
				Me("FormForeColor") = value
			End Set
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("1")> _
		Public Property FormOpacity() As Double
			Get
				Return CDbl(Me("FormOpacity"))
			End Get
			Set
				Me("FormOpacity") = value
			End Set
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("Control")> _
		Public Property FormBackColor() As Global.System.Drawing.Color
			Get
				Return CType(Me("FormBackColor"), Global.System.Drawing.Color)
			End Get
			Set
				Me("FormBackColor") = value
			End Set
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("Control")> _
		Public Property ButtonBackColor() As Global.System.Drawing.Color
			Get
				Return CType(Me("ButtonBackColor"), Global.System.Drawing.Color)
			End Get
			Set
				Me("ButtonBackColor") = value
			End Set
		End Property

		<System.Configuration.UserScopedSettingAttribute> _
		<System.Diagnostics.DebuggerNonUserCodeAttribute> _
		<System.Configuration.DefaultSettingValueAttribute("Koos se waarde")> _
		Public Property Koos() As String
			Get
				Return DirectCast(Me("Koos"), String)
			End Get
			Set
				Me("Koos") = value
			End Set
		End Property
	End Class
End Namespace
