Public Class riza

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Red Then

            Me.BackColor = Color.HotPink

        Else
            Me.BackColor = Color.Red

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Red
    End Sub
End Class
