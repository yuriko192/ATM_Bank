﻿Public Class TarikUang

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TarikUang_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        F_MainM.Show()
    End Sub

End Class