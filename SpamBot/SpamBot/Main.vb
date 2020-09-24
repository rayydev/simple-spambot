Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Am can't spam empty text!", MsgBoxStyle.Critical)

            If TextBox2.Text = "" Then
                MsgBox("Am can't spam in 0 seconds!", MsgBoxStyle.Critical)
            Else
                Timer1.Interval = TextBox2.Text * 1000
                Timer1.Enabled = True
            End If
        Else
            Timer1.Interval = TextBox2.Text * 1000
            Timer1.Enabled = True
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        SendKeys.Send(TextBox1.Text)
        SendKeys.Send("{Enter}")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        MsgBox("See you next time!", MsgBoxStyle.Information)
        SplashScreen.Close()
    End Sub
End Class
