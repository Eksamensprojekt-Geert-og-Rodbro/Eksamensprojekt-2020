Public Class Form2
    Private Sub But_tilbage_Click(sender As Object, e As EventArgs) Handles But_tilbage.Click
        Form1.Show()
        Me.Hide()
    End Sub













    Private Sub Beregner()
        'Kæmpe if statement hvor vi bruger case, hvis vi har A B og C så skal vi en ting, hvis vi har A B og c skal vi noget andet og så videre.

    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Lbl_vis.Text = vinkelA
    End Sub
End Class