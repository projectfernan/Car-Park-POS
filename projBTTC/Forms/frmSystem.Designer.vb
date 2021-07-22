<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSystem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSystem))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.cmdSS = New System.Windows.Forms.ToolStripButton
        Me.cmdSettings = New System.Windows.Forms.ToolStripButton
        Me.cmdAcc = New System.Windows.Forms.ToolStripButton
        Me.cmdVehicle = New System.Windows.Forms.ToolStripButton
        Me.cmdCharging = New System.Windows.Forms.ToolStripButton
        Me.cmdReport = New System.Windows.Forms.ToolStripDropDownButton
        Me.ZReadingReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CashierLogoutReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.cmdAbout = New System.Windows.Forms.ToolStripButton
        Me.cmdExit = New System.Windows.Forms.ToolStripButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(7, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 455)
        Me.Panel1.TabIndex = 0
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSS, Me.cmdSettings, Me.cmdAcc, Me.cmdVehicle, Me.cmdCharging, Me.cmdReport, Me.cmdAbout, Me.cmdExit})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(256, 468)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'cmdSS
        '
        Me.cmdSS.BackColor = System.Drawing.Color.Navy
        Me.cmdSS.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSS.ForeColor = System.Drawing.Color.White
        Me.cmdSS.Image = CType(resources.GetObject("cmdSS.Image"), System.Drawing.Image)
        Me.cmdSS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSS.Name = "cmdSS"
        Me.cmdSS.Size = New System.Drawing.Size(254, 52)
        Me.cmdSS.Text = "(F1) Set System Logo"
        Me.cmdSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdSettings
        '
        Me.cmdSettings.BackColor = System.Drawing.Color.Navy
        Me.cmdSettings.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettings.ForeColor = System.Drawing.Color.White
        Me.cmdSettings.Image = CType(resources.GetObject("cmdSettings.Image"), System.Drawing.Image)
        Me.cmdSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.Size = New System.Drawing.Size(254, 52)
        Me.cmdSettings.Text = "(F2) Settings"
        '
        'cmdAcc
        '
        Me.cmdAcc.BackColor = System.Drawing.Color.Navy
        Me.cmdAcc.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAcc.ForeColor = System.Drawing.Color.White
        Me.cmdAcc.Image = CType(resources.GetObject("cmdAcc.Image"), System.Drawing.Image)
        Me.cmdAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAcc.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAcc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAcc.Name = "cmdAcc"
        Me.cmdAcc.Size = New System.Drawing.Size(254, 52)
        Me.cmdAcc.Text = "(F3) Account Settings"
        '
        'cmdVehicle
        '
        Me.cmdVehicle.BackColor = System.Drawing.Color.Navy
        Me.cmdVehicle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVehicle.ForeColor = System.Drawing.Color.White
        Me.cmdVehicle.Image = CType(resources.GetObject("cmdVehicle.Image"), System.Drawing.Image)
        Me.cmdVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVehicle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdVehicle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVehicle.Name = "cmdVehicle"
        Me.cmdVehicle.Size = New System.Drawing.Size(254, 52)
        Me.cmdVehicle.Text = "(F5) Vehicle Category"
        '
        'cmdCharging
        '
        Me.cmdCharging.BackColor = System.Drawing.Color.Navy
        Me.cmdCharging.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCharging.ForeColor = System.Drawing.Color.White
        Me.cmdCharging.Image = CType(resources.GetObject("cmdCharging.Image"), System.Drawing.Image)
        Me.cmdCharging.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCharging.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCharging.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCharging.Name = "cmdCharging"
        Me.cmdCharging.Size = New System.Drawing.Size(254, 52)
        Me.cmdCharging.Text = "(F6) Charging Rules"
        '
        'cmdReport
        '
        Me.cmdReport.BackColor = System.Drawing.Color.Navy
        Me.cmdReport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZReadingReportToolStripMenuItem, Me.CashierLogoutReportToolStripMenuItem})
        Me.cmdReport.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReport.ForeColor = System.Drawing.Color.White
        Me.cmdReport.Image = CType(resources.GetObject("cmdReport.Image"), System.Drawing.Image)
        Me.cmdReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdReport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdReport.Name = "cmdReport"
        Me.cmdReport.Size = New System.Drawing.Size(254, 52)
        Me.cmdReport.Text = "(F7) Reports"
        '
        'ZReadingReportToolStripMenuItem
        '
        Me.ZReadingReportToolStripMenuItem.Name = "ZReadingReportToolStripMenuItem"
        Me.ZReadingReportToolStripMenuItem.Size = New System.Drawing.Size(261, 24)
        Me.ZReadingReportToolStripMenuItem.Text = "Z Reading Report"
        '
        'CashierLogoutReportToolStripMenuItem
        '
        Me.CashierLogoutReportToolStripMenuItem.Name = "CashierLogoutReportToolStripMenuItem"
        Me.CashierLogoutReportToolStripMenuItem.Size = New System.Drawing.Size(261, 24)
        Me.CashierLogoutReportToolStripMenuItem.Text = "Cashier Logout Report"
        '
        'cmdAbout
        '
        Me.cmdAbout.BackColor = System.Drawing.Color.Navy
        Me.cmdAbout.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.Color.White
        Me.cmdAbout.Image = CType(resources.GetObject("cmdAbout.Image"), System.Drawing.Image)
        Me.cmdAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.Size = New System.Drawing.Size(254, 52)
        Me.cmdAbout.Text = "(F8) About"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.Navy
        Me.cmdExit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(254, 52)
        Me.cmdExit.Text = "(ESC) Quit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(249, 2)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "  "
        '
        'frmSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(269, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSystem"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCharging As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAcc As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAbout As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdVehicle As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdSS As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdReport As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ZReadingReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CashierLogoutReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
