Public Class Form1
    Dim nulstil
    Private Sub But_Beregn_Click(sender As Object, e As EventArgs) Handles But_Beregn.Click

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



        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub But_Nulstil_Click(sender As Object, e As EventArgs) Handles But_Nulstil.Click
        Tbox_Va.Text = "0"
        Tbox_Vb.Text = "0"
        Tbox_Vc.Text = "0"

        Tbox_Sa.Text = "0"
        Tbox_Sb.Text = "0"
        Tbox_Sc.Text = "0"

        vinkelA = 0
        vinkelB = 0
        vinkelC = 0
        sideA = 0
        sideB = 0
        sideC = 0
        A = 0
        B = 0
        C = 0
        a1 = 0
        b1 = 0
        c1 = 0
        va = 0
        vb = 0
        vc = 0
        sa = 0
        sb = 0
        sc = 0

        Me.Text = vinkelA

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

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Controls.Clear()
        InitializeComponent()

        Tbox_Va.Text = "0"
        Tbox_Vb.Text = "0"
        Tbox_Vc.Text = "0"

        Tbox_Sa.Text = "0"
        Tbox_Sb.Text = "0"
        Tbox_Sc.Text = "0"

        vinkelA = 0
        vinkelB = 0
        vinkelC = 0
        sideA = 0
        sideB = 0
        sideC = 0
        A = 0
        B = 0
        C = 0
        a1 = 0
        b1 = 0
        c1 = 0
        va = 0
        vb = 0
        vc = 0
        sa = 0
        sb = 0
        sc = 0

    End Sub
End Class
