<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetController
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetController))
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.txtTriggerDelay = New System.Windows.Forms.NumericUpDown
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmdSave = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtSN = New System.Windows.Forms.TextBox
        Me.txtSubnet = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtMack = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtIP = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtGateway = New System.Windows.Forms.TextBox
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.txtPcIp = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnFind = New System.Windows.Forms.Button
        Me.btnTrigger = New System.Windows.Forms.Button
        Me.HeaderPanel.SuspendLayout()
        CType(Me.txtTriggerDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(395, 38)
        Me.HeaderPanel.TabIndex = 0
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
        Me.Label8.Size = New System.Drawing.Size(174, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Controller Settings"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(366, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'txtTriggerDelay
        '
        Me.txtTriggerDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTriggerDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTriggerDelay.Location = New System.Drawing.Point(148, 355)
        Me.txtTriggerDelay.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtTriggerDelay.Name = "txtTriggerDelay"
        Me.txtTriggerDelay.Size = New System.Drawing.Size(210, 22)
        Me.txtTriggerDelay.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(30, 357)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 16)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "Trigger Delay :"
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.Black
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSave.Location = New System.Drawing.Point(260, 402)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(98, 38)
        Me.cmdSave.TabIndex = 8
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 18)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Subnet Mask :"
        '
        'txtSN
        '
        Me.txtSN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSN.Location = New System.Drawing.Point(148, 75)
        Me.txtSN.MaxLength = 30
        Me.txtSN.Name = "txtSN"
        Me.txtSN.Size = New System.Drawing.Size(212, 22)
        Me.txtSN.TabIndex = 0
        '
        'txtSubnet
        '
        Me.txtSubnet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubnet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubnet.Location = New System.Drawing.Point(149, 233)
        Me.txtSubnet.MaxLength = 30
        Me.txtSubnet.Name = "txtSubnet"
        Me.txtSubnet.Size = New System.Drawing.Size(211, 22)
        Me.txtSubnet.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(110, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 18)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "IP :"
        '
        'txtMack
        '
        Me.txtMack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMack.Location = New System.Drawing.Point(149, 193)
        Me.txtMack.MaxLength = 30
        Me.txtMack.Name = "txtMack"
        Me.txtMack.Size = New System.Drawing.Size(211, 22)
        Me.txtMack.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(102, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 18)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "SN :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(60, 273)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 18)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Gateway :"
        '
        'txtIP
        '
        Me.txtIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIP.Location = New System.Drawing.Point(149, 114)
        Me.txtIP.MaxLength = 30
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(211, 22)
        Me.txtIP.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(60, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 18)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Mac Add :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(93, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 18)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Port :"
        '
        'txtGateway
        '
        Me.txtGateway.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGateway.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGateway.Location = New System.Drawing.Point(149, 273)
        Me.txtGateway.MaxLength = 30
        Me.txtGateway.Name = "txtGateway"
        Me.txtGateway.Size = New System.Drawing.Size(211, 22)
        Me.txtGateway.TabIndex = 5
        '
        'txtPort
        '
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(149, 153)
        Me.txtPort.MaxLength = 30
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(211, 22)
        Me.txtPort.TabIndex = 2
        '
        'txtPcIp
        '
        Me.txtPcIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPcIp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPcIp.Location = New System.Drawing.Point(148, 314)
        Me.txtPcIp.MaxLength = 30
        Me.txtPcIp.Name = "txtPcIp"
        Me.txtPcIp.Size = New System.Drawing.Size(211, 22)
        Me.txtPcIp.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(46, 314)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 18)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "This PC IP :"
        '
        'btnFind
        '
        Me.btnFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFind.ForeColor = System.Drawing.Color.Black
        Me.btnFind.Image = CType(resources.GetObject("btnFind.Image"), System.Drawing.Image)
        Me.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFind.Location = New System.Drawing.Point(52, 402)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(98, 38)
        Me.btnFind.TabIndex = 45
        Me.btnFind.Text = "&Find"
        Me.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFind.UseVisualStyleBackColor = False
        '
        'btnTrigger
        '
        Me.btnTrigger.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTrigger.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTrigger.ForeColor = System.Drawing.Color.Black
        Me.btnTrigger.Image = CType(resources.GetObject("btnTrigger.Image"), System.Drawing.Image)
        Me.btnTrigger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTrigger.Location = New System.Drawing.Point(156, 402)
        Me.btnTrigger.Name = "btnTrigger"
        Me.btnTrigger.Size = New System.Drawing.Size(98, 38)
        Me.btnTrigger.TabIndex = 46
        Me.btnTrigger.Text = "&Test"
        Me.btnTrigger.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTrigger.UseVisualStyleBackColor = False
        '
        'frmSetController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(389, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnTrigger)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.txtPcIp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTriggerDelay)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSN)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtSubnet)
        Me.Controls.Add(Me.txtGateway)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtIP)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSetController"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.txtTriggerDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents txtMack As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGateway As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSubnet As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtSN As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTriggerDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents txtPcIp As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnTrigger As System.Windows.Forms.Button
End Class
