Public Class frmReservation
    Private Sub btnMenus_Click(sender As Object, e As EventArgs) Handles btnMenus.Click
        Dim frmReservation As New frmMenus

        Hide()
        frmReservation.ShowDialog()
    End Sub

    Private Sub btnSpecials_Click(sender As Object, e As EventArgs) Handles btnSpecials.Click
        Dim frmReservation As New frmSpecials

        Hide()
        frmReservation.ShowDialog()
    End Sub

    Private Sub btnRoyalClub_Click(sender As Object, e As EventArgs) Handles btnRoyalClub.Click
        Dim frmReservation As New frmRoyalClub

        Hide()
        frmReservation.ShowDialog()
    End Sub

    Private Sub frmReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim InputError As Boolean = False

        If cboSeatingType.SelectedIndex < 0 Then
            MsgBox("Please select the type of seating you would like", , "Error")
            cboSeatingType.Focus()
            InputError = True
        ElseIf txtNumOfCustomers.TextLength < 1 Then
            MsgBox("Enter number of customers in Customer box", , "Error")
            txtNumOfCustomers.Clear()
            txtNumOfCustomers.Focus()
            InputError = True

        ElseIf txtName.TextLength < 1 Then
            MsgBox("Enter the name of reservation", , "Error")
            txtName.Clear()
            txtName.Focus()
            InputError = True

        End If

        Dim SeatingType As String
        Dim NumberOfCustomers As String
        Dim Name As String

        SeatingType = cboSeatingType.SelectedItem
        NumberOfCustomers = txtNumOfCustomers.Text
        Name = txtName.Text

        Dim strNameandLocationOfFile As String = "Reservation List.txt"

        Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameandLocationOfFile)

        objWriter.Write(SeatingType & ",")
        objWriter.Write(NumberOfCustomers & ",")
        objWriter.Write(Name & ",")
        objWriter.Close()

        cboSeatingType.Text = "Select seating type"
        txtNumOfCustomers.Clear()
        txtName.Clear()
        MsgBox("Your reservation has been created, thank you!")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        cboSeatingType.Text = "Select seating type"
        txtNumOfCustomers.Clear()
        txtName.Clear()
    End Sub

End Class