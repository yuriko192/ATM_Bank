Imports ATM_Bank.TugasBankUasDataSetTableAdapters
Imports ATM_Bank.UserTableTableAdapters
Imports Microsoft.VisualBasic.ApplicationServices

Public Class DaftarB
    Dim source As DaftarA

    Public Sub New(source)
        Me.source = source
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DaftarB_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        If (source.IsAccessible) Then
            source.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Pin = PinBox.Text
        If (Pin = PinBox2.Text) Then
            If Not (Pin.Length = 6) Then
                MsgBox("PIN needs to be 6 character", MsgBoxStyle.Critical, "Invalid PIN")
            Else
                Dim Balance = BalBox.Text
                If Not (IsNumeric(Balance)) Then
                    MsgBox("Balance needs to be a number", MsgBoxStyle.Critical, "Invalid Balance")
                ElseIf (Val(Balance) < 500000) Then
                    MsgBox("Balance needs to be over 500.000", MsgBoxStyle.Critical, "Invalid Balance")
                Else
                    Dim Username = UnameBox.Text
                    Dim x = New USER_ACCTableAdapter
                    x.InsertUser(Username, source.Name, source.Address, source.Job, Pin, Balance)
                    MsgBox("User Created", MsgBoxStyle.Information, "User Created")
                    source.Close()
                    Me.Close()
                End If

            End If
        Else
            MsgBox("PIN doesn't match", MsgBoxStyle.Critical, "Invalid PIN")
        End If

    End Sub

End Class