Imports ATM_Bank.UserTableTableAdapters

Public Class history

    Public Sub New(x)

        ' This call is required by the designer.
        InitializeComponent()
        Dim adpt As New TRANSACTION_HISTTableAdapter
        Dim cont = adpt.GetDataByID(x).Rows.Item(0)
        IdBox.Text = cont.Item("ID")
        ' Add any initialization after the InitializeComponent() call.

    End Sub

End Class