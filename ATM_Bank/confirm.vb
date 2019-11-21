Public Class confirm
    Dim source As Form

    Public Sub New(x)
        source = x
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub confirm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Try
            source.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pin = PinBox.Text
        If (pin = user.Item("PIN")) Then
            Dim x As New MainMenu
            x.Show()
            source.Close()
            Me.Close()
        Else
            PinBox.Text = ""
        End If
    End Sub

End Class