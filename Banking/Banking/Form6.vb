Public Class FormviewFD

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankingDataSet.FD' table. You can move, or remove it, as needed.
        Me.FDTableAdapter.Fill(Me.BankingDataSet.FD)

    End Sub

    Private Sub save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        Form8.Show()
    End Sub
End Class