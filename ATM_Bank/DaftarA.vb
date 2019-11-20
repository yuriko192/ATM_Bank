Public Class DaftarA

    Public Name As String
    Public Address As String
    Public Job As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DaftarA_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        F_login.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Name = NameBox.Text
        Address = AddrBox.Text
        Job = JobBox.Text

        Dim x As New DaftarB(Me)
        x.Show()
        Me.Hide()
    End Sub

End Class