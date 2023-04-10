<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label8Title = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MyButton1 = New Net_Track.MyButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MyButton2 = New Net_Track.MyButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.MyButton3 = New Net_Track.MyButton()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MyButton3)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.Label8Title)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(630, 480)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Net_Track.My.Resources.Resources.logo
        Me.PictureBox8.Location = New System.Drawing.Point(11, 11)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(54, 49)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 13
        Me.PictureBox8.TabStop = False
        '
        'Label8Title
        '
        Me.Label8Title.AutoSize = True
        Me.Label8Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8Title.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8Title.Location = New System.Drawing.Point(71, 11)
        Me.Label8Title.Name = "Label8Title"
        Me.Label8Title.Size = New System.Drawing.Size(226, 31)
        Me.Label8Title.TabIndex = 12
        Me.Label8Title.Text = "System Settings"
        '
        'btnclose
        '
        Me.btnclose.Image = Global.Net_Track.My.Resources.Resources._1110973_close_essential_set_x_icon
        Me.btnclose.Location = New System.Drawing.Point(589, 11)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(28, 25)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 11
        Me.btnclose.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.MyButton1)
        Me.Panel3.Location = New System.Drawing.Point(11, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(606, 93)
        Me.Panel3.TabIndex = 14
        '
        'MyButton1
        '
        Me.MyButton1.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton1.Location = New System.Drawing.Point(420, 26)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(171, 45)
        Me.MyButton1.TabIndex = 0
        Me.MyButton1.Text = "Enable"
        Me.MyButton1.TopColor = System.Drawing.Color.Blue
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(24, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 31)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Real Time Protection"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(24, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 51)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Enable real time protection to potect your computer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.MyButton2)
        Me.Panel2.Location = New System.Drawing.Point(11, 188)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(606, 93)
        Me.Panel2.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(24, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(390, 51)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Enable Auto-Piolt Mode to protect your computer automatically" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(24, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 31)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Auto-Piolet Mode"
        '
        'MyButton2
        '
        Me.MyButton2.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton2.Location = New System.Drawing.Point(420, 26)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(171, 45)
        Me.MyButton2.TabIndex = 0
        Me.MyButton2.Text = "Enable"
        Me.MyButton2.TopColor = System.Drawing.Color.Blue
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox1.Location = New System.Drawing.Point(11, 313)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(267, 29)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Start with Windows Bootup"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox2.Location = New System.Drawing.Point(11, 364)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(242, 29)
        Me.CheckBox2.TabIndex = 17
        Me.CheckBox2.Text = "Start VPN Automatically" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox3.Location = New System.Drawing.Point(321, 364)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(143, 29)
        Me.CheckBox3.TabIndex = 18
        Me.CheckBox3.Text = "Auto Update"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CheckBox4.Location = New System.Drawing.Point(321, 313)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(167, 29)
        Me.CheckBox4.TabIndex = 19
        Me.CheckBox4.Text = "Scan ever hour"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'MyButton3
        '
        Me.MyButton3.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton3.Location = New System.Drawing.Point(171, 409)
        Me.MyButton3.Name = "MyButton3"
        Me.MyButton3.Size = New System.Drawing.Size(293, 45)
        Me.MyButton3.TabIndex = 20
        Me.MyButton3.Text = "Save Settings"
        Me.MyButton3.TopColor = System.Drawing.Color.Blue
        Me.MyButton3.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(630, 480)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSettings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label8Title As Label
    Friend WithEvents btnclose As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents Label2 As Label
    Friend WithEvents MyButton3 As MyButton
End Class
