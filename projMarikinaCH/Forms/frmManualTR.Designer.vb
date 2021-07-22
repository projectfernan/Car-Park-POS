<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManualTR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmManualTR))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtPlate = New System.Windows.Forms.TextBox
        Me.cmdCompute = New System.Windows.Forms.Button
        Me.cboVtype = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtFrm = New System.Windows.Forms.DateTimePicker
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(53, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 80
        Me.Label1.Text = "Plate No :"
        '
        'txtPlate
        '
        Me.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(136, 60)
        Me.txtPlate.MaxLength = 7
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(193, 26)
        Me.txtPlate.TabIndex = 0
        '
        'cmdCompute
        '
        Me.cmdCompute.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompute.ForeColor = System.Drawing.Color.Black
        Me.cmdCompute.Image = CType(resources.GetObject("cmdCompute.Image"), System.Drawing.Image)
        Me.cmdCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompute.Location = New System.Drawing.Point(216, 223)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(112, 37)
        Me.cmdCompute.TabIndex = 4
        Me.cmdCompute.Text = "Compute"
        Me.cmdCompute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCompute.UseVisualStyleBackColor = False
        '
        'cboVtype
        '
        Me.cboVtype.BackColor = System.Drawing.Color.White
        Me.cboVtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVtype.FormattingEnabled = True
        Me.cboVtype.Location = New System.Drawing.Point(137, 100)
        Me.cboVtype.Name = "cboVtype"
        Me.cboVtype.Size = New System.Drawing.Size(191, 26)
        Me.cboVtype.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Vehicle Type :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(53, 182)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(78, 16)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Time Out :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(64, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 16)
        Me.Label14.TabIndex = 68
        Me.Label14.Text = "Time In :"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "yyyy-MM-dd HH:mm:00"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(137, 177)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(191, 24)
        Me.dtTo.TabIndex = 3
        '
        'dtFrm
        '
        Me.dtFrm.CustomFormat = "yyyy-MM-dd HH:mm:00"
        Me.dtFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm.Location = New System.Drawing.Point(137, 139)
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
        Me.HeaderPanel.Size = New System.Drawing.Size(359, 38)
        Me.HeaderPanel.TabIndex = 18
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
        Me.Label8.Size = New System.Drawing.Size(160, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Manual Compute"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(336, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmManualTR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(355, 290)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.txtPlate)
        Me.Controls.Add(Me.cmdCompute)
        Me.Controls.Add(Me.cboVtype)
        Me.Controls.Add(Me.dtFrm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmManualTR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCompute As System.Windows.Forms.Button
    Friend WithEvents cboVtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPlate As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
