<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBreakdown
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBreakdown))
        Me.cmdCashOut = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotalCash = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cboCashier = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt1k = New System.Windows.Forms.Label
        Me.txt500 = New System.Windows.Forms.Label
        Me.txt200 = New System.Windows.Forms.Label
        Me.txt100 = New System.Windows.Forms.Label
        Me.txt50 = New System.Windows.Forms.Label
        Me.txt20 = New System.Windows.Forms.Label
        Me.txtQty1k = New System.Windows.Forms.NumericUpDown
        Me.txtQty500 = New System.Windows.Forms.NumericUpDown
        Me.txtQty200 = New System.Windows.Forms.NumericUpDown
        Me.txtQty100 = New System.Windows.Forms.NumericUpDown
        Me.txtQty50 = New System.Windows.Forms.NumericUpDown
        Me.txtQty20 = New System.Windows.Forms.NumericUpDown
        Me.txt1kAmt = New System.Windows.Forms.TextBox
        Me.txt500Amt = New System.Windows.Forms.TextBox
        Me.txt100Amt = New System.Windows.Forms.TextBox
        Me.txt200Amt = New System.Windows.Forms.TextBox
        Me.txt20Amt = New System.Windows.Forms.TextBox
        Me.txt50Amt = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        CType(Me.txtQty1k, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty200, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtQty20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdCashOut
        '
        Me.cmdCashOut.BackColor = System.Drawing.Color.White
        Me.cmdCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCashOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCashOut.ForeColor = System.Drawing.Color.Black
        Me.cmdCashOut.Image = CType(resources.GetObject("cmdCashOut.Image"), System.Drawing.Image)
        Me.cmdCashOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCashOut.Location = New System.Drawing.Point(244, 350)
        Me.cmdCashOut.Name = "cmdCashOut"
        Me.cmdCashOut.Size = New System.Drawing.Size(130, 37)
        Me.cmdCashOut.TabIndex = 7
        Me.cmdCashOut.Text = "    Cash Out"
        Me.cmdCashOut.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(121, 315)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Total Cash Out :"
        '
        'txtTotalCash
        '
        Me.txtTotalCash.AutoSize = True
        Me.txtTotalCash.BackColor = System.Drawing.Color.Navy
        Me.txtTotalCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCash.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalCash.Location = New System.Drawing.Point(241, 309)
        Me.txtTotalCash.Name = "txtTotalCash"
        Me.txtTotalCash.Size = New System.Drawing.Size(49, 24)
        Me.txtTotalCash.TabIndex = 33
        Me.txtTotalCash.Text = "0.00"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(66, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 37)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "      Add Denomination"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.txt20Amt)
        Me.Panel1.Controls.Add(Me.txt50Amt)
        Me.Panel1.Controls.Add(Me.txt100Amt)
        Me.Panel1.Controls.Add(Me.txt200Amt)
        Me.Panel1.Controls.Add(Me.txt500Amt)
        Me.Panel1.Controls.Add(Me.txt1kAmt)
        Me.Panel1.Controls.Add(Me.txtQty20)
        Me.Panel1.Controls.Add(Me.txtQty50)
        Me.Panel1.Controls.Add(Me.txtQty100)
        Me.Panel1.Controls.Add(Me.txtQty200)
        Me.Panel1.Controls.Add(Me.txtQty500)
        Me.Panel1.Controls.Add(Me.txtQty1k)
        Me.Panel1.Controls.Add(Me.txt20)
        Me.Panel1.Controls.Add(Me.txt50)
        Me.Panel1.Controls.Add(Me.txt100)
        Me.Panel1.Controls.Add(Me.txt200)
        Me.Panel1.Controls.Add(Me.txt500)
        Me.Panel1.Controls.Add(Me.txt1k)
        Me.Panel1.Controls.Add(Me.cboCashier)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtTotalCash)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmdCashOut)
        Me.Panel1.Location = New System.Drawing.Point(6, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 411)
        Me.Panel1.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 18)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cash Break Down"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(390, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "  "
        '
        'cboCashier
        '
        Me.cboCashier.BackColor = System.Drawing.Color.White
        Me.cboCashier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCashier.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCashier.FormattingEnabled = True
        Me.cboCashier.Location = New System.Drawing.Point(108, 16)
        Me.cboCashier.Name = "cboCashier"
        Me.cboCashier.Size = New System.Drawing.Size(276, 26)
        Me.cboCashier.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(32, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Cashier :"
        '
        'txt1k
        '
        Me.txt1k.AutoSize = True
        Me.txt1k.BackColor = System.Drawing.Color.Navy
        Me.txt1k.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1k.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt1k.Location = New System.Drawing.Point(42, 64)
        Me.txt1k.Name = "txt1k"
        Me.txt1k.Size = New System.Drawing.Size(82, 24)
        Me.txt1k.TabIndex = 75
        Me.txt1k.Text = "1000.00"
        '
        'txt500
        '
        Me.txt500.AutoSize = True
        Me.txt500.BackColor = System.Drawing.Color.Navy
        Me.txt500.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt500.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt500.Location = New System.Drawing.Point(42, 105)
        Me.txt500.Name = "txt500"
        Me.txt500.Size = New System.Drawing.Size(71, 24)
        Me.txt500.TabIndex = 76
        Me.txt500.Text = "500.00"
        '
        'txt200
        '
        Me.txt200.AutoSize = True
        Me.txt200.BackColor = System.Drawing.Color.Navy
        Me.txt200.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt200.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt200.Location = New System.Drawing.Point(42, 146)
        Me.txt200.Name = "txt200"
        Me.txt200.Size = New System.Drawing.Size(71, 24)
        Me.txt200.TabIndex = 77
        Me.txt200.Text = "200.00"
        '
        'txt100
        '
        Me.txt100.AutoSize = True
        Me.txt100.BackColor = System.Drawing.Color.Navy
        Me.txt100.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt100.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt100.Location = New System.Drawing.Point(41, 186)
        Me.txt100.Name = "txt100"
        Me.txt100.Size = New System.Drawing.Size(71, 24)
        Me.txt100.TabIndex = 78
        Me.txt100.Text = "100.00"
        '
        'txt50
        '
        Me.txt50.AutoSize = True
        Me.txt50.BackColor = System.Drawing.Color.Navy
        Me.txt50.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt50.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt50.Location = New System.Drawing.Point(42, 226)
        Me.txt50.Name = "txt50"
        Me.txt50.Size = New System.Drawing.Size(60, 24)
        Me.txt50.TabIndex = 79
        Me.txt50.Text = "50.00"
        '
        'txt20
        '
        Me.txt20.AutoSize = True
        Me.txt20.BackColor = System.Drawing.Color.Navy
        Me.txt20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt20.Location = New System.Drawing.Point(42, 267)
        Me.txt20.Name = "txt20"
        Me.txt20.Size = New System.Drawing.Size(60, 24)
        Me.txt20.TabIndex = 80
        Me.txt20.Text = "20.00"
        '
        'txtQty1k
        '
        Me.txtQty1k.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty1k.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty1k.Location = New System.Drawing.Point(147, 66)
        Me.txtQty1k.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtQty1k.Name = "txtQty1k"
        Me.txtQty1k.Size = New System.Drawing.Size(85, 22)
        Me.txtQty1k.TabIndex = 1
        '
        'txtQty500
        '
        Me.txtQty500.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty500.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty500.Location = New System.Drawing.Point(147, 107)
        Me.txtQty500.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtQty500.Name = "txtQty500"
        Me.txtQty500.Size = New System.Drawing.Size(85, 22)
        Me.txtQty500.TabIndex = 2
        '
        'txtQty200
        '
        Me.txtQty200.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty200.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty200.Location = New System.Drawing.Point(147, 148)
        Me.txtQty200.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtQty200.Name = "txtQty200"
        Me.txtQty200.Size = New System.Drawing.Size(85, 22)
        Me.txtQty200.TabIndex = 3
        '
        'txtQty100
        '
        Me.txtQty100.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty100.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty100.Location = New System.Drawing.Point(147, 188)
        Me.txtQty100.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtQty100.Name = "txtQty100"
        Me.txtQty100.Size = New System.Drawing.Size(85, 22)
        Me.txtQty100.TabIndex = 4
        '
        'txtQty50
        '
        Me.txtQty50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty50.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty50.Location = New System.Drawing.Point(147, 228)
        Me.txtQty50.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtQty50.Name = "txtQty50"
        Me.txtQty50.Size = New System.Drawing.Size(85, 22)
        Me.txtQty50.TabIndex = 5
        '
        'txtQty20
        '
        Me.txtQty20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty20.Location = New System.Drawing.Point(147, 269)
        Me.txtQty20.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.txtQty20.Name = "txtQty20"
        Me.txtQty20.Size = New System.Drawing.Size(85, 22)
        Me.txtQty20.TabIndex = 6
        '
        'txt1kAmt
        '
        Me.txt1kAmt.BackColor = System.Drawing.Color.White
        Me.txt1kAmt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1kAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt1kAmt.Location = New System.Drawing.Point(242, 66)
        Me.txt1kAmt.MaxLength = 30
        Me.txt1kAmt.Name = "txt1kAmt"
        Me.txt1kAmt.ReadOnly = True
        Me.txt1kAmt.Size = New System.Drawing.Size(141, 22)
        Me.txt1kAmt.TabIndex = 87
        Me.txt1kAmt.TabStop = False
        Me.txt1kAmt.Text = "0.00"
        '
        'txt500Amt
        '
        Me.txt500Amt.BackColor = System.Drawing.Color.White
        Me.txt500Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt500Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt500Amt.Location = New System.Drawing.Point(243, 107)
        Me.txt500Amt.MaxLength = 30
        Me.txt500Amt.Name = "txt500Amt"
        Me.txt500Amt.ReadOnly = True
        Me.txt500Amt.Size = New System.Drawing.Size(141, 22)
        Me.txt500Amt.TabIndex = 88
        Me.txt500Amt.TabStop = False
        Me.txt500Amt.Text = "0.00"
        '
        'txt100Amt
        '
        Me.txt100Amt.BackColor = System.Drawing.Color.White
        Me.txt100Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt100Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt100Amt.Location = New System.Drawing.Point(243, 188)
        Me.txt100Amt.MaxLength = 30
        Me.txt100Amt.Name = "txt100Amt"
        Me.txt100Amt.ReadOnly = True
        Me.txt100Amt.Size = New System.Drawing.Size(141, 22)
        Me.txt100Amt.TabIndex = 90
        Me.txt100Amt.TabStop = False
        Me.txt100Amt.Text = "0.00"
        '
        'txt200Amt
        '
        Me.txt200Amt.BackColor = System.Drawing.Color.White
        Me.txt200Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt200Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt200Amt.Location = New System.Drawing.Point(243, 148)
        Me.txt200Amt.MaxLength = 30
        Me.txt200Amt.Name = "txt200Amt"
        Me.txt200Amt.ReadOnly = True
        Me.txt200Amt.Size = New System.Drawing.Size(141, 22)
        Me.txt200Amt.TabIndex = 89
        Me.txt200Amt.TabStop = False
        Me.txt200Amt.Text = "0.00"
        '
        'txt20Amt
        '
        Me.txt20Amt.BackColor = System.Drawing.Color.White
        Me.txt20Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt20Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt20Amt.Location = New System.Drawing.Point(244, 269)
        Me.txt20Amt.MaxLength = 30
        Me.txt20Amt.Name = "txt20Amt"
        Me.txt20Amt.ReadOnly = True
        Me.txt20Amt.Size = New System.Drawing.Size(141, 22)
        Me.txt20Amt.TabIndex = 92
        Me.txt20Amt.TabStop = False
        Me.txt20Amt.Text = "0.00"
        '
        'txt50Amt
        '
        Me.txt50Amt.BackColor = System.Drawing.Color.White
        Me.txt50Amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt50Amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt50Amt.Location = New System.Drawing.Point(243, 228)
        Me.txt50Amt.MaxLength = 30
        Me.txt50Amt.Name = "txt50Amt"
        Me.txt50Amt.ReadOnly = True
        Me.txt50Amt.Size = New System.Drawing.Size(141, 22)
        Me.txt50Amt.TabIndex = 91
        Me.txt50Amt.TabStop = False
        Me.txt50Amt.Text = "0.00"
        '
        'frmBreakdown
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(407, 442)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBreakdown"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtQty1k, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty200, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtQty20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCashOut As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotalCash As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCashier As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt20 As System.Windows.Forms.Label
    Friend WithEvents txt50 As System.Windows.Forms.Label
    Friend WithEvents txt100 As System.Windows.Forms.Label
    Friend WithEvents txt200 As System.Windows.Forms.Label
    Friend WithEvents txt500 As System.Windows.Forms.Label
    Friend WithEvents txt1k As System.Windows.Forms.Label
    Friend WithEvents txtQty20 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtQty50 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtQty100 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtQty200 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtQty500 As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtQty1k As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt500Amt As System.Windows.Forms.TextBox
    Friend WithEvents txt1kAmt As System.Windows.Forms.TextBox
    Friend WithEvents txt20Amt As System.Windows.Forms.TextBox
    Friend WithEvents txt50Amt As System.Windows.Forms.TextBox
    Friend WithEvents txt100Amt As System.Windows.Forms.TextBox
    Friend WithEvents txt200Amt As System.Windows.Forms.TextBox
End Class
