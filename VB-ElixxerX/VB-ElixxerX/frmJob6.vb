Public Class frmJob6
    Dim sum, total As Double
    Private Sub frmJob6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        total = 1325000
        total = Val(lblSartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
        lblPaidPrice.Text = ""
    End Sub
    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFree1.Click

    End Sub

    Private Sub chkCarForMe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.CheckedChanged

        If chkCarForMe.Checked Then
            lblPaidPrice.Text = total
            chkItemsAdd1.Enabled = True
            chkItemsAdd2.Enabled = True
            chkItemsAdd3.Enabled = True
            chkItemsAdd4.Enabled = True
            chkFree1.Enabled = True
            chkFree2.Enabled = True
            chkFree3.Enabled = True
        Else
            If MsgBox("ต้องการยกเลิก", vbYesNo) = vbYes Then

                chkItemsAdd1.Enabled = False
                chkItemsAdd2.Enabled = False
                chkItemsAdd3.Enabled = False
                chkItemsAdd4.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Enabled = False
                chkFree2.Enabled = False
                chkFree3.Enabled = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                chkCarForMe.Checked = False
                lblPaidPrice.Text = ""

            Else
                chkCarForMe.Checked = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub lblSartPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSartPrice.Click

    End Sub

    Private Sub lblSartPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSartPrice.TextChanged
       
    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked Then
            total = total + 40000
            lblPaidPrice.Text = total
        ElseIf chkItemsAdd1.Checked = False Then
            total = total - 40000
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked Then
            total = total + 50000
            lblPaidPrice.Text = total
        ElseIf chkItemsAdd2.Checked = False Then
            total = total - 50000
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked Then
            total = total + 20000
            lblPaidPrice.Text = total
        ElseIf chkItemsAdd3.Checked = False Then
            total = total - 20000
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked Then
            total = total + 30000
            lblPaidPrice.Text = total
        ElseIf chkItemsAdd4.Checked = False Then
            total = total - 30000
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            total = total - 25000
            lblPaidPrice.Text = total
        ElseIf chkFree1.Checked = False Then
            total = total + 25000
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            total = total - 15000
            lblPaidPrice.Text = total
        ElseIf chkFree2.Checked = False Then
            total = total + 15000
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            total = total - 35000
            lblPaidPrice.Text = total
        ElseIf chkFree3.Checked = False Then
            total = total + 35000
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    
End Class