<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmOR = New System.Windows.Forms.ToolStrip
        Me.btnSetPOS = New System.Windows.Forms.ToolStripButton
        Me.btnDbSettings = New System.Windows.Forms.ToolStripButton
        Me.btnDtSync = New System.Windows.Forms.ToolStripButton
        Me.btnController = New System.Windows.Forms.ToolStripButton
        Me.btnCamera = New System.Windows.Forms.ToolStripButton
        Me.btnPrinter = New System.Windows.Forms.ToolStripButton
        Me.btnPoleDisp = New System.Windows.Forms.ToolStripButton
        Me.btnCashDrawer = New System.Windows.Forms.ToolStripButton
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.btnER302 = New System.Windows.Forms.ToolStripButton
        Me.Panel1.SuspendLayout()
        Me.cmOR.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmOR)
        Me.Panel1.Location = New System.Drawing.Point(8, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 502)
        Me.Panel1.TabIndex = 6
        '
        'cmOR
        '
        Me.cmOR.BackColor = System.Drawing.Color.Transparent
        Me.cmOR.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.cmOR.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnSetPOS, Me.btnDbSettings, Me.btnDtSync, Me.btnController, Me.btnCamera, Me.btnPrinter, Me.btnPoleDisp, Me.btnCashDrawer, Me.btnER302})
        Me.cmOR.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.cmOR.Location = New System.Drawing.Point(0, 0)
        Me.cmOR.Name = "cmOR"
        Me.cmOR.Size = New System.Drawing.Size(303, 497)
        Me.cmOR.TabIndex = 2
        Me.cmOR.Text = "ToolStrip2"
        '
        'btnSetPOS
        '
        Me.btnSetPOS.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSetPOS.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetPOS.ForeColor = System.Drawing.Color.Black
        Me.btnSetPOS.Image = CType(resources.GetObject("btnSetPOS.Image"), System.Drawing.Image)
        Me.btnSetPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSetPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSetPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSetPOS.Name = "btnSetPOS"
        Me.btnSetPOS.Size = New System.Drawing.Size(301, 52)
        Me.btnSetPOS.Text = "(F1) Set POS"
        '
        'btnDbSettings
        '
        Me.btnDbSettings.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDbSettings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDbSettings.ForeColor = System.Drawing.Color.Black
        Me.btnDbSettings.Image = CType(resources.GetObject("btnDbSettings.Image"), System.Drawing.Image)
        Me.btnDbSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDbSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDbSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDbSettings.Name = "btnDbSettings"
        Me.btnDbSettings.Size = New System.Drawing.Size(301, 52)
        Me.btnDbSettings.Text = "(F2) Database Settings"
        '
        'btnDtSync
        '
        Me.btnDtSync.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDtSync.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDtSync.ForeColor = System.Drawing.Color.Black
        Me.btnDtSync.Image = CType(resources.GetObject("btnDtSync.Image"), System.Drawing.Image)
        Me.btnDtSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDtSync.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDtSync.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDtSync.Name = "btnDtSync"
        Me.btnDtSync.Size = New System.Drawing.Size(301, 52)
        Me.btnDtSync.Text = "(F3) Date and Time Synch"
        '
        'btnController
        '
        Me.btnController.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnController.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnController.ForeColor = System.Drawing.Color.Black
        Me.btnController.Image = CType(resources.GetObject("btnController.Image"), System.Drawing.Image)
        Me.btnController.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnController.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnController.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnController.Name = "btnController"
        Me.btnController.Size = New System.Drawing.Size(301, 52)
        Me.btnController.Text = "(F4) Controller Settings"
        '
        'btnCamera
        '
        Me.btnCamera.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCamera.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCamera.ForeColor = System.Drawing.Color.Black
        Me.btnCamera.Image = CType(resources.GetObject("btnCamera.Image"), System.Drawing.Image)
        Me.btnCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCamera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCamera.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCamera.Name = "btnCamera"
        Me.btnCamera.Size = New System.Drawing.Size(301, 52)
        Me.btnCamera.Text = "(F5) Camera Settings"
        '
        'btnPrinter
        '
        Me.btnPrinter.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrinter.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrinter.ForeColor = System.Drawing.Color.Black
        Me.btnPrinter.Image = CType(resources.GetObject("btnPrinter.Image"), System.Drawing.Image)
        Me.btnPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrinter.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPrinter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPrinter.Name = "btnPrinter"
        Me.btnPrinter.Size = New System.Drawing.Size(301, 52)
        Me.btnPrinter.Text = "(F6) Printer Settings"
        '
        'btnPoleDisp
        '
        Me.btnPoleDisp.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPoleDisp.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPoleDisp.ForeColor = System.Drawing.Color.Black
        Me.btnPoleDisp.Image = CType(resources.GetObject("btnPoleDisp.Image"), System.Drawing.Image)
        Me.btnPoleDisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPoleDisp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnPoleDisp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPoleDisp.Name = "btnPoleDisp"
        Me.btnPoleDisp.Size = New System.Drawing.Size(301, 52)
        Me.btnPoleDisp.Text = "(F7) Pole Display Settings"
        '
        'btnCashDrawer
        '
        Me.btnCashDrawer.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnCashDrawer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCashDrawer.ForeColor = System.Drawing.Color.Black
        Me.btnCashDrawer.Image = CType(resources.GetObject("btnCashDrawer.Image"), System.Drawing.Image)
        Me.btnCashDrawer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCashDrawer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnCashDrawer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCashDrawer.Name = "btnCashDrawer"
        Me.btnCashDrawer.Size = New System.Drawing.Size(301, 52)
        Me.btnCashDrawer.Text = "(F8) Cash Drawer Settings"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(-1, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(324, 38)
        Me.HeaderPanel.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(6, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Settings"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(301, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'btnER302
        '
        Me.btnER302.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnER302.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnER302.ForeColor = System.Drawing.Color.Black
        Me.btnER302.Image = CType(resources.GetObject("btnER302.Image"), System.Drawing.Image)
        Me.btnER302.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnER302.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnER302.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnER302.Name = "btnER302"
        Me.btnER302.Size = New System.Drawing.Size(301, 52)
        Me.btnER302.Text = "(F9) ER302 Reader Settings"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 553)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.cmOR.ResumeLayout(False)
        Me.cmOR.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmOR As System.Windows.Forms.ToolStrip
    Friend WithEvents btnDbSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnController As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCamera As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPrinter As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnPoleDisp As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDtSync As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSetPOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents btnCashDrawer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnER302 As System.Windows.Forms.ToolStripButton
End Class
