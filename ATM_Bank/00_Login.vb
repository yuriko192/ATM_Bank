Public Class Login

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        F_login = Me
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New DaftarA
        x.Show()
        Me.Hide()
    End Sub

End Class