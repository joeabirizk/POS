<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clients))
        Dim C_idLabel As System.Windows.Forms.Label
        Dim C_nameLabel As System.Windows.Forms.Label
        Dim C_addressLabel As System.Windows.Forms.Label
        Dim Phone_nbLabel As System.Windows.Forms.Label
        Me._J_JDataSet = New pos._J_JDataSet()
        Me.Client_tBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Client_tTableAdapter = New pos._J_JDataSetTableAdapters.client_tTableAdapter()
        Me.TableAdapterManager = New pos._J_JDataSetTableAdapters.TableAdapterManager()
        Me.Client_tBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Client_tBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Client_tDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_idTextBox = New System.Windows.Forms.TextBox()
        Me.C_nameTextBox = New System.Windows.Forms.TextBox()
        Me.C_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Phone_nbTextBox = New System.Windows.Forms.TextBox()
        C_idLabel = New System.Windows.Forms.Label()
        C_nameLabel = New System.Windows.Forms.Label()
        C_addressLabel = New System.Windows.Forms.Label()
        Phone_nbLabel = New System.Windows.Forms.Label()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Client_tBindingNavigator.SuspendLayout()
        CType(Me.Client_tDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_J_JDataSet
        '
        Me._J_JDataSet.DataSetName = "_J_JDataSet"
        Me._J_JDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Client_tBindingSource
        '
        Me.Client_tBindingSource.DataMember = "client_t"
        Me.Client_tBindingSource.DataSource = Me._J_JDataSet
        '
        'Client_tTableAdapter
        '
        Me.Client_tTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.client_tTableAdapter = Me.Client_tTableAdapter
        Me.TableAdapterManager.item_tTableAdapter = Nothing
        Me.TableAdapterManager.jjusersTableAdapter = Nothing
        Me.TableAdapterManager.order_detailsTableAdapter = Nothing
        Me.TableAdapterManager.order_tTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pos._J_JDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.user_tTableAdapter = Nothing
        '
        'Client_tBindingNavigator
        '
        Me.Client_tBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Client_tBindingNavigator.BindingSource = Me.Client_tBindingSource
        Me.Client_tBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Client_tBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Client_tBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Client_tBindingNavigatorSaveItem})
        Me.Client_tBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Client_tBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Client_tBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Client_tBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Client_tBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Client_tBindingNavigator.Name = "Client_tBindingNavigator"
        Me.Client_tBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Client_tBindingNavigator.Size = New System.Drawing.Size(628, 25)
        Me.Client_tBindingNavigator.TabIndex = 0
        Me.Client_tBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 15)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'Client_tBindingNavigatorSaveItem
        '
        Me.Client_tBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Client_tBindingNavigatorSaveItem.Image = CType(resources.GetObject("Client_tBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Client_tBindingNavigatorSaveItem.Name = "Client_tBindingNavigatorSaveItem"
        Me.Client_tBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.Client_tBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Client_tDataGridView
        '
        Me.Client_tDataGridView.AllowUserToAddRows = False
        Me.Client_tDataGridView.AllowUserToDeleteRows = False
        Me.Client_tDataGridView.AutoGenerateColumns = False
        Me.Client_tDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Client_tDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.Client_tDataGridView.DataSource = Me.Client_tBindingSource
        Me.Client_tDataGridView.Location = New System.Drawing.Point(12, 141)
        Me.Client_tDataGridView.Name = "Client_tDataGridView"
        Me.Client_tDataGridView.ReadOnly = True
        Me.Client_tDataGridView.Size = New System.Drawing.Size(586, 173)
        Me.Client_tDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "c_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "c_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "c_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "c_name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "c_address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "c_address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "phone_nb"
        Me.DataGridViewTextBoxColumn4.HeaderText = "phone_nb"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'C_idLabel
        '
        C_idLabel.AutoSize = True
        C_idLabel.Location = New System.Drawing.Point(21, 36)
        C_idLabel.Name = "C_idLabel"
        C_idLabel.Size = New System.Drawing.Size(27, 13)
        C_idLabel.TabIndex = 2
        C_idLabel.Text = "c id:"
        '
        'C_idTextBox
        '
        Me.C_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "c_id", True))
        Me.C_idTextBox.Location = New System.Drawing.Point(83, 33)
        Me.C_idTextBox.Name = "C_idTextBox"
        Me.C_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.C_idTextBox.TabIndex = 3
        '
        'C_nameLabel
        '
        C_nameLabel.AutoSize = True
        C_nameLabel.Location = New System.Drawing.Point(21, 62)
        C_nameLabel.Name = "C_nameLabel"
        C_nameLabel.Size = New System.Drawing.Size(45, 13)
        C_nameLabel.TabIndex = 4
        C_nameLabel.Text = "c name:"
        '
        'C_nameTextBox
        '
        Me.C_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "c_name", True))
        Me.C_nameTextBox.Location = New System.Drawing.Point(83, 59)
        Me.C_nameTextBox.Name = "C_nameTextBox"
        Me.C_nameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.C_nameTextBox.TabIndex = 5
        '
        'C_addressLabel
        '
        C_addressLabel.AutoSize = True
        C_addressLabel.Location = New System.Drawing.Point(21, 88)
        C_addressLabel.Name = "C_addressLabel"
        C_addressLabel.Size = New System.Drawing.Size(56, 13)
        C_addressLabel.TabIndex = 6
        C_addressLabel.Text = "c address:"
        '
        'C_addressTextBox
        '
        Me.C_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "c_address", True))
        Me.C_addressTextBox.Location = New System.Drawing.Point(83, 85)
        Me.C_addressTextBox.Name = "C_addressTextBox"
        Me.C_addressTextBox.Size = New System.Drawing.Size(100, 20)
        Me.C_addressTextBox.TabIndex = 7
        '
        'Phone_nbLabel
        '
        Phone_nbLabel.AutoSize = True
        Phone_nbLabel.Location = New System.Drawing.Point(21, 114)
        Phone_nbLabel.Name = "Phone_nbLabel"
        Phone_nbLabel.Size = New System.Drawing.Size(55, 13)
        Phone_nbLabel.TabIndex = 8
        Phone_nbLabel.Text = "phone nb:"
        '
        'Phone_nbTextBox
        '
        Me.Phone_nbTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "phone_nb", True))
        Me.Phone_nbTextBox.Location = New System.Drawing.Point(83, 111)
        Me.Phone_nbTextBox.Name = "Phone_nbTextBox"
        Me.Phone_nbTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Phone_nbTextBox.TabIndex = 9
        '
        'Clients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 334)
        Me.Controls.Add(C_idLabel)
        Me.Controls.Add(Me.C_idTextBox)
        Me.Controls.Add(C_nameLabel)
        Me.Controls.Add(Me.C_nameTextBox)
        Me.Controls.Add(C_addressLabel)
        Me.Controls.Add(Me.C_addressTextBox)
        Me.Controls.Add(Phone_nbLabel)
        Me.Controls.Add(Me.Phone_nbTextBox)
        Me.Controls.Add(Me.Client_tDataGridView)
        Me.Controls.Add(Me.Client_tBindingNavigator)
        Me.Name = "Clients"
        Me.Text = "Clients"
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Client_tBindingNavigator.ResumeLayout(False)
        Me.Client_tBindingNavigator.PerformLayout()
        CType(Me.Client_tDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _J_JDataSet As _J_JDataSet
    Friend WithEvents Client_tBindingSource As BindingSource
    Friend WithEvents Client_tTableAdapter As _J_JDataSetTableAdapters.client_tTableAdapter
    Friend WithEvents TableAdapterManager As _J_JDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Client_tBindingNavigator As BindingNavigator
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
    Friend WithEvents Client_tBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Client_tDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents C_idTextBox As TextBox
    Friend WithEvents C_nameTextBox As TextBox
    Friend WithEvents C_addressTextBox As TextBox
    Friend WithEvents Phone_nbTextBox As TextBox
End Class
