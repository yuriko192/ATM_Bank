Imports ATM_Bank.UserTableTableAdapters

Public Class history

    Public Sub New(x)

        ' This call is required by the designer.
        InitializeComponent()
        Dim adpt As New TRANSACTION_HISTTableAdapter
        Dim cont = adpt.GetDataByID(x).Rows.Item(0)
        Dim text = IIf(cont.Item("IS_TAKING"), "Penarikan", "Penyetoran")
        TR_ID.Text = cont.Item("ID")
        TR_Date.Text = cont.Item("DATE")
        TR_Cont.Text = "Terjadi " & text & " :" & vbNewLine & vbNewLine
        TR_Cont.Text = TR_Cont.Text & "====================" & vbNewLine & "Sebesar : Rp." & cont.Item("AMOUNT") & vbNewLine & "====================" & vbNewLine & vbNewLine
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

End Class