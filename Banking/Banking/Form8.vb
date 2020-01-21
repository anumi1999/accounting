Public Class Form8

    Private Sub Form8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.FD' table. You can move, or remove it, as needed.
        Me.FDTableAdapter.Fill(Me.BankingDataSet.FD)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Search As String = TextBox1.Text
        Dim search2 As String = TextBox2.Text
        FDDataGridView.Show()
        Me.FDTableAdapter.FillBy(Me.BankingDataSet.FD, Search, search2)

    End Sub

    Private Sub FDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankingDataSet)

    End Sub

    Private Sub FDDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles FDDataGridView.CellContentClick
        Me.Hide()
    End Sub
End Class