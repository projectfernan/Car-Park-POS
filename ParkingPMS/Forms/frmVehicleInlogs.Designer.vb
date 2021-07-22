<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicleInlogs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicleInlogs))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cmdDel = New System.Windows.Forms.Button
        Me.CarImage = New System.Windows.Forms.PictureBox
        Me.lstList = New System.Windows.Forms.ListView
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdFind = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpOut = New System.Windows.Forms.DateTimePicker
        Me.dtptmeOut = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpIn = New System.Windows.Forms.DateTimePicker
        Me.dtptmeIn = New System.Windows.Forms.DateTimePicker
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtcnt = New System.Windows.Forms.ToolStripStatusLabel
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.CarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.CarImage)
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(7, 46)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 421)
        Me.Panel1.TabIndex = 8
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.ForeColor = System.Drawing.Color.White
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDel.Location = New System.Drawing.Point(148, 377)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(96, 34)
        Me.cmdDel.TabIndex = 31
        Me.cmdDel.Text = "&Delete"
        Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDel.UseVisualStyleBackColor = False
        '
        'CarImage
        '
        Me.CarImage.BackColor = System.Drawing.Color.Black
        Me.CarImage.BackgroundImage = CType(resources.GetObject("CarImage.BackgroundImage"), System.Drawing.Image)
        Me.CarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CarImage.Image = CType(resources.GetObject("CarImage.Image"), System.Drawing.Image)
        Me.CarImage.Location = New System.Drawing.Point(5, 85)
        Me.CarImage.Name = "CarImage"
        Me.CarImage.Size = New System.Drawing.Size(380, 286)
        Me.CarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarImage.TabIndex = 30
        Me.CarImage.TabStop = False
        '
        'lstList
        '
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(392, 85)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(622, 326)
        Me.lstList.TabIndex = 10
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.Panel2.Size = New System.Drawing.Size(1009, 74)
        Me.Panel2.TabIndex = 9
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.ForeColor = System.Drawing.Color.White
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(923, 8)
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
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(642, 44)
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
        Me.dtpOut.Location = New System.Drawing.Point(679, 41)
        Me.dtpOut.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dtpOut.Name = "dtpOut"
        Me.dtpOut.Size = New System.Drawing.Size(124, 24)
        Me.dtpOut.TabIndex = 27
        '
        'dtptmeOut
        '
        Me.dtptmeOut.CustomFormat = "HH:mm:ss"
        Me.dtptmeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptmeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptmeOut.Location = New System.Drawing.Point(814, 41)
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
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(626, 11)
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
        Me.dtpIn.Location = New System.Drawing.Point(679, 8)
        Me.dtpIn.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dtpIn.Name = "dtpIn"
        Me.dtpIn.Size = New System.Drawing.Size(124, 24)
        Me.dtpIn.TabIndex = 24
        '
        'dtptmeIn
        '
        Me.dtptmeIn.CustomFormat = "HH:mm:ss"
        Me.dtptmeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtptmeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtptmeIn.Location = New System.Drawing.Point(814, 8)
        Me.dtptmeIn.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.dtptmeIn.Name = "dtptmeIn"
        Me.dtptmeIn.ShowUpDown = True
        Me.dtptmeIn.Size = New System.Drawing.Size(100, 24)
        Me.dtptmeIn.TabIndex = 23
        Me.dtptmeIn.Value = New Date(2012, 10, 24, 0, 0, 0, 0)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtcnt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 475)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1036, 37)
        Me.StatusStrip1.TabIndex = 5
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Image = CType(resources.GetObject("ToolStripStatusLabel1.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(149, 32)
        Me.ToolStripStatusLabel1.Text = "Record Count :"
        '
        'txtcnt
        '
        Me.txtcnt.BackColor = System.Drawing.Color.Transparent
        Me.txtcnt.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcnt.ForeColor = System.Drawing.Color.Cyan
        Me.txtcnt.Name = "txtcnt"
        Me.txtcnt.Size = New System.Drawing.Size(23, 32)
        Me.txtcnt.Text = "0"
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
        Me.HeaderPanel.Size = New System.Drawing.Size(1036, 38)
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
        Me.Label8.Size = New System.Drawing.Size(147, 18)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "     Vehicle In Logs"
        '
        'btnClose
        '
        Me.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1014, 7)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'frmVehicleInlogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1036, 512)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVehicleInlogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.CarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptmeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptmeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtcnt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents CarImage As System.Windows.Forms.PictureBox
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
End Class
