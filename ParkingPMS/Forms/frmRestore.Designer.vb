<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRestore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRestore))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExeFile = New System.Windows.Forms.TextBox()
        Me.cmdBrowseDump = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFile1 = New System.Windows.Forms.TextBox()
        Me.cmdBrowse = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtpath = New System.Windows.Forms.TextBox()
        Me.cmdBackup = New System.Windows.Forms.Button()
        Me.SavePath = New System.Windows.Forms.SaveFileDialog()
        Me.FBD = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenPath = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(2, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(144, 18)
        Me.Label5.TabIndex = 56768
        Me.Label5.Text = "Restore Database"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.Location = New System.Drawing.Point(454, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 20)
        Me.Label3.TabIndex = 56769
        Me.Label3.Text = "  "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtExeFile)
        Me.Panel1.Controls.Add(Me.cmdBrowseDump)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFile1)
        Me.Panel1.Controls.Add(Me.cmdBrowse)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtpath)
        Me.Panel1.Controls.Add(Me.cmdBackup)
        Me.Panel1.Location = New System.Drawing.Point(6, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 209)
        Me.Panel1.TabIndex = 56770
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(414, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(60, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 16)
        Me.Label2.TabIndex = 119
        Me.Label2.Text = "mysql Path :"
        '
        'txtExeFile
        '
        Me.txtExeFile.BackColor = System.Drawing.Color.White
        Me.txtExeFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtExeFile.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExeFile.Location = New System.Drawing.Point(154, 69)
        Me.txtExeFile.Name = "txtExeFile"
        Me.txtExeFile.ReadOnly = True
        Me.txtExeFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtExeFile.Size = New System.Drawing.Size(244, 23)
        Me.txtExeFile.TabIndex = 117
        Me.txtExeFile.TabStop = False
        '
        'cmdBrowseDump
        '
        Me.cmdBrowseDump.BackColor = System.Drawing.Color.White
        Me.cmdBrowseDump.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowseDump.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowseDump.Image = CType(resources.GetObject("cmdBrowseDump.Image"), System.Drawing.Image)
        Me.cmdBrowseDump.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowseDump.Location = New System.Drawing.Point(414, 104)
        Me.cmdBrowseDump.Name = "cmdBrowseDump"
        Me.cmdBrowseDump.Size = New System.Drawing.Size(34, 34)
        Me.cmdBrowseDump.TabIndex = 2
        Me.cmdBrowseDump.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBrowseDump.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 16)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Working Directory :"
        '
        'txtFile1
        '
        Me.txtFile1.BackColor = System.Drawing.Color.White
        Me.txtFile1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFile1.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFile1.Location = New System.Drawing.Point(154, 111)
        Me.txtFile1.Name = "txtFile1"
        Me.txtFile1.ReadOnly = True
        Me.txtFile1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFile1.Size = New System.Drawing.Size(244, 23)
        Me.txtFile1.TabIndex = 1232
        Me.txtFile1.TabStop = False
        '
        'cmdBrowse
        '
        Me.cmdBrowse.BackColor = System.Drawing.Color.White
        Me.cmdBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBrowse.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBrowse.Image = CType(resources.GetObject("cmdBrowse.Image"), System.Drawing.Image)
        Me.cmdBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBrowse.Location = New System.Drawing.Point(414, 22)
        Me.cmdBrowse.Name = "cmdBrowse"
        Me.cmdBrowse.Size = New System.Drawing.Size(34, 34)
        Me.cmdBrowse.TabIndex = 0
        Me.cmdBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBrowse.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(52, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 16)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Source Path :"
        '
        'txtpath
        '
        Me.txtpath.BackColor = System.Drawing.Color.White
        Me.txtpath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpath.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpath.Location = New System.Drawing.Point(154, 29)
        Me.txtpath.Name = "txtpath"
        Me.txtpath.ReadOnly = True
        Me.txtpath.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtpath.Size = New System.Drawing.Size(244, 23)
        Me.txtpath.TabIndex = 34234
        Me.txtpath.TabStop = False
        '
        'cmdBackup
        '
        Me.cmdBackup.BackColor = System.Drawing.Color.White
        Me.cmdBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdBackup.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBackup.Image = CType(resources.GetObject("cmdBackup.Image"), System.Drawing.Image)
        Me.cmdBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdBackup.Location = New System.Drawing.Point(337, 161)
        Me.cmdBackup.Name = "cmdBackup"
        Me.cmdBackup.Size = New System.Drawing.Size(111, 34)
        Me.cmdBackup.TabIndex = 3
        Me.cmdBackup.Text = "&Restore "
        Me.cmdBackup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdBackup.UseVisualStyleBackColor = False
        '
        'OpenPath
        '
        Me.OpenPath.FileName = "OpenPath"
        '
        'frmRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(473, 239)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRestore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmdBrowseDump As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFile1 As System.Windows.Forms.TextBox
    Friend WithEvents cmdBrowse As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtpath As System.Windows.Forms.TextBox
    Friend WithEvents cmdBackup As System.Windows.Forms.Button
    Friend WithEvents SavePath As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FBD As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenPath As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtExeFile As System.Windows.Forms.TextBox
End Class
