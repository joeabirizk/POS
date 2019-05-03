Public Class Main
    Private Sub StockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockToolStripMenuItem.Click
        Transaction.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Login.Show()
        Login.UsernameTextBox.Text = ""

    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownToolStripMenuItem.Click
        Me.Close()


    End Sub

    Private Sub UsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsersToolStripMenuItem.Click
        Employee.Show()
    End Sub

    Private Sub InquiryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InquiryToolStripMenuItem.Click
        stock.Show()


    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub CurrencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CurrencyToolStripMenuItem.Click
        CURRENCY.Show()

    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        Customers.Show()

    End Sub

    Private Sub ClientsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientsToolStripMenuItem.Click
        Clients.Show()

    End Sub
End Class