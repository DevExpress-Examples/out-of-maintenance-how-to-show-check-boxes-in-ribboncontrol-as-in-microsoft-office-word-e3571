Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.ribbonControl1 = New DXSample.MyRibbonControl()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.propertyGridControl1 = New DevExpress.XtraVerticalGrid.PropertyGridControl()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonText = Nothing
			' 
			' 
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barCheckItem1})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 2
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemCheckEdit1})
			Me.ribbonControl1.SelectedPage = Me.ribbonPage1
			Me.ribbonControl1.Size = New System.Drawing.Size(578, 143)
			Me.ribbonControl1.TransparentEditors = True
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "barCheckItem1"
			Me.barCheckItem1.Id = 0
			Me.barCheckItem1.Name = "barCheckItem1"
			Me.barCheckItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' repositoryItemCheckEdit1
			' 
			Me.repositoryItemCheckEdit1.AllowFocused = False
			Me.repositoryItemCheckEdit1.AutoHeight = False
			Me.repositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default
			Me.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1"
			Me.repositoryItemCheckEdit1.UseParentBackground = True
			' 
			' propertyGridControl1
			' 
			Me.propertyGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.propertyGridControl1.Location = New System.Drawing.Point(0, 143)
			Me.propertyGridControl1.Name = "propertyGridControl1"
			Me.propertyGridControl1.Size = New System.Drawing.Size(578, 297)
			Me.propertyGridControl1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(578, 440)
			Me.Controls.Add(Me.propertyGridControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.propertyGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private ribbonControl1 As MyRibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
		Private repositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Private propertyGridControl1 As DevExpress.XtraVerticalGrid.PropertyGridControl
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
	End Class
End Namespace

