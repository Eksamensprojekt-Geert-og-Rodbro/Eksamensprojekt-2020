Public Class Form1
    Dim nulstil
    Private Sub But_Beregn_Click(sender As Object, e As EventArgs) Handles But_Beregn.Click
        Form2.Show()
        Me.Hide()


        va = CDec(Tbox_Va.Text)
        vinkelA = va
        vb = CDec(Tbox_Vb.Text)
        vinkelB = vb
        vc = CDec(Tbox_Vc.Text)
        vinkelC = vc

        sa = CDec(Tbox_Sa.Text)
        sideA = sa
        sb = CDec(Tbox_Sb.Text)
        sideB = sb
        sc = CDec(Tbox_Sc.Text)
        sideC = sc

    End Sub

    Private Sub But_Nulstil_Click(sender As Object, e As EventArgs) Handles But_Nulstil.Click
        Tbox_Va.Text = "0"
        Tbox_Vb.Text = "0"
        Tbox_Vc.Text = "0"

        Tbox_Sa.Text = "0"
        Tbox_Sb.Text = "0"
        Tbox_Sc.Text = "0"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pbox_billeder.Image = My.Resources.Clean
    End Sub
    Private Sub Tbox_Va_Click(sender As Object, e As EventArgs) Handles Tbox_Va.Click
        Pbox_billeder.Image = My.Resources.A
    End Sub
    Private Sub But_luk_Click(sender As Object, e As EventArgs) Handles But_luk.Click
        End
    End Sub
    Private Sub Tbox_Vb_Click(sender As Object, e As EventArgs) Handles Tbox_Vb.Click
        Pbox_billeder.Image = My.Resources.B
    End Sub
    Private Sub Tbox_Vc_Click(sender As Object, e As EventArgs) Handles Tbox_Vc.Click
        Pbox_billeder.Image = My.Resources.C
    End Sub

    Private Sub Tbox_Sa_Click(sender As Object, e As EventArgs) Handles Tbox_Sa.Click
        Pbox_billeder.Image = My.Resources.a_lille
    End Sub

    Private Sub Tbox_Sb_Click(sender As Object, e As EventArgs) Handles Tbox_Sb.Click
        Pbox_billeder.Image = My.Resources.b_lille
    End Sub

    Private Sub Tbox_Sc_Click(sender As Object, e As EventArgs) Handles Tbox_Sc.Click
        Pbox_billeder.Image = My.Resources.c_lille
    End Sub
End Class
