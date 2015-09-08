Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class transactionHandler
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
        Try
            Dim connectionString As String = "Data Source=.\sqlexpress;Initial Catalog=HDIMembershipProvider;Integrated Security=True"
            Using cn As New SqlConnection(connectionString)
                cn.Open()
                Dim cmd As New SqlCommand()
                cmd.CommandText = "INSERT INTO tblSepa VALUES(@TransactionID,@PayeeName,@SepaDate,@Amount,@BIC, @IBAN, @IsPayment, @FromAccount, @ToAccount, @Reference)"

                Dim param1 As New SqlParameter()
                param1.ParameterName = "@TransactionID"
                'param1.Value = rowCount +1
                cmd.Parameters.Add(param1)

                'Dim param2 As New SqlParameter()
                'param2.ParameterName = "@PayeeName"
                'param2.Value = txtPassword.Text.Trim()
                'cmd.Parameters.Add(param2)

                Dim param3 As New SqlParameter()
                param3.ParameterName = "@SepaDate"
                param3.Value = dtTransferDate.Value
                cmd.Parameters.Add(param3)

                Dim param4 As New SqlParameter()
                param4.ParameterName = "@Amount"
                param4.Value = txtTransferAmount.Text
                cmd.Parameters.Add(param4)

                'Dim param5 As New SqlParameter()
                'param5.ParameterName = "@BIC"
                'param5.Value = txtSecurityAnswer.Text.Trim()
                'cmd.Parameters.Add(param5)

                'Dim param4 As New SqlParameter()
                'param4.ParameterName = "@IBAN"
                'param4.Value = txtSecurityQuestion.Text.Trim()
                'cmd.Parameters.Add(param4)

                'Dim param5 As New SqlParameter()
                'param5.ParameterName = "@IsPayment"
                'param5.Value = txtSecurityAnswer.Text.Trim()
                'cmd.Parameters.Add(param5)

                Dim param4 As New SqlParameter()
                param4.ParameterName = "@FromAccount"
                param4.Value = txtSecurityQuestion.Text.Trim()
                cmd.Parameters.Add(param6)

                Dim param5 As New SqlParameter()
                param5.ParameterName = "@ToAccount"
                param5.Value = txtSecurityAnswer.Text.Trim()
                cmd.Parameters.Add(param7)

                Dim param4 As New SqlParameter()
                param4.ParameterName = "@Reference"
                param4.Value = txtSecurityQuestion.Text.Trim()
                cmd.Parameters.Add(param8)

                cmd.Connection = cn
                cmd.ExecuteNonQuery()
                cn.Close()
            End Using
            Successlbl.show()
            Successlbl.show.Text = "Regisration Success."
        Catch
            Errolbl.Show()
            Errolbl.Text = "Your account was not created.Please try again."
        End Try

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
            'Initialise TransferFrom Combobox
            cboTransferFrom.Items.Clear()
            cboTransferFrom.Items.Add("Current")
            cboTransferFrom.Items.Add("Deposit")
            cboTransferFrom.Items.Add("Loan")
            cboTransferFrom.SelectedItem = "Current"
            'Initialise TransferTo Combobox
            cboTransferTo.Items.Clear()
            cboTransferTo.Items.Add("Deposit")
            cboTransferTo.Items.Add("Loan")
            cboTransferTo.SelectedItem = "Deposit"
            'Reset Transfer Date value and mindate value
            dtTransferDate.Value = Now
            dtTransferDate.MinDate = Now
            'Reset all Transfer Text values
            txtTransferAmount.Text = ""
            rtbTransferReference.Text = ""
            'Initialise PaymentFrom Combobox
            cboPaymentFrom.Items.Clear()
            cboPaymentFrom.Items.Add("Current")
            cboPaymentFrom.Items.Add("Deposit")
            cboPaymentFrom.SelectedItem = "Current"
            'Reset Payment Date value and mindate value
            dtPaymentDate.Value = Now
            dtPaymentDate.MinDate = Now
            'Reset all Payment Text values
            txtPaymentPayee.Text = ""
            txtPaymentBIC.Text = ""
            txtPaymentIBAN.Text = ""
            txtPaymentAmount.Text = ""
            rtbPaymentReference.Text = ""
        Catch ex As Exception
            MsgBox("Warning: There was an error while OnlineBanker9000 was attempting to initialise. Please close the program and re-open it." + vbNewLine + "Original Error:" + vbNewLine)
        End Try
    End Sub

    Private Sub cboTransferFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransferFrom.SelectedIndexChanged
        If (cboTransferFrom.SelectedItem = "Current") Then
            cboTransferTo.Items.Clear()
            cboTransferTo.Items.Add("Deposit")
            cboTransferTo.Items.Add("Loan")
            cboTransferTo.SelectedItem = "Deposit"
        ElseIf (cboTransferFrom.SelectedItem = "Deposit") Then
            cboTransferTo.Items.Clear()
            cboTransferTo.Items.Add("Current")
            cboTransferTo.Items.Add("Loan")
            cboTransferTo.SelectedItem = "Current"
        ElseIf (cboTransferFrom.SelectedItem = "Loan") Then
            cboTransferTo.Items.Clear()
            cboTransferTo.Items.Add("Current")
            cboTransferTo.Items.Add("Deposit")
            cboTransferTo.SelectedItem = "Current"
        End If
    End Sub
End Class
