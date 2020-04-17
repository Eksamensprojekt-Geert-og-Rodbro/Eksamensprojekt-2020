Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        A = vinkelA
        B = vinkelB
        C = vinkelC
        a1 = sideA
        b1 = sideB
        c1 = sideC

        'Hvis vi har Side b, Side c og Vinkel B
        If sideB > 0 And sideC > 0 And vinkelB > 0 Then
            C = Math.Asin((Math.Sin(B) * c1) / b1)
            vinkelC = (180 / Math.PI) * C

            A = 180 - B - C
            vinkelA = (180 / Math.PI) * A

            sideA = (Math.Sin(A) * b1) / Math.Sin(B)
            a1 = sideA

            'Hvis vi har Side b, Side c og Vinkel C
        ElseIf sideB > 0 And sideC > 0 And vinkelC > 0 Then
            B = Math.Asin((Math.Sin(C) * b1))
            B = vinkelB * Math.PI / 180

            A = 180 - B - C
            vinkelA = (180 / Math.PI) * A

            sideA = (Math.Sin(A) * b1 / Math.Sin(B))
            a1 = sideA


            Lbl_vis.Text = "A:" & vinkelA & " B:" & vinkelB & " C:" & vinkelC & " a:" & sideA & " b:" & sideB & " c:" & sideC




    End Sub
End Class