'Indsæt paranteser for at fikse overflow
' kører alle udregninger igennem på cossincalc

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
            'regner VinkelB, i radian, ved hjælp af cosinusrelationen
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
            sideC = Math.Sqrt(a1 ^ 2 + b1 ^ 2 - 2 * a1 * b1 * Math.Cos(C))
            c1 = sideC

            A = Math.Acos((b1 ^ 2 + c1 ^ 2 - a1 ^ 2) / (2 * b1 * c1))
            A = Format(A, "###.##")
            vinkelA = (180 / Math.PI) * A

            B = Math.Round(Math.Acos((a1 ^ 2 + c1 ^ 2 - b1 ^ 2) / (2 * a1 * c1)), 2)

            vinkelB = (180 / Math.PI) * B


            'Hvis vi har Side a, Side c og Vinkel A 
        ElseIf sideA > 0 And sideC > 0 And vinkelA > 0 Then
            C = Math.Asin((Math.Sin(A) * c1) / a1)
            vinkelC = 180 / Math.PI * C

            vinkelB = 180 - vinkelA - vinkelC
            B = vinkelB * Math.PI / 18

            sideB = (Math.Sin(B) * a1 / Math.Sin(A))


            'Hvis vi har Side a, Side c og Vinkel B
        ElseIf sideA > 0 And sideC > 0 And vinkelB > 0 Then
            sideB = Math.Sqrt(a1 ^ 2 + c1 ^ 2 - 2 * a1 * c1 * Math.Cos(B))
            b1 = sideB

            A = Math.Acos((b1 ^ 2 + c1 ^ 2 - a1 ^ 2) / (2 * b1 * c1))
            vinkelA = (180 / Math.PI) * A

            C = Math.Acos((a1 ^ 2 + b1 ^ 2 - c1 ^ 2) / (2 * a1 * b1))
            vinkelC = (180 / Math.PI) * C

            'Hvis vi har Side a, Side c og Vinkel C
        ElseIf sideA > 0 And sideC > 0 And vinkelC > 0 Then
            A = Math.Asin(Math.Sin(C) * a1 / c1)
            vinkelA = (180 / Math.PI) * A

            vinkelB = 180 - vinkelA - vinkelC
            B = vinkelB * Math.PI / 180

            sideB = (Math.Sin(B) * a1 / Math.Sin(A))

            'Hvis vi har Side b, Side c og Vinkel A
        ElseIf sideB > 0 And sideC > 0 And vinkelA > 0 Then
            sideA = Math.Sqrt(b1 ^ 2 + c1 ^ 2 - 2 * b1 * c1 * Math.Cos(A))
            a1 = sideA

            B = Math.Acos((a1 ^ 2 + c1 ^ 2 - b1 ^ 2) / (2 * a1 * c1))
            vinkelB = (180 / Math.PI) * B

            C = Math.Acos((a1 ^ 2 + b1 ^ 2 - c1 ^ 2) / (2 * a1 * b1))
            vinkelC = (180 / Math.PI) * C


            'Hvis vi har Side b, Side c og Vinkel B
        ElseIf sideB > 0 And sideC > 0 And vinkelB > 0 Then
            C = Math.Asin((Math.Sin(B) * c1) / b1)
            vinkelC = (180 / Math.PI) * C

            vinkelA = 180 - vinkelB - vinkelC
            A = vinkelA * Math.PI / 180

            sideA = (Math.Sin(A) * b1) / Math.Sin(B)
            a1 = sideA

            'Hvis vi har Side b, Side c og Vinkel C
        ElseIf sideB > 0 And sideC > 0 And vinkelC > 0 Then
            B = Math.Asin((Math.Sin(C) * b1) / c1)
            vinkelB = (180 / Math.PI) * B

            vinkelA = 180 - vinkelB - vinkelC
            A = vinkelA * Math.PI / 180

            vinkelA = Math.Round(((180 / Math.PI) * A), 2)

            sideA = (Math.Sin(A) * (b1)) / (Math.Sin(B))
            a1 = sideA



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
    End Sub
End Class