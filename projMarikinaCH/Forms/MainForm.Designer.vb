<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.tmeTime = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtPosi = New System.Windows.Forms.ToolStripStatusLabel
        Me.TxtOp = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtDbStat = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel11 = New System.Windows.Forms.ToolStripStatusLabel
        Me.dbstat2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel17 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel12 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtTotalSlot = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel13 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel14 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtSlot = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel16 = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtUsername = New System.Windows.Forms.ToolStripStatusLabel
        Me.txtStatus = New System.Windows.Forms.ToolStripStatusLabel
        Me.TmrRead = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer7 = New System.Windows.Forms.SplitContainer
        Me.Label13 = New System.Windows.Forms.Label
        Me.InPic = New System.Windows.Forms.PictureBox
        Me.CamEntry = New AxNETVIDEOACTIVEXLib.AxNetVideoActiveX
        Me.Label17 = New System.Windows.Forms.Label
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer
        Me.SplitContainer8 = New System.Windows.Forms.SplitContainer
        Me.lblTotal = New System.Windows.Forms.Label
        Me.txtAmtStat = New System.Windows.Forms.Label
        Me.txtTender = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.gpTran = New System.Windows.Forms.GroupBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblZeroRated = New System.Windows.Forms.Label
        Me.labelZeroRate = New System.Windows.Forms.Label
        Me.lblVatExempt = New System.Windows.Forms.Label
        Me.labelVatEx = New System.Windows.Forms.Label
        Me.lblTimeOut = New System.Windows.Forms.Label
        Me.lblTimeIn = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblVtype = New System.Windows.Forms.Label
        Me.lblPlate = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.labelVatSale = New System.Windows.Forms.Label
        Me.lblLostCard = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblDiscount = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.lblVAT = New System.Windows.Forms.Label
        Me.labelVat = New System.Windows.Forms.Label
        Me.lblAmountDue = New System.Windows.Forms.Label
        Me.lblOvernigth = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lblTotalTime = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.ToolTransact = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdDiscount = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.lblORno = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.txtSysMsg = New System.Windows.Forms.ToolStripLabel
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip
        Me.btnEntryVeh = New System.Windows.Forms.ToolStripButton
        Me.cmdBt = New System.Windows.Forms.ToolStripButton
        Me.cmdRR = New System.Windows.Forms.ToolStripButton
        Me.cmdLost = New System.Windows.Forms.ToolStripButton
        Me.cmdManualLost = New System.Windows.Forms.ToolStripButton
        Me.cmdEditPlate = New System.Windows.Forms.ToolStripButton
        Me.cmdManualTR = New System.Windows.Forms.ToolStripButton
        Me.cmdLO = New System.Windows.Forms.ToolStripButton
        Me.txtBarcode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.DriverImage = New System.Windows.Forms.PictureBox
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.txtBussDate = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtMODE = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel
        Me.txtTimer = New System.Windows.Forms.ToolStripLabel
        Me.txtTime = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel5 = New System.Windows.Forms.ToolStripLabel
        Me.txtStation = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripLabel4 = New System.Windows.Forms.ToolStripLabel
        Me.lblTrial = New System.Windows.Forms.ToolStripLabel
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.bgwCtrler = New System.ComponentModel.BackgroundWorker
        Me.bgwServerPush = New System.ComponentModel.BackgroundWorker
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer7.Panel1.SuspendLayout()
        Me.SplitContainer7.Panel2.SuspendLayout()
        Me.SplitContainer7.SuspendLayout()
        CType(Me.InPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CamEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.SplitContainer8.Panel1.SuspendLayout()
        Me.SplitContainer8.Panel2.SuspendLayout()
        Me.SplitContainer8.SuspendLayout()
        Me.gpTran.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ToolTransact.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip3.SuspendLayout()
        CType(Me.DriverImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmeTime
        '
        Me.tmeTime.Enabled = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel1.Text = " "
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Silver
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtPosi, Me.TxtOp, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4, Me.txtDbStat, Me.ToolStripStatusLabel7, Me.ToolStripStatusLabel11, Me.dbstat2, Me.ToolStripStatusLabel17, Me.ToolStripStatusLabel12, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.txtTotalSlot, Me.ToolStripStatusLabel13, Me.ToolStripStatusLabel14, Me.txtSlot, Me.ToolStripStatusLabel16, Me.txtUsername, Me.txtStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 724)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1094, 37)
        Me.StatusStrip1.TabIndex = 500
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtPosi
        '
        Me.txtPosi.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosi.ForeColor = System.Drawing.Color.Black
        Me.txtPosi.Image = CType(resources.GetObject("txtPosi.Image"), System.Drawing.Image)
        Me.txtPosi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtPosi.Name = "txtPosi"
        Me.txtPosi.Size = New System.Drawing.Size(104, 32)
        Me.txtPosi.Text = "System :"
        '
        'TxtOp
        '
        Me.TxtOp.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOp.ForeColor = System.Drawing.Color.Teal
        Me.TxtOp.Name = "TxtOp"
        Me.TxtOp.Size = New System.Drawing.Size(61, 32)
        Me.TxtOp.Text = "Locked"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(14, 32)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel4.Image = CType(resources.GetObject("ToolStripStatusLabel4.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(100, 32)
        Me.ToolStripStatusLabel4.Text = "Server :"
        '
        'txtDbStat
        '
        Me.txtDbStat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDbStat.ForeColor = System.Drawing.Color.Red
        Me.txtDbStat.Name = "txtDbStat"
        Me.txtDbStat.Size = New System.Drawing.Size(108, 32)
        Me.txtDbStat.Text = "Disconnected"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(14, 32)
        Me.ToolStripStatusLabel7.Text = "|"
        '
        'ToolStripStatusLabel11
        '
        Me.ToolStripStatusLabel11.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel11.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel11.Image = CType(resources.GetObject("ToolStripStatusLabel11.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel11.Name = "ToolStripStatusLabel11"
        Me.ToolStripStatusLabel11.Size = New System.Drawing.Size(121, 32)
        Me.ToolStripStatusLabel11.Text = "Localhost :"
        '
        'dbstat2
        '
        Me.dbstat2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbstat2.ForeColor = System.Drawing.Color.Red
        Me.dbstat2.Name = "dbstat2"
        Me.dbstat2.Size = New System.Drawing.Size(108, 32)
        Me.dbstat2.Text = "Disconnected"
        '
        'ToolStripStatusLabel17
        '
        Me.ToolStripStatusLabel17.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel17.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabel17.Name = "ToolStripStatusLabel17"
        Me.ToolStripStatusLabel17.Size = New System.Drawing.Size(12, 32)
        Me.ToolStripStatusLabel17.Text = " "
        '
        'ToolStripStatusLabel12
        '
        Me.ToolStripStatusLabel12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel12.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel12.Name = "ToolStripStatusLabel12"
        Me.ToolStripStatusLabel12.Size = New System.Drawing.Size(14, 32)
        Me.ToolStripStatusLabel12.Text = "|"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(12, 32)
        Me.ToolStripStatusLabel2.Text = " "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.RightToLeftAutoMirrorImage = True
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(89, 32)
        Me.ToolStripStatusLabel3.Text = "Total Slot :"
        '
        'txtTotalSlot
        '
        Me.txtTotalSlot.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalSlot.Name = "txtTotalSlot"
        Me.txtTotalSlot.Size = New System.Drawing.Size(18, 32)
        Me.txtTotalSlot.Text = "0"
        '
        'ToolStripStatusLabel13
        '
        Me.ToolStripStatusLabel13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel13.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabel13.Name = "ToolStripStatusLabel13"
        Me.ToolStripStatusLabel13.Size = New System.Drawing.Size(12, 32)
        Me.ToolStripStatusLabel13.Text = " "
        '
        'ToolStripStatusLabel14
        '
        Me.ToolStripStatusLabel14.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel14.ForeColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabel14.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel14.Name = "ToolStripStatusLabel14"
        Me.ToolStripStatusLabel14.Size = New System.Drawing.Size(121, 32)
        Me.ToolStripStatusLabel14.Text = "Available Slot :"
        '
        'txtSlot
        '
        Me.txtSlot.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSlot.Name = "txtSlot"
        Me.txtSlot.Size = New System.Drawing.Size(18, 32)
        Me.txtSlot.Text = "0"
        '
        'ToolStripStatusLabel16
        '
        Me.ToolStripStatusLabel16.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel16.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabel16.Name = "ToolStripStatusLabel16"
        Me.ToolStripStatusLabel16.Size = New System.Drawing.Size(12, 32)
        Me.ToolStripStatusLabel16.Text = " "
        '
        'txtUsername
        '
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(60, 32)
        Me.txtUsername.Text = "Username"
        Me.txtUsername.Visible = False
        '
        'txtStatus
        '
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(76, 32)
        Me.txtStatus.Text = "VehicleStatus"
        Me.txtStatus.Visible = False
        '
        'TmrRead
        '
        Me.TmrRead.Enabled = True
        Me.TmrRead.Interval = 30000
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer7)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer2.Size = New System.Drawing.Size(1094, 640)
        Me.SplitContainer2.SplitterDistance = 445
        Me.SplitContainer2.TabIndex = 502
        '
        'SplitContainer7
        '
        Me.SplitContainer7.BackColor = System.Drawing.Color.White
        Me.SplitContainer7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer7.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer7.Name = "SplitContainer7"
        Me.SplitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer7.Panel1
        '
        Me.SplitContainer7.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer7.Panel1.Controls.Add(Me.Label13)
        Me.SplitContainer7.Panel1.Controls.Add(Me.InPic)
        '
        'SplitContainer7.Panel2
        '
        Me.SplitContainer7.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer7.Panel2.Controls.Add(Me.CamEntry)
        Me.SplitContainer7.Panel2.Controls.Add(Me.Label17)
        Me.SplitContainer7.Size = New System.Drawing.Size(445, 640)
        Me.SplitContainer7.SplitterDistance = 317
        Me.SplitContainer7.TabIndex = 502
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(4, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(97, 18)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Entry Image"
        '
        'InPic
        '
        Me.InPic.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InPic.BackColor = System.Drawing.Color.Black
        Me.InPic.Location = New System.Drawing.Point(5, 22)
        Me.InPic.Name = "InPic"
        Me.InPic.Size = New System.Drawing.Size(433, 287)
        Me.InPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.InPic.TabIndex = 13
        Me.InPic.TabStop = False
        '
        'CamEntry
        '
        Me.CamEntry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CamEntry.Enabled = True
        Me.CamEntry.Location = New System.Drawing.Point(5, 24)
        Me.CamEntry.Name = "CamEntry"
        Me.CamEntry.OcxState = CType(resources.GetObject("CamEntry.OcxState"), System.Windows.Forms.AxHost.State)
        Me.CamEntry.Size = New System.Drawing.Size(433, 287)
        Me.CamEntry.TabIndex = 104
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(4, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 18)
        Me.Label17.TabIndex = 103
        Me.Label17.Text = "Exit Image"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer6)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
        Me.SplitContainer3.Size = New System.Drawing.Size(645, 640)
        Me.SplitContainer3.SplitterDistance = 338
        Me.SplitContainer3.TabIndex = 503
        '
        'SplitContainer6
        '
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.Controls.Add(Me.SplitContainer8)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.Controls.Add(Me.gpTran)
        Me.SplitContainer6.Size = New System.Drawing.Size(643, 336)
        Me.SplitContainer6.SplitterDistance = 84
        Me.SplitContainer6.TabIndex = 0
        '
        'SplitContainer8
        '
        Me.SplitContainer8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer8.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer8.Name = "SplitContainer8"
        '
        'SplitContainer8.Panel1
        '
        Me.SplitContainer8.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer8.Panel1.Controls.Add(Me.lblTotal)
        Me.SplitContainer8.Panel1.Controls.Add(Me.txtAmtStat)
        '
        'SplitContainer8.Panel2
        '
        Me.SplitContainer8.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer8.Panel2.Controls.Add(Me.txtTender)
        Me.SplitContainer8.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer8.Size = New System.Drawing.Size(643, 84)
        Me.SplitContainer8.SplitterDistance = 319
        Me.SplitContainer8.TabIndex = 0
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(1, 21)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(315, 64)
        Me.lblTotal.TabIndex = 35
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAmtStat
        '
        Me.txtAmtStat.AutoSize = True
        Me.txtAmtStat.BackColor = System.Drawing.Color.White
        Me.txtAmtStat.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmtStat.ForeColor = System.Drawing.Color.Black
        Me.txtAmtStat.Location = New System.Drawing.Point(2, 0)
        Me.txtAmtStat.Name = "txtAmtStat"
        Me.txtAmtStat.Size = New System.Drawing.Size(158, 19)
        Me.txtAmtStat.TabIndex = 14
        Me.txtAmtStat.Text = " TOTAL AMOUNT :"
        '
        'txtTender
        '
        Me.txtTender.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTender.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTender.Location = New System.Drawing.Point(2, 21)
        Me.txtTender.Name = "txtTender"
        Me.txtTender.Size = New System.Drawing.Size(317, 65)
        Me.txtTender.TabIndex = 0
        Me.txtTender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 1)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(165, 19)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "TENDER AMOUNT :"
        '
        'gpTran
        '
        Me.gpTran.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gpTran.Controls.Add(Me.Panel1)
        Me.gpTran.Controls.Add(Me.ToolTransact)
        Me.gpTran.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpTran.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpTran.ForeColor = System.Drawing.Color.White
        Me.gpTran.Location = New System.Drawing.Point(0, 0)
        Me.gpTran.Name = "gpTran"
        Me.gpTran.Size = New System.Drawing.Size(643, 248)
        Me.gpTran.TabIndex = 903
        Me.gpTran.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lblZeroRated)
        Me.Panel1.Controls.Add(Me.labelZeroRate)
        Me.Panel1.Controls.Add(Me.lblVatExempt)
        Me.Panel1.Controls.Add(Me.labelVatEx)
        Me.Panel1.Controls.Add(Me.lblTimeOut)
        Me.Panel1.Controls.Add(Me.lblTimeIn)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lblVtype)
        Me.Panel1.Controls.Add(Me.lblPlate)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lblSubTotal)
        Me.Panel1.Controls.Add(Me.labelVatSale)
        Me.Panel1.Controls.Add(Me.lblLostCard)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.lblDiscount)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.lblVAT)
        Me.Panel1.Controls.Add(Me.labelVat)
        Me.Panel1.Controls.Add(Me.lblAmountDue)
        Me.Panel1.Controls.Add(Me.lblOvernigth)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblTotalTime)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 202)
        Me.Panel1.TabIndex = 25
        '
        'lblZeroRated
        '
        Me.lblZeroRated.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblZeroRated.AutoSize = True
        Me.lblZeroRated.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblZeroRated.ForeColor = System.Drawing.Color.Lime
        Me.lblZeroRated.Location = New System.Drawing.Point(520, 145)
        Me.lblZeroRated.Name = "lblZeroRated"
        Me.lblZeroRated.Size = New System.Drawing.Size(44, 20)
        Me.lblZeroRated.TabIndex = 60
        Me.lblZeroRated.Text = "0.00"
        '
        'labelZeroRate
        '
        Me.labelZeroRate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelZeroRate.AutoSize = True
        Me.labelZeroRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelZeroRate.Location = New System.Drawing.Point(363, 145)
        Me.labelZeroRate.Name = "labelZeroRate"
        Me.labelZeroRate.Size = New System.Drawing.Size(151, 20)
        Me.labelZeroRate.TabIndex = 59
        Me.labelZeroRate.Text = "Zero Rated Sale :"
        '
        'lblVatExempt
        '
        Me.lblVatExempt.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVatExempt.AutoSize = True
        Me.lblVatExempt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVatExempt.ForeColor = System.Drawing.Color.Lime
        Me.lblVatExempt.Location = New System.Drawing.Point(520, 116)
        Me.lblVatExempt.Name = "lblVatExempt"
        Me.lblVatExempt.Size = New System.Drawing.Size(44, 20)
        Me.lblVatExempt.TabIndex = 58
        Me.lblVatExempt.Text = "0.00"
        '
        'labelVatEx
        '
        Me.labelVatEx.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelVatEx.AutoSize = True
        Me.labelVatEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVatEx.Location = New System.Drawing.Point(361, 116)
        Me.labelVatEx.Name = "labelVatEx"
        Me.labelVatEx.Size = New System.Drawing.Size(153, 20)
        Me.labelVatEx.TabIndex = 57
        Me.labelVatEx.Text = "Vat Exempt Sale :"
        '
        'lblTimeOut
        '
        Me.lblTimeOut.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTimeOut.AutoSize = True
        Me.lblTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeOut.ForeColor = System.Drawing.Color.Lime
        Me.lblTimeOut.Location = New System.Drawing.Point(166, 89)
        Me.lblTimeOut.Name = "lblTimeOut"
        Me.lblTimeOut.Size = New System.Drawing.Size(21, 20)
        Me.lblTimeOut.TabIndex = 56
        Me.lblTimeOut.Text = "--"
        '
        'lblTimeIn
        '
        Me.lblTimeIn.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTimeIn.AutoSize = True
        Me.lblTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeIn.ForeColor = System.Drawing.Color.Lime
        Me.lblTimeIn.Location = New System.Drawing.Point(166, 62)
        Me.lblTimeIn.Name = "lblTimeIn"
        Me.lblTimeIn.Size = New System.Drawing.Size(21, 20)
        Me.lblTimeIn.TabIndex = 55
        Me.lblTimeIn.Text = "--"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(69, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 20)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "Time Out :"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(83, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Time In :"
        '
        'lblVtype
        '
        Me.lblVtype.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVtype.AutoSize = True
        Me.lblVtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVtype.ForeColor = System.Drawing.Color.Lime
        Me.lblVtype.Location = New System.Drawing.Point(166, 35)
        Me.lblVtype.Name = "lblVtype"
        Me.lblVtype.Size = New System.Drawing.Size(21, 20)
        Me.lblVtype.TabIndex = 52
        Me.lblVtype.Text = "--"
        '
        'lblPlate
        '
        Me.lblPlate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblPlate.AutoSize = True
        Me.lblPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlate.ForeColor = System.Drawing.Color.Lime
        Me.lblPlate.Location = New System.Drawing.Point(166, 8)
        Me.lblPlate.Name = "lblPlate"
        Me.lblPlate.Size = New System.Drawing.Size(21, 20)
        Me.lblPlate.TabIndex = 51
        Me.lblPlate.Text = "--"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Vehicle :"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(69, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Plate No. :"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.ForeColor = System.Drawing.Color.Lime
        Me.lblSubTotal.Location = New System.Drawing.Point(520, 62)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(44, 20)
        Me.lblSubTotal.TabIndex = 48
        Me.lblSubTotal.Text = "0.00"
        '
        'labelVatSale
        '
        Me.labelVatSale.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelVatSale.AutoSize = True
        Me.labelVatSale.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVatSale.Location = New System.Drawing.Point(426, 62)
        Me.labelVatSale.Name = "labelVatSale"
        Me.labelVatSale.Size = New System.Drawing.Size(88, 20)
        Me.labelVatSale.TabIndex = 47
        Me.labelVatSale.Text = "Vat Sale :"
        '
        'lblLostCard
        '
        Me.lblLostCard.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLostCard.AutoSize = True
        Me.lblLostCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLostCard.ForeColor = System.Drawing.Color.Lime
        Me.lblLostCard.Location = New System.Drawing.Point(520, 9)
        Me.lblLostCard.Name = "lblLostCard"
        Me.lblLostCard.Size = New System.Drawing.Size(44, 20)
        Me.lblLostCard.TabIndex = 46
        Me.lblLostCard.Text = "0.00"
        '
        'Label26
        '
        Me.Label26.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(417, 8)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(97, 20)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Lost Card :"
        '
        'lblDiscount
        '
        Me.lblDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.Lime
        Me.lblDiscount.Location = New System.Drawing.Point(520, 35)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(44, 20)
        Me.lblDiscount.TabIndex = 44
        Me.lblDiscount.Text = "0.00"
        '
        'Label24
        '
        Me.Label24.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(424, 35)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(90, 20)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Discount :"
        '
        'lblVAT
        '
        Me.lblVAT.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblVAT.AutoSize = True
        Me.lblVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVAT.ForeColor = System.Drawing.Color.Lime
        Me.lblVAT.Location = New System.Drawing.Point(520, 89)
        Me.lblVAT.Name = "lblVAT"
        Me.lblVAT.Size = New System.Drawing.Size(44, 20)
        Me.lblVAT.TabIndex = 42
        Me.lblVAT.Text = "0.00"
        '
        'labelVat
        '
        Me.labelVat.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.labelVat.AutoSize = True
        Me.labelVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelVat.Location = New System.Drawing.Point(467, 89)
        Me.labelVat.Name = "labelVat"
        Me.labelVat.Size = New System.Drawing.Size(47, 20)
        Me.labelVat.TabIndex = 41
        Me.labelVat.Text = "Vat :"
        '
        'lblAmountDue
        '
        Me.lblAmountDue.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblAmountDue.AutoSize = True
        Me.lblAmountDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountDue.ForeColor = System.Drawing.Color.Lime
        Me.lblAmountDue.Location = New System.Drawing.Point(166, 145)
        Me.lblAmountDue.Name = "lblAmountDue"
        Me.lblAmountDue.Size = New System.Drawing.Size(44, 20)
        Me.lblAmountDue.TabIndex = 40
        Me.lblAmountDue.Text = "0.00"
        '
        'lblOvernigth
        '
        Me.lblOvernigth.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblOvernigth.AutoSize = True
        Me.lblOvernigth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOvernigth.ForeColor = System.Drawing.Color.Lime
        Me.lblOvernigth.Location = New System.Drawing.Point(166, 171)
        Me.lblOvernigth.Name = "lblOvernigth"
        Me.lblOvernigth.Size = New System.Drawing.Size(44, 20)
        Me.lblOvernigth.TabIndex = 39
        Me.lblOvernigth.Text = "0.00"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 170)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(134, 20)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Overnight Due :"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(40, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Regular Due :"
        '
        'lblTotalTime
        '
        Me.lblTotalTime.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTotalTime.AutoSize = True
        Me.lblTotalTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime.ForeColor = System.Drawing.Color.Lime
        Me.lblTotalTime.Location = New System.Drawing.Point(166, 118)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(135, 20)
        Me.lblTotalTime.TabIndex = 36
        Me.lblTotalTime.Text = "0 Hr and 0 Mins"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Total Time :"
        '
        'ToolTransact
        '
        Me.ToolTransact.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolTransact.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolTransact.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolTransact.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator4, Me.cmdCancel, Me.ToolStripSeparator1, Me.cmdDiscount, Me.ToolStripSeparator5, Me.lblORno, Me.ToolStripLabel2, Me.ToolStripSeparator2, Me.txtSysMsg})
        Me.ToolTransact.Location = New System.Drawing.Point(3, 206)
        Me.ToolTransact.Name = "ToolTransact"
        Me.ToolTransact.Size = New System.Drawing.Size(637, 39)
        Me.ToolTransact.TabIndex = 24
        Me.ToolTransact.Text = "ToolStrip1"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'cmdCancel
        '
        Me.cmdCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdCancel.BackColor = System.Drawing.Color.Transparent
        Me.cmdCancel.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.ForeColor = System.Drawing.Color.Black
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(94, 36)
        Me.cmdCancel.Text = "&Cancel"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDiscount
        '
        Me.cmdDiscount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.cmdDiscount.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDiscount.ForeColor = System.Drawing.Color.Black
        Me.cmdDiscount.Image = CType(resources.GetObject("cmdDiscount.Image"), System.Drawing.Image)
        Me.cmdDiscount.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDiscount.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDiscount.Name = "cmdDiscount"
        Me.cmdDiscount.Size = New System.Drawing.Size(109, 36)
        Me.cmdDiscount.Text = "&Discount"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'lblORno
        '
        Me.lblORno.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.lblORno.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblORno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblORno.Name = "lblORno"
        Me.lblORno.Size = New System.Drawing.Size(94, 36)
        Me.lblORno.Text = "28-000003"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.Color.Black
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(107, 36)
        Me.ToolStripLabel2.Text = " OR Number :"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'txtSysMsg
        '
        Me.txtSysMsg.ForeColor = System.Drawing.Color.Maroon
        Me.txtSysMsg.Image = CType(resources.GetObject("txtSysMsg.Image"), System.Drawing.Image)
        Me.txtSysMsg.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtSysMsg.Name = "txtSysMsg"
        Me.txtSysMsg.Size = New System.Drawing.Size(54, 36)
        Me.txtSysMsg.Text = "---"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer4.Panel1.Controls.Add(Me.Panel2)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SplitContainer4.Panel2.Controls.Add(Me.txtBarcode)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer4.Panel2.Controls.Add(Me.DriverImage)
        Me.SplitContainer4.Size = New System.Drawing.Size(643, 296)
        Me.SplitContainer4.SplitterDistance = 325
        Me.SplitContainer4.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.ToolStrip3)
        Me.Panel2.Location = New System.Drawing.Point(6, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(313, 283)
        Me.Panel2.TabIndex = 4
        '
        'ToolStrip3
        '
        Me.ToolStrip3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEntryVeh, Me.cmdBt, Me.cmdRR, Me.cmdLost, Me.cmdManualLost, Me.cmdEditPlate, Me.cmdManualTR, Me.cmdLO})
        Me.ToolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(313, 275)
        Me.ToolStrip3.TabIndex = 3
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'btnEntryVeh
        '
        Me.btnEntryVeh.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnEntryVeh.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEntryVeh.ForeColor = System.Drawing.Color.Black
        Me.btnEntryVeh.Image = CType(resources.GetObject("btnEntryVeh.Image"), System.Drawing.Image)
        Me.btnEntryVeh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntryVeh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnEntryVeh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEntryVeh.Name = "btnEntryVeh"
        Me.btnEntryVeh.Size = New System.Drawing.Size(311, 36)
        Me.btnEntryVeh.Text = "(Crtl + E) Entry Vehicle"
        Me.btnEntryVeh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdBt
        '
        Me.cmdBt.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdBt.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBt.ForeColor = System.Drawing.Color.Black
        Me.cmdBt.Image = CType(resources.GetObject("cmdBt.Image"), System.Drawing.Image)
        Me.cmdBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBt.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdBt.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdBt.Name = "cmdBt"
        Me.cmdBt.Size = New System.Drawing.Size(311, 36)
        Me.cmdBt.Text = "(F1) Begin Transaction"
        Me.cmdBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdRR
        '
        Me.cmdRR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdRR.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRR.ForeColor = System.Drawing.Color.Black
        Me.cmdRR.Image = CType(resources.GetObject("cmdRR.Image"), System.Drawing.Image)
        Me.cmdRR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdRR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRR.Name = "cmdRR"
        Me.cmdRR.Size = New System.Drawing.Size(311, 36)
        Me.cmdRR.Text = "(F2) Reprint Last OR"
        '
        'cmdLost
        '
        Me.cmdLost.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdLost.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLost.ForeColor = System.Drawing.Color.Black
        Me.cmdLost.Image = CType(resources.GetObject("cmdLost.Image"), System.Drawing.Image)
        Me.cmdLost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdLost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLost.Name = "cmdLost"
        Me.cmdLost.Size = New System.Drawing.Size(311, 36)
        Me.cmdLost.Text = "(F3) Lost Card"
        '
        'cmdManualLost
        '
        Me.cmdManualLost.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdManualLost.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdManualLost.ForeColor = System.Drawing.Color.Black
        Me.cmdManualLost.Image = CType(resources.GetObject("cmdManualLost.Image"), System.Drawing.Image)
        Me.cmdManualLost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdManualLost.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdManualLost.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdManualLost.Name = "cmdManualLost"
        Me.cmdManualLost.Size = New System.Drawing.Size(311, 36)
        Me.cmdManualLost.Text = "(F4) Manual Lost Card"
        Me.cmdManualLost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdEditPlate
        '
        Me.cmdEditPlate.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdEditPlate.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditPlate.ForeColor = System.Drawing.Color.Black
        Me.cmdEditPlate.Image = CType(resources.GetObject("cmdEditPlate.Image"), System.Drawing.Image)
        Me.cmdEditPlate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEditPlate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEditPlate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditPlate.Name = "cmdEditPlate"
        Me.cmdEditPlate.Size = New System.Drawing.Size(311, 36)
        Me.cmdEditPlate.Text = "(F5) Edit Plate"
        Me.cmdEditPlate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEditPlate.ToolTipText = "(F6) Edit Plate"
        '
        'cmdManualTR
        '
        Me.cmdManualTR.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdManualTR.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdManualTR.ForeColor = System.Drawing.Color.Black
        Me.cmdManualTR.Image = CType(resources.GetObject("cmdManualTR.Image"), System.Drawing.Image)
        Me.cmdManualTR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdManualTR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdManualTR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdManualTR.Name = "cmdManualTR"
        Me.cmdManualTR.Size = New System.Drawing.Size(311, 36)
        Me.cmdManualTR.Text = "(F6) Manual Transaction"
        Me.cmdManualTR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdManualTR.ToolTipText = "(F7) Manual Transaction"
        Me.cmdManualTR.Visible = False
        '
        'cmdLO
        '
        Me.cmdLO.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cmdLO.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdLO.ForeColor = System.Drawing.Color.Black
        Me.cmdLO.Image = CType(resources.GetObject("cmdLO.Image"), System.Drawing.Image)
        Me.cmdLO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdLO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdLO.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdLO.Name = "cmdLO"
        Me.cmdLO.Size = New System.Drawing.Size(311, 36)
        Me.cmdLO.Text = "(Esc) Logout"
        '
        'txtBarcode
        '
        Me.txtBarcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBarcode.Enabled = False
        Me.txtBarcode.Location = New System.Drawing.Point(5, 270)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(304, 20)
        Me.txtBarcode.TabIndex = 105
        Me.txtBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(4, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 18)
        Me.Label9.TabIndex = 104
        Me.Label9.Text = "Entry Driver Image"
        '
        'DriverImage
        '
        Me.DriverImage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DriverImage.BackColor = System.Drawing.Color.Black
        Me.DriverImage.Location = New System.Drawing.Point(5, 22)
        Me.DriverImage.Name = "DriverImage"
        Me.DriverImage.Size = New System.Drawing.Size(304, 244)
        Me.DriverImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DriverImage.TabIndex = 29
        Me.DriverImage.TabStop = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.Gray
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtBussDate)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtMODE)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label12)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1094, 724)
        Me.SplitContainer1.SplitterDistance = 80
        Me.SplitContainer1.TabIndex = 503
        '
        'txtBussDate
        '
        Me.txtBussDate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtBussDate.AutoSize = True
        Me.txtBussDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBussDate.ForeColor = System.Drawing.Color.Yellow
        Me.txtBussDate.Location = New System.Drawing.Point(981, 55)
        Me.txtBussDate.Name = "txtBussDate"
        Me.txtBussDate.Size = New System.Drawing.Size(107, 20)
        Me.txtBussDate.TabIndex = 35
        Me.txtBussDate.Text = "DD-mm-yyyy"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(849, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Business Date :"
        '
        'txtMODE
        '
        Me.txtMODE.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtMODE.AutoSize = True
        Me.txtMODE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMODE.ForeColor = System.Drawing.Color.Lime
        Me.txtMODE.Location = New System.Drawing.Point(65, 55)
        Me.txtMODE.Name = "txtMODE"
        Me.txtMODE.Size = New System.Drawing.Size(104, 20)
        Me.txtMODE.TabIndex = 33
        Me.txtMODE.Text = "FLAT RATE"
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(5, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(63, 20)
        Me.Label12.TabIndex = 32
        Me.Label12.Text = "Mode :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripLabel3, Me.txtTimer, Me.txtTime, Me.ToolStripLabel5, Me.txtStation, Me.ToolStripLabel4, Me.lblTrial})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1094, 51)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(10, 48)
        Me.ToolStripLabel1.Text = " "
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Image = CType(resources.GetObject("ToolStripLabel3.Image"), System.Drawing.Image)
        Me.ToolStripLabel3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(465, 48)
        Me.ToolStripLabel3.Text = "CAR PARK POINT-OF-SALE SYSTEM"
        '
        'txtTimer
        '
        Me.txtTimer.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTimer.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimer.Image = CType(resources.GetObject("txtTimer.Image"), System.Drawing.Image)
        Me.txtTimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(96, 48)
        Me.txtTimer.Text = "Time"
        '
        'txtTime
        '
        Me.txtTime.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtTime.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Image = CType(resources.GetObject("txtTime.Image"), System.Drawing.Image)
        Me.txtTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(94, 48)
        Me.txtTime.Text = "Date"
        '
        'ToolStripLabel5
        '
        Me.ToolStripLabel5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel5.Name = "ToolStripLabel5"
        Me.ToolStripLabel5.Size = New System.Drawing.Size(10, 48)
        Me.ToolStripLabel5.Text = " "
        '
        'txtStation
        '
        Me.txtStation.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.txtStation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStation.Image = CType(resources.GetObject("txtStation.Image"), System.Drawing.Image)
        Me.txtStation.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(113, 48)
        Me.txtStation.Text = "Station"
        '
        'ToolStripLabel4
        '
        Me.ToolStripLabel4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel4.Name = "ToolStripLabel4"
        Me.ToolStripLabel4.Size = New System.Drawing.Size(10, 48)
        Me.ToolStripLabel4.Text = " "
        '
        'lblTrial
        '
        Me.lblTrial.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTrial.Image = CType(resources.GetObject("lblTrial.Image"), System.Drawing.Image)
        Me.lblTrial.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.lblTrial.Name = "lblTrial"
        Me.lblTrial.Size = New System.Drawing.Size(255, 48)
        Me.lblTrial.Text = " Trial - 30 Days Remaining"
        Me.lblTrial.Visible = False
        '
        'bgwCtrler
        '
        '
        'bgwServerPush
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1094, 761)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer7.Panel1.ResumeLayout(False)
        Me.SplitContainer7.Panel1.PerformLayout()
        Me.SplitContainer7.Panel2.ResumeLayout(False)
        Me.SplitContainer7.Panel2.PerformLayout()
        Me.SplitContainer7.ResumeLayout(False)
        CType(Me.InPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CamEntry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.ResumeLayout(False)
        Me.SplitContainer8.Panel1.ResumeLayout(False)
        Me.SplitContainer8.Panel1.PerformLayout()
        Me.SplitContainer8.Panel2.ResumeLayout(False)
        Me.SplitContainer8.Panel2.PerformLayout()
        Me.SplitContainer8.ResumeLayout(False)
        Me.gpTran.ResumeLayout(False)
        Me.gpTran.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolTransact.ResumeLayout(False)
        Me.ToolTransact.PerformLayout()
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        Me.SplitContainer4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        CType(Me.DriverImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmeTime As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDbStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TmrRead As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel11 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dbstat2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer7 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents InPic As System.Windows.Forms.PictureBox
    Friend WithEvents CamEntry As AxNETVIDEOACTIVEXLib.AxNetVideoActiveX
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip3 As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdBt As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRR As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdLost As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEditPlate As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdLO As System.Windows.Forms.ToolStripButton
    Friend WithEvents DriverImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPosi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TxtOp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTotalSlot As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel14 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtSlot As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel16 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel17 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel12 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel13 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtUsername As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents cmdManualLost As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdManualTR As System.Windows.Forms.ToolStripButton
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer8 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtAmtStat As System.Windows.Forms.Label
    Friend WithEvents txtTender As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gpTran As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTransact As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents lblORno As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDiscount As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblTimeOut As System.Windows.Forms.Label
    Friend WithEvents lblTimeIn As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblVtype As System.Windows.Forms.Label
    Friend WithEvents lblPlate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents labelVatSale As System.Windows.Forms.Label
    Friend WithEvents lblLostCard As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblVAT As System.Windows.Forms.Label
    Friend WithEvents labelVat As System.Windows.Forms.Label
    Friend WithEvents lblAmountDue As System.Windows.Forms.Label
    Friend WithEvents lblOvernigth As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTime As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel3 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtTimer As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel5 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtStation As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripLabel4 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtMODE As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBussDate As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtBarcode As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblZeroRated As System.Windows.Forms.Label
    Friend WithEvents labelZeroRate As System.Windows.Forms.Label
    Friend WithEvents lblVatExempt As System.Windows.Forms.Label
    Friend WithEvents labelVatEx As System.Windows.Forms.Label
    Friend WithEvents btnEntryVeh As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblTrial As System.Windows.Forms.ToolStripLabel
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents txtSysMsg As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bgwCtrler As System.ComponentModel.BackgroundWorker
    Friend WithEvents bgwServerPush As System.ComponentModel.BackgroundWorker

End Class
