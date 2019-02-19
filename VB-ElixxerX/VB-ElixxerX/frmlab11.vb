Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmlab11
    Dim myDa As New SqlDataAdapter
    Dim myDs As New DataSet
    Dim myConn As New SqlConnection

    Dim strCon As String = ConfigurationManager.ConnectionStrings("VB_ElixxerX.My.MySettings.MyData").ConnectionString

    Private Sub Conndata()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
        myConn.ConnectionString = strCon
        myConn.Open()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub frmlab11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnChoice1_Click(sender As Object, e As EventArgs) Handles btnChoice1.Click
        Conndata()
        strCon = "select productID , productname,unitsInstock , unitpri"
    End Sub

    Private Sub btnChoice2_Click(sender As Object, e As EventArgs) Handles btnChoice2.Click

    End Sub
End Class