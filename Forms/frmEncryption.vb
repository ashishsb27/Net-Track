Imports System.Security.Cryptography.X509Certificates
Imports System.Text

Public Class frmEncryption
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()
    End Sub

    Private Sub frmEncryption_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown, headerPanel2.MouseDown, Label8Title.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MyFunctions.ReleaseCapture()
            MyFunctions.SendMessage(Handle, MyFunctions.WM_NCLBUTTONDOWN, MyFunctions.HT_CAPTION, 0)

        End If
    End Sub

    Private Sub btnminimize_Click(sender As Object, e As EventArgs) Handles btnminimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Public Function Encrypt(Encryption As String) As String
        Dim msg As String = String.Empty
        Dim encode As Byte() = New Byte(Encryption.Length - 1) {}
        encode = Encoding.UTF32.GetBytes(Encryption)
        msg = Convert.ToBase64String(encode)
        Return msg

    End Function

    Private Sub MyButton2_Click(sender As Object, e As EventArgs) Handles MyButton2.Click
        txtEncrypt.Text = Encrypt(txtInput.Text)
    End Sub

    Public Function Decrypt(Decryption As String) As String
        Dim decrypttext As String = String.Empty
        Dim encodedtxt As New UTF32Encoding()
        Dim decode As Decoder = encodedtxt.GetDecoder()
        Dim code_byte As Byte() = Convert.FromBase64String(Decryption)
        Dim charcount As Integer = decode.GetCharCount(code_byte, 0, code_byte.Length)
        Dim decode_char As Char() = New Char(charcount - 1) {}
        decode.GetChars(code_byte, 0, code_byte.Length, decode_char, 0)
        decrypttext = New String(decode_char)
        Return decrypttext

    End Function

    Private Sub MyButton1_Click(sender As Object, e As EventArgs) Handles MyButton1.Click
        txtDecrypt.Text = Decrypt(txtInput.Text)
    End Sub
End Class