<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmScan
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
        Me.components = New System.ComponentModel.Container()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MyButton4 = New Net_Track.MyButton()
        Me.MyButton3 = New Net_Track.MyButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.MyButton1 = New Net_Track.MyButton()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblVirus = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.headerPanel2 = New System.Windows.Forms.Panel()
        Me.btnclose = New System.Windows.Forms.PictureBox()
        Me.Label8Title = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.headerPanel2.SuspendLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.MyButton4)
        Me.Panel1.Controls.Add(Me.MyButton3)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.ListBox2)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.MyButton1)
        Me.Panel1.Controls.Add(Me.lblLast)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblVirus)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.headerPanel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(872, 762)
        Me.Panel1.TabIndex = 3
        '
        'MyButton4
        '
        Me.MyButton4.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton4.Location = New System.Drawing.Point(803, 630)
        Me.MyButton4.Name = "MyButton4"
        Me.MyButton4.Size = New System.Drawing.Size(41, 26)
        Me.MyButton4.TabIndex = 35
        Me.MyButton4.Text = "?"
        Me.MyButton4.TopColor = System.Drawing.Color.Green
        Me.MyButton4.UseVisualStyleBackColor = True
        '
        'MyButton3
        '
        Me.MyButton3.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton3.Location = New System.Drawing.Point(803, 585)
        Me.MyButton3.Name = "MyButton3"
        Me.MyButton3.Size = New System.Drawing.Size(41, 26)
        Me.MyButton3.TabIndex = 34
        Me.MyButton3.Text = "X"
        Me.MyButton3.TopColor = System.Drawing.Color.Red
        Me.MyButton3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(422, 557)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 23)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "Virus List"
        '
        'ListBox2
        '
        Me.ListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListBox2.ForeColor = System.Drawing.Color.Silver
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 16
        Me.ListBox2.Location = New System.Drawing.Point(426, 585)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(371, 164)
        Me.ListBox2.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(18, 557)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 23)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Files Scanning"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(20, 537)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(840, 3)
        Me.Panel4.TabIndex = 30
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListBox1.ForeColor = System.Drawing.Color.Silver
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(22, 585)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(371, 164)
        Me.ListBox1.TabIndex = 29
        '
        'MyButton1
        '
        Me.MyButton1.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton1.Location = New System.Drawing.Point(752, 307)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(104, 26)
        Me.MyButton1.TabIndex = 28
        Me.MyButton1.Text = "Cancle"
        Me.MyButton1.TopColor = System.Drawing.Color.Red
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'lblLast
        '
        Me.lblLast.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLast.ForeColor = System.Drawing.SystemColors.Control
        Me.lblLast.Location = New System.Drawing.Point(18, 437)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(826, 83)
        Me.lblLast.TabIndex = 27
        Me.lblLast.Text = "C:\"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(13, 402)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(230, 25)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Last Directry Scanned:"
        '
        'lblVirus
        '
        Me.lblVirus.AutoSize = True
        Me.lblVirus.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVirus.ForeColor = System.Drawing.SystemColors.Control
        Me.lblVirus.Location = New System.Drawing.Point(210, 370)
        Me.lblVirus.Name = "lblVirus"
        Me.lblVirus.Size = New System.Drawing.Size(24, 25)
        Me.lblVirus.TabIndex = 25
        Me.lblVirus.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(8, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(196, 25)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = " Detected Threats :"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Silver
        Me.lblTotal.Location = New System.Drawing.Point(174, 339)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(395, 30)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "-" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(15, 338)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Files Scanned :"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(19, 307)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(727, 23)
        Me.ProgressBar1.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Location = New System.Drawing.Point(16, 298)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(840, 3)
        Me.Panel3.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(577, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 56)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Scan Files And Folders As you Wish" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(575, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 39)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Folder Scan"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Net_Track.My.Resources.Resources._8684058_folder_file_document_search_find_icon
        Me.PictureBox1.Location = New System.Drawing.Point(426, 186)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 105)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(173, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 56)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Scan Files And Folders Very Quickly" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(171, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(189, 39)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Quick Scan"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Net_Track.My.Resources.Resources._9845931_bug_scan_search_error_virus_icon
        Me.PictureBox3.Location = New System.Drawing.Point(22, 186)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(143, 105)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 14
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(19, 177)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(840, 3)
        Me.Panel2.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(17, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(842, 48)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quickly run a smart can on your computer to detect any hidden virusus that can ea" &
    "sly harm your system and files" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(11, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 66)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Scan Center"
        '
        'headerPanel2
        '
        Me.headerPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.headerPanel2.Controls.Add(Me.btnclose)
        Me.headerPanel2.Controls.Add(Me.Label8Title)
        Me.headerPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.headerPanel2.Location = New System.Drawing.Point(0, 0)
        Me.headerPanel2.Name = "headerPanel2"
        Me.headerPanel2.Size = New System.Drawing.Size(870, 55)
        Me.headerPanel2.TabIndex = 3
        '
        'btnclose
        '
        Me.btnclose.Image = Global.Net_Track.My.Resources.Resources._1110973_close_essential_set_x_icon
        Me.btnclose.Location = New System.Drawing.Point(836, 11)
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
        Me.Label8Title.Location = New System.Drawing.Point(14, 10)
        Me.Label8Title.Name = "Label8Title"
        Me.Label8Title.Size = New System.Drawing.Size(281, 36)
        Me.Label8Title.TabIndex = 3
        Me.Label8Title.Text = "Smart Scan Center"
        '
        'frmScan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(872, 762)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmScan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmScan"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.headerPanel2.ResumeLayout(False)
        Me.headerPanel2.PerformLayout()
        CType(Me.btnclose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents headerPanel2 As Panel
    Friend WithEvents btnclose As PictureBox
    Friend WithEvents Label8Title As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lblLast As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblVirus As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents Label14 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents MyButton4 As MyButton
    Friend WithEvents MyButton3 As MyButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer2 As Timer
End Class
