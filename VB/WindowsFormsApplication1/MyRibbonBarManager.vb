Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.Skins
Imports System.Drawing
Imports DevExpress.Utils

Namespace DXSample
	Public Class MyRibbonBarManager
		Inherits RibbonBarManager
		Private checkImage_Renamed, uncheckImage_Renamed As Image
		Public Sub New(ByVal control As RibbonControl)
			MyBase.New(control)
		End Sub

		Friend Property CheckImage() As Image
			Get
				If checkImage_Renamed Is Nothing Then
					checkImage_Renamed = GetCheckImage()
				End If
				Return checkImage_Renamed
			End Get
			Set(ByVal value As Image)
				checkImage_Renamed = value
			End Set
		End Property

		Friend Property UncheckImage() As Image
			Get
				If uncheckImage_Renamed Is Nothing Then
					uncheckImage_Renamed = GetUncheckImage()
				End If
				Return uncheckImage_Renamed
			End Get
			Set(ByVal value As Image)
				uncheckImage_Renamed = value
			End Set
		End Property


		Protected Overrides Function CreateItemViewInfo(ByVal viewInfo As DevExpress.XtraBars.Ribbon.ViewInfo.BaseRibbonViewInfo, ByVal item As IRibbonItem) As DevExpress.XtraBars.Ribbon.ViewInfo.RibbonItemViewInfo
			Dim checkButtonLink As BarCheckItemLink = TryCast(item, BarCheckItemLink)
			If checkButtonLink IsNot Nothing Then
				Dim owner As BarCheckItem = TryCast(checkButtonLink.Item, BarCheckItem)
				owner.Glyph = UncheckImage
				RemoveHandler owner.CheckedChanged, AddressOf OnCheckedChanged
				AddHandler owner.CheckedChanged, AddressOf OnCheckedChanged
				Return New MyRibbonCheckItemViewInfo(viewInfo, item)
			End If
			Return MyBase.CreateItemViewInfo(viewInfo, item)
		End Function

		Private Sub OnCheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim item As BarCheckItem = TryCast(e.Item, BarCheckItem)
			item.Glyph = If(item.Checked, CheckImage, UncheckImage)
		End Sub

		Private Function GetCheckImage() As Image
			Dim images As Images = GetImages()
			Return images(4)
		End Function

		Private Function GetUncheckImage() As Image
			Dim images As Images = GetImages()
			Return images(0)
		End Function

		Private Function GetImages() As Images
			Dim skin As Skin = EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveLookAndFeel)
			Dim elem As SkinElement = skin(EditorsSkins.SkinCheckBox)
			Return elem.Image.GetImages().Images
		End Function
	End Class
End Namespace
