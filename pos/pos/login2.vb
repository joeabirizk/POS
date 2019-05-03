Imports System.Data.SqlClient

Public Class login2

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As New SqlConnection("Server=HP\SQLEXPRESS; Database =J&J; Integrated Security = true")
        connection.Open()

        Dim dr As SqlClient.SqlDataReader

        Dim cmd As New SqlCommand("select * from [jjusers] where Userpass = @userpass ", connection)

        cmd.Parameters.Add("@userpass", SqlDbType.VarChar).Value = PasswordTextBox.Text()

        dr = cmd.ExecuteReader

        If dr.Read Then
            Main.Show()
            Me.Hide()
            PasswordTextBox.Text() = ""

        Else
            MsgBox("Wrong Password, Please Try again!", MsgBoxStyle.Exclamation)
            PasswordTextBox.Text() = ""

        End If



    End Sub

    Private Sub login2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class