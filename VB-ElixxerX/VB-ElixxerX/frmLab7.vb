Public Class frmLab7

    Private Sub frmLab7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        txtAdd.Focus()
        Dim n As Integer
        n = lstAdd.Items.Count
        lstAdd.SelectedIndex = n - 1
        n = cboOutpu.Items.Count
        cboOutpu.SelectedIndex = n - 1
    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("เติมข้อมูล")
        Else
            Dim a As Integer = lstAdd.SelectedIndex
            cboOutpu.Items.Add(lstAdd.SelectedItem)
            cboOutpu.SelectedIndex = cboOutpu.Items.Count - 1
            lstAdd.Items.Remove(lstAdd.SelectedItem)
            If lstAdd.Items.Count <> 0 Then
                If lstAdd.Items.Count <= a Then
                    lstAdd.SelectedIndex = lstAdd.Items.Count - 1
                Else
                    lstAdd.SelectedIndex = a
                End If
            End If
        End If
    End Sub

    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("เติมข้อมูล")
        Else
            For Each item In lstAdd.Items
                cboOutpu.Items.Add(item)
            Next
            lstAdd.Items.Clear()
            Dim n As Integer
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
            n = cboOutpu.Items.Count
            cboOutpu.SelectedIndex = n - 1
        End If
    End Sub


    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If cboOutpu.SelectedIndex = -1 Then
            MessageBox.Show("เติมข้อมูล")
        Else
            lstAdd.Items.Add(cboOutpu.Text)
            cboOutpu.Items.Remove(cboOutpu.Text)
            Dim n As Integer
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
            n = cboOutpu.Items.Count
            cboOutpu.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If cboOutpu.SelectedIndex = -1 Then
            MessageBox.Show("เติมข้อมูล")
        Else
            For Each item In cboOutpu.Items
                lstAdd.Items.Add(item)
            Next
            cboOutpu.Items.Clear()
            Dim n As Integer
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
            n = cboOutpu.Items.Count
            cboOutpu.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub lstAdd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAdd.SelectedIndexChanged
        lblOutput.Text = lstAdd.SelectedItem
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstAdd.Items.Clear()
        cboOutpu.Items.Clear()
        txtAdd.Text = ""
        lblOutput.Text = ""

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class