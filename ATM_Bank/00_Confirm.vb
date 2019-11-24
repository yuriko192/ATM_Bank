Imports ATM_Bank.UserTableTableAdapters

Public Class confirm
    Dim source As Form
    Dim target As Form

    Public Sub New(x, y)
        source = x
        target = y
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
            confirmed = True
            target.Show()
            source.Close()
            Dim x = New USER_ACCTableAdapter
            user = x.GetUser(user.Item("USERNAME")).Rows.Item(0)
            Me.Close()
        Else
            PinBox.Text = ""
        End If
    End Sub

End Class