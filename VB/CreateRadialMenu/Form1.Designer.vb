Namespace CreateRadialMenu

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.btnShowRadialMenu = New DevExpress.XtraBars.BarButtonItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar2})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btnShowRadialMenu})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 1
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.btnShowRadialMenu)})
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' btnShowRadialMenu
            ' 
            Me.btnShowRadialMenu.Caption = "Show Radial Menu"
            Me.btnShowRadialMenu.Id = 0
            Me.btnShowRadialMenu.Name = "btnShowRadialMenu"
            AddHandler Me.btnShowRadialMenu.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.btnShowRadialMenu_ItemClick)
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(777, 22)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 456)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(777, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 22)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 434)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(777, 22)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 434)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(777, 456)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

'#End Region
        Private barManager1 As DevExpress.XtraBars.BarManager

        Private bar2 As DevExpress.XtraBars.Bar

        Private btnShowRadialMenu As DevExpress.XtraBars.BarButtonItem

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    End Class
End Namespace
