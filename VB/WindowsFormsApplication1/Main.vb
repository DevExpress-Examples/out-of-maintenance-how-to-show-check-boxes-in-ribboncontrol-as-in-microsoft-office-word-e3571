Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms


Namespace DXSample
	Partial Public Class Main
		Inherits Form
		Public Sub New()
			InitializeComponent()
			propertyGridControl1.SelectedObject = defaultLookAndFeel1.LookAndFeel
		End Sub
	End Class
End Namespace
