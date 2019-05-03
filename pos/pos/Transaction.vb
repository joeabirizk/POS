Public Class Transaction


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtInvoice_TextChanged(sender As Object, e As EventArgs) Handles txtInvoice.TextChanged

    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub txtItemCode_TextChanged_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtClient_TextChanged(sender As Object, e As EventArgs) Handles txtClient.TextChanged

    End Sub

    Private Sub btnClient_Click(sender As Object, e As EventArgs)
        Client.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        CURRENCY.Show()

    End Sub

    Private Sub Transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.order_t' table. You can move, or remove it, as needed.
        Me.Order_tTableAdapter.Fill(Me._J_JDataSet.order_t)
        'TODO: This line of code loads data into the '_J_JDataSet.order_details' table. You can move, or remove it, as needed.



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_detailsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

    End Sub

    Private Sub Inv_contentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Order_tBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Order_tBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order_tBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        order.Show()

    End Sub
End Class