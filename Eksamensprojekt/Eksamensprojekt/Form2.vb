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
        'Lbl_vis.Text = vinkelA
        'Lbl_vis.Text = vinkelB
        'Lbl_vis.Text = sideA
        'Lbl_vis.Text = sideB
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load












        'Udregning Vinkel B
        If sideA + vinkelA + sideB > 0 Then ' Her tjekkes om der er indtastet noget på vores vinkler og sider. 
            A = vinkelA 'Angiver VinkelA til A
            B = Math.Asin((Math.Sin(A) * sideB) / sideA) 'Udregner med Arcussinus og finder vinkel B i radianer
            vinkelB = (180 / Math.PI) * B 'Omregner til grader
            vinkelA = (180 / Math.PI) * A 'Omregner til grader
            MsgBox(vinkelA & "   " & vinkelB) ' Viser i MSGboks
        End If

        Lbl_vis.Text = vinkelA
        Lbl_vis.Text = vinkelB
        Lbl_vis.Text = sideA
        Lbl_vis.Text = sideB


    End Sub
End Class