Public Class frmMenus
    Const Tax_Rate As Decimal = 0.0875
    Const Price_FriesWaffle As Decimal = 1.5
    Const Price_FriesSteak As Decimal = 1.25
    Const Price_FriesCurly As Decimal = 2.0
    Const Price_Soda As Decimal = 1.99
    Const Price_Tea As Decimal = 1.99
    Const Price_Water As Decimal = 0.5
    Const Price_Martini As Decimal = 6.45
    Const Price_LongI As Decimal = 7.25
    Const Price_Beer As Decimal = 5.25
    Const Price_SteakTBone As Decimal = 5.0
    Const Price_SteakFiletMig As Decimal = 6.0
    Const Price_SteakRibEye As Decimal = 6.0
    Const Price_SteakBeefTender As Decimal = 5.5
    Const Price_RedCake As Decimal = 5.5
    Const Price_Pie As Decimal = 3.25
    Const Price_IceCream As Decimal = 2.0
    ' Class level variables
    Dim subtotal As Decimal
    Dim tax As Decimal
    Dim total As Decimal

    Private Sub frmMenus_Load(sender As Object, e As EventArgs)
        ' Display a message telling the customer welcome to The Lion's Den
        MsgBox("Please explore our menu, we have great prices!")
        InitializeVariables()
        ClearCustomerSelection()
        ClearTab()
    End Sub

    Private Sub ClearTab()
        ' Clear the customer receipt
        lstTab.Items.Clear()
        lstTotal.Items.Clear()
    End Sub

    Private Sub InitializeVariables()
        ' for new customers
        subtotal = 0
        tax = 0
        total = 0
    End Sub

    Private Sub ClearCustomerSelection()
        ' for the new customers, clearing the selection
        chkSteak.Checked = False
        chkFries.Checked = False
        chkDrinks.Checked = False
        chkDessert.Checked = False
        radTboneSteak.Checked = False
        radFiletMignon.Checked = False
        radRibEye.Checked = False
        radBeefTenderloin.Checked = False
        radWaffleFries.Checked = False
        radSteakFries.Checked = False
        radCurlyFries.Checked = False
        radSoda.Checked = False
        radWater.Checked = False
        radMartini.Checked = False
        radLongIsland.Checked = False
        radBeer.Checked = False
        radCake.Checked = False
        radApplePie.Checked = False
        radIceCream.Checked = False
    End Sub

    Private Sub btnSpecials_Click(sender As Object, e As EventArgs) Handles btnSpecials.Click
        Dim frmMenu As New frmSpecials

        Hide()
        frmMenu.ShowDialog()
    End Sub

    Private Sub btnRoyalClub_Click(sender As Object, e As EventArgs) Handles btnRoyalClub.Click
        Dim frmMenu As New frmRoyalClub

        Hide()
        frmMenu.ShowDialog()
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim frmMenu As New frmReservation

        Hide()
        frmMenu.ShowDialog()
    End Sub

    Private Sub chkSteak_CheckedChanged(sender As Object, e As EventArgs) Handles chkSteak.CheckedChanged
        If chkSteak.Checked = True Then
            grpSteakChoices.Visible = True
        Else
            grpSteakChoices.Visible = False
        End If
    End Sub

    Private Sub chkFries_CheckedChanged(sender As Object, e As EventArgs) Handles chkFries.CheckedChanged
        If chkFries.Checked = True Then
            grpFries.Visible = True
        Else
            grpFries.Visible = False
        End If
    End Sub

    Private Sub chkDrinks_CheckedChanged(sender As Object, e As EventArgs) Handles chkDrinks.CheckedChanged
        If chkDrinks.Checked = True Then
            grpDrinks.Visible = True
        Else
            grpDrinks.Visible = False
        End If
    End Sub

    Private Sub chkDessert_CheckedChanged(sender As Object, e As EventArgs) Handles chkDessert.CheckedChanged
        If chkDessert.Checked = True Then
            grpDessert.Visible = True
        Else
            grpDessert.Visible = False
        End If
    End Sub

    Private Sub FindPrice()
        If chkSteak.Checked = True Then
            If radTboneSteak.Checked Then
                subtotal += Price_SteakTBone
                Dim Steak As String =
                    Price_SteakTBone.ToString("C") & " T-Bone Steak"
                lstTab.Items.Add(Steak)
            ElseIf radFiletMignon.Checked = True Then
                subtotal += Price_SteakFiletMig
                Dim Steak2 As String =
                    Price_SteakFiletMig.ToString("C") & " Filet Mignon Steak"
                lstTab.Items.Add(Steak2)
            ElseIf radRibEye.Checked = True Then
                subtotal += Price_SteakRibEye
                Dim Steak3 As String =
                    Price_SteakRibEye.ToString("C") & " Rib Eye Steak"
                lstTab.Items.Add(Steak3)
            ElseIf radBeefTenderloin.Checked = True Then
                subtotal += Price_SteakBeefTender
                Dim Steak4 As String =
                    Price_SteakRibEye.ToString("C") & " Beef Tenderloin Steak"
                lstTab.Items.Add(Steak4)
            End If
        End If

        If chkFries.Checked = True Then
            If radWaffleFries.Checked Then
                subtotal += Price_FriesWaffle
                Dim Fries1 As String =
                    Price_FriesWaffle.ToString("C") & " Waffle Fries"
                lstTab.Items.Add(Fries1)
            ElseIf radSteakFries.Checked = True Then
                subtotal += Price_FriesSteak
                Dim Fries2 As String =
                    Price_FriesSteak.ToString("C") & " Steak Fries"
                lstTab.Items.Add(Fries2)
            ElseIf radCurlyFries.Checked = True Then
                subtotal += Price_FriesCurly
                Dim Fries3 As String =
                    Price_FriesCurly.ToString("C") & " Curly Fries"
                lstTab.Items.Add(Fries3)
            End If
        End If

        If chkDrinks.Checked = True Then
            If radSoda.Checked Then
                subtotal += Price_Soda
                Dim Soda As String =
                    Price_Soda.ToString("C") & " Soda"
                lstTab.Items.Add(Soda)
            ElseIf radWater.Checked = True Then
                subtotal += Price_Water
                Dim Water As String =
                    Price_Water.ToString("C") & " Water"
                lstTab.Items.Add(Water)
            ElseIf radMartini.Checked = True Then
                subtotal += Price_Martini
                Dim Martini As String =
                    Price_Martini.ToString("C") & " Martini"
                lstTab.Items.Add(Martini)
            ElseIf radLongIsland.Checked = True Then
                subtotal += Price_LongI
                Dim LongIs As String =
                    Price_LongI.ToString("C") & " Long Island"
                lstTab.Items.Add(LongIs)
            ElseIf radBeer.Checked = True Then
                subtotal += Price_Beer
                Dim Beer As String =
                    Price_Beer.ToString("C") & " Beer"
                lstTab.Items.Add(Beer)
            End If
        End If

        If chkDessert.Checked = True Then
            If radCake.Checked Then
                subtotal += Price_RedCake
                Dim Cake As String =
                    Price_RedCake.ToString("C") & " Red Velvet Cake"
                lstTab.Items.Add(Cake)
            ElseIf radApplePie.Checked = True Then
                subtotal += Price_Pie
                Dim Pie As String =
                    Price_Pie.ToString("C") & " Apple Pie"
                lstTab.Items.Add(Pie)
            ElseIf radIceCream.Checked = True Then
                subtotal += Price_IceCream
                Dim Ice As String =
                    Price_IceCream.ToString("C") & " Any Ice Cream Flavor"
                lstTab.Items.Add(Ice)
            End If
        End If
    End Sub

    Private Sub TotalCosts()
        ' Clear any previous subtotal, tax , and total
        lstTotal.Items.Clear()
        ' Display subtotal
        lstTotal.Items.Add("Subtotal = " & subtotal.ToString("C"))
        ' Display the tax
        tax = subtotal * Tax_Rate
        lstTotal.Items.Add("        Tax = " & tax.ToString("C"))
        ' Display the total
        total = subtotal + tax
        lstTotal.Items.Add("        Total = " & total.ToString("C"))

        ' Separate each customer's order on the same tab
        lstTab.Items.Add("----------------------------")

    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        FindPrice()
        TotalCosts()
        'ClearCustomerSelection()

    End Sub

    Private Sub btnClearTab_Click(sender As Object, e As EventArgs) Handles btnClearTab.Click
        InitializeVariables()
        ClearCustomerSelection()
        ClearTab()
    End Sub

    Private Sub frmMenus_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class