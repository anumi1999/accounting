Public Class Form3

    Private Sub FDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.FDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankingDataSet)

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.FD' table. You can move, or remove it, as needed.
        Me.FDTableAdapter.Fill(Me.BankingDataSet.FD)

    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close.Click
        Me.Hide()
    End Sub

    Private Sub RDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub FDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub FDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub InterestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterestToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class