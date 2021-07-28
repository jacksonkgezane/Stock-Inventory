<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserControl1))
        Dim Product_IDLabel As System.Windows.Forms.Label
        Dim CategoryLabel As System.Windows.Forms.Label
        Dim Product_NameLabel As System.Windows.Forms.Label
        Dim Product_SizeLabel As System.Windows.Forms.Label
        Dim Product_PriceLabel As System.Windows.Forms.Label
        Dim Unit_LevelLabel As System.Windows.Forms.Label
        Dim Reorder_LevelLabel As System.Windows.Forms.Label
        Dim Max_LevelLabel As System.Windows.Forms.Label
        Dim Order_IDLabel As System.Windows.Forms.Label
        Dim QuantityLabel As System.Windows.Forms.Label
        Dim DatesLabel As System.Windows.Forms.Label
        Dim DispatchedLabel As System.Windows.Forms.Label
        Dim PaidLabel As System.Windows.Forms.Label
        Dim Customer_IDLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim FistNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim Cell_NumberLabel As System.Windows.Forms.Label
        Me.Stock_shopDataSet = New Stock_Inventory.Stock_shopDataSet()
        Me.Stock_shopBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Stock_shopTableAdapter = New Stock_Inventory.Stock_shopDataSetTableAdapters.Stock_shopTableAdapter()
        Me.TableAdapterManager = New Stock_Inventory.Stock_shopDataSetTableAdapters.TableAdapterManager()
        Me.Stock_shopBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Stock_shopBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Stock_shopDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CategoryTextBox = New System.Windows.Forms.TextBox()
        Me.Product_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Product_SizeTextBox = New System.Windows.Forms.TextBox()
        Me.Product_PriceTextBox = New System.Windows.Forms.TextBox()
        Me.Unit_LevelTextBox = New System.Windows.Forms.TextBox()
        Me.Reorder_LevelTextBox = New System.Windows.Forms.TextBox()
        Me.Max_LevelTextBox = New System.Windows.Forms.TextBox()
        Me.Order_IDTextBox = New System.Windows.Forms.TextBox()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.DatesDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DispatchedCheckBox = New System.Windows.Forms.CheckBox()
        Me.PaidCheckBox = New System.Windows.Forms.CheckBox()
        Me.Customer_IDTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.FistNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Cell_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Product_IDLabel = New System.Windows.Forms.Label()
        CategoryLabel = New System.Windows.Forms.Label()
        Product_NameLabel = New System.Windows.Forms.Label()
        Product_SizeLabel = New System.Windows.Forms.Label()
        Product_PriceLabel = New System.Windows.Forms.Label()
        Unit_LevelLabel = New System.Windows.Forms.Label()
        Reorder_LevelLabel = New System.Windows.Forms.Label()
        Max_LevelLabel = New System.Windows.Forms.Label()
        Order_IDLabel = New System.Windows.Forms.Label()
        QuantityLabel = New System.Windows.Forms.Label()
        DatesLabel = New System.Windows.Forms.Label()
        DispatchedLabel = New System.Windows.Forms.Label()
        PaidLabel = New System.Windows.Forms.Label()
        Customer_IDLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        FistNameLabel = New System.Windows.Forms.Label()
        LastNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        Cell_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.Stock_shopDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_shopBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_shopBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Stock_shopBindingNavigator.SuspendLayout()
        CType(Me.Stock_shopDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Stock_shopDataSet
        '
        Me.Stock_shopDataSet.DataSetName = "Stock_shopDataSet"
        Me.Stock_shopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Stock_shopBindingSource
        '
        Me.Stock_shopBindingSource.DataMember = "Stock shop"
        Me.Stock_shopBindingSource.DataSource = Me.Stock_shopDataSet
        '
        'Stock_shopTableAdapter
        '
        Me.Stock_shopTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Catalogue_ProductsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.Customer_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Product_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Product_ordersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Stock_Inventory.Stock_shopDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Stock_shopBindingNavigator
        '
        Me.Stock_shopBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Stock_shopBindingNavigator.BindingSource = Me.Stock_shopBindingSource
        Me.Stock_shopBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Stock_shopBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Stock_shopBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Stock_shopBindingNavigatorSaveItem})
        Me.Stock_shopBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Stock_shopBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Stock_shopBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Stock_shopBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Stock_shopBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Stock_shopBindingNavigator.Name = "Stock_shopBindingNavigator"
        Me.Stock_shopBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Stock_shopBindingNavigator.Size = New System.Drawing.Size(1942, 25)
        Me.Stock_shopBindingNavigator.TabIndex = 0
        Me.Stock_shopBindingNavigator.Text = "BindingNavigator1"
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
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
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
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
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
        'Stock_shopBindingNavigatorSaveItem
        '
        Me.Stock_shopBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Stock_shopBindingNavigatorSaveItem.Enabled = False
        Me.Stock_shopBindingNavigatorSaveItem.Image = CType(resources.GetObject("Stock_shopBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Stock_shopBindingNavigatorSaveItem.Name = "Stock_shopBindingNavigatorSaveItem"
        Me.Stock_shopBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Stock_shopBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Stock_shopDataGridView
        '
        Me.Stock_shopDataGridView.AutoGenerateColumns = False
        Me.Stock_shopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Stock_shopDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.Stock_shopDataGridView.DataSource = Me.Stock_shopBindingSource
        Me.Stock_shopDataGridView.Location = New System.Drawing.Point(-1, 378)
        Me.Stock_shopDataGridView.Name = "Stock_shopDataGridView"
        Me.Stock_shopDataGridView.Size = New System.Drawing.Size(1969, 389)
        Me.Stock_shopDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Product ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Product ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Product Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Product Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Product Size"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Product Size"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Product Price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Product Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Unit Level"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Unit Level"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Reorder Level"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Reorder Level"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Max Level"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Max Level"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Order ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Order ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Dates"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Dates"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Dispatched"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Dispatched"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Paid"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Paid"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Customer ID"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Customer ID"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Title"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Title"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "FistName"
        Me.DataGridViewTextBoxColumn14.HeaderText = "FistName"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "LastName"
        Me.DataGridViewTextBoxColumn15.HeaderText = "LastName"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Address"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Cell Number"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Cell Number"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'Product_IDLabel
        '
        Product_IDLabel.AutoSize = True
        Product_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_IDLabel.Location = New System.Drawing.Point(5, 155)
        Product_IDLabel.Name = "Product_IDLabel"
        Product_IDLabel.Size = New System.Drawing.Size(89, 16)
        Product_IDLabel.TabIndex = 2
        Product_IDLabel.Text = "Product ID:"
        '
        'Product_IDTextBox
        '
        Me.Product_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Product ID", True))
        Me.Product_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_IDTextBox.Location = New System.Drawing.Point(140, 155)
        Me.Product_IDTextBox.Name = "Product_IDTextBox"
        Me.Product_IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Product_IDTextBox.TabIndex = 3
        '
        'CategoryLabel
        '
        CategoryLabel.AutoSize = True
        CategoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CategoryLabel.Location = New System.Drawing.Point(5, 181)
        CategoryLabel.Name = "CategoryLabel"
        CategoryLabel.Size = New System.Drawing.Size(78, 16)
        CategoryLabel.TabIndex = 4
        CategoryLabel.Text = "Category:"
        '
        'CategoryTextBox
        '
        Me.CategoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Category", True))
        Me.CategoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CategoryTextBox.Location = New System.Drawing.Point(140, 178)
        Me.CategoryTextBox.Name = "CategoryTextBox"
        Me.CategoryTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CategoryTextBox.TabIndex = 5
        '
        'Product_NameLabel
        '
        Product_NameLabel.AutoSize = True
        Product_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_NameLabel.Location = New System.Drawing.Point(5, 207)
        Product_NameLabel.Name = "Product_NameLabel"
        Product_NameLabel.Size = New System.Drawing.Size(114, 16)
        Product_NameLabel.TabIndex = 6
        Product_NameLabel.Text = "Product Name:"
        '
        'Product_NameTextBox
        '
        Me.Product_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Product Name", True))
        Me.Product_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_NameTextBox.Location = New System.Drawing.Point(140, 204)
        Me.Product_NameTextBox.Name = "Product_NameTextBox"
        Me.Product_NameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Product_NameTextBox.TabIndex = 7
        '
        'Product_SizeLabel
        '
        Product_SizeLabel.AutoSize = True
        Product_SizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_SizeLabel.Location = New System.Drawing.Point(5, 233)
        Product_SizeLabel.Name = "Product_SizeLabel"
        Product_SizeLabel.Size = New System.Drawing.Size(103, 16)
        Product_SizeLabel.TabIndex = 8
        Product_SizeLabel.Text = "Product Size:"
        '
        'Product_SizeTextBox
        '
        Me.Product_SizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Product Size", True))
        Me.Product_SizeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_SizeTextBox.Location = New System.Drawing.Point(140, 230)
        Me.Product_SizeTextBox.Name = "Product_SizeTextBox"
        Me.Product_SizeTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Product_SizeTextBox.TabIndex = 9
        '
        'Product_PriceLabel
        '
        Product_PriceLabel.AutoSize = True
        Product_PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Product_PriceLabel.Location = New System.Drawing.Point(5, 259)
        Product_PriceLabel.Name = "Product_PriceLabel"
        Product_PriceLabel.Size = New System.Drawing.Size(109, 16)
        Product_PriceLabel.TabIndex = 10
        Product_PriceLabel.Text = "Product Price:"
        '
        'Product_PriceTextBox
        '
        Me.Product_PriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Product Price", True))
        Me.Product_PriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_PriceTextBox.Location = New System.Drawing.Point(140, 256)
        Me.Product_PriceTextBox.Name = "Product_PriceTextBox"
        Me.Product_PriceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Product_PriceTextBox.TabIndex = 11
        '
        'Unit_LevelLabel
        '
        Unit_LevelLabel.AutoSize = True
        Unit_LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Unit_LevelLabel.Location = New System.Drawing.Point(5, 285)
        Unit_LevelLabel.Name = "Unit_LevelLabel"
        Unit_LevelLabel.Size = New System.Drawing.Size(85, 16)
        Unit_LevelLabel.TabIndex = 12
        Unit_LevelLabel.Text = "Unit Level:"
        '
        'Unit_LevelTextBox
        '
        Me.Unit_LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Unit Level", True))
        Me.Unit_LevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_LevelTextBox.Location = New System.Drawing.Point(140, 282)
        Me.Unit_LevelTextBox.Name = "Unit_LevelTextBox"
        Me.Unit_LevelTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Unit_LevelTextBox.TabIndex = 13
        '
        'Reorder_LevelLabel
        '
        Reorder_LevelLabel.AutoSize = True
        Reorder_LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Reorder_LevelLabel.Location = New System.Drawing.Point(376, 164)
        Reorder_LevelLabel.Name = "Reorder_LevelLabel"
        Reorder_LevelLabel.Size = New System.Drawing.Size(115, 16)
        Reorder_LevelLabel.TabIndex = 14
        Reorder_LevelLabel.Text = "Reorder Level:"
        '
        'Reorder_LevelTextBox
        '
        Me.Reorder_LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Reorder Level", True))
        Me.Reorder_LevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reorder_LevelTextBox.Location = New System.Drawing.Point(525, 158)
        Me.Reorder_LevelTextBox.Name = "Reorder_LevelTextBox"
        Me.Reorder_LevelTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Reorder_LevelTextBox.TabIndex = 15
        '
        'Max_LevelLabel
        '
        Max_LevelLabel.AutoSize = True
        Max_LevelLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Max_LevelLabel.Location = New System.Drawing.Point(376, 190)
        Max_LevelLabel.Name = "Max_LevelLabel"
        Max_LevelLabel.Size = New System.Drawing.Size(86, 16)
        Max_LevelLabel.TabIndex = 16
        Max_LevelLabel.Text = "Max Level:"
        '
        'Max_LevelTextBox
        '
        Me.Max_LevelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Max Level", True))
        Me.Max_LevelTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Max_LevelTextBox.Location = New System.Drawing.Point(525, 184)
        Me.Max_LevelTextBox.Name = "Max_LevelTextBox"
        Me.Max_LevelTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Max_LevelTextBox.TabIndex = 17
        '
        'Order_IDLabel
        '
        Order_IDLabel.AutoSize = True
        Order_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Order_IDLabel.Location = New System.Drawing.Point(376, 217)
        Order_IDLabel.Name = "Order_IDLabel"
        Order_IDLabel.Size = New System.Drawing.Size(75, 16)
        Order_IDLabel.TabIndex = 18
        Order_IDLabel.Text = "Order ID:"
        '
        'Order_IDTextBox
        '
        Me.Order_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Order ID", True))
        Me.Order_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_IDTextBox.Location = New System.Drawing.Point(525, 211)
        Me.Order_IDTextBox.Name = "Order_IDTextBox"
        Me.Order_IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Order_IDTextBox.TabIndex = 19
        '
        'QuantityLabel
        '
        QuantityLabel.AutoSize = True
        QuantityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        QuantityLabel.Location = New System.Drawing.Point(376, 243)
        QuantityLabel.Name = "QuantityLabel"
        QuantityLabel.Size = New System.Drawing.Size(70, 16)
        QuantityLabel.TabIndex = 20
        QuantityLabel.Text = "Quantity:"
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Quantity", True))
        Me.QuantityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTextBox.Location = New System.Drawing.Point(525, 237)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(200, 22)
        Me.QuantityTextBox.TabIndex = 21
        '
        'DatesLabel
        '
        DatesLabel.AutoSize = True
        DatesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DatesLabel.Location = New System.Drawing.Point(376, 270)
        DatesLabel.Name = "DatesLabel"
        DatesLabel.Size = New System.Drawing.Size(55, 16)
        DatesLabel.TabIndex = 22
        DatesLabel.Text = "Dates:"
        '
        'DatesDateTimePicker
        '
        Me.DatesDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Stock_shopBindingSource, "Dates", True))
        Me.DatesDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatesDateTimePicker.Location = New System.Drawing.Point(525, 263)
        Me.DatesDateTimePicker.Name = "DatesDateTimePicker"
        Me.DatesDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DatesDateTimePicker.TabIndex = 23
        '
        'DispatchedLabel
        '
        DispatchedLabel.AutoSize = True
        DispatchedLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DispatchedLabel.Location = New System.Drawing.Point(1123, 190)
        DispatchedLabel.Name = "DispatchedLabel"
        DispatchedLabel.Size = New System.Drawing.Size(93, 16)
        DispatchedLabel.TabIndex = 24
        DispatchedLabel.Text = "Dispatched:"
        '
        'DispatchedCheckBox
        '
        Me.DispatchedCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Stock_shopBindingSource, "Dispatched", True))
        Me.DispatchedCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DispatchedCheckBox.Location = New System.Drawing.Point(1222, 184)
        Me.DispatchedCheckBox.Name = "DispatchedCheckBox"
        Me.DispatchedCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.DispatchedCheckBox.TabIndex = 25
        Me.DispatchedCheckBox.Text = "CheckBox1"
        Me.DispatchedCheckBox.UseVisualStyleBackColor = True
        '
        'PaidLabel
        '
        PaidLabel.AutoSize = True
        PaidLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PaidLabel.Location = New System.Drawing.Point(1123, 152)
        PaidLabel.Name = "PaidLabel"
        PaidLabel.Size = New System.Drawing.Size(46, 16)
        PaidLabel.TabIndex = 26
        PaidLabel.Text = "Paid:"
        '
        'PaidCheckBox
        '
        Me.PaidCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.Stock_shopBindingSource, "Paid", True))
        Me.PaidCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaidCheckBox.Location = New System.Drawing.Point(1222, 149)
        Me.PaidCheckBox.Name = "PaidCheckBox"
        Me.PaidCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.PaidCheckBox.TabIndex = 27
        Me.PaidCheckBox.Text = "CheckBox1"
        Me.PaidCheckBox.UseVisualStyleBackColor = True
        '
        'Customer_IDLabel
        '
        Customer_IDLabel.AutoSize = True
        Customer_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Customer_IDLabel.Location = New System.Drawing.Point(764, 158)
        Customer_IDLabel.Name = "Customer_IDLabel"
        Customer_IDLabel.Size = New System.Drawing.Size(102, 16)
        Customer_IDLabel.TabIndex = 28
        Customer_IDLabel.Text = "Customer ID:"
        '
        'Customer_IDTextBox
        '
        Me.Customer_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Customer ID", True))
        Me.Customer_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_IDTextBox.Location = New System.Drawing.Point(882, 152)
        Me.Customer_IDTextBox.Name = "Customer_IDTextBox"
        Me.Customer_IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Customer_IDTextBox.TabIndex = 29
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.Location = New System.Drawing.Point(764, 178)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(44, 16)
        TitleLabel.TabIndex = 30
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.Location = New System.Drawing.Point(882, 178)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(200, 22)
        Me.TitleTextBox.TabIndex = 31
        '
        'FistNameLabel
        '
        FistNameLabel.AutoSize = True
        FistNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FistNameLabel.Location = New System.Drawing.Point(764, 204)
        FistNameLabel.Name = "FistNameLabel"
        FistNameLabel.Size = New System.Drawing.Size(86, 16)
        FistNameLabel.TabIndex = 32
        FistNameLabel.Text = "Fist Name:"
        '
        'FistNameTextBox
        '
        Me.FistNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "FistName", True))
        Me.FistNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FistNameTextBox.Location = New System.Drawing.Point(882, 204)
        Me.FistNameTextBox.Name = "FistNameTextBox"
        Me.FistNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FistNameTextBox.TabIndex = 33
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LastNameLabel.Location = New System.Drawing.Point(764, 230)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(90, 16)
        LastNameLabel.TabIndex = 34
        LastNameLabel.Text = "Last Name:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "LastName", True))
        Me.LastNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.Location = New System.Drawing.Point(882, 230)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.LastNameTextBox.TabIndex = 35
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AddressLabel.Location = New System.Drawing.Point(764, 256)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(72, 16)
        AddressLabel.TabIndex = 36
        AddressLabel.Text = "Address:"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Address", True))
        Me.AddressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.Location = New System.Drawing.Point(882, 256)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(200, 22)
        Me.AddressTextBox.TabIndex = 37
        '
        'Cell_NumberLabel
        '
        Cell_NumberLabel.AutoSize = True
        Cell_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Cell_NumberLabel.Location = New System.Drawing.Point(764, 285)
        Cell_NumberLabel.Name = "Cell_NumberLabel"
        Cell_NumberLabel.Size = New System.Drawing.Size(102, 16)
        Cell_NumberLabel.TabIndex = 38
        Cell_NumberLabel.Text = "Cell Number:"
        '
        'Cell_NumberTextBox
        '
        Me.Cell_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Stock_shopBindingSource, "Cell Number", True))
        Me.Cell_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cell_NumberTextBox.Location = New System.Drawing.Point(882, 282)
        Me.Cell_NumberTextBox.Name = "Cell_NumberTextBox"
        Me.Cell_NumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Cell_NumberTextBox.TabIndex = 39
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(249, 50)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "STOCK CONTROL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(8, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 48)
        Me.Panel1.TabIndex = 40
        '
        'UserControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Product_IDLabel)
        Me.Controls.Add(Me.Product_IDTextBox)
        Me.Controls.Add(CategoryLabel)
        Me.Controls.Add(Me.CategoryTextBox)
        Me.Controls.Add(Product_NameLabel)
        Me.Controls.Add(Me.Product_NameTextBox)
        Me.Controls.Add(Product_SizeLabel)
        Me.Controls.Add(Me.Product_SizeTextBox)
        Me.Controls.Add(Product_PriceLabel)
        Me.Controls.Add(Me.Product_PriceTextBox)
        Me.Controls.Add(Unit_LevelLabel)
        Me.Controls.Add(Me.Unit_LevelTextBox)
        Me.Controls.Add(Reorder_LevelLabel)
        Me.Controls.Add(Me.Reorder_LevelTextBox)
        Me.Controls.Add(Max_LevelLabel)
        Me.Controls.Add(Me.Max_LevelTextBox)
        Me.Controls.Add(Order_IDLabel)
        Me.Controls.Add(Me.Order_IDTextBox)
        Me.Controls.Add(QuantityLabel)
        Me.Controls.Add(Me.QuantityTextBox)
        Me.Controls.Add(DatesLabel)
        Me.Controls.Add(Me.DatesDateTimePicker)
        Me.Controls.Add(DispatchedLabel)
        Me.Controls.Add(Me.DispatchedCheckBox)
        Me.Controls.Add(PaidLabel)
        Me.Controls.Add(Me.PaidCheckBox)
        Me.Controls.Add(Customer_IDLabel)
        Me.Controls.Add(Me.Customer_IDTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(FistNameLabel)
        Me.Controls.Add(Me.FistNameTextBox)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Cell_NumberLabel)
        Me.Controls.Add(Me.Cell_NumberTextBox)
        Me.Controls.Add(Me.Stock_shopDataGridView)
        Me.Controls.Add(Me.Stock_shopBindingNavigator)
        Me.Name = "UserControl1"
        Me.Size = New System.Drawing.Size(1942, 744)
        CType(Me.Stock_shopDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_shopBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_shopBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Stock_shopBindingNavigator.ResumeLayout(False)
        Me.Stock_shopBindingNavigator.PerformLayout()
        CType(Me.Stock_shopDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Stock_shopDataSet As Stock_shopDataSet
    Friend WithEvents Stock_shopBindingSource As BindingSource
    Friend WithEvents Stock_shopTableAdapter As Stock_shopDataSetTableAdapters.Stock_shopTableAdapter
    Friend WithEvents TableAdapterManager As Stock_shopDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Stock_shopBindingNavigator As BindingNavigator
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
    Friend WithEvents Stock_shopBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Stock_shopDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents Product_IDTextBox As TextBox
    Friend WithEvents CategoryTextBox As TextBox
    Friend WithEvents Product_NameTextBox As TextBox
    Friend WithEvents Product_SizeTextBox As TextBox
    Friend WithEvents Product_PriceTextBox As TextBox
    Friend WithEvents Unit_LevelTextBox As TextBox
    Friend WithEvents Reorder_LevelTextBox As TextBox
    Friend WithEvents Max_LevelTextBox As TextBox
    Friend WithEvents Order_IDTextBox As TextBox
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents DatesDateTimePicker As DateTimePicker
    Friend WithEvents DispatchedCheckBox As CheckBox
    Friend WithEvents PaidCheckBox As CheckBox
    Friend WithEvents Customer_IDTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents FistNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Cell_NumberTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
