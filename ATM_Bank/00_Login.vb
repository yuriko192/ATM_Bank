Imports ATM_Bank.UserTableTableAdapters

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = UserBox.Text
        Dim x = New USER_ACCTableAdapter
        Dim pin = x.FindUserPin(username)
        If (pin = Nothing) Then
            MsgBox("Username doesn't exist", MsgBoxStyle.Critical, "Invalid Username")
        Else
            user = x.GetUser(username).Rows.Item(0)
            Dim cont As New confirm(Me)
            cont.Show()
            Me.Hide()
        End If

    End Sub

End Class