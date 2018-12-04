Public Class lab2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim computer, printer, totalSale, com1, com2, comsum As Double
        computer = Val(txtComputer.Text)
        printer = Val(txtPrinter.Text)
        totalSale = computer + printer
        com1 = totalSale * 0.05
        com2 = totalSale * 0.1
        comsum = com1 + com2
        lbltotal.Text = totalSale
        lblcom1.Text = com1
        lblcom2.Text = com2
        lbltotalcom.Text = comsum


        



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class