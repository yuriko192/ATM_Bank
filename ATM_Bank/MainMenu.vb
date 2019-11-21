Public Class MainMenu

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x As New Login
        x.Show()
        Me.Close()
    End Sub

End Class