<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ADMINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnLockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenSalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOCKSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenStocksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.BtnForward = New System.Windows.Forms.Button()
        Me.BtnErase = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuDataGridView = New System.Windows.Forms.DataGridView()
        Me.RequestedItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReepahDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReepahDataSet2 = New Reepah.ReepahDataSet2()
        Me.MenuDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Checkbox1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuTableAdapter = New Reepah.ReepahDataSet2TableAdapters.MenuTableAdapter()
        Me.Requested_ItemsTableAdapter = New Reepah.ReepahDataSet2TableAdapters.Requested_ItemsTableAdapter()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestedItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReepahDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReepahDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADMINToolStripMenuItem, Me.SALESToolStripMenuItem, Me.STOCKSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 35)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ADMINToolStripMenuItem
        '
        Me.ADMINToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockToolStripMenuItem, Me.UnLockToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ADMINToolStripMenuItem.Name = "ADMINToolStripMenuItem"
        Me.ADMINToolStripMenuItem.Size = New System.Drawing.Size(104, 31)
        Me.ADMINToolStripMenuItem.Text = "ADMIN"
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'UnLockToolStripMenuItem
        '
        Me.UnLockToolStripMenuItem.Name = "UnLockToolStripMenuItem"
        Me.UnLockToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.UnLockToolStripMenuItem.Text = "UnLock"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(162, 32)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SALESToolStripMenuItem
        '
        Me.SALESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenSalesToolStripMenuItem})
        Me.SALESToolStripMenuItem.Name = "SALESToolStripMenuItem"
        Me.SALESToolStripMenuItem.Size = New System.Drawing.Size(95, 31)
        Me.SALESToolStripMenuItem.Text = "SALES"
        '
        'OpenSalesToolStripMenuItem
        '
        Me.OpenSalesToolStripMenuItem.Name = "OpenSalesToolStripMenuItem"
        Me.OpenSalesToolStripMenuItem.Size = New System.Drawing.Size(191, 32)
        Me.OpenSalesToolStripMenuItem.Text = "Open Sales"
        '
        'STOCKSToolStripMenuItem
        '
        Me.STOCKSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenStocksToolStripMenuItem})
        Me.STOCKSToolStripMenuItem.Name = "STOCKSToolStripMenuItem"
        Me.STOCKSToolStripMenuItem.Size = New System.Drawing.Size(141, 31)
        Me.STOCKSToolStripMenuItem.Text = "REQUESTS"
        '
        'OpenStocksToolStripMenuItem
        '
        Me.OpenStocksToolStripMenuItem.Name = "OpenStocksToolStripMenuItem"
        Me.OpenStocksToolStripMenuItem.Size = New System.Drawing.Size(229, 32)
        Me.OpenStocksToolStripMenuItem.Text = "Open Requests"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.BackColor = System.Drawing.Color.Transparent
        Me.lblSales.Font = New System.Drawing.Font("Times New Roman", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.ForeColor = System.Drawing.Color.Lime
        Me.lblSales.Location = New System.Drawing.Point(515, 48)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(331, 73)
        Me.lblSales.TabIndex = 1
        Me.lblSales.Text = "Sales Menu"
        '
        'BtnForward
        '
        Me.BtnForward.Location = New System.Drawing.Point(610, 258)
        Me.BtnForward.Name = "BtnForward"
        Me.BtnForward.Size = New System.Drawing.Size(64, 46)
        Me.BtnForward.TabIndex = 5
        Me.BtnForward.Text = "Forward"
        Me.BtnForward.UseVisualStyleBackColor = True
        '
        'BtnErase
        '
        Me.BtnErase.Location = New System.Drawing.Point(610, 363)
        Me.BtnErase.Name = "BtnErase"
        Me.BtnErase.Size = New System.Drawing.Size(64, 46)
        Me.BtnErase.TabIndex = 6
        Me.BtnErase.Text = "Erase"
        Me.BtnErase.UseVisualStyleBackColor = True
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(940, 599)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(111, 46)
        Me.BtnSubmit.TabIndex = 7
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(921, 523)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(311, 26)
        Me.TxtName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(686, 513)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 36)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ordered by :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(194, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 36)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Food Items :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(875, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 36)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Food Order :"
        '
        'MenuDataGridView
        '
        Me.MenuDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MenuDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MenuDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView.Location = New System.Drawing.Point(692, 180)
        Me.MenuDataGridView.Name = "MenuDataGridView"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MenuDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MenuDataGridView.Size = New System.Drawing.Size(540, 327)
        Me.MenuDataGridView.TabIndex = 11
        '
        'RequestedItemsBindingSource
        '
        Me.RequestedItemsBindingSource.DataMember = "Requested_Items"
        Me.RequestedItemsBindingSource.DataSource = Me.ReepahDataSet2BindingSource
        '
        'ReepahDataSet2BindingSource
        '
        Me.ReepahDataSet2BindingSource.DataSource = Me.ReepahDataSet2
        Me.ReepahDataSet2BindingSource.Position = 0
        '
        'ReepahDataSet2
        '
        Me.ReepahDataSet2.DataSetName = "ReepahDataSet2"
        Me.ReepahDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuDataGridView1
        '
        Me.MenuDataGridView1.AutoGenerateColumns = False
        Me.MenuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MenuDataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.MenuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MenuDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.MenuDataGridViewTextBoxColumn, Me.CostDataGridViewTextBoxColumn, Me.Checkbox1})
        Me.MenuDataGridView1.DataSource = Me.MenuBindingSource
        Me.MenuDataGridView1.Location = New System.Drawing.Point(36, 169)
        Me.MenuDataGridView1.Name = "MenuDataGridView1"
        Me.MenuDataGridView1.Size = New System.Drawing.Size(540, 498)
        Me.MenuDataGridView1.TabIndex = 11
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'MenuDataGridViewTextBoxColumn
        '
        Me.MenuDataGridViewTextBoxColumn.DataPropertyName = "Menu"
        Me.MenuDataGridViewTextBoxColumn.HeaderText = "Menu"
        Me.MenuDataGridViewTextBoxColumn.Name = "MenuDataGridViewTextBoxColumn"
        '
        'CostDataGridViewTextBoxColumn
        '
        Me.CostDataGridViewTextBoxColumn.DataPropertyName = "Cost"
        Me.CostDataGridViewTextBoxColumn.HeaderText = "Cost"
        Me.CostDataGridViewTextBoxColumn.Name = "CostDataGridViewTextBoxColumn"
        '
        'Checkbox1
        '
        Me.Checkbox1.HeaderText = "SelectItem"
        Me.Checkbox1.Name = "Checkbox1"
        '
        'MenuBindingSource
        '
        Me.MenuBindingSource.DataMember = "Menu"
        Me.MenuBindingSource.DataSource = Me.ReepahDataSet2BindingSource
        '
        'MenuTableAdapter
        '
        Me.MenuTableAdapter.ClearBeforeFill = True
        '
        'Requested_ItemsTableAdapter
        '
        Me.Requested_ItemsTableAdapter.ClearBeforeFill = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(430, 691)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(111, 46)
        Me.btnclear.TabIndex = 12
        Me.btnclear.Text = "Clear checked"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.MenuDataGridView1)
        Me.Controls.Add(Me.MenuDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.BtnErase)
        Me.Controls.Add(Me.BtnForward)
        Me.Controls.Add(Me.lblSales)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "Reepah"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.MenuDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestedItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReepahDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReepahDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MenuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ADMINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnLockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenSalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOCKSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenStocksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents BtnForward As System.Windows.Forms.Button
    Friend WithEvents BtnErase As System.Windows.Forms.Button
    Friend WithEvents BtnSubmit As System.Windows.Forms.Button
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents MenuDataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReepahDataSet2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReepahDataSet2 As Reepah.ReepahDataSet2
    Friend WithEvents MenuBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MenuTableAdapter As Reepah.ReepahDataSet2TableAdapters.MenuTableAdapter
    Friend WithEvents RequestedItemsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Requested_ItemsTableAdapter As Reepah.ReepahDataSet2TableAdapters.Requested_ItemsTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MenuDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CostDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Checkbox1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnclear As System.Windows.Forms.Button

End Class
