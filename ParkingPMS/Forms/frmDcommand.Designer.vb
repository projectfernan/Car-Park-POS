<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDcommand
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDcommand))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtStat = New System.Windows.Forms.RichTextBox
        Me.cmdResetCam = New System.Windows.Forms.Button
        Me.cmdDevStatus = New System.Windows.Forms.Button
        Me.cmdOpenBarrier = New System.Windows.Forms.Button
        Me.cmdRestartDev = New System.Windows.Forms.Button
        Me.txtDispenser = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtStat)
        Me.Panel1.Controls.Add(Me.cmdResetCam)
        Me.Panel1.Controls.Add(Me.cmdDevStatus)
        Me.Panel1.Controls.Add(Me.cmdOpenBarrier)
        Me.Panel1.Controls.Add(Me.cmdRestartDev)
        Me.Panel1.Controls.Add(Me.txtDispenser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel1.Location = New System.Drawing.Point(8, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 259)
        Me.Panel1.TabIndex = 1
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
        Me.cmdResetCam.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdResetCam.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdResetCam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetCam.ForeColor = System.Drawing.Color.White
        Me.cmdResetCam.Image = CType(resources.GetObject("cmdResetCam.Image"), System.Drawing.Image)
        Me.cmdResetCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdResetCam.Location = New System.Drawing.Point(158, 215)
        Me.cmdResetCam.Name = "cmdResetCam"
        Me.cmdResetCam.Size = New System.Drawing.Size(143, 34)
        Me.cmdResetCam.TabIndex = 29
        Me.cmdResetCam.Text = "      &Reset Cam"
        Me.cmdResetCam.UseVisualStyleBackColor = False
        '
        'cmdDevStatus
        '
        Me.cmdDevStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDevStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDevStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevStatus.ForeColor = System.Drawing.Color.White
        Me.cmdDevStatus.Image = CType(resources.GetObject("cmdDevStatus.Image"), System.Drawing.Image)
        Me.cmdDevStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDevStatus.Location = New System.Drawing.Point(158, 172)
        Me.cmdDevStatus.Name = "cmdDevStatus"
        Me.cmdDevStatus.Size = New System.Drawing.Size(143, 34)
        Me.cmdDevStatus.TabIndex = 28
        Me.cmdDevStatus.Text = "      &Device Status"
        Me.cmdDevStatus.UseVisualStyleBackColor = False
        '
        'cmdOpenBarrier
        '
        Me.cmdOpenBarrier.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdOpenBarrier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpenBarrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenBarrier.ForeColor = System.Drawing.Color.White
        Me.cmdOpenBarrier.Image = CType(resources.GetObject("cmdOpenBarrier.Image"), System.Drawing.Image)
        Me.cmdOpenBarrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOpenBarrier.Location = New System.Drawing.Point(9, 215)
        Me.cmdOpenBarrier.Name = "cmdOpenBarrier"
        Me.cmdOpenBarrier.Size = New System.Drawing.Size(143, 34)
        Me.cmdOpenBarrier.TabIndex = 27
        Me.cmdOpenBarrier.Text = "      &Open Barrier"
        Me.cmdOpenBarrier.UseVisualStyleBackColor = False
        '
        'cmdRestartDev
        '
        Me.cmdRestartDev.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdRestartDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRestartDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestartDev.ForeColor = System.Drawing.Color.White
        Me.cmdRestartDev.Image = CType(resources.GetObject("cmdRestartDev.Image"), System.Drawing.Image)
        Me.cmdRestartDev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRestartDev.Location = New System.Drawing.Point(9, 172)
        Me.cmdRestartDev.Name = "cmdRestartDev"
        Me.cmdRestartDev.Size = New System.Drawing.Size(143, 34)
        Me.cmdRestartDev.TabIndex = 26
        Me.cmdRestartDev.Text = "      &Restart Device"
        Me.cmdRestartDev.UseVisualStyleBackColor = False
        '
        'txtDispenser
        '
        Me.txtDispenser.AutoSize = True
        Me.txtDispenser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispenser.ForeColor = System.Drawing.Color.Black
        Me.txtDispenser.Location = New System.Drawing.Point(62, 26)
        Me.txtDispenser.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txtDispenser.Name = "txtDispenser"
        Me.txtDispenser.Size = New System.Drawing.Size(100, 18)
        Me.txtDispenser.TabIndex = 20
        Me.txtDispenser.Text = "Entry Zone :"
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
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.lblTitle)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(325, 38)
        Me.HeaderPanel.TabIndex = 106
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
        Me.lblTitle.Size = New System.Drawing.Size(218, 18)
        Me.lblTitle.TabIndex = 28
        Me.lblTitle.Text = "     Communicate Dispenser"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(304, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmDcommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(325, 315)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDcommand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdRestartDev As System.Windows.Forms.Button
    Friend WithEvents txtDispenser As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdResetCam As System.Windows.Forms.Button
    Friend WithEvents cmdDevStatus As System.Windows.Forms.Button
    Friend WithEvents cmdOpenBarrier As System.Windows.Forms.Button
    Friend WithEvents txtStat As System.Windows.Forms.RichTextBox
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
