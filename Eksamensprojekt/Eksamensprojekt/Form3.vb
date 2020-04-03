Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        A = vinkelA
        B = vinkelB
        C = vinkelC
        a1 = sideA
        b1 = sideB
        c1 = sideC

        'Hvis vi har Side A, Side B og Vinkel B
        If sideA + sideB + vinkelB > 0 Then
            A = Math.Asin((Math.Sin(B) * a1) / b1)
            vinkelA = (180 / Math.PI) * B
            vinkelB = (180 / Math.PI) * A
            vinkelC = 180 - vinkelA - vinkelB
            C = vinkelC = Math.PI / 180
            sideC = Math.Sin(C) * a1 / Math.Sin(A)
        End If

        'Hvis vi har Side A, Side B og Vinkel C
        If sideA + sideB + vinkelB > 0 Then


            A = Math.Asin((Math.Sin(B) * a1) / b1)
            vinkelA = (180 / Math.PI) * B
            vinkelB = (180 / Math.PI) * A
            vinkelC = 180 - vinkelA - vinkelB
            C = vinkelC = Math.PI / 180
        End If


        Lbl_vis.Text = "A:" & vinkelA & " B:" & vinkelB & " C:" & vinkelC & " a:" & sideA & " b:" & sideB & " c:" & sideC




    End Sub
End Class