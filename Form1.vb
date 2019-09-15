Public Class Form1

    Dim Player1Score As New List(Of Integer)
    Dim Player2Score As New List(Of Integer)

#Region "Event Handlers"
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
        If Player1Score.Contains(1) And Player1Score.Contains(2) And Player1Score.Contains(3) Then
            MessageBox.Show("Player 1 wins!")
        End If

        If Player1Score.Contains(4) And Player1Score.Contains(5) And Player1Score.Contains(6) Then
            MessageBox.Show("Player 1 wins!")
        End If

        If Player1Score.Contains(7) And Player1Score.Contains(8) And Player1Score.Contains(9) Then
            MessageBox.Show("Player 1 wins!")
        End If

        If Player1Score.Contains(1) And Player1Score.Contains(4) And Player1Score.Contains(7) Then
            MessageBox.Show("Player 1 wins!")
        End If

        If Player1Score.Contains(2) And Player1Score.Contains(5) And Player1Score.Contains(8) Then
            MessageBox.Show("Player 1 wins!")
        End If

        If Player1Score.Contains(3) And Player1Score.Contains(6) And Player1Score.Contains(9) Then
            MessageBox.Show("Player 1 wins!")
        End If

        If Player1Score.Contains(1) And Player1Score.Contains(5) And Player1Score.Contains(9) Then
            MessageBox.Show("Player 1 wins!")
        End If

        If Player1Score.Contains(3) And Player1Score.Contains(5) And Player1Score.Contains(7) Then
            MessageBox.Show("Player 1 wins!")
        End If
#End Region

#Region "Player 2 logic"
        If Player2Score.Contains(1) And Player2Score.Contains(2) And Player2Score.Contains(3) Then
            MessageBox.Show("Player 2 wins!")
        End If

        If Player2Score.Contains(4) And Player2Score.Contains(5) And Player2Score.Contains(6) Then
            MessageBox.Show("Player 2 wins!")
        End If

        If Player2Score.Contains(7) And Player2Score.Contains(8) And Player2Score.Contains(9) Then
            MessageBox.Show("Player 2 wins!")
        End If

        If Player2Score.Contains(1) And Player2Score.Contains(4) And Player2Score.Contains(7) Then
            MessageBox.Show("Player 2 wins!")
        End If

        If Player2Score.Contains(2) And Player2Score.Contains(5) And Player2Score.Contains(8) Then
            MessageBox.Show("Player 2 wins!")
        End If

        If Player2Score.Contains(3) And Player2Score.Contains(6) And Player2Score.Contains(9) Then
            MessageBox.Show("Player 2 wins!")
        End If

        If Player2Score.Contains(1) And Player2Score.Contains(5) And Player2Score.Contains(9) Then
            MessageBox.Show("Player 2 wins!")
        End If

        If Player2Score.Contains(3) And Player2Score.Contains(5) And Player2Score.Contains(7) Then
            MessageBox.Show("Player 2 wins!")
        End If
#End Region

    End Sub

End Class
