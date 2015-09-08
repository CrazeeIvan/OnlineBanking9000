Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient



Public Class transactionHandler

    Private Sub TblSepaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub transactionHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbTransactionsDataSet.tblSepa' table. You can move, or remove it, as needed.
        'Me.TblSepaTableAdapter.Fill(Me.DbTransactionsDataSet.tblSepa)
        InitialiseInput()
        gbTransfer.Enabled = False
        gbPayment.Enabled = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim msg = "Are you sure you would like to exit the OnlineBanker9000?" + vbNewLine + "All data you have entered will be lost!"
        ' Now define a style for the message box. In this example, the 
        ' message box will have Yes and No buttons, the default will be 
        ' the No button, and a Critical Message icon will be present. 
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or _
                    MsgBoxStyle.Critical
        ' Display the message box and save the response, Yes or No. 
        Dim response = MsgBox(msg, style)
        ' Take some action based on the response. 
        If response = MsgBoxResult.Yes Then
            MsgBox("Program was closed by user!", )
            Me.Close()
        Else
            MsgBox("Exit aborted by user!", )
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TblSepaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbTransactionsDataSet)
    End Sub

    Private Sub radTransfer_CheckedChanged(sender As Object, e As EventArgs) Handles radTransfer.CheckedChanged
        InitialiseInput()
        gbPayment.Enabled = False
        gbTransfer.Enabled = True
    End Sub

    Private Sub radPayment_CheckedChanged(sender As Object, e As EventArgs) Handles radPayment.CheckedChanged
        InitialiseInput()
        gbPayment.Enabled = True
        gbTransfer.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim msg = "Are you sure you would like to cancel this transaction?" + vbNewLine + "All data you have entered will be lost!"
        ' Now define a style for the message box. In this example, the 
        ' message box will have Yes and No buttons, the default will be 
        ' the No button, and a Critical Message icon will be present. 
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or _
                    MsgBoxStyle.Critical
        ' Display the message box and save the response, Yes or No. 
        Dim response = MsgBox(msg, style)
        ' Take some action based on the response. 
        If response = MsgBoxResult.Yes Then
            MsgBox("Transaction Cancelled!", )
            InitialiseInput()
            radTransfer.Checked = False
            radPayment.Checked = False
            gbTransfer.Enabled = False
            gbPayment.Enabled = False
        Else
            MsgBox("Cancel aborted by user!", )
        End If

    End Sub
    Private Sub InitialiseInput()
        Try
            cboTransferFrom.Items.Clear()
            cboTransferTo.Items.Clear()
            cboTransferFrom.Items.Add("Current")
            cboTransferFrom.Items.Add("Deposit")
            cboTransferTo.Items.Add("Current")
            cboTransferTo.Items.Add("Deposit")
            cboTransferTo.Items.Add("Loan")
            cboTransferFrom.SelectedIndex = 0
            cboTransferTo.SelectedIndex = 1
            dtTransferDate.Value = Now
            dtTransferDate.MinDate = Now
            txtTransferAmount.Text = ""
            rtbTransferReference.Text = ""


            cboPaymentFrom.Items.Clear()
            cboPaymentFrom.Items.Add("Current")
            cboPaymentFrom.Items.Add("Deposit")
            cboPaymentFrom.Items.Add("Loan")
            cboPaymentFrom.SelectedIndex = 0
            dtPaymentDate.Value = Now
            dtPaymentDate.MinDate = Now

            txtPaymentPayee.Text = ""
            txtPaymentBIC.Text = ""
            txtPaymentIBAN.Text = ""
            txtPaymentAmount.Text = ""
            rtbPaymentReference.Text = ""



        Catch ex As Exception
            MsgBox("Warning: There was an error while OnlineBanker9000 was attempting to initialise. Please close the program and re-open it." + vbNewLine + "Original Error:" + vbNewLine)
        End Try
    End Sub
End Class
