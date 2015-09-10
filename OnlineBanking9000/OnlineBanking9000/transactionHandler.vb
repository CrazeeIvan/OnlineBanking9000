Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class transactionHandler
    Dim connectionString As String
    Dim cnMySQLConnection As New SqlConnection
    Private Sub transactionHandler_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiseInput()
        gbTransfer.Enabled = False
        gbPayment.Enabled = False
        Debug()
        ConnectToDatabase()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim msg = "Are you sure you would like to exit the OnlineBanker9000?" + vbNewLine + "All unsaved data will be lost!"
        ' Now define a style for the message box. In this example, the 
        ' message box will have Yes and No buttons, the default will be 
        ' the No button, and a Critical Message icon will be present. 
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or _
                    MsgBoxStyle.Critical
        ' Display the message box and save the response, Yes or No. 
        Dim response = MsgBox(msg, style)
        ' Take some action based on the response. 
        If response = MsgBoxResult.Yes Then
            MsgBox("OnlineBanker9000 was closed by user!", )
            If cnMySQLConnection.State = ConnectionState.Open Then
                cnMySQLConnection.Close()
            End If
            Me.Close()
        Else
            MsgBox("Exit aborted by user!", )
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim cmdMySQLCommand As New SqlCommand
        Dim strMyQuery As String = String.Empty
        If (radTransfer.Checked = True) Then
            strMyQuery = "INSERT INTO tblSepa (IsPayment,SepaDate,Amount,FromAccount,ToAccount, Reference)"
            strMyQuery &= "Values ('False',@SepaDate,@Amount,@FromAccount,@ToAccount, @reference)"
            Try
                With cmdMySQLCommand
                    .Connection = cnMySQLConnection
                    .CommandText = strMyQuery
                    .Parameters.AddWithValue("@SepaDate", dtTransferDate.Text)
                    .Parameters.AddWithValue("@Amount", txtTransferAmount.Text)
                    .Parameters.AddWithValue("@FromAccount", cboTransferFrom.Text)
                    .Parameters.AddWithValue("@ToAccount", cboTransferTo.Text)
                    .Parameters.AddWithValue("@reference", rtbTransferReference.Text)
                End With
                If cnMySQLConnection.State = ConnectionState.Closed Then
                    connectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\blue20\documents\VSprojects\OnlineBanking9000\OnlineBanking9000\OnlineBanking9000\dbTransactions.mdf;Integrated Security=True"
                    cnMySQLConnection = New SqlConnection(connectionString)
                    cnMySQLConnection.Open()
                End If
                cmdMySQLCommand.ExecuteNonQuery()
                cnMySQLConnection.Close()
                MsgBox("Transfer completed successfully!" + vbNewLine + "€" + txtTransferAmount.Text + " successfully transferred from " + cboTransferFrom.SelectedItem + " to " + cboTransferTo.SelectedItem + ".")
                InitialiseInput()
                radTransfer.Checked = False
                radPayment.Checked = False
                gbTransfer.Enabled = False
                gbPayment.Enabled = False
            Catch ex As SqlException
                MsgBox("Online Banker 9000 was unable to complete your Transaction." + vbNewLine + "Please ensure that the database is saved in: " + vbNewLine + "c:\users\blue20\documents\VSprojects\OnlineBanking9000\OnlineBanking9000\OnlineBanking9000\dbTransactions.mdf" + "Original Error: " + vbNewLine + ex.Message.ToString())
            End Try

        ElseIf (radPayment.Checked = True) Then
            strMyQuery = "INSERT INTO tblSepa (IsPayment, PayeeName,SepaDate,Amount,FromAccount, BIC,IBAN, Reference)"
            strMyQuery &= "Values ('True', @PayeeName,@SepaDate,@Amount,@FromAccount,@BIC,@IBAN,@reference)"
            Try
                With cmdMySQLCommand
                    .Connection = cnMySQLConnection
                    .CommandText = strMyQuery
                    .Parameters.AddWithValue("@PayeeName", txtPaymentPayee.Text)
                    .Parameters.AddWithValue("@SepaDate", dtPaymentDate.Text)
                    .Parameters.AddWithValue("@Amount", txtPaymentAmount.Text)
                    .Parameters.AddWithValue("@FromAccount", cboPaymentFrom.Text)
                    .Parameters.AddWithValue("@BIC", txtPaymentBIC.Text)
                    .Parameters.AddWithValue("@IBAN", txtPaymentIBAN.Text)
                    .Parameters.AddWithValue("@reference", rtbPaymentReference.Text)
                End With
                If cnMySQLConnection.State = ConnectionState.Closed Then
                    connectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=c:\users\blue20\documents\VSprojects\OnlineBanking9000\OnlineBanking9000\OnlineBanking9000\dbTransactions.mdf;Integrated Security=True"
                    cnMySQLConnection = New SqlConnection(connectionString)
                    cnMySQLConnection.Open()
                End If
                cmdMySQLCommand.ExecuteNonQuery()
                cnMySQLConnection.Close()
                MsgBox("Payment completed successfully!" + vbNewLine + "€" + txtPaymentAmount.Text + " successfully paid from " + cboPaymentFrom.SelectedItem + " to " + txtPaymentPayee.Text + ".")
                InitialiseInput()
                radTransfer.Checked = False
                radPayment.Checked = False
                gbTransfer.Enabled = False
                gbPayment.Enabled = False
            Catch ex As SqlException
                MsgBox("Online Banker 9000 was unable to complete your Transaction." + vbNewLine + "Please ensure that the database is saved in: " + vbNewLine + "c:\users\blue20\documents\VSprojects\OnlineBanking9000\OnlineBanking9000\OnlineBanking9000\dbTransactions.mdf" + "Original Error: " + vbNewLine + ex.Message.ToString())
            End Try

        Else
            MsgBox("Please select a Transaction type before continuing.")
        End If
        Debug()
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
        Dim style = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Critical
        Dim response = MsgBox(msg, style)
        'Display the message box and save the response, Yes or No. 
        If response = MsgBoxResult.Yes Then 'If cancel response is yes then reinitialise inputs and reset the form
            MsgBox("Transaction Cancelled!", )
            InitialiseInput()
            radTransfer.Checked = False
            radPayment.Checked = False
            gbTransfer.Enabled = False
            gbPayment.Enabled = False
        Else
            MsgBox("Cancel aborted by user!", ) 'If response is no then abort cancel and show a confirmation to the user
        End If
    End Sub
    Private Sub ConnectToDatabase()
        connectionString = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\blue20\Documents\VSprojects\OnlineBanking9000\OnlineBanking9000\OnlineBanking9000\dbTransactions.mdf;Integrated Security=True"
        cnMySQLConnection = New SqlConnection(connectionString)
        Try
            cnMySQLConnection.Open()
            MsgBox("Online Banker 9000 successfully connected to the Transaction database.")
        Catch ex As Exception
            MsgBox("Online Banker 9000 was unable to connect to the Transaction database!" + vbNewLine + "Please ensure that the database is saved in: " + vbNewLine + "c:\users\blue20\documents\VSprojects\OnlineBanking9000\OnlineBanking9000\OnlineBanking9000\dbTransactions.mdf" + "Original Error: " + vbNewLine + ex.Message.ToString())
        End Try
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
            MsgBox("Warning: There was an error while OnlineBanker9000 was attempting to initialise. Please close the program and re-open it." + vbNewLine + "Original Error:" + vbNewLine + ex.Message.ToString())
        End Try
    End Sub

    Private Sub cboTransferFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTransferFrom.SelectedIndexChanged
        'When TransferFrom combobox's value is changed, update TransferTo combobox to remove the invalid options
        If (cboTransferFrom.SelectedItem = "Current") Then 'If 'Current' is selected, remove 'Current' from the TransferTo Combobox
            cboTransferTo.Items.Clear()
            cboTransferTo.Items.Add("Deposit")
            cboTransferTo.Items.Add("Loan")
            cboTransferTo.SelectedItem = "Deposit"

        ElseIf (cboTransferFrom.SelectedItem = "Deposit") Then 'If 'Deposit' is selected, remove 'Deposit' from the TransferTo Combobox
            cboTransferTo.Items.Clear()
            cboTransferTo.Items.Add("Current")
            cboTransferTo.Items.Add("Loan")
            cboTransferTo.SelectedItem = "Current"
        ElseIf (cboTransferFrom.SelectedItem = "Loan") Then 'If 'Loan' is selected, remove 'Loan' from the TransferTo Combobox 
            cboTransferTo.Items.Clear()
            cboTransferTo.Items.Add("Current")
            cboTransferTo.Items.Add("Deposit")
            cboTransferTo.SelectedItem = "Current"
        End If
    End Sub

    Private Sub chkDebug_CheckedChanged(sender As Object, e As EventArgs) Handles chkDebug.CheckedChanged
        Debug()
        If (chkDebug.Checked = True) Then
            dgvDebug.Visible = True
        ElseIf (chkDebug.Checked = False) Then
            dgvDebug.Visible = False
        End If
    End Sub
    Private Sub Debug()
        Dim strDebugConnectionString As String = "Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\blue20\Documents\VSprojects\OnlineBanking9000\OnlineBanking9000\OnlineBanking9000\dbTransactions.mdf;Integrated Security=True"
        Dim cnDebugSQLConnection = New SqlConnection(strDebugConnectionString)
        Dim strDebugQuery As String = "Select * From tblSepa"
        Dim dtDebugDataTable As New DataTable
        Dim cmdDebugSQLCommand As New SqlCommand(strDebugQuery, cnDebugSQLConnection)
        Dim daDebugDataAdapter As New SqlDataAdapter(strDebugQuery, cnDebugSQLConnection)
        Dim dsDebugDataSet As New DataSet()
        Try
            cnDebugSQLConnection.Open()
            daDebugDataAdapter.Fill(dsDebugDataSet, "tblSepa")
            cnDebugSQLConnection.Close()
            dgvDebug.DataSource = dsDebugDataSet
            dgvDebug.DataMember = "tblSepa"
        Catch ex As Exception
            MsgBox("Online Banker 9000 encountered an error while trying to launch debugging tools." + vbNewLine + "Original Error:" + vbNewLine + ex.Message.ToString())
        End Try

    End Sub
End Class
