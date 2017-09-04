Public Class frmSteakhouse
    Private Sub btnMenus_Click(sender As Object, e As EventArgs) Handles btnMenus.Click
        Dim frmHomePage As New frmMenus

        Hide()
        frmHomePage.ShowDialog()
    End Sub

    Private Sub btnSpecials_Click(sender As Object, e As EventArgs) Handles btnSpecials.Click
        Dim frmHomePage As New frmSpecials

        Hide()
        frmHomePage.ShowDialog()
    End Sub

    Private Sub btnRoyalClub_Click(sender As Object, e As EventArgs) Handles btnRoyalClub.Click
        Dim frmHomePage As New frmRoyalClub

        Hide()
        frmHomePage.ShowDialog()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim frmHomePage As New frmReservation

        Hide()
        frmHomePage.ShowDialog()
    End Sub

    Private Sub frmSteakhouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Display a message telling the customer welcome to The Lion's Den
        MsgBox("Welcome to our site!")
    End Sub
End Class
