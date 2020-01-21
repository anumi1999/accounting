<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Dim Account_NumberLabel As System.Windows.Forms.Label
        Dim Deposite_DateLabel As System.Windows.Forms.Label
        Dim Deposit_AmountLabel As System.Windows.Forms.Label
        Dim Interest_rateLabel As System.Windows.Forms.Label
        Dim Maturity_DateLabel As System.Windows.Forms.Label
        Dim Branch_NameLabel As System.Windows.Forms.Label
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
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.FDToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.RDToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.FDToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InterestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FDBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FDBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Account_NumberTextBox = New System.Windows.Forms.TextBox
        Me.Deposite_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Deposit_AmountTextBox = New System.Windows.Forms.TextBox
        Me.Interest_rateTextBox = New System.Windows.Forms.TextBox
        Me.Maturity_DateDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.Branch_NameTextBox = New System.Windows.Forms.TextBox
        Me.NomineeTextBox = New System.Windows.Forms.TextBox
        Me.save = New System.Windows.Forms.Button
        Me.delete = New System.Windows.Forms.Button
        Me.Add = New System.Windows.Forms.Button
        Me.FindToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankingDataSet = New Banking.bankingDataSet
        Me.FDTableAdapter = New Banking.bankingDataSetTableAdapters.FDTableAdapter
        Me.TableAdapterManager = New Banking.bankingDataSetTableAdapters.TableAdapterManager
        Account_NumberLabel = New System.Windows.Forms.Label
        Deposite_DateLabel = New System.Windows.Forms.Label
        Deposit_AmountLabel = New System.Windows.Forms.Label
        Interest_rateLabel = New System.Windows.Forms.Label
        Maturity_DateLabel = New System.Windows.Forms.Label
        Branch_NameLabel = New System.Windows.Forms.Label
        NomineeLabel = New System.Windows.Forms.Label
        Me.MenuStrip1.SuspendLayout()
        CType(Me.FDBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FDBindingNavigator.SuspendLayout()
        CType(Me.FDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankingDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 0
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
        Me.TableToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.TableToolStripMenuItem.Text = "Table"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RDToolStripMenuItem2, Me.FDToolStripMenuItem2})
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FormToolStripMenuItem.Text = "Form"
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
        'FDBindingNavigator
        '
        Me.FDBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FDBindingNavigator.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FDBindingNavigator.BindingSource = Me.FDBindingSource
        Me.FDBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FDBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FDBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FDBindingNavigatorSaveItem})
        Me.FDBindingNavigator.Location = New System.Drawing.Point(0, 24)
        Me.FDBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FDBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FDBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FDBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FDBindingNavigator.Name = "FDBindingNavigator"
        Me.FDBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FDBindingNavigator.Size = New System.Drawing.Size(697, 25)
        Me.FDBindingNavigator.TabIndex = 1
        Me.FDBindingNavigator.Text = "BindingNavigator1"
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
        'FDBindingNavigatorSaveItem
        '
        Me.FDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FDBindingNavigatorSaveItem.Image = CType(resources.GetObject("FDBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FDBindingNavigatorSaveItem.Name = "FDBindingNavigatorSaveItem"
        Me.FDBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FDBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Account_NumberLabel
        '
        Account_NumberLabel.AutoSize = True
        Account_NumberLabel.Location = New System.Drawing.Point(188, 80)
        Account_NumberLabel.Name = "Account_NumberLabel"
        Account_NumberLabel.Size = New System.Drawing.Size(90, 13)
        Account_NumberLabel.TabIndex = 2
        Account_NumberLabel.Text = "Account Number:"
        '
        'Account_NumberTextBox
        '
        Me.Account_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FDBindingSource, "Account Number", True))
        Me.Account_NumberTextBox.Location = New System.Drawing.Point(284, 77)
        Me.Account_NumberTextBox.Name = "Account_NumberTextBox"
        Me.Account_NumberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Account_NumberTextBox.TabIndex = 3
        '
        'Deposite_DateLabel
        '
        Deposite_DateLabel.AutoSize = True
        Deposite_DateLabel.Location = New System.Drawing.Point(188, 131)
        Deposite_DateLabel.Name = "Deposite_DateLabel"
        Deposite_DateLabel.Size = New System.Drawing.Size(78, 13)
        Deposite_DateLabel.TabIndex = 4
        Deposite_DateLabel.Text = "Deposite Date:"
        '
        'Deposite_DateDateTimePicker
        '
        Me.Deposite_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FDBindingSource, "Deposite Date", True))
        Me.Deposite_DateDateTimePicker.Location = New System.Drawing.Point(284, 127)
        Me.Deposite_DateDateTimePicker.Name = "Deposite_DateDateTimePicker"
        Me.Deposite_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Deposite_DateDateTimePicker.TabIndex = 5
        '
        'Deposit_AmountLabel
        '
        Deposit_AmountLabel.AutoSize = True
        Deposit_AmountLabel.Location = New System.Drawing.Point(188, 156)
        Deposit_AmountLabel.Name = "Deposit_AmountLabel"
        Deposit_AmountLabel.Size = New System.Drawing.Size(85, 13)
        Deposit_AmountLabel.TabIndex = 6
        Deposit_AmountLabel.Text = "Deposit Amount:"
        '
        'Deposit_AmountTextBox
        '
        Me.Deposit_AmountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FDBindingSource, "Deposit Amount", True))
        Me.Deposit_AmountTextBox.Location = New System.Drawing.Point(284, 153)
        Me.Deposit_AmountTextBox.Name = "Deposit_AmountTextBox"
        Me.Deposit_AmountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Deposit_AmountTextBox.TabIndex = 7
        '
        'Interest_rateLabel
        '
        Interest_rateLabel.AutoSize = True
        Interest_rateLabel.Location = New System.Drawing.Point(188, 182)
        Interest_rateLabel.Name = "Interest_rateLabel"
        Interest_rateLabel.Size = New System.Drawing.Size(66, 13)
        Interest_rateLabel.TabIndex = 8
        Interest_rateLabel.Text = "Interest rate:"
        '
        'Interest_rateTextBox
        '
        Me.Interest_rateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FDBindingSource, "Interest rate", True))
        Me.Interest_rateTextBox.Location = New System.Drawing.Point(284, 179)
        Me.Interest_rateTextBox.Name = "Interest_rateTextBox"
        Me.Interest_rateTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Interest_rateTextBox.TabIndex = 9
        '
        'Maturity_DateLabel
        '
        Maturity_DateLabel.AutoSize = True
        Maturity_DateLabel.Location = New System.Drawing.Point(188, 209)
        Maturity_DateLabel.Name = "Maturity_DateLabel"
        Maturity_DateLabel.Size = New System.Drawing.Size(73, 13)
        Maturity_DateLabel.TabIndex = 10
        Maturity_DateLabel.Text = "Maturity Date:"
        '
        'Maturity_DateDateTimePicker
        '
        Me.Maturity_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FDBindingSource, "Maturity Date", True))
        Me.Maturity_DateDateTimePicker.Location = New System.Drawing.Point(284, 205)
        Me.Maturity_DateDateTimePicker.Name = "Maturity_DateDateTimePicker"
        Me.Maturity_DateDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Maturity_DateDateTimePicker.TabIndex = 11
        '
        'Branch_NameLabel
        '
        Branch_NameLabel.AutoSize = True
        Branch_NameLabel.Location = New System.Drawing.Point(188, 106)
        Branch_NameLabel.Name = "Branch_NameLabel"
        Branch_NameLabel.Size = New System.Drawing.Size(75, 13)
        Branch_NameLabel.TabIndex = 16
        Branch_NameLabel.Text = "Branch Name:"
        '
        'Branch_NameTextBox
        '
        Me.Branch_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FDBindingSource, "Branch Name", True))
        Me.Branch_NameTextBox.Location = New System.Drawing.Point(284, 103)
        Me.Branch_NameTextBox.Name = "Branch_NameTextBox"
        Me.Branch_NameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Branch_NameTextBox.TabIndex = 17
        '
        'NomineeLabel
        '
        NomineeLabel.AutoSize = True
        NomineeLabel.Location = New System.Drawing.Point(188, 237)
        NomineeLabel.Name = "NomineeLabel"
        NomineeLabel.Size = New System.Drawing.Size(52, 13)
        NomineeLabel.TabIndex = 18
        NomineeLabel.Text = "Nominee:"
        '
        'NomineeTextBox
        '
        Me.NomineeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FDBindingSource, "Nominee", True))
        Me.NomineeTextBox.Location = New System.Drawing.Point(284, 234)
        Me.NomineeTextBox.Name = "NomineeTextBox"
        Me.NomineeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.NomineeTextBox.TabIndex = 19
        '
        'save
        '
        Me.save.Location = New System.Drawing.Point(189, 271)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(82, 29)
        Me.save.TabIndex = 20
        Me.save.Text = "Save"
        Me.save.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Location = New System.Drawing.Point(307, 271)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(82, 29)
        Me.delete.TabIndex = 21
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Add
        '
        Me.Add.Location = New System.Drawing.Point(425, 271)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(82, 29)
        Me.Add.TabIndex = 22
        Me.Add.Text = "Add New"
        Me.Add.UseVisualStyleBackColor = True
        '
        'FindToolStripMenuItem
        '
        Me.FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        Me.FindToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FindToolStripMenuItem.Text = "Find"
        '
        'FDBindingSource
        '
        Me.FDBindingSource.DataMember = "FD"
        Me.FDBindingSource.DataSource = Me.BankingDataSet
        '
        'BankingDataSet
        '
        Me.BankingDataSet.DataSetName = "bankingDataSet"
        Me.BankingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FDTableAdapter
        '
        Me.FDTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FDTableAdapter = Me.FDTableAdapter
        Me.TableAdapterManager.RDTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Banking.bankingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 355)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Account_NumberLabel)
        Me.Controls.Add(Me.Account_NumberTextBox)
        Me.Controls.Add(Deposite_DateLabel)
        Me.Controls.Add(Me.Deposite_DateDateTimePicker)
        Me.Controls.Add(Deposit_AmountLabel)
        Me.Controls.Add(Me.Deposit_AmountTextBox)
        Me.Controls.Add(Interest_rateLabel)
        Me.Controls.Add(Me.Interest_rateTextBox)
        Me.Controls.Add(Maturity_DateLabel)
        Me.Controls.Add(Me.Maturity_DateDateTimePicker)
        Me.Controls.Add(Branch_NameLabel)
        Me.Controls.Add(Me.Branch_NameTextBox)
        Me.Controls.Add(NomineeLabel)
        Me.Controls.Add(Me.NomineeTextBox)
        Me.Controls.Add(Me.FDBindingNavigator)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "FD New Entry"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.FDBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FDBindingNavigator.ResumeLayout(False)
        Me.FDBindingNavigator.PerformLayout()
        CType(Me.FDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents FDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FDTableAdapter As Banking.bankingDataSetTableAdapters.FDTableAdapter
    Friend WithEvents TableAdapterManager As Banking.bankingDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FDBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents FDBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Account_NumberTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Deposite_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Deposit_AmountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Interest_rateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Maturity_DateDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Branch_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomineeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents save As System.Windows.Forms.Button
    Friend WithEvents delete As System.Windows.Forms.Button
    Friend WithEvents Add As System.Windows.Forms.Button
    Friend WithEvents FindToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
