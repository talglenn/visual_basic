Public Class frmSpecials
    Private Sub btnMenus_Click(sender As Object, e As EventArgs) Handles btnMenus.Click
        Dim frmSpecials As New frmMenus

        Hide()
        frmSpecials.ShowDialog()
    End Sub

    Private Sub btnRoyalClub_Click(sender As Object, e As EventArgs) Handles btnRoyalClub.Click
        Dim frmSpecials As New frmRoyalClub

        Hide()
        frmSpecials.ShowDialog()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim frmSpecials As New frmReservation

        Hide()
        frmSpecials.ShowDialog()
    End Sub
End Class