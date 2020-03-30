Public Class Form1
    Dim nulstil
    Private Sub But_Beregn_Click(sender As Object, e As EventArgs) Handles But_Beregn.Click
        Form2.Show()
        Me.Hide()

        Dim va As Decimal = CDec(Tbox_Va.Text)
        vinkelA = va
        Dim vb As Decimal = CDec(Tbox_Vb.Text)
        vinkelB = vb
        Dim vc As Decimal = CDec(Tbox_Vb.Text)
        vinkelB = vc

        Dim sa As Decimal = CDec(Tbox_Vb.Text)
        vinkelB = sa
        Dim sb As Decimal = CDec(Tbox_Vb.Text)
        vinkelB = sb
        Dim sc As Decimal = CDec(Tbox_Vb.Text)
        vinkelB = sc
    End Sub

    Private Sub But_Nulstil_Click(sender As Object, e As EventArgs) Handles But_Nulstil.Click
        Tbox_Va.Text = "0"
        Tbox_Vb.Text = "0"
        Tbox_Vc.Text = "0"

        Tbox_Sa.Text = "0"
        Tbox_Sb.Text = "0"
        Tbox_Sc.Text = "0"
    End Sub

    Private Sub Tbox_Va_TextChanged(sender As Object, e As EventArgs) Handles Tbox_Va.TextChanged

    End Sub

    Private Sub But_luk_Click(sender As Object, e As EventArgs) Handles But_luk.Click
        End
    End Sub

    Private Sub Tbox_Va_Click(sender As Object, e As EventArgs) Handles Tbox_Va.Click
        Pbox_billeder.Image = Properties.resour
    End Sub
End Class
