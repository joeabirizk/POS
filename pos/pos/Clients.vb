Public Class Clients
    Private Sub Client_tBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Client_tBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Client_tBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._J_JDataSet)

    End Sub

    Private Sub Clients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_J_JDataSet.client_t' table. You can move, or remove it, as needed.
        Me.Client_tTableAdapter.Fill(Me._J_JDataSet.client_t)

    End Sub
End Class