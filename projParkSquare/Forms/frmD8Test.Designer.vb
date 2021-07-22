<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmD8Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmD8Test))
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDetect = New System.Windows.Forms.Button
        Me.cmdBeep = New System.Windows.Forms.Button
        Me.cmdInit = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(199, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "D8U Testing" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.cmdDetect)
        Me.Panel1.Controls.Add(Me.cmdBeep)
        Me.Panel1.Controls.Add(Me.cmdInit)
        Me.Panel1.Location = New System.Drawing.Point(6, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 159)
        Me.Panel1.TabIndex = 10
        '
        'cmdDetect
        '
        Me.cmdDetect.BackColor = System.Drawing.Color.White
        Me.cmdDetect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDetect.Image = CType(resources.GetObject("cmdDetect.Image"), System.Drawing.Image)
        Me.cmdDetect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDetect.Location = New System.Drawing.Point(38, 111)
        Me.cmdDetect.Name = "cmdDetect"
        Me.cmdDetect.Size = New System.Drawing.Size(125, 34)
        Me.cmdDetect.TabIndex = 22
        Me.cmdDetect.Text = "      Detect Card"
        Me.cmdDetect.UseVisualStyleBackColor = False
        '
        'cmdBeep
        '
        Me.cmdBeep.BackColor = System.Drawing.Color.White
        Me.cmdBeep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBeep.Image = CType(resources.GetObject("cmdBeep.Image"), System.Drawing.Image)
        Me.cmdBeep.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBeep.Location = New System.Drawing.Point(38, 62)
        Me.cmdBeep.Name = "cmdBeep"
        Me.cmdBeep.Size = New System.Drawing.Size(125, 34)
        Me.cmdBeep.TabIndex = 21
        Me.cmdBeep.Text = "       Test Beep"
        Me.cmdBeep.UseVisualStyleBackColor = False
        '
        'cmdInit
        '
        Me.cmdInit.BackColor = System.Drawing.Color.White
        Me.cmdInit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInit.Image = CType(resources.GetObject("cmdInit.Image"), System.Drawing.Image)
        Me.cmdInit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInit.Location = New System.Drawing.Point(38, 14)
        Me.cmdInit.Name = "cmdInit"
        Me.cmdInit.Size = New System.Drawing.Size(125, 34)
        Me.cmdInit.TabIndex = 20
        Me.cmdInit.Text = "      Initialize"
        Me.cmdInit.UseVisualStyleBackColor = False
        '
        'frmD8Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(218, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmD8Test"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdInit As System.Windows.Forms.Button
    Friend WithEvents cmdBeep As System.Windows.Forms.Button
    Friend WithEvents cmdDetect As System.Windows.Forms.Button
End Class
