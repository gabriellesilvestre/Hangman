Public Class Hangman

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim strWord As String
        Dim objRandom As New Random()
        Dim intTeller As Integer
        Dim arrWorden(3) As String
        Dim intWrongguess As Integer = 0
        Dim intRandom As Integer
        Dim binPresent As Boolean
        Dim chrGuessbox As Char
        Const cstrletters As String = "abcdefghijklmnopqrstuvwxyz"

        lblWord.Text = String.Empty
        picPicture.Visible = False
        lstLetters.Items.Clear()

        intRandom = objRandom.Next(1, 4)

        arrWorden(1) = "deadpool"
        arrWorden(2) = "leonardo dicaprio"
        arrWorden(3) = "computer engineering"

        strWord = arrWorden(intRandom)

        Select Case intRandom
            Case Is = 1
                Me.lblWord.Text = "________"
            Case Is = 2
                Me.lblWord.Text = "________ ________"
            Case Is = 3
                Me.lblWord.Text = "________ ___________"
        End Select

        strWord.ToCharArray()
        Do
            chrGuessbox = InputBox("Give a letter from a-z.")
            If InStr(cstrletters, chrGuessbox) = 0 Then
                MessageBox.Show("You can only use letters.")
            Else
                If lstLetters.Items.Contains(chrGuessbox) = False Then
                    binPresent = False
                    lstLetters.Items.Add(chrGuessbox)

                    For intTeller = 0 To Integer.Parse(arrWorden(intRandom).Length - 1) Step 1
                        If strWord(intTeller) = chrGuessbox Then
                            Me.lblWord.Text = lblWord.Text.Remove(intTeller, 1)
                            Me.lblWord.Text = lblWord.Text.Insert(intTeller, chrGuessbox)
                            binPresent = True

                        End If
                    Next

                    If binPresent = False Then
                        picPicture.Visible = True
                        picPicture.Image = lstHangman.Images(intWrongguess)
                        intWrongguess += 1
                    End If

                Else
                    MessageBox.Show("Letter already used before.")
                End If



            End If
        Loop Until lblWord.Text = arrWorden(intRandom) Or intWrongguess = 5
        If intWrongguess = 5 Then
            MessageBox.Show("You lost the game.")
        Else
            If lblWord.Text = arrWorden(intRandom) Then
                MessageBox.Show("You won!")
            End If
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Try to guess what the phrase is by guessing letters. The player have 5 incorrect guess only.")
    End Sub
End Class
