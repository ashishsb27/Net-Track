<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncryption
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
        Me.headerPanel2 = New System.Windows.Forms.Panel()
        Me.btnminimize = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.Label8Title = New System.Windows.Forms.Label()
        Me.txtDecrypt = New System.Windows.Forms.TextBox()
        Me.txtEncrypt = New System.Windows.Forms.TextBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.MyButton2 = New Net_Track.MyButton()
        Me.MyButton1 = New Net_Track.MyButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.headerPanel2.SuspendLayout()
        CType(Me.btnminimize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headerPanel2
        '
        Me.headerPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.headerPanel2.Controls.Add(Me.btnminimize)
        Me.headerPanel2.Controls.Add(Me.btnclose)
        Me.headerPanel2.Controls.Add(Me.Label8Title)
        Me.headerPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel2.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel2.Name = "headerPanel2"
        Me.headerPanel2.Size = New System.Drawing.Size(857, 55)
        Me.headerPanel2.TabIndex = 4
        '
        'btnminimize
        '
        Me.btnminimize.Image = Global.Net_Track.My.Resources.Resources._4168572_remove_cancel_close_delete_minus_icon
        Me.btnminimize.Location = New System.Drawing.Point(766, 13)
        Me.btnminimize.Name = "btnminimize"
        Me.btnminimize.Size = New System.Drawing.Size(26, 25)
        Me.btnminimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnminimize.TabIndex = 6
        Me.btnminimize.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.Image = Global.Net_Track.My.Resources.Resources._1110973_close_essential_set_x_icon
        Me.btnclose.Location = New System.Drawing.Point(815, 13)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(28, 25)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 4
        Me.btnclose.TabStop = False
        '
        'Label8Title
        '
        Me.Label8Title.AutoSize = True
        Me.Label8Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8Title.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8Title.Location = New System.Drawing.Point(12, 9)
        Me.Label8Title.Name = "Label8Title"
        Me.Label8Title.Size = New System.Drawing.Size(281, 36)
        Me.Label8Title.TabIndex = 3
        Me.Label8Title.Text = "Smart Scan Center"
        '
        'txtDecrypt
        '
        Me.txtDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDecrypt.Location = New System.Drawing.Point(277, 282)
        Me.txtDecrypt.Name = "txtDecrypt"
        Me.txtDecrypt.Size = New System.Drawing.Size(566, 36)
        Me.txtDecrypt.TabIndex = 17
        '
        'txtEncrypt
        '
        Me.txtEncrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEncrypt.Location = New System.Drawing.Point(277, 208)
        Me.txtEncrypt.Name = "txtEncrypt"
        Me.txtEncrypt.Size = New System.Drawing.Size(566, 36)
        Me.txtEncrypt.TabIndex = 18
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(277, 135)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(566, 36)
        Me.txtInput.TabIndex = 19
        '
        'MyButton2
        '
        Me.MyButton2.ButtomColor = System.Drawing.Color.LightBlue
        Me.MyButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton2.Location = New System.Drawing.Point(54, 394)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(317, 46)
        Me.MyButton2.TabIndex = 22
        Me.MyButton2.Text = "Encrypt"
        Me.MyButton2.TopColor = System.Drawing.Color.Blue
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'MyButton1
        '
        Me.MyButton1.ButtomColor = System.Drawing.Color.LightBlue
        Me.MyButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton1.Location = New System.Drawing.Point(475, 394)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(317, 46)
        Me.MyButton1.TabIndex = 23
        Me.MyButton1.Text = "Decrypt"
        Me.MyButton1.TopColor = System.Drawing.Color.Red
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(152, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 31)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(118, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 31)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Encrypt"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(116, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 31)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Decrypt"
        '
        'frmEncryption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(857, 506)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MyButton1)
        Me.Controls.Add(Me.MyButton2)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.txtEncrypt)
        Me.Controls.Add(Me.txtDecrypt)
        Me.Controls.Add(Me.headerPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEncryption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEncryption"
        Me.headerPanel2.ResumeLayout(False)
        Me.headerPanel2.PerformLayout()
        CType(Me.btnminimize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents headerPanel2 As Panel
    Friend WithEvents btnclose As PictureBox
    Friend WithEvents Label8Title As Label
    Friend WithEvents btnminimize As PictureBox
    Friend WithEvents txtDecrypt As TextBox
    Friend WithEvents txtEncrypt As TextBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
