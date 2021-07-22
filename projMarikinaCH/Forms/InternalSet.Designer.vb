<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InternalSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InternalSet))
        Me.cmdT = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtOR = New System.Windows.Forms.NumericUpDown
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.cboMode = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtZread = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboPOSVer = New System.Windows.Forms.ComboBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkEntryLogDb = New System.Windows.Forms.CheckBox
        Me.chkCardData = New System.Windows.Forms.CheckBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolOther = New System.Windows.Forms.ToolStripDropDownButton
        Me.ErrorLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResetErrorLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.txtOR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.txtZread, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdT
        '
        Me.cmdT.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdT.Image = CType(resources.GetObject("cmdT.Image"), System.Drawing.Image)
        Me.cmdT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdT.Location = New System.Drawing.Point(251, 246)
        Me.cmdT.Name = "cmdT"
        Me.cmdT.Size = New System.Drawing.Size(81, 38)
        Me.cmdT.TabIndex = 21
        Me.cmdT.Text = "  Set"
        Me.cmdT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdT.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(47, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "OR Series :"
        '
        'txtOR
        '
        Me.txtOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOR.Location = New System.Drawing.Point(149, 56)
        Me.txtOR.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtOR.Name = "txtOR"
        Me.txtOR.Size = New System.Drawing.Size(183, 24)
        Me.txtOR.TabIndex = 0
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(369, 38)
        Me.HeaderPanel.TabIndex = 14
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
        Me.Label8.Size = New System.Drawing.Size(154, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Internal Settings"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(348, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(87, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 16)
        Me.Label19.TabIndex = 93
        Me.Label19.Text = "Mode :"
        '
        'cboMode
        '
        Me.cboMode.BackColor = System.Drawing.Color.White
        Me.cboMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMode.FormattingEnabled = True
        Me.cboMode.Items.AddRange(New Object() {"SINGLE", "DUAL", "PAY STATION"})
        Me.cboMode.Location = New System.Drawing.Point(149, 120)
        Me.cboMode.Name = "cboMode"
        Me.cboMode.Size = New System.Drawing.Size(183, 24)
        Me.cboMode.TabIndex = 90
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(21, 89)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(122, 18)
        Me.Label13.TabIndex = 92
        Me.Label13.Text = "Z Read Count :"
        '
        'txtZread
        '
        Me.txtZread.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZread.Location = New System.Drawing.Point(149, 88)
        Me.txtZread.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.txtZread.Name = "txtZread"
        Me.txtZread.Size = New System.Drawing.Size(183, 24)
        Me.txtZread.TabIndex = 91
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "POS Version :"
        '
        'cboPOSVer
        '
        Me.cboPOSVer.BackColor = System.Drawing.Color.White
        Me.cboPOSVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPOSVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPOSVer.FormattingEnabled = True
        Me.cboPOSVer.Items.AddRange(New Object() {"BIR BASED", "GOVERNMENT BASED"})
        Me.cboPOSVer.Location = New System.Drawing.Point(149, 153)
        Me.cboPOSVer.Name = "cboPOSVer"
        Me.cboPOSVer.Size = New System.Drawing.Size(183, 24)
        Me.cboPOSVer.TabIndex = 94
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.chkEntryLogDb)
        Me.Panel1.Controls.Add(Me.chkCardData)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtOR)
        Me.Panel1.Controls.Add(Me.cboPOSVer)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.cmdT)
        Me.Panel1.Controls.Add(Me.cboMode)
        Me.Panel1.Controls.Add(Me.txtZread)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Location = New System.Drawing.Point(6, 44)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(356, 309)
        Me.Panel1.TabIndex = 96
        '
        'chkEntryLogDb
        '
        Me.chkEntryLogDb.AutoSize = True
        Me.chkEntryLogDb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkEntryLogDb.ForeColor = System.Drawing.Color.White
        Me.chkEntryLogDb.Location = New System.Drawing.Point(129, 217)
        Me.chkEntryLogDb.Name = "chkEntryLogDb"
        Me.chkEntryLogDb.Size = New System.Drawing.Size(169, 20)
        Me.chkEntryLogDb.TabIndex = 97
        Me.chkEntryLogDb.Text = "Enable Entry Db Log"
        Me.chkEntryLogDb.UseVisualStyleBackColor = True
        '
        'chkCardData
        '
        Me.chkCardData.AutoSize = True
        Me.chkCardData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCardData.ForeColor = System.Drawing.Color.White
        Me.chkCardData.Location = New System.Drawing.Point(129, 191)
        Me.chkCardData.Name = "chkCardData"
        Me.chkCardData.Size = New System.Drawing.Size(206, 20)
        Me.chkCardData.TabIndex = 96
        Me.chkCardData.Text = "Enable Card Data Backup"
        Me.chkCardData.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolOther})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(354, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolOther
        '
        Me.ToolOther.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolOther.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErrorLogsToolStripMenuItem})
        Me.ToolOther.Image = CType(resources.GetObject("ToolOther.Image"), System.Drawing.Image)
        Me.ToolOther.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolOther.Name = "ToolOther"
        Me.ToolOther.Size = New System.Drawing.Size(29, 22)
        Me.ToolOther.Text = "Settings Menu"
        '
        'ErrorLogsToolStripMenuItem
        '
        Me.ErrorLogsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetErrorLogsToolStripMenuItem})
        Me.ErrorLogsToolStripMenuItem.Name = "ErrorLogsToolStripMenuItem"
        Me.ErrorLogsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ErrorLogsToolStripMenuItem.Text = "Error Logs"
        '
        'ResetErrorLogsToolStripMenuItem
        '
        Me.ResetErrorLogsToolStripMenuItem.Name = "ResetErrorLogsToolStripMenuItem"
        Me.ResetErrorLogsToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ResetErrorLogsToolStripMenuItem.Text = "Reset Error Logs"
        '
        'InternalSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(369, 360)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "InternalSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtOR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.txtZread, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtOR As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmdT As System.Windows.Forms.Button
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cboMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtZread As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPOSVer As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolOther As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ErrorLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetErrorLogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkCardData As System.Windows.Forms.CheckBox
    Friend WithEvents chkEntryLogDb As System.Windows.Forms.CheckBox
End Class
