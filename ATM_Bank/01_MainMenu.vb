Public Class MainMenu

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        F_MainM = Me
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim x As New Login
        x.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As New TarikUang
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim x As New Nabung
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New CekSaldo
        x.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New HistoList
        x.Show()
        Me.Hide()
    End Sub

End Class