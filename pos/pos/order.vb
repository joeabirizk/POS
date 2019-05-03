Public Class order
    Private Sub Order_tBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Order_tBindingNavigatorSaveItem.Click, Order_tBindingNavigatorSaveItem.Click, Order_tBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Order_tBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

    End Sub

    Private Sub order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.order_details' table. You can move, or remove it, as needed.
        Me.Order_detailsTableAdapter.Fill(Me._J_JDataSet.order_details)
        'TODO: This line of code loads data into the '_J_JDataSet.order_t' table. You can move, or remove it, as needed.
        Me.Order_tTableAdapter.Fill(Me._J_JDataSet.order_t)

    End Sub
End Class