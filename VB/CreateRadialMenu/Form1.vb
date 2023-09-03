Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars

Namespace CreateRadialMenu

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            barManager = barManager1
            AddHandler barManager.ItemClick, New ItemClickEventHandler(AddressOf barManager_ItemClick)
            ' Create Radial Menu
            radialMenu = New RadialMenu(barManager)
            radialMenu.AddItems(GetRadialMenuItems(barManager))
        End Sub

        Private barManager As BarManager

        Private radialMenu As RadialMenu

        Private Sub btnShowRadialMenu_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            ' Display Radial Menu
            If radialMenu Is Nothing Then Return
            Dim pt As Point = Location
            pt.Offset(Width \ 2, Height \ 2)
            radialMenu.ShowPopup(pt)
        End Sub

        Private Function GetRadialMenuItems(ByVal barManager As BarManager) As BarItem()
            ' Create bar items to display in Radial Menu
            Dim btnCopy As BarItem = New BarButtonItem(barManager, "Copy")
            btnCopy.ImageOptions.ImageUri.Uri = "Copy;Size16x16"
            Dim btnCut As BarItem = New BarButtonItem(barManager, "Cut")
            btnCut.ImageOptions.ImageUri.Uri = "Cut;Size16x16"
            Dim btnDelete As BarItem = New BarButtonItem(barManager, "Delete")
            btnDelete.ImageOptions.ImageUri.Uri = "Delete;Size16x16"
            Dim btnPaste As BarItem = New BarButtonItem(barManager, "Paste")
            btnPaste.ImageOptions.ImageUri.Uri = "Paste;Size16x16"
            ' Sub-menu with 3 check buttons
            Dim btnMenuFormat As BarSubItem = New BarSubItem(barManager, "Format")
            Dim btnCheckBold As BarCheckItem = New BarCheckItem(barManager, False)
            btnCheckBold.Caption = "Bold"
            btnCheckBold.ImageOptions.ImageUri.Uri = "Bold;Size16x16"
            Dim btnCheckItalic As BarCheckItem = New BarCheckItem(barManager, True)
            btnCheckItalic.Caption = "Italic"
            btnCheckItalic.ImageOptions.ImageUri.Uri = "Italic;Size16x16"
            Dim btnCheckUnderline As BarCheckItem = New BarCheckItem(barManager, False)
            btnCheckUnderline.Caption = "Underline"
            btnCheckUnderline.ImageOptions.ImageUri.Uri = "Underline;Size16x16"
            Dim subMenuItems As BarItem() = New BarItem() {btnCheckBold, btnCheckItalic, btnCheckUnderline}
            btnMenuFormat.AddItems(subMenuItems)
            Dim btnFind As BarItem = New BarButtonItem(barManager, "Find")
            btnFind.ImageOptions.ImageUri.Uri = "Find;Size16x16"
            Dim btnUndo As BarItem = New BarButtonItem(barManager, "Undo")
            btnUndo.ImageOptions.ImageUri.Uri = "Undo;Size16x16"
            Dim btnRedo As BarItem = New BarButtonItem(barManager, "Redo")
            btnRedo.ImageOptions.ImageUri.Uri = "Redo;Size16x16"
            Return New BarItem() {btnCopy, btnCut, btnDelete, btnPaste, btnMenuFormat, btnFind, btnUndo, btnRedo}
        End Function

        Private Sub barManager_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            '...
            Text = "Item clicked: " & e.Item.Caption
        End Sub
    End Class
End Namespace
