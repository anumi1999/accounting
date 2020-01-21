<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim Account_noLabel As System.Windows.Forms.Label
        Dim Deposite_DateLabel As System.Windows.Forms.Label
        Dim AmountLabel As System.Windows.Forms.Label
        Dim Interest_RateLabel As System.Windows.Forms.Label
        Dim Maturity_DateLabel As System.Windows.Forms.Label
        Dim Branch_nameLabel As System.Windows.Forms.Label
        Dim NomineeLabel As System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RDToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.FDToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InterestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.RDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Account_noTextBox = New System.Windows.Forms.TextBox
        Me.Deposite_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.AmountTextBox = New System.Windows.Forms.TextBox
        Me.Interest_RateTextBox = New System.Windows.Forms.TextBox
        Me.Maturity_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Branch_nameTextBox = New System.Windows.Forms.TextBox
        Me.NomineeTextBox = New System.Windows.Forms.TextBox
        Me.Add = New System.Windows.Forms.Button
        Me.delete = New System.Windows.Forms.Button
        Me.save = New System.Windows.Forms.Button
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankingDataSet = New Banking.bankingDataSet
        Me.RDTableAdapter = New Banking.bankingDataSetTableAdapters.RDTableAdapter
        Me.TableAdapterManager = New Banking.bankingDataSetTableAdapters.TableAdapterManager
        Me.FDToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.RDToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Account_noLabel = New System.Windows.Forms.Label
        Deposite_DateLabel = New System.Windows.Forms.Label
        AmountLabel = New System.Windows.Forms.Label
        Interest_RateLabel = New System.Windows.Forms.Label
        Maturity_DateLabel = New System.Windows.Forms.Label
        Branch_nameLabel = New System.Windows.Forms.Label
        NomineeLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.RDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RDBindingNavigator.SuspendLayout()
        CType(Me.RDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(694, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FileToolStripMenuItem.Text = "File "
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RDToolStripMenuItem, Me.FDToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.NewToolStripMenuItem.Text = "New "
        '
        'RDToolStripMenuItem
        '
        Me.RDToolStripMenuItem.Name = "RDToolStripMenuItem"
        Me.RDToolStripMenuItem.Size = New System.Drawing.Size(89, 22)
        Me.RDToolStripMenuItem.Text = "RD"
        '
        'FDToolStripMenuItem
        '
        Me.FDToolStripMenuItem.Name = "FDToolStripMenuItem"
        Me.FDToolStripMenuItem.Size = New System.Drawing.Size(89, 22)
        Me.FDToolStripMenuItem.Text = "FD"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.OpenToolStripMenuItem.Text = "Open "
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CutToolStripMenuItem, Me.CopyToolStripMenuItem, Me.PasteToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CutToolStripMenuItem.Text = "Cut "
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TableToolStripMenuItem, Me.FormToolStripMenuItem, Me.FindToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'TableToolStripMenuItem
        '
        Me.TableToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RDToolStripMenuItem1, Me.FDToolStripMenuItem1})
        Me.TableToolStripMenuItem.Name = "TableToolStripMenuItem"
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.TableToolStripMenuItem.Text = "Table"
        '
        'RDToolStripMenuItem1
        '
        Me.RDToolStripMenuItem1.Name = "RDToolStripMenuItem1"
        Me.RDToolStripMenuItem1.Size = New System.Drawing.Size(89, 22)
        Me.RDToolStripMenuItem1.Text = "RD"
        '
        'FDToolStripMenuItem1
        '
        Me.FDToolStripMenuItem1.Name = "FDToolStripMenuItem1"
        Me.FDToolStripMenuItem1.Size = New System.Drawing.Size(89, 22)
        Me.FDToolStripMenuItem1.Text = "FD"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RDToolStripMenuItem2, Me.FDToolStripMenuItem2})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.FormToolStripMenuItem.Text = "Form"
        '
        'RDToolStripMenuItem2
        '
        Me.RDToolStripMenuItem2.Name = "RDToolStripMenuItem2"
        Me.RDToolStripMenuItem2.Size = New System.Drawing.Size(89, 22)
        Me.RDToolStripMenuItem2.Text = "RD"
        '
        'FDToolStripMenuItem2
        '
        Me.FDToolStripMenuItem2.Name = "FDToolStripMenuItem2"
        Me.FDToolStripMenuItem2.Size = New System.Drawing.Size(89, 22)
        Me.FDToolStripMenuItem2.Text = "FD"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InterestToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'InterestToolStripMenuItem
        '
        Me.InterestToolStripMenuItem.Name = "InterestToolStripMenuItem"
        Me.InterestToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InterestToolStripMenuItem.Text = "Interest"
        '
        'RDBindingNavigator
        '
        Me.RDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RDBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.RDBindingNavigator.BindingSource = Me.RDBindingSource
        Me.RDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RDBindingNavigatorSaveItem})
        Me.RDBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.RDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RDBindingNavigator.Name = "RDBindingNavigator"
        Me.RDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RDBindingNavigator.Size = New System.Drawing.Size(694, 25)
        Me.RDBindingNavigator.TabIndex = 2
        Me.RDBindingNavigator.Text = "BindingNavigator1"
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
        'RDBindingNavigatorSaveItem
        '
        Me.RDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RDBindingNavigatorSaveItem.Image = CType(resources.GetObject("RDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RDBindingNavigatorSaveItem.Name = "RDBindingNavigatorSaveItem"
        Me.RDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Account_noLabel
        '
        Account_noLabel.AutoSize = True
        Account_noLabel.Location = New System.Drawing.Point(195, 63)
        Account_noLabel.Name = "Account_noLabel"
        Account_noLabel.Size = New System.Drawing.Size(65, 13)
        Account_noLabel.TabIndex = 2
        Account_noLabel.Text = "Account no:"
        '
        'Account_noTextBox
        '
        Me.Account_noTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RDBindingSource, "Account no", True))
        Me.Account_noTextBox.Location = New System.Drawing.Point(287, 60)
        Me.Account_noTextBox.Name = "Account_noTextBox"
        Me.Account_noTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Account_noTextBox.TabIndex = 3
        '
        'Deposite_DateLabel
        '
        Deposite_DateLabel.AutoSize = True
        Deposite_DateLabel.Location = New System.Drawing.Point(195, 116)
        Deposite_DateLabel.Name = "Deposite_DateLabel"
        Deposite_DateLabel.Size = New System.Drawing.Size(78, 13)
        Deposite_DateLabel.TabIndex = 4
        Deposite_DateLabel.Text = "Deposite Date:"
        '
        'Deposite_DateDateTimePicker
        '
        Me.Deposite_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RDBindingSource, "Deposite Date", True))
        Me.Deposite_DateDateTimePicker.Location = New System.Drawing.Point(287, 112)
        Me.Deposite_DateDateTimePicker.Name = "Deposite_DateDateTimePicker"
        Me.Deposite_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Deposite_DateDateTimePicker.TabIndex = 5
        '
        'AmountLabel
        '
        AmountLabel.AutoSize = True
        AmountLabel.Location = New System.Drawing.Point(195, 141)
        AmountLabel.Name = "AmountLabel"
        AmountLabel.Size = New System.Drawing.Size(46, 13)
        AmountLabel.TabIndex = 6
        AmountLabel.Text = "Amount:"
        '
        'AmountTextBox
        '
        Me.AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RDBindingSource, "Amount", True))
        Me.AmountTextBox.Location = New System.Drawing.Point(287, 138)
        Me.AmountTextBox.Name = "AmountTextBox"
        Me.AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AmountTextBox.TabIndex = 7
        '
        'Interest_RateLabel
        '
        Interest_RateLabel.AutoSize = True
        Interest_RateLabel.Location = New System.Drawing.Point(195, 167)
        Interest_RateLabel.Name = "Interest_RateLabel"
        Interest_RateLabel.Size = New System.Drawing.Size(71, 13)
        Interest_RateLabel.TabIndex = 8
        Interest_RateLabel.Text = "Interest Rate:"
        '
        'Interest_RateTextBox
        '
        Me.Interest_RateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RDBindingSource, "Interest Rate", True))
        Me.Interest_RateTextBox.Location = New System.Drawing.Point(287, 164)
        Me.Interest_RateTextBox.Name = "Interest_RateTextBox"
        Me.Interest_RateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Interest_RateTextBox.TabIndex = 9
        '
        'Maturity_DateLabel
        '
        Maturity_DateLabel.AutoSize = True
        Maturity_DateLabel.Location = New System.Drawing.Point(195, 194)
        Maturity_DateLabel.Name = "Maturity_DateLabel"
        Maturity_DateLabel.Size = New System.Drawing.Size(73, 13)
        Maturity_DateLabel.TabIndex = 10
        Maturity_DateLabel.Text = "Maturity Date:"
        '
        'Maturity_DateDateTimePicker
        '
        Me.Maturity_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.RDBindingSource, "Maturity Date", True))
        Me.Maturity_DateDateTimePicker.Location = New System.Drawing.Point(287, 190)
        Me.Maturity_DateDateTimePicker.Name = "Maturity_DateDateTimePicker"
        Me.Maturity_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Maturity_DateDateTimePicker.TabIndex = 11
        '
        'Branch_nameLabel
        '
        Branch_nameLabel.AutoSize = True
        Branch_nameLabel.Location = New System.Drawing.Point(195, 89)
        Branch_nameLabel.Name = "Branch_nameLabel"
        Branch_nameLabel.Size = New System.Drawing.Size(72, 13)
        Branch_nameLabel.TabIndex = 16
        Branch_nameLabel.Text = "branch name:"
        AddHandler Branch_nameLabel.Click, AddressOf Me.Branch_nameLabel_Click
        '
        'Branch_nameTextBox
        '
        Me.Branch_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RDBindingSource, "branch name", True))
        Me.Branch_nameTextBox.Location = New System.Drawing.Point(287, 86)
        Me.Branch_nameTextBox.Name = "Branch_nameTextBox"
        Me.Branch_nameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Branch_nameTextBox.TabIndex = 17
        '
        'NomineeLabel
        '
        NomineeLabel.AutoSize = True
        NomineeLabel.Location = New System.Drawing.Point(195, 219)
        NomineeLabel.Name = "NomineeLabel"
        NomineeLabel.Size = New System.Drawing.Size(50, 13)
        NomineeLabel.TabIndex = 18
        NomineeLabel.Text = "nominee:"
        '
        'NomineeTextBox
        '
        Me.NomineeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RDBindingSource, "nominee", True))
        Me.NomineeTextBox.Location = New System.Drawing.Point(287, 216)
        Me.NomineeTextBox.Name = "NomineeTextBox"
        Me.NomineeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomineeTextBox.TabIndex = 19
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(417, 248)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(82, 29)
        Me.Add.TabIndex = 25
        Me.Add.Text = "Add New"
        Me.Add.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(306, 248)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(82, 29)
        Me.delete.TabIndex = 24
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(195, 248)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(82, 29)
        Me.save.TabIndex = 23
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FDToolStripMenuItem3, Me.RDToolStripMenuItem3})
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'RDBindingSource
        '
        Me.RDBindingSource.DataMember = "RD"
        Me.RDBindingSource.DataSource = Me.BankingDataSet
        '
        'BankingDataSet
        '
        Me.BankingDataSet.DataSetName = "bankingDataSet"
        Me.BankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RDTableAdapter
        '
        Me.RDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FDTableAdapter = Nothing
        Me.TableAdapterManager.RDTableAdapter = Me.RDTableAdapter
        Me.TableAdapterManager.UpdateOrder = Banking.bankingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FDToolStripMenuItem3
        '
        Me.FDToolStripMenuItem3.Name = "FDToolStripMenuItem3"
        Me.FDToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.FDToolStripMenuItem3.Text = "FD"
        '
        'RDToolStripMenuItem3
        '
        Me.RDToolStripMenuItem3.Name = "RDToolStripMenuItem3"
        Me.RDToolStripMenuItem3.Size = New System.Drawing.Size(152, 22)
        Me.RDToolStripMenuItem3.Text = "RD"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 337)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Account_noLabel)
        Me.Controls.Add(Me.Account_noTextBox)
        Me.Controls.Add(Deposite_DateLabel)
        Me.Controls.Add(Me.Deposite_DateDateTimePicker)
        Me.Controls.Add(AmountLabel)
        Me.Controls.Add(Me.AmountTextBox)
        Me.Controls.Add(Interest_RateLabel)
        Me.Controls.Add(Me.Interest_RateTextBox)
        Me.Controls.Add(Maturity_DateLabel)
        Me.Controls.Add(Me.Maturity_DateDateTimePicker)
        Me.Controls.Add(Branch_nameLabel)
        Me.Controls.Add(Me.Branch_nameTextBox)
        Me.Controls.Add(NomineeLabel)
        Me.Controls.Add(Me.NomineeTextBox)
        Me.Controls.Add(Me.RDBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form1"
        Me.Text = "RD New Entry"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.RDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RDBindingNavigator.ResumeLayout(False)
        Me.RDBindingNavigator.PerformLayout()
        CType(Me.RDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RDToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FDToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RDToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FDToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InterestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BankingDataSet As Banking.bankingDataSet
    Friend WithEvents RDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RDTableAdapter As Banking.bankingDataSetTableAdapters.RDTableAdapter
    Friend WithEvents TableAdapterManager As Banking.bankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RDBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RDBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Account_noTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Deposite_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Interest_RateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Maturity_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Branch_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomineeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FDToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RDToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem

End Class
