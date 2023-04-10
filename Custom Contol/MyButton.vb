Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class MyButton
    Inherits Button

    Private m_TopColo As Color = Color.LightGreen
    Private m_ButtonColor As Color = Color.Orange

    Public Property TopColor As Color
        Get
            Return m_TopColo
        End Get
        Set(value As Color)
            m_TopColo = value
            Me.Invalidate()
        End Set
    End Property

    Public Property ButtomColor As Color
        Get
            Return m_ButtonColor
        End Get
        Set(value As Color)
            m_ButtonColor = value
            Me.Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

        MyBase.OnPaint(e)

        Using lgb As LinearGradientBrush = New LinearGradientBrush(Me.ClientRectangle, m_TopColo, m_ButtonColor, 90.0F)
            Using textBrush As SolidBrush = New SolidBrush(Me.ForeColor)
                Using format As StringFormat = New StringFormat()
                    format.Alignment = GetHorizontalAlignment()
                    format.LineAlignment = GetVerticalAlignment()
                    e.Graphics.FillRectangle(lgb, Me.ClientRectangle)
                    e.Graphics.DrawString(Me.Text, Me.Font, textBrush, Me.ClientRectangle, format)
                End Using
            End Using
        End Using
    End Sub

    Private Function GetVerticalAlignment() As StringAlignment
        Return CType(Math.Log(Me.TextAlign, 2D) / 4, StringAlignment)
    End Function

    Private Function GetHorizontalAlignment() As StringAlignment
        Return CType(Math.Log(Me.TextAlign, 2D) Mod 4, StringAlignment)
    End Function

End Class
