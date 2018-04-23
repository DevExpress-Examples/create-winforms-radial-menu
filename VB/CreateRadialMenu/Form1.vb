Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars

Namespace CreateRadialMenu
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
			' Create and display Radial Menu
			AddHandler barManager1.ItemClick, AddressOf barManager1_ItemClick
			Dim menu As New RadialMenu()
			menu.Manager = barManager1
			menu.AddItems(CreateBarItems())

			Dim pt As Point = Me.Location
			pt.Offset(Me.Width \ 2, Me.Height \ 2)
			menu.ShowPopup(pt)
		End Sub

		Private Function CreateBarItems() As BarItem()
			' Create bar items to display in Radial Menu
			barManager1.Images = imageCollection1

			Dim barButtonItem0 As BarItem = New BarButtonItem(barManager1, "Copy", 0)
			Dim barButtonItem1 As BarItem = New BarButtonItem(barManager1, "Cut", 1)
			Dim barButtonItem2 As BarItem = New BarButtonItem(barManager1, "Delete", 2)
			Dim barButtonItem3 As BarItem = New BarButtonItem(barManager1, "Paste", 3)

			' Sub-menu with 3 check buttons
			Dim subMenu As New BarSubItem(barManager1, "Format")
			Dim barCheckItem4 As New BarCheckItem(barManager1, False) With {.ImageIndex = 4, .Caption = "Bold"}
			Dim barCheckItem5 As New BarCheckItem(barManager1, True) With {.ImageIndex = 5, .Caption = "Italic"}
			Dim barCheckItem6 As New BarCheckItem(barManager1, False) With {.ImageIndex = 6, .Caption = "Underline"}
			Dim subMenuItems() As BarItem = { barCheckItem4, barCheckItem5, barCheckItem6 }
			subMenu.AddItems(subMenuItems)

			Dim barButtonItem7 As BarItem = New BarButtonItem(barManager1, "Find", 7)
			Dim barButtonItem8 As BarItem = New BarButtonItem(barManager1, "Undo", 8)
			Dim barButtonItem9 As BarItem = New BarButtonItem(barManager1, "Redo", 9)

			Return New BarItem() {barButtonItem0, barButtonItem1, barButtonItem2, barButtonItem3, subMenu, barButtonItem7, barButtonItem8, barButtonItem9}
		End Function



		Private Sub barManager1_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			'...
		End Sub
	End Class
End Namespace
