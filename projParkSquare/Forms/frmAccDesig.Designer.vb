<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccDesig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccDesig))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkTerminate = New System.Windows.Forms.CheckBox
        Me.chkReports = New System.Windows.Forms.CheckBox
        Me.chkCashOut = New System.Windows.Forms.CheckBox
        Me.chkCutOff = New System.Windows.Forms.CheckBox
        Me.chkFlatSched = New System.Windows.Forms.CheckBox
        Me.chkCharging = New System.Windows.Forms.CheckBox
        Me.chkVehicle = New System.Windows.Forms.CheckBox
        Me.chkAccSetting = New System.Windows.Forms.CheckBox
        Me.chkSettings = New System.Windows.Forms.CheckBox
        Me.chkLogo = New System.Windows.Forms.CheckBox
        Me.txtDesig = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdDel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.lstList = New System.Windows.Forms.ListView
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtCnt = New System.Windows.Forms.ToolStripStatusLabel
        Me.cmdReset = New System.Windows.Forms.ToolStripButton
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Black
        Me.lblTitle.Location = New System.Drawing.Point(2, 2)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(290, 18)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "System Account Designation Settings"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(486, 2)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "  "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkTerminate)
        Me.Panel1.Controls.Add(Me.chkReports)
        Me.Panel1.Controls.Add(Me.chkCashOut)
        Me.Panel1.Controls.Add(Me.chkCutOff)
        Me.Panel1.Controls.Add(Me.chkFlatSched)
        Me.Panel1.Controls.Add(Me.chkCharging)
        Me.Panel1.Controls.Add(Me.chkVehicle)
        Me.Panel1.Controls.Add(Me.chkAccSetting)
        Me.Panel1.Controls.Add(Me.chkSettings)
        Me.Panel1.Controls.Add(Me.chkLogo)
        Me.Panel1.Controls.Add(Me.txtDesig)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Location = New System.Drawing.Point(7, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(490, 370)
        Me.Panel1.TabIndex = 16
        '
        'chkTerminate
        '
        Me.chkTerminate.AutoSize = True
        Me.chkTerminate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkTerminate.ForeColor = System.Drawing.Color.White
        Me.chkTerminate.Location = New System.Drawing.Point(280, 298)
        Me.chkTerminate.Name = "chkTerminate"
        Me.chkTerminate.Size = New System.Drawing.Size(152, 20)
        Me.chkTerminate.TabIndex = 10
        Me.chkTerminate.Text = "System Terminate"
        Me.chkTerminate.UseVisualStyleBackColor = True
        '
        'chkReports
        '
        Me.chkReports.AutoSize = True
        Me.chkReports.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkReports.ForeColor = System.Drawing.Color.White
        Me.chkReports.Location = New System.Drawing.Point(280, 272)
        Me.chkReports.Name = "chkReports"
        Me.chkReports.Size = New System.Drawing.Size(82, 20)
        Me.chkReports.TabIndex = 9
        Me.chkReports.Text = "Reports"
        Me.chkReports.UseVisualStyleBackColor = True
        '
        'chkCashOut
        '
        Me.chkCashOut.AutoSize = True
        Me.chkCashOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCashOut.ForeColor = System.Drawing.Color.White
        Me.chkCashOut.Location = New System.Drawing.Point(281, 246)
        Me.chkCashOut.Name = "chkCashOut"
        Me.chkCashOut.Size = New System.Drawing.Size(89, 20)
        Me.chkCashOut.TabIndex = 8
        Me.chkCashOut.Text = "Cash Out"
        Me.chkCashOut.UseVisualStyleBackColor = True
        '
        'chkCutOff
        '
        Me.chkCutOff.AutoSize = True
        Me.chkCutOff.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCutOff.ForeColor = System.Drawing.Color.White
        Me.chkCutOff.Location = New System.Drawing.Point(281, 220)
        Me.chkCutOff.Name = "chkCutOff"
        Me.chkCutOff.Size = New System.Drawing.Size(132, 20)
        Me.chkCutOff.TabIndex = 7
        Me.chkCutOff.Text = "Cut Off Settings"
        Me.chkCutOff.UseVisualStyleBackColor = True
        '
        'chkFlatSched
        '
        Me.chkFlatSched.AutoSize = True
        Me.chkFlatSched.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFlatSched.ForeColor = System.Drawing.Color.White
        Me.chkFlatSched.Location = New System.Drawing.Point(281, 194)
        Me.chkFlatSched.Name = "chkFlatSched"
        Me.chkFlatSched.Size = New System.Drawing.Size(159, 20)
        Me.chkFlatSched.TabIndex = 6
        Me.chkFlatSched.Text = "Flat Rate Schedule"
        Me.chkFlatSched.UseVisualStyleBackColor = True
        '
        'chkCharging
        '
        Me.chkCharging.AutoSize = True
        Me.chkCharging.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCharging.ForeColor = System.Drawing.Color.White
        Me.chkCharging.Location = New System.Drawing.Point(281, 168)
        Me.chkCharging.Name = "chkCharging"
        Me.chkCharging.Size = New System.Drawing.Size(133, 20)
        Me.chkCharging.TabIndex = 5
        Me.chkCharging.Text = "Charging Rules"
        Me.chkCharging.UseVisualStyleBackColor = True
        '
        'chkVehicle
        '
        Me.chkVehicle.AutoSize = True
        Me.chkVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVehicle.ForeColor = System.Drawing.Color.White
        Me.chkVehicle.Location = New System.Drawing.Point(281, 142)
        Me.chkVehicle.Name = "chkVehicle"
        Me.chkVehicle.Size = New System.Drawing.Size(146, 20)
        Me.chkVehicle.TabIndex = 4
        Me.chkVehicle.Text = "Vehicle Category"
        Me.chkVehicle.UseVisualStyleBackColor = True
        '
        'chkAccSetting
        '
        Me.chkAccSetting.AutoSize = True
        Me.chkAccSetting.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccSetting.ForeColor = System.Drawing.Color.White
        Me.chkAccSetting.Location = New System.Drawing.Point(281, 116)
        Me.chkAccSetting.Name = "chkAccSetting"
        Me.chkAccSetting.Size = New System.Drawing.Size(197, 20)
        Me.chkAccSetting.TabIndex = 3
        Me.chkAccSetting.Text = "System Account Settings"
        Me.chkAccSetting.UseVisualStyleBackColor = True
        '
        'chkSettings
        '
        Me.chkSettings.AutoSize = True
        Me.chkSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSettings.ForeColor = System.Drawing.Color.White
        Me.chkSettings.Location = New System.Drawing.Point(281, 90)
        Me.chkSettings.Name = "chkSettings"
        Me.chkSettings.Size = New System.Drawing.Size(83, 20)
        Me.chkSettings.TabIndex = 2
        Me.chkSettings.Text = "Settings"
        Me.chkSettings.UseVisualStyleBackColor = True
        '
        'chkLogo
        '
        Me.chkLogo.AutoSize = True
        Me.chkLogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLogo.ForeColor = System.Drawing.Color.White
        Me.chkLogo.Location = New System.Drawing.Point(281, 64)
        Me.chkLogo.Name = "chkLogo"
        Me.chkLogo.Size = New System.Drawing.Size(144, 20)
        Me.chkLogo.TabIndex = 1
        Me.chkLogo.Text = "Set System Logo"
        Me.chkLogo.UseVisualStyleBackColor = True
        '
        'txtDesig
        '
        Me.txtDesig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDesig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesig.Location = New System.Drawing.Point(106, 62)
        Me.txtDesig.MaxLength = 30
        Me.txtDesig.Name = "txtDesig"
        Me.txtDesig.Size = New System.Drawing.Size(153, 22)
        Me.txtDesig.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(7, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Designation :"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmdAdd, Me.ToolStripSeparator5, Me.cmdDel, Me.ToolStripSeparator7, Me.cmdReset})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(488, 55)
        Me.ToolStrip2.TabIndex = 14
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(88, 52)
        Me.cmdAdd.Text = "&Add"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 55)
        '
        'cmdDel
        '
        Me.cmdDel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(109, 52)
        Me.cmdDel.Text = "&Delete"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 55)
        '
        'lstList
        '
        Me.lstList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(10, 90)
        Me.lstList.MultiSelect = False
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(249, 228)
        Me.lstList.TabIndex = 567
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.txtCnt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 331)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(488, 37)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel3.Text = " "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(149, 32)
        Me.ToolStripStatusLabel1.Text = "Record Count :"
        '
        'txtCnt
        '
        Me.txtCnt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtCnt.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCnt.ForeColor = System.Drawing.Color.Blue
        Me.txtCnt.Name = "txtCnt"
        Me.txtCnt.Size = New System.Drawing.Size(23, 32)
        Me.txtCnt.Text = "0"
        '
        'cmdReset
        '
        Me.cmdReset.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdReset.Image = CType(resources.GetObject("cmdReset.Image"), System.Drawing.Image)
        Me.cmdReset.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdReset.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdReset.Name = "cmdReset"
        Me.cmdReset.Size = New System.Drawing.Size(103, 52)
        Me.cmdReset.Text = "&Reset"
        '
        'frmAccDesig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(503, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAccDesig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtDesig As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtCnt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents chkLogo As System.Windows.Forms.CheckBox
    Friend WithEvents chkSettings As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccSetting As System.Windows.Forms.CheckBox
    Friend WithEvents chkVehicle As System.Windows.Forms.CheckBox
    Friend WithEvents chkCharging As System.Windows.Forms.CheckBox
    Friend WithEvents chkFlatSched As System.Windows.Forms.CheckBox
    Friend WithEvents chkCutOff As System.Windows.Forms.CheckBox
    Friend WithEvents chkCashOut As System.Windows.Forms.CheckBox
    Friend WithEvents chkReports As System.Windows.Forms.CheckBox
    Friend WithEvents chkTerminate As System.Windows.Forms.CheckBox
    Friend WithEvents cmdReset As System.Windows.Forms.ToolStripButton
End Class
