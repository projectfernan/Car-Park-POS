<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCcommand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCcommand))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdGraceMin = New System.Windows.Forms.Button()
        Me.cmdGraceStat = New System.Windows.Forms.Button()
        Me.cboGraceStat = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGraceMin = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmdBackUp = New System.Windows.Forms.Button()
        Me.StopDev = New System.Windows.Forms.Button()
        Me.cmdShutdown = New System.Windows.Forms.Button()
        Me.cmdRestartUnit = New System.Windows.Forms.Button()
        Me.txtStat = New System.Windows.Forms.RichTextBox()
        Me.cmdResetCam = New System.Windows.Forms.Button()
        Me.cmdDevStatus = New System.Windows.Forms.Button()
        Me.cmdOpenBarrier = New System.Windows.Forms.Button()
        Me.cmdRestartDev = New System.Windows.Forms.Button()
        Me.txtCapturer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.txtGraceMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.cmdGraceMin)
        Me.Panel1.Controls.Add(Me.cmdGraceStat)
        Me.Panel1.Controls.Add(Me.cboGraceStat)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtGraceMin)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmdBackUp)
        Me.Panel1.Controls.Add(Me.StopDev)
        Me.Panel1.Controls.Add(Me.cmdShutdown)
        Me.Panel1.Controls.Add(Me.cmdRestartUnit)
        Me.Panel1.Controls.Add(Me.txtStat)
        Me.Panel1.Controls.Add(Me.cmdResetCam)
        Me.Panel1.Controls.Add(Me.cmdDevStatus)
        Me.Panel1.Controls.Add(Me.cmdOpenBarrier)
        Me.Panel1.Controls.Add(Me.cmdRestartDev)
        Me.Panel1.Controls.Add(Me.txtCapturer)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(5, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 412)
        Me.Panel1.TabIndex = 2
        '
        'cmdGraceMin
        '
        Me.cmdGraceMin.BackColor = System.Drawing.Color.White
        Me.cmdGraceMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGraceMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraceMin.ForeColor = System.Drawing.Color.Black
        Me.cmdGraceMin.Image = CType(resources.GetObject("cmdGraceMin.Image"), System.Drawing.Image)
        Me.cmdGraceMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGraceMin.Location = New System.Drawing.Point(268, 366)
        Me.cmdGraceMin.Name = "cmdGraceMin"
        Me.cmdGraceMin.Size = New System.Drawing.Size(33, 34)
        Me.cmdGraceMin.TabIndex = 41
        Me.cmdGraceMin.UseVisualStyleBackColor = False
        '
        'cmdGraceStat
        '
        Me.cmdGraceStat.BackColor = System.Drawing.Color.White
        Me.cmdGraceStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGraceStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGraceStat.ForeColor = System.Drawing.Color.Black
        Me.cmdGraceStat.Image = CType(resources.GetObject("cmdGraceStat.Image"), System.Drawing.Image)
        Me.cmdGraceStat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGraceStat.Location = New System.Drawing.Point(268, 329)
        Me.cmdGraceStat.Name = "cmdGraceStat"
        Me.cmdGraceStat.Size = New System.Drawing.Size(33, 34)
        Me.cmdGraceStat.TabIndex = 40
        Me.cmdGraceStat.UseVisualStyleBackColor = False
        '
        'cboGraceStat
        '
        Me.cboGraceStat.BackColor = System.Drawing.Color.White
        Me.cboGraceStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboGraceStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGraceStat.FormattingEnabled = True
        Me.cboGraceStat.Items.AddRange(New Object() {"True", "False"})
        Me.cboGraceStat.Location = New System.Drawing.Point(150, 335)
        Me.cboGraceStat.Name = "cboGraceStat"
        Me.cboGraceStat.Size = New System.Drawing.Size(105, 24)
        Me.cboGraceStat.TabIndex = 38
        Me.cboGraceStat.Text = "True"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(36, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Grace Period :"
        '
        'txtGraceMin
        '
        Me.txtGraceMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGraceMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGraceMin.Location = New System.Drawing.Point(150, 373)
        Me.txtGraceMin.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.txtGraceMin.Name = "txtGraceMin"
        Me.txtGraceMin.Size = New System.Drawing.Size(105, 22)
        Me.txtGraceMin.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(9, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Set Grace Period :"
        '
        'cmdBackUp
        '
        Me.cmdBackUp.BackColor = System.Drawing.Color.White
        Me.cmdBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBackUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBackUp.ForeColor = System.Drawing.Color.Black
        Me.cmdBackUp.Image = CType(resources.GetObject("cmdBackUp.Image"), System.Drawing.Image)
        Me.cmdBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBackUp.Location = New System.Drawing.Point(9, 289)
        Me.cmdBackUp.Name = "cmdBackUp"
        Me.cmdBackUp.Size = New System.Drawing.Size(143, 34)
        Me.cmdBackUp.TabIndex = 35
        Me.cmdBackUp.Text = "      &Get Backup"
        Me.cmdBackUp.UseVisualStyleBackColor = False
        '
        'StopDev
        '
        Me.StopDev.BackColor = System.Drawing.Color.White
        Me.StopDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.StopDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StopDev.ForeColor = System.Drawing.Color.Black
        Me.StopDev.Image = CType(resources.GetObject("StopDev.Image"), System.Drawing.Image)
        Me.StopDev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StopDev.Location = New System.Drawing.Point(158, 209)
        Me.StopDev.Name = "StopDev"
        Me.StopDev.Size = New System.Drawing.Size(143, 34)
        Me.StopDev.TabIndex = 34
        Me.StopDev.Text = "      &Stop Device"
        Me.StopDev.UseVisualStyleBackColor = False
        '
        'cmdShutdown
        '
        Me.cmdShutdown.BackColor = System.Drawing.Color.White
        Me.cmdShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShutdown.ForeColor = System.Drawing.Color.Black
        Me.cmdShutdown.Image = CType(resources.GetObject("cmdShutdown.Image"), System.Drawing.Image)
        Me.cmdShutdown.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdShutdown.Location = New System.Drawing.Point(158, 169)
        Me.cmdShutdown.Name = "cmdShutdown"
        Me.cmdShutdown.Size = New System.Drawing.Size(143, 34)
        Me.cmdShutdown.TabIndex = 33
        Me.cmdShutdown.Text = "          &Shutdown Unit"
        Me.cmdShutdown.UseVisualStyleBackColor = False
        '
        'cmdRestartUnit
        '
        Me.cmdRestartUnit.BackColor = System.Drawing.Color.White
        Me.cmdRestartUnit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRestartUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestartUnit.ForeColor = System.Drawing.Color.Black
        Me.cmdRestartUnit.Image = CType(resources.GetObject("cmdRestartUnit.Image"), System.Drawing.Image)
        Me.cmdRestartUnit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRestartUnit.Location = New System.Drawing.Point(9, 169)
        Me.cmdRestartUnit.Name = "cmdRestartUnit"
        Me.cmdRestartUnit.Size = New System.Drawing.Size(143, 34)
        Me.cmdRestartUnit.TabIndex = 32
        Me.cmdRestartUnit.Text = "      &Restart Unit"
        Me.cmdRestartUnit.UseVisualStyleBackColor = False
        '
        'txtStat
        '
        Me.txtStat.BackColor = System.Drawing.Color.White
        Me.txtStat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStat.Location = New System.Drawing.Point(9, 69)
        Me.txtStat.Name = "txtStat"
        Me.txtStat.ReadOnly = True
        Me.txtStat.Size = New System.Drawing.Size(292, 93)
        Me.txtStat.TabIndex = 31
        Me.txtStat.Text = ""
        '
        'cmdResetCam
        '
        Me.cmdResetCam.BackColor = System.Drawing.Color.White
        Me.cmdResetCam.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdResetCam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetCam.ForeColor = System.Drawing.Color.Black
        Me.cmdResetCam.Image = CType(resources.GetObject("cmdResetCam.Image"), System.Drawing.Image)
        Me.cmdResetCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdResetCam.Location = New System.Drawing.Point(158, 249)
        Me.cmdResetCam.Name = "cmdResetCam"
        Me.cmdResetCam.Size = New System.Drawing.Size(143, 34)
        Me.cmdResetCam.TabIndex = 29
        Me.cmdResetCam.Text = "      &Reset Cam"
        Me.cmdResetCam.UseVisualStyleBackColor = False
        '
        'cmdDevStatus
        '
        Me.cmdDevStatus.BackColor = System.Drawing.Color.White
        Me.cmdDevStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDevStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevStatus.ForeColor = System.Drawing.Color.Black
        Me.cmdDevStatus.Image = CType(resources.GetObject("cmdDevStatus.Image"), System.Drawing.Image)
        Me.cmdDevStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDevStatus.Location = New System.Drawing.Point(9, 249)
        Me.cmdDevStatus.Name = "cmdDevStatus"
        Me.cmdDevStatus.Size = New System.Drawing.Size(143, 34)
        Me.cmdDevStatus.TabIndex = 28
        Me.cmdDevStatus.Text = "      &Device Status"
        Me.cmdDevStatus.UseVisualStyleBackColor = False
        '
        'cmdOpenBarrier
        '
        Me.cmdOpenBarrier.BackColor = System.Drawing.Color.White
        Me.cmdOpenBarrier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpenBarrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenBarrier.ForeColor = System.Drawing.Color.Black
        Me.cmdOpenBarrier.Image = CType(resources.GetObject("cmdOpenBarrier.Image"), System.Drawing.Image)
        Me.cmdOpenBarrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOpenBarrier.Location = New System.Drawing.Point(158, 289)
        Me.cmdOpenBarrier.Name = "cmdOpenBarrier"
        Me.cmdOpenBarrier.Size = New System.Drawing.Size(143, 34)
        Me.cmdOpenBarrier.TabIndex = 27
        Me.cmdOpenBarrier.Text = "      &Open Barrier"
        Me.cmdOpenBarrier.UseVisualStyleBackColor = False
        '
        'cmdRestartDev
        '
        Me.cmdRestartDev.BackColor = System.Drawing.Color.White
        Me.cmdRestartDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRestartDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestartDev.ForeColor = System.Drawing.Color.Black
        Me.cmdRestartDev.Image = CType(resources.GetObject("cmdRestartDev.Image"), System.Drawing.Image)
        Me.cmdRestartDev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRestartDev.Location = New System.Drawing.Point(9, 209)
        Me.cmdRestartDev.Name = "cmdRestartDev"
        Me.cmdRestartDev.Size = New System.Drawing.Size(143, 34)
        Me.cmdRestartDev.TabIndex = 26
        Me.cmdRestartDev.Text = "      &Restart Device"
        Me.cmdRestartDev.UseVisualStyleBackColor = False
        '
        'txtCapturer
        '
        Me.txtCapturer.AutoSize = True
        Me.txtCapturer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapturer.ForeColor = System.Drawing.Color.White
        Me.txtCapturer.Location = New System.Drawing.Point(62, 24)
        Me.txtCapturer.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txtCapturer.Name = "txtCapturer"
        Me.txtCapturer.Size = New System.Drawing.Size(89, 18)
        Me.txtCapturer.TabIndex = 20
        Me.txtCapturer.Text = "Exit Zone :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(302, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 5)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 18)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Send Command to Capturer"
        '
        'frmCcommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(321, 447)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCcommand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtGraceMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtStat As System.Windows.Forms.RichTextBox
    Friend WithEvents cmdResetCam As System.Windows.Forms.Button
    Friend WithEvents cmdDevStatus As System.Windows.Forms.Button
    Friend WithEvents cmdOpenBarrier As System.Windows.Forms.Button
    Friend WithEvents cmdRestartDev As System.Windows.Forms.Button
    Friend WithEvents txtCapturer As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents StopDev As System.Windows.Forms.Button
    Friend WithEvents cmdShutdown As System.Windows.Forms.Button
    Friend WithEvents cmdRestartUnit As System.Windows.Forms.Button
    Friend WithEvents cmdBackUp As System.Windows.Forms.Button
    Friend WithEvents txtGraceMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboGraceStat As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdGraceMin As System.Windows.Forms.Button
    Friend WithEvents cmdGraceStat As System.Windows.Forms.Button
End Class
