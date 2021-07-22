<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashierLogout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashierLogout))
        Me.cmdCompute = New System.Windows.Forms.Button
        Me.cboCashier = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtFrm = New System.Windows.Forms.DateTimePicker
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.chkLOprint = New System.Windows.Forms.CheckBox
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdCompute
        '
        Me.cmdCompute.BackColor = System.Drawing.Color.White
        Me.cmdCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompute.ForeColor = System.Drawing.Color.Black
        Me.cmdCompute.Image = CType(resources.GetObject("cmdCompute.Image"), System.Drawing.Image)
        Me.cmdCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompute.Location = New System.Drawing.Point(212, 168)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(95, 37)
        Me.cmdCompute.TabIndex = 4
        Me.cmdCompute.Text = "&Print"
        Me.cmdCompute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCompute.UseVisualStyleBackColor = False
        '
        'cboCashier
        '
        Me.cboCashier.BackColor = System.Drawing.Color.White
        Me.cboCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCashier.FormattingEnabled = True
        Me.cboCashier.Location = New System.Drawing.Point(116, 64)
        Me.cboCashier.Name = "cboCashier"
        Me.cboCashier.Size = New System.Drawing.Size(191, 26)
        Me.cboCashier.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(41, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Cashier :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(20, 106)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 16)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Buss. Date :"
        '
        'dtFrm
        '
        Me.dtFrm.CustomFormat = "yyyy-MM-dd"
        Me.dtFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm.Location = New System.Drawing.Point(116, 103)
        Me.dtFrm.Name = "dtFrm"
        Me.dtFrm.Size = New System.Drawing.Size(191, 24)
        Me.dtFrm.TabIndex = 2
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(-1, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(336, 38)
        Me.HeaderPanel.TabIndex = 71
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
        Me.Label8.Size = New System.Drawing.Size(204, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Cashier Logout Report"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(313, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'chkLOprint
        '
        Me.chkLOprint.AutoSize = True
        Me.chkLOprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLOprint.ForeColor = System.Drawing.Color.White
        Me.chkLOprint.Location = New System.Drawing.Point(116, 138)
        Me.chkLOprint.Name = "chkLOprint"
        Me.chkLOprint.Size = New System.Drawing.Size(162, 20)
        Me.chkLOprint.TabIndex = 72
        Me.chkLOprint.Text = "Enable Logout Print"
        Me.chkLOprint.UseVisualStyleBackColor = True
        '
        'frmCashierLogout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(332, 231)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkLOprint)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.cmdCompute)
        Me.Controls.Add(Me.cboCashier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtFrm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCashierLogout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCompute As System.Windows.Forms.Button
    Friend WithEvents cboCashier As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents chkLOprint As System.Windows.Forms.CheckBox
End Class
