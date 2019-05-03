<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Employee
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim User_idLabel As System.Windows.Forms.Label
        Dim User_nameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Phone_nbLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Me._J_JDataSet = New pos._J_JDataSet()
        Me.User_tBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.User_tTableAdapter = New pos._J_JDataSetTableAdapters.user_tTableAdapter()
        Me.TableAdapterManager = New pos._J_JDataSetTableAdapters.TableAdapterManager()
        Me.User_tBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.User_tBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.User_idTextBox = New System.Windows.Forms.TextBox()
        Me.User_nameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_nbTextBox = New System.Windows.Forms.TextBox()
        User_idLabel = New System.Windows.Forms.Label()
        User_nameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Phone_nbLabel = New System.Windows.Forms.Label()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_tBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.User_tBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.User_tBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'User_idLabel
        '
        User_idLabel.AutoSize = True
        User_idLabel.Location = New System.Drawing.Point(26, 52)
        User_idLabel.Name = "User_idLabel"
        User_idLabel.Size = New System.Drawing.Size(41, 13)
        User_idLabel.TabIndex = 1
        User_idLabel.Text = "user id:"
        '
        'User_nameLabel
        '
        User_nameLabel.AutoSize = True
        User_nameLabel.Location = New System.Drawing.Point(26, 78)
        User_nameLabel.Name = "User_nameLabel"
        User_nameLabel.Size = New System.Drawing.Size(59, 13)
        User_nameLabel.TabIndex = 3
        User_nameLabel.Text = "user name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(353, 52)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(47, 13)
        AddressLabel.TabIndex = 5
        AddressLabel.Text = "address:"
        '
        'Phone_nbLabel
        '
        Phone_nbLabel.AutoSize = True
        Phone_nbLabel.Location = New System.Drawing.Point(353, 78)
        Phone_nbLabel.Name = "Phone_nbLabel"
        Phone_nbLabel.Size = New System.Drawing.Size(55, 13)
        Phone_nbLabel.TabIndex = 7
        Phone_nbLabel.Text = "phone nb:"
        '
        '_J_JDataSet
        '
        Me._J_JDataSet.DataSetName = "_J_JDataSet"
        Me._J_JDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_tBindingSource
        '
        Me.User_tBindingSource.DataMember = "user_t"
        Me.User_tBindingSource.DataSource = Me._J_JDataSet
        '
        'User_tTableAdapter
        '
        Me.User_tTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.client_tTableAdapter = Nothing
        Me.TableAdapterManager.item_tTableAdapter = Nothing
        Me.TableAdapterManager.jjusersTableAdapter = Nothing
        Me.TableAdapterManager.order_detailsTableAdapter = Nothing
        Me.TableAdapterManager.order_tTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pos._J_JDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tTableAdapter = Me.User_tTableAdapter
        '
        'User_tBindingNavigator
        '
        Me.User_tBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.User_tBindingNavigator.BindingSource = Me.User_tBindingSource
        Me.User_tBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.User_tBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.User_tBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.User_tBindingNavigatorSaveItem})
        Me.User_tBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.User_tBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.User_tBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.User_tBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.User_tBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.User_tBindingNavigator.Name = "User_tBindingNavigator"
        Me.User_tBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.User_tBindingNavigator.Size = New System.Drawing.Size(698, 25)
        Me.User_tBindingNavigator.TabIndex = 0
        Me.User_tBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'User_tBindingNavigatorSaveItem
        '
        Me.User_tBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.User_tBindingNavigatorSaveItem.Image = CType(resources.GetObject("User_tBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.User_tBindingNavigatorSaveItem.Name = "User_tBindingNavigatorSaveItem"
        Me.User_tBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.User_tBindingNavigatorSaveItem.Text = "Save Data"
        '
        'User_idTextBox
        '
        Me.User_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tBindingSource, "user_id", True))
        Me.User_idTextBox.Location = New System.Drawing.Point(91, 49)
        Me.User_idTextBox.Name = "User_idTextBox"
        Me.User_idTextBox.Size = New System.Drawing.Size(239, 20)
        Me.User_idTextBox.TabIndex = 2
        '
        'User_nameTextBox
        '
        Me.User_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tBindingSource, "user_name", True))
        Me.User_nameTextBox.Location = New System.Drawing.Point(91, 75)
        Me.User_nameTextBox.Name = "User_nameTextBox"
        Me.User_nameTextBox.Size = New System.Drawing.Size(239, 20)
        Me.User_nameTextBox.TabIndex = 4
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(418, 49)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(239, 20)
        Me.AddressTextBox.TabIndex = 6
        '
        'Phone_nbTextBox
        '
        Me.Phone_nbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.User_tBindingSource, "phone_nb", True))
        Me.Phone_nbTextBox.Location = New System.Drawing.Point(418, 75)
        Me.Phone_nbTextBox.Name = "Phone_nbTextBox"
        Me.Phone_nbTextBox.Size = New System.Drawing.Size(239, 20)
        Me.Phone_nbTextBox.TabIndex = 8
        '
        'Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 139)
        Me.Controls.Add(User_idLabel)
        Me.Controls.Add(Me.User_idTextBox)
        Me.Controls.Add(User_nameLabel)
        Me.Controls.Add(Me.User_nameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Phone_nbLabel)
        Me.Controls.Add(Me.Phone_nbTextBox)
        Me.Controls.Add(Me.User_tBindingNavigator)
        Me.Name = "Employee"
        Me.Text = "Employee"
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_tBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.User_tBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.User_tBindingNavigator.ResumeLayout(False)
        Me.User_tBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _J_JDataSet As _J_JDataSet
    Friend WithEvents User_tBindingSource As BindingSource
    Friend WithEvents User_tTableAdapter As _J_JDataSetTableAdapters.user_tTableAdapter
    Friend WithEvents TableAdapterManager As _J_JDataSetTableAdapters.TableAdapterManager
    Friend WithEvents User_tBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents User_tBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents User_idTextBox As TextBox
    Friend WithEvents User_nameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Phone_nbTextBox As TextBox
End Class
