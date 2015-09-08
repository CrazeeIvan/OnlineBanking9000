<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class transactionHandler
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DbTransactionsDataSet = New OnlineBanking9000.dbTransactionsDataSet()
        Me.TblSepaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSepaTableAdapter = New OnlineBanking9000.dbTransactionsDataSetTableAdapters.tblSepaTableAdapter()
        Me.TableAdapterManager = New OnlineBanking9000.dbTransactionsDataSetTableAdapters.TableAdapterManager()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbTransfer = New System.Windows.Forms.GroupBox()
        Me.dtTransferDate = New System.Windows.Forms.DateTimePicker()
        Me.txtTransferAmount = New System.Windows.Forms.TextBox()
        Me.lblTransferAmount = New System.Windows.Forms.Label()
        Me.lblTransferDate = New System.Windows.Forms.Label()
        Me.lblTransferReference = New System.Windows.Forms.Label()
        Me.lblTransferTo = New System.Windows.Forms.Label()
        Me.lblTransferFrom = New System.Windows.Forms.Label()
        Me.rtbTransferReference = New System.Windows.Forms.RichTextBox()
        Me.cboTransferTo = New System.Windows.Forms.ComboBox()
        Me.cboTransferFrom = New System.Windows.Forms.ComboBox()
        Me.gbPayment = New System.Windows.Forms.GroupBox()
        Me.dtPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.lblPaymentIBAN = New System.Windows.Forms.Label()
        Me.lblPaymentBIC = New System.Windows.Forms.Label()
        Me.lblPaymentPayee = New System.Windows.Forms.Label()
        Me.lblPaymentFrom = New System.Windows.Forms.Label()
        Me.lblPaymentReference = New System.Windows.Forms.Label()
        Me.txtPaymentIBAN = New System.Windows.Forms.TextBox()
        Me.txtPaymentBIC = New System.Windows.Forms.TextBox()
        Me.txtPaymentPayee = New System.Windows.Forms.TextBox()
        Me.rtbPaymentReference = New System.Windows.Forms.RichTextBox()
        Me.cboPaymentFrom = New System.Windows.Forms.ComboBox()
        Me.gbTransactionSelect = New System.Windows.Forms.GroupBox()
        Me.radPayment = New System.Windows.Forms.RadioButton()
        Me.radTransfer = New System.Windows.Forms.RadioButton()
        Me.txtPaymentAmount = New System.Windows.Forms.TextBox()
        Me.lblPaymentAmount = New System.Windows.Forms.Label()
        Me.lblPaymentDate = New System.Windows.Forms.Label()
        CType(Me.DbTransactionsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSepaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbTransfer.SuspendLayout()
        Me.gbPayment.SuspendLayout()
        Me.gbTransactionSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'DbTransactionsDataSet
        '
        Me.DbTransactionsDataSet.DataSetName = "dbTransactionsDataSet"
        Me.DbTransactionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblSepaBindingSource
        '
        Me.TblSepaBindingSource.DataMember = "tblSepa"
        Me.TblSepaBindingSource.DataSource = Me.DbTransactionsDataSet
        '
        'TblSepaTableAdapter
        '
        Me.TblSepaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblSepaTableAdapter = Me.TblSepaTableAdapter
        Me.TableAdapterManager.UpdateOrder = OnlineBanking9000.dbTransactionsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(823, 41)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(823, 74)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(823, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbTransfer
        '
        Me.gbTransfer.Controls.Add(Me.dtTransferDate)
        Me.gbTransfer.Controls.Add(Me.txtTransferAmount)
        Me.gbTransfer.Controls.Add(Me.lblTransferAmount)
        Me.gbTransfer.Controls.Add(Me.lblTransferDate)
        Me.gbTransfer.Controls.Add(Me.lblTransferReference)
        Me.gbTransfer.Controls.Add(Me.lblTransferTo)
        Me.gbTransfer.Controls.Add(Me.lblTransferFrom)
        Me.gbTransfer.Controls.Add(Me.rtbTransferReference)
        Me.gbTransfer.Controls.Add(Me.cboTransferTo)
        Me.gbTransfer.Controls.Add(Me.cboTransferFrom)
        Me.gbTransfer.Location = New System.Drawing.Point(12, 192)
        Me.gbTransfer.Name = "gbTransfer"
        Me.gbTransfer.Size = New System.Drawing.Size(368, 363)
        Me.gbTransfer.TabIndex = 24
        Me.gbTransfer.TabStop = False
        '
        'dtTransferDate
        '
        Me.dtTransferDate.Location = New System.Drawing.Point(162, 173)
        Me.dtTransferDate.Name = "dtTransferDate"
        Me.dtTransferDate.Size = New System.Drawing.Size(200, 20)
        Me.dtTransferDate.TabIndex = 9
        '
        'txtTransferAmount
        '
        Me.txtTransferAmount.Location = New System.Drawing.Point(162, 212)
        Me.txtTransferAmount.Name = "txtTransferAmount"
        Me.txtTransferAmount.Size = New System.Drawing.Size(200, 20)
        Me.txtTransferAmount.TabIndex = 8
        '
        'lblTransferAmount
        '
        Me.lblTransferAmount.AutoSize = True
        Me.lblTransferAmount.Location = New System.Drawing.Point(3, 212)
        Me.lblTransferAmount.Name = "lblTransferAmount"
        Me.lblTransferAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblTransferAmount.TabIndex = 7
        Me.lblTransferAmount.Text = "Amount"
        '
        'lblTransferDate
        '
        Me.lblTransferDate.AutoSize = True
        Me.lblTransferDate.Location = New System.Drawing.Point(3, 173)
        Me.lblTransferDate.Name = "lblTransferDate"
        Me.lblTransferDate.Size = New System.Drawing.Size(30, 13)
        Me.lblTransferDate.TabIndex = 6
        Me.lblTransferDate.Text = "Date"
        '
        'lblTransferReference
        '
        Me.lblTransferReference.AutoSize = True
        Me.lblTransferReference.Location = New System.Drawing.Point(7, 245)
        Me.lblTransferReference.Name = "lblTransferReference"
        Me.lblTransferReference.Size = New System.Drawing.Size(57, 13)
        Me.lblTransferReference.TabIndex = 5
        Me.lblTransferReference.Text = "Reference"
        '
        'lblTransferTo
        '
        Me.lblTransferTo.AutoSize = True
        Me.lblTransferTo.Location = New System.Drawing.Point(3, 70)
        Me.lblTransferTo.Name = "lblTransferTo"
        Me.lblTransferTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTransferTo.TabIndex = 4
        Me.lblTransferTo.Text = "To"
        '
        'lblTransferFrom
        '
        Me.lblTransferFrom.AutoSize = True
        Me.lblTransferFrom.Location = New System.Drawing.Point(3, 34)
        Me.lblTransferFrom.Name = "lblTransferFrom"
        Me.lblTransferFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblTransferFrom.TabIndex = 3
        Me.lblTransferFrom.Text = "From"
        '
        'rtbTransferReference
        '
        Me.rtbTransferReference.Location = New System.Drawing.Point(6, 261)
        Me.rtbTransferReference.Name = "rtbTransferReference"
        Me.rtbTransferReference.Size = New System.Drawing.Size(356, 96)
        Me.rtbTransferReference.TabIndex = 2
        Me.rtbTransferReference.Text = ""
        '
        'cboTransferTo
        '
        Me.cboTransferTo.FormattingEnabled = True
        Me.cboTransferTo.Location = New System.Drawing.Point(162, 71)
        Me.cboTransferTo.Name = "cboTransferTo"
        Me.cboTransferTo.Size = New System.Drawing.Size(200, 21)
        Me.cboTransferTo.TabIndex = 1
        '
        'cboTransferFrom
        '
        Me.cboTransferFrom.FormattingEnabled = True
        Me.cboTransferFrom.Location = New System.Drawing.Point(162, 34)
        Me.cboTransferFrom.Name = "cboTransferFrom"
        Me.cboTransferFrom.Size = New System.Drawing.Size(200, 21)
        Me.cboTransferFrom.TabIndex = 0
        '
        'gbPayment
        '
        Me.gbPayment.Controls.Add(Me.txtPaymentAmount)
        Me.gbPayment.Controls.Add(Me.lblPaymentAmount)
        Me.gbPayment.Controls.Add(Me.lblPaymentDate)
        Me.gbPayment.Controls.Add(Me.dtPaymentDate)
        Me.gbPayment.Controls.Add(Me.lblPaymentIBAN)
        Me.gbPayment.Controls.Add(Me.lblPaymentBIC)
        Me.gbPayment.Controls.Add(Me.lblPaymentPayee)
        Me.gbPayment.Controls.Add(Me.lblPaymentFrom)
        Me.gbPayment.Controls.Add(Me.lblPaymentReference)
        Me.gbPayment.Controls.Add(Me.txtPaymentIBAN)
        Me.gbPayment.Controls.Add(Me.txtPaymentBIC)
        Me.gbPayment.Controls.Add(Me.txtPaymentPayee)
        Me.gbPayment.Controls.Add(Me.rtbPaymentReference)
        Me.gbPayment.Controls.Add(Me.cboPaymentFrom)
        Me.gbPayment.Location = New System.Drawing.Point(530, 192)
        Me.gbPayment.Name = "gbPayment"
        Me.gbPayment.Size = New System.Drawing.Size(368, 363)
        Me.gbPayment.TabIndex = 25
        Me.gbPayment.TabStop = False
        '
        'dtPaymentDate
        '
        Me.dtPaymentDate.Location = New System.Drawing.Point(162, 173)
        Me.dtPaymentDate.Name = "dtPaymentDate"
        Me.dtPaymentDate.Size = New System.Drawing.Size(200, 20)
        Me.dtPaymentDate.TabIndex = 10
        '
        'lblPaymentIBAN
        '
        Me.lblPaymentIBAN.AutoSize = True
        Me.lblPaymentIBAN.Location = New System.Drawing.Point(23, 126)
        Me.lblPaymentIBAN.Name = "lblPaymentIBAN"
        Me.lblPaymentIBAN.Size = New System.Drawing.Size(32, 13)
        Me.lblPaymentIBAN.TabIndex = 9
        Me.lblPaymentIBAN.Text = "IBAN"
        '
        'lblPaymentBIC
        '
        Me.lblPaymentBIC.AutoSize = True
        Me.lblPaymentBIC.Location = New System.Drawing.Point(23, 99)
        Me.lblPaymentBIC.Name = "lblPaymentBIC"
        Me.lblPaymentBIC.Size = New System.Drawing.Size(24, 13)
        Me.lblPaymentBIC.TabIndex = 8
        Me.lblPaymentBIC.Text = "BIC"
        '
        'lblPaymentPayee
        '
        Me.lblPaymentPayee.AutoSize = True
        Me.lblPaymentPayee.Location = New System.Drawing.Point(23, 70)
        Me.lblPaymentPayee.Name = "lblPaymentPayee"
        Me.lblPaymentPayee.Size = New System.Drawing.Size(20, 13)
        Me.lblPaymentPayee.TabIndex = 7
        Me.lblPaymentPayee.Text = "To"
        '
        'lblPaymentFrom
        '
        Me.lblPaymentFrom.AutoSize = True
        Me.lblPaymentFrom.Location = New System.Drawing.Point(23, 31)
        Me.lblPaymentFrom.Name = "lblPaymentFrom"
        Me.lblPaymentFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblPaymentFrom.TabIndex = 6
        Me.lblPaymentFrom.Text = "From"
        '
        'lblPaymentReference
        '
        Me.lblPaymentReference.AutoSize = True
        Me.lblPaymentReference.Location = New System.Drawing.Point(6, 245)
        Me.lblPaymentReference.Name = "lblPaymentReference"
        Me.lblPaymentReference.Size = New System.Drawing.Size(57, 13)
        Me.lblPaymentReference.TabIndex = 5
        Me.lblPaymentReference.Text = "Reference"
        '
        'txtPaymentIBAN
        '
        Me.txtPaymentIBAN.Location = New System.Drawing.Point(162, 126)
        Me.txtPaymentIBAN.Name = "txtPaymentIBAN"
        Me.txtPaymentIBAN.Size = New System.Drawing.Size(200, 20)
        Me.txtPaymentIBAN.TabIndex = 4
        '
        'txtPaymentBIC
        '
        Me.txtPaymentBIC.Location = New System.Drawing.Point(162, 99)
        Me.txtPaymentBIC.Name = "txtPaymentBIC"
        Me.txtPaymentBIC.Size = New System.Drawing.Size(200, 20)
        Me.txtPaymentBIC.TabIndex = 3
        '
        'txtPaymentPayee
        '
        Me.txtPaymentPayee.Location = New System.Drawing.Point(162, 71)
        Me.txtPaymentPayee.Name = "txtPaymentPayee"
        Me.txtPaymentPayee.Size = New System.Drawing.Size(200, 20)
        Me.txtPaymentPayee.TabIndex = 2
        '
        'rtbPaymentReference
        '
        Me.rtbPaymentReference.Location = New System.Drawing.Point(6, 261)
        Me.rtbPaymentReference.Name = "rtbPaymentReference"
        Me.rtbPaymentReference.Size = New System.Drawing.Size(299, 96)
        Me.rtbPaymentReference.TabIndex = 1
        Me.rtbPaymentReference.Text = ""
        '
        'cboPaymentFrom
        '
        Me.cboPaymentFrom.FormattingEnabled = True
        Me.cboPaymentFrom.Location = New System.Drawing.Point(162, 31)
        Me.cboPaymentFrom.Name = "cboPaymentFrom"
        Me.cboPaymentFrom.Size = New System.Drawing.Size(200, 21)
        Me.cboPaymentFrom.TabIndex = 0
        '
        'gbTransactionSelect
        '
        Me.gbTransactionSelect.Controls.Add(Me.radPayment)
        Me.gbTransactionSelect.Controls.Add(Me.radTransfer)
        Me.gbTransactionSelect.Location = New System.Drawing.Point(12, 41)
        Me.gbTransactionSelect.Name = "gbTransactionSelect"
        Me.gbTransactionSelect.Size = New System.Drawing.Size(401, 55)
        Me.gbTransactionSelect.TabIndex = 26
        Me.gbTransactionSelect.TabStop = False
        Me.gbTransactionSelect.Text = "Please select a transaction type"
        '
        'radPayment
        '
        Me.radPayment.AutoSize = True
        Me.radPayment.Location = New System.Drawing.Point(237, 20)
        Me.radPayment.Name = "radPayment"
        Me.radPayment.Size = New System.Drawing.Size(66, 17)
        Me.radPayment.TabIndex = 1
        Me.radPayment.TabStop = True
        Me.radPayment.Text = "Payment"
        Me.radPayment.UseVisualStyleBackColor = True
        '
        'radTransfer
        '
        Me.radTransfer.AutoSize = True
        Me.radTransfer.Location = New System.Drawing.Point(38, 20)
        Me.radTransfer.Name = "radTransfer"
        Me.radTransfer.Size = New System.Drawing.Size(64, 17)
        Me.radTransfer.TabIndex = 0
        Me.radTransfer.TabStop = True
        Me.radTransfer.Text = "Transfer"
        Me.radTransfer.UseVisualStyleBackColor = True
        '
        'txtPaymentAmount
        '
        Me.txtPaymentAmount.Location = New System.Drawing.Point(162, 211)
        Me.txtPaymentAmount.Name = "txtPaymentAmount"
        Me.txtPaymentAmount.Size = New System.Drawing.Size(200, 20)
        Me.txtPaymentAmount.TabIndex = 13
        '
        'lblPaymentAmount
        '
        Me.lblPaymentAmount.AutoSize = True
        Me.lblPaymentAmount.Location = New System.Drawing.Point(23, 211)
        Me.lblPaymentAmount.Name = "lblPaymentAmount"
        Me.lblPaymentAmount.Size = New System.Drawing.Size(43, 13)
        Me.lblPaymentAmount.TabIndex = 12
        Me.lblPaymentAmount.Text = "Amount"
        '
        'lblPaymentDate
        '
        Me.lblPaymentDate.AutoSize = True
        Me.lblPaymentDate.Location = New System.Drawing.Point(23, 172)
        Me.lblPaymentDate.Name = "lblPaymentDate"
        Me.lblPaymentDate.Size = New System.Drawing.Size(30, 13)
        Me.lblPaymentDate.TabIndex = 11
        Me.lblPaymentDate.Text = "Date"
        '
        'transactionHandler
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 581)
        Me.Controls.Add(Me.gbTransactionSelect)
        Me.Controls.Add(Me.gbPayment)
        Me.Controls.Add(Me.gbTransfer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "transactionHandler"
        Me.Text = "Event Driven Programming Solutions Assignment - 8th-Sept-2015"
        CType(Me.DbTransactionsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSepaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbTransfer.ResumeLayout(False)
        Me.gbTransfer.PerformLayout()
        Me.gbPayment.ResumeLayout(False)
        Me.gbPayment.PerformLayout()
        Me.gbTransactionSelect.ResumeLayout(False)
        Me.gbTransactionSelect.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DbTransactionsDataSet As OnlineBanking9000.dbTransactionsDataSet
    Friend WithEvents TblSepaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSepaTableAdapter As OnlineBanking9000.dbTransactionsDataSetTableAdapters.tblSepaTableAdapter
    Friend WithEvents TableAdapterManager As OnlineBanking9000.dbTransactionsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents gbTransfer As System.Windows.Forms.GroupBox
    Friend WithEvents gbPayment As System.Windows.Forms.GroupBox
    Friend WithEvents gbTransactionSelect As System.Windows.Forms.GroupBox
    Friend WithEvents radPayment As System.Windows.Forms.RadioButton
    Friend WithEvents radTransfer As System.Windows.Forms.RadioButton
    Friend WithEvents rtbTransferReference As System.Windows.Forms.RichTextBox
    Friend WithEvents cboTransferTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboTransferFrom As System.Windows.Forms.ComboBox
    Friend WithEvents rtbPaymentReference As System.Windows.Forms.RichTextBox
    Friend WithEvents cboPaymentFrom As System.Windows.Forms.ComboBox
    Friend WithEvents lblTransferReference As System.Windows.Forms.Label
    Friend WithEvents lblTransferTo As System.Windows.Forms.Label
    Friend WithEvents lblTransferFrom As System.Windows.Forms.Label
    Friend WithEvents lblPaymentReference As System.Windows.Forms.Label
    Friend WithEvents txtPaymentIBAN As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentBIC As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentPayee As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentIBAN As System.Windows.Forms.Label
    Friend WithEvents lblPaymentBIC As System.Windows.Forms.Label
    Friend WithEvents lblPaymentPayee As System.Windows.Forms.Label
    Friend WithEvents lblPaymentFrom As System.Windows.Forms.Label
    Friend WithEvents dtTransferDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtTransferAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTransferAmount As System.Windows.Forms.Label
    Friend WithEvents lblTransferDate As System.Windows.Forms.Label
    Friend WithEvents dtPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPaymentAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentAmount As System.Windows.Forms.Label
    Friend WithEvents lblPaymentDate As System.Windows.Forms.Label

End Class
