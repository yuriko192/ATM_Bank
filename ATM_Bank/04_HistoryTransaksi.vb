﻿Public Class history
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As New HistoList
        x.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As New MainMenu
        x.Show()
        Me.Close()
    End Sub
End Class