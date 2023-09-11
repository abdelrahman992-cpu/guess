Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim secret, read As Integer
        Dim read1 As String
        Randomize()
        Do
            secret = 1 + 5 * Rnd()
            read1 = InputBox("Enter a number between 1 and 5 ")
            read = Integer.Parse(read1)
            If read = secret Then
                MsgBox("Congratulation Your Guess is right .")
            Else
                MsgBox(Format(secret, "Your guess is wrong " & vbCrLf & "The right number is # ."))

            End If

        Loop While (read <> secret)
    End Sub
End Class
