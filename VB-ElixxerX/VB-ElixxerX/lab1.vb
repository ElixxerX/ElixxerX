Public Class lab1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label5.Text = Val(txtsalary.Text) * 12
        Label6.Text = Label5.Text * 0.05
        Label7.Text = Label5.Text - Label6.Text

    End Sub
End Class
