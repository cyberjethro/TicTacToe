Public Class Form1
#Region "Vars"
    'Variables
    Dim Player1Score As New List(Of Integer)
    Dim Player2Score As New List(Of Integer)
    Dim Player1Win As Boolean = False
    Dim Player2Win As Boolean = False
#End Region

#Region "Event Handlers"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        Form2.ShowDialog()

    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        ScoreKeeper(1)
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        ScoreKeeper(2)
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        ScoreKeeper(3)
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        ScoreKeeper(4)
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        ScoreKeeper(5)
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        ScoreKeeper(6)
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        ScoreKeeper(7)
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        ScoreKeeper(8)
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        ScoreKeeper(9)
    End Sub

#End Region
    Private Sub ScoreKeeper(keystroke As Integer)

        Player1Score.Add(keystroke)

        Referee()

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

        'Checks current state of play
        If Player1Win = True Or Player2Win Then
            Results()
        End If

    End Sub

    Private Sub Results()

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
    End Sub

End Class
