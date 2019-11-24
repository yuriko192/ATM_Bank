Public Class NominalUang

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub NominalUang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        F_MainM.Show()
    End Sub

End Class