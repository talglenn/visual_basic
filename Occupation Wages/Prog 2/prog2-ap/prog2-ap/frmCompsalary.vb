' Program Name: Salaries for Computer Occupations
' Developer: Talmadge Glenn
' Date: February 27, 2017
' Purpose: This application calculates and displays
'         the yearly and annual wages for the selected
'         occupations

' Option Strict On

Public Class frmCompsalary
    Const compDevHourlyWage As Decimal = 40.56D
    Const compDevAnnualWage As Integer = 84360
    Const compSystAnalystHourlyWage As Decimal = 43.36D
    Const compSystAnalystAnnualWage As Integer = 90180
    Const compInfoSystManHourlyWage As Decimal = 67.79D
    Const compInfoSystManAnnualWage As Integer = 141000
    Const compSoftEngHourlyWage As Decimal = 49.12D
    Const compSoftEngAnnualWage As Integer = 102160
    Const raiseVal As Decimal = 0.4D


    Private Sub cboOccupation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOccupation.SelectedIndexChanged
        ' This method uses Select Cases to assign the constant variables to its respective selection

        Select Case cboOccupation.SelectedIndex
            Case 0
                lblHourlyval.Text = "$" & compDevHourlyWage
                lblAnnualval.Text = "$" & compDevAnnualWage
            Case 1
                lblHourlyval.Text = "$" & compSystAnalystHourlyWage
                lblAnnualval.Text = "$" & compSystAnalystAnnualWage
            Case 2
                lblHourlyval.Text = "$" & compInfoSystManHourlyWage
                lblAnnualval.Text = "$" & compInfoSystManAnnualWage
            Case 3
                lblHourlyval.Text = "$" & compSoftEngHourlyWage
                lblAnnualval.Text = "$" & compSoftEngAnnualWage
        End Select
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This method calculates the 4% increase in both percentage rates for each selection made

        Dim compDevNewVal1 As Integer
        Dim compDevNewVal2 As Integer
        Dim compSystAnalystNewVal1 As Integer
        Dim compSystAnalystNewVal2 As Integer
        Dim compInfoSystemManNewVal1 As Integer
        Dim compInfoSystemManNewVal2 As Integer
        Dim compSoftEngNewVal1 As Integer
        Dim compSoftEngNewVal2 As Integer

        Select Case cboOccupation.SelectedIndex
            Case 0
                compDevNewVal1 = compDevHourlyWage * raiseVal + compDevHourlyWage
                compDevNewVal2 = compDevAnnualWage * raiseVal + compDevAnnualWage
                lblHourlyRaiseval.Text = "$" & compDevNewVal1.ToString()
                lblAnnualRaiseval.Text = "$" & compDevNewVal2.ToString()
            Case 1
                compSystAnalystNewVal1 = compSystAnalystHourlyWage * raiseVal + compSystAnalystHourlyWage
                compSystAnalystNewVal2 = compSystAnalystAnnualWage * raiseVal + compSystAnalystAnnualWage
                lblHourlyRaiseval.Text = "$" & compSystAnalystNewVal1.ToString()
                lblAnnualRaiseval.Text = "$" & compSystAnalystNewVal2.ToString()
            Case 2
                compInfoSystemManNewVal1 = compInfoSystManHourlyWage * raiseVal + compInfoSystManHourlyWage
                compInfoSystemManNewVal2 = compInfoSystManAnnualWage * raiseVal + compInfoSystManAnnualWage
                lblHourlyRaiseval.Text = "$" & compInfoSystemManNewVal1.ToString()
                lblAnnualRaiseval.Text = "$" & compInfoSystemManNewVal2.ToString()
            Case 3
                compSoftEngNewVal1 = compSoftEngHourlyWage * raiseVal + compSoftEngHourlyWage
                compSoftEngNewVal2 = compSoftEngAnnualWage * raiseVal + compSoftEngAnnualWage
                lblHourlyRaiseval.Text = "$" & compSoftEngNewVal1.ToString()
                lblAnnualRaiseval.Text = "$" & compSoftEngNewVal2.ToString()
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This method clears the values of each selection made so that a new one can be made.

        cboOccupation.Text = "Select an Occupation"
        lblHourlyval.ResetText()
        lblAnnualval.ResetText()
        lblHourlyRaiseval.ResetText()
        lblAnnualRaiseval.ResetText()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Terminates the program

        Close()
    End Sub
End Class
