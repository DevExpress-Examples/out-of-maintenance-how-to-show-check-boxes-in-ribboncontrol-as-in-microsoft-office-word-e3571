Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.Utils
Imports DevExpress.Skins

Namespace DXSample
	Public Class MyRibbonControl
		Inherits RibbonControl
		Public Sub New()
			MyBase.New()
			AddHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf OnStyleChanged
		End Sub

		Private Sub OnStyleChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateCheckItemGlyph()
		End Sub

		Protected Overrides Function CreateBarManager() As RibbonBarManager
			Return New MyRibbonBarManager(Me)
		End Function

		Friend Sub UpdateCheckItemGlyph()
			Manager.CheckImage = Nothing
			Manager.UncheckImage = Nothing
		End Sub

		Public Shadows ReadOnly Property Manager() As MyRibbonBarManager
			Get
				Return TryCast(MyBase.Manager, MyRibbonBarManager)
			End Get
		End Property

		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				RemoveHandler DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged, AddressOf OnStyleChanged
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
