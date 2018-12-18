Public Class frmLab5
    Dim decTotal, decDiscount, decNumber, decNet, decCredit As Double
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        If decTotal < 1000 And radPaid.Checked And radMember.Checked Then
            decDiscount = 0
            lblDiscount.Text = "0%"
        ElseIf decTotal < 5000 And radPaid.Checked And radMember.Checked Then
            decDiscount = 0.05
            lblDiscount.Text = "5%"
        ElseIf decTotal < 10000 And radPaid.Checked And radMember.Checked Then
            decDiscount = 0.1
            lblDiscount.Text = "10%"
        ElseIf decTotal >= 10000 And radPaid.Checked And radMember.Checked Then
            decDiscount = 0.15
            lblDiscount.Text = "15%"
        Else
            decDiscount = 0
        End If
        decDiscount = decTotal * decDiscount
        decNet = decTotal - decDiscount

        lblDiscount.Text = decDiscount
        lblPaid.Text = decNet

        If radCredit.Checked Then
            lblCredit.Text = decNet
        Else
            lblCredit.Text = 0
        End If



    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        decTotal = Val(txtPrice.Text)
        lblTotal.Text = decTotal
    End Sub

    Private Sub txtUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUnit.TextChanged
        decTotal = Val(txtPrice.Text) * Val(txtUnit.Text)
        lblTotal.Text = decTotal
    End Sub

    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
        radCredit.Enabled = True
    End Sub

    Private Sub frmLab5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radMember.Select()
        radPaid.Select()
    End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
        radPaid.Select()
        radCredit.Enabled = False
    End Sub

    Private Sub radPaid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPaid.CheckedChanged
        lblCredit.Text = ""
        lblDiscount.Text = ""
        lblPaid.Text = ""
    End Sub
End Class