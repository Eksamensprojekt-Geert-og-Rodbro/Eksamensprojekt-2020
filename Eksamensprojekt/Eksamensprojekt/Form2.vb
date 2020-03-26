Public Class Form2
    Private Sub But_tilbage_Click(sender As Object, e As EventArgs) Handles But_tilbage.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Tbox_vis_TextChanged(sender As Object, e As EventArgs)
        vinkelA = vinkelA
    End Sub
End Class