Public Class Form1
#Region "Vars"
    'Variables
    Dim Player1Score As New List(Of Integer)
    Dim Player2Score As New List(Of Integer)
    Dim Player1Win As Boolean = False
    Dim Player2Win As Boolean = False
    Dim PlayerXTurn As Boolean = True
    Dim PlayerOTurn As Boolean = False
    Dim Draw As Boolean = False
#End Region

#Region "Event Handlers"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Form2.ShowDialog()
        lblX.ForeColor = Color.Blue
        btn1.TabStop = False
        btn2.TabStop = False
        btn3.TabStop = False
        btn4.TabStop = False
        btn5.TabStop = False
        btn6.TabStop = False
        btn7.TabStop = False
        btn8.TabStop = False
        btn9.TabStop = False

    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click

        If PlayerOTurn = True Then
            btn1.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn1.Text = "X"
        End If
        btn1.Enabled = False
        ScoreKeeper(1)

    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        If PlayerOTurn = True Then
            btn2.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn2.Text = "X"
        End If
        btn2.Enabled = False
        ScoreKeeper(2)

    End Sub
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        If PlayerOTurn = True Then
            btn3.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn3.Text = "X"
        End If
        btn3.Enabled = False
        ScoreKeeper(3)

    End Sub
    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        If PlayerOTurn = True Then
            btn4.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn4.Text = "X"
        End If
        btn4.Enabled = False
        ScoreKeeper(4)

    End Sub
    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click

        If PlayerOTurn = True Then
            btn5.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn5.Text = "X"
        End If
        btn5.Enabled = False
        ScoreKeeper(5)

    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click

        If PlayerOTurn = True Then
            btn6.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn6.Text = "X"
        End If
        btn6.Enabled = False
        ScoreKeeper(6)

    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click

        If PlayerOTurn = True Then
            btn7.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn7.Text = "X"
        End If
        btn7.Enabled = False
        ScoreKeeper(7)

    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click

        If PlayerOTurn = True Then
            btn8.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn8.Text = "X"
        End If
        btn8.Enabled = False
        ScoreKeeper(8)

    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click

        If PlayerOTurn = True Then
            btn9.Text = "O"
        End If
        If PlayerXTurn = True Then
            btn9.Text = "X"
        End If
        btn9.Enabled = False
        ScoreKeeper(9)

    End Sub
#End Region
    Public Sub ScoreKeeper(keystroke As Integer)

        If PlayerXTurn = True Then
            lblO.ForeColor = Color.Blue
            lblX.ForeColor = Color.Black
            Player1Score.Add(keystroke)
            PlayerXTurn = False
            PlayerOTurn = True
            Referee()
            Exit Sub
        End If

        If PlayerOTurn = True Then
            lblO.ForeColor = Color.Black
            lblX.ForeColor = Color.Blue
            Player2Score.Add(keystroke)
            PlayerXTurn = True
            PlayerOTurn = False
            Referee()
            Exit Sub
        End If

    End Sub

    Private Sub Referee()

#Region "Player 1 logic"

        'Conditonals that check for winning place/number combinations
        If Player1Score.Contains(1) And Player1Score.Contains(2) And Player1Score.Contains(3) Then
            Player1Win = True
        End If

        If Player1Score.Contains(4) And Player1Score.Contains(5) And Player1Score.Contains(6) Then
            Player1Win = True
        End If

        If Player1Score.Contains(7) And Player1Score.Contains(8) And Player1Score.Contains(9) Then
            Player1Win = True
        End If

        If Player1Score.Contains(1) And Player1Score.Contains(4) And Player1Score.Contains(7) Then
            Player1Win = True
        End If

        If Player1Score.Contains(2) And Player1Score.Contains(5) And Player1Score.Contains(8) Then
            Player1Win = True
        End If

        If Player1Score.Contains(3) And Player1Score.Contains(6) And Player1Score.Contains(9) Then
            Player1Win = True
        End If

        If Player1Score.Contains(1) And Player1Score.Contains(5) And Player1Score.Contains(9) Then
            Player1Win = True
        End If

        If Player1Score.Contains(3) And Player1Score.Contains(5) And Player1Score.Contains(7) Then
            Player1Win = True
        End If
#End Region

#Region "Player 2 logic"

        'Conditonals that check for winning place/number combinations
        If Player2Score.Contains(1) And Player2Score.Contains(2) And Player2Score.Contains(3) Then
            Player2Win = True
        End If

        If Player2Score.Contains(4) And Player2Score.Contains(5) And Player2Score.Contains(6) Then
            Player2Win = True
        End If

        If Player2Score.Contains(7) And Player2Score.Contains(8) And Player2Score.Contains(9) Then
            Player2Win = True
        End If

        If Player2Score.Contains(1) And Player2Score.Contains(4) And Player2Score.Contains(7) Then
            Player2Win = True
        End If

        If Player2Score.Contains(2) And Player2Score.Contains(5) And Player2Score.Contains(8) Then
            Player2Win = True
        End If

        If Player2Score.Contains(3) And Player2Score.Contains(6) And Player2Score.Contains(9) Then
            Player2Win = True
        End If

        If Player2Score.Contains(1) And Player2Score.Contains(5) And Player2Score.Contains(9) Then
            Player2Win = True
        End If

        If Player2Score.Contains(3) And Player2Score.Contains(5) And Player2Score.Contains(7) Then
            Player2Win = True
        End If
#End Region

        'Draw Logic
        If Player1Score.Count = 5 And Player2Score.Count = 4 Then
            MessageBox.Show("Game is a draw!")
            Results()
        End If

        'Checks current state of play
        If Player1Win = True Or Player2Win = True Then
            Results()
        End If

    End Sub

    Private Sub Results()

        PlayerOTurn = False
        PlayerXTurn = True

        'Winner Text
        If Player1Win = True Then
            MessageBox.Show("Player 1 wins!")
        ElseIf Player2Win = True Then
            MessageBox.Show("Player 2 wins!")
        End If

        'Reset bools
        Player1Win = False
        Player2Win = False

        'Clear score keeping lists
        Player1Score.Clear()
        Player2Score.Clear()

        'Re-enable UI
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True

        btn1.Text = ""
        btn2.Text = ""
        btn3.Text = ""
        btn4.Text = ""
        btn5.Text = ""
        btn6.Text = ""
        btn7.Text = ""
        btn8.Text = ""
        btn9.Text = ""

        lblX.ForeColor = Color.Blue
        lblO.ForeColor = Color.Black

    End Sub

End Class
