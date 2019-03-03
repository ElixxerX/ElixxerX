Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient

Public Class frmlab11
    Dim strCon As String = ConfigurationManager.ConnectionStrings("VB_ElixxerX.My.MySettings.MyData").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim strSql As String

    Private Sub Conndata()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvData.CellContentClick

    End Sub

    Private Sub frmlab11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSql = "Select * from products"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro")
        dgvData.DataSource = myDS.Tables("mypro")
    End Sub
    Private Sub DBConnect()
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()
    End Sub
    Private Sub btnChoice1_Click(sender As Object, e As EventArgs) Handles btnChoice1.Click
        DBConnect()

        strSql = "SELECT * FROM Products WHERE productname LIKE 'N%'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro1")
        dgvData.DataSource = myDS.Tables("mypro1")
        myCon.Close()
    End Sub

    Private Sub btnChoice2_Click(sender As Object, e As EventArgs) Handles btnChoice2.Click
        DBConnect()

        strSql = "SELECT (unitprice * unitsinstock) AS ProductPrice FROM Products WHERE productID LIKE 64"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro2")
        dgvData.DataSource = myDS.Tables("mypro2")
        myCon.Close()
    End Sub

    Private Sub btnChoice3_Click(sender As Object, e As EventArgs) Handles btnChoice3.Click
        DBConnect()

        strSql = "SELECT COUNT(*) AS BrazilCustomers FROM Customers WHERE country LIKE '%BRAZIL%'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro3")
        dgvData.DataSource = myDS.Tables("mypro3")
        myCon.Close()
    End Sub

    Private Sub btnChoice4_Click(sender As Object, e As EventArgs) Handles btnChoice4.Click
        DBConnect()

        strSql = "SELECT productname,quantity,contactname  FROM Customers,Orders,[Order Details],Products WHERE Customers.customerID = Orders.customerID AND Orders.orderID = [Order Details].orderID AND [Order Details].productID = Products.productID AND contactname LIKE 'Yang Wang'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro4")
        dgvData.DataSource = myDS.Tables("mypro4")
        myCon.Close()
    End Sub

    Private Sub btnChoice5_Click(sender As Object, e As EventArgs) Handles btnChoice5.Click
        DBConnect()

        strSql = "SELECT  productname,unitsinstock FROM Products WHERE unitsinstock < 10"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro5")
        dgvData.DataSource = myDS.Tables("mypro5")
        myCon.Close()
    End Sub

    Private Sub btnChoice6_Click(sender As Object, e As EventArgs) Handles btnChoice6.Click
        DBConnect()

        strSql = "SELECT * FROM [Order Details],Products WHERE [Order Details].ProductID = Products.ProductID AND OrderID LIKE 10255"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro6")
        dgvData.DataSource = myDS.Tables("mypro6")
        myCon.Close()
    End Sub

    Private Sub btnChoice7_Click(sender As Object, e As EventArgs) Handles btnChoice7.Click
        DBConnect()

        strSql = "SELECT SUM(unitprice * quantity) AS TotalSale  FROM [Order Details] WHERE OrderID LIKE 10255"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro7")
        dgvData.DataSource = myDS.Tables("mypro7")
        myCon.Close()
    End Sub

    Private Sub btnChoice8_Click(sender As Object, e As EventArgs) Handles btnChoice8.Click
        DBConnect()

        strSql = "SELECT Orders.OrderID,* FROM Customers,Orders WHERE Customers.customerID = Orders.customerID AND OrderID LIKE '10347'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro8")
        dgvData.DataSource = myDS.Tables("mypro8")
        myCon.Close()
    End Sub

    Private Sub btnChoice9_Click(sender As Object, e As EventArgs) Handles btnChoice9.Click
        DBConnect()

        strSql = "SELECT Suppliers.companyname,Orders.orderid,Orders.orderdate,Products.productname,Products.unitprice,[Order Details].quantity FROM Orders,[Order Details],Products,Suppliers WHERE Orders.orderid = [Order Details].orderid AND [Order Details].productid = Products.productid AND Products.supplierid = Suppliers.supplierid AND Suppliers.companyname LIKE '%Exotic Liquids%'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro9")
        dgvData.DataSource = myDS.Tables("mypro9")
        myCon.Close()
    End Sub

    Private Sub btnChoice10_Click(sender As Object, e As EventArgs) Handles btnChoice10.Click
        DBConnect()

        strSql = "SELECT COUNT(*) AS CountOrder FROM Customers,Orders,[Order Details],Products WHERE Customers.customerid = Orders.customerid AND Orders.orderid = [Order Details].orderid AND [Order Details].productid = Products.productid AND Customers.country LIKE 'ITALY'"
        myDA = New SqlDataAdapter(strSql, myCon)
        myDA.Fill(myDS, "mypro10")
        dgvData.DataSource = myDS.Tables("mypro10")
        myCon.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class