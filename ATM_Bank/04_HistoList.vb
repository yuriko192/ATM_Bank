Imports System.Security.Cryptography.X509Certificates
Imports ATM_Bank.UserTableTableAdapters

Public Class HistoList

    Function Form_Button(x As Button, cont As UserTable.TRANSACTION_HISTRow) As Button
        x.Font = New System.Drawing.Font("MS Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        x.Size = New System.Drawing.Size(425, 23)
        x.Text = cont._DATE
        x.UseVisualStyleBackColor = True
        x.Tag = cont.ID
        AddHandler x.Click, AddressOf Me.OpenInfo
        Return x
    End Function

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        Dim x As New TRANSACTION_HISTTableAdapter
        Dim y = x.GetDataByUsername(user.Item("USERNAME")).GetEnumerator()
        While y.MoveNext() = True
            History_list.Controls.Add(Form_Button(New Button(), y.Current))
        End While
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub HistoList_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        F_MainM.Show()
    End Sub

    Private Sub OpenInfo(sender As Object, e As EventArgs)
        Dim x As New history(sender.Tag)
        x.Show()
    End Sub

End Class