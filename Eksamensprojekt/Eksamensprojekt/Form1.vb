﻿Public Class Form1
    Dim nulstil
    Private Sub But_Beregn_Click(sender As Object, e As EventArgs) Handles But_Beregn.Click

        vinkelA = CDec(Tbox_Va.Text) 'Sætter Variablen vinkelA = texten/tallet i textboxen

        vinkelB = CDec(Tbox_Vb.Text) 'Sætter Variablen vinkelB = texten/tallet i textboxen

        vinkelC = CDec(Tbox_Vc.Text) 'Sætter Variablen vinkelC = texten/tallet i textboxen

        sideA = CDec(Tbox_Sa.Text) 'Sætter Variablen sideA = texten/tallet i textboxen

        sideB = CDec(Tbox_Sb.Text) 'Sætter Variablen sideB = texten/tallet i textboxen

        sideC = CDec(Tbox_Sc.Text) 'Sætter Variablen sideC = texten/tallet i textboxen


        A = vinkelA * Math.PI / 180 'Trækker variablen for vinkelA fra indtastnings form og regner den om til radian(A)
        B = vinkelB * Math.PI / 180 'Trækker variablen for vinkelB fra indtastnings form og regner den om til radian(B)
        C = vinkelC * Math.PI / 180 'Trækker variablen for vinkelC fra indtastnings form og regner den om til radian(C)
        a1 = sideA 'Sætter a1 til at være lig med sideA som er indtastet på forrige form
        b1 = sideB 'Sætter b1 til at være lig med sideB som er indtastet på forrige form
        c1 = sideC 'Sætter c1 til at være lig med sideC som er indtastet på forrige form

        If sideA <= 0 And sideB <= 0 And sideC <= 0 And vinkelA <= 0 And vinkelB <= 0 And vinkelC <= 0 Then
            MsgBox("Indsæt værdier. Kun positive tal")
            FejlMSG = True
        ElseIf sideA < 0 Or sideB < 0 Or sideC < 0 Or vinkelA < 0 Or vinkelB < 0 Or vinkelC < 0 Then
            MsgBox("Tjek lige efter fejl. Kun positive tal")
            FejlMSG = True

            'Hvis vi har side a, side b og Vinkel A
        ElseIf sideA > 0 And sideB > 0 And vinkelA > 0 Then
            B = Math.Asin((Math.Sin(A) * b1) / a1) 'regner VinkelB, i radian, ved hjælp af sinusrelationen
            vinkelB = (180 / Math.PI) * B 'Laver radianerne for vinkelB om til grader
            vinkelC = 180 - vinkelA - vinkelB 'Udregner vinkelC ud fra vinkelsum i trekanten
            C = vinkelC * Math.PI / 180 'Laver vinkelC om til radianer så vi kan regne med dem i visual studio
            sideC = (Math.Sin(C) * a1) / Math.Sin(A) 'Udregner side c ud fra sinusrelation

            'Hvis vi har Side a, Side b og Vinkel B
        ElseIf sideA > 0 And sideB > 0 And vinkelB > 0 Then
            A = Math.Asin((Math.Sin(B) * a1) / b1) 'Her bruger vi sinusrelationen hvor der er isoleret for vinkel A
            vinkelA = (180 / Math.PI) * A 'Omregner Radianen der er udregnet ovenfor til grader
            vinkelC = 180 - vinkelA - vinkelB 'regner vinkel C ud fra at vinkelsummen i en trekant er 180 grader 
            C = vinkelC * Math.PI / 180 'Regner vinkel c fra grader til radianer
            sideC = ((Math.Sin(C) * a1) / (Math.Sin(A))) 'Regner side c som er isoleret ud fra sinusrelationen

            'Hvis vi har Side a, Side b og Vinkel C 
        ElseIf sideA > 0 And sideB > 0 And vinkelC > 0 Then
            sideC = Math.Sqrt(a1 ^ 2 + b1 ^ 2 - 2 * a1 * b1 * Math.Cos(C)) 'Udregner sideC ud fra en isoleret cosinus relation
            c1 = sideC 'Giver variablen c1 værdien for side c til udregegninger.
            A = Math.Acos((b1 ^ 2 + c1 ^ 2 - a1 ^ 2) / (2 * b1 * c1)) 'A er isoleret i en cosinusrelation og bliver udregnet.
            vinkelA = (180 / Math.PI) * A 'Laver radian variablen for vinkel a om til grader
            B = Math.Round(Math.Acos((a1 ^ 2 + c1 ^ 2 - b1 ^ 2) / (2 * a1 * c1)), 2) 'Udregner Vinkel b ud fra en cosinusrelation med Vinkel b isoleret
            vinkelB = (180 / Math.PI) * B 'Omregner vinkel b fra radianer om til grader


            'Hvis vi har Side a, Side c og Vinkel A 
        ElseIf sideA > 0 And sideC > 0 And vinkelA > 0 Then
            C = Math.Asin((Math.Sin(A) * c1) / a1) 'Udregner vinkel c, i radianer, ud fra sinusrelationen
            vinkelC = 180 / Math.PI * C 'Omregner vinkel C fra radianer til grader
            vinkelB = 180 - vinkelA - vinkelC 'regner vinkel B ud fra at vinkelsummen i en trekant er 180 grader 
            B = vinkelB * Math.PI / 180 'Omregner vinkel B fra grader til radianer
            sideB = (Math.Sin(B) * a1 / Math.Sin(A)) 'Udregner side b ud fra sinusrelationen

            'Hvis vi har Side a, Side c og Vinkel B
        ElseIf sideA > 0 And sideC > 0 And vinkelB > 0 Then
            sideB = Math.Sqrt(a1 ^ 2 + c1 ^ 2 - 2 * a1 * c1 * Math.Cos(B)) 'Ud fra en isoleret cosinusrelation udregnes side b
            b1 = sideB 'Giver variablen b1 værdien for side b til udregegninger.
            A = Math.Acos((b1 ^ 2 + c1 ^ 2 - a1 ^ 2) / (2 * b1 * c1)) 'Ud fra en isoleret cosinusrelation udregnes vinkel A
            vinkelA = (180 / Math.PI) * A 'Omregner vinkel A fra radianer til grader
            C = Math.Acos((a1 ^ 2 + b1 ^ 2 - c1 ^ 2) / (2 * a1 * b1)) 'Ud fra en isoleret cosinusrelation udregnes vinkel C
            vinkelC = (180 / Math.PI) * C 'Omregner vinkel C fra radianer til grader

            'Hvis vi har Side a, Side c og Vinkel C
        ElseIf sideA > 0 And sideC > 0 And vinkelC > 0 Then
            A = Math.Asin(Math.Sin(C) * a1 / c1) 'Udregner vinkel A, i radianer, ud fra sinusrelationen
            vinkelA = (180 / Math.PI) * A 'Omregner vinkel A fra radianer til grader
            vinkelB = 180 - vinkelA - vinkelC 'regner vinkel B ud fra at vinkelsummen i en trekant er 180 grader
            B = vinkelB * Math.PI / 180 'Omregner vinkel B fra grader til radianer
            sideB = (Math.Sin(B) * a1 / Math.Sin(A)) 'Udregner side b ud fra sinusrelationen

            'Hvis vi har Side b, Side c og Vinkel A
        ElseIf sideB > 0 And sideC > 0 And vinkelA > 0 Then
            sideA = Math.Sqrt(b1 ^ 2 + c1 ^ 2 - 2 * b1 * c1 * Math.Cos(A)) 'Ud fra en isoleret cosinusrelation udregnes side a
            a1 = sideA 'Giver variablen a1 værdien for side a til udregegninger.
            B = Math.Acos((a1 ^ 2 + c1 ^ 2 - b1 ^ 2) / (2 * a1 * c1)) 'Ud fra en isoleret cosinusrelation udregnes vinkel B
            vinkelB = (180 / Math.PI) * B 'Omregner vinkel B fra radianer til grader
            C = Math.Acos((a1 ^ 2 + b1 ^ 2 - c1 ^ 2) / (2 * a1 * b1)) 'Ud fra en isoleret cosinusrelation udregnes vinkel C
            vinkelC = (180 / Math.PI) * C 'Omregner vinkel C fra radianer til grader

            'Hvis vi har Side b, Side c og Vinkel B
        ElseIf sideB > 0 And sideC > 0 And vinkelB > 0 Then
            C = Math.Asin((Math.Sin(B) * c1) / b1) 'Udregner vinkel C, i radianer, ud fra sinusrelationen
            vinkelC = (180 / Math.PI) * C 'Omregner vinkel C fra radianer til grader
            vinkelA = 180 - vinkelB - vinkelC 'regner vinkel A ud fra at vinkelsummen i en trekant er 180 grader 
            A = vinkelA * Math.PI / 180 'Omregner vinkel A fra grader til radianer
            sideA = (Math.Sin(A) * b1) / Math.Sin(B) 'Udregner side a ud fra sinusrelationen
            a1 = sideA 'Giver variablen a1 værdien for side a til udregegninger.

            'Hvis vi har Side sb, Side c og Vinkel C
        ElseIf sideB > 0 And sideC > 0 And vinkelC > 0 Then
            B = Math.Asin((Math.Sin(C) * b1) / c1) 'Udregner vinkel B, i radianer, ud fra sinusrelationen
            vinkelB = (180 / Math.PI) * B 'Omregner vinkel B fra radianer til grader
            vinkelA = 180 - vinkelB - vinkelC 'regner vinkel A ud fra at vinkelsummen i en trekant er 180 grader 
            A = vinkelA * Math.PI / 180 'Omregner vinkel A fra grader til radianer
            vinkelA = Math.Round(((180 / Math.PI) * A), 2)
            sideA = (Math.Sin(A) * (b1)) / (Math.Sin(B)) 'Udregner side a ud fra sinusrelationen

            'Hvis vi har alle sider
        ElseIf sideA > 0 And sideB > 0 And sideC > 0 Then
            A = Math.Acos(((b1 ^ 2) + (c1 ^ 2) - (a1 ^ 2)) / (2 * b1 * c1)) 'Bruger cosinusrelation til at udregne vinkel A
            vinkelA = (180 / Math.PI) * A 'Omregner vinkel A fra radianer til grader
            B = Math.Acos(((a1 ^ 2) + (c1 ^ 2) - (b1 ^ 2)) / (2 * a1 * c1)) 'Bruger cosinusrelation til at udregne vinkel B
            vinkelB = (180 / Math.PI) * B 'Omregner vinkel B fra radianer til grader
            C = Math.Acos(((a1 ^ 2) + (b1 ^ 2) - (c1 ^ 2)) / (2 * a1 * b1)) 'Bruger cosinusrelation til at udregne vinkel C
            vinkelC = (180 / Math.PI) * C 'Omregner vinkel C fra radianer til grader 

        End If 'Ender If statementet

        If FejlMSG = True Then
            FejlMSG = False
        Else
            Form2.Tbox_Vavis.Text = Format(vinkelA, "###.##") 'Viser værdien for Vinkel a i tilsvarende textbox
            Form2.Tbox_Vbvis.Text = Format(vinkelB, "###.##") 'Viser værdien for Vinkel b i tilsvarende textbox
            Form2.Tbox_Vcvis.Text = Format(vinkelC, "###.##") 'Viser værdien for Vinkel c i tilsvarende textbox

            Form2.Tbox_Savis.Text = Format(sideA, "###.##") 'Viser værdien for Side a i tilsvarende textbox
            Form2.Tbox_Sbvis.Text = Format(sideB, "###.##") 'Viser værdien for Side b i tilsvarende textbox
            Form2.Tbox_Scvis.Text = Format(sideC, "###.##") 'Viser værdien for Side c i tilsvarende textbox

            Form2.Pbox_billeder1.Image = My.Resources.Clean

            Form2.Show() 'Viser form 2 
            Me.Hide() 'Gemmer form 1
            Nulstiling()
        End If
    End Sub

    Private Sub But_Nulstil_Click(sender As Object, e As EventArgs) Handles But_Nulstil.Click
        Nulstiling()
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
    Private Sub Nulstiling()
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
