<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrLogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrLogs))
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.dgErrRec = New System.Windows.Forms.DataGridView
        Me.cboCateg = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtTo = New System.Windows.Forms.DateTimePicker
        Me.dtFrm = New System.Windows.Forms.DateTimePicker
        Me.txtKeyCode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboFindType = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.HeaderPanel.SuspendLayout()
        CType(Me.dgErrRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label3)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(661, 38)
        Me.HeaderPanel.TabIndex = 19
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
        Me.Label3.Size = New System.Drawing.Size(114, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "     Error Logs"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(640, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'dgErrRec
        '
        Me.dgErrRec.AllowUserToAddRows = False
        Me.dgErrRec.AllowUserToDeleteRows = False
        Me.dgErrRec.BackgroundColor = System.Drawing.Color.White
        Me.dgErrRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgErrRec.Location = New System.Drawing.Point(12, 152)
        Me.dgErrRec.Name = "dgErrRec"
        Me.dgErrRec.ReadOnly = True
        Me.dgErrRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgErrRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgErrRec.ShowEditingIcon = False
        Me.dgErrRec.Size = New System.Drawing.Size(637, 302)
        Me.dgErrRec.TabIndex = 20
        '
        'cboCateg
        '
        Me.cboCateg.BackColor = System.Drawing.Color.White
        Me.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCateg.FormattingEnabled = True
        Me.cboCateg.Items.AddRange(New Object() {"Thread", "Error"})
        Me.cboCateg.Location = New System.Drawing.Point(345, 63)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(153, 24)
        Me.cboCateg.TabIndex = 75
        Me.cboCateg.Text = "Thread"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(262, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Category :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(38, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 16)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "To :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(22, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 72
        Me.Label14.Text = "From :"
        '
        'dtTo
        '
        Me.dtTo.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTo.Location = New System.Drawing.Point(79, 102)
        Me.dtTo.Name = "dtTo"
        Me.dtTo.Size = New System.Drawing.Size(173, 24)
        Me.dtTo.TabIndex = 71
        '
        'dtFrm
        '
        Me.dtFrm.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrm.Location = New System.Drawing.Point(79, 63)
        Me.dtFrm.Name = "dtFrm"
        Me.dtFrm.Size = New System.Drawing.Size(173, 24)
        Me.dtFrm.TabIndex = 70
        '
        'txtKeyCode
        '
        Me.txtKeyCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtKeyCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeyCode.Location = New System.Drawing.Point(345, 104)
        Me.txtKeyCode.MaxLength = 30
        Me.txtKeyCode.Name = "txtKeyCode"
        Me.txtKeyCode.Size = New System.Drawing.Size(153, 22)
        Me.txtKeyCode.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(263, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 77
        Me.Label6.Text = "Keycode :"
        '
        'cboFindType
        '
        Me.cboFindType.BackColor = System.Drawing.Color.White
        Me.cboFindType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFindType.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFindType.FormattingEnabled = True
        Me.cboFindType.Items.AddRange(New Object() {"Category Only", "Date Range"})
        Me.cboFindType.Location = New System.Drawing.Point(513, 63)
        Me.cboFindType.Name = "cboFindType"
        Me.cboFindType.Size = New System.Drawing.Size(126, 24)
        Me.cboFindType.TabIndex = 79
        Me.cboFindType.Text = "Category Only"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(513, 97)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(126, 34)
        Me.btnSearch.TabIndex = 80
        Me.btnSearch.Text = "&Search"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'ErrLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(661, 468)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.cboFindType)
        Me.Controls.Add(Me.txtKeyCode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboCateg)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.dtTo)
        Me.Controls.Add(Me.dtFrm)
        Me.Controls.Add(Me.dgErrRec)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ErrLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.dgErrRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents dgErrRec As System.Windows.Forms.DataGridView
    Friend WithEvents cboCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtKeyCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboFindType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
End Class
