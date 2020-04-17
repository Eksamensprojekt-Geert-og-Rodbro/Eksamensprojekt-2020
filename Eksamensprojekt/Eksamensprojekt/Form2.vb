Public Class Form2
    Private Sub But_tilbage_Click(sender As Object, e As EventArgs) Handles But_tilbage.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Beregner()
        'Kæmpe if statement hvor vi bruger case, hvis vi har A B og C så skal vi en ting, hvis vi har A B og c skal vi noget andet og så videre.

    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        A = vinkelA * Math.PI / 180
        B = vinkelB * Math.PI / 180
        C = vinkelC * Math.PI / 180
        a1 = sideA
        b1 = sideB
        c1 = sideC

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
            A = Math.Asin((Math.Sin(B) * a1) / b1)
            vinkelA = (180 / Math.PI) * B
            vinkelB = (180 / Math.PI) * A
            vinkelC = 180 - vinkelA - vinkelB
            C = vinkelC = Math.PI / 180
            sideC = Math.Sin(C) * a1 / Math.Sin(A)

            'Hvis vi har Side a, Side b og Vinkel C
        ElseIf sideA > 0 And sideB > 0 And vinkelC > 0 Then
            sideC = Math.Sqrt(a1 ^ 2 + b1 ^ 2 - 2 * a1 * b1 * Math.Cos(C))

            A = Math.Acos((b1 ^ 2 + c1 ^ 2 - a1 ^ 2) / 2 * b1 * c1)
            vinkelA = (180 / Math.PI) * A

            B = Math.Acos((a1 ^ 2 + c1 ^ 2 - b1 ^ 2) / 2 * a1 * c1)
            vinkelB = (180 / Math.PI) * B

            'Hvis vi har Side a, Side c og Vinkel A
        ElseIf sideA > 0 And sideC > 0 And vinkelC > 0 Then
            C = Math.Asin((Math.Sin(A) * c1 / a1))
            vinkelC = vinkelC * Math.PI / 180

            vinkelC = 180 - vinkelA - vinkelB
            C = vinkelB * Math.PI / 180

            sideB = (Math.Sin(B) * a1 / Math.Sin(A))


            'Hvis vi har Side a, Side c og Vinkel B
        ElseIf sideA > 0 And sideC > 0 And vinkelB > 0 Then
            sideB = Math.Sqrt(a1 ^ 2 + c1 ^ 2 - 2 * a1 * c1 * Math.Cos(B))

            A = Math.Acos((b1 ^ 2 + c1 ^ 2 - a1 ^ 2 / 2 * b1 * c1))
            vinkelA = (180 / Math.PI) * A

            C = Math.Acos((a1 ^ 2 + b1 ^ 2 - c1 ^ 2 / 2 * a1 * b1))
            vinkelC = (180 / Math.PI) * C

            'Hvis vi har Side a, Side c og Vinkel C
        ElseIf sideA > 0 And sideC > 0 And vinkelC > 0 Then
            A = Math.Asin(Math.Sin(C) * a1 / c1)
            vinkelA = (180 / Math.PI) * A

            vinkelB = 180 - vinkelA - vinkelC
            B = vinkelB * Math.PI / 180

            sideB = (Math.Sin(B) * a1 / Math.Sin(A))

            'Hvis vi har Side b, Side c og Vinkel A

            sideA = Math.Sqrt(b1 ^ 2 + c1 ^ 2 - 2 * b1 * c1 * Math.Cos(A))

            B = Math.Acos((a1 ^ 2 + c1 ^ 2 - b1 ^ 2) / 2 * a1 * c1)
            vinkelB


            'Hvis vi har Side b, Side c og Vinkel B


            'Hvis vi har Side b, Side c og Vinkel C




        End If













        Lbl_vis.Text = "A:" & vinkelA & " B:" & vinkelB & " C:" & vinkelC & " a:" & sideA & " b:" & sideB & " c:" & sideC

    End Sub
End Class