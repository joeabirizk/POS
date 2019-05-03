<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Client
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
        Dim C_idLabel As System.Windows.Forms.Label
        Dim C_nameLabel As System.Windows.Forms.Label
        Dim C_addressLabel As System.Windows.Forms.Label
        Dim Phone_nbLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Client))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me._J_JDataSet = New pos._J_JDataSet()
        Me.Client_tBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Client_tTableAdapter = New pos._J_JDataSetTableAdapters.client_tTableAdapter()
        Me.TableAdapterManager = New pos._J_JDataSetTableAdapters.TableAdapterManager()
        Me.Client_tBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Client_tBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.C_idTextBox1 = New System.Windows.Forms.TextBox()
        Me.C_nameTextBox1 = New System.Windows.Forms.TextBox()
        Me.C_addressTextBox1 = New System.Windows.Forms.TextBox()
        Me.Phone_nbTextBox1 = New System.Windows.Forms.TextBox()
        C_idLabel = New System.Windows.Forms.Label()
        C_nameLabel = New System.Windows.Forms.Label()
        C_addressLabel = New System.Windows.Forms.Label()
        Phone_nbLabel = New System.Windows.Forms.Label()
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Client_tBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Client_tBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'C_idLabel
        '
        C_idLabel.AutoSize = True
        C_idLabel.Location = New System.Drawing.Point(10, 47)
        C_idLabel.Name = "C_idLabel"
        C_idLabel.Size = New System.Drawing.Size(27, 13)
        C_idLabel.TabIndex = 52
        C_idLabel.Text = "c id:"
        '
        'C_nameLabel
        '
        C_nameLabel.AutoSize = True
        C_nameLabel.Location = New System.Drawing.Point(10, 73)
        C_nameLabel.Name = "C_nameLabel"
        C_nameLabel.Size = New System.Drawing.Size(45, 13)
        C_nameLabel.TabIndex = 54
        C_nameLabel.Text = "c name:"
        '
        'C_addressLabel
        '
        C_addressLabel.AutoSize = True
        C_addressLabel.Location = New System.Drawing.Point(10, 99)
        C_addressLabel.Name = "C_addressLabel"
        C_addressLabel.Size = New System.Drawing.Size(56, 13)
        C_addressLabel.TabIndex = 56
        C_addressLabel.Text = "c address:"
        '
        'Phone_nbLabel
        '
        Phone_nbLabel.AutoSize = True
        Phone_nbLabel.Location = New System.Drawing.Point(10, 125)
        Phone_nbLabel.Name = "Phone_nbLabel"
        Phone_nbLabel.Size = New System.Drawing.Size(55, 13)
        Phone_nbLabel.TabIndex = 58
        Phone_nbLabel.Text = "phone nb:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(258, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Date of birth"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "CLient ID"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(105, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 40
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
        Me.Client_tBindingNavigator.Size = New System.Drawing.Size(577, 25)
        Me.Client_tBindingNavigator.TabIndex = 52
        Me.Client_tBindingNavigator.Text = "BindingNavigator1"
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
        'Client_tBindingNavigatorSaveItem
        '
        Me.Client_tBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Client_tBindingNavigatorSaveItem.Image = CType(resources.GetObject("Client_tBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Client_tBindingNavigatorSaveItem.Name = "Client_tBindingNavigatorSaveItem"
        Me.Client_tBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Client_tBindingNavigatorSaveItem.Text = "Save Data"
        '
        'C_idTextBox1
        '
        Me.C_idTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "c_id", True))
        Me.C_idTextBox1.Location = New System.Drawing.Point(72, 44)
        Me.C_idTextBox1.Name = "C_idTextBox1"
        Me.C_idTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.C_idTextBox1.TabIndex = 53
        '
        'C_nameTextBox1
        '
        Me.C_nameTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "c_name", True))
        Me.C_nameTextBox1.Location = New System.Drawing.Point(72, 70)
        Me.C_nameTextBox1.Name = "C_nameTextBox1"
        Me.C_nameTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.C_nameTextBox1.TabIndex = 55
        '
        'C_addressTextBox1
        '
        Me.C_addressTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "c_address", True))
        Me.C_addressTextBox1.Location = New System.Drawing.Point(72, 96)
        Me.C_addressTextBox1.Name = "C_addressTextBox1"
        Me.C_addressTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.C_addressTextBox1.TabIndex = 57
        '
        'Phone_nbTextBox1
        '
        Me.Phone_nbTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Client_tBindingSource, "phone_nb", True))
        Me.Phone_nbTextBox1.Location = New System.Drawing.Point(72, 122)
        Me.Phone_nbTextBox1.Name = "Phone_nbTextBox1"
        Me.Phone_nbTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Phone_nbTextBox1.TabIndex = 59
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 254)
        Me.Controls.Add(C_idLabel)
        Me.Controls.Add(Me.C_idTextBox1)
        Me.Controls.Add(C_nameLabel)
        Me.Controls.Add(Me.C_nameTextBox1)
        Me.Controls.Add(C_addressLabel)
        Me.Controls.Add(Me.C_addressTextBox1)
        Me.Controls.Add(Phone_nbLabel)
        Me.Controls.Add(Me.Phone_nbTextBox1)
        Me.Controls.Add(Me.Client_tBindingNavigator)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "Client"
        Me.Text = "Client"
        CType(Me._J_JDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Client_tBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Client_tBindingNavigator.ResumeLayout(False)
        Me.Client_tBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
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
    Friend WithEvents C_idTextBox1 As TextBox
    Friend WithEvents C_nameTextBox1 As TextBox
    Friend WithEvents C_addressTextBox1 As TextBox
    Friend WithEvents Phone_nbTextBox1 As TextBox
End Class
