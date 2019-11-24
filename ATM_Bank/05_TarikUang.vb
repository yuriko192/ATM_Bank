Public Class TarikUang
    Dim source As NominalUang
    Dim nominal As Int32

    Public Sub New(x, y)
        nominal = y
        source = x
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub TarikUang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        source.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tarik = _Tarik.Text
        If Not (IsNumeric(tarik)) Then
            MsgBox("Amount taken needs to be a number", MsgBoxStyle.Critical, "Invalid Balance")
        Else
            If Not (Val(tarik) Mod nominal = 0) Then
                MsgBox("Amount taken needs to be multiple of Rp. " & nominal / 1000 & ".000", MsgBoxStyle.Critical, "Invalid Balance")
            End If
        End If
    End Sub

End Class