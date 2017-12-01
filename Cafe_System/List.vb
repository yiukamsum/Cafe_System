Public Class frmList
    Public Event SimulateForm1ButtonClick()
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        RaiseEvent SimulateForm1ButtonClick()
    End Sub
End Class