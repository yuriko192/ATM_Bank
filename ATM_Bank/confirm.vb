Public Class confirm
    Dim source As Form

    Public Sub New(x)
        source = x
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub confirm_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class