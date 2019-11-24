Public Class CekSaldo

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Saldo.Text = user.Item("BALANCE")
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CekSaldo_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        F_MainM.Show()
    End Sub

End Class