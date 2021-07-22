<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPOSGov
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetPOSGov))
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.txtOperatedBy = New System.Windows.Forms.TextBox
        Me.fsdf = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.lstList = New System.Windows.Forms.ListView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtRegulation = New System.Windows.Forms.RichTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdDel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.btnSave = New System.Windows.Forms.Button
        Me.chkPing = New System.Windows.Forms.CheckBox
        Me.chkDataPool = New System.Windows.Forms.CheckBox
        Me.chkDesktop = New System.Windows.Forms.CheckBox
        Me.txtSlot = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboStation = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboChargeState = New System.Windows.Forms.ComboBox
        Me.HeaderPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.txtSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(142, 59)
        Me.txtTitle.MaxLength = 33
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(240, 22)
        Me.txtTitle.TabIndex = 0
        '
        'txtOperatedBy
        '
        Me.txtOperatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperatedBy.Location = New System.Drawing.Point(142, 89)
        Me.txtOperatedBy.MaxLength = 33
        Me.txtOperatedBy.Name = "txtOperatedBy"
        Me.txtOperatedBy.Size = New System.Drawing.Size(240, 22)
        Me.txtOperatedBy.TabIndex = 1
        '
        'fsdf
        '
        Me.fsdf.AutoSize = True
        Me.fsdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fsdf.ForeColor = System.Drawing.Color.White
        Me.fsdf.Location = New System.Drawing.Point(44, 91)
        Me.fsdf.Name = "fsdf"
        Me.fsdf.Size = New System.Drawing.Size(94, 16)
        Me.fsdf.TabIndex = 47
        Me.fsdf.Text = "Oprated By :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(33, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 16)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Receipt Title :"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label11)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(416, 38)
        Me.HeaderPanel.TabIndex = 48
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 18)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "     Set POS"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(395, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'lstList
        '
        Me.lstList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(6, 114)
        Me.lstList.MultiSelect = False
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(379, 162)
        Me.lstList.TabIndex = 49
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtRegulation)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Location = New System.Drawing.Point(12, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 285)
        Me.Panel1.TabIndex = 50
        '
        'txtRegulation
        '
        Me.txtRegulation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegulation.Location = New System.Drawing.Point(102, 53)
        Me.txtRegulation.Name = "txtRegulation"
        Me.txtRegulation.Size = New System.Drawing.Size(282, 54)
        Me.txtRegulation.TabIndex = 53
        Me.txtRegulation.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Regulation :"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmdAdd, Me.ToolStripSeparator5, Me.cmdDel, Me.ToolStripSeparator7})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(392, 39)
        Me.ToolStrip2.TabIndex = 50
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAdd
        '
        Me.cmdAdd.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(72, 36)
        Me.cmdAdd.Text = "&Add"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDel
        '
        Me.cmdDel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(93, 36)
        Me.cmdDel.Text = "&Delete"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(308, 597)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 38)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'chkPing
        '
        Me.chkPing.AutoSize = True
        Me.chkPing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPing.ForeColor = System.Drawing.Color.White
        Me.chkPing.Location = New System.Drawing.Point(115, 538)
        Me.chkPing.Name = "chkPing"
        Me.chkPing.Size = New System.Drawing.Size(175, 20)
        Me.chkPing.TabIndex = 6
        Me.chkPing.Text = "Disabled Server Ping"
        Me.chkPing.UseVisualStyleBackColor = True
        '
        'chkDataPool
        '
        Me.chkDataPool.AutoSize = True
        Me.chkDataPool.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDataPool.ForeColor = System.Drawing.Color.White
        Me.chkDataPool.Location = New System.Drawing.Point(115, 512)
        Me.chkDataPool.Name = "chkDataPool"
        Me.chkDataPool.Size = New System.Drawing.Size(175, 20)
        Me.chkDataPool.TabIndex = 5
        Me.chkDataPool.Text = "Disable Data Pooling"
        Me.chkDataPool.UseVisualStyleBackColor = True
        '
        'chkDesktop
        '
        Me.chkDesktop.AutoSize = True
        Me.chkDesktop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDesktop.ForeColor = System.Drawing.Color.White
        Me.chkDesktop.Location = New System.Drawing.Point(115, 564)
        Me.chkDesktop.Name = "chkDesktop"
        Me.chkDesktop.Size = New System.Drawing.Size(122, 20)
        Me.chkDesktop.TabIndex = 7
        Me.chkDesktop.Text = "Lock Desktop"
        Me.chkDesktop.UseVisualStyleBackColor = True
        '
        'txtSlot
        '
        Me.txtSlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlot.Location = New System.Drawing.Point(142, 119)
        Me.txtSlot.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtSlot.Name = "txtSlot"
        Me.txtSlot.Size = New System.Drawing.Size(239, 22)
        Me.txtSlot.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Parking Slot :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(73, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Station :"
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.White
        Me.cboStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4", "Station 5", "Station 6", "Station 7", "Station 8", "Station 9", "Station 10", "Station 11", "Station 12", "Station 13", "Station 14", "Station 15", "Station 16", "Station 17", "Station 18", "Station 19", "Station 20", "Station 21", "Station 22", "Station 23", "Station 24", "Station 25", "Station 26", "Station 27", "Station 28", "Station 29", "Station 30", "Station 31", "Station 32", "Station 33", "Station 34", "Station 35", "Station 36", "Station 37", "Station 38", "Station 39", "Station 40", "Station 41", "Station 42", "Station 43", "Station 44", "Station 45", "Station 46", "Station 47", "Station 48", "Station 49", "Station 50", "Station 51", "Station 52", "Station 53", "Station 54", "Station 55", "Station 56", "Station 57", "Station 58", "Station 59", "Station 60", "Station 61", "Station 62", "Station 63", "Station 64", "Station 65", "Station 66", "Station 67", "Station 68", "Station 69", "Station 70", "Station 71", "Station 72", "Station 73", "Station 74", "Station 75", "Station 76", "Station 77", "Station 78", "Station 79", "Station 80", "Station 81", "Station 82", "Station 83", "Station 84", "Station 85", "Station 86", "Station 87", "Station 88", "Station 89", "Station 90", "Station 91", "Station 92", "Station 93", "Station 94", "Station 95", "Station 96", "Station 97", "Station 98", "Station 99", "Station 100"})
        Me.cboStation.Location = New System.Drawing.Point(142, 149)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(240, 24)
        Me.cboStation.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(19, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Charging State :"
        '
        'cboChargeState
        '
        Me.cboChargeState.BackColor = System.Drawing.Color.White
        Me.cboChargeState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboChargeState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChargeState.FormattingEnabled = True
        Me.cboChargeState.Items.AddRange(New Object() {"HOURLY", "FLAT RATE"})
        Me.cboChargeState.Location = New System.Drawing.Point(142, 182)
        Me.cboChargeState.Name = "cboChargeState"
        Me.cboChargeState.Size = New System.Drawing.Size(240, 24)
        Me.cboChargeState.TabIndex = 4
        '
        'frmSetPOSGov
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(416, 648)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboStation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cboChargeState)
        Me.Controls.Add(Me.txtSlot)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkPing)
        Me.Controls.Add(Me.chkDataPool)
        Me.Controls.Add(Me.chkDesktop)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.txtOperatedBy)
        Me.Controls.Add(Me.fsdf)
        Me.Controls.Add(Me.Label12)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetPOSGov"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.txtSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtOperatedBy As System.Windows.Forms.TextBox
    Friend WithEvents fsdf As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtRegulation As System.Windows.Forms.RichTextBox
    Friend WithEvents chkPing As System.Windows.Forms.CheckBox
    Friend WithEvents chkDataPool As System.Windows.Forms.CheckBox
    Friend WithEvents chkDesktop As System.Windows.Forms.CheckBox
    Friend WithEvents txtSlot As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboChargeState As System.Windows.Forms.ComboBox
End Class
