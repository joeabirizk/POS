<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
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
        Me.components = New System.ComponentModel.Container()
        Dim Item_idLabel As System.Windows.Forms.Label
        Dim Order_idLabel As System.Windows.Forms.Label
        Dim PriceLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(order))
        Me._J_JDataSet = New pos._J_JDataSet()
        Me.Order_tBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_tTableAdapter = New pos._J_JDataSetTableAdapters.order_tTableAdapter()
        Me.TableAdapterManager = New pos._J_JDataSetTableAdapters.TableAdapterManager()
        Me.Order_tComboBox = New System.Windows.Forms.ComboBox()
        Me.Order_detailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Order_detailsTableAdapter = New pos._J_JDataSetTableAdapters.order_detailsTableAdapter()
        Me.Item_idTextBox = New System.Windows.Forms.TextBox()
        Me.Order_idTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.Order_tBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Order_tBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Item_idLabel = New System.Windows.Forms.Label()
        Order_idLabel = New System.Windows.Forms.Label()
        PriceLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_tBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_detailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Order_tBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Order_tBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        '_J_JDataSet
        '
        Me._J_JDataSet.DataSetName = "_J_JDataSet"
        Me._J_JDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Order_tBindingSource
        '
        Me.Order_tBindingSource.DataMember = "order_t"
        Me.Order_tBindingSource.DataSource = Me._J_JDataSet
        '
        'Order_tTableAdapter
        '
        Me.Order_tTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.client_tTableAdapter = Nothing
        Me.TableAdapterManager.item_tTableAdapter = Nothing
        Me.TableAdapterManager.jjusersTableAdapter = Nothing
        Me.TableAdapterManager.order_detailsTableAdapter = Nothing
        Me.TableAdapterManager.order_tTableAdapter = Me.Order_tTableAdapter
        Me.TableAdapterManager.UpdateOrder = pos._J_JDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tTableAdapter = Nothing
        '
        'Order_tComboBox
        '
        Me.Order_tComboBox.DataSource = Me.Order_tBindingSource
        Me.Order_tComboBox.DisplayMember = "user_id"
        Me.Order_tComboBox.FormattingEnabled = True
        Me.Order_tComboBox.Location = New System.Drawing.Point(12, 58)
        Me.Order_tComboBox.Name = "Order_tComboBox"
        Me.Order_tComboBox.Size = New System.Drawing.Size(300, 21)
        Me.Order_tComboBox.TabIndex = 1
        Me.Order_tComboBox.ValueMember = "order_id"
        '
        'Order_detailsBindingSource
        '
        Me.Order_detailsBindingSource.DataMember = "FK__order_det__order__412EB0B6"
        Me.Order_detailsBindingSource.DataSource = Me.Order_tBindingSource
        '
        'Order_detailsTableAdapter
        '
        Me.Order_detailsTableAdapter.ClearBeforeFill = True
        '
        'Item_idLabel
        '
        Item_idLabel.AutoSize = True
        Item_idLabel.Location = New System.Drawing.Point(12, 101)
        Item_idLabel.Name = "Item_idLabel"
        Item_idLabel.Size = New System.Drawing.Size(40, 13)
        Item_idLabel.TabIndex = 2
        Item_idLabel.Text = "item id:"
        '
        'Item_idTextBox
        '
        Me.Item_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_detailsBindingSource, "item_id", True))
        Me.Item_idTextBox.Location = New System.Drawing.Point(65, 98)
        Me.Item_idTextBox.Name = "Item_idTextBox"
        Me.Item_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Item_idTextBox.TabIndex = 3
        '
        'Order_idLabel
        '
        Order_idLabel.AutoSize = True
        Order_idLabel.Location = New System.Drawing.Point(12, 127)
        Order_idLabel.Name = "Order_idLabel"
        Order_idLabel.Size = New System.Drawing.Size(45, 13)
        Order_idLabel.TabIndex = 4
        Order_idLabel.Text = "order id:"
        '
        'Order_idTextBox
        '
        Me.Order_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_detailsBindingSource, "order_id", True))
        Me.Order_idTextBox.Location = New System.Drawing.Point(65, 124)
        Me.Order_idTextBox.Name = "Order_idTextBox"
        Me.Order_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Order_idTextBox.TabIndex = 5
        '
        'PriceLabel
        '
        PriceLabel.AutoSize = True
        PriceLabel.Location = New System.Drawing.Point(12, 153)
        PriceLabel.Name = "PriceLabel"
        PriceLabel.Size = New System.Drawing.Size(33, 13)
        PriceLabel.TabIndex = 6
        PriceLabel.Text = "price:"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_detailsBindingSource, "price", True))
        Me.PriceTextBox.Location = New System.Drawing.Point(65, 150)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PriceTextBox.TabIndex = 7
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Location = New System.Drawing.Point(12, 179)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(47, 13)
        QuantityLabel.TabIndex = 8
        QuantityLabel.Text = "quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Order_detailsBindingSource, "quantity", True))
        Me.QuantityTextBox.Location = New System.Drawing.Point(65, 176)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(100, 20)
        Me.QuantityTextBox.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Select Order ID"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Order_tBindingNavigatorSaveItem
        '
        Me.Order_tBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Order_tBindingNavigatorSaveItem.Image = CType(resources.GetObject("Order_tBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Order_tBindingNavigatorSaveItem.Name = "Order_tBindingNavigatorSaveItem"
        Me.Order_tBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Order_tBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Order_tBindingNavigator
        '
        Me.Order_tBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Order_tBindingNavigator.BindingSource = Me.Order_tBindingSource
        Me.Order_tBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Order_tBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Order_tBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Order_tBindingNavigatorSaveItem})
        Me.Order_tBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Order_tBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Order_tBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Order_tBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Order_tBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Order_tBindingNavigator.Name = "Order_tBindingNavigator"
        Me.Order_tBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Order_tBindingNavigator.Size = New System.Drawing.Size(419, 25)
        Me.Order_tBindingNavigator.TabIndex = 0
        Me.Order_tBindingNavigator.Text = "BindingNavigator1"
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 226)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Item_idLabel)
        Me.Controls.Add(Me.Item_idTextBox)
        Me.Controls.Add(Order_idLabel)
        Me.Controls.Add(Me.Order_idTextBox)
        Me.Controls.Add(PriceLabel)
        Me.Controls.Add(Me.PriceTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(Me.Order_tComboBox)
        Me.Controls.Add(Me.Order_tBindingNavigator)
        Me.Name = "order"
        Me.Text = "order"
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_tBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_detailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Order_tBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Order_tBindingNavigator.ResumeLayout(False)
        Me.Order_tBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _J_JDataSet As _J_JDataSet
    Friend WithEvents Order_tBindingSource As BindingSource
    Friend WithEvents Order_tTableAdapter As _J_JDataSetTableAdapters.order_tTableAdapter
    Friend WithEvents TableAdapterManager As _J_JDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Order_tComboBox As ComboBox
    Friend WithEvents Order_detailsBindingSource As BindingSource
    Friend WithEvents Order_detailsTableAdapter As _J_JDataSetTableAdapters.order_detailsTableAdapter
    Friend WithEvents Item_idTextBox As TextBox
    Friend WithEvents Order_idTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents Order_tBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Order_tBindingNavigator As BindingNavigator
End Class
