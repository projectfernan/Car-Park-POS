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
        Me.btnVat = New System.Windows.Forms.ToolStripButton
        Me.btnDiscount = New System.Windows.Forms.ToolStripButton
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(8, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 223)
        Me.Panel1.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdHourly, Me.cmdOvernigth, Me.btnVat, Me.btnDiscount})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(303, 222)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'cmdHourly
        '
        Me.cmdHourly.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdHourly.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdHourly.ForeColor = System.Drawing.Color.Black
        Me.cmdHourly.Image = CType(resources.GetObject("cmdHourly.Image"), System.Drawing.Image)
        Me.cmdHourly.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHourly.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdHourly.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHourly.Name = "cmdHourly"
        Me.cmdHourly.Size = New System.Drawing.Size(301, 52)
        Me.cmdHourly.Text = "(F1) Charging Rate"
        '
        'cmdOvernigth
        '
        Me.cmdOvernigth.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdOvernigth.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOvernigth.ForeColor = System.Drawing.Color.Black
        Me.cmdOvernigth.Image = CType(resources.GetObject("cmdOvernigth.Image"), System.Drawing.Image)
        Me.cmdOvernigth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOvernigth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdOvernigth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOvernigth.Name = "cmdOvernigth"
        Me.cmdOvernigth.Size = New System.Drawing.Size(301, 52)
        Me.cmdOvernigth.Text = "(F2) Overnight Rate"
        '
        'btnVat
        '
        Me.btnVat.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnVat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVat.ForeColor = System.Drawing.Color.Black
        Me.btnVat.Image = CType(resources.GetObject("btnVat.Image"), System.Drawing.Image)
        Me.btnVat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnVat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVat.Name = "btnVat"
        Me.btnVat.Size = New System.Drawing.Size(301, 52)
        Me.btnVat.Text = "(F3) Vat Settings"
        '
        'btnDiscount
        '
        Me.btnDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnDiscount.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.ForeColor = System.Drawing.Color.Black
        Me.btnDiscount.Image = CType(resources.GetObject("btnDiscount.Image"), System.Drawing.Image)
        Me.btnDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDiscount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnDiscount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(301, 52)
        Me.btnDiscount.Text = "(F4) Discount"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label3)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(-1, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(397, 38)
        Me.HeaderPanel.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "     Charging Rules"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(301, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmChargeCateg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(320, 277)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
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
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdHourly As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOvernigth As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnVat As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnDiscount As System.Windows.Forms.ToolStripButton
End Class
