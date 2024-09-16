Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.Button_Click_, AudioPlayMode.Background)
        Form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.Button_Click_, AudioPlayMode.Background)
        Form3.Show()

    End Sub
End Class