<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateSettigns
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateSettigns))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lstLoad = New System.Windows.Forms.ListBox()
        Me.Progbar = New System.Windows.Forms.ProgressBar()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.cmdFinish = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.chkVat = New System.Windows.Forms.CheckBox()
        Me.chkVehicle = New System.Windows.Forms.CheckBox()
        Me.chkOverNigth = New System.Windows.Forms.CheckBox()
        Me.chkCharging = New System.Windows.Forms.CheckBox()
        Me.chkSystemAcc = New System.Windows.Forms.CheckBox()
        Me.chkAccDesig = New System.Windows.Forms.CheckBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.lstLoad)
        Me.Panel2.Controls.Add(Me.Progbar)
        Me.Panel2.Controls.Add(Me.cmdLoad)
        Me.Panel2.Controls.Add(Me.cmdFinish)
        Me.Panel2.Location = New System.Drawing.Point(7, 227)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 286)
        Me.Panel2.TabIndex = 20
        '
        'lstLoad
        '
        Me.lstLoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstLoad.FormattingEnabled = True
        Me.lstLoad.ItemHeight = 16
        Me.lstLoad.Location = New System.Drawing.Point(7, 40)
        Me.lstLoad.Name = "lstLoad"
        Me.lstLoad.Size = New System.Drawing.Size(480, 194)
        Me.lstLoad.TabIndex = 19
        '
        'Progbar
        '
        Me.Progbar.BackColor = System.Drawing.Color.White
        Me.Progbar.ForeColor = System.Drawing.Color.Lime
        Me.Progbar.Location = New System.Drawing.Point(7, 8)
        Me.Progbar.Name = "Progbar"
        Me.Progbar.Size = New System.Drawing.Size(479, 25)
        Me.Progbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.Progbar.TabIndex = 17
        Me.Progbar.UseWaitCursor = True
        '
        'cmdLoad
        '
        Me.cmdLoad.BackColor = System.Drawing.Color.White
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.ForeColor = System.Drawing.Color.Black
        Me.cmdLoad.Image = CType(resources.GetObject("cmdLoad.Image"), System.Drawing.Image)
        Me.cmdLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLoad.Location = New System.Drawing.Point(374, 243)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(112, 34)
        Me.cmdLoad.TabIndex = 7
        Me.cmdLoad.Text = "      &Upload"
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'cmdFinish
        '
        Me.cmdFinish.BackColor = System.Drawing.Color.White
        Me.cmdFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinish.ForeColor = System.Drawing.Color.Black
        Me.cmdFinish.Image = CType(resources.GetObject("cmdFinish.Image"), System.Drawing.Image)
        Me.cmdFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFinish.Location = New System.Drawing.Point(374, 243)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(112, 34)
        Me.cmdFinish.TabIndex = 20
        Me.cmdFinish.Text = "      &Finish"
        Me.cmdFinish.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(487, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Update System Settings"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.chkAccDesig)
        Me.Panel1.Controls.Add(Me.chkDiscount)
        Me.Panel1.Controls.Add(Me.chkVat)
        Me.Panel1.Controls.Add(Me.chkVehicle)
        Me.Panel1.Controls.Add(Me.chkOverNigth)
        Me.Panel1.Controls.Add(Me.chkCharging)
        Me.Panel1.Controls.Add(Me.chkSystemAcc)
        Me.Panel1.Location = New System.Drawing.Point(7, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 192)
        Me.Panel1.TabIndex = 17
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDiscount.ForeColor = System.Drawing.Color.White
        Me.chkDiscount.Location = New System.Drawing.Point(299, 102)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(147, 20)
        Me.chkDiscount.TabIndex = 6
        Me.chkDiscount.Text = "Discount Settings"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'chkVat
        '
        Me.chkVat.AutoSize = True
        Me.chkVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVat.ForeColor = System.Drawing.Color.White
        Me.chkVat.Location = New System.Drawing.Point(32, 141)
        Me.chkVat.Name = "chkVat"
        Me.chkVat.Size = New System.Drawing.Size(110, 20)
        Me.chkVat.TabIndex = 3
        Me.chkVat.Text = "Vat Settings"
        Me.chkVat.UseVisualStyleBackColor = True
        '
        'chkVehicle
        '
        Me.chkVehicle.AutoSize = True
        Me.chkVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVehicle.ForeColor = System.Drawing.Color.White
        Me.chkVehicle.Location = New System.Drawing.Point(32, 102)
        Me.chkVehicle.Name = "chkVehicle"
        Me.chkVehicle.Size = New System.Drawing.Size(146, 20)
        Me.chkVehicle.TabIndex = 2
        Me.chkVehicle.Text = "Vehicle Category"
        Me.chkVehicle.UseVisualStyleBackColor = True
        '
        'chkOverNigth
        '
        Me.chkOverNigth.AutoSize = True
        Me.chkOverNigth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkOverNigth.ForeColor = System.Drawing.Color.White
        Me.chkOverNigth.Location = New System.Drawing.Point(299, 63)
        Me.chkOverNigth.Name = "chkOverNigth"
        Me.chkOverNigth.Size = New System.Drawing.Size(155, 20)
        Me.chkOverNigth.TabIndex = 5
        Me.chkOverNigth.Text = "Overnigth Charges"
        Me.chkOverNigth.UseVisualStyleBackColor = True
        '
        'chkCharging
        '
        Me.chkCharging.AutoSize = True
        Me.chkCharging.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkCharging.ForeColor = System.Drawing.Color.White
        Me.chkCharging.Location = New System.Drawing.Point(299, 22)
        Me.chkCharging.Name = "chkCharging"
        Me.chkCharging.Size = New System.Drawing.Size(133, 20)
        Me.chkCharging.TabIndex = 4
        Me.chkCharging.Text = "Charging Rules"
        Me.chkCharging.UseVisualStyleBackColor = True
        '
        'chkSystemAcc
        '
        Me.chkSystemAcc.AutoSize = True
        Me.chkSystemAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSystemAcc.ForeColor = System.Drawing.Color.White
        Me.chkSystemAcc.Location = New System.Drawing.Point(33, 63)
        Me.chkSystemAcc.Name = "chkSystemAcc"
        Me.chkSystemAcc.Size = New System.Drawing.Size(145, 20)
        Me.chkSystemAcc.TabIndex = 1
        Me.chkSystemAcc.Text = "System Accounts"
        Me.chkSystemAcc.UseVisualStyleBackColor = True
        '
        'chkAccDesig
        '
        Me.chkAccDesig.AutoSize = True
        Me.chkAccDesig.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAccDesig.ForeColor = System.Drawing.Color.White
        Me.chkAccDesig.Location = New System.Drawing.Point(32, 22)
        Me.chkAccDesig.Name = "chkAccDesig"
        Me.chkAccDesig.Size = New System.Drawing.Size(177, 20)
        Me.chkAccDesig.TabIndex = 0
        Me.chkAccDesig.Text = "Accounts Designation"
        Me.chkAccDesig.UseVisualStyleBackColor = True
        '
        'frmUpdateSettigns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(507, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateSettigns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lstLoad As System.Windows.Forms.ListBox
    Friend WithEvents Progbar As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdFinish As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkOverNigth As System.Windows.Forms.CheckBox
    Friend WithEvents chkCharging As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystemAcc As System.Windows.Forms.CheckBox
    Friend WithEvents chkVehicle As System.Windows.Forms.CheckBox
    Friend WithEvents chkVat As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccDesig As System.Windows.Forms.CheckBox
End Class
