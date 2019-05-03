Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes
Imports System.Configuration

Public Class Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New SqlConnection("Server=HP\SQLEXPRESS; Database =J&J; Integrated Security = true")
        connection.Open()

        Dim dr As SqlClient.SqlDataReader

        Dim cmd As New SqlCommand("select * from [jjusers] where Username = @username ", connection)

        cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = UsernameTextBox.Text

        dr = cmd.ExecuteReader

        If dr.Read Then
            login2.Show()

            Me.Hide()
            UsernameTextBox.Text = ""

        Else
            MsgBox("Wrong Username, Please Try again!", MsgBoxStyle.Exclamation)
            UsernameTextBox.Text = ""
        End If


    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
