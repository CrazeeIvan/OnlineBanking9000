Public Class transactionHandler

    Private Sub TblSepaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
       
    End Sub

    Private Sub transactionHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbTransactionsDataSet.tblSepa' table. You can move, or remove it, as needed.
        'Me.TblSepaTableAdapter.Fill(Me.DbTransactionsDataSet.tblSepa)
        cboTransferFrom.SelectedIndex = 0
        cboTransferTo.SelectedIndex = 1
        dtTransferDate.MinDate = Now
        dtPaymentDate.MinDate = Now
        gbPayment.Enabled = False
        gbTransfer.Enabled = False











    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TblSepaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbTransactionsDataSet)
    End Sub

    Private Sub radTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles radTransfer.CheckedChanged
        gbPayment.Enabled = False
        gbTransfer.Enabled = True
    End Sub

    Private Sub radPayment_CheckedChanged(sender As Object, e As EventArgs) Handles radPayment.CheckedChanged
        gbPayment.Enabled = True
        gbTransfer.Enabled = False
    End Sub
End Class
