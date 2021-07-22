<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportDT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportDT))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtDateTo = New System.Windows.Forms.DateTimePicker
        Me.dtDateFrm = New System.Windows.Forms.DateTimePicker
        Me.dtTmeTo = New System.Windows.Forms.DateTimePicker
        Me.dtTmeFrm = New System.Windows.Forms.DateTimePicker
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.tmeToOp = New System.Windows.Forms.DateTimePicker
        Me.tmeFrmOp = New System.Windows.Forms.DateTimePicker
        Me.cboOp = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmdPrintOp = New System.Windows.Forms.Button
        Me.cmdSearchOp = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtToOp = New System.Windows.Forms.DateTimePicker
        Me.dtFrmOP = New System.Windows.Forms.DateTimePicker
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.tmeToSt = New System.Windows.Forms.DateTimePicker
        Me.tmeFrmSt = New System.Windows.Forms.DateTimePicker
        Me.cboStation = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmdPrintSt = New System.Windows.Forms.Button
        Me.cmdSearchSt = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.dtToSt = New System.Windows.Forms.DateTimePicker
        Me.dtFrmSt = New System.Windows.Forms.DateTimePicker
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.tmeToVh = New System.Windows.Forms.DateTimePicker
        Me.tmeFrmVh = New System.Windows.Forms.DateTimePicker
        Me.cboVehicle = New System.Windows.Forms.ComboBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmdPrintVh = New System.Windows.Forms.Button
        Me.cmdSearchVh = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.dtToVh = New System.Windows.Forms.DateTimePicker
        Me.dtFrmVh = New System.Windows.Forms.DateTimePicker
        Me.lstList = New System.Windows.Forms.ListView
        Me.Label2 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtcnt = New System.Windows.Forms.ToolStripStatusLabel
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(156, 18)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Reprint Transaction"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Location = New System.Drawing.Point(5, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(756, 643)
        Me.Panel1.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(737, 206)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(729, 175)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Date and Time"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1227, 173)
        Me.Panel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Navy
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Controls.Add(Me.cmdSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.dtDateTo)
        Me.GroupBox1.Controls.Add(Me.dtDateFrm)
        Me.GroupBox1.Controls.Add(Me.dtTmeTo)
        Me.GroupBox1.Controls.Add(Me.dtTmeFrm)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(717, 161)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Query"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.White
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.Black
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrint.Location = New System.Drawing.Point(435, 88)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(112, 34)
        Me.cmdPrint.TabIndex = 67
        Me.cmdPrint.Text = "&Print      "
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'cmdSearch
        '
        Me.cmdSearch.BackColor = System.Drawing.Color.White
        Me.cmdSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearch.ForeColor = System.Drawing.Color.Black
        Me.cmdSearch.Image = CType(resources.GetObject("cmdSearch.Image"), System.Drawing.Image)
        Me.cmdSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearch.Location = New System.Drawing.Point(435, 43)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(112, 34)
        Me.cmdSearch.TabIndex = 66
        Me.cmdSearch.Text = "&Search  "
        Me.cmdSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(88, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "To :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(72, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "From :"
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "yyyy-MM-dd"
        Me.dtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(129, 91)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(121, 24)
        Me.dtDateTo.TabIndex = 63
        '
        'dtDateFrm
        '
        Me.dtDateFrm.CustomFormat = "yyyy-MM-dd"
        Me.dtDateFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrm.Location = New System.Drawing.Point(129, 48)
        Me.dtDateFrm.Name = "dtDateFrm"
        Me.dtDateFrm.Size = New System.Drawing.Size(121, 24)
        Me.dtDateFrm.TabIndex = 62
        '
        'dtTmeTo
        '
        Me.dtTmeTo.CustomFormat = "HH:mm:ss"
        Me.dtTmeTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTmeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTmeTo.Location = New System.Drawing.Point(279, 91)
        Me.dtTmeTo.Name = "dtTmeTo"
        Me.dtTmeTo.ShowUpDown = True
        Me.dtTmeTo.Size = New System.Drawing.Size(123, 24)
        Me.dtTmeTo.TabIndex = 61
        Me.dtTmeTo.Value = New Date(2012, 7, 14, 0, 0, 0, 0)
        '
        'dtTmeFrm
        '
        Me.dtTmeFrm.CustomFormat = "HH:mm:ss"
        Me.dtTmeFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtTmeFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtTmeFrm.Location = New System.Drawing.Point(279, 48)
        Me.dtTmeFrm.Name = "dtTmeFrm"
        Me.dtTmeFrm.ShowUpDown = True
        Me.dtTmeFrm.Size = New System.Drawing.Size(123, 24)
        Me.dtTmeFrm.TabIndex = 60
        Me.dtTmeFrm.Value = New Date(2012, 11, 3, 0, 0, 0, 0)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Panel3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(729, 175)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "By Operator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.GroupBox4)
        Me.Panel3.Location = New System.Drawing.Point(1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1227, 174)
        Me.Panel3.TabIndex = 1
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Navy
        Me.GroupBox4.Controls.Add(Me.tmeToOp)
        Me.GroupBox4.Controls.Add(Me.tmeFrmOp)
        Me.GroupBox4.Controls.Add(Me.cboOp)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cmdPrintOp)
        Me.GroupBox4.Controls.Add(Me.cmdSearchOp)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.dtToOp)
        Me.GroupBox4.Controls.Add(Me.dtFrmOP)
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(716, 161)
        Me.GroupBox4.TabIndex = 52
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Query"
        '
        'tmeToOp
        '
        Me.tmeToOp.CustomFormat = "HH:mm:ss"
        Me.tmeToOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmeToOp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tmeToOp.Location = New System.Drawing.Point(295, 113)
        Me.tmeToOp.Name = "tmeToOp"
        Me.tmeToOp.ShowUpDown = True
        Me.tmeToOp.Size = New System.Drawing.Size(123, 24)
        Me.tmeToOp.TabIndex = 71
        Me.tmeToOp.Value = New Date(2012, 11, 3, 0, 0, 0, 0)
        '
        'tmeFrmOp
        '
        Me.tmeFrmOp.CustomFormat = "HH:mm:ss"
        Me.tmeFrmOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmeFrmOp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tmeFrmOp.Location = New System.Drawing.Point(295, 74)
        Me.tmeFrmOp.Name = "tmeFrmOp"
        Me.tmeFrmOp.ShowUpDown = True
        Me.tmeFrmOp.Size = New System.Drawing.Size(123, 24)
        Me.tmeFrmOp.TabIndex = 70
        Me.tmeFrmOp.Value = New Date(2012, 11, 3, 0, 0, 0, 0)
        '
        'cboOp
        '
        Me.cboOp.BackColor = System.Drawing.Color.White
        Me.cboOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOp.FormattingEnabled = True
        Me.cboOp.Location = New System.Drawing.Point(149, 33)
        Me.cboOp.Name = "cboOp"
        Me.cboOp.Size = New System.Drawing.Size(269, 24)
        Me.cboOp.TabIndex = 69
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(66, 35)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Operator :"
        '
        'cmdPrintOp
        '
        Me.cmdPrintOp.BackColor = System.Drawing.Color.White
        Me.cmdPrintOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintOp.ForeColor = System.Drawing.Color.Black
        Me.cmdPrintOp.Image = CType(resources.GetObject("cmdPrintOp.Image"), System.Drawing.Image)
        Me.cmdPrintOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrintOp.Location = New System.Drawing.Point(446, 89)
        Me.cmdPrintOp.Name = "cmdPrintOp"
        Me.cmdPrintOp.Size = New System.Drawing.Size(112, 34)
        Me.cmdPrintOp.TabIndex = 67
        Me.cmdPrintOp.Text = "&Print      "
        Me.cmdPrintOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrintOp.UseVisualStyleBackColor = False
        '
        'cmdSearchOp
        '
        Me.cmdSearchOp.BackColor = System.Drawing.Color.White
        Me.cmdSearchOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchOp.ForeColor = System.Drawing.Color.Black
        Me.cmdSearchOp.Image = CType(resources.GetObject("cmdSearchOp.Image"), System.Drawing.Image)
        Me.cmdSearchOp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearchOp.Location = New System.Drawing.Point(446, 43)
        Me.cmdSearchOp.Name = "cmdSearchOp"
        Me.cmdSearchOp.Size = New System.Drawing.Size(112, 34)
        Me.cmdSearchOp.TabIndex = 66
        Me.cmdSearchOp.Text = "&Search  "
        Me.cmdSearchOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearchOp.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(108, 116)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 16)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "To :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(92, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "From :"
        '
        'dtToOp
        '
        Me.dtToOp.CustomFormat = "yyyy-MM-dd"
        Me.dtToOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToOp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtToOp.Location = New System.Drawing.Point(149, 112)
        Me.dtToOp.Name = "dtToOp"
        Me.dtToOp.Size = New System.Drawing.Size(121, 24)
        Me.dtToOp.TabIndex = 63
        '
        'dtFrmOP
        '
        Me.dtFrmOP.CustomFormat = "yyyy-MM-dd"
        Me.dtFrmOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrmOP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrmOP.Location = New System.Drawing.Point(149, 74)
        Me.dtFrmOP.Name = "dtFrmOP"
        Me.dtFrmOP.Size = New System.Drawing.Size(121, 24)
        Me.dtFrmOP.TabIndex = 62
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(729, 175)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "By Station"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel4.Controls.Add(Me.GroupBox6)
        Me.Panel4.Location = New System.Drawing.Point(1, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1227, 174)
        Me.Panel4.TabIndex = 2
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.Color.Navy
        Me.GroupBox6.Controls.Add(Me.tmeToSt)
        Me.GroupBox6.Controls.Add(Me.tmeFrmSt)
        Me.GroupBox6.Controls.Add(Me.cboStation)
        Me.GroupBox6.Controls.Add(Me.Label17)
        Me.GroupBox6.Controls.Add(Me.cmdPrintSt)
        Me.GroupBox6.Controls.Add(Me.cmdSearchSt)
        Me.GroupBox6.Controls.Add(Me.Label18)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.dtToSt)
        Me.GroupBox6.Controls.Add(Me.dtFrmSt)
        Me.GroupBox6.ForeColor = System.Drawing.Color.White
        Me.GroupBox6.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(716, 161)
        Me.GroupBox6.TabIndex = 52
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Query"
        '
        'tmeToSt
        '
        Me.tmeToSt.CustomFormat = "HH:mm:ss"
        Me.tmeToSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmeToSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tmeToSt.Location = New System.Drawing.Point(295, 113)
        Me.tmeToSt.Name = "tmeToSt"
        Me.tmeToSt.ShowUpDown = True
        Me.tmeToSt.Size = New System.Drawing.Size(123, 24)
        Me.tmeToSt.TabIndex = 73
        Me.tmeToSt.Value = New Date(2012, 11, 3, 0, 0, 0, 0)
        '
        'tmeFrmSt
        '
        Me.tmeFrmSt.CustomFormat = "HH:mm:ss"
        Me.tmeFrmSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmeFrmSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tmeFrmSt.Location = New System.Drawing.Point(295, 74)
        Me.tmeFrmSt.Name = "tmeFrmSt"
        Me.tmeFrmSt.ShowUpDown = True
        Me.tmeFrmSt.Size = New System.Drawing.Size(123, 24)
        Me.tmeFrmSt.TabIndex = 72
        Me.tmeFrmSt.Value = New Date(2012, 11, 3, 0, 0, 0, 0)
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.White
        Me.cboStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4", "Station 5", "Station 6", "Station 7", "Station 8", "Station 9", "Station 10", "Station 11", "Station 12", "Station 13", "Station 14", "Station 15", "Station 16", "Station 17", "Station 18", "Station 19", "Station 20", "Station 21", "Station 22", "Station 23", "Station 24", "Station 25", "Station 26", "Station 27", "Station 28", "Station 29", "Station 30", "Station 31", "Station 32", "Station 33", "Station 34", "Station 35", "Station 36", "Station 37", "Station 38", "Station 39", "Station 40", "Station 41", "Station 42", "Station 43", "Station 44", "Station 45", "Station 46", "Station 47", "Station 48", "Station 49", "Station 50", "Station 51", "Station 52", "Station 53", "Station 54", "Station 55", "Station 56", "Station 57", "Station 58", "Station 59", "Station 60", "Station 61", "Station 62", "Station 63", "Station 64", "Station 65", "Station 66", "Station 67", "Station 68", "Station 69", "Station 70", "Station 71", "Station 72", "Station 73", "Station 74", "Station 75", "Station 76", "Station 77", "Station 78", "Station 79", "Station 80", "Station 81", "Station 82", "Station 83", "Station 84", "Station 85", "Station 86", "Station 87", "Station 88", "Station 89", "Station 90", "Station 91", "Station 92", "Station 93", "Station 94", "Station 95", "Station 96", "Station 97", "Station 98", "Station 99", "Station 100"})
        Me.cboStation.Location = New System.Drawing.Point(151, 33)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(267, 24)
        Me.cboStation.TabIndex = 69
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(79, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Station :"
        '
        'cmdPrintSt
        '
        Me.cmdPrintSt.BackColor = System.Drawing.Color.White
        Me.cmdPrintSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintSt.ForeColor = System.Drawing.Color.Black
        Me.cmdPrintSt.Image = CType(resources.GetObject("cmdPrintSt.Image"), System.Drawing.Image)
        Me.cmdPrintSt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrintSt.Location = New System.Drawing.Point(446, 89)
        Me.cmdPrintSt.Name = "cmdPrintSt"
        Me.cmdPrintSt.Size = New System.Drawing.Size(112, 34)
        Me.cmdPrintSt.TabIndex = 67
        Me.cmdPrintSt.Text = "&Print      "
        Me.cmdPrintSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrintSt.UseVisualStyleBackColor = False
        '
        'cmdSearchSt
        '
        Me.cmdSearchSt.BackColor = System.Drawing.Color.White
        Me.cmdSearchSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchSt.ForeColor = System.Drawing.Color.Black
        Me.cmdSearchSt.Image = CType(resources.GetObject("cmdSearchSt.Image"), System.Drawing.Image)
        Me.cmdSearchSt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearchSt.Location = New System.Drawing.Point(446, 43)
        Me.cmdSearchSt.Name = "cmdSearchSt"
        Me.cmdSearchSt.Size = New System.Drawing.Size(112, 34)
        Me.cmdSearchSt.TabIndex = 66
        Me.cmdSearchSt.Text = "&Search  "
        Me.cmdSearchSt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearchSt.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(108, 116)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 16)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "To :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(92, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 16)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "From :"
        '
        'dtToSt
        '
        Me.dtToSt.CustomFormat = "yyyy-MM-dd"
        Me.dtToSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtToSt.Location = New System.Drawing.Point(149, 112)
        Me.dtToSt.Name = "dtToSt"
        Me.dtToSt.Size = New System.Drawing.Size(121, 24)
        Me.dtToSt.TabIndex = 63
        '
        'dtFrmSt
        '
        Me.dtFrmSt.CustomFormat = "yyyy-MM-dd"
        Me.dtFrmSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrmSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrmSt.Location = New System.Drawing.Point(149, 74)
        Me.dtFrmSt.Name = "dtFrmSt"
        Me.dtFrmSt.Size = New System.Drawing.Size(121, 24)
        Me.dtFrmSt.TabIndex = 62
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 27)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(729, 175)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "By Vehicle"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel5.Controls.Add(Me.GroupBox8)
        Me.Panel5.Location = New System.Drawing.Point(1, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(727, 174)
        Me.Panel5.TabIndex = 2
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Navy
        Me.GroupBox8.Controls.Add(Me.tmeToVh)
        Me.GroupBox8.Controls.Add(Me.tmeFrmVh)
        Me.GroupBox8.Controls.Add(Me.cboVehicle)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.cmdPrintVh)
        Me.GroupBox8.Controls.Add(Me.cmdSearchVh)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.dtToVh)
        Me.GroupBox8.Controls.Add(Me.dtFrmVh)
        Me.GroupBox8.ForeColor = System.Drawing.Color.White
        Me.GroupBox8.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(715, 161)
        Me.GroupBox8.TabIndex = 52
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Query"
        '
        'tmeToVh
        '
        Me.tmeToVh.CustomFormat = "HH:mm:ss"
        Me.tmeToVh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmeToVh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tmeToVh.Location = New System.Drawing.Point(296, 113)
        Me.tmeToVh.Name = "tmeToVh"
        Me.tmeToVh.ShowUpDown = True
        Me.tmeToVh.Size = New System.Drawing.Size(123, 24)
        Me.tmeToVh.TabIndex = 73
        Me.tmeToVh.Value = New Date(2012, 11, 3, 0, 0, 0, 0)
        '
        'tmeFrmVh
        '
        Me.tmeFrmVh.CustomFormat = "HH:mm:ss"
        Me.tmeFrmVh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmeFrmVh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.tmeFrmVh.Location = New System.Drawing.Point(296, 75)
        Me.tmeFrmVh.Name = "tmeFrmVh"
        Me.tmeFrmVh.ShowUpDown = True
        Me.tmeFrmVh.Size = New System.Drawing.Size(123, 24)
        Me.tmeFrmVh.TabIndex = 72
        Me.tmeFrmVh.Value = New Date(2012, 11, 3, 0, 0, 0, 0)
        '
        'cboVehicle
        '
        Me.cboVehicle.BackColor = System.Drawing.Color.White
        Me.cboVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVehicle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicle.FormattingEnabled = True
        Me.cboVehicle.Location = New System.Drawing.Point(149, 33)
        Me.cboVehicle.Name = "cboVehicle"
        Me.cboVehicle.Size = New System.Drawing.Size(270, 24)
        Me.cboVehicle.TabIndex = 69
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(75, 36)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 16)
        Me.Label23.TabIndex = 68
        Me.Label23.Text = "Vehicle :"
        '
        'cmdPrintVh
        '
        Me.cmdPrintVh.BackColor = System.Drawing.Color.White
        Me.cmdPrintVh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintVh.ForeColor = System.Drawing.Color.Black
        Me.cmdPrintVh.Image = CType(resources.GetObject("cmdPrintVh.Image"), System.Drawing.Image)
        Me.cmdPrintVh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdPrintVh.Location = New System.Drawing.Point(446, 89)
        Me.cmdPrintVh.Name = "cmdPrintVh"
        Me.cmdPrintVh.Size = New System.Drawing.Size(112, 34)
        Me.cmdPrintVh.TabIndex = 67
        Me.cmdPrintVh.Text = "&Print      "
        Me.cmdPrintVh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdPrintVh.UseVisualStyleBackColor = False
        '
        'cmdSearchVh
        '
        Me.cmdSearchVh.BackColor = System.Drawing.Color.White
        Me.cmdSearchVh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSearchVh.ForeColor = System.Drawing.Color.Black
        Me.cmdSearchVh.Image = CType(resources.GetObject("cmdSearchVh.Image"), System.Drawing.Image)
        Me.cmdSearchVh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSearchVh.Location = New System.Drawing.Point(446, 43)
        Me.cmdSearchVh.Name = "cmdSearchVh"
        Me.cmdSearchVh.Size = New System.Drawing.Size(112, 34)
        Me.cmdSearchVh.TabIndex = 66
        Me.cmdSearchVh.Text = "&Search  "
        Me.cmdSearchVh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSearchVh.UseVisualStyleBackColor = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(108, 116)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(35, 16)
        Me.Label24.TabIndex = 65
        Me.Label24.Text = "To :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(92, 78)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(51, 16)
        Me.Label25.TabIndex = 64
        Me.Label25.Text = "From :"
        '
        'dtToVh
        '
        Me.dtToVh.CustomFormat = "yyyy-MM-dd"
        Me.dtToVh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToVh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtToVh.Location = New System.Drawing.Point(149, 112)
        Me.dtToVh.Name = "dtToVh"
        Me.dtToVh.Size = New System.Drawing.Size(121, 24)
        Me.dtToVh.TabIndex = 63
        '
        'dtFrmVh
        '
        Me.dtFrmVh.CustomFormat = "yyyy-MM-dd"
        Me.dtFrmVh.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrmVh.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrmVh.Location = New System.Drawing.Point(149, 74)
        Me.dtFrmVh.Name = "dtFrmVh"
        Me.dtFrmVh.Size = New System.Drawing.Size(121, 24)
        Me.dtFrmVh.TabIndex = 62
        '
        'lstList
        '
        Me.lstList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.FullRowSelect = True
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(10, 225)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(737, 408)
        Me.lstList.TabIndex = 24
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(748, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "  "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel1, Me.txtcnt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 675)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(766, 37)
        Me.StatusStrip1.TabIndex = 17
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
        'frmReportDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(766, 712)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmReportDT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtcnt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDateFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTmeTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtTmeFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cboOp As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdPrintOp As System.Windows.Forms.Button
    Friend WithEvents cmdSearchOp As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtToOp As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrmOP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdPrintSt As System.Windows.Forms.Button
    Friend WithEvents cmdSearchSt As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtToSt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrmSt As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents cboVehicle As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmdPrintVh As System.Windows.Forms.Button
    Friend WithEvents cmdSearchVh As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents dtToVh As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrmVh As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmeToOp As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmeFrmOp As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmeToSt As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmeFrmSt As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmeToVh As System.Windows.Forms.DateTimePicker
    Friend WithEvents tmeFrmVh As System.Windows.Forms.DateTimePicker
End Class
