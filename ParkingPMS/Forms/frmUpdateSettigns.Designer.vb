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
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.lstLoad = New System.Windows.Forms.ListBox
        Me.Progbar = New System.Windows.Forms.ProgressBar
        Me.cmdLoad = New System.Windows.Forms.Button
        Me.cmdFinish = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.chkAccDesig = New System.Windows.Forms.CheckBox
        Me.chkDiscount = New System.Windows.Forms.CheckBox
        Me.chkVat = New System.Windows.Forms.CheckBox
        Me.chkOverNigth = New System.Windows.Forms.CheckBox
        Me.chkCharging = New System.Windows.Forms.CheckBox
        Me.chkSystemAcc = New System.Windows.Forms.CheckBox
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lstLoad)
        Me.Panel2.Controls.Add(Me.Progbar)
        Me.Panel2.Controls.Add(Me.cmdLoad)
        Me.Panel2.Controls.Add(Me.cmdFinish)
        Me.Panel2.Location = New System.Drawing.Point(7, 203)
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
        Me.cmdLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdLoad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLoad.ForeColor = System.Drawing.Color.White
        Me.cmdLoad.Image = CType(resources.GetObject("cmdLoad.Image"), System.Drawing.Image)
        Me.cmdLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLoad.Location = New System.Drawing.Point(374, 243)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(112, 34)
        Me.cmdLoad.TabIndex = 7
        Me.cmdLoad.Text = "&Upload"
        Me.cmdLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLoad.UseVisualStyleBackColor = False
        '
        'cmdFinish
        '
        Me.cmdFinish.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFinish.ForeColor = System.Drawing.Color.White
        Me.cmdFinish.Image = CType(resources.GetObject("cmdFinish.Image"), System.Drawing.Image)
        Me.cmdFinish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFinish.Location = New System.Drawing.Point(374, 243)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(112, 34)
        Me.cmdFinish.TabIndex = 20
        Me.cmdFinish.Text = "&Finish"
        Me.cmdFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFinish.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.chkAccDesig)
        Me.Panel1.Controls.Add(Me.chkDiscount)
        Me.Panel1.Controls.Add(Me.chkVat)
        Me.Panel1.Controls.Add(Me.chkOverNigth)
        Me.Panel1.Controls.Add(Me.chkCharging)
        Me.Panel1.Controls.Add(Me.chkSystemAcc)
        Me.Panel1.Location = New System.Drawing.Point(7, 46)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(493, 148)
        Me.Panel1.TabIndex = 17
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
        Me.chkVat.Location = New System.Drawing.Point(33, 102)
        Me.chkVat.Name = "chkVat"
        Me.chkVat.Size = New System.Drawing.Size(110, 20)
        Me.chkVat.TabIndex = 3
        Me.chkVat.Text = "Vat Settings"
        Me.chkVat.UseVisualStyleBackColor = True
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
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(507, 38)
        Me.HeaderPanel.TabIndex = 95
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(6, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(192, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Update POS Settings"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(485, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmUpdateSettigns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(507, 497)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.Panel2)
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
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lstLoad As System.Windows.Forms.ListBox
    Friend WithEvents Progbar As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents cmdFinish As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chkOverNigth As System.Windows.Forms.CheckBox
    Friend WithEvents chkCharging As System.Windows.Forms.CheckBox
    Friend WithEvents chkSystemAcc As System.Windows.Forms.CheckBox
    Friend WithEvents chkVat As System.Windows.Forms.CheckBox
    Friend WithEvents chkDiscount As System.Windows.Forms.CheckBox
    Friend WithEvents chkAccDesig As System.Windows.Forms.CheckBox
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
