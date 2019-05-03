Public Class Client
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Transaction.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        C_idTextBox1.Text() = ""
        C_nameTextBox1.Text() = ""
        C_addressTextBox1.Text() = ""
        Phone_nbTextBox1.Text() = ""


    End Sub





    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.client_t' table. You can move, or remove it, as needed.
        Me.Client_tTableAdapter.Fill(Me._J_JDataSet.client_t)
        'TODO: This line of code loads data into the '_J_JDataSet.client_t' table. You can move, or remove it, as needed.
        Me.Client_tTableAdapter.Fill(Me._J_JDataSet.client_t)
        'TODO: This line of code loads data into the '_J_JDataSet.Client' table. You can move, or remove it, as needed.

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub C_idTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub


End Class