Public Class frmRoyalClub
    Private Sub btnMenus_Click(sender As Object, e As EventArgs) Handles btnMenus.Click
        Dim frmRoyalClub As New frmMenus

        Hide()
        frmRoyalClub.ShowDialog()
    End Sub

    Private Sub btnSpecials_Click(sender As Object, e As EventArgs) Handles btnSpecials.Click
        Dim frmRoyalClub As New frmSpecials

        Hide()
        frmRoyalClub.ShowDialog()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim frmRoyalClub As New frmReservation

        Hide()
        frmRoyalClub.ShowDialog()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        mskEmail.Clear()
        MsgBox("You have been added to our emailing list!")

    End Sub
End Class