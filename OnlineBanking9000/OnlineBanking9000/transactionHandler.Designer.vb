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
        Me.gbPayment = New System.Windows.Forms.GroupBox()
        Me.gbTransactionSelect = New System.Windows.Forms.GroupBox()
        Me.radTransfer = New System.Windows.Forms.RadioButton()
        Me.radPayment = New System.Windows.Forms.RadioButton()
        Me.cboTransferFrom = New System.Windows.Forms.ComboBox()
        Me.cboTransferTo = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.rtbTransferReference = New System.Windows.Forms.RichTextBox()
        Me.rtbPaymentReference = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.lblTransferFrom = New System.Windows.Forms.Label()
        Me.lblTransferTo = New System.Windows.Forms.Label()
        Me.lblTransferReference = New System.Windows.Forms.Label()
        Me.lblPaymentReference = New System.Windows.Forms.Label()
        Me.lblPaymentFrom = New System.Windows.Forms.Label()
        Me.lblPaymentPayee = New System.Windows.Forms.Label()
        Me.lblPaymentBIC = New System.Windows.Forms.Label()
        Me.lblPaymentIBAN = New System.Windows.Forms.Label()
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
        Me.btnSave.Location = New System.Drawing.Point(812, 41)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 21
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(812, 74)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(812, 104)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'gbTransfer
        '
        Me.gbTransfer.Controls.Add(Me.lblTransferReference)
        Me.gbTransfer.Controls.Add(Me.lblTransferTo)
        Me.gbTransfer.Controls.Add(Me.lblTransferFrom)
        Me.gbTransfer.Controls.Add(Me.rtbTransferReference)
        Me.gbTransfer.Controls.Add(Me.cboTransferTo)
        Me.gbTransfer.Controls.Add(Me.cboTransferFrom)
        Me.gbTransfer.Location = New System.Drawing.Point(12, 192)
        Me.gbTransfer.Name = "gbTransfer"
        Me.gbTransfer.Size = New System.Drawing.Size(311, 363)
        Me.gbTransfer.TabIndex = 24
        Me.gbTransfer.TabStop = False
        Me.gbTransfer.Text = "GroupBox1"
        '
        'gbPayment
        '
        Me.gbPayment.Controls.Add(Me.lblPaymentIBAN)
        Me.gbPayment.Controls.Add(Me.lblPaymentBIC)
        Me.gbPayment.Controls.Add(Me.lblPaymentPayee)
        Me.gbPayment.Controls.Add(Me.lblPaymentFrom)
        Me.gbPayment.Controls.Add(Me.lblPaymentReference)
        Me.gbPayment.Controls.Add(Me.TextBox3)
        Me.gbPayment.Controls.Add(Me.TextBox2)
        Me.gbPayment.Controls.Add(Me.TextBox1)
        Me.gbPayment.Controls.Add(Me.rtbPaymentReference)
        Me.gbPayment.Controls.Add(Me.ComboBox3)
        Me.gbPayment.Location = New System.Drawing.Point(382, 192)
        Me.gbPayment.Name = "gbPayment"
        Me.gbPayment.Size = New System.Drawing.Size(311, 363)
        Me.gbPayment.TabIndex = 25
        Me.gbPayment.TabStop = False
        Me.gbPayment.Text = "GroupBox2"
        '
        'gbTransactionSelect
        '
        Me.gbTransactionSelect.Controls.Add(Me.radPayment)
        Me.gbTransactionSelect.Controls.Add(Me.radTransfer)
        Me.gbTransactionSelect.Location = New System.Drawing.Point(102, 41)
        Me.gbTransactionSelect.Name = "gbTransactionSelect"
        Me.gbTransactionSelect.Size = New System.Drawing.Size(401, 55)
        Me.gbTransactionSelect.TabIndex = 26
        Me.gbTransactionSelect.TabStop = False
        Me.gbTransactionSelect.Text = "Please select a transaction type"
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
        'cboTransferFrom
        '
        Me.cboTransferFrom.FormattingEnabled = True
        Me.cboTransferFrom.Location = New System.Drawing.Point(128, 31)
        Me.cboTransferFrom.Name = "cboTransferFrom"
        Me.cboTransferFrom.Size = New System.Drawing.Size(121, 21)
        Me.cboTransferFrom.TabIndex = 0
        '
        'cboTransferTo
        '
        Me.cboTransferTo.FormattingEnabled = True
        Me.cboTransferTo.Location = New System.Drawing.Point(128, 70)
        Me.cboTransferTo.Name = "cboTransferTo"
        Me.cboTransferTo.Size = New System.Drawing.Size(121, 21)
        Me.cboTransferTo.TabIndex = 1
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(170, 31)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 0
        '
        'rtbTransferReference
        '
        Me.rtbTransferReference.Location = New System.Drawing.Point(6, 261)
        Me.rtbTransferReference.Name = "rtbTransferReference"
        Me.rtbTransferReference.Size = New System.Drawing.Size(299, 96)
        Me.rtbTransferReference.TabIndex = 2
        Me.rtbTransferReference.Text = ""
        '
        'rtbPaymentReference
        '
        Me.rtbPaymentReference.Location = New System.Drawing.Point(6, 261)
        Me.rtbPaymentReference.Name = "rtbPaymentReference"
        Me.rtbPaymentReference.Size = New System.Drawing.Size(299, 96)
        Me.rtbPaymentReference.TabIndex = 1
        Me.rtbPaymentReference.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(170, 71)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(170, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(170, 126)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 4
        '
        'lblTransferFrom
        '
        Me.lblTransferFrom.AutoSize = True
        Me.lblTransferFrom.Location = New System.Drawing.Point(7, 31)
        Me.lblTransferFrom.Name = "lblTransferFrom"
        Me.lblTransferFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblTransferFrom.TabIndex = 3
        Me.lblTransferFrom.Text = "From"
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
        'lblTransferReference
        '
        Me.lblTransferReference.AutoSize = True
        Me.lblTransferReference.Location = New System.Drawing.Point(7, 245)
        Me.lblTransferReference.Name = "lblTransferReference"
        Me.lblTransferReference.Size = New System.Drawing.Size(57, 13)
        Me.lblTransferReference.TabIndex = 5
        Me.lblTransferReference.Text = "Reference"
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
        'lblPaymentFrom
        '
        Me.lblPaymentFrom.AutoSize = True
        Me.lblPaymentFrom.Location = New System.Drawing.Point(23, 31)
        Me.lblPaymentFrom.Name = "lblPaymentFrom"
        Me.lblPaymentFrom.Size = New System.Drawing.Size(30, 13)
        Me.lblPaymentFrom.TabIndex = 6
        Me.lblPaymentFrom.Text = "From"
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
        'lblPaymentBIC
        '
        Me.lblPaymentBIC.AutoSize = True
        Me.lblPaymentBIC.Location = New System.Drawing.Point(23, 99)
        Me.lblPaymentBIC.Name = "lblPaymentBIC"
        Me.lblPaymentBIC.Size = New System.Drawing.Size(24, 13)
        Me.lblPaymentBIC.TabIndex = 8
        Me.lblPaymentBIC.Text = "BIC"
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
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents lblTransferReference As System.Windows.Forms.Label
    Friend WithEvents lblTransferTo As System.Windows.Forms.Label
    Friend WithEvents lblTransferFrom As System.Windows.Forms.Label
    Friend WithEvents lblPaymentReference As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblPaymentIBAN As System.Windows.Forms.Label
    Friend WithEvents lblPaymentBIC As System.Windows.Forms.Label
    Friend WithEvents lblPaymentPayee As System.Windows.Forms.Label
    Friend WithEvents lblPaymentFrom As System.Windows.Forms.Label

End Class
