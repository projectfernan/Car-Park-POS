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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdRestartDev = New System.Windows.Forms.Button()
        Me.txtzoneIP = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDispenser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdOpenBarrier = New System.Windows.Forms.Button()
        Me.cmdDevStatus = New System.Windows.Forms.Button()
        Me.cmdResetCam = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.cmdResetCam)
        Me.Panel1.Controls.Add(Me.cmdDevStatus)
        Me.Panel1.Controls.Add(Me.cmdOpenBarrier)
        Me.Panel1.Controls.Add(Me.cmdRestartDev)
        Me.Panel1.Controls.Add(Me.txtzoneIP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtDispenser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(6, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(311, 192)
        Me.Panel1.TabIndex = 1
        '
        'cmdRestartDev
        '
        Me.cmdRestartDev.BackColor = System.Drawing.Color.White
        Me.cmdRestartDev.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRestartDev.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRestartDev.ForeColor = System.Drawing.Color.Black
        Me.cmdRestartDev.Image = CType(resources.GetObject("cmdRestartDev.Image"), System.Drawing.Image)
        Me.cmdRestartDev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRestartDev.Location = New System.Drawing.Point(9, 97)
        Me.cmdRestartDev.Name = "cmdRestartDev"
        Me.cmdRestartDev.Size = New System.Drawing.Size(143, 34)
        Me.cmdRestartDev.TabIndex = 26
        Me.cmdRestartDev.Text = "      &Restart Device"
        Me.cmdRestartDev.UseVisualStyleBackColor = False
        '
        'txtzoneIP
        '
        Me.txtzoneIP.AutoSize = True
        Me.txtzoneIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtzoneIP.ForeColor = System.Drawing.Color.Lime
        Me.txtzoneIP.Location = New System.Drawing.Point(139, 64)
        Me.txtzoneIP.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txtzoneIP.Name = "txtzoneIP"
        Me.txtzoneIP.Size = New System.Drawing.Size(77, 18)
        Me.txtzoneIP.TabIndex = 22
        Me.txtzoneIP.Text = "127.0.0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(62, 64)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Zone IP :"
        '
        'txtDispenser
        '
        Me.txtDispenser.AutoSize = True
        Me.txtDispenser.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDispenser.ForeColor = System.Drawing.Color.White
        Me.txtDispenser.Location = New System.Drawing.Point(62, 26)
        Me.txtDispenser.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.txtDispenser.Name = "txtDispenser"
        Me.txtDispenser.Size = New System.Drawing.Size(104, 18)
        Me.txtDispenser.TabIndex = 20
        Me.txtDispenser.Text = "Entry Zone 1"
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
        Me.Label3.Location = New System.Drawing.Point(305, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Send Command to Dispenser"
        '
        'cmdOpenBarrier
        '
        Me.cmdOpenBarrier.BackColor = System.Drawing.Color.White
        Me.cmdOpenBarrier.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdOpenBarrier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOpenBarrier.ForeColor = System.Drawing.Color.Black
        Me.cmdOpenBarrier.Image = CType(resources.GetObject("cmdOpenBarrier.Image"), System.Drawing.Image)
        Me.cmdOpenBarrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOpenBarrier.Location = New System.Drawing.Point(9, 146)
        Me.cmdOpenBarrier.Name = "cmdOpenBarrier"
        Me.cmdOpenBarrier.Size = New System.Drawing.Size(143, 34)
        Me.cmdOpenBarrier.TabIndex = 27
        Me.cmdOpenBarrier.Text = "      &Open Barrier"
        Me.cmdOpenBarrier.UseVisualStyleBackColor = False
        '
        'cmdDevStatus
        '
        Me.cmdDevStatus.BackColor = System.Drawing.Color.White
        Me.cmdDevStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdDevStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDevStatus.ForeColor = System.Drawing.Color.Black
        Me.cmdDevStatus.Image = CType(resources.GetObject("cmdDevStatus.Image"), System.Drawing.Image)
        Me.cmdDevStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDevStatus.Location = New System.Drawing.Point(158, 97)
        Me.cmdDevStatus.Name = "cmdDevStatus"
        Me.cmdDevStatus.Size = New System.Drawing.Size(143, 34)
        Me.cmdDevStatus.TabIndex = 28
        Me.cmdDevStatus.Text = "      &Device Status"
        Me.cmdDevStatus.UseVisualStyleBackColor = False
        '
        'cmdResetCam
        '
        Me.cmdResetCam.BackColor = System.Drawing.Color.White
        Me.cmdResetCam.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdResetCam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdResetCam.ForeColor = System.Drawing.Color.Black
        Me.cmdResetCam.Image = CType(resources.GetObject("cmdResetCam.Image"), System.Drawing.Image)
        Me.cmdResetCam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdResetCam.Location = New System.Drawing.Point(158, 146)
        Me.cmdResetCam.Name = "cmdResetCam"
        Me.cmdResetCam.Size = New System.Drawing.Size(143, 34)
        Me.cmdResetCam.TabIndex = 29
        Me.cmdResetCam.Text = "      &Reset Cam"
        Me.cmdResetCam.UseVisualStyleBackColor = False
        '
        'frmDcommand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(323, 223)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDcommand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdRestartDev As System.Windows.Forms.Button
    Friend WithEvents txtzoneIP As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDispenser As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdResetCam As System.Windows.Forms.Button
    Friend WithEvents cmdDevStatus As System.Windows.Forms.Button
    Friend WithEvents cmdOpenBarrier As System.Windows.Forms.Button
End Class
