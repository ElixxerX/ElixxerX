Public Class frmJob4


    Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_TAX As Double = 0.07



        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_TAX


        lblYearSalary.Text = dblYearSalary.ToString("n2")
        lblBonus.Text = dblBonus.ToString("n2")
        lblAllIncome.Text = dblAllIncome.ToString("n2")
        lblAllowance.Text = dblAllowance.ToString("n2")
        lblTax.Text = dblTax.ToString("n2")


    End Sub

    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged

    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenaralDate.CheckedChanged

    End Sub

    Private Sub radShortDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.Click
        lblDate.Text = Format(Now, "Short Date")
    End Sub

    Private Sub radGenaralDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenaralDate.Click
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radLongDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.Click
        lblDate.Text = Format(Now, "Long Date")
    End Sub
End Class