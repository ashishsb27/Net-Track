Imports System.Runtime.InteropServices

Public Class MyFunctions
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2


    <DllImportAttribute("user32.dll")>
    Public Shared Function SendMessage(ByVal HWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    End Function

    <DllImportAttribute("user32.dll")>
    Public Shared Function ReleaseCapture() As Boolean

    End Function

    Public Shared Sub privacyClick()
        With Form1.BtnDashboard
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgDashBoard.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnProtection
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2

        End With
        Form1.ImgProtection.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnPrivacy
            .ButtomColor = MyClolors.active_color1
            .TopColor = MyClolors.active_color2

        End With
        Form1.ImgPrivacy.BackColor = MyClolors.imageActiveColor

        With Form1.BtnNotification
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgNotification.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnMyAccount
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgMyAccount.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnEncryption
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgEncryption.BackColor = MyClolors.imageDeactiveColor

    End Sub

    Public Shared Sub systemperformance()
        With Form1.BtnDashboard
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgDashBoard.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnProtection
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgProtection.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnPrivacy
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgPrivacy.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnNotification
            .ButtomColor = MyClolors.active_color1
            .TopColor = MyClolors.active_color2
        End With
        Form1.ImgNotification.BackColor = MyClolors.imageActiveColor

        With Form1.BtnMyAccount
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgMyAccount.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnEncryption
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgEncryption.BackColor = MyClolors.imageDeactiveColor

    End Sub

    Public Shared Sub encryption()
        With Form1.BtnDashboard
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgDashBoard.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnProtection
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgProtection.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnPrivacy
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgPrivacy.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnNotification
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgNotification.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnMyAccount
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        Form1.ImgMyAccount.BackColor = MyClolors.imageDeactiveColor

        With Form1.BtnEncryption
            .ButtomColor = MyClolors.active_color1
            .TopColor = MyClolors.active_color2
        End With
        Form1.ImgEncryption.BackColor = MyClolors.imageActiveColor

    End Sub



    Public Shared Sub Enable_Firewall()
        Dim firewall As New Process
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32\"
        firewall.StartInfo.Arguments = "/c netsh fireball set opmode mode=enable"
        firewall.Start()
        MsgBox("Firewall Enabled successfully! ", MsgBoxStyle.Information, "Attention!")
        My.Settings.firewall = True
        My.Settings.Save()

    End Sub

    Public Shared Sub Disnable_Firewall()
        Dim firewall As New Process
        firewall.StartInfo.FileName = "cmd.exe"
        firewall.StartInfo.WorkingDirectory = "\windows\system32\"
        firewall.StartInfo.Arguments = "/c netsh fireball set opmode mode=disable"
        firewall.Start()
        MsgBox("Firewall Disabled successfully! ", MsgBoxStyle.Information, "Attention!")
        My.Settings.firewall = False
        My.Settings.Save()

    End Sub

End Class
