<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCafe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCafe))
        Me.txtAnnouncement = New System.Windows.Forms.TextBox()
        Me.gpbCurrentOrderInformation = New System.Windows.Forms.GroupBox()
        Me.txtOrderAMT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbSelectionofSaladIngredients = New System.Windows.Forms.GroupBox()
        Me.ckbHam = New System.Windows.Forms.CheckBox()
        Me.ckbApple = New System.Windows.Forms.CheckBox()
        Me.ckbTuna = New System.Windows.Forms.CheckBox()
        Me.ckbLettuce = New System.Windows.Forms.CheckBox()
        Me.ckbTomato = New System.Windows.Forms.CheckBox()
        Me.gpbSelectionofBread = New System.Windows.Forms.GroupBox()
        Me.rdbGrain = New System.Windows.Forms.RadioButton()
        Me.rdbHoney = New System.Windows.Forms.RadioButton()
        Me.nupQuantity = New System.Windows.Forms.NumericUpDown()
        Me.lstCustomer = New System.Windows.Forms.ListBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet1 = New Cafe_System.DatabaseDataSet()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnClearAcc = New System.Windows.Forms.Button()
        Me.btnMost = New System.Windows.Forms.Button()
        Me.txtTotalSales = New System.Windows.Forms.TextBox()
        Me.txtAveOfSales = New System.Windows.Forms.TextBox()
        Me.txtLargestSales = New System.Windows.Forms.TextBox()
        Me.txtNumOfOrders = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.txtFindName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OrderTableAdapter1 = New Cafe_System.DatabaseDataSetTableAdapters.OrderTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportCSVFileIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppleDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LettuceDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TomatoDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HamDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TunaDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GrainWheatDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HoneyOatDataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TotalDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StaffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppleDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.LettuceDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TomatoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HamDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TunaDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GrainWheatDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.HoneyOatDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.gpbCurrentOrderInformation.SuspendLayout()
        Me.gpbSelectionofSaladIngredients.SuspendLayout()
        Me.gpbSelectionofBread.SuspendLayout()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAnnouncement
        '
        Me.txtAnnouncement.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtAnnouncement.Location = New System.Drawing.Point(388, 6)
        Me.txtAnnouncement.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtAnnouncement.Multiline = True
        Me.txtAnnouncement.Name = "txtAnnouncement"
        Me.txtAnnouncement.ReadOnly = True
        Me.txtAnnouncement.Size = New System.Drawing.Size(501, 93)
        Me.txtAnnouncement.TabIndex = 0
        '
        'gpbCurrentOrderInformation
        '
        Me.gpbCurrentOrderInformation.Controls.Add(Me.txtOrderAMT)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.Label10)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.btnConfirm)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.btnClear)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.Label2)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.txtCustomerName)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.Label1)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.gpbSelectionofSaladIngredients)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.gpbSelectionofBread)
        Me.gpbCurrentOrderInformation.Controls.Add(Me.nupQuantity)
        Me.gpbCurrentOrderInformation.Location = New System.Drawing.Point(16, 93)
        Me.gpbCurrentOrderInformation.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gpbCurrentOrderInformation.Name = "gpbCurrentOrderInformation"
        Me.gpbCurrentOrderInformation.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gpbCurrentOrderInformation.Size = New System.Drawing.Size(961, 351)
        Me.gpbCurrentOrderInformation.TabIndex = 1
        Me.gpbCurrentOrderInformation.TabStop = False
        Me.gpbCurrentOrderInformation.Text = "Current Order Information"
        '
        'txtOrderAMT
        '
        Me.txtOrderAMT.Location = New System.Drawing.Point(727, 48)
        Me.txtOrderAMT.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtOrderAMT.Name = "txtOrderAMT"
        Me.txtOrderAMT.ReadOnly = True
        Me.txtOrderAMT.Size = New System.Drawing.Size(132, 25)
        Me.txtOrderAMT.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(636, 52)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 15)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Order amt:  "
        '
        'btnConfirm
        '
        Me.btnConfirm.Location = New System.Drawing.Point(700, 280)
        Me.btnConfirm.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(115, 52)
        Me.btnConfirm.TabIndex = 11
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(825, 280)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(115, 52)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear Order"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(339, 242)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Customer name"
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(451, 239)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(161, 25)
        Me.txtCustomerName.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(383, 202)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Quantity"
        '
        'gpbSelectionofSaladIngredients
        '
        Me.gpbSelectionofSaladIngredients.Controls.Add(Me.ckbHam)
        Me.gpbSelectionofSaladIngredients.Controls.Add(Me.ckbApple)
        Me.gpbSelectionofSaladIngredients.Controls.Add(Me.ckbTuna)
        Me.gpbSelectionofSaladIngredients.Controls.Add(Me.ckbLettuce)
        Me.gpbSelectionofSaladIngredients.Controls.Add(Me.ckbTomato)
        Me.gpbSelectionofSaladIngredients.Location = New System.Drawing.Point(24, 22)
        Me.gpbSelectionofSaladIngredients.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gpbSelectionofSaladIngredients.Name = "gpbSelectionofSaladIngredients"
        Me.gpbSelectionofSaladIngredients.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gpbSelectionofSaladIngredients.Size = New System.Drawing.Size(304, 248)
        Me.gpbSelectionofSaladIngredients.TabIndex = 0
        Me.gpbSelectionofSaladIngredients.TabStop = False
        Me.gpbSelectionofSaladIngredients.Text = "Selection of Salad Ingredients"
        '
        'ckbHam
        '
        Me.ckbHam.AutoSize = True
        Me.ckbHam.Location = New System.Drawing.Point(24, 108)
        Me.ckbHam.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ckbHam.Name = "ckbHam"
        Me.ckbHam.Size = New System.Drawing.Size(74, 19)
        Me.ckbHam.TabIndex = 3
        Me.ckbHam.Text = "Ham -- "
        Me.ckbHam.UseVisualStyleBackColor = True
        '
        'ckbApple
        '
        Me.ckbApple.AutoSize = True
        Me.ckbApple.Location = New System.Drawing.Point(24, 29)
        Me.ckbApple.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ckbApple.Name = "ckbApple"
        Me.ckbApple.Size = New System.Drawing.Size(81, 19)
        Me.ckbApple.TabIndex = 0
        Me.ckbApple.Text = "Apple -- "
        Me.ckbApple.UseVisualStyleBackColor = True
        '
        'ckbTuna
        '
        Me.ckbTuna.AutoSize = True
        Me.ckbTuna.Location = New System.Drawing.Point(24, 135)
        Me.ckbTuna.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ckbTuna.Name = "ckbTuna"
        Me.ckbTuna.Size = New System.Drawing.Size(76, 19)
        Me.ckbTuna.TabIndex = 4
        Me.ckbTuna.Text = "Tuna -- "
        Me.ckbTuna.UseVisualStyleBackColor = True
        '
        'ckbLettuce
        '
        Me.ckbLettuce.AutoSize = True
        Me.ckbLettuce.Location = New System.Drawing.Point(24, 55)
        Me.ckbLettuce.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ckbLettuce.Name = "ckbLettuce"
        Me.ckbLettuce.Size = New System.Drawing.Size(89, 19)
        Me.ckbLettuce.TabIndex = 1
        Me.ckbLettuce.Text = "Lettuce -- "
        Me.ckbLettuce.UseVisualStyleBackColor = True
        '
        'ckbTomato
        '
        Me.ckbTomato.AutoSize = True
        Me.ckbTomato.Location = New System.Drawing.Point(24, 82)
        Me.ckbTomato.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.ckbTomato.Name = "ckbTomato"
        Me.ckbTomato.Size = New System.Drawing.Size(91, 19)
        Me.ckbTomato.TabIndex = 2
        Me.ckbTomato.Text = "Tomato -- "
        Me.ckbTomato.UseVisualStyleBackColor = True
        '
        'gpbSelectionofBread
        '
        Me.gpbSelectionofBread.Controls.Add(Me.rdbGrain)
        Me.gpbSelectionofBread.Controls.Add(Me.rdbHoney)
        Me.gpbSelectionofBread.Location = New System.Drawing.Point(336, 22)
        Me.gpbSelectionofBread.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gpbSelectionofBread.Name = "gpbSelectionofBread"
        Me.gpbSelectionofBread.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.gpbSelectionofBread.Size = New System.Drawing.Size(267, 115)
        Me.gpbSelectionofBread.TabIndex = 0
        Me.gpbSelectionofBread.TabStop = False
        Me.gpbSelectionofBread.Text = "Selection of Bread"
        '
        'rdbGrain
        '
        Me.rdbGrain.AutoSize = True
        Me.rdbGrain.Location = New System.Drawing.Point(36, 38)
        Me.rdbGrain.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.rdbGrain.Name = "rdbGrain"
        Me.rdbGrain.Size = New System.Drawing.Size(118, 19)
        Me.rdbGrain.TabIndex = 5
        Me.rdbGrain.TabStop = True
        Me.rdbGrain.Text = "Grain Wheat -- "
        Me.rdbGrain.UseVisualStyleBackColor = True
        '
        'rdbHoney
        '
        Me.rdbHoney.AutoSize = True
        Me.rdbHoney.Location = New System.Drawing.Point(36, 62)
        Me.rdbHoney.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.rdbHoney.Name = "rdbHoney"
        Me.rdbHoney.Size = New System.Drawing.Size(107, 19)
        Me.rdbHoney.TabIndex = 6
        Me.rdbHoney.TabStop = True
        Me.rdbHoney.Text = "Honey Oat -- "
        Me.rdbHoney.UseVisualStyleBackColor = True
        '
        'nupQuantity
        '
        Me.nupQuantity.Location = New System.Drawing.Point(453, 200)
        Me.nupQuantity.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.nupQuantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nupQuantity.Name = "nupQuantity"
        Me.nupQuantity.Size = New System.Drawing.Size(160, 25)
        Me.nupQuantity.TabIndex = 7
        Me.nupQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lstCustomer
        '
        Me.lstCustomer.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstCustomer.DataSource = Me.OrderBindingSource
        Me.lstCustomer.DisplayMember = "CustomerName"
        Me.lstCustomer.FormattingEnabled = True
        Me.lstCustomer.ItemHeight = 15
        Me.lstCustomer.Location = New System.Drawing.Point(988, 117)
        Me.lstCustomer.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.lstCustomer.Name = "lstCustomer"
        Me.lstCustomer.Size = New System.Drawing.Size(251, 454)
        Me.lstCustomer.TabIndex = 13
        Me.lstCustomer.ValueMember = "DateTime"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveRToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(176, 56)
        '
        'RemoveRToolStripMenuItem
        '
        Me.RemoveRToolStripMenuItem.Name = "RemoveRToolStripMenuItem"
        Me.RemoveRToolStripMenuItem.Size = New System.Drawing.Size(175, 24)
        Me.RemoveRToolStripMenuItem.Text = "Remove (&R)"
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataMember = "Order"
        Me.OrderBindingSource.DataSource = Me.DatabaseDataSet1
        '
        'DatabaseDataSet1
        '
        Me.DatabaseDataSet1.DataSetName = "DatabaseDataSet"
        Me.DatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnClearAcc)
        Me.GroupBox4.Controls.Add(Me.btnMost)
        Me.GroupBox4.Controls.Add(Me.txtTotalSales)
        Me.GroupBox4.Controls.Add(Me.txtAveOfSales)
        Me.GroupBox4.Controls.Add(Me.txtLargestSales)
        Me.GroupBox4.Controls.Add(Me.txtNumOfOrders)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 452)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(961, 174)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Accumulated Sales"
        '
        'btnClearAcc
        '
        Me.btnClearAcc.Location = New System.Drawing.Point(673, 102)
        Me.btnClearAcc.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnClearAcc.Name = "btnClearAcc"
        Me.btnClearAcc.Size = New System.Drawing.Size(187, 28)
        Me.btnClearAcc.TabIndex = 9
        Me.btnClearAcc.Text = "Clear Accumlation"
        Me.btnClearAcc.UseVisualStyleBackColor = True
        '
        'btnMost
        '
        Me.btnMost.Location = New System.Drawing.Point(673, 36)
        Me.btnMost.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnMost.Name = "btnMost"
        Me.btnMost.Size = New System.Drawing.Size(187, 28)
        Me.btnMost.TabIndex = 8
        Me.btnMost.Text = "Most Popular Ingredient"
        Me.btnMost.UseVisualStyleBackColor = True
        '
        'txtTotalSales
        '
        Me.txtTotalSales.Location = New System.Drawing.Point(173, 104)
        Me.txtTotalSales.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtTotalSales.Name = "txtTotalSales"
        Me.txtTotalSales.ReadOnly = True
        Me.txtTotalSales.Size = New System.Drawing.Size(132, 25)
        Me.txtTotalSales.TabIndex = 6
        '
        'txtAveOfSales
        '
        Me.txtAveOfSales.Location = New System.Drawing.Point(480, 39)
        Me.txtAveOfSales.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtAveOfSales.Name = "txtAveOfSales"
        Me.txtAveOfSales.ReadOnly = True
        Me.txtAveOfSales.Size = New System.Drawing.Size(132, 25)
        Me.txtAveOfSales.TabIndex = 5
        '
        'txtLargestSales
        '
        Me.txtLargestSales.Location = New System.Drawing.Point(480, 104)
        Me.txtLargestSales.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtLargestSales.Name = "txtLargestSales"
        Me.txtLargestSales.ReadOnly = True
        Me.txtLargestSales.Size = New System.Drawing.Size(132, 25)
        Me.txtLargestSales.TabIndex = 7
        '
        'txtNumOfOrders
        '
        Me.txtNumOfOrders.Location = New System.Drawing.Point(173, 39)
        Me.txtNumOfOrders.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtNumOfOrders.Name = "txtNumOfOrders"
        Me.txtNumOfOrders.ReadOnly = True
        Me.txtNumOfOrders.Size = New System.Drawing.Size(132, 25)
        Me.txtNumOfOrders.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(355, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Largest Sales"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 108)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Sales"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Average of Sales"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Number of Orders"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(985, 93)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Customer History"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(1139, 599)
        Me.btnFind.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(100, 28)
        Me.btnFind.TabIndex = 16
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'txtFindName
        '
        Me.txtFindName.Location = New System.Drawing.Point(985, 602)
        Me.txtFindName.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.txtFindName.Name = "txtFindName"
        Me.txtFindName.Size = New System.Drawing.Size(132, 25)
        Me.txtFindName.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(985, 575)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Customer Name:"
        '
        'OrderTableAdapter1
        '
        Me.OrderTableAdapter1.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileFToolStripMenuItem, Me.HelpHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1267, 27)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileFToolStripMenuItem
        '
        Me.FileFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePToolStripMenuItem, Me.ToolStripSeparator2, Me.ImportCSVFileIToolStripMenuItem, Me.ExportEToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitEToolStripMenuItem})
        Me.FileFToolStripMenuItem.Name = "FileFToolStripMenuItem"
        Me.FileFToolStripMenuItem.Size = New System.Drawing.Size(67, 23)
        Me.FileFToolStripMenuItem.Text = "File (&F)"
        '
        'ChangePToolStripMenuItem
        '
        Me.ChangePToolStripMenuItem.Name = "ChangePToolStripMenuItem"
        Me.ChangePToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.ChangePToolStripMenuItem.Text = "Change Staff (&S)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(208, 6)
        '
        'ImportCSVFileIToolStripMenuItem
        '
        Me.ImportCSVFileIToolStripMenuItem.Name = "ImportCSVFileIToolStripMenuItem"
        Me.ImportCSVFileIToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.ImportCSVFileIToolStripMenuItem.Text = "Import CSV File (&I)"
        '
        'ExportEToolStripMenuItem
        '
        Me.ExportEToolStripMenuItem.Name = "ExportEToolStripMenuItem"
        Me.ExportEToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.ExportEToolStripMenuItem.Text = "Export CSV File (&E)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(208, 6)
        '
        'ExitEToolStripMenuItem
        '
        Me.ExitEToolStripMenuItem.Name = "ExitEToolStripMenuItem"
        Me.ExitEToolStripMenuItem.Size = New System.Drawing.Size(211, 26)
        Me.ExitEToolStripMenuItem.Text = "Exit (&E)"
        '
        'HelpHToolStripMenuItem
        '
        Me.HelpHToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutAToolStripMenuItem})
        Me.HelpHToolStripMenuItem.Name = "HelpHToolStripMenuItem"
        Me.HelpHToolStripMenuItem.Size = New System.Drawing.Size(78, 23)
        Me.HelpHToolStripMenuItem.Text = "Help (&H)"
        '
        'AboutAToolStripMenuItem
        '
        Me.AboutAToolStripMenuItem.Name = "AboutAToolStripMenuItem"
        Me.AboutAToolStripMenuItem.Size = New System.Drawing.Size(150, 26)
        Me.AboutAToolStripMenuItem.Text = "About (&A)"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.FileName = "Output.csv"
        Me.SaveFileDialog1.Filter = "Comma-Separated Values (CSV) File | *.csv"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-4, 31)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1279, 717)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.Controls.Add(Me.StatusStrip1)
        Me.TabPage1.Controls.Add(Me.txtAnnouncement)
        Me.TabPage1.Controls.Add(Me.gpbCurrentOrderInformation)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.txtFindName)
        Me.TabPage1.Controls.Add(Me.lstCustomer)
        Me.TabPage1.Controls.Add(Me.btnFind)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.TabPage1.Size = New System.Drawing.Size(1271, 688)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Order Page"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(4, 650)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 13, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1263, 35)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(100, 30)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.AutoSize = False
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(867, 29)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(48, 30)
        Me.ToolStripStatusLabel2.Text = "Staff: "
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView1)
        Me.TabPage3.Controls.Add(Me.BindingNavigator1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1271, 688)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Table View"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DateTimeDataGridViewTextBoxColumn1, Me.CustomerNameDataGridViewTextBoxColumn1, Me.QuantityDataGridViewTextBoxColumn1, Me.AppleDataGridViewCheckBoxColumn1, Me.LettuceDataGridViewCheckBoxColumn1, Me.TomatoDataGridViewCheckBoxColumn1, Me.HamDataGridViewCheckBoxColumn1, Me.TunaDataGridViewCheckBoxColumn1, Me.GrainWheatDataGridViewCheckBoxColumn1, Me.HoneyOatDataGridViewCheckBoxColumn1, Me.TotalDataGridViewTextBoxColumn1, Me.StaffDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrderBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 27
        Me.DataGridView1.Size = New System.Drawing.Size(1262, 649)
        Me.DataGridView1.TabIndex = 1
        '
        'DateTimeDataGridViewTextBoxColumn1
        '
        Me.DateTimeDataGridViewTextBoxColumn1.DataPropertyName = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn1.HeaderText = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn1.Name = "DateTimeDataGridViewTextBoxColumn1"
        Me.DateTimeDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CustomerNameDataGridViewTextBoxColumn1
        '
        Me.CustomerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn1.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn1.Name = "CustomerNameDataGridViewTextBoxColumn1"
        Me.CustomerNameDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'QuantityDataGridViewTextBoxColumn1
        '
        Me.QuantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn1.Name = "QuantityDataGridViewTextBoxColumn1"
        Me.QuantityDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'AppleDataGridViewCheckBoxColumn1
        '
        Me.AppleDataGridViewCheckBoxColumn1.DataPropertyName = "Apple"
        Me.AppleDataGridViewCheckBoxColumn1.HeaderText = "Apple"
        Me.AppleDataGridViewCheckBoxColumn1.Name = "AppleDataGridViewCheckBoxColumn1"
        Me.AppleDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'LettuceDataGridViewCheckBoxColumn1
        '
        Me.LettuceDataGridViewCheckBoxColumn1.DataPropertyName = "Lettuce"
        Me.LettuceDataGridViewCheckBoxColumn1.HeaderText = "Lettuce"
        Me.LettuceDataGridViewCheckBoxColumn1.Name = "LettuceDataGridViewCheckBoxColumn1"
        Me.LettuceDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'TomatoDataGridViewCheckBoxColumn1
        '
        Me.TomatoDataGridViewCheckBoxColumn1.DataPropertyName = "Tomato"
        Me.TomatoDataGridViewCheckBoxColumn1.HeaderText = "Tomato"
        Me.TomatoDataGridViewCheckBoxColumn1.Name = "TomatoDataGridViewCheckBoxColumn1"
        Me.TomatoDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'HamDataGridViewCheckBoxColumn1
        '
        Me.HamDataGridViewCheckBoxColumn1.DataPropertyName = "Ham"
        Me.HamDataGridViewCheckBoxColumn1.HeaderText = "Ham"
        Me.HamDataGridViewCheckBoxColumn1.Name = "HamDataGridViewCheckBoxColumn1"
        Me.HamDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'TunaDataGridViewCheckBoxColumn1
        '
        Me.TunaDataGridViewCheckBoxColumn1.DataPropertyName = "Tuna"
        Me.TunaDataGridViewCheckBoxColumn1.HeaderText = "Tuna"
        Me.TunaDataGridViewCheckBoxColumn1.Name = "TunaDataGridViewCheckBoxColumn1"
        Me.TunaDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'GrainWheatDataGridViewCheckBoxColumn1
        '
        Me.GrainWheatDataGridViewCheckBoxColumn1.DataPropertyName = "GrainWheat"
        Me.GrainWheatDataGridViewCheckBoxColumn1.HeaderText = "GrainWheat"
        Me.GrainWheatDataGridViewCheckBoxColumn1.Name = "GrainWheatDataGridViewCheckBoxColumn1"
        Me.GrainWheatDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'HoneyOatDataGridViewCheckBoxColumn1
        '
        Me.HoneyOatDataGridViewCheckBoxColumn1.DataPropertyName = "HoneyOat"
        Me.HoneyOatDataGridViewCheckBoxColumn1.HeaderText = "HoneyOat"
        Me.HoneyOatDataGridViewCheckBoxColumn1.Name = "HoneyOatDataGridViewCheckBoxColumn1"
        Me.HoneyOatDataGridViewCheckBoxColumn1.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn1
        '
        Me.TotalDataGridViewTextBoxColumn1.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn1.Name = "TotalDataGridViewTextBoxColumn1"
        Me.TotalDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'StaffDataGridViewTextBoxColumn
        '
        Me.StaffDataGridViewTextBoxColumn.DataPropertyName = "Staff"
        Me.StaffDataGridViewTextBoxColumn.HeaderText = "Staff"
        Me.StaffDataGridViewTextBoxColumn.Name = "StaffDataGridViewTextBoxColumn"
        Me.StaffDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1265, 27)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(46, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(49, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        '
        'CustomerNameDataGridViewTextBoxColumn
        '
        Me.CustomerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName"
        Me.CustomerNameDataGridViewTextBoxColumn.Name = "CustomerNameDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'AppleDataGridViewCheckBoxColumn
        '
        Me.AppleDataGridViewCheckBoxColumn.DataPropertyName = "Apple"
        Me.AppleDataGridViewCheckBoxColumn.HeaderText = "Apple"
        Me.AppleDataGridViewCheckBoxColumn.Name = "AppleDataGridViewCheckBoxColumn"
        '
        'LettuceDataGridViewCheckBoxColumn
        '
        Me.LettuceDataGridViewCheckBoxColumn.DataPropertyName = "Lettuce"
        Me.LettuceDataGridViewCheckBoxColumn.HeaderText = "Lettuce"
        Me.LettuceDataGridViewCheckBoxColumn.Name = "LettuceDataGridViewCheckBoxColumn"
        '
        'TomatoDataGridViewCheckBoxColumn
        '
        Me.TomatoDataGridViewCheckBoxColumn.DataPropertyName = "Tomato"
        Me.TomatoDataGridViewCheckBoxColumn.HeaderText = "Tomato"
        Me.TomatoDataGridViewCheckBoxColumn.Name = "TomatoDataGridViewCheckBoxColumn"
        '
        'HamDataGridViewCheckBoxColumn
        '
        Me.HamDataGridViewCheckBoxColumn.DataPropertyName = "Ham"
        Me.HamDataGridViewCheckBoxColumn.HeaderText = "Ham"
        Me.HamDataGridViewCheckBoxColumn.Name = "HamDataGridViewCheckBoxColumn"
        '
        'TunaDataGridViewCheckBoxColumn
        '
        Me.TunaDataGridViewCheckBoxColumn.DataPropertyName = "Tuna"
        Me.TunaDataGridViewCheckBoxColumn.HeaderText = "Tuna"
        Me.TunaDataGridViewCheckBoxColumn.Name = "TunaDataGridViewCheckBoxColumn"
        '
        'GrainWheatDataGridViewCheckBoxColumn
        '
        Me.GrainWheatDataGridViewCheckBoxColumn.DataPropertyName = "GrainWheat"
        Me.GrainWheatDataGridViewCheckBoxColumn.HeaderText = "GrainWheat"
        Me.GrainWheatDataGridViewCheckBoxColumn.Name = "GrainWheatDataGridViewCheckBoxColumn"
        '
        'HoneyOatDataGridViewCheckBoxColumn
        '
        Me.HoneyOatDataGridViewCheckBoxColumn.DataPropertyName = "HoneyOat"
        Me.HoneyOatDataGridViewCheckBoxColumn.HeaderText = "HoneyOat"
        Me.HoneyOatDataGridViewCheckBoxColumn.Name = "HoneyOatDataGridViewCheckBoxColumn"
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "Output.csv"
        Me.OpenFileDialog1.Filter = "Comma-Separated Values (CSV) File | *.csv"
        '
        'frmCafe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 740)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1285, 787)
        Me.MinimumSize = New System.Drawing.Size(1285, 787)
        Me.Name = "frmCafe"
        Me.Text = "Cafe System"
        Me.gpbCurrentOrderInformation.ResumeLayout(False)
        Me.gpbCurrentOrderInformation.PerformLayout()
        Me.gpbSelectionofSaladIngredients.ResumeLayout(False)
        Me.gpbSelectionofSaladIngredients.PerformLayout()
        Me.gpbSelectionofBread.ResumeLayout(False)
        Me.gpbSelectionofBread.PerformLayout()
        CType(Me.nupQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gpbSelectionofSaladIngredients As GroupBox
    Friend WithEvents gpbSelectionofBread As GroupBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents rdbGrain As RadioButton
    Friend WithEvents ckbTuna As CheckBox
    Friend WithEvents ckbHam As CheckBox
    Friend WithEvents ckbTomato As CheckBox
    Friend WithEvents ckbLettuce As CheckBox
    Friend WithEvents ckbApple As CheckBox
    Friend WithEvents rdbHoney As RadioButton
    Friend WithEvents nupQuantity As NumericUpDown
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstCustomer As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents gpbCurrentOrderInformation As GroupBox
    Friend WithEvents txtAnnouncement As TextBox
    Friend WithEvents txtOrderAMT As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLargestSales As TextBox
    Friend WithEvents txtTotalSales As TextBox
    Friend WithEvents txtAveOfSales As TextBox
    Friend WithEvents txtNumOfOrders As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClearAcc As Button
    Friend WithEvents btnMost As Button
    Friend WithEvents btnFind As Button
    Friend WithEvents txtFindName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DatabaseDataSet1 As DatabaseDataSet
    Friend WithEvents OrderTableAdapter1 As DatabaseDataSetTableAdapters.OrderTableAdapter
    Friend WithEvents OrderBindingSource As BindingSource
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpHToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ChangePToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PrincipalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigator1 As BindingNavigator
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
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AppleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LettuceDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TomatoDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HamDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TunaDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents GrainWheatDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HoneyOatDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DateTimeDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CustomerNameDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents AppleDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents LettuceDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents TomatoDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents HamDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents TunaDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents GrainWheatDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents HoneyOatDataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents StaffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ImportCSVFileIToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RemoveRToolStripMenuItem As ToolStripMenuItem
End Class
