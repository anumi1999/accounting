Public Class Form2

    Private Sub FDBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.FDBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BankingDataSet)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.FD' table. You can move, or remove it, as needed.
        Me.FDTableAdapter.Fill(Me.BankingDataSet.FD)

    End Sub

    Private Sub Maturity_AmountLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Maturity_AmountTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add.Click
        FDBindingSource.AddNew()
        TableAdapterManager.UpdateAll(BankingDataSet)
    End Sub

    Private Sub delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles delete.Click
        FDBindingSource.RemoveCurrent()
        TableAdapterManager.UpdateAll(BankingDataSet)
        MsgBox("Record Deleted")
    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles save.Click
        Dim p As Double
        Dim r As Double
        Dim n As Double
        Dim t As Double
        Dim i As Double
        p = Deposit_AmountTextBox.Text
        r = Interest_rateTextBox.Text
        n = 0.25
        t = Maturity_DateDateTimePicker.Text - Deposite_DateDateTimePicker.Text
        i = p * ((1 + (r / n)) ^ (n * t))
        Try
            FDBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(BankingDataSet)
            MsgBox("Saved Data")
        Catch ex As Exception
            MsgBox("OOps! Some data is faulty. Try Again")
        End Try
    End Sub

    Private Sub FileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub RDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub FDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub FDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FDToolStripMenuItem1.Click
        Form3.Show()
    End Sub

    Private Sub RDToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDToolStripMenuItem1.Click
        Form4.Show()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingNavigatorDeleteItem.Click

    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Form8.Show()
    End Sub

    Private Sub InterestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InterestToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class