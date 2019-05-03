Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes
Imports System.Configuration
Imports System.Drawing.Imaging
Public Class Customers
    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New SqlConnection("Server=HP\SQLEXPRESS; Database =J&J; Integrated Security = true")
        Dim query As String = "Select c_name as 'Name',order_t.order_id as 'Order ID',order_date as 'Date',user_id as 'Serviced by',item_id as 'Item ID', quantity as 'Quantity', price As 'Price'
        From client_t,order_t,order_details
where order_t.order_id = order_details.order_id
and  client_t.c_address = order_t.c_id
and c_name like '@VALUE';"

        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.Add("@VALUE", SqlDbType.VarChar).Value = TextBox1.Text

        Dim adapter As New SqlDataAdapter(cmd)

        Dim table As New DataTable

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub
End Class