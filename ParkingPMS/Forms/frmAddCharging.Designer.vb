<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddCharging
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddCharging))
        Me.txtVtype = New System.Windows.Forms.TextBox
        Me.cboChargeType = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboKey = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtIntAmount = New System.Windows.Forms.NumericUpDown
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtLostCard = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFlatRate = New System.Windows.Forms.NumericUpDown
        Me.txtGPeriod = New System.Windows.Forms.NumericUpDown
        Me.txtMinMinutes = New System.Windows.Forms.NumericUpDown
        Me.txtAmount = New System.Windows.Forms.NumericUpDown
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        CType(Me.txtIntAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLostCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFlatRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtVtype
        '
        Me.txtVtype.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVtype.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtVtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVtype.Location = New System.Drawing.Point(168, 70)
        Me.txtVtype.MaxLength = 30
        Me.txtVtype.Name = "txtVtype"
        Me.txtVtype.Size = New System.Drawing.Size(184, 22)
        Me.txtVtype.TabIndex = 0
        '
        'cboChargeType
        '
        Me.cboChargeType.BackColor = System.Drawing.Color.White
        Me.cboChargeType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboChargeType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChargeType.FormattingEnabled = True
        Me.cboChargeType.Items.AddRange(New Object() {"Regular", "Coupon", "Senior"})
        Me.cboChargeType.Location = New System.Drawing.Point(168, 362)
        Me.cboChargeType.Name = "cboChargeType"
        Me.cboChargeType.Size = New System.Drawing.Size(184, 24)
        Me.cboChargeType.TabIndex = 8
        Me.cboChargeType.Text = "Regular"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(60, 365)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 16)
        Me.Label12.TabIndex = 66
        Me.Label12.Text = "Charge Type :"
        '
        'cboKey
        '
        Me.cboKey.BackColor = System.Drawing.Color.White
        Me.cboKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboKey.FormattingEnabled = True
        Me.cboKey.Items.AddRange(New Object() {"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"})
        Me.cboKey.Location = New System.Drawing.Point(168, 406)
        Me.cboKey.Name = "cboKey"
        Me.cboKey.Size = New System.Drawing.Size(184, 24)
        Me.cboKey.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(124, 409)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Key :"
        '
        'txtIntAmount
        '
        Me.txtIntAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIntAmount.DecimalPlaces = 2
        Me.txtIntAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIntAmount.Location = New System.Drawing.Point(168, 236)
        Me.txtIntAmount.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtIntAmount.Name = "txtIntAmount"
        Me.txtIntAmount.Size = New System.Drawing.Size(184, 22)
        Me.txtIntAmount.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 16)
        Me.Label5.TabIndex = 63
        Me.Label5.Text = "Succeeding Amount :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(356, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 16)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Mins."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(356, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Mins."
        '
        'txtLostCard
        '
        Me.txtLostCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLostCard.DecimalPlaces = 2
        Me.txtLostCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLostCard.Location = New System.Drawing.Point(168, 320)
        Me.txtLostCard.Maximum = New Decimal(New Integer() {500000, 0, 0, 0})
        Me.txtLostCard.Name = "txtLostCard"
        Me.txtLostCard.Size = New System.Drawing.Size(184, 22)
        Me.txtLostCard.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(30, 322)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Lost Card Charge :"
        '
        'txtFlatRate
        '
        Me.txtFlatRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFlatRate.DecimalPlaces = 2
        Me.txtFlatRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFlatRate.Location = New System.Drawing.Point(168, 277)
        Me.txtFlatRate.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtFlatRate.Name = "txtFlatRate"
        Me.txtFlatRate.Size = New System.Drawing.Size(184, 22)
        Me.txtFlatRate.TabIndex = 5
        '
        'txtGPeriod
        '
        Me.txtGPeriod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGPeriod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGPeriod.Location = New System.Drawing.Point(168, 112)
        Me.txtGPeriod.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtGPeriod.Name = "txtGPeriod"
        Me.txtGPeriod.Size = New System.Drawing.Size(184, 22)
        Me.txtGPeriod.TabIndex = 1
        '
        'txtMinMinutes
        '
        Me.txtMinMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMinMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinMinutes.Location = New System.Drawing.Point(168, 153)
        Me.txtMinMinutes.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtMinMinutes.Name = "txtMinMinutes"
        Me.txtMinMinutes.Size = New System.Drawing.Size(184, 22)
        Me.txtMinMinutes.TabIndex = 3
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.DecimalPlaces = 2
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(168, 196)
        Me.txtAmount.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(184, 22)
        Me.txtAmount.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(32, 279)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Flat Rate Amount :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(65, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "First Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(63, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "First Minutes :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(58, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Grace Period :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(58, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Vehicle Type :"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.lblTitle)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(418, 38)
        Me.HeaderPanel.TabIndex = 67
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), System.Drawing.Image)
        Me.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTitle.Location = New System.Drawing.Point(6, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(178, 18)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "     New Charging Rate"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(397, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(297, 449)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 38)
        Me.btnSave.TabIndex = 89
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmAddCharging
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(418, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.txtVtype)
        Me.Controls.Add(Me.cboChargeType)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cboKey)
        Me.Controls.Add(Me.txtMinMinutes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtIntAmount)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLostCard)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtGPeriod)
        Me.Controls.Add(Me.txtFlatRate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddCharging"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.txtIntAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLostCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFlatRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtGPeriod As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtMinMinutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtLostCard As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFlatRate As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIntAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboKey As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboChargeType As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtVtype As System.Windows.Forms.TextBox
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
