Public Class Form4

    Private Sub RDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.RDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankingDataSet)

    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.RD' table. You can move, or remove it, as needed.
        Me.RDTableAdapter.Fill(Me.BankingDataSet.RD)

    End Sub

    Private Sub Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Close.Click
        Me.Hide()
    End Sub

    Private Sub RDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub FDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub RDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem1.Click
        Me.Show()
    End Sub

    Private Sub FDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem1.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Form8.Show()
    End Sub
End Class