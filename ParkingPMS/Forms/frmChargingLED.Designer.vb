<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChargingLED
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChargingLED))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboCom3 = New System.Windows.Forms.ComboBox()
        Me.cmdO = New System.Windows.Forms.Button()
        Me.txtOvernightIP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOVAmt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboCom2 = New System.Windows.Forms.ComboBox()
        Me.cmdF = New System.Windows.Forms.Button()
        Me.txtFlatRateIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFlatrateAmt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboCom1 = New System.Windows.Forms.ComboBox()
        Me.cmdH = New System.Windows.Forms.Button()
        Me.txtHourlyIP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtHourlyAmt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 464)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboCom3)
        Me.GroupBox3.Controls.Add(Me.cmdO)
        Me.GroupBox3.Controls.Add(Me.txtOvernightIP)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtOVAmt)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(8, 307)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 147)
        Me.GroupBox3.TabIndex = 75
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Overnight LED"
        '
        'cboCom3
        '
        Me.cboCom3.BackColor = System.Drawing.Color.White
        Me.cboCom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCom3.FormattingEnabled = True
        Me.cboCom3.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboCom3.Location = New System.Drawing.Point(261, 69)
        Me.cboCom3.Name = "cboCom3"
        Me.cboCom3.Size = New System.Drawing.Size(76, 24)
        Me.cboCom3.TabIndex = 74
        '
        'cmdO
        '
        Me.cmdO.BackColor = System.Drawing.Color.White
        Me.cmdO.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdO.ForeColor = System.Drawing.Color.Black
        Me.cmdO.Image = CType(resources.GetObject("cmdO.Image"), System.Drawing.Image)
        Me.cmdO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdO.Location = New System.Drawing.Point(261, 99)
        Me.cmdO.Name = "cmdO"
        Me.cmdO.Size = New System.Drawing.Size(76, 34)
        Me.cmdO.TabIndex = 29
        Me.cmdO.Text = "    Send"
        Me.cmdO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdO.UseVisualStyleBackColor = False
        '
        'txtOvernightIP
        '
        Me.txtOvernightIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOvernightIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOvernightIP.Location = New System.Drawing.Point(136, 32)
        Me.txtOvernightIP.Name = "txtOvernightIP"
        Me.txtOvernightIP.Size = New System.Drawing.Size(201, 22)
        Me.txtOvernightIP.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(96, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = " IP :"
        '
        'txtOVAmt
        '
        Me.txtOVAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOVAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOVAmt.Location = New System.Drawing.Point(136, 68)
        Me.txtOVAmt.Name = "txtOVAmt"
        Me.txtOVAmt.Size = New System.Drawing.Size(119, 22)
        Me.txtOVAmt.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(63, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Amount :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboCom2)
        Me.GroupBox2.Controls.Add(Me.cmdF)
        Me.GroupBox2.Controls.Add(Me.txtFlatRateIP)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtFlatrateAmt)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 147)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flatrate LED"
        '
        'cboCom2
        '
        Me.cboCom2.BackColor = System.Drawing.Color.White
        Me.cboCom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCom2.FormattingEnabled = True
        Me.cboCom2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboCom2.Location = New System.Drawing.Point(261, 69)
        Me.cboCom2.Name = "cboCom2"
        Me.cboCom2.Size = New System.Drawing.Size(76, 24)
        Me.cboCom2.TabIndex = 74
        '
        'cmdF
        '
        Me.cmdF.BackColor = System.Drawing.Color.White
        Me.cmdF.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdF.ForeColor = System.Drawing.Color.Black
        Me.cmdF.Image = CType(resources.GetObject("cmdF.Image"), System.Drawing.Image)
        Me.cmdF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdF.Location = New System.Drawing.Point(261, 99)
        Me.cmdF.Name = "cmdF"
        Me.cmdF.Size = New System.Drawing.Size(76, 34)
        Me.cmdF.TabIndex = 29
        Me.cmdF.Text = "    Send"
        Me.cmdF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdF.UseVisualStyleBackColor = False
        '
        'txtFlatRateIP
        '
        Me.txtFlatRateIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFlatRateIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlatRateIP.Location = New System.Drawing.Point(136, 32)
        Me.txtFlatRateIP.Name = "txtFlatRateIP"
        Me.txtFlatRateIP.Size = New System.Drawing.Size(201, 22)
        Me.txtFlatRateIP.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(97, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = " IP :"
        '
        'txtFlatrateAmt
        '
        Me.txtFlatrateAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFlatrateAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlatrateAmt.Location = New System.Drawing.Point(136, 68)
        Me.txtFlatrateAmt.Name = "txtFlatrateAmt"
        Me.txtFlatrateAmt.Size = New System.Drawing.Size(119, 22)
        Me.txtFlatrateAmt.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(63, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Amount :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboCom1)
        Me.GroupBox1.Controls.Add(Me.cmdH)
        Me.GroupBox1.Controls.Add(Me.txtHourlyIP)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtHourlyAmt)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 147)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hourly LED"
        '
        'cboCom1
        '
        Me.cboCom1.BackColor = System.Drawing.Color.White
        Me.cboCom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCom1.FormattingEnabled = True
        Me.cboCom1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6"})
        Me.cboCom1.Location = New System.Drawing.Point(261, 69)
        Me.cboCom1.Name = "cboCom1"
        Me.cboCom1.Size = New System.Drawing.Size(76, 24)
        Me.cboCom1.TabIndex = 74
        '
        'cmdH
        '
        Me.cmdH.BackColor = System.Drawing.Color.White
        Me.cmdH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdH.ForeColor = System.Drawing.Color.Black
        Me.cmdH.Image = CType(resources.GetObject("cmdH.Image"), System.Drawing.Image)
        Me.cmdH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdH.Location = New System.Drawing.Point(261, 99)
        Me.cmdH.Name = "cmdH"
        Me.cmdH.Size = New System.Drawing.Size(76, 34)
        Me.cmdH.TabIndex = 29
        Me.cmdH.Text = "    Send"
        Me.cmdH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdH.UseVisualStyleBackColor = False
        '
        'txtHourlyIP
        '
        Me.txtHourlyIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHourlyIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHourlyIP.Location = New System.Drawing.Point(136, 32)
        Me.txtHourlyIP.Name = "txtHourlyIP"
        Me.txtHourlyIP.Size = New System.Drawing.Size(201, 22)
        Me.txtHourlyIP.TabIndex = 25
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(96, 34)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 16)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = " IP :"
        '
        'txtHourlyAmt
        '
        Me.txtHourlyAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHourlyAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHourlyAmt.Location = New System.Drawing.Point(136, 68)
        Me.txtHourlyAmt.Name = "txtHourlyAmt"
        Me.txtHourlyAmt.Size = New System.Drawing.Size(119, 22)
        Me.txtHourlyAmt.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(63, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Amount :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(359, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 20)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(1, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "LED Charging Rules"
        '
        'frmChargingLED
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(378, 495)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChargingLED"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtHourlyIP As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtHourlyAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdH As System.Windows.Forms.Button
    Friend WithEvents cboCom1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCom2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmdF As System.Windows.Forms.Button
    Friend WithEvents txtFlatRateIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFlatrateAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboCom3 As System.Windows.Forms.ComboBox
    Friend WithEvents cmdO As System.Windows.Forms.Button
    Friend WithEvents txtOvernightIP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOVAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
