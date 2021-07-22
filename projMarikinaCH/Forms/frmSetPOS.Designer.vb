<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetPOS))
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtPermit = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.dtAccr = New System.Windows.Forms.DateTimePicker
        Me.txtVendorAddr = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtVendorTin = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtPOSVendor = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtOperatedBy = New System.Windows.Forms.TextBox
        Me.fsdf = New System.Windows.Forms.Label
        Me.chkPing = New System.Windows.Forms.CheckBox
        Me.chkDataPool = New System.Windows.Forms.CheckBox
        Me.chkDesktop = New System.Windows.Forms.CheckBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtAdd = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cboChargeState = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboStation = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAccr = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtMachine = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtSerial = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPermit = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTin = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.HeaderPanel = New System.Windows.Forms.Panel
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Label
        Me.btnSave = New System.Windows.Forms.Button
        Me.txtSlot = New System.Windows.Forms.NumericUpDown
        Me.HeaderPanel.SuspendLayout()
        CType(Me.txtSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(62, 419)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 16)
        Me.Label18.TabIndex = 86
        Me.Label18.Text = "Date Issued :"
        '
        'dtPermit
        '
        Me.dtPermit.CustomFormat = "yyyy-MM-dd"
        Me.dtPermit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtPermit.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtPermit.Location = New System.Drawing.Point(167, 417)
        Me.dtPermit.Name = "dtPermit"
        Me.dtPermit.Size = New System.Drawing.Size(240, 24)
        Me.dtPermit.TabIndex = 13
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(79, 362)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 16)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "Accr Date :"
        '
        'dtAccr
        '
        Me.dtAccr.CustomFormat = "yyyy-MM-dd"
        Me.dtAccr.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtAccr.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtAccr.Location = New System.Drawing.Point(167, 359)
        Me.dtAccr.Name = "dtAccr"
        Me.dtAccr.Size = New System.Drawing.Size(240, 24)
        Me.dtAccr.TabIndex = 11
        '
        'txtVendorAddr
        '
        Me.txtVendorAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendorAddr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendorAddr.Location = New System.Drawing.Point(167, 275)
        Me.txtVendorAddr.MaxLength = 44
        Me.txtVendorAddr.Name = "txtVendorAddr"
        Me.txtVendorAddr.Size = New System.Drawing.Size(240, 22)
        Me.txtVendorAddr.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(20, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 16)
        Me.Label14.TabIndex = 84
        Me.Label14.Text = "POS Vendor Addr. :"
        '
        'txtVendorTin
        '
        Me.txtVendorTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVendorTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendorTin.Location = New System.Drawing.Point(167, 303)
        Me.txtVendorTin.MaxLength = 50
        Me.txtVendorTin.Name = "txtVendorTin"
        Me.txtVendorTin.Size = New System.Drawing.Size(240, 22)
        Me.txtVendorTin.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(20, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(142, 16)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "POS Vendor TIN # :"
        '
        'txtPOSVendor
        '
        Me.txtPOSVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOSVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOSVendor.Location = New System.Drawing.Point(167, 247)
        Me.txtPOSVendor.MaxLength = 50
        Me.txtPOSVendor.Name = "txtPOSVendor"
        Me.txtPOSVendor.Size = New System.Drawing.Size(240, 22)
        Me.txtPOSVendor.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(60, 249)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 16)
        Me.Label16.TabIndex = 82
        Me.Label16.Text = "POS Vendor :"
        '
        'txtOperatedBy
        '
        Me.txtOperatedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOperatedBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOperatedBy.Location = New System.Drawing.Point(167, 79)
        Me.txtOperatedBy.MaxLength = 33
        Me.txtOperatedBy.Name = "txtOperatedBy"
        Me.txtOperatedBy.Size = New System.Drawing.Size(240, 22)
        Me.txtOperatedBy.TabIndex = 1
        '
        'fsdf
        '
        Me.fsdf.AutoSize = True
        Me.fsdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fsdf.ForeColor = System.Drawing.Color.White
        Me.fsdf.Location = New System.Drawing.Point(69, 81)
        Me.fsdf.Name = "fsdf"
        Me.fsdf.Size = New System.Drawing.Size(94, 16)
        Me.fsdf.TabIndex = 43
        Me.fsdf.Text = "Oprated By :"
        '
        'chkPing
        '
        Me.chkPing.AutoSize = True
        Me.chkPing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkPing.ForeColor = System.Drawing.Color.White
        Me.chkPing.Location = New System.Drawing.Point(168, 563)
        Me.chkPing.Name = "chkPing"
        Me.chkPing.Size = New System.Drawing.Size(175, 20)
        Me.chkPing.TabIndex = 20
        Me.chkPing.Text = "Disabled Server Ping"
        Me.chkPing.UseVisualStyleBackColor = True
        '
        'chkDataPool
        '
        Me.chkDataPool.AutoSize = True
        Me.chkDataPool.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDataPool.ForeColor = System.Drawing.Color.White
        Me.chkDataPool.Location = New System.Drawing.Point(168, 537)
        Me.chkDataPool.Name = "chkDataPool"
        Me.chkDataPool.Size = New System.Drawing.Size(175, 20)
        Me.chkDataPool.TabIndex = 19
        Me.chkDataPool.Text = "Disable Data Pooling"
        Me.chkDataPool.UseVisualStyleBackColor = True
        '
        'chkDesktop
        '
        Me.chkDesktop.AutoSize = True
        Me.chkDesktop.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDesktop.ForeColor = System.Drawing.Color.White
        Me.chkDesktop.Location = New System.Drawing.Point(168, 589)
        Me.chkDesktop.Name = "chkDesktop"
        Me.chkDesktop.Size = New System.Drawing.Size(122, 20)
        Me.chkDesktop.TabIndex = 21
        Me.chkDesktop.Text = "Lock Desktop"
        Me.chkDesktop.UseVisualStyleBackColor = True
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContact.Location = New System.Drawing.Point(167, 135)
        Me.txtContact.MaxLength = 44
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(240, 22)
        Me.txtContact.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(66, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Contact No. :"
        '
        'txtAdd
        '
        Me.txtAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdd.Location = New System.Drawing.Point(167, 107)
        Me.txtAdd.MaxLength = 44
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(240, 22)
        Me.txtAdd.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(88, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 16)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Address :"
        '
        'txtTitle
        '
        Me.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(167, 51)
        Me.txtTitle.MaxLength = 33
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(240, 22)
        Me.txtTitle.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(58, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(105, 16)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Receipt Title :"
        '
        'cboChargeState
        '
        Me.cboChargeState.BackColor = System.Drawing.Color.White
        Me.cboChargeState.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboChargeState.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChargeState.FormattingEnabled = True
        Me.cboChargeState.Items.AddRange(New Object() {"HOURLY", "FLAT RATE"})
        Me.cboChargeState.Location = New System.Drawing.Point(167, 505)
        Me.cboChargeState.Name = "cboChargeState"
        Me.cboChargeState.Size = New System.Drawing.Size(240, 24)
        Me.cboChargeState.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(42, 508)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Charging State :"
        '
        'cboStation
        '
        Me.cboStation.BackColor = System.Drawing.Color.White
        Me.cboStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboStation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStation.FormattingEnabled = True
        Me.cboStation.Items.AddRange(New Object() {"Station 1", "Station 2", "Station 3", "Station 4", "Station 5", "Station 6", "Station 7", "Station 8", "Station 9", "Station 10", "Station 11", "Station 12", "Station 13", "Station 14", "Station 15", "Station 16", "Station 17", "Station 18", "Station 19", "Station 20", "Station 21", "Station 22", "Station 23", "Station 24", "Station 25", "Station 26", "Station 27", "Station 28", "Station 29", "Station 30", "Station 31", "Station 32", "Station 33", "Station 34", "Station 35", "Station 36", "Station 37", "Station 38", "Station 39", "Station 40", "Station 41", "Station 42", "Station 43", "Station 44", "Station 45", "Station 46", "Station 47", "Station 48", "Station 49", "Station 50", "Station 51", "Station 52", "Station 53", "Station 54", "Station 55", "Station 56", "Station 57", "Station 58", "Station 59", "Station 60", "Station 61", "Station 62", "Station 63", "Station 64", "Station 65", "Station 66", "Station 67", "Station 68", "Station 69", "Station 70", "Station 71", "Station 72", "Station 73", "Station 74", "Station 75", "Station 76", "Station 77", "Station 78", "Station 79", "Station 80", "Station 81", "Station 82", "Station 83", "Station 84", "Station 85", "Station 86", "Station 87", "Station 88", "Station 89", "Station 90", "Station 91", "Station 92", "Station 93", "Station 94", "Station 95", "Station 96", "Station 97", "Station 98", "Station 99", "Station 100"})
        Me.cboStation.Location = New System.Drawing.Point(167, 475)
        Me.cboStation.Name = "cboStation"
        Me.cboStation.Size = New System.Drawing.Size(240, 24)
        Me.cboStation.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(60, 447)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Parking Slot :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(96, 478)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Station :"
        '
        'txtAccr
        '
        Me.txtAccr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAccr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccr.Location = New System.Drawing.Point(167, 331)
        Me.txtAccr.MaxLength = 50
        Me.txtAccr.Name = "txtAccr"
        Me.txtAccr.Size = New System.Drawing.Size(240, 22)
        Me.txtAccr.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(116, 333)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Accr :"
        '
        'txtMachine
        '
        Me.txtMachine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMachine.Location = New System.Drawing.Point(167, 219)
        Me.txtMachine.MaxLength = 50
        Me.txtMachine.Name = "txtMachine"
        Me.txtMachine.Size = New System.Drawing.Size(240, 22)
        Me.txtMachine.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(75, 221)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 16)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Machine # :"
        '
        'txtSerial
        '
        Me.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerial.Location = New System.Drawing.Point(167, 191)
        Me.txtSerial.MaxLength = 50
        Me.txtSerial.Name = "txtSerial"
        Me.txtSerial.Size = New System.Drawing.Size(240, 22)
        Me.txtSerial.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(93, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Serial # :"
        '
        'txtPermit
        '
        Me.txtPermit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPermit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPermit.Location = New System.Drawing.Point(167, 389)
        Me.txtPermit.MaxLength = 50
        Me.txtPermit.Name = "txtPermit"
        Me.txtPermit.Size = New System.Drawing.Size(240, 22)
        Me.txtPermit.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(89, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Permit # :"
        '
        'txtTin
        '
        Me.txtTin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTin.Location = New System.Drawing.Point(167, 163)
        Me.txtTin.MaxLength = 50
        Me.txtTin.Name = "txtTin"
        Me.txtTin.Size = New System.Drawing.Size(240, 22)
        Me.txtTin.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(109, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "TIN # :"
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.HeaderPanel.Controls.Add(Me.Label11)
        Me.HeaderPanel.Controls.Add(Me.btnClose)
        Me.HeaderPanel.Location = New System.Drawing.Point(-1, -1)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(438, 38)
        Me.HeaderPanel.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Image = CType(resources.GetObject("Label11.Image"), System.Drawing.Image)
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label11.Location = New System.Drawing.Point(6, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 18)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "     Set POS"
        '
        'btnClose
        '
        Me.btnClose.AutoSize = True
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(417, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(17, 20)
        Me.btnClose.TabIndex = 29
        Me.btnClose.Text = "x"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.Black
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(309, 624)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(98, 38)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "&Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtSlot
        '
        Me.txtSlot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSlot.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlot.Location = New System.Drawing.Point(168, 447)
        Me.txtSlot.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txtSlot.Name = "txtSlot"
        Me.txtSlot.Size = New System.Drawing.Size(239, 22)
        Me.txtSlot.TabIndex = 14
        '
        'frmSetPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(436, 687)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtSlot)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.dtPermit)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.dtAccr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVendorAddr)
        Me.Controls.Add(Me.txtTin)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtVendorTin)
        Me.Controls.Add(Me.txtPermit)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPOSVendor)
        Me.Controls.Add(Me.txtSerial)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMachine)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtOperatedBy)
        Me.Controls.Add(Me.txtAccr)
        Me.Controls.Add(Me.fsdf)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chkPing)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkDataPool)
        Me.Controls.Add(Me.chkDesktop)
        Me.Controls.Add(Me.cboStation)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboChargeState)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetPOS"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.HeaderPanel.ResumeLayout(False)
        Me.HeaderPanel.PerformLayout()
        CType(Me.txtSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMachine As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSerial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPermit As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTin As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAccr As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboStation As System.Windows.Forms.ComboBox
    Friend WithEvents cboChargeState As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAdd As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkDesktop As System.Windows.Forms.CheckBox
    Friend WithEvents chkDataPool As System.Windows.Forms.CheckBox
    Friend WithEvents chkPing As System.Windows.Forms.CheckBox
    Friend WithEvents txtOperatedBy As System.Windows.Forms.TextBox
    Friend WithEvents fsdf As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtPermit As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtAccr As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtVendorAddr As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtVendorTin As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtPOSVendor As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents HeaderPanel As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtSlot As System.Windows.Forms.NumericUpDown
End Class
