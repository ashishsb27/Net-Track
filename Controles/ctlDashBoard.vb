Imports System.IO
Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ctlDashBoard

    Dim isActive As Boolean = False
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        frmScan.ShowDialog()
        frmScan.FolderBrowserDialog1.SelectedPath = "C:\"

        On Error Resume Next

        For Each strDir As String In System.IO.Directory.GetDirectories(frmScan.FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.TopDirectoryOnly)
            For Each strFile As String In System.IO.Directory.GetFiles(strDir, "*.*", SearchOption.AllDirectories)
                frmScan.ListBox1.Items.Add(strFile)
            Next
        Next

        frmScan.MyButton1.Enabled = False
        frmScan.MyButton3.Enabled = True
        frmScan.MyButton4.Enabled = True
        frmScan.Timer1.Start()
        frmScan.ProgressBar1.Visible = False

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        frmScan.ShowDialog()
        If frmScan.FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            frmScan.ListBox1.Items.Clear()
            MyButton1.Enabled = True
        Else
            Exit Sub
        End If

        On Error Resume Next

        For Each strFile As String In System.IO.Directory.GetFiles(frmScan.FolderBrowserDialog1.SelectedPath, "*.*", IO.SearchOption.AllDirectories)
            frmScan.ListBox1.Items.Add(strFile)
        Next
        frmScan.Timer1.Start()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Form1.BtnPrivacy.PerformClick()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(MyStrings.HelpLink)
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        If isActive = False Then
            isActive = True
            MyButton1.Text = "Disabled"
            MyButton1.ButtomColor = Color.Gray
            MyButton1.TopColor = Color.Red
            MyFunctions.Disnable_Firewall()

        ElseIf isActive = True Then
            isActive = False
            MyButton1.Text = "Enabled"
            MyButton1.ButtomColor = Color.Gray
            MyButton1.TopColor = Color.Blue

            MyFunctions.Enable_Firewall()


        End If
    End Sub

    Private Sub ctlDashBoard_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.firewall = True Then
            isActive = True
            MyButton1.ButtomColor = Color.Gray
            MyButton1.TopColor = Color.Red
            MyButton1.Text = "Disabled"

        ElseIf My.Settings.firewall = False Then
            isActive = False
            MyButton1.ButtomColor = Color.Gray
            MyButton1.TopColor = Color.Blue
            MyButton1.Text = "Enabled"
        End If
    End Sub
End Class
