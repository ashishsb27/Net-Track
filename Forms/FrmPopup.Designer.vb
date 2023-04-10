<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPopup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MyButton2 = New Net_Track.MyButton()
        Me.MyButton1 = New Net_Track.MyButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Label8Title = New System.Windows.Forms.Label()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MyButton2)
        Me.Panel1.Controls.Add(Me.MyButton1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox8)
        Me.Panel1.Controls.Add(Me.Label8Title)
        Me.Panel1.Controls.Add(Me.btnclose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(522, 328)
        Me.Panel1.TabIndex = 0
        '
        'MyButton2
        '
        Me.MyButton2.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton2.Location = New System.Drawing.Point(272, 216)
        Me.MyButton2.Name = "MyButton2"
        Me.MyButton2.Size = New System.Drawing.Size(171, 55)
        Me.MyButton2.TabIndex = 13
        Me.MyButton2.Text = "Yes"
        Me.MyButton2.TopColor = System.Drawing.Color.Red
        Me.MyButton2.UseVisualStyleBackColor = True
        '
        'MyButton1
        '
        Me.MyButton1.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton1.Location = New System.Drawing.Point(64, 216)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(171, 55)
        Me.MyButton1.TabIndex = 12
        Me.MyButton1.Text = "No"
        Me.MyButton1.TopColor = System.Drawing.Color.Blue
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(6, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 89)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Do You Want To Close?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Net_Track.My.Resources.Resources.logo
        Me.PictureBox8.Location = New System.Drawing.Point(-1, 11)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(54, 42)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 10
        Me.PictureBox8.TabStop = False
        '
        'Label8Title
        '
        Me.Label8Title.AutoSize = True
        Me.Label8Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8Title.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8Title.Location = New System.Drawing.Point(59, 11)
        Me.Label8Title.Name = "Label8Title"
        Me.Label8Title.Size = New System.Drawing.Size(132, 29)
        Me.Label8Title.TabIndex = 6
        Me.Label8Title.Text = "Net-Track"
        '
        'btnclose
        '
        Me.btnclose.Image = Global.Net_Track.My.Resources.Resources._1110973_close_essential_set_x_icon
        Me.btnclose.Location = New System.Drawing.Point(478, 11)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(28, 25)
        Me.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnclose.TabIndex = 5
        Me.btnclose.TabStop = False
        '
        'FrmPopup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(522, 328)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPopup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmPopup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnclose As PictureBox
    Friend WithEvents Label8Title As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MyButton2 As MyButton
    Friend WithEvents MyButton1 As MyButton
End Class
