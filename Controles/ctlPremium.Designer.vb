<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctlPremium
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
        Me.MyButton1 = New Net_Track.MyButton()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyButton1
        '
        Me.MyButton1.ButtomColor = System.Drawing.Color.Gray
        Me.MyButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyButton1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.MyButton1.Location = New System.Drawing.Point(287, 336)
        Me.MyButton1.Name = "MyButton1"
        Me.MyButton1.Size = New System.Drawing.Size(381, 76)
        Me.MyButton1.TabIndex = 13
        Me.MyButton1.Text = "Go Premium"
        Me.MyButton1.TopColor = System.Drawing.Color.Blue
        Me.MyButton1.UseVisualStyleBackColor = True
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Net_Track.My.Resources.Resources.logo
        Me.PictureBox8.Location = New System.Drawing.Point(391, 127)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(165, 166)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 14
        Me.PictureBox8.TabStop = False
        '
        'ctlPremium
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.MyButton1)
        Me.Name = "ctlPremium"
        Me.Size = New System.Drawing.Size(988, 595)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MyButton1 As MyButton
    Friend WithEvents PictureBox8 As PictureBox
End Class
