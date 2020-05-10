Public Class Form2
    Private Sub But_tilbage_Click(sender As Object, e As EventArgs) Handles But_tilbage.Click 'Aktiverer når man klikker på knappen tilbage
        Form1.Show() 'Viser form 1
        Me.Hide() 'Gemmer form 2
    End Sub 'stopper sub rutinen

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed 'Kører kode nedenunder når form 2 lukker
        End 'Stopper hele programmet
    End Sub 'Stopper subrutinen

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Pbox_billeder1.Image = My.Resources.Clean
    End Sub
End Class'Slutter alt koden