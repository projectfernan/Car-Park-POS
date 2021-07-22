<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetTrial
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetTrial))
        Me.txtNoDay = New System.Windows.Forms.NumericUpDown
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblDtStart = New System.Windows.Forms.Label
        Me.btnSet = New System.Windows.Forms.Button
        CType(Me.txtNoDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNoDay
        '
        Me.txtNoDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoDay.Location = New System.Drawing.Point(151, 54)
        Me.txtNoDay.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtNoDay.Name = "txtNoDay"
        Me.txtNoDay.Size = New System.Drawing.Size(62, 22)
        Me.txtNoDay.TabIndex = 42
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(50, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 16)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "No. of days :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Activation Start :"
        '
        'lblDtStart
        '
        Me.lblDtStart.AutoSize = True
        Me.lblDtStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDtStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDtStart.Location = New System.Drawing.Point(151, 23)
        Me.lblDtStart.Name = "lblDtStart"
        Me.lblDtStart.Size = New System.Drawing.Size(92, 16)
        Me.lblDtStart.TabIndex = 45
        Me.lblDtStart.Text = "yyyy-MM-dd"
        '
        'btnSet
        '
        Me.btnSet.BackColor = System.Drawing.Color.White
        Me.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSet.Location = New System.Drawing.Point(111, 87)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(42, 24)
        Me.btnSet.TabIndex = 46
        Me.btnSet.Text = "OK"
        Me.btnSet.UseVisualStyleBackColor = False
        '
        'frmSetTrial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(265, 135)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.lblDtStart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoDay)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSetTrial"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtNoDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNoDay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDtStart As System.Windows.Forms.Label
    Friend WithEvents btnSet As System.Windows.Forms.Button
End Class
