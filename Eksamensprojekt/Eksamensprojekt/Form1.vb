Public Class Form1
    Dim nulstil
    Private Sub But_Beregn_Click(sender As Object, e As EventArgs) Handles But_Beregn.Click

        vinkelA = CDec(Tbox_Va.Text) 'Sætter Variablen vinkelA = texten/tallet i textboxen

        vinkelB = CDec(Tbox_Vb.Text) 'Sætter Variablen vinkelB = texten/tallet i textboxen

        vinkelC = CDec(Tbox_Vc.Text) 'Sætter Variablen vinkelC = texten/tallet i textboxen

        sideA = CDec(Tbox_Sa.Text) 'Sætter Variablen sideA = texten/tallet i textboxen

        sideB = CDec(Tbox_Sb.Text) 'Sætter Variablen sideB = texten/tallet i textboxen

        sideC = CDec(Tbox_Sc.Text) 'Sætter Variablen sideC = texten/tallet i textboxen


        Form2.Show() 'Viser form 2 
        Me.Hide() 'Gemmer form 1
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


        Me.Text = vinkelA

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Kode der kører når programmet åbnes
        Pbox_billeder.Image = My.Resources.Clean 'Indlæser billedet for vores trekant uden highlights
    End Sub
    Private Sub But_luk_Click(sender As Object, e As EventArgs) Handles But_luk.Click 'Aktiveres når man trykker på knappen luk
        End 'Lukker programmet
    End Sub
    Private Sub Tbox_Va_Click(sender As Object, e As EventArgs) Handles Tbox_Va.Click 'Aktiverer når man trykker på Tbox_Va
        Pbox_billeder.Image = My.Resources.A 'Sætter billedet i pictureboxen til at være lig med billede a stor
    End Sub
    Private Sub Tbox_Vb_Click(sender As Object, e As EventArgs) Handles Tbox_Vb.Click 'Aktiverer når man trykker på Tbox_Vb
        Pbox_billeder.Image = My.Resources.B 'Sætter billedet i pictureboxen til at være lig med billede b stor
    End Sub
    Private Sub Tbox_Vc_Click(sender As Object, e As EventArgs) Handles Tbox_Vc.Click 'Aktiverer når man trykker på Tbox_Vc
        Pbox_billeder.Image = My.Resources.C 'Sætter billedet i pictureboxen til at være lig med billede c stor
    End Sub

    Private Sub Tbox_Sa_Click(sender As Object, e As EventArgs) Handles Tbox_Sa.Click 'Aktiverer når man trykker på Tbox_Sa
        Pbox_billeder.Image = My.Resources.a_lille 'Sætter billedet i pictureboxen til at være lig med billede a lille
    End Sub

    Private Sub Tbox_Sb_Click(sender As Object, e As EventArgs) Handles Tbox_Sb.Click 'Aktiverer når man trykker på Tbox_Sb
        Pbox_billeder.Image = My.Resources.b_lille 'Sætter billedet i pictureboxen til at være lig med billede b lille
    End Sub

    Private Sub Tbox_Sc_Click(sender As Object, e As EventArgs) Handles Tbox_Sc.Click 'Aktiverer når man trykker på Tbox_Sc
        Pbox_billeder.Image = My.Resources.c_lille 'Sætter billedet i pictureboxen til at være lig med billede c lille
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

    End Sub
End Class
