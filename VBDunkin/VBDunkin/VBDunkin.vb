'Name: Alex Winstanley
'Date:3/12/15
'Purpose: to create a program that computes the cost of donuts
Public Class frmDunkin

    'constants
    Const DONUT_PRICE As Double = 0.75
    Const DOZEN_PRICE As Double = 7
    Const HALFDOZEN_PRICE As Double = 4


    'Clears the Program
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        frmDunkin_Load(sender, e)
    End Sub

    'Exits the program
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'Ensures the program is clear
    Private Sub frmDunkin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNumDonuts.Clear()
        txtCostDonuts.Clear()
        txtCostPurchase.Clear()
        txtTax.Clear()
        txtNumDonuts.Focus()
    End Sub

    'Finds the answer

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        'LOCAL VARIBLES
        Dim numDonuts, dozen, halfDozen, donut As Integer
        Dim finalCost, taxDonuts, basicCost As Decimal

        'Gets the numbers
        numDonuts = Val(txtNumDonuts.Text)

        'labels the numbers
        dozen = numDonuts \ 12
        numDonuts = numDonuts Mod 12
        halfDozen = numDonuts \ 6
        numDonuts = numDonuts Mod 6
        donut = numDonuts

        'Computes the numbers
        basicCost = (dozen * DOZEN_PRICE) + (halfDozen * HALFDOZEN_PRICE) + (donut * DONUT_PRICE)
        taxDonuts = basicCost * 0.06
        finalCost = basicCost + taxDonuts

        'Displays number
        txtCostDonuts.Text = basicCost.ToString("c")
        txtTax.Text = taxDonuts.ToString("c")
        txtCostPurchase.Text = finalCost.ToString("c")
    End Sub
End Class
