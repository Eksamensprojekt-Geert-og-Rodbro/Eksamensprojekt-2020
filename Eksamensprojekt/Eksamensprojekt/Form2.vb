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
        'clickmix = vinkelA
        'pi = 2 * Math.Asin(1)
        If sideA + vinkelA + sideB > 0 Then
            A = vinkelA '* Math.PI / 180
            B = Math.Asin((Math.Sin(A) * sideB) / sideA)
            vinkelB = (180 / Math.PI) * B
            vinkelA = (180 / Math.PI) * A
            MsgBox(vinkelA & "   " & vinkelB)
        End If
        'MsgBox(clickmix)

        Lbl_vis.Text = vinkelA
        Lbl_vis.Text = vinkelB
        Lbl_vis.Text = sideA
        Lbl_vis.Text = sideB

    End Sub
End Class