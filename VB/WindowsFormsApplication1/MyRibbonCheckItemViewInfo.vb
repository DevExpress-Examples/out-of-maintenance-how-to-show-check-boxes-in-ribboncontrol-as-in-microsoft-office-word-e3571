Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.Skins
Imports System.Drawing
Imports DevExpress.XtraBars.Ribbon

Namespace DXSample
	Public Class MyRibbonCheckItemViewInfo
		Inherits RibbonCheckItemViewInfo
		Private glyphIndent As Integer = 2
		Public Sub New(ByVal viewInfo As BaseRibbonViewInfo, ByVal item As IRibbonItem)
			MyBase.New(viewInfo, item)
		End Sub

		Public Overrides Function GetItemInfo() As DevExpress.Skins.SkinElementInfo
			Dim info As SkinElementInfo = MyBase.GetItemInfo()
			If info.State <> DevExpress.Utils.Drawing.ObjectState.Normal Then
				Dim rect As Rectangle = info.Bounds
				info.Bounds = New Rectangle(GlyphBounds.X - glyphIndent, rect.Y, GlyphBounds.Width + 2 * glyphIndent, rect.Height)
			End If
			Return info
		End Function
	End Class
End Namespace
