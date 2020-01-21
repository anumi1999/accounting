Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Double
        Dim r As Double
        Dim n As Double
        Dim t As Double
        Dim i As Double
        p = TextBox1.Text
        r = TextBox2.Text
        n = TextBox3.Text
        t = TextBox4.Text
        i = p * ((1 + (r / n)) ^ (n * t))
        MsgBox(i)
    End Sub
End Class