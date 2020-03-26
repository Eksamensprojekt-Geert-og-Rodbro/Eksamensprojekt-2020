Public Class Form1


    Private Sub But_luk_Click(sender As Object, e As EventArgs) Handles But_luk.Click
        End
    End Sub

    Private Sub But_Beregn_Click(sender As Object, e As EventArgs) Handles But_Beregn.Click
        Form2.Show()
        Me.Hide()

        vinkelA = CDec(Tbox_Va.Text)
        vinkelB = CDec(Tbox_Vb.Text)
        vinkelC = CDec(Tbox_Vc.Text)

        sideA = CDec(Tbox_Sa.Text)
        sideB = CDec(Tbox_Sb.Text)
        sideC = CDec(Tbox_Sc.Text)
    End Sub
End Class
