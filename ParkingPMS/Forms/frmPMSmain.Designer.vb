<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPMSmain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPMSmain))
        Me.tmeSlot = New System.Windows.Forms.Timer(Me.components)
        Me.Image1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TmrRead = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel8 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel9 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtTimer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.txtDbStat = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmeTime = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrData = New System.Windows.Forms.Timer(Me.components)
        Me.txtPosi = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TxtOp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.ControlPanel = New System.Windows.Forms.Panel()
        Me.menu = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.SystemLogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatabaseSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SocketSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LEDSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParkingSlotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargingRulesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdDbSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.cmdVehicle = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.cmdOvernigth = New System.Windows.Forms.ToolStripButton()
        Me.cmdVatSettings = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmdReports = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickLoadReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickLodByTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PickLoadByDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdbackUp = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator17 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton7 = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer6 = New System.Windows.Forms.SplitContainer()
        Me.POSpanel = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAddPOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdEditPOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDelPOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdUpdateSettingsPOS = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDownload = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdTestPos = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.lstList = New System.Windows.Forms.ListView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DispenserPanel = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdAddD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdeditD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdDelD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmdCommandD = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator16 = New System.Windows.Forms.ToolStripSeparator()
        Me.lstList2 = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Wns_Server = New AxMSWinsockLib.AxWinsock()
        Me.Wns_Local = New AxMSWinsockLib.AxWinsock()
        Me.txtTotalNet = New System.Windows.Forms.Label()
        Me.txtTransaction = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotalSlot = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSlot = New System.Windows.Forms.TextBox()
        Me.Image2 = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.ControlPanel.SuspendLayout()
        Me.menu.SuspendLayout()
        Me.SplitContainer6.Panel1.SuspendLayout()
        Me.SplitContainer6.Panel2.SuspendLayout()
        Me.SplitContainer6.SuspendLayout()
        Me.POSpanel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.DispenserPanel.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Wns_Server, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wns_Local, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmeSlot
        '
        Me.tmeSlot.Interval = 1
        '
        'Image1
        '
        Me.Image1.ImageStream = CType(resources.GetObject("Image1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image1.TransparentColor = System.Drawing.Color.Transparent
        Me.Image1.Images.SetKeyName(0, "exit.ico")
        Me.Image1.Images.SetKeyName(1, "monitor_vista.png")
        '
        'TmrRead
        '
        Me.TmrRead.Interval = 300
        '
        'SplitContainer5
        '
        Me.SplitContainer5.BackColor = System.Drawing.Color.Navy
        Me.SplitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.BackColor = System.Drawing.Color.Navy
        Me.SplitContainer5.Panel1.Controls.Add(Me.PicLogo)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.StatusStrip2)
        Me.SplitContainer5.Size = New System.Drawing.Size(1092, 63)
        Me.SplitContainer5.SplitterDistance = 519
        Me.SplitContainer5.TabIndex = 503
        '
        'PicLogo
        '
        Me.PicLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(0, 0)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(517, 61)
        Me.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicLogo.TabIndex = 3
        Me.PicLogo.TabStop = False
        '
        'StatusStrip2
        '
        Me.StatusStrip2.BackColor = System.Drawing.Color.Navy
        Me.StatusStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel8, Me.txtTime, Me.ToolStripStatusLabel9, Me.txtTimer})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(567, 61)
        Me.StatusStrip2.TabIndex = 100
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(10, 56)
        Me.ToolStripStatusLabel6.Text = " "
        '
        'ToolStripStatusLabel8
        '
        Me.ToolStripStatusLabel8.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel8.Name = "ToolStripStatusLabel8"
        Me.ToolStripStatusLabel8.Size = New System.Drawing.Size(14, 56)
        Me.ToolStripStatusLabel8.Text = " "
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.ForeColor = System.Drawing.Color.White
        Me.txtTime.Image = CType(resources.GetObject("txtTime.Image"), System.Drawing.Image)
        Me.txtTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(98, 56)
        Me.txtTime.Text = "Date"
        '
        'ToolStripStatusLabel9
        '
        Me.ToolStripStatusLabel9.Font = New System.Drawing.Font("Arial", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel9.Name = "ToolStripStatusLabel9"
        Me.ToolStripStatusLabel9.Size = New System.Drawing.Size(14, 56)
        Me.ToolStripStatusLabel9.Text = " "
        '
        'txtTimer
        '
        Me.txtTimer.BackColor = System.Drawing.Color.Navy
        Me.txtTimer.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimer.ForeColor = System.Drawing.Color.White
        Me.txtTimer.Image = CType(resources.GetObject("txtTimer.Image"), System.Drawing.Image)
        Me.txtTimer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(99, 56)
        Me.txtTimer.Text = "Time"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel7.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(14, 32)
        Me.ToolStripStatusLabel7.Text = "|"
        '
        'txtDbStat
        '
        Me.txtDbStat.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDbStat.ForeColor = System.Drawing.Color.Red
        Me.txtDbStat.Name = "txtDbStat"
        Me.txtDbStat.Size = New System.Drawing.Size(108, 32)
        Me.txtDbStat.Text = "Disconnected"
        '
        'tmeTime
        '
        Me.tmeTime.Enabled = True
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Image = CType(resources.GetObject("ToolStripStatusLabel4.Image"), System.Drawing.Image)
        Me.ToolStripStatusLabel4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(100, 32)
        Me.ToolStripStatusLabel4.Text = "Server :"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 32)
        Me.ToolStripStatusLabel1.Text = " "
        '
        'tmrData
        '
        Me.tmrData.Interval = 50
        '
        'txtPosi
        '
        Me.txtPosi.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosi.ForeColor = System.Drawing.Color.White
        Me.txtPosi.Image = CType(resources.GetObject("txtPosi.Image"), System.Drawing.Image)
        Me.txtPosi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.txtPosi.Name = "txtPosi"
        Me.txtPosi.Size = New System.Drawing.Size(95, 32)
        Me.txtPosi.Text = "Admin :"
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel5.ForeColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(14, 32)
        Me.ToolStripStatusLabel5.Text = "|"
        '
        'TxtOp
        '
        Me.TxtOp.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOp.ForeColor = System.Drawing.Color.DodgerBlue
        Me.TxtOp.Name = "TxtOp"
        Me.TxtOp.Size = New System.Drawing.Size(60, 32)
        Me.TxtOp.Text = "Fernan"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Navy
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.txtPosi, Me.TxtOp, Me.ToolStripStatusLabel5, Me.ToolStripStatusLabel4, Me.txtDbStat, Me.ToolStripStatusLabel7})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 725)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1092, 37)
        Me.StatusStrip1.TabIndex = 504
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 63)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1092, 662)
        Me.SplitContainer1.SplitterDistance = 31
        Me.SplitContainer1.TabIndex = 505
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(48, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(275, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "PARKING MANAGEMENT SYSTEM"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1092, 627)
        Me.SplitContainer2.SplitterDistance = 892
        Me.SplitContainer2.TabIndex = 0
        '
        'SplitContainer3
        '
        Me.SplitContainer3.BackColor = System.Drawing.Color.White
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainer4)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer6)
        Me.SplitContainer3.Size = New System.Drawing.Size(890, 625)
        Me.SplitContainer3.SplitterDistance = 251
        Me.SplitContainer3.TabIndex = 508
        '
        'SplitContainer4
        '
        Me.SplitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.SplitContainer4.Panel1Collapsed = True
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.ControlPanel)
        Me.SplitContainer4.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer4.Size = New System.Drawing.Size(251, 625)
        Me.SplitContainer4.SplitterDistance = 28
        Me.SplitContainer4.TabIndex = 0
        '
        'ControlPanel
        '
        Me.ControlPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlPanel.BackColor = System.Drawing.Color.Navy
        Me.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ControlPanel.Controls.Add(Me.menu)
        Me.ControlPanel.Location = New System.Drawing.Point(9, 30)
        Me.ControlPanel.Name = "ControlPanel"
        Me.ControlPanel.Size = New System.Drawing.Size(231, 583)
        Me.ControlPanel.TabIndex = 14
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.LightSteelBlue
        Me.menu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1, Me.cmdDbSettings, Me.ToolStripSeparator8, Me.ToolStripButton3, Me.cmdVehicle, Me.ToolStripButton5, Me.ToolStripSeparator9, Me.ToolStripButton2, Me.cmdOvernigth, Me.cmdVatSettings, Me.ToolStripButton4, Me.ToolStripSeparator4, Me.CmdReports, Me.ToolStripSeparator3, Me.cmdbackUp, Me.ToolStripSeparator17, Me.ToolStripButton1, Me.ToolStripButton7})
        Me.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(229, 546)
        Me.menu.TabIndex = 4
        Me.menu.Text = "ToolStrip2"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.BackColor = System.Drawing.Color.Navy
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SystemLogoToolStripMenuItem, Me.DatabaseSettingsToolStripMenuItem, Me.SocketSettingsToolStripMenuItem, Me.LEDSettingsToolStripMenuItem})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripDropDownButton1.Image = CType(resources.GetObject("ToolStripDropDownButton1.Image"), System.Drawing.Image)
        Me.ToolStripDropDownButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(227, 36)
        Me.ToolStripDropDownButton1.Text = " Settings"
        '
        'SystemLogoToolStripMenuItem
        '
        Me.SystemLogoToolStripMenuItem.Name = "SystemLogoToolStripMenuItem"
        Me.SystemLogoToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SystemLogoToolStripMenuItem.Text = "System Logo"
        '
        'DatabaseSettingsToolStripMenuItem
        '
        Me.DatabaseSettingsToolStripMenuItem.Name = "DatabaseSettingsToolStripMenuItem"
        Me.DatabaseSettingsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.DatabaseSettingsToolStripMenuItem.Text = "Database Settings"
        '
        'SocketSettingsToolStripMenuItem
        '
        Me.SocketSettingsToolStripMenuItem.Name = "SocketSettingsToolStripMenuItem"
        Me.SocketSettingsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.SocketSettingsToolStripMenuItem.Text = "Socket Settings"
        '
        'LEDSettingsToolStripMenuItem
        '
        Me.LEDSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParkingSlotToolStripMenuItem, Me.ChargingRulesToolStripMenuItem})
        Me.LEDSettingsToolStripMenuItem.Name = "LEDSettingsToolStripMenuItem"
        Me.LEDSettingsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.LEDSettingsToolStripMenuItem.Text = "LED Settings"
        Me.LEDSettingsToolStripMenuItem.Visible = False
        '
        'ParkingSlotToolStripMenuItem
        '
        Me.ParkingSlotToolStripMenuItem.Name = "ParkingSlotToolStripMenuItem"
        Me.ParkingSlotToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ParkingSlotToolStripMenuItem.Text = "Parking Slot LED"
        '
        'ChargingRulesToolStripMenuItem
        '
        Me.ChargingRulesToolStripMenuItem.Name = "ChargingRulesToolStripMenuItem"
        Me.ChargingRulesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ChargingRulesToolStripMenuItem.Text = "Charging Rules LED"
        '
        'cmdDbSettings
        '
        Me.cmdDbSettings.BackColor = System.Drawing.Color.Navy
        Me.cmdDbSettings.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDbSettings.ForeColor = System.Drawing.Color.White
        Me.cmdDbSettings.Image = CType(resources.GetObject("cmdDbSettings.Image"), System.Drawing.Image)
        Me.cmdDbSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdDbSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDbSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDbSettings.Name = "cmdDbSettings"
        Me.cmdDbSettings.Size = New System.Drawing.Size(227, 36)
        Me.cmdDbSettings.Text = " Total Parking Slot"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(227, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Navy
        Me.ToolStripButton3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(227, 36)
        Me.ToolStripButton3.Text = " Account Settings"
        '
        'cmdVehicle
        '
        Me.cmdVehicle.BackColor = System.Drawing.Color.Navy
        Me.cmdVehicle.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVehicle.ForeColor = System.Drawing.Color.White
        Me.cmdVehicle.Image = CType(resources.GetObject("cmdVehicle.Image"), System.Drawing.Image)
        Me.cmdVehicle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVehicle.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdVehicle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVehicle.Name = "cmdVehicle"
        Me.cmdVehicle.Size = New System.Drawing.Size(227, 36)
        Me.cmdVehicle.Text = " Vehicle Category"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.BackColor = System.Drawing.Color.Navy
        Me.ToolStripButton5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(227, 36)
        Me.ToolStripButton5.Text = " VIP Parkers"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(227, 6)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Navy
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(227, 36)
        Me.ToolStripButton2.Text = " Charging Rules"
        '
        'cmdOvernigth
        '
        Me.cmdOvernigth.BackColor = System.Drawing.Color.Navy
        Me.cmdOvernigth.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOvernigth.ForeColor = System.Drawing.Color.White
        Me.cmdOvernigth.Image = CType(resources.GetObject("cmdOvernigth.Image"), System.Drawing.Image)
        Me.cmdOvernigth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdOvernigth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdOvernigth.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdOvernigth.Name = "cmdOvernigth"
        Me.cmdOvernigth.Size = New System.Drawing.Size(227, 36)
        Me.cmdOvernigth.Text = " Overnight Rules"
        '
        'cmdVatSettings
        '
        Me.cmdVatSettings.BackColor = System.Drawing.Color.Navy
        Me.cmdVatSettings.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdVatSettings.ForeColor = System.Drawing.Color.White
        Me.cmdVatSettings.Image = CType(resources.GetObject("cmdVatSettings.Image"), System.Drawing.Image)
        Me.cmdVatSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdVatSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdVatSettings.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdVatSettings.Name = "cmdVatSettings"
        Me.cmdVatSettings.Size = New System.Drawing.Size(227, 36)
        Me.cmdVatSettings.Text = " Vat Settings"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Navy
        Me.ToolStripButton4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(227, 36)
        Me.ToolStripButton4.Text = " Discount Settings"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(227, 6)
        '
        'CmdReports
        '
        Me.CmdReports.BackColor = System.Drawing.Color.Navy
        Me.CmdReports.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.PickLoadReportToolStripMenuItem})
        Me.CmdReports.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdReports.ForeColor = System.Drawing.Color.White
        Me.CmdReports.Image = CType(resources.GetObject("CmdReports.Image"), System.Drawing.Image)
        Me.CmdReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdReports.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdReports.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdReports.Name = "CmdReports"
        Me.CmdReports.Size = New System.Drawing.Size(227, 36)
        Me.CmdReports.Text = " Reports"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(246, 22)
        Me.ToolStripMenuItem1.Text = "Sales Report"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(246, 22)
        Me.ToolStripMenuItem2.Text = "Summary Sales Report"
        '
        'PickLoadReportToolStripMenuItem
        '
        Me.PickLoadReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PickLodByTimeToolStripMenuItem, Me.PickLoadByDateToolStripMenuItem})
        Me.PickLoadReportToolStripMenuItem.Name = "PickLoadReportToolStripMenuItem"
        Me.PickLoadReportToolStripMenuItem.Size = New System.Drawing.Size(246, 22)
        Me.PickLoadReportToolStripMenuItem.Text = "Pick Load Report"
        '
        'PickLodByTimeToolStripMenuItem
        '
        Me.PickLodByTimeToolStripMenuItem.Name = "PickLodByTimeToolStripMenuItem"
        Me.PickLodByTimeToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.PickLodByTimeToolStripMenuItem.Text = "Pick Load By Time"
        '
        'PickLoadByDateToolStripMenuItem
        '
        Me.PickLoadByDateToolStripMenuItem.Name = "PickLoadByDateToolStripMenuItem"
        Me.PickLoadByDateToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.PickLoadByDateToolStripMenuItem.Text = "Pick Load By Date"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(227, 6)
        '
        'cmdbackUp
        '
        Me.cmdbackUp.BackColor = System.Drawing.Color.Navy
        Me.cmdbackUp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.cmdbackUp.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdbackUp.ForeColor = System.Drawing.Color.White
        Me.cmdbackUp.Image = CType(resources.GetObject("cmdbackUp.Image"), System.Drawing.Image)
        Me.cmdbackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdbackUp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdbackUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdbackUp.Name = "cmdbackUp"
        Me.cmdbackUp.Size = New System.Drawing.Size(227, 36)
        Me.cmdbackUp.Text = " System Backup"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem3.Text = "Backup Database"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(209, 22)
        Me.ToolStripMenuItem4.Text = "Restore Database"
        '
        'ToolStripSeparator17
        '
        Me.ToolStripSeparator17.Name = "ToolStripSeparator17"
        Me.ToolStripSeparator17.Size = New System.Drawing.Size(227, 6)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.BackColor = System.Drawing.Color.Navy
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(227, 36)
        Me.ToolStripButton1.Text = " Logout"
        '
        'ToolStripButton7
        '
        Me.ToolStripButton7.BackColor = System.Drawing.Color.Navy
        Me.ToolStripButton7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton7.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton7.Image = CType(resources.GetObject("ToolStripButton7.Image"), System.Drawing.Image)
        Me.ToolStripButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton7.Name = "ToolStripButton7"
        Me.ToolStripButton7.Size = New System.Drawing.Size(227, 36)
        Me.ToolStripButton7.Text = "Terminate System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Control Panel"
        '
        'SplitContainer6
        '
        Me.SplitContainer6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer6.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer6.Name = "SplitContainer6"
        Me.SplitContainer6.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer6.Panel1
        '
        Me.SplitContainer6.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer6.Panel1.Controls.Add(Me.POSpanel)
        Me.SplitContainer6.Panel1.Controls.Add(Me.Label5)
        '
        'SplitContainer6.Panel2
        '
        Me.SplitContainer6.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.SplitContainer6.Panel2.Controls.Add(Me.DispenserPanel)
        Me.SplitContainer6.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer6.Size = New System.Drawing.Size(635, 625)
        Me.SplitContainer6.SplitterDistance = 314
        Me.SplitContainer6.TabIndex = 0
        '
        'POSpanel
        '
        Me.POSpanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.POSpanel.BackColor = System.Drawing.Color.Navy
        Me.POSpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.POSpanel.Controls.Add(Me.ToolStrip1)
        Me.POSpanel.Controls.Add(Me.lstList)
        Me.POSpanel.Location = New System.Drawing.Point(5, 24)
        Me.POSpanel.Name = "POSpanel"
        Me.POSpanel.Size = New System.Drawing.Size(623, 281)
        Me.POSpanel.TabIndex = 11
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmdAddPOS, Me.ToolStripSeparator5, Me.cmdEditPOS, Me.ToolStripSeparator6, Me.cmdDelPOS, Me.ToolStripSeparator7, Me.cmdUpdateSettingsPOS, Me.ToolStripSeparator2, Me.cmdDownload, Me.ToolStripSeparator10, Me.cmdTestPos, Me.ToolStripSeparator11})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(621, 39)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAddPOS
        '
        Me.cmdAddPOS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddPOS.Image = CType(resources.GetObject("cmdAddPOS.Image"), System.Drawing.Image)
        Me.cmdAddPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAddPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAddPOS.Name = "cmdAddPOS"
        Me.cmdAddPOS.Size = New System.Drawing.Size(70, 36)
        Me.cmdAddPOS.Text = "Add"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'cmdEditPOS
        '
        Me.cmdEditPOS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEditPOS.Image = CType(resources.GetObject("cmdEditPOS.Image"), System.Drawing.Image)
        Me.cmdEditPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdEditPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEditPOS.Name = "cmdEditPOS"
        Me.cmdEditPOS.Size = New System.Drawing.Size(68, 36)
        Me.cmdEditPOS.Text = "Edit"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDelPOS
        '
        Me.cmdDelPOS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelPOS.Image = CType(resources.GetObject("cmdDelPOS.Image"), System.Drawing.Image)
        Me.cmdDelPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDelPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelPOS.Name = "cmdDelPOS"
        Me.cmdDelPOS.Size = New System.Drawing.Size(86, 36)
        Me.cmdDelPOS.Text = "Delete"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 39)
        '
        'cmdUpdateSettingsPOS
        '
        Me.cmdUpdateSettingsPOS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUpdateSettingsPOS.Image = CType(resources.GetObject("cmdUpdateSettingsPOS.Image"), System.Drawing.Image)
        Me.cmdUpdateSettingsPOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdUpdateSettingsPOS.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdUpdateSettingsPOS.Name = "cmdUpdateSettingsPOS"
        Me.cmdUpdateSettingsPOS.Size = New System.Drawing.Size(200, 36)
        Me.cmdUpdateSettingsPOS.Text = "Update System Settings"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDownload
        '
        Me.cmdDownload.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDownload.Image = CType(resources.GetObject("cmdDownload.Image"), System.Drawing.Image)
        Me.cmdDownload.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDownload.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.Size = New System.Drawing.Size(142, 36)
        Me.cmdDownload.Text = "Download Data"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 39)
        '
        'cmdTestPos
        '
        Me.cmdTestPos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTestPos.Image = CType(resources.GetObject("cmdTestPos.Image"), System.Drawing.Image)
        Me.cmdTestPos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdTestPos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTestPos.Name = "cmdTestPos"
        Me.cmdTestPos.Size = New System.Drawing.Size(97, 36)
        Me.cmdTestPos.Text = "Connect"
        Me.cmdTestPos.Visible = False
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 39)
        Me.ToolStripSeparator11.Visible = False
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
        Me.lstList.LargeImageList = Me.Image1
        Me.lstList.Location = New System.Drawing.Point(5, 46)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(610, 227)
        Me.lstList.SmallImageList = Me.Image1
        Me.lstList.TabIndex = 13
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Networked POS"
        '
        'DispenserPanel
        '
        Me.DispenserPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DispenserPanel.BackColor = System.Drawing.Color.Navy
        Me.DispenserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DispenserPanel.Controls.Add(Me.ToolStrip2)
        Me.DispenserPanel.Controls.Add(Me.lstList2)
        Me.DispenserPanel.Location = New System.Drawing.Point(5, 24)
        Me.DispenserPanel.Name = "DispenserPanel"
        Me.DispenserPanel.Size = New System.Drawing.Size(624, 276)
        Me.DispenserPanel.TabIndex = 14
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator12, Me.cmdAddD, Me.ToolStripSeparator13, Me.cmdeditD, Me.ToolStripSeparator14, Me.cmdDelD, Me.ToolStripSeparator15, Me.cmdCommandD, Me.ToolStripSeparator16})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(622, 39)
        Me.ToolStrip2.TabIndex = 14
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 39)
        '
        'cmdAddD
        '
        Me.cmdAddD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddD.Image = CType(resources.GetObject("cmdAddD.Image"), System.Drawing.Image)
        Me.cmdAddD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdAddD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAddD.Name = "cmdAddD"
        Me.cmdAddD.Size = New System.Drawing.Size(70, 36)
        Me.cmdAddD.Text = "Add"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 39)
        '
        'cmdeditD
        '
        Me.cmdeditD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdeditD.Image = CType(resources.GetObject("cmdeditD.Image"), System.Drawing.Image)
        Me.cmdeditD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdeditD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdeditD.Name = "cmdeditD"
        Me.cmdeditD.Size = New System.Drawing.Size(68, 36)
        Me.cmdeditD.Text = "Edit"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 39)
        '
        'cmdDelD
        '
        Me.cmdDelD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelD.Image = CType(resources.GetObject("cmdDelD.Image"), System.Drawing.Image)
        Me.cmdDelD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdDelD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdDelD.Name = "cmdDelD"
        Me.cmdDelD.Size = New System.Drawing.Size(86, 36)
        Me.cmdDelD.Text = "Delete"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 39)
        '
        'cmdCommandD
        '
        Me.cmdCommandD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCommandD.Image = CType(resources.GetObject("cmdCommandD.Image"), System.Drawing.Image)
        Me.cmdCommandD.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdCommandD.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCommandD.Name = "cmdCommandD"
        Me.cmdCommandD.Size = New System.Drawing.Size(134, 36)
        Me.cmdCommandD.Text = "Send Command"
        '
        'ToolStripSeparator16
        '
        Me.ToolStripSeparator16.Name = "ToolStripSeparator16"
        Me.ToolStripSeparator16.Size = New System.Drawing.Size(6, 39)
        '
        'lstList2
        '
        Me.lstList2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstList2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList2.ForeColor = System.Drawing.Color.Black
        Me.lstList2.FullRowSelect = True
        Me.lstList2.GridLines = True
        Me.lstList2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList2.LargeImageList = Me.Image1
        Me.lstList2.Location = New System.Drawing.Point(5, 46)
        Me.lstList2.Name = "lstList2"
        Me.lstList2.Size = New System.Drawing.Size(611, 222)
        Me.lstList2.SmallImageList = Me.Image1
        Me.lstList2.TabIndex = 13
        Me.lstList2.UseCompatibleStateImageBehavior = False
        Me.lstList2.View = System.Windows.Forms.View.Details
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(7, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 18)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Networked Dispenser's"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Wns_Server)
        Me.Panel1.Controls.Add(Me.Wns_Local)
        Me.Panel1.Controls.Add(Me.txtTotalNet)
        Me.Panel1.Controls.Add(Me.txtTransaction)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTotalSlot)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSlot)
        Me.Panel1.Location = New System.Drawing.Point(7, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(179, 611)
        Me.Panel1.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 546)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 20)
        Me.Label8.TabIndex = 508
        Me.Label8.Text = "Total Sale :"
        '
        'Wns_Server
        '
        Me.Wns_Server.Enabled = True
        Me.Wns_Server.Location = New System.Drawing.Point(18, 180)
        Me.Wns_Server.Name = "Wns_Server"
        Me.Wns_Server.OcxState = CType(resources.GetObject("Wns_Server.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Wns_Server.Size = New System.Drawing.Size(28, 28)
        Me.Wns_Server.TabIndex = 507
        '
        'Wns_Local
        '
        Me.Wns_Local.Enabled = True
        Me.Wns_Local.Location = New System.Drawing.Point(53, 180)
        Me.Wns_Local.Name = "Wns_Local"
        Me.Wns_Local.OcxState = CType(resources.GetObject("Wns_Local.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Wns_Local.Size = New System.Drawing.Size(28, 28)
        Me.Wns_Local.TabIndex = 506
        '
        'txtTotalNet
        '
        Me.txtTotalNet.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTotalNet.AutoSize = True
        Me.txtTotalNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalNet.ForeColor = System.Drawing.Color.Lime
        Me.txtTotalNet.Location = New System.Drawing.Point(16, 566)
        Me.txtTotalNet.Name = "txtTotalNet"
        Me.txtTotalNet.Size = New System.Drawing.Size(71, 31)
        Me.txtTotalNet.TabIndex = 12
        Me.txtTotalNet.Text = "0.00"
        '
        'txtTransaction
        '
        Me.txtTransaction.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtTransaction.AutoSize = True
        Me.txtTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransaction.ForeColor = System.Drawing.Color.Cyan
        Me.txtTransaction.Location = New System.Drawing.Point(16, 505)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(30, 31)
        Me.txtTransaction.TabIndex = 13
        Me.txtTransaction.Text = "0"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(5, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total Slot :"
        '
        'txtTotalSlot
        '
        Me.txtTotalSlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalSlot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotalSlot.Font = New System.Drawing.Font("MS Reference Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalSlot.Location = New System.Drawing.Point(18, 34)
        Me.txtTotalSlot.Name = "txtTotalSlot"
        Me.txtTotalSlot.Size = New System.Drawing.Size(147, 45)
        Me.txtTotalSlot.TabIndex = 9
        Me.txtTotalSlot.TabStop = False
        Me.txtTotalSlot.Text = "300"
        Me.txtTotalSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(9, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Available Slot :"
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total Transaction :"
        '
        'txtSlot
        '
        Me.txtSlot.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSlot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSlot.Font = New System.Drawing.Font("MS Reference Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSlot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSlot.Location = New System.Drawing.Point(18, 129)
        Me.txtSlot.Name = "txtSlot"
        Me.txtSlot.Size = New System.Drawing.Size(147, 45)
        Me.txtSlot.TabIndex = 8
        Me.txtSlot.TabStop = False
        Me.txtSlot.Text = "100"
        Me.txtSlot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Image2
        '
        Me.Image2.ImageStream = CType(resources.GetObject("Image2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.Image2.TransparentColor = System.Drawing.Color.Transparent
        Me.Image2.Images.SetKeyName(0, "monitor_vista.png")
        '
        'frmPMSmain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 762)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.SplitContainer5)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmPMSmain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Parking Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.Panel2.PerformLayout()
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        Me.SplitContainer3.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.Panel2.PerformLayout()
        Me.SplitContainer4.ResumeLayout(False)
        Me.ControlPanel.ResumeLayout(False)
        Me.ControlPanel.PerformLayout()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.SplitContainer6.Panel1.ResumeLayout(False)
        Me.SplitContainer6.Panel1.PerformLayout()
        Me.SplitContainer6.Panel2.ResumeLayout(False)
        Me.SplitContainer6.Panel2.PerformLayout()
        Me.SplitContainer6.ResumeLayout(False)
        Me.POSpanel.ResumeLayout(False)
        Me.POSpanel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.DispenserPanel.ResumeLayout(False)
        Me.DispenserPanel.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Wns_Server, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wns_Local, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tmeSlot As System.Windows.Forms.Timer
    Friend WithEvents Image1 As System.Windows.Forms.ImageList
    Friend WithEvents TmrRead As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents StatusStrip2 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel8 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel9 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtTimer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents txtDbStat As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmeTime As System.Windows.Forms.Timer
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tmrData As System.Windows.Forms.Timer
    Friend WithEvents txtPosi As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TxtOp As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents PicLogo As System.Windows.Forms.PictureBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
    Friend WithEvents ControlPanel As System.Windows.Forms.Panel
    Friend WithEvents menu As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents SystemLogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdDbSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdVehicle As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdOvernigth As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdVatSettings As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmdReports As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton7 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer6 As System.Windows.Forms.SplitContainer
    Friend WithEvents POSpanel As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAddPOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdEditPOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDelPOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdUpdateSettingsPOS As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDownload As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdTestPos As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lstList As System.Windows.Forms.ListView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTransaction As System.Windows.Forms.Label
    Friend WithEvents txtTotalNet As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTotalSlot As System.Windows.Forms.TextBox
    Friend WithEvents txtSlot As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DispenserPanel As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdAddD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdeditD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdDelD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCommandD As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator16 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lstList2 As System.Windows.Forms.ListView
    Friend WithEvents SocketSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Wns_Server As AxMSWinsockLib.AxWinsock
    Friend WithEvents Wns_Local As AxMSWinsockLib.AxWinsock
    Friend WithEvents Image2 As System.Windows.Forms.ImageList
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PickLoadReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PickLodByTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PickLoadByDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdbackUp As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator17 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents LEDSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ParkingSlotToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargingRulesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
