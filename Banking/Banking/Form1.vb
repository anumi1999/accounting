Public Class Form1

    Private Sub RDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankingDataSet)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.RD' table. You can move, or remove it, as needed.
        Me.RDTableAdapter.Fill(Me.BankingDataSet.RD)

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Try
            RDBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(BankingDataSet)
            MsgBox("Saved Data")
        Catch ex As Exception
            MsgBox("OOps! Some data is faulty. Try Again")
        End Try
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        RDBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(BankingDataSet)
        MsgBox("Record Deleted")
    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        RDBindingSource.AddNew()
        TableAdapterManager.UpdateAll(BankingDataSet)
    End Sub

    Private Sub Branch_nameLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub RDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub FDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem.Click
        Form2.Show()
    End Sub

    Private Sub FDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem1.Click
        Form3.Show()
    End Sub

    Private Sub RDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub InterestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterestToolStripMenuItem.Click
        Form5.Show()
    End Sub

    Private Sub FDToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem3.Click
        Form8.Show()
    End Sub
End Class
