<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExeedGrace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExeedGrace))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cboVtype = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
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
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cboVtype)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmdAccept)
        Me.Panel1.Controls.Add(Me.txtPlate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblMsg1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(6, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 277)
        Me.Panel1.TabIndex = 103
        '
        'cboVtype
        '
        Me.cboVtype.BackColor = System.Drawing.Color.White
        Me.cboVtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboVtype.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVtype.FormattingEnabled = True
        Me.cboVtype.Location = New System.Drawing.Point(159, 133)
        Me.cboVtype.Name = "cboVtype"
        Me.cboVtype.Size = New System.Drawing.Size(201, 26)
        Me.cboVtype.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(32, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 20)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Vehicle Type :"
        '
        'cmdAccept
        '
        Me.cmdAccept.BackColor = System.Drawing.Color.White
        Me.cmdAccept.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdAccept.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAccept.ForeColor = System.Drawing.Color.Black
        Me.cmdAccept.Image = CType(resources.GetObject("cmdAccept.Image"), System.Drawing.Image)
        Me.cmdAccept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAccept.Location = New System.Drawing.Point(248, 185)
        Me.cmdAccept.Name = "cmdAccept"
        Me.cmdAccept.Size = New System.Drawing.Size(112, 34)
        Me.cmdAccept.TabIndex = 2
        Me.cmdAccept.Text = "      &Accept"
        Me.cmdAccept.UseVisualStyleBackColor = False
        '
        'txtPlate
        '
        Me.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(159, 77)
        Me.txtPlate.MaxLength = 7
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(201, 26)
        Me.txtPlate.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 78)
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
        'frmExeedGrace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(399, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmExeedGrace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cboVtype As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAccept As System.Windows.Forms.Button
    Friend WithEvents txtPlate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
