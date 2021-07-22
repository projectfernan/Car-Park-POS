<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenCateg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenCateg))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip
        Me.cmdGenServer = New System.Windows.Forms.ToolStripButton
        Me.cmdGenLocal = New System.Windows.Forms.ToolStripButton
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.ToolStrip2)
        Me.Panel1.ForeColor = System.Drawing.Color.Navy
        Me.Panel1.Location = New System.Drawing.Point(5, 22)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(308, 123)
        Me.Panel1.TabIndex = 2
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdGenServer, Me.cmdGenLocal})
        Me.ToolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(308, 119)
        Me.ToolStrip2.TabIndex = 1
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'cmdGenServer
        '
        Me.cmdGenServer.BackColor = System.Drawing.Color.Navy
        Me.cmdGenServer.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenServer.ForeColor = System.Drawing.Color.White
        Me.cmdGenServer.Image = CType(resources.GetObject("cmdGenServer.Image"), System.Drawing.Image)
        Me.cmdGenServer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGenServer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdGenServer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGenServer.Name = "cmdGenServer"
        Me.cmdGenServer.Size = New System.Drawing.Size(306, 52)
        Me.cmdGenServer.Text = "(F1) Generate from Server"
        '
        'cmdGenLocal
        '
        Me.cmdGenLocal.BackColor = System.Drawing.Color.Navy
        Me.cmdGenLocal.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenLocal.ForeColor = System.Drawing.Color.White
        Me.cmdGenLocal.Image = CType(resources.GetObject("cmdGenLocal.Image"), System.Drawing.Image)
        Me.cmdGenLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGenLocal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdGenLocal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdGenLocal.Name = "cmdGenLocal"
        Me.cmdGenLocal.Size = New System.Drawing.Size(306, 52)
        Me.cmdGenLocal.Text = "(F2) Generate from Localhost"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 18)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Generate Report"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(301, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "  "
        '
        'frmGenCateg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(320, 152)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frmGenCateg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGenCateg"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdGenServer As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdGenLocal As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
