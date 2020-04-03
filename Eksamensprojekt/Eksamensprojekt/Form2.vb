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
        A = vinkelA
        B = vinkelB
        C = vinkelB
        a1 = sideA
        b1 = sideB
        c1 = sideC
        If sideA + vinkelB + sideB > 0 Then
            'A = 

        End If

        'Hvis vi har side A, side B og Vinkel A
        If sideA + vinkelA + sideB > 0 Then
            B = Math.Asin((Math.Sin(A) * b1) / a1)
            vinkelB = (180 / Math.PI) * B
            vinkelA = (180 / Math.PI) * A
            MsgBox("A: " & vinkelA & " B: " & vinkelB)
        End If

        Lbl_vis.Text = "A:" & vinkelA & " B:" & vinkelB & " C:" & vinkelC & " a:" & sideA & " b:" & sideB & " c:" & sideC

    End Sub
End Class