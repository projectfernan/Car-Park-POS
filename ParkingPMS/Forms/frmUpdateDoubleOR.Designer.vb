<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateDoubleOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateDoubleOR))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Da2 = New System.Windows.Forms.DateTimePicker()
        Me.Da1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtORCount = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cboStation = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        Me.Panel1.SuspendLayout()
        CType(Me.txtORCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(379, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "  "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(2, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 18)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Update Double OR"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.ProgBar)
        Me.Panel1.Controls.Add(Me.cboStation)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtORCount)
        Me.Panel1.Controls.Add(Me.Da2)
        Me.Panel1.Controls.Add(Me.Da1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(6, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 282)
        Me.Panel1.TabIndex = 24
        '
        'Da2
        '
        Me.Da2.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.Da2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Da2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Da2.Location = New System.Drawing.Point(105, 148)
        Me.Da2.Name = "Da2"
        Me.Da2.Size = New System.Drawing.Size(217, 26)
        Me.Da2.TabIndex = 3
        '
        'Da1
        '
        Me.Da1.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.Da1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Da1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Da1.Location = New System.Drawing.Point(105, 103)
        Me.Da1.Name = "Da1"
        Me.Da1.Size = New System.Drawing.Size(217, 26)
        Me.Da1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "To :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "From :"
        '
        'txtORCount
        '
        Me.txtORCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtORCount.Location = New System.Drawing.Point(105, 60)
        Me.txtORCount.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.txtORCount.Name = "txtORCount"
        Me.txtORCount.Size = New System.Drawing.Size(217, 24)
        Me.txtORCount.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(58, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "OR :"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(147, 191)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "      &Update"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.White
        Me.cboStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4", "Station 5", "Station 6", "Station 7", "Station 8", "Station 9", "Station 10", "Station 11", "Station 12", "Station 13", "Station 14", "Station 15", "Station 16", "Station 17", "Station 18", "Station 19", "Station 20", "Station 21", "Station 22", "Station 23", "Station 24", "Station 25", "Station 26", "Station 27", "Station 28", "Station 29", "Station 30", "Station 31", "Station 32", "Station 33", "Station 34", "Station 35", "Station 36", "Station 37", "Station 38", "Station 39", "Station 40", "Station 41", "Station 42", "Station 43", "Station 44", "Station 45", "Station 46", "Station 47", "Station 48", "Station 49", "Station 50", "Station 51", "Station 52", "Station 53", "Station 54", "Station 55", "Station 56", "Station 57", "Station 58", "Station 59", "Station 60", "Station 61", "Station 62", "Station 63", "Station 64", "Station 65", "Station 66", "Station 67", "Station 68", "Station 69", "Station 70", "Station 71", "Station 72", "Station 73", "Station 74", "Station 75", "Station 76", "Station 77", "Station 78", "Station 79", "Station 80", "Station 81", "Station 82", "Station 83", "Station 84", "Station 85", "Station 86", "Station 87", "Station 88", "Station 89", "Station 90", "Station 91", "Station 92", "Station 93", "Station 94", "Station 95", "Station 96", "Station 97", "Station 98", "Station 99", "Station 100"})
        Me.cboStation.Location = New System.Drawing.Point(105, 21)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(217, 24)
        Me.cboStation.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Station :"
        '
        'ProgBar
        '
        Me.ProgBar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ProgBar.Location = New System.Drawing.Point(0, 248)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(383, 33)
        Me.ProgBar.TabIndex = 32
        '
        'frmUpdateDoubleOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(396, 316)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpdateDoubleOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtORCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Da2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Da1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtORCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProgBar As System.Windows.Forms.ProgressBar
End Class
