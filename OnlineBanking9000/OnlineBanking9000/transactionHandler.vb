Public Class transactionHandler

    Private Sub TblSepaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub transactionHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbTransactionsDataSet.tblSepa' table. You can move, or remove it, as needed.
        Me.TblSepaTableAdapter.Fill(Me.DbTransactionsDataSet.tblSepa)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TblSepaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbTransactionsDataSet)
    End Sub
End Class
