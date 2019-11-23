Public Class HistoList
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New history
        x.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New MainMenu
        x.Show()
        Me.Close()
    End Sub
End Class