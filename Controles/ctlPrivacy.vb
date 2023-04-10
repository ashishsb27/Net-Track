Public Class ctlPrivacy
    Dim username As String
    Dim password As String
    Dim host As String
    Dim location As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        username = "freevpn"
        host = "83.170.115.92"
        password = "account"
        location = "USA"
        PictureBox5.Image = PictureBox1.Image
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        username = "free"
        host = "65.111.173.161"
        password = "1234"
        location = "CANADA"
        PictureBox5.Image = PictureBox2.Image
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        username = "free"
        host = "108.163.169.44"
        password = "1234"
        location = "GERMANY"
        PictureBox5.Image = PictureBox4.Image
    End Sub


    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        If Not IO.Directory.Exists(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector") Then
            IO.Directory.CreateDirectory(System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector")
        End If

        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "connection.pbk"), "[VPN]" & vbNewLine & "MEDIA=rastapi" & "Port=VPN2-0" & vbNewLine & "Device=WAN Miniport (IKEv2)" & vbNewLine & "DEVICE=vpn" & vbNewLine & "PhoneNumber=" & host)
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"), "rasdial ""VPN"" " & username & " " & password & " /phonebook:" & """" & System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.pbk" & """")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\connection.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

        connect.Start()
        connect.WaitForExit()


        If connect.ExitCode Then
            Label1.Text = "CONNECTED - YOUR IP ADDRES IS " & host
            Label1.ForeColor = Color.Blue
            PictureBox3.Image = My.Resources.Group1
            Label2.Text = " YOU ARE CONNECTED TO " & location
            MyButton2.Enabled = True
            MyButton1.Enabled = False
        End If

    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        IO.File.WriteAllText((System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\vpnconnector" & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal

        connect.Start()
        connect.WaitForExit()


        Label1.Text = "VPN DISCONNECTED"
        Label1.ForeColor = Color.Red
        PictureBox3.Image = My.Resources.Group2
        Label2.Text = " Choose a Country "
        MyButton2.Enabled = False
        MyButton1.Enabled = True
    End Sub
End Class
