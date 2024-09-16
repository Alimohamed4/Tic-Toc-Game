Public Class Form1
    Dim checkforXorO As Boolean = False
    Dim addOneToScore As Integer = 0
    Dim playerX As String
    Dim playerO As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        playerX = InputBox("Enter Player X Name")
        playerO = InputBox("Enter Player O Name")

        Label2.Text = playerX
        Label3.Text = playerO

        If Label2.Text = "" Then
            Label2.Text = "Player X"
            playerX = "Player X"
        End If
        If Label3.Text = "" Then
            Label3.Text = "Player O"
            playerO = "Player O"
        End If
        Label4.Text = "Player X Turn"

    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button9.Click, Button8.Click, Button7.Click, Button6.Click, Button5.Click, Button4.Click, Button3.Click, Button2.Click, Button1.Click
        Dim b As Button = sender
        If checkforXorO = False Then
            b.Text = "X"
            checkforXorO = True
            Label4.Text = "Player O Turn"
            My.Computer.Audio.Play(My.Resources.Button_Click_, AudioPlayMode.Background)

        Else
            b.Text = "O"
            checkforXorO = False
            Label4.Text = "Player X Turn"
            My.Computer.Audio.Play(My.Resources.Button_Click_, AudioPlayMode.Background)
        End If
        chekForWin()
        b.Enabled = False


    End Sub

    Sub ButtonEnabledFalse()
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
    End Sub

    Sub chekForWin()
        'X code
        If Button1.Text = "X" And Button2.Text = "X" And Button3.Text = "X" Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"

        End If
        If Button4.Text = "X" And Button5.Text = "X" And Button6.Text = "X" Then
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"

        End If
        If Button7.Text = "X" And Button8.Text = "X" And Button9.Text = "X" Then
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Button9.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"

        End If
        If Button1.Text = "X" And Button4.Text = "X" And Button7.Text = "X" Then
            Button1.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button7.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"

        End If
        If Button2.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
            Button2.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button8.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"

        End If
        If Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
            Button3.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button9.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button1.Text = "X" And Button5.Text = "X" And Button9.Text = "X" Then
            Button1.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button9.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button3.Text = "X" And Button5.Text = "X" And Button7.Text = "X" Then
            Button3.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button7.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerX, "Tic Toc")
            addOneToScore = Convert.ToInt64(LebelscoreX.Text)
            LebelscoreX.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"

        End If
        ' O code
        If Button1.Text = "O" And Button2.Text = "O" And Button3.Text = "O" Then
            Button1.BackColor = Color.Black
            Button2.BackColor = Color.Black
            Button3.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"

        End If
        If Button4.Text = "O" And Button5.Text = "O" And Button6.Text = "O" Then
            Button4.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button6.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button7.Text = "O" And Button8.Text = "O" And Button9.Text = "O" Then
            Button7.BackColor = Color.Black
            Button8.BackColor = Color.Black
            Button9.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button1.Text = "O" And Button4.Text = "O" And Button7.Text = "O" Then
            Button1.BackColor = Color.Black
            Button4.BackColor = Color.Black
            Button7.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button2.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
            Button2.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button8.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
            Button3.BackColor = Color.Black
            Button6.BackColor = Color.Black
            Button9.BackColor = Color.Black
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button1.Text = "O" And Button5.Text = "O" And Button9.Text = "O" Then
            Button1.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button9.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
        If Button3.Text = "O" And Button5.Text = "O" And Button7.Text = "O" Then
            Button3.BackColor = Color.Black
            Button5.BackColor = Color.Black
            Button7.BackColor = Color.Black
            My.Computer.Audio.Play(My.Resources.Mobile_Games_Victory_Sound_Effect_Meme__cut_2sec_, AudioPlayMode.Background)
            MessageBox.Show("Winner is :" & playerO, "Tic Toc")
            addOneToScore = Convert.ToInt64(LabelscoreO.Text)
            LabelscoreO.Text = Convert.ToString(addOneToScore + 1)
            ButtonEnabledFalse()
            Label4.Text = "Game Over"
        End If
    End Sub

    Private Sub ButtonNewGame_Click(sender As Object, e As EventArgs) Handles ButtonNewGame.Click
        My.Computer.Audio.Play(My.Resources.Button_Click_, AudioPlayMode.Background)
        playerX = InputBox("Enter Player X Name")
        playerO = InputBox("Enter Player O Name")
        Label2.Text = playerX
        Label3.Text = playerO
        If Label2.Text = "" Then
            Label2.Text = "Player X"

        End If
        If Label3.Text = "" Then
            Label3.Text = "Player O"
        End If

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button9.BackColor = Color.White
        Button8.BackColor = Color.White

        LabelscoreO.Text = "0"
        LebelscoreX.Text = "0"

    End Sub



    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        My.Computer.Audio.Play(My.Resources.Button_Click_, AudioPlayMode.Background)
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True

        Button1.Text = ""
        Button2.Text = ""
        Button3.Text = ""
        Button4.Text = ""
        Button5.Text = ""
        Button6.Text = ""
        Button7.Text = ""
        Button8.Text = ""
        Button9.Text = ""

        Button1.BackColor = Color.White
        Button2.BackColor = Color.White
        Button3.BackColor = Color.White
        Button4.BackColor = Color.White
        Button5.BackColor = Color.White
        Button6.BackColor = Color.White
        Button7.BackColor = Color.White
        Button9.BackColor = Color.White
        Button8.BackColor = Color.White


        Dim b As Button = sender
        If checkforXorO = False Then

            checkforXorO = True
            Label4.Text = "Player O Turn"

        Else
            checkforXorO = False
            Label4.Text = "Player X Turn"
        End If
    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        My.Computer.Audio.Play(My.Resources.Button_Click_, AudioPlayMode.Background)
        Dim checkforExit As DialogResult = MessageBox.Show("Confirm if you want to exit", "Tic Tac Toe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If checkforExit = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub


End Class
