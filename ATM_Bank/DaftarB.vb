Imports ATM_Bank.TugasBankUasDataSetTableAdapters

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
        source.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Pin = PinBox.Text
        If (Pin = PinBox2.Text) Then
            Dim Username = UnameBox.Text
            Dim Balance = BalBox.Text
        Else
            MsgBox("PIN doesn't match", MsgBoxStyle.Critical, "Invalid PIN")
        End If

    End Sub

End Class