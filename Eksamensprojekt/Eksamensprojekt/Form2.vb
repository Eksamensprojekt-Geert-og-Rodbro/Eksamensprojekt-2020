Public Class Form2
    Private Sub But_tilbage_Click(sender As Object, e As EventArgs) Handles But_tilbage.Click 'Aktiverer når man klikker på knappen tilbage
        Form1.Show() 'Viser form 1
        Me.Hide() 'Gemmer form 2
    End Sub 'stopper sub rutinen
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'Starter subrutinen når form 2 loader
        A = vinkelA * Math.PI / 180 'Trækker variablen for vinkelA fra indtastnings form og regner den om til radian(A)
        B = vinkelB * Math.PI / 180 'Trækker variablen for vinkelB fra indtastnings form og regner den om til radian(B)
        C = vinkelC * Math.PI / 180 'Trækker variablen for vinkelC fra indtastnings form og regner den om til radian(C)
        a1 = sideA 'Sætter a1 til at være lig med sideA som er indtastet på forrige form
        b1 = sideB 'Sætter b1 til at være lig med sideB som er indtastet på forrige form
        c1 = sideC 'Sætter c1 til at være lig med sideC som er indtastet på forrige form
        Me.Text = "Udregning" 'Sætter navnet 

        'Hvis vi har side a, side b og Vinkel A
        If sideA > 0 And sideB > 0 And vinkelA > 0 Then
            'regner VinkelB, i radian, ved hjælp af sinusrelationen
            B = Math.Asin((Math.Sin(A) * b1) / a1)
            'Laver radianerne for vinkelB om til grader
            vinkelB = (180 / Math.PI) * B
            'Udregner vinkelC ud fra vinkelsum i trekanten
            vinkelC = 180 - vinkelA - vinkelB
            'Laver vinkelC om til radianer så vi kan regne med dem i visual studio
            C = vinkelC * Math.PI / 180
            'Udregner side c ud fra sinusrelation
            sideC = (Math.Sin(C) * a1) / Math.Sin(A)

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

            'Hvis vi har Side b, Side c og Vinkel C
        ElseIf sideB > 0 And sideC > 0 And vinkelC > 0 Then
            B = Math.Asin((Math.Sin(C) * b1) / c1) 'Udregner vinkel B, i radianer, ud fra sinusrelationen
            vinkelB = (180 / Math.PI) * B 'Omregner vinkel B fra radianer til grader
            vinkelA = 180 - vinkelB - vinkelC 'regner vinkel A ud fra at vinkelsummen i en trekant er 180 grader 
            A = vinkelA * Math.PI / 180 'Omregner vinkel A fra grader til radianer
            vinkelA = Math.Round(((180 / Math.PI) * A), 2)
            sideA = (Math.Sin(A) * (b1)) / (Math.Sin(B)) 'Udregner side a ud fra sinusrelationen

        End If 'Ender If statementet

        Tbox_Vavis.Text = Format(vinkelA, "###.##") 'Viser værdien for Vinkel a i tilsvarende textbox
        Tbox_Vbvis.Text = Format(vinkelB, "###.##") 'Viser værdien for Vinkel b i tilsvarende textbox
        Tbox_Vcvis.Text = Format(vinkelC, "###.##") 'Viser værdien for Vinkel c i tilsvarende textbox

        Tbox_Savis.Text = Format(sideA, "###.##") 'Viser værdien for Side a i tilsvarende textbox
        Tbox_Sbvis.Text = Format(sideB, "###.##") 'Viser værdien for Side b i tilsvarende textbox
        Tbox_Scvis.Text = Format(sideC, "###.##") 'Viser værdien for Side c i tilsvarende textbox



    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed 'Kører kode nedenunder når form 2 lukker
        End 'Stopper hele programmet
    End Sub 'Stopper subrutinen
End Class'Slutter alt koden