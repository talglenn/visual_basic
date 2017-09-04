Public Class frmSpecials
    Private Sub btnMenus_Click(sender As Object, e As EventArgs) Handles btnMenus.Click
        Dim frmSpecials As New frmMenus

        Hide()
        frmSpecials.ShowDialog()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnSpecials.Click
        Dim frmReservation As New frmSpecials

        Hide()
        frmReservation.ShowDialog()
    End Sub

    Private Sub btnRoyalClub_Click(sender As Object, e As EventArgs) Handles btnRoyalClub.Click
        Dim frmSpecials As New frmRoyalClub

        Hide()
        frmSpecials.ShowDialog()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Choosing the items will display the item pictures
        If cboSpecials.Text = "Steak" Then
            picSteak.Visible = True
        ElseIf cboSpecials.Text = "Fries" Then
            picFries.Visible = True
        ElseIf cboSpecials.Text = "Drinks" Then
            picDrinks.Visible = True
        ElseIf cboSpecials.Text = "Dessert" Then
            picDessert.Visible = True
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        picFries.Visible = False
        picDrinks.Visible = False
        picSteak.Visible = False
        picDessert.Visible = False
        cboSpecials.Text = String.Empty
    End Sub
End Class