<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFindLostCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFindLostCard))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lstList = New System.Windows.Forms.ListView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdVerified = New System.Windows.Forms.Button
        Me.cmdFind = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpOut = New System.Windows.Forms.DateTimePicker
        Me.dtptmeOut = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpIn = New System.Windows.Forms.DateTimePicker
        Me.dtptmeIn = New System.Windows.Forms.DateTimePicker
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtcnt = New System.Windows.Forms.ToolStripStatusLabel
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboCateg = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPlate = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Location = New System.Drawing.Point(5, 21)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(502, 371)
        Me.Panel1.TabIndex = 7
        '
        'lstList
        '
        Me.lstList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(6, 128)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(487, 196)
        Me.lstList.TabIndex = 10
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtPlate)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cboCateg)
        Me.Panel2.Controls.Add(Me.cmdVerified)
        Me.Panel2.Controls.Add(Me.cmdFind)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dtpOut)
        Me.Panel2.Controls.Add(Me.dtptmeOut)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.dtpIn)
        Me.Panel2.Controls.Add(Me.dtptmeIn)
        Me.Panel2.Location = New System.Drawing.Point(5, 6)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(488, 119)
        Me.Panel2.TabIndex = 9
        '
        'cmdVerified
        '
        Me.cmdVerified.BackColor = System.Drawing.Color.White
        Me.cmdVerified.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVerified.Image = CType(resources.GetObject("cmdVerified.Image"), System.Drawing.Image)
        Me.cmdVerified.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdVerified.Location = New System.Drawing.Point(398, 48)
        Me.cmdVerified.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.cmdVerified.Name = "cmdVerified"
        Me.cmdVerified.Size = New System.Drawing.Size(78, 58)
        Me.cmdVerified.TabIndex = 30
        Me.cmdVerified.Text = "&Verified"
        Me.cmdVerified.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdVerified.UseVisualStyleBackColor = False
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.White
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(308, 48)
        Me.cmdFind.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.cmdFind.Name = "cmdFind"
        Me.cmdFind.Size = New System.Drawing.Size(78, 58)
        Me.cmdFind.TabIndex = 29
        Me.cmdFind.Text = "&Search"
        Me.cmdFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdFind.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 84)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "To :"
        '
        'dtpOut
        '
        Me.dtpOut.CustomFormat = "yyyy-MM-dd"
        Me.dtpOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpOut.Location = New System.Drawing.Point(64, 81)
        Me.dtpOut.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dtpOut.Name = "dtpOut"
        Me.dtpOut.Size = New System.Drawing.Size(124, 24)
        Me.dtpOut.TabIndex = 27
        '
        'dtptmeOut
        '
        Me.dtptmeOut.CustomFormat = "HH:mm"
        Me.dtptmeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptmeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptmeOut.Location = New System.Drawing.Point(199, 81)
        Me.dtptmeOut.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dtptmeOut.Name = "dtptmeOut"
        Me.dtptmeOut.ShowUpDown = True
        Me.dtptmeOut.Size = New System.Drawing.Size(100, 24)
        Me.dtptmeOut.TabIndex = 26
        Me.dtptmeOut.Value = New Date(2012, 7, 14, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(11, 51)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "From :"
        '
        'dtpIn
        '
        Me.dtpIn.CustomFormat = "yyyy-MM-dd"
        Me.dtpIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpIn.Location = New System.Drawing.Point(64, 48)
        Me.dtpIn.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dtpIn.Name = "dtpIn"
        Me.dtpIn.Size = New System.Drawing.Size(124, 24)
        Me.dtpIn.TabIndex = 24
        '
        'dtptmeIn
        '
        Me.dtptmeIn.CustomFormat = "HH:mm"
        Me.dtptmeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptmeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptmeIn.Location = New System.Drawing.Point(199, 48)
        Me.dtptmeIn.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dtptmeIn.Name = "dtptmeIn"
        Me.dtptmeIn.ShowUpDown = True
        Me.dtptmeIn.Size = New System.Drawing.Size(100, 24)
        Me.dtptmeIn.TabIndex = 23
        Me.dtptmeIn.Value = New Date(2012, 10, 24, 0, 0, 0, 0)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.txtcnt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 332)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(500, 37)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel3.Text = " "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(149, 32)
        Me.ToolStripStatusLabel1.Text = "Record Count :"
        '
        'txtcnt
        '
        Me.txtcnt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtcnt.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcnt.ForeColor = System.Drawing.Color.Blue
        Me.txtcnt.Name = "txtcnt"
        Me.txtcnt.Size = New System.Drawing.Size(23, 32)
        Me.txtcnt.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Find Lost Card"
        '
        'cboCateg
        '
        Me.cboCateg.BackColor = System.Drawing.Color.White
        Me.cboCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCateg.FormattingEnabled = True
        Me.cboCateg.Items.AddRange(New Object() {"By Date", "By Plate"})
        Me.cboCateg.Location = New System.Drawing.Point(89, 12)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(124, 24)
        Me.cboCateg.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 15)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Category :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(221, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Plate :"
        '
        'txtPlate
        '
        Me.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(274, 14)
        Me.txtPlate.MaxLength = 40
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(202, 22)
        Me.txtPlate.TabIndex = 34
        '
        'frmFindLostCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(512, 398)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Name = "frmFindLostCard"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtcnt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptmeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptmeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents cmdVerified As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboCateg As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPlate As System.Windows.Forms.TextBox
End Class
