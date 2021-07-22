<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGuest
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGuest))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.optInHouse = New System.Windows.Forms.RadioButton
        Me.optVIP = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtDateExp = New System.Windows.Forms.DateTimePicker
        Me.dtDateStart = New System.Windows.Forms.DateTimePicker
        Me.cmdAccept = New System.Windows.Forms.Button
        Me.txtPlate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMsg1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.Controls.Add(Me.optInHouse)
        Me.Panel1.Controls.Add(Me.optVIP)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.dtDateExp)
        Me.Panel1.Controls.Add(Me.dtDateStart)
        Me.Panel1.Controls.Add(Me.cmdAccept)
        Me.Panel1.Controls.Add(Me.txtPlate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblMsg1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 277)
        Me.Panel1.TabIndex = 5
        '
        'optInHouse
        '
        Me.optInHouse.AutoSize = True
        Me.optInHouse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optInHouse.ForeColor = System.Drawing.Color.White
        Me.optInHouse.Location = New System.Drawing.Point(155, 180)
        Me.optInHouse.Name = "optInHouse"
        Me.optInHouse.Size = New System.Drawing.Size(94, 22)
        Me.optInHouse.TabIndex = 3
        Me.optInHouse.TabStop = True
        Me.optInHouse.Text = "In-House"
        Me.optInHouse.UseVisualStyleBackColor = True
        '
        'optVIP
        '
        Me.optVIP.AutoSize = True
        Me.optVIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optVIP.ForeColor = System.Drawing.Color.White
        Me.optVIP.Location = New System.Drawing.Point(255, 181)
        Me.optVIP.Name = "optVIP"
        Me.optVIP.Size = New System.Drawing.Size(51, 22)
        Me.optVIP.TabIndex = 4
        Me.optVIP.TabStop = True
        Me.optVIP.Text = "VIP"
        Me.optVIP.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Date Expired :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(55, 94)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 18)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Date Start :"
        '
        'dtDateExp
        '
        Me.dtDateExp.CustomFormat = "yyyy-MM-dd 00:00:00"
        Me.dtDateExp.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateExp.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateExp.Location = New System.Drawing.Point(155, 137)
        Me.dtDateExp.Name = "dtDateExp"
        Me.dtDateExp.Size = New System.Drawing.Size(201, 24)
        Me.dtDateExp.TabIndex = 2
        '
        'dtDateStart
        '
        Me.dtDateStart.CustomFormat = "yyyy-MM-dd HH:mm:ss"
        Me.dtDateStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDateStart.Location = New System.Drawing.Point(155, 92)
        Me.dtDateStart.Name = "dtDateStart"
        Me.dtDateStart.Size = New System.Drawing.Size(201, 24)
        Me.dtDateStart.TabIndex = 1
        '
        'cmdAccept
        '
        Me.cmdAccept.BackColor = System.Drawing.Color.White
        Me.cmdAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.ForeColor = System.Drawing.Color.Black
        Me.cmdAccept.Image = CType(resources.GetObject("cmdAccept.Image"), System.Drawing.Image)
        Me.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccept.Location = New System.Drawing.Point(244, 220)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(112, 34)
        Me.cmdAccept.TabIndex = 5
        Me.cmdAccept.Text = "      &Accept"
        Me.cmdAccept.UseVisualStyleBackColor = False
        '
        'txtPlate
        '
        Me.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(155, 46)
        Me.txtPlate.MaxLength = 6
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(201, 26)
        Me.txtPlate.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 20)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Plate Number :"
        '
        'lblMsg1
        '
        Me.lblMsg1.AutoSize = True
        Me.lblMsg1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg1.ForeColor = System.Drawing.Color.Yellow
        Me.lblMsg1.Location = New System.Drawing.Point(449, 14)
        Me.lblMsg1.Name = "lblMsg1"
        Me.lblMsg1.Size = New System.Drawing.Size(409, 18)
        Me.lblMsg1.TabIndex = 38
        Me.lblMsg1.Text = "* Please place the card to reader to begin transaction"
        Me.lblMsg1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(19, 405)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Vehicle Type :"
        '
        'frmGuest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(399, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmGuest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtDateExp As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents txtPlate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents optInHouse As System.Windows.Forms.RadioButton
    Friend WithEvents optVIP As System.Windows.Forms.RadioButton
End Class
