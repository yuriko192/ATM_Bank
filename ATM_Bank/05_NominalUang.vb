Public Class NominalUang

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub NominalUang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        F_MainM.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New TarikUang(Me, 50000)
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New TarikUang(Me, 100000)
        x.Show()
        Me.Hide()
    End Sub

End Class