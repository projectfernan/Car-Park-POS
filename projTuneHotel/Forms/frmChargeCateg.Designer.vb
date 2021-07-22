<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChargeCateg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChargeCateg))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.cmdHourly = New System.Windows.Forms.ToolStripButton
        Me.cmdOvernigth = New System.Windows.Forms.ToolStripButton
        Me.cmdDiscount = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdInhouseRate = New System.Windows.Forms.ToolStripButton
        Me.cmdFlat = New System.Windows.Forms.ToolStripButton
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(6, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 290)
        Me.Panel1.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHourly, Me.cmdOvernigth, Me.cmdDiscount, Me.cmdFlat, Me.cmdInhouseRate})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(256, 303)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'cmdHourly
        '
        Me.cmdHourly.BackColor = System.Drawing.Color.Maroon
        Me.cmdHourly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHourly.ForeColor = System.Drawing.Color.White
        Me.cmdHourly.Image = CType(resources.GetObject("cmdHourly.Image"), System.Drawing.Image)
        Me.cmdHourly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHourly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdHourly.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHourly.Name = "cmdHourly"
        Me.cmdHourly.Size = New System.Drawing.Size(254, 52)
        Me.cmdHourly.Text = "(F1) Charging Rate"
        '
        'cmdOvernigth
        '
        Me.cmdOvernigth.BackColor = System.Drawing.Color.Maroon
        Me.cmdOvernigth.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOvernigth.ForeColor = System.Drawing.Color.White
        Me.cmdOvernigth.Image = CType(resources.GetObject("cmdOvernigth.Image"), System.Drawing.Image)
        Me.cmdOvernigth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOvernigth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdOvernigth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOvernigth.Name = "cmdOvernigth"
        Me.cmdOvernigth.Size = New System.Drawing.Size(254, 52)
        Me.cmdOvernigth.Text = "(F2) Overnight Rate"
        '
        'cmdDiscount
        '
        Me.cmdDiscount.BackColor = System.Drawing.Color.Maroon
        Me.cmdDiscount.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.ForeColor = System.Drawing.Color.White
        Me.cmdDiscount.Image = CType(resources.GetObject("cmdDiscount.Image"), System.Drawing.Image)
        Me.cmdDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDiscount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDiscount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(254, 52)
        Me.cmdDiscount.Text = "(F3) Vat Settings"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(249, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Charging Rules"
        '
        'cmdInhouseRate
        '
        Me.cmdInhouseRate.BackColor = System.Drawing.Color.Maroon
        Me.cmdInhouseRate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInhouseRate.ForeColor = System.Drawing.Color.White
        Me.cmdInhouseRate.Image = CType(resources.GetObject("cmdInhouseRate.Image"), System.Drawing.Image)
        Me.cmdInhouseRate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdInhouseRate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdInhouseRate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdInhouseRate.Name = "cmdInhouseRate"
        Me.cmdInhouseRate.Size = New System.Drawing.Size(254, 52)
        Me.cmdInhouseRate.Text = "(F6) In-House Rate"
        Me.cmdInhouseRate.ToolTipText = "(F5) Flat Rate"
        '
        'cmdFlat
        '
        Me.cmdFlat.BackColor = System.Drawing.Color.Maroon
        Me.cmdFlat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFlat.ForeColor = System.Drawing.Color.White
        Me.cmdFlat.Image = CType(resources.GetObject("cmdFlat.Image"), System.Drawing.Image)
        Me.cmdFlat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdFlat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdFlat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdFlat.Name = "cmdFlat"
        Me.cmdFlat.Size = New System.Drawing.Size(254, 52)
        Me.cmdFlat.Text = "(F5) Monthly Rate"
        Me.cmdFlat.ToolTipText = "(F5) Flat Rate"
        '
        'frmChargeCateg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(268, 321)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmChargeCateg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdHourly As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOvernigth As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdDiscount As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdFlat As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdInhouseRate As System.Windows.Forms.ToolStripButton
End Class
