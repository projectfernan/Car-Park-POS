<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParkerHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmParkerHistory))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CarImage2 = New System.Windows.Forms.PictureBox()
        Me.CarImage = New System.Windows.Forms.PictureBox()
        Me.lstList = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCateg = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdDel = New System.Windows.Forms.Button()
        Me.txtPlate = New System.Windows.Forms.TextBox()
        Me.cmdFind = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpOut = New System.Windows.Forms.DateTimePicker()
        Me.dtptmeOut = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpIn = New System.Windows.Forms.DateTimePicker()
        Me.dtptmeIn = New System.Windows.Forms.DateTimePicker()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtcnt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Progbar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.CarImage2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CarImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CarImage2)
        Me.Panel1.Controls.Add(Me.CarImage)
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.StatusStrip1)
        Me.Panel1.Location = New System.Drawing.Point(6, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1023, 608)
        Me.Panel1.TabIndex = 9
        '
        'CarImage2
        '
        Me.CarImage2.BackColor = System.Drawing.Color.Black
        Me.CarImage2.BackgroundImage = CType(resources.GetObject("CarImage2.BackgroundImage"), System.Drawing.Image)
        Me.CarImage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CarImage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CarImage2.Image = CType(resources.GetObject("CarImage2.Image"), System.Drawing.Image)
        Me.CarImage2.Location = New System.Drawing.Point(5, 327)
        Me.CarImage2.Name = "CarImage2"
        Me.CarImage2.Size = New System.Drawing.Size(305, 235)
        Me.CarImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarImage2.TabIndex = 31
        Me.CarImage2.TabStop = False
        '
        'CarImage
        '
        Me.CarImage.BackColor = System.Drawing.Color.Black
        Me.CarImage.BackgroundImage = CType(resources.GetObject("CarImage.BackgroundImage"), System.Drawing.Image)
        Me.CarImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CarImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CarImage.Image = CType(resources.GetObject("CarImage.Image"), System.Drawing.Image)
        Me.CarImage.Location = New System.Drawing.Point(5, 86)
        Me.CarImage.Name = "CarImage"
        Me.CarImage.Size = New System.Drawing.Size(305, 235)
        Me.CarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CarImage.TabIndex = 30
        Me.CarImage.TabStop = False
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
        Me.lstList.Location = New System.Drawing.Point(316, 87)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(698, 475)
        Me.lstList.TabIndex = 10
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cboCateg)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmdDel)
        Me.Panel2.Controls.Add(Me.txtPlate)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(282, 43)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Keyword :"
        '
        'cboCateg
        '
        Me.cboCateg.BackColor = System.Drawing.Color.White
        Me.cboCateg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCateg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCateg.FormattingEnabled = True
        Me.cboCateg.Items.AddRange(New Object() {"CardCode", "Plate", "ExitLane"})
        Me.cboCateg.Location = New System.Drawing.Point(366, 7)
        Me.cboCateg.Name = "cboCateg"
        Me.cboCateg.Size = New System.Drawing.Size(162, 24)
        Me.cboCateg.TabIndex = 45
        Me.cboCateg.Text = "CardCode"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(278, 10)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 16)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Category :"
        '
        'cmdDel
        '
        Me.cmdDel.BackColor = System.Drawing.Color.White
        Me.cmdDel.Enabled = False
        Me.cmdDel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDel.Image = CType(resources.GetObject("cmdDel.Image"), System.Drawing.Image)
        Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdDel.Location = New System.Drawing.Point(923, 7)
        Me.cmdDel.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Size = New System.Drawing.Size(78, 58)
        Me.cmdDel.TabIndex = 43
        Me.cmdDel.Text = "&Delete"
        Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDel.UseVisualStyleBackColor = False
        '
        'txtPlate
        '
        Me.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(366, 38)
        Me.txtPlate.MaxLength = 7
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(162, 26)
        Me.txtPlate.TabIndex = 40
        '
        'cmdFind
        '
        Me.cmdFind.BackColor = System.Drawing.Color.White
        Me.cmdFind.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFind.Image = CType(resources.GetObject("cmdFind.Image"), System.Drawing.Image)
        Me.cmdFind.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdFind.Location = New System.Drawing.Point(833, 7)
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
        Me.Label1.Location = New System.Drawing.Point(552, 43)
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
        Me.dtpOut.Location = New System.Drawing.Point(589, 40)
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
        Me.dtptmeOut.Location = New System.Drawing.Point(724, 40)
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
        Me.Label6.Location = New System.Drawing.Point(536, 10)
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
        Me.dtpIn.Location = New System.Drawing.Point(589, 7)
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
        Me.dtptmeIn.Location = New System.Drawing.Point(724, 7)
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
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.txtcnt, Me.ToolStripStatusLabel2, Me.Progbar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 569)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1021, 37)
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
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(17, 32)
        Me.ToolStripStatusLabel2.Text = "|"
        '
        'Progbar
        '
        Me.Progbar.BackColor = System.Drawing.Color.White
        Me.Progbar.ForeColor = System.Drawing.Color.Lime
        Me.Progbar.Name = "Progbar"
        Me.Progbar.Size = New System.Drawing.Size(100, 31)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.Location = New System.Drawing.Point(1016, 1)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "  "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 1)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 18)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Parker's History"
        '
        'frmParkerHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1034, 638)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmParkerHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.CarImage2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CarImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CarImage2 As System.Windows.Forms.PictureBox
    Friend WithEvents CarImage As System.Windows.Forms.PictureBox
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtPlate As System.Windows.Forms.TextBox
    Friend WithEvents cmdFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptmeOut As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtptmeIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtcnt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdDel As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboCateg As System.Windows.Forms.ComboBox
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Progbar As System.Windows.Forms.ToolStripProgressBar
End Class
