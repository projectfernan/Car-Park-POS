<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStayIn
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStayIn))
        Me.lstList = New System.Windows.Forms.ListView
        Me.cmdCashOut = New System.Windows.Forms.Button
        Me.bckPrint = New System.ComponentModel.BackgroundWorker
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstList
        '
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(6, 42)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(374, 431)
        Me.lstList.TabIndex = 31
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'cmdCashOut
        '
        Me.cmdCashOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdCashOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCashOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCashOut.ForeColor = System.Drawing.Color.Black
        Me.cmdCashOut.Image = CType(resources.GetObject("cmdCashOut.Image"), System.Drawing.Image)
        Me.cmdCashOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCashOut.Location = New System.Drawing.Point(287, 479)
        Me.cmdCashOut.Name = "cmdCashOut"
        Me.cmdCashOut.Size = New System.Drawing.Size(93, 37)
        Me.cmdCashOut.TabIndex = 30
        Me.cmdCashOut.Text = "&Print"
        Me.cmdCashOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCashOut.UseVisualStyleBackColor = False
        '
        'bckPrint
        '
        Me.bckPrint.WorkerReportsProgress = True
        Me.bckPrint.WorkerSupportsCancellation = True
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label8)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(-1, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(388, 38)
        Me.HeaderPanel.TabIndex = 32
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
        Me.Label8.Size = New System.Drawing.Size(140, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Stay In Report"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(367, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmStayIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(385, 523)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.lstList)
        Me.Controls.Add(Me.cmdCashOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStayIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents cmdCashOut As System.Windows.Forms.Button
    Friend WithEvents bckPrint As System.ComponentModel.BackgroundWorker
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
