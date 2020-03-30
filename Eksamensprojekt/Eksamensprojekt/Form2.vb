Public Class Form2
    Dim pi As Single
    Private Sub But_tilbage_Click(sender As Object, e As EventArgs) Handles But_tilbage.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Beregner()
        'Kæmpe if statement hvor vi bruger case, hvis vi har A B og C så skal vi en ting, hvis vi har A B og c skal vi noget andet og så videre.

    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Lbl_vis.Text = vinkelA
        Lbl_vis.Text = vinkelB
        Lbl_vis.Text = sideA
        Lbl_vis.Text = sideB
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pi = 2 * Math.Asin(1)
        If sideA & vinkelA & sideB > 0 Then
            X = (pi * 180) * vinkelA
            Y = (sideA * sideB) / X
            vinkelB = (180 / pi) * Y

        End If



        pi = 2 * Math.Asin(1)
        'MsgBox(pi)



    End Sub
End Class