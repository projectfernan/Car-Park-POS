<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCashOut
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCashOut))
        Me.txtTotalCash = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lstList = New System.Windows.Forms.ListView
        Me.cmdCompute = New System.Windows.Forms.Button
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTotalCash
        '
        Me.txtTotalCash.AutoSize = True
        Me.txtTotalCash.BackColor = System.Drawing.Color.Transparent
        Me.txtTotalCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCash.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalCash.Location = New System.Drawing.Point(255, 299)
        Me.txtTotalCash.Name = "txtTotalCash"
        Me.txtTotalCash.Size = New System.Drawing.Size(36, 16)
        Me.txtTotalCash.TabIndex = 33
        Me.txtTotalCash.Text = "0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(134, 299)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Total Cash Out :"
        '
        'lstList
        '
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(11, 47)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(382, 234)
        Me.lstList.TabIndex = 31
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'cmdCompute
        '
        Me.cmdCompute.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCompute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCompute.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompute.ForeColor = System.Drawing.Color.Black
        Me.cmdCompute.Image = CType(resources.GetObject("cmdCompute.Image"), System.Drawing.Image)
        Me.cmdCompute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompute.Location = New System.Drawing.Point(272, 337)
        Me.cmdCompute.Name = "cmdCompute"
        Me.cmdCompute.Size = New System.Drawing.Size(111, 37)
        Me.cmdCompute.TabIndex = 30
        Me.cmdCompute.Text = "&Cash Out"
        Me.cmdCompute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCompute.UseVisualStyleBackColor = False
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(0, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(474, 38)
        Me.HeaderPanel.TabIndex = 75
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
        Me.Label8.Size = New System.Drawing.Size(153, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Cut Off Settings"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(383, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmCashOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(403, 399)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.txtTotalCash)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstList)
        Me.Controls.Add(Me.cmdCompute)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCashOut"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCompute As System.Windows.Forms.Button
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents txtTotalCash As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
