Public Class frmLab10
    Dim decSale(4, 2), i As Integer
    Dim saleName(4) As String
    Dim intIndex, decSumSale, saleA, SaleB, SaleC As Decimal
    Private Sub frmLab10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i = 0 To 4
            cboIndex.Items.Add(i + 1)
        Next
        cboIndex.SelectedIndex = 0
        cboIndex.DropDownStyle = ComboBoxStyle.DropDownList
        lblMaxSaleAmount.Text = "0"
        lblSumA.Text = "0"
        lblSumB.Text = "0"
        lblSumC.Text = "0"
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Or txtSaleName.Text = "" Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบถ้วนด้วยครับ", "ป้อนให้ครบ!!!!!!")
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            Exit Sub
        Else
            Dim x As Integer = Val(cboIndex.SelectedIndex)
            decSale(x, 0) = Val(txtSaleA.Text)
            decSale(x, 1) = Val(txtSaleB.Text)
            decSale(x, 2) = Val(txtSaleC.Text)
            saleName(x) = txtSaleName.Text
            Call showData()
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleName.Clear()

            If cboIndex.SelectedIndex < 4 Then
                cboIndex.SelectedIndex = cboIndex.SelectedIndex + 1
            Else
                cboIndex.SelectedIndex = cboIndex.SelectedIndex
            End If
        End If
    End Sub
    Private Sub showData()
        Dim salea, saleb, salec As Integer
        lstData.Items.Clear()
        For i = 0 To cboIndex.Items.Count - 1
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))
        Next

        For i = 0 To 4
            salea = salea + decSale(i, 0)
            saleb = saleb + decSale(i, 1)
            salec = salec + decSale(i, 2)
        Next

        lblSumA.Text = salea
        lblSumB.Text = saleb
        lblSumC.Text = salec

        Dim max As Integer = decSale(0, 0) + decSale(0, 1) + decSale(0, 2)
        Dim n As Integer = 0
        For i = 1 To cboIndex.Items.Count - 1
            If max < decSale(i, 0) + decSale(i, 1) + decSale(i, 2) Then
                max = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)
                n = i
            End If
            lblMaxSaleAmount.Text = max
            lblMaxSaleName.Text = saleName(n)
        Next
    End Sub
End Class