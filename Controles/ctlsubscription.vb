Public Class ctlsubscription
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()
    End Sub

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        Process.Start(MyStrings.SubscriptionLink)
    End Sub

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        Process.Start(MyStrings.SubscriptionLink)
    End Sub

    Private Sub MyButton3_Click(sender As Object, e As EventArgs) Handles MyButton3.Click
        Process.Start(MyStrings.SubscriptionLink)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmSerialKey.ShowDialog()
    End Sub
End Class
