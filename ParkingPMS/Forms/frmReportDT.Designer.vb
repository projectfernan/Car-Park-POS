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
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboDtsort = New System.Windows.Forms.ComboBox
        Me.cboDtOrderBy = New System.Windows.Forms.ComboBox
        Me.dtDateFrm = New System.Windows.Forms.DateTimePicker
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.dtDateTo = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboOpSort = New System.Windows.Forms.ComboBox
        Me.cboOpOrder = New System.Windows.Forms.ComboBox
        Me.cboOp = New System.Windows.Forms.ComboBox
        Me.cmdPrintOp = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.dtFrmOP = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtToOp = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.Label5 = New System.Windows.Forms.Label
        Me.cboStSort = New System.Windows.Forms.ComboBox
        Me.cboStOrder = New System.Windows.Forms.ComboBox
        Me.cboStation = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmdPrintSt = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.dtFrmSt = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.dtToSt = New System.Windows.Forms.DateTimePicker
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.crViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(976, 156)
        Me.TabControl1.TabIndex = 27
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboDtsort)
        Me.TabPage1.Controls.Add(Me.cboDtOrderBy)
        Me.TabPage1.Controls.Add(Me.dtDateFrm)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.dtDateTo)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmdPrint)
        Me.TabPage1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(968, 125)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Date and Time"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(259, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 79
        Me.Label2.Text = "Sort By :"
        '
        'cboDtsort
        '
        Me.cboDtsort.BackColor = System.Drawing.Color.White
        Me.cboDtsort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDtsort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDtsort.FormattingEnabled = True
        Me.cboDtsort.Items.AddRange(New Object() {"Asc", "Desc"})
        Me.cboDtsort.Location = New System.Drawing.Point(329, 65)
        Me.cboDtsort.Name = "cboDtsort"
        Me.cboDtsort.Size = New System.Drawing.Size(120, 24)
        Me.cboDtsort.TabIndex = 78
        Me.cboDtsort.Text = "Asc"
        '
        'cboDtOrderBy
        '
        Me.cboDtOrderBy.BackColor = System.Drawing.Color.White
        Me.cboDtOrderBy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDtOrderBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDtOrderBy.FormattingEnabled = True
        Me.cboDtOrderBy.Items.AddRange(New Object() {"ORno", "Total", "Hourly", "Overnigth", "LostCard"})
        Me.cboDtOrderBy.Location = New System.Drawing.Point(329, 32)
        Me.cboDtOrderBy.Name = "cboDtOrderBy"
        Me.cboDtOrderBy.Size = New System.Drawing.Size(120, 24)
        Me.cboDtOrderBy.TabIndex = 77
        Me.cboDtOrderBy.Text = "ORno"
        '
        'dtDateFrm
        '
        Me.dtDateFrm.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtDateFrm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateFrm.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateFrm.Location = New System.Drawing.Point(77, 31)
        Me.dtDateFrm.Name = "dtDateFrm"
        Me.dtDateFrm.Size = New System.Drawing.Size(168, 24)
        Me.dtDateFrm.TabIndex = 62
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(23, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "From :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(248, 35)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(77, 16)
        Me.Label27.TabIndex = 76
        Me.Label27.Text = "Order By :"
        '
        'dtDateTo
        '
        Me.dtDateTo.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateTo.Location = New System.Drawing.Point(77, 61)
        Me.dtDateTo.Name = "dtDateTo"
        Me.dtDateTo.Size = New System.Drawing.Size(168, 24)
        Me.dtDateTo.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(39, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "To :"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrint.Location = New System.Drawing.Point(455, 30)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(87, 61)
        Me.cmdPrint.TabIndex = 67
        Me.cmdPrint.Text = "&Generate"
        Me.cmdPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrint.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.cboOpSort)
        Me.TabPage2.Controls.Add(Me.cboOpOrder)
        Me.TabPage2.Controls.Add(Me.cboOp)
        Me.TabPage2.Controls.Add(Me.cmdPrintOp)
        Me.TabPage2.Controls.Add(Me.Label26)
        Me.TabPage2.Controls.Add(Me.dtFrmOP)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.dtToOp)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(968, 125)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "By Operator"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(279, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Sort By :"
        '
        'cboOpSort
        '
        Me.cboOpSort.BackColor = System.Drawing.Color.White
        Me.cboOpSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboOpSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpSort.FormattingEnabled = True
        Me.cboOpSort.Items.AddRange(New Object() {"Asc", "Desc"})
        Me.cboOpSort.Location = New System.Drawing.Point(349, 79)
        Me.cboOpSort.Name = "cboOpSort"
        Me.cboOpSort.Size = New System.Drawing.Size(121, 24)
        Me.cboOpSort.TabIndex = 79
        Me.cboOpSort.Text = "Asc"
        '
        'cboOpOrder
        '
        Me.cboOpOrder.BackColor = System.Drawing.Color.White
        Me.cboOpOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboOpOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOpOrder.FormattingEnabled = True
        Me.cboOpOrder.Items.AddRange(New Object() {"ORno", "Total", "Hourly", "Overnigth", "LostCard"})
        Me.cboOpOrder.Location = New System.Drawing.Point(349, 49)
        Me.cboOpOrder.Name = "cboOpOrder"
        Me.cboOpOrder.Size = New System.Drawing.Size(121, 24)
        Me.cboOpOrder.TabIndex = 73
        Me.cboOpOrder.Text = "ORno"
        '
        'cboOp
        '
        Me.cboOp.BackColor = System.Drawing.Color.White
        Me.cboOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboOp.FormattingEnabled = True
        Me.cboOp.Location = New System.Drawing.Point(97, 16)
        Me.cboOp.Name = "cboOp"
        Me.cboOp.Size = New System.Drawing.Size(373, 24)
        Me.cboOp.TabIndex = 69
        '
        'cmdPrintOp
        '
        Me.cmdPrintOp.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPrintOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrintOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintOp.ForeColor = System.Drawing.Color.White
        Me.cmdPrintOp.Image = CType(resources.GetObject("cmdPrintOp.Image"), System.Drawing.Image)
        Me.cmdPrintOp.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrintOp.Location = New System.Drawing.Point(476, 45)
        Me.cmdPrintOp.Name = "cmdPrintOp"
        Me.cmdPrintOp.Size = New System.Drawing.Size(87, 61)
        Me.cmdPrintOp.TabIndex = 67
        Me.cmdPrintOp.Text = "&Generate"
        Me.cmdPrintOp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrintOp.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(268, 52)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 16)
        Me.Label26.TabIndex = 72
        Me.Label26.Text = "Order By :"
        '
        'dtFrmOP
        '
        Me.dtFrmOP.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtFrmOP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrmOP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrmOP.Location = New System.Drawing.Point(97, 48)
        Me.dtFrmOP.Name = "dtFrmOP"
        Me.dtFrmOP.Size = New System.Drawing.Size(168, 24)
        Me.dtFrmOP.TabIndex = 62
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(17, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 16)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Operator :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(59, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 16)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "To :"
        '
        'dtToOp
        '
        Me.dtToOp.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtToOp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToOp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtToOp.Location = New System.Drawing.Point(97, 78)
        Me.dtToOp.Name = "dtToOp"
        Me.dtToOp.Size = New System.Drawing.Size(168, 24)
        Me.dtToOp.TabIndex = 63
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(43, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 16)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "From :"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.cboStSort)
        Me.TabPage3.Controls.Add(Me.cboStOrder)
        Me.TabPage3.Controls.Add(Me.cboStation)
        Me.TabPage3.Controls.Add(Me.Label17)
        Me.TabPage3.Controls.Add(Me.cmdPrintSt)
        Me.TabPage3.Controls.Add(Me.Label28)
        Me.TabPage3.Controls.Add(Me.dtFrmSt)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.dtToSt)
        Me.TabPage3.Location = New System.Drawing.Point(4, 27)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(968, 125)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "By Station"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(279, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 16)
        Me.Label5.TabIndex = 83
        Me.Label5.Text = "Sort By :"
        '
        'cboStSort
        '
        Me.cboStSort.BackColor = System.Drawing.Color.White
        Me.cboStSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStSort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStSort.FormattingEnabled = True
        Me.cboStSort.Items.AddRange(New Object() {"Asc", "Desc"})
        Me.cboStSort.Location = New System.Drawing.Point(349, 79)
        Me.cboStSort.Name = "cboStSort"
        Me.cboStSort.Size = New System.Drawing.Size(121, 24)
        Me.cboStSort.TabIndex = 82
        Me.cboStSort.Text = "Asc"
        '
        'cboStOrder
        '
        Me.cboStOrder.BackColor = System.Drawing.Color.White
        Me.cboStOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStOrder.FormattingEnabled = True
        Me.cboStOrder.Items.AddRange(New Object() {"ORno", "Total", "Hourly", "Overnigth", "LostCard"})
        Me.cboStOrder.Location = New System.Drawing.Point(349, 49)
        Me.cboStOrder.Name = "cboStOrder"
        Me.cboStOrder.Size = New System.Drawing.Size(121, 24)
        Me.cboStOrder.TabIndex = 81
        Me.cboStOrder.Text = "ORno"
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.White
        Me.cboStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4", "Station 5", "Station 6", "Station 7", "Station 8", "Station 9", "Station 10", "Station 11", "Station 12", "Station 13", "Station 14", "Station 15", "Station 16", "Station 17", "Station 18", "Station 19", "Station 20", "Station 21", "Station 22", "Station 23", "Station 24", "Station 25", "Station 26", "Station 27", "Station 28", "Station 29", "Station 30", "Station 31", "Station 32", "Station 33", "Station 34", "Station 35", "Station 36", "Station 37", "Station 38", "Station 39", "Station 40", "Station 41", "Station 42", "Station 43", "Station 44", "Station 45", "Station 46", "Station 47", "Station 48", "Station 49", "Station 50", "Station 51", "Station 52", "Station 53", "Station 54", "Station 55", "Station 56", "Station 57", "Station 58", "Station 59", "Station 60", "Station 61", "Station 62", "Station 63", "Station 64", "Station 65", "Station 66", "Station 67", "Station 68", "Station 69", "Station 70", "Station 71", "Station 72", "Station 73", "Station 74", "Station 75", "Station 76", "Station 77", "Station 78", "Station 79", "Station 80", "Station 81", "Station 82", "Station 83", "Station 84", "Station 85", "Station 86", "Station 87", "Station 88", "Station 89", "Station 90", "Station 91", "Station 92", "Station 93", "Station 94", "Station 95", "Station 96", "Station 97", "Station 98", "Station 99", "Station 100"})
        Me.cboStation.Location = New System.Drawing.Point(97, 16)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(373, 24)
        Me.cboStation.TabIndex = 69
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(29, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 68
        Me.Label17.Text = "Station :"
        '
        'cmdPrintSt
        '
        Me.cmdPrintSt.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmdPrintSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrintSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrintSt.ForeColor = System.Drawing.Color.White
        Me.cmdPrintSt.Image = CType(resources.GetObject("cmdPrintSt.Image"), System.Drawing.Image)
        Me.cmdPrintSt.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.cmdPrintSt.Location = New System.Drawing.Point(476, 45)
        Me.cmdPrintSt.Name = "cmdPrintSt"
        Me.cmdPrintSt.Size = New System.Drawing.Size(87, 61)
        Me.cmdPrintSt.TabIndex = 67
        Me.cmdPrintSt.Text = "&Generate"
        Me.cmdPrintSt.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdPrintSt.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(268, 52)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(77, 16)
        Me.Label28.TabIndex = 80
        Me.Label28.Text = "Order By :"
        '
        'dtFrmSt
        '
        Me.dtFrmSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtFrmSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtFrmSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtFrmSt.Location = New System.Drawing.Point(97, 48)
        Me.dtFrmSt.Name = "dtFrmSt"
        Me.dtFrmSt.Size = New System.Drawing.Size(168, 24)
        Me.dtFrmSt.TabIndex = 62
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(59, 82)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 16)
        Me.Label18.TabIndex = 65
        Me.Label18.Text = "To :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(43, 52)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(51, 16)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "From :"
        '
        'dtToSt
        '
        Me.dtToSt.CustomFormat = "yyyy-MM-dd HH:mm"
        Me.dtToSt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtToSt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtToSt.Location = New System.Drawing.Point(97, 78)
        Me.dtToSt.Name = "dtToSt"
        Me.dtToSt.Size = New System.Drawing.Size(168, 24)
        Me.dtToSt.TabIndex = 63
        '
        'HeaderPanel
        '
        Me.HeaderPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label3)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.HeaderPanel.Location = New System.Drawing.Point(-1, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1000, 38)
        Me.HeaderPanel.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(6, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 18)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "     Detailed Sales Report"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(974, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.crViewer)
        Me.Panel1.Location = New System.Drawing.Point(9, 210)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(976, 390)
        Me.Panel1.TabIndex = 30
        '
        'crViewer
        '
        Me.crViewer.ActiveViewIndex = -1
        Me.crViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crViewer.Cursor = System.Windows.Forms.Cursors.Default
        Me.crViewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crViewer.Location = New System.Drawing.Point(0, 0)
        Me.crViewer.Name = "crViewer"
        Me.crViewer.Size = New System.Drawing.Size(976, 390)
        Me.crViewer.TabIndex = 0
        Me.crViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frmReportDT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(994, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmReportDT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cboOp As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmdPrintOp As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents dtToOp As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrmOP As System.Windows.Forms.DateTimePicker
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdPrintSt As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents dtToSt As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFrmSt As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboOpOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cboOpSort As System.Windows.Forms.ComboBox
    Friend WithEvents cboStSort As System.Windows.Forms.ComboBox
    Friend WithEvents cboStOrder As System.Windows.Forms.ComboBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents cboDtsort As System.Windows.Forms.ComboBox
    Friend WithEvents cboDtOrderBy As System.Windows.Forms.ComboBox
    Friend WithEvents dtDateFrm As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents dtDateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents crViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
