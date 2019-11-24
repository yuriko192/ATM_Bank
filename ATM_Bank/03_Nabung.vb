Imports ATM_Bank.UserTableTableAdapters

Public Class Nabung

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        confirmed = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Nabung_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If (confirmed) Then
            Dim y As New TRANSACTION_HISTTableAdapter
            y.InsertHistory(user.Item("USERNAME"), Val(Setor.Text), 0)
            Dim x As New USER_ACCTableAdapter
            x.AddBalance(Val(Setor.Text), user.Item("USERNAME"))
            MsgBox("Balance has been added", MsgBoxStyle.Information, "Success!")
        End If
        Try
            F_MainM.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabung = Setor.Text
        If Not (IsNumeric(tabung)) Then
            MsgBox("Stored amount needs to be a number", MsgBoxStyle.Critical, "Invalid Amount")
        Else
            If Not (Val(tabung) Mod 50000 = 0) Then
                MsgBox("Stored amount needs to be a multiple of Rp. 50.000", MsgBoxStyle.Critical, "Invalid Amount")
            Else
                Dim x As New confirm(Me, F_MainM)
                x.Show()
                Me.Hide()
            End If

        End If
    End Sub

End Class