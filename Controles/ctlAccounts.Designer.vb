<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlAccounts
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImgMyAccount = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MyButton2 = New Net_Track.MyButton()
        Me.MyButton1 = New Net_Track.MyButton()
        CType(Me.ImgMyAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(47, 84)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 5)
        Me.Panel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 66)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "User Account"
        '
        'ImgMyAccount
        '
        Me.ImgMyAccount.Image = Global.Net_Track.My.Resources.Resources._928429_account_customer_profile_user_icon
        Me.ImgMyAccount.Location = New System.Drawing.Point(390, 95)
        Me.ImgMyAccount.Name = "ImgMyAccount"
        Me.ImgMyAccount.Size = New System.Drawing.Size(177, 172)
        Me.ImgMyAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImgMyAccount.TabIndex = 16
        Me.ImgMyAccount.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(62, 352)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(825, 207)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(264, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(555, 35)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "-"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(264, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(555, 35)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "-"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(264, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(555, 35)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(152, 144)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 35)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Expiry:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(107, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 35)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Validation:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(24, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 35)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Activation Email:"
        '
        'MyButton2
        '
        Me.MyButton2.ButtomColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MyButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton2.Location = New System.Drawing.Point(510, 291)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(212, 55)
        Me.MyButton2.TabIndex = 19
        Me.MyButton2.Text = "New Account"
        Me.MyButton2.TopColor = System.Drawing.Color.Red
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'MyButton1
        '
        Me.MyButton1.ButtomColor = System.Drawing.Color.LightBlue
        Me.MyButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton1.Location = New System.Drawing.Point(241, 291)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(219, 55)
        Me.MyButton1.TabIndex = 18
        Me.MyButton1.Text = "Login"
        Me.MyButton1.TopColor = System.Drawing.Color.Blue
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'ctlAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ImgMyAccount)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ctlAccounts"
        Me.Size = New System.Drawing.Size(988, 595)
        CType(Me.ImgMyAccount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ImgMyAccount As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton1 As MyButton
End Class
