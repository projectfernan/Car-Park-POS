<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransact))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lstList = New System.Windows.Forms.ListView
        Me.cmdGo = New System.Windows.Forms.Button
        Me.txtPlate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblMsg1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblMsg2 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lstList)
        Me.Panel1.Controls.Add(Me.cmdGo)
        Me.Panel1.Controls.Add(Me.txtPlate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblMsg1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(392, 283)
        Me.Panel1.TabIndex = 0
        '
        'lstList
        '
        Me.lstList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lstList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstList.ForeColor = System.Drawing.Color.Black
        Me.lstList.GridLines = True
        Me.lstList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lstList.Location = New System.Drawing.Point(4, 36)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(384, 243)
        Me.lstList.TabIndex = 40
        Me.lstList.UseCompatibleStateImageBehavior = False
        Me.lstList.View = System.Windows.Forms.View.Details
        '
        'cmdGo
        '
        Me.cmdGo.BackColor = System.Drawing.Color.White
        Me.cmdGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGo.ForeColor = System.Drawing.Color.Black
        Me.cmdGo.Image = CType(resources.GetObject("cmdGo.Image"), System.Drawing.Image)
        Me.cmdGo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGo.Location = New System.Drawing.Point(243, 362)
        Me.cmdGo.Name = "cmdGo"
        Me.cmdGo.Size = New System.Drawing.Size(112, 34)
        Me.cmdGo.TabIndex = 3
        Me.cmdGo.Text = "      &Accept"
        Me.cmdGo.UseVisualStyleBackColor = False
        '
        'txtPlate
        '
        Me.txtPlate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPlate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlate.Location = New System.Drawing.Point(130, 5)
        Me.txtPlate.MaxLength = 7
        Me.txtPlate.Name = "txtPlate"
        Me.txtPlate.Size = New System.Drawing.Size(258, 26)
        Me.txtPlate.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(4, 7)
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
        'lblMsg2
        '
        Me.lblMsg2.AutoSize = True
        Me.lblMsg2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg2.ForeColor = System.Drawing.Color.Yellow
        Me.lblMsg2.Location = New System.Drawing.Point(419, 40)
        Me.lblMsg2.Name = "lblMsg2"
        Me.lblMsg2.Size = New System.Drawing.Size(294, 18)
        Me.lblMsg2.TabIndex = 40
        Me.lblMsg2.Text = "* Now you may begin your transaction"
        Me.lblMsg2.Visible = False
        '
        'frmTransact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(399, 291)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblMsg2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmTransact"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblMsg1 As System.Windows.Forms.Label
    Friend WithEvents txtPlate As System.Windows.Forms.TextBox
    Friend WithEvents cmdGo As System.Windows.Forms.Button
    Friend WithEvents lblMsg2 As System.Windows.Forms.Label
    Friend WithEvents lstList As System.Windows.Forms.ListView
End Class
