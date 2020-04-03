Public Class Form2
    Dim pi As Single
    Dim clickmix As Decimal
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
        A = vinkelA
        B = vinkelB
        C = vinkelB
        a1 = sideA
        b1 = sideB
        c1 = sideC
        If sideA + vinkelB + sideB > 0 Then
            A = 

        End If

        'Hvis vi har sideA, vinkelA og sideB
        If sideA + vinkelA + sideB > 0 Then
            B = Math.Asin((Math.Sin(A) * b1) / a1)
            vinkelB = (180 / pi) * B
            vinkelA = (180 / pi) * A
            MsgBox("A: " & vinkelA & " B: " & vinkelB)
        End If


        Lbl_vis.Text = vinkelA
        Lbl_vis.Text = vinkelB
        Lbl_vis.Text = sideA
        Lbl_vis.Text = sideB






        'Hvis vi har sideB, vinkelA og sideC
        If sideB + vinkelA + sideC > 0 Then
            C = Math.Asin((Math.Sin(A) * c1) / a1)
            vinkelB = (180 / pi) * B
            vinkelA = (180 / pi) * A
            MsgBox("A: " & vinkelA & " B: " & vinkelB)
        End If

    End Sub
End Class