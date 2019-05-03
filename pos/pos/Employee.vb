Public Class Employee
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        User_idTextBox.Text() = ""
        AddressTextBox.Text() = ""
        User_nameTextBox.Text() = ""
        Phone_nbTextBox.Text() = ""

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Main.Show()
        Me.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.user_t' table. You can move, or remove it, as needed.
        Me.User_tTableAdapter.Fill(Me._J_JDataSet.user_t)
        'TODO: This line of code loads data into the '_J_JDataSet.client_t' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the '_J_JDataSet.client_t' table. You can move, or remove it, as needed.


    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub User_idTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Client_tBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

    End Sub

    Private Sub Client_tBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

    End Sub

    Private Sub User_tBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles User_tBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.User_tBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

        Try
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Succesully saved")
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub
End Class