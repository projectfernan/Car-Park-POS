<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBussDate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBussDate))
        Me.chkBussAuto = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtBdate = New System.Windows.Forms.DateTimePicker
        Me.dtFcut = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtHcut = New System.Windows.Forms.DateTimePicker
        Me.cmdT = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.dtSaleCutt = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkBussAuto
        '
        Me.chkBussAuto.AutoSize = True
        Me.chkBussAuto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkBussAuto.ForeColor = System.Drawing.Color.White
        Me.chkBussAuto.Location = New System.Drawing.Point(93, 229)
        Me.chkBussAuto.Name = "chkBussAuto"
        Me.chkBussAuto.Size = New System.Drawing.Size(217, 20)
        Me.chkBussAuto.TabIndex = 73
        Me.chkBussAuto.Text = "Disabled Automatic Update"
        Me.chkBussAuto.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 16)
        Me.Label2.TabIndex = 72
        Me.Label2.Text = "Bussiness Date :"
        '
        'dtBdate
        '
        Me.dtBdate.CustomFormat = "yyyy-MM-dd"
        Me.dtBdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtBdate.Location = New System.Drawing.Point(161, 63)
        Me.dtBdate.Name = "dtBdate"
        Me.dtBdate.Size = New System.Drawing.Size(149, 24)
        Me.dtBdate.TabIndex = 71
        '
        'dtFcut
        '
        Me.dtFcut.CustomFormat = "HH:mm:ss"
        Me.dtFcut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFcut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFcut.Location = New System.Drawing.Point(161, 146)
        Me.dtFcut.Name = "dtFcut"
        Me.dtFcut.ShowUpDown = True
        Me.dtFcut.Size = New System.Drawing.Size(149, 24)
        Me.dtFcut.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(27, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Flat Rate Cut Off :"
        '
        'dtHcut
        '
        Me.dtHcut.CustomFormat = "HH:mm:ss"
        Me.dtHcut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtHcut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtHcut.Location = New System.Drawing.Point(161, 105)
        Me.dtHcut.Name = "dtHcut"
        Me.dtHcut.ShowUpDown = True
        Me.dtHcut.Size = New System.Drawing.Size(149, 24)
        Me.dtHcut.TabIndex = 68
        '
        'cmdT
        '
        Me.cmdT.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdT.Image = CType(resources.GetObject("cmdT.Image"), System.Drawing.Image)
        Me.cmdT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdT.Location = New System.Drawing.Point(211, 261)
        Me.cmdT.Name = "cmdT"
        Me.cmdT.Size = New System.Drawing.Size(99, 35)
        Me.cmdT.TabIndex = 20
        Me.cmdT.Text = "&Update"
        Me.cmdT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdT.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(45, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Hourly Cut Off :"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(-1, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(345, 38)
        Me.HeaderPanel.TabIndex = 74
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
        Me.Label8.Size = New System.Drawing.Size(153, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Cut Off Settings"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(319, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'dtSaleCutt
        '
        Me.dtSaleCutt.CustomFormat = "HH:mm:ss"
        Me.dtSaleCutt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtSaleCutt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtSaleCutt.Location = New System.Drawing.Point(161, 188)
        Me.dtSaleCutt.Name = "dtSaleCutt"
        Me.dtSaleCutt.ShowUpDown = True
        Me.dtSaleCutt.Size = New System.Drawing.Size(149, 24)
        Me.dtSaleCutt.TabIndex = 77
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(45, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Sales Cutt Off :"
        '
        'frmBussDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 320)
        Me.ControlBox = False
        Me.Controls.Add(Me.dtSaleCutt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.chkBussAuto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtBdate)
        Me.Controls.Add(Me.dtFcut)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dtHcut)
        Me.Controls.Add(Me.cmdT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmBussDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdT As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtHcut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFcut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtBdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkBussAuto As System.Windows.Forms.CheckBox
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents dtSaleCutt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
