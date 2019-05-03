<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim I_qtyLabel As System.Windows.Forms.Label
        Dim I_priceLabel As System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Item_idTextBox = New System.Windows.Forms.TextBox()
        Me.Item_descriptionTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        I_qtyLabel = New System.Windows.Forms.Label()
        I_priceLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'I_qtyLabel
        '
        I_qtyLabel.AutoSize = True
        I_qtyLabel.Location = New System.Drawing.Point(18, 92)
        I_qtyLabel.Name = "I_qtyLabel"
        I_qtyLabel.Size = New System.Drawing.Size(49, 13)
        I_qtyLabel.TabIndex = 60
        I_qtyLabel.Text = "Quantity:"
        '
        'I_priceLabel
        '
        I_priceLabel.AutoSize = True
        I_priceLabel.Location = New System.Drawing.Point(18, 127)
        I_priceLabel.Name = "I_priceLabel"
        I_priceLabel.Size = New System.Drawing.Size(34, 13)
        I_priceLabel.TabIndex = 62
        I_priceLabel.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Barcode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Style"
        '
        'Item_idTextBox
        '
        Me.Item_idTextBox.Location = New System.Drawing.Point(80, 31)
        Me.Item_idTextBox.Name = "Item_idTextBox"
        Me.Item_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Item_idTextBox.TabIndex = 63
        '
        'Item_descriptionTextBox
        '
        Me.Item_descriptionTextBox.Location = New System.Drawing.Point(80, 56)
        Me.Item_descriptionTextBox.Name = "Item_descriptionTextBox"
        Me.Item_descriptionTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Item_descriptionTextBox.TabIndex = 64
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(80, 120)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 65
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(80, 82)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 66
        '
        'stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 303)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(Me.Item_descriptionTextBox)
        Me.Controls.Add(Me.Item_idTextBox)
        Me.Controls.Add(I_priceLabel)
        Me.Controls.Add(I_qtyLabel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "stock"
        Me.Text = "stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Item_idTextBox As TextBox
    Friend WithEvents Item_descriptionTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
End Class
