Imports System.Runtime.InteropServices

Public Class Form1


    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, headerPanel2.MouseDown, Label8Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HT_CAPTION, 0)

        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        FrmPopup.ShowDialog()
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        With BtnDashboard
            .ButtomColor = MyClolors.active_color1
            .TopColor = MyClolors.active_color2
        End With
        CtlDashBoard1.BringToFront()
        CtlDashBoard1.Visible = True
        ImgDashBoard.BackColor = MyClolors.imageActiveColor

        With BtnProtection
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgProtection.BackColor = MyClolors.imageDeactiveColor

        With BtnPrivacy
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgPrivacy.BackColor = MyClolors.imageDeactiveColor

        With BtnNotification
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgNotification.BackColor = MyClolors.imageDeactiveColor

        With BtnMyAccount
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgMyAccount.BackColor = MyClolors.imageDeactiveColor

        With BtnEncryption
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgEncryption.BackColor = MyClolors.imageDeactiveColor


    End Sub

    Private Sub BtnProtection_Click(sender As Object, e As EventArgs) Handles BtnProtection.Click
        With BtnDashboard
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgDashBoard.BackColor = MyClolors.imageDeactiveColor
        CtlScanControl1.BringToFront()
        CtlScanControl1.Visible = True

        With BtnProtection
            .ButtomColor = MyClolors.active_color1
            .TopColor = MyClolors.active_color2

        End With
        ImgProtection.BackColor = MyClolors.imageActiveColor

        With BtnPrivacy
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgPrivacy.BackColor = MyClolors.imageDeactiveColor

        With BtnNotification
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgNotification.BackColor = MyClolors.imageDeactiveColor

        With BtnMyAccount
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgMyAccount.BackColor = MyClolors.imageDeactiveColor

        With BtnEncryption
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgEncryption.BackColor = MyClolors.imageDeactiveColor

    End Sub

    Private Sub BtnPrivacy_Click(sender As Object, e As EventArgs) Handles BtnPrivacy.Click
        MyFunctions.privacyClick()
        If My.Settings.ActivationStatus = True Then
            CtlPremium1.BringToFront()
            CtlPremium1.Visible = True
        Else
            CtlPrivacy1.BringToFront()
            CtlPrivacy1.Visible = True
        End If


    End Sub

    Private Sub BtnNotification_Click(sender As Object, e As EventArgs) Handles BtnNotification.Click
        MyFunctions.systemperformance()
        If My.Settings.ActivationStatus = True Then
            CtlPremium1.BringToFront()
            CtlPremium1.Visible = True
        Else
            CtlSystemPerfromanve1.BringToFront()
            CtlSystemPerfromanve1.Visible = True
        End If


    End Sub

    Private Sub BtnMyAccount_Click(sender As Object, e As EventArgs) Handles BtnMyAccount.Click
        CtlAccounts1.BringToFront()
        CtlAccounts1.Visible = True
        With BtnDashboard
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgDashBoard.BackColor = MyClolors.imageDeactiveColor

        With BtnProtection
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgProtection.BackColor = MyClolors.imageDeactiveColor

        With BtnPrivacy
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgPrivacy.BackColor = MyClolors.imageDeactiveColor

        With BtnNotification
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgNotification.BackColor = MyClolors.imageDeactiveColor

        With BtnMyAccount
            .ButtomColor = MyClolors.active_color1
            .TopColor = MyClolors.active_color2
        End With
        ImgMyAccount.BackColor = MyClolors.imageActiveColor

        With BtnEncryption
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgEncryption.BackColor = MyClolors.imageDeactiveColor


    End Sub

    Private Sub BtnPreferenes_Click(sender As Object, e As EventArgs)
        With BtnDashboard
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgDashBoard.BackColor = MyClolors.imageDeactiveColor

        With BtnProtection
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgProtection.BackColor = MyClolors.imageDeactiveColor

        With BtnPrivacy
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgPrivacy.BackColor = MyClolors.imageDeactiveColor

        With BtnNotification
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgNotification.BackColor = MyClolors.imageDeactiveColor

        With BtnMyAccount
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgMyAccount.BackColor = MyClolors.imageDeactiveColor

        With BtnEncryption
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgEncryption.BackColor = MyClolors.imageDeactiveColor

    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs)
        With BtnDashboard
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgDashBoard.BackColor = MyClolors.imageDeactiveColor

        With BtnProtection
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgProtection.BackColor = MyClolors.imageDeactiveColor

        With BtnPrivacy
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgPrivacy.BackColor = MyClolors.imageDeactiveColor

        With BtnNotification
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgNotification.BackColor = MyClolors.imageDeactiveColor

        With BtnMyAccount
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgMyAccount.BackColor = MyClolors.imageDeactiveColor

        With BtnEncryption
            .ButtomColor = MyClolors.deactive_color1
            .TopColor = MyClolors.deactive_color2
        End With
        ImgEncryption.BackColor = MyClolors.imageDeactiveColor


    End Sub

    Private Sub ImgPrefeences_Click(sender As Object, e As EventArgs) Handles ImgPrefeences.Click
        frmSettings.ShowDialog()
    End Sub

    Private Sub ImgHelp_Click(sender As Object, e As EventArgs) Handles ImgHelp.Click
        Process.Start("https://ashishsb27.github.io/netrack.github.io/")
    End Sub

    Private Sub MyButton8_Click(sender As Object, e As EventArgs) Handles MyButton8.Click
        Ctlsubscription1.BringToFront()
        Ctlsubscription1.Visible = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.ActivationStatus = True Then
            Ctlsubscription1.BringToFront()
            Ctlsubscription1.Visible = True
        End If
    End Sub

    Private Sub BtnEncryption_Click(sender As Object, e As EventArgs) Handles BtnEncryption.Click
        MyFunctions.encryption()
        If My.Settings.ActivationStatus = True Then
            CtlPremium1.BringToFront()
            CtlPremium1.Visible = True
        Else
            CtlEncryption1.BringToFront()
            CtlEncryption1.Visible = True
        End If
    End Sub


End Class
