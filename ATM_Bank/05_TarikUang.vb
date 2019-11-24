Imports ATM_Bank.UserTableTableAdapters

Public Class TarikUang
    Dim source As NominalUang
    Dim nominal As Int32

    Public Sub New(x, y)
        nominal = y
        source = x
        ' This call is required by the designer.
        InitializeComponent()
        confirmed = False
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TarikUang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If (confirmed) Then
            Dim x As New USER_ACCTableAdapter
            x.TakeBalance(Val(Tarik.Text), user.Item("USERNAME"))
            MsgBox("Balance has been taken", MsgBoxStyle.Information, "Success!")
            source.Close()
        End If
        Try
            source.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tarik = _Tarik.Text
        If Not (IsNumeric(tarik)) Then
            MsgBox("Amount taken needs to be a number", MsgBoxStyle.Critical, "Invalid Amount")
        Else
            If (Val(tarik) > user.Item("BALANCE")) Then
                MsgBox("Amount taken is over current balance", MsgBoxStyle.Critical, "Invalid Balance")
            End If
            If Not (Val(tarik) Mod nominal = 0) Then
                MsgBox("Amount taken needs to be multiple of Rp. " & nominal / 1000 & ".000", MsgBoxStyle.Critical, "Invalid Amount")
            Else
                Dim x As New confirm(Me, F_MainM)
                x.Show()
                Me.Hide()
            End If
        End If
    End Sub

End Class