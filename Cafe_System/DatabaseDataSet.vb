Partial Class DatabaseDataSet
    Partial Public Class OrderDataTable
        Private Sub OrderDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.HoneyOatColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
