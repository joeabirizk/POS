Public Class CURRENCY
    Private Sub Button1_Click(sender As Object, e As EventArgs) 
        Transaction.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 

    End Sub



    Private Sub CURRENCY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label4.Hide()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "LBP" Then
            If ComboBox2.Text = "$ USD" Then
                Label4.Text = "The amount is $" & TextBox1.Text * 0.00066 & " USD"
                Label4.Show()
            Else
                If ComboBox2.Text = "€ Euro" Then
                    Label4.Text = "The amount is €" & TextBox1.Text * 0.00059 & " Euros"
                    Label4.Show()
                Else
                    Label4.Text = "You cannot convert from LBP to LBP (Same Currency)"
                    Label4.Show()
                End If
            End If
        End If
        If ComboBox1.Text = "$ USD" Then
            If ComboBox2.Text = "LBP" Then
                Label4.Text = "The amount is " & TextBox1.Text * 1507.95 & " L.L"
                Label4.Show()
            Else
                If ComboBox2.Text = "€ Euro" Then
                    Label4.Text = "The amount is €" & TextBox1.Text * 0.89 & " Euros"
                    Label4.Show()
                Else
                    Label4.Text = "You cannot convert from USD to USD (Same Currency)"
                    Label4.Show()
                End If
            End If
        End If
        If ComboBox1.Text = "€ Euro" Then
            If ComboBox2.Text = "LBP" Then
                Label4.Text = "The amount is " & TextBox1.Text * 1691.39 & " L.L"
                Label4.Show()
            Else
                If ComboBox2.Text = "$ USD" Then
                    Label4.Text = "The amount is $" & TextBox1.Text * 1.12 & " USD"
                    Label4.Show()
                Else
                    Label4.Text = "You cannot convert from Euro to Euro (Same Currency)"
                    Label4.Show()
                End If
            End If
        End If

    End Sub
End Class