<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addAdvertisement
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addAdvertisement))
        Me.buttonConfirm = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.tabMainGeneral = New System.Windows.Forms.TabPage()
        Me.valueAdvID = New System.Windows.Forms.Label()
        Me.labelAdvID = New System.Windows.Forms.Label()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.labelDateEnd = New System.Windows.Forms.Label()
        Me.dateAdvStart = New System.Windows.Forms.DateTimePicker()
        Me.labelDateStart = New System.Windows.Forms.Label()
        Me.valueSignature = New System.Windows.Forms.TextBox()
        Me.labelSignature = New System.Windows.Forms.Label()
        Me.valueWalletId = New System.Windows.Forms.TextBox()
        Me.labelWalletId = New System.Windows.Forms.Label()
        Me.tabMainReqOff = New System.Windows.Forms.TabPage()
        Me.tabRequestOffered = New System.Windows.Forms.TabControl()
        Me.tabRequest = New System.Windows.Forms.TabPage()
        Me.valueCurrency = New System.Windows.Forms.ComboBox()
        Me.labelCurrency = New System.Windows.Forms.Label()
        Me.buttonDeleteRequest = New System.Windows.Forms.Button()
        Me.buttonRequestUpdate = New System.Windows.Forms.Button()
        Me.buttonRequestAddNew = New System.Windows.Forms.Button()
        Me.buttonRequestConfirm = New System.Windows.Forms.Button()
        Me.gridRequests = New System.Windows.Forms.DataGridView()
        Me.valueAmountRequest = New System.Windows.Forms.TextBox()
        Me.labelQuantity = New System.Windows.Forms.Label()
        Me.valueDescriptionRequest = New System.Windows.Forms.TextBox()
        Me.labelDescription = New System.Windows.Forms.Label()
        Me.valueTypeRequest = New System.Windows.Forms.ComboBox()
        Me.labelType = New System.Windows.Forms.Label()
        Me.tabOffered = New System.Windows.Forms.TabPage()
        Me.valueCurrencyOffered = New System.Windows.Forms.ComboBox()
        Me.labelCurrencyOffered = New System.Windows.Forms.Label()
        Me.buttonDeleteOffered = New System.Windows.Forms.Button()
        Me.buttonOfferedUpdate = New System.Windows.Forms.Button()
        Me.buttonOfferedAddNew = New System.Windows.Forms.Button()
        Me.buttonOfferedConfirm = New System.Windows.Forms.Button()
        Me.gridOffered = New System.Windows.Forms.DataGridView()
        Me.valueAmountOffered = New System.Windows.Forms.TextBox()
        Me.labelQuantityOffered = New System.Windows.Forms.Label()
        Me.valueDescriptionOffered = New System.Windows.Forms.TextBox()
        Me.labelDescriptionOffered = New System.Windows.Forms.Label()
        Me.valueTypeOffered = New System.Windows.Forms.ComboBox()
        Me.labelTypeOffered = New System.Windows.Forms.Label()
        Me.tabMainOption = New System.Windows.Forms.TabPage()
        Me.checkVisible = New System.Windows.Forms.CheckBox()
        Me.checkOnlyEntireAmount = New System.Windows.Forms.CheckBox()
        Me.checkNegotiable = New System.Windows.Forms.CheckBox()
        Me.checkAcceptOtherItems = New System.Windows.Forms.CheckBox()
        Me.valueArea = New System.Windows.Forms.TextBox()
        Me.labelArea = New System.Windows.Forms.Label()
        Me.tabMain.SuspendLayout()
        Me.tabMainGeneral.SuspendLayout()
        Me.tabMainReqOff.SuspendLayout()
        Me.tabRequestOffered.SuspendLayout()
        Me.tabRequest.SuspendLayout()
        CType(Me.gridRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOffered.SuspendLayout()
        CType(Me.gridOffered, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMainOption.SuspendLayout()
        Me.SuspendLayout()
        '
        'buttonConfirm
        '
        Me.buttonConfirm.Location = New System.Drawing.Point(477, 437)
        Me.buttonConfirm.Name = "buttonConfirm"
        Me.buttonConfirm.Size = New System.Drawing.Size(75, 23)
        Me.buttonConfirm.TabIndex = 17
        Me.buttonConfirm.Text = "Confirm"
        Me.buttonConfirm.UseVisualStyleBackColor = True
        '
        'buttonCancel
        '
        Me.buttonCancel.Location = New System.Drawing.Point(558, 436)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 18
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = True
        '
        'tabMain
        '
        Me.tabMain.Controls.Add(Me.tabMainGeneral)
        Me.tabMain.Controls.Add(Me.tabMainReqOff)
        Me.tabMain.Controls.Add(Me.tabMainOption)
        Me.tabMain.Location = New System.Drawing.Point(12, 12)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(625, 418)
        Me.tabMain.TabIndex = 19
        '
        'tabMainGeneral
        '
        Me.tabMainGeneral.Controls.Add(Me.valueAdvID)
        Me.tabMainGeneral.Controls.Add(Me.labelAdvID)
        Me.tabMainGeneral.Controls.Add(Me.dateEnd)
        Me.tabMainGeneral.Controls.Add(Me.labelDateEnd)
        Me.tabMainGeneral.Controls.Add(Me.dateAdvStart)
        Me.tabMainGeneral.Controls.Add(Me.labelDateStart)
        Me.tabMainGeneral.Controls.Add(Me.valueSignature)
        Me.tabMainGeneral.Controls.Add(Me.labelSignature)
        Me.tabMainGeneral.Controls.Add(Me.valueWalletId)
        Me.tabMainGeneral.Controls.Add(Me.labelWalletId)
        Me.tabMainGeneral.Location = New System.Drawing.Point(4, 22)
        Me.tabMainGeneral.Name = "tabMainGeneral"
        Me.tabMainGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMainGeneral.Size = New System.Drawing.Size(617, 392)
        Me.tabMainGeneral.TabIndex = 0
        Me.tabMainGeneral.Text = "General"
        Me.tabMainGeneral.UseVisualStyleBackColor = True
        '
        'valueAdvID
        '
        Me.valueAdvID.AutoSize = True
        Me.valueAdvID.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueAdvID.Location = New System.Drawing.Point(113, 34)
        Me.valueAdvID.Name = "valueAdvID"
        Me.valueAdvID.Size = New System.Drawing.Size(28, 14)
        Me.valueAdvID.TabIndex = 26
        Me.valueAdvID.Text = "xxx"
        '
        'labelAdvID
        '
        Me.labelAdvID.AutoSize = True
        Me.labelAdvID.Location = New System.Drawing.Point(19, 35)
        Me.labelAdvID.Name = "labelAdvID"
        Me.labelAdvID.Size = New System.Drawing.Size(88, 13)
        Me.labelAdvID.TabIndex = 25
        Me.labelAdvID.Text = "Advertisement ID"
        '
        'dateEnd
        '
        Me.dateEnd.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateEnd.Location = New System.Drawing.Point(116, 147)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(249, 20)
        Me.dateEnd.TabIndex = 24
        '
        'labelDateEnd
        '
        Me.labelDateEnd.AutoSize = True
        Me.labelDateEnd.Location = New System.Drawing.Point(55, 150)
        Me.labelDateEnd.Name = "labelDateEnd"
        Me.labelDateEnd.Size = New System.Drawing.Size(52, 13)
        Me.labelDateEnd.TabIndex = 23
        Me.labelDateEnd.Text = "Date End"
        '
        'dateAdvStart
        '
        Me.dateAdvStart.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateAdvStart.Location = New System.Drawing.Point(116, 120)
        Me.dateAdvStart.Name = "dateAdvStart"
        Me.dateAdvStart.Size = New System.Drawing.Size(249, 20)
        Me.dateAdvStart.TabIndex = 22
        '
        'labelDateStart
        '
        Me.labelDateStart.AutoSize = True
        Me.labelDateStart.Location = New System.Drawing.Point(52, 123)
        Me.labelDateStart.Name = "labelDateStart"
        Me.labelDateStart.Size = New System.Drawing.Size(55, 13)
        Me.labelDateStart.TabIndex = 21
        Me.labelDateStart.Text = "Date Start"
        '
        'valueSignature
        '
        Me.valueSignature.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueSignature.Location = New System.Drawing.Point(116, 91)
        Me.valueSignature.Name = "valueSignature"
        Me.valueSignature.Size = New System.Drawing.Size(480, 20)
        Me.valueSignature.TabIndex = 20
        '
        'labelSignature
        '
        Me.labelSignature.AutoSize = True
        Me.labelSignature.Location = New System.Drawing.Point(55, 91)
        Me.labelSignature.Name = "labelSignature"
        Me.labelSignature.Size = New System.Drawing.Size(52, 13)
        Me.labelSignature.TabIndex = 19
        Me.labelSignature.Text = "Signature"
        '
        'valueWalletId
        '
        Me.valueWalletId.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueWalletId.Location = New System.Drawing.Point(116, 62)
        Me.valueWalletId.Name = "valueWalletId"
        Me.valueWalletId.Size = New System.Drawing.Size(480, 20)
        Me.valueWalletId.TabIndex = 18
        '
        'labelWalletId
        '
        Me.labelWalletId.AutoSize = True
        Me.labelWalletId.Location = New System.Drawing.Point(56, 65)
        Me.labelWalletId.Name = "labelWalletId"
        Me.labelWalletId.Size = New System.Drawing.Size(51, 13)
        Me.labelWalletId.TabIndex = 17
        Me.labelWalletId.Text = "Wallet ID"
        '
        'tabMainReqOff
        '
        Me.tabMainReqOff.Controls.Add(Me.tabRequestOffered)
        Me.tabMainReqOff.Location = New System.Drawing.Point(4, 22)
        Me.tabMainReqOff.Name = "tabMainReqOff"
        Me.tabMainReqOff.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMainReqOff.Size = New System.Drawing.Size(617, 392)
        Me.tabMainReqOff.TabIndex = 1
        Me.tabMainReqOff.Text = "Request / Offered"
        Me.tabMainReqOff.UseVisualStyleBackColor = True
        '
        'tabRequestOffered
        '
        Me.tabRequestOffered.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tabRequestOffered.Controls.Add(Me.tabRequest)
        Me.tabRequestOffered.Controls.Add(Me.tabOffered)
        Me.tabRequestOffered.Location = New System.Drawing.Point(0, 17)
        Me.tabRequestOffered.Multiline = True
        Me.tabRequestOffered.Name = "tabRequestOffered"
        Me.tabRequestOffered.SelectedIndex = 0
        Me.tabRequestOffered.Size = New System.Drawing.Size(617, 375)
        Me.tabRequestOffered.TabIndex = 9
        '
        'tabRequest
        '
        Me.tabRequest.Controls.Add(Me.valueCurrency)
        Me.tabRequest.Controls.Add(Me.labelCurrency)
        Me.tabRequest.Controls.Add(Me.buttonDeleteRequest)
        Me.tabRequest.Controls.Add(Me.buttonRequestUpdate)
        Me.tabRequest.Controls.Add(Me.buttonRequestAddNew)
        Me.tabRequest.Controls.Add(Me.buttonRequestConfirm)
        Me.tabRequest.Controls.Add(Me.gridRequests)
        Me.tabRequest.Controls.Add(Me.valueAmountRequest)
        Me.tabRequest.Controls.Add(Me.labelQuantity)
        Me.tabRequest.Controls.Add(Me.valueDescriptionRequest)
        Me.tabRequest.Controls.Add(Me.labelDescription)
        Me.tabRequest.Controls.Add(Me.valueTypeRequest)
        Me.tabRequest.Controls.Add(Me.labelType)
        Me.tabRequest.Location = New System.Drawing.Point(23, 4)
        Me.tabRequest.Name = "tabRequest"
        Me.tabRequest.Padding = New System.Windows.Forms.Padding(3)
        Me.tabRequest.Size = New System.Drawing.Size(590, 367)
        Me.tabRequest.TabIndex = 0
        Me.tabRequest.Text = "Request"
        Me.tabRequest.UseVisualStyleBackColor = True
        '
        'valueCurrency
        '
        Me.valueCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.valueCurrency.Enabled = False
        Me.valueCurrency.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueCurrency.FormattingEnabled = True
        Me.valueCurrency.Items.AddRange(New Object() {"Eur", "Dollar", "Bitcoin", "Ethereum", "Ripple", "Crypto Hide Coin", "Other"})
        Me.valueCurrency.Location = New System.Drawing.Point(355, 16)
        Me.valueCurrency.Name = "valueCurrency"
        Me.valueCurrency.Size = New System.Drawing.Size(210, 22)
        Me.valueCurrency.TabIndex = 24
        '
        'labelCurrency
        '
        Me.labelCurrency.AutoSize = True
        Me.labelCurrency.Enabled = False
        Me.labelCurrency.Location = New System.Drawing.Point(300, 19)
        Me.labelCurrency.Name = "labelCurrency"
        Me.labelCurrency.Size = New System.Drawing.Size(49, 13)
        Me.labelCurrency.TabIndex = 23
        Me.labelCurrency.Text = "Currency"
        '
        'buttonDeleteRequest
        '
        Me.buttonDeleteRequest.Location = New System.Drawing.Point(490, 148)
        Me.buttonDeleteRequest.Name = "buttonDeleteRequest"
        Me.buttonDeleteRequest.Size = New System.Drawing.Size(75, 23)
        Me.buttonDeleteRequest.TabIndex = 22
        Me.buttonDeleteRequest.Text = "Delete"
        Me.buttonDeleteRequest.UseVisualStyleBackColor = True
        '
        'buttonRequestUpdate
        '
        Me.buttonRequestUpdate.Location = New System.Drawing.Point(409, 148)
        Me.buttonRequestUpdate.Name = "buttonRequestUpdate"
        Me.buttonRequestUpdate.Size = New System.Drawing.Size(75, 23)
        Me.buttonRequestUpdate.TabIndex = 21
        Me.buttonRequestUpdate.Text = "Update"
        Me.buttonRequestUpdate.UseVisualStyleBackColor = True
        '
        'buttonRequestAddNew
        '
        Me.buttonRequestAddNew.Location = New System.Drawing.Point(328, 148)
        Me.buttonRequestAddNew.Name = "buttonRequestAddNew"
        Me.buttonRequestAddNew.Size = New System.Drawing.Size(75, 23)
        Me.buttonRequestAddNew.TabIndex = 20
        Me.buttonRequestAddNew.Text = "Add"
        Me.buttonRequestAddNew.UseVisualStyleBackColor = True
        '
        'buttonRequestConfirm
        '
        Me.buttonRequestConfirm.Location = New System.Drawing.Point(247, 148)
        Me.buttonRequestConfirm.Name = "buttonRequestConfirm"
        Me.buttonRequestConfirm.Size = New System.Drawing.Size(75, 23)
        Me.buttonRequestConfirm.TabIndex = 19
        Me.buttonRequestConfirm.Text = "Confirm"
        Me.buttonRequestConfirm.UseVisualStyleBackColor = True
        '
        'gridRequests
        '
        Me.gridRequests.AllowUserToAddRows = False
        Me.gridRequests.AllowUserToDeleteRows = False
        Me.gridRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridRequests.Location = New System.Drawing.Point(83, 177)
        Me.gridRequests.MultiSelect = False
        Me.gridRequests.Name = "gridRequests"
        Me.gridRequests.ReadOnly = True
        Me.gridRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridRequests.Size = New System.Drawing.Size(482, 159)
        Me.gridRequests.TabIndex = 6
        '
        'valueAmountRequest
        '
        Me.valueAmountRequest.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueAmountRequest.Location = New System.Drawing.Point(83, 119)
        Me.valueAmountRequest.Multiline = True
        Me.valueAmountRequest.Name = "valueAmountRequest"
        Me.valueAmountRequest.Size = New System.Drawing.Size(99, 20)
        Me.valueAmountRequest.TabIndex = 5
        Me.valueAmountRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelQuantity
        '
        Me.labelQuantity.AutoSize = True
        Me.labelQuantity.Location = New System.Drawing.Point(31, 119)
        Me.labelQuantity.Name = "labelQuantity"
        Me.labelQuantity.Size = New System.Drawing.Size(43, 13)
        Me.labelQuantity.TabIndex = 4
        Me.labelQuantity.Text = "Amount"
        '
        'valueDescriptionRequest
        '
        Me.valueDescriptionRequest.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueDescriptionRequest.Location = New System.Drawing.Point(83, 49)
        Me.valueDescriptionRequest.Multiline = True
        Me.valueDescriptionRequest.Name = "valueDescriptionRequest"
        Me.valueDescriptionRequest.Size = New System.Drawing.Size(482, 60)
        Me.valueDescriptionRequest.TabIndex = 3
        '
        'labelDescription
        '
        Me.labelDescription.AutoSize = True
        Me.labelDescription.Location = New System.Drawing.Point(17, 49)
        Me.labelDescription.Name = "labelDescription"
        Me.labelDescription.Size = New System.Drawing.Size(60, 13)
        Me.labelDescription.TabIndex = 2
        Me.labelDescription.Text = "Description"
        '
        'valueTypeRequest
        '
        Me.valueTypeRequest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.valueTypeRequest.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueTypeRequest.FormattingEnabled = True
        Me.valueTypeRequest.Items.AddRange(New Object() {"Currency / Cryptocurrency", "Other"})
        Me.valueTypeRequest.Location = New System.Drawing.Point(83, 16)
        Me.valueTypeRequest.Name = "valueTypeRequest"
        Me.valueTypeRequest.Size = New System.Drawing.Size(210, 22)
        Me.valueTypeRequest.TabIndex = 1
        '
        'labelType
        '
        Me.labelType.AutoSize = True
        Me.labelType.Location = New System.Drawing.Point(46, 19)
        Me.labelType.Name = "labelType"
        Me.labelType.Size = New System.Drawing.Size(31, 13)
        Me.labelType.TabIndex = 0
        Me.labelType.Text = "Type"
        '
        'tabOffered
        '
        Me.tabOffered.Controls.Add(Me.valueCurrencyOffered)
        Me.tabOffered.Controls.Add(Me.labelCurrencyOffered)
        Me.tabOffered.Controls.Add(Me.buttonDeleteOffered)
        Me.tabOffered.Controls.Add(Me.buttonOfferedUpdate)
        Me.tabOffered.Controls.Add(Me.buttonOfferedAddNew)
        Me.tabOffered.Controls.Add(Me.buttonOfferedConfirm)
        Me.tabOffered.Controls.Add(Me.gridOffered)
        Me.tabOffered.Controls.Add(Me.valueAmountOffered)
        Me.tabOffered.Controls.Add(Me.labelQuantityOffered)
        Me.tabOffered.Controls.Add(Me.valueDescriptionOffered)
        Me.tabOffered.Controls.Add(Me.labelDescriptionOffered)
        Me.tabOffered.Controls.Add(Me.valueTypeOffered)
        Me.tabOffered.Controls.Add(Me.labelTypeOffered)
        Me.tabOffered.Location = New System.Drawing.Point(23, 4)
        Me.tabOffered.Name = "tabOffered"
        Me.tabOffered.Padding = New System.Windows.Forms.Padding(3)
        Me.tabOffered.Size = New System.Drawing.Size(590, 367)
        Me.tabOffered.TabIndex = 1
        Me.tabOffered.Text = "Offered"
        Me.tabOffered.UseVisualStyleBackColor = True
        '
        'valueCurrencyOffered
        '
        Me.valueCurrencyOffered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.valueCurrencyOffered.Enabled = False
        Me.valueCurrencyOffered.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueCurrencyOffered.FormattingEnabled = True
        Me.valueCurrencyOffered.Items.AddRange(New Object() {"Eur", "Dollar", "Bitcoin", "Ethereum", "Ripple", "Crypto Hide Coin", "Other"})
        Me.valueCurrencyOffered.Location = New System.Drawing.Point(355, 17)
        Me.valueCurrencyOffered.Name = "valueCurrencyOffered"
        Me.valueCurrencyOffered.Size = New System.Drawing.Size(210, 22)
        Me.valueCurrencyOffered.TabIndex = 37
        '
        'labelCurrencyOffered
        '
        Me.labelCurrencyOffered.AutoSize = True
        Me.labelCurrencyOffered.Enabled = False
        Me.labelCurrencyOffered.Location = New System.Drawing.Point(300, 20)
        Me.labelCurrencyOffered.Name = "labelCurrencyOffered"
        Me.labelCurrencyOffered.Size = New System.Drawing.Size(49, 13)
        Me.labelCurrencyOffered.TabIndex = 36
        Me.labelCurrencyOffered.Text = "Currency"
        '
        'buttonDeleteOffered
        '
        Me.buttonDeleteOffered.Location = New System.Drawing.Point(490, 149)
        Me.buttonDeleteOffered.Name = "buttonDeleteOffered"
        Me.buttonDeleteOffered.Size = New System.Drawing.Size(75, 23)
        Me.buttonDeleteOffered.TabIndex = 35
        Me.buttonDeleteOffered.Text = "Delete"
        Me.buttonDeleteOffered.UseVisualStyleBackColor = True
        '
        'buttonOfferedUpdate
        '
        Me.buttonOfferedUpdate.Location = New System.Drawing.Point(409, 149)
        Me.buttonOfferedUpdate.Name = "buttonOfferedUpdate"
        Me.buttonOfferedUpdate.Size = New System.Drawing.Size(75, 23)
        Me.buttonOfferedUpdate.TabIndex = 34
        Me.buttonOfferedUpdate.Text = "Update"
        Me.buttonOfferedUpdate.UseVisualStyleBackColor = True
        '
        'buttonOfferedAddNew
        '
        Me.buttonOfferedAddNew.Location = New System.Drawing.Point(328, 149)
        Me.buttonOfferedAddNew.Name = "buttonOfferedAddNew"
        Me.buttonOfferedAddNew.Size = New System.Drawing.Size(75, 23)
        Me.buttonOfferedAddNew.TabIndex = 33
        Me.buttonOfferedAddNew.Text = "Add"
        Me.buttonOfferedAddNew.UseVisualStyleBackColor = True
        '
        'buttonOfferedConfirm
        '
        Me.buttonOfferedConfirm.Location = New System.Drawing.Point(247, 149)
        Me.buttonOfferedConfirm.Name = "buttonOfferedConfirm"
        Me.buttonOfferedConfirm.Size = New System.Drawing.Size(75, 23)
        Me.buttonOfferedConfirm.TabIndex = 32
        Me.buttonOfferedConfirm.Text = "Confirm"
        Me.buttonOfferedConfirm.UseVisualStyleBackColor = True
        '
        'gridOffered
        '
        Me.gridOffered.AllowUserToAddRows = False
        Me.gridOffered.AllowUserToDeleteRows = False
        Me.gridOffered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridOffered.Location = New System.Drawing.Point(83, 178)
        Me.gridOffered.MultiSelect = False
        Me.gridOffered.Name = "gridOffered"
        Me.gridOffered.ReadOnly = True
        Me.gridOffered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridOffered.Size = New System.Drawing.Size(482, 159)
        Me.gridOffered.TabIndex = 31
        '
        'valueAmountOffered
        '
        Me.valueAmountOffered.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueAmountOffered.Location = New System.Drawing.Point(83, 120)
        Me.valueAmountOffered.Multiline = True
        Me.valueAmountOffered.Name = "valueAmountOffered"
        Me.valueAmountOffered.Size = New System.Drawing.Size(99, 20)
        Me.valueAmountOffered.TabIndex = 30
        Me.valueAmountOffered.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labelQuantityOffered
        '
        Me.labelQuantityOffered.AutoSize = True
        Me.labelQuantityOffered.Location = New System.Drawing.Point(31, 120)
        Me.labelQuantityOffered.Name = "labelQuantityOffered"
        Me.labelQuantityOffered.Size = New System.Drawing.Size(43, 13)
        Me.labelQuantityOffered.TabIndex = 29
        Me.labelQuantityOffered.Text = "Amount"
        '
        'valueDescriptionOffered
        '
        Me.valueDescriptionOffered.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueDescriptionOffered.Location = New System.Drawing.Point(83, 50)
        Me.valueDescriptionOffered.Multiline = True
        Me.valueDescriptionOffered.Name = "valueDescriptionOffered"
        Me.valueDescriptionOffered.Size = New System.Drawing.Size(482, 60)
        Me.valueDescriptionOffered.TabIndex = 28
        '
        'labelDescriptionOffered
        '
        Me.labelDescriptionOffered.AutoSize = True
        Me.labelDescriptionOffered.Location = New System.Drawing.Point(17, 50)
        Me.labelDescriptionOffered.Name = "labelDescriptionOffered"
        Me.labelDescriptionOffered.Size = New System.Drawing.Size(60, 13)
        Me.labelDescriptionOffered.TabIndex = 27
        Me.labelDescriptionOffered.Text = "Description"
        '
        'valueTypeOffered
        '
        Me.valueTypeOffered.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.valueTypeOffered.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueTypeOffered.FormattingEnabled = True
        Me.valueTypeOffered.Items.AddRange(New Object() {"Currency / Cryptocurrency", "Other"})
        Me.valueTypeOffered.Location = New System.Drawing.Point(83, 17)
        Me.valueTypeOffered.Name = "valueTypeOffered"
        Me.valueTypeOffered.Size = New System.Drawing.Size(210, 22)
        Me.valueTypeOffered.TabIndex = 26
        '
        'labelTypeOffered
        '
        Me.labelTypeOffered.AutoSize = True
        Me.labelTypeOffered.Location = New System.Drawing.Point(46, 20)
        Me.labelTypeOffered.Name = "labelTypeOffered"
        Me.labelTypeOffered.Size = New System.Drawing.Size(31, 13)
        Me.labelTypeOffered.TabIndex = 25
        Me.labelTypeOffered.Text = "Type"
        '
        'tabMainOption
        '
        Me.tabMainOption.Controls.Add(Me.checkVisible)
        Me.tabMainOption.Controls.Add(Me.checkOnlyEntireAmount)
        Me.tabMainOption.Controls.Add(Me.checkNegotiable)
        Me.tabMainOption.Controls.Add(Me.checkAcceptOtherItems)
        Me.tabMainOption.Controls.Add(Me.valueArea)
        Me.tabMainOption.Controls.Add(Me.labelArea)
        Me.tabMainOption.Location = New System.Drawing.Point(4, 22)
        Me.tabMainOption.Name = "tabMainOption"
        Me.tabMainOption.Size = New System.Drawing.Size(617, 392)
        Me.tabMainOption.TabIndex = 2
        Me.tabMainOption.Text = "Options"
        Me.tabMainOption.UseVisualStyleBackColor = True
        '
        'checkVisible
        '
        Me.checkVisible.AutoSize = True
        Me.checkVisible.Location = New System.Drawing.Point(347, 149)
        Me.checkVisible.Name = "checkVisible"
        Me.checkVisible.Size = New System.Drawing.Size(56, 17)
        Me.checkVisible.TabIndex = 18
        Me.checkVisible.Text = "Visible"
        Me.checkVisible.UseVisualStyleBackColor = True
        '
        'checkOnlyEntireAmount
        '
        Me.checkOnlyEntireAmount.AutoSize = True
        Me.checkOnlyEntireAmount.Location = New System.Drawing.Point(347, 126)
        Me.checkOnlyEntireAmount.Name = "checkOnlyEntireAmount"
        Me.checkOnlyEntireAmount.Size = New System.Drawing.Size(116, 17)
        Me.checkOnlyEntireAmount.TabIndex = 17
        Me.checkOnlyEntireAmount.Text = "Only Entire Amount"
        Me.checkOnlyEntireAmount.UseVisualStyleBackColor = True
        '
        'checkNegotiable
        '
        Me.checkNegotiable.AutoSize = True
        Me.checkNegotiable.Location = New System.Drawing.Point(70, 149)
        Me.checkNegotiable.Name = "checkNegotiable"
        Me.checkNegotiable.Size = New System.Drawing.Size(77, 17)
        Me.checkNegotiable.TabIndex = 16
        Me.checkNegotiable.Text = "Negotiable"
        Me.checkNegotiable.UseVisualStyleBackColor = True
        '
        'checkAcceptOtherItems
        '
        Me.checkAcceptOtherItems.AutoSize = True
        Me.checkAcceptOtherItems.Location = New System.Drawing.Point(71, 126)
        Me.checkAcceptOtherItems.Name = "checkAcceptOtherItems"
        Me.checkAcceptOtherItems.Size = New System.Drawing.Size(117, 17)
        Me.checkAcceptOtherItems.TabIndex = 15
        Me.checkAcceptOtherItems.Text = "Accept Other Items"
        Me.checkAcceptOtherItems.UseVisualStyleBackColor = True
        '
        'valueArea
        '
        Me.valueArea.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.valueArea.Location = New System.Drawing.Point(71, 34)
        Me.valueArea.Multiline = True
        Me.valueArea.Name = "valueArea"
        Me.valueArea.Size = New System.Drawing.Size(522, 76)
        Me.valueArea.TabIndex = 14
        '
        'labelArea
        '
        Me.labelArea.AutoSize = True
        Me.labelArea.Location = New System.Drawing.Point(27, 34)
        Me.labelArea.Name = "labelArea"
        Me.labelArea.Size = New System.Drawing.Size(29, 13)
        Me.labelArea.TabIndex = 13
        Me.labelArea.Text = "Area"
        '
        'addAdvertisement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 471)
        Me.Controls.Add(Me.tabMain)
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonConfirm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "addAdvertisement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Insert new advertisement"
        Me.tabMain.ResumeLayout(False)
        Me.tabMainGeneral.ResumeLayout(False)
        Me.tabMainGeneral.PerformLayout()
        Me.tabMainReqOff.ResumeLayout(False)
        Me.tabRequestOffered.ResumeLayout(False)
        Me.tabRequest.ResumeLayout(False)
        Me.tabRequest.PerformLayout()
        CType(Me.gridRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOffered.ResumeLayout(False)
        Me.tabOffered.PerformLayout()
        CType(Me.gridOffered, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMainOption.ResumeLayout(False)
        Me.tabMainOption.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents buttonConfirm As Button
    Friend WithEvents buttonCancel As Button
    Friend WithEvents tabMain As TabControl
    Friend WithEvents tabMainGeneral As TabPage
    Friend WithEvents tabMainReqOff As TabPage
    Friend WithEvents valueAdvID As Label
    Friend WithEvents labelAdvID As Label
    Friend WithEvents dateEnd As DateTimePicker
    Friend WithEvents labelDateEnd As Label
    Friend WithEvents dateAdvStart As DateTimePicker
    Friend WithEvents labelDateStart As Label
    Friend WithEvents valueSignature As TextBox
    Friend WithEvents labelSignature As Label
    Friend WithEvents valueWalletId As TextBox
    Friend WithEvents labelWalletId As Label
    Friend WithEvents tabRequestOffered As TabControl
    Friend WithEvents tabRequest As TabPage
    Friend WithEvents gridRequests As DataGridView
    Friend WithEvents valueAmountRequest As TextBox
    Friend WithEvents labelQuantity As Label
    Friend WithEvents valueDescriptionRequest As TextBox
    Friend WithEvents labelDescription As Label
    Friend WithEvents valueTypeRequest As ComboBox
    Friend WithEvents labelType As Label
    Friend WithEvents tabMainOption As TabPage
    Friend WithEvents checkVisible As CheckBox
    Friend WithEvents checkOnlyEntireAmount As CheckBox
    Friend WithEvents checkNegotiable As CheckBox
    Friend WithEvents checkAcceptOtherItems As CheckBox
    Friend WithEvents valueArea As TextBox
    Friend WithEvents labelArea As Label
    Friend WithEvents buttonDeleteRequest As Button
    Friend WithEvents buttonRequestUpdate As Button
    Friend WithEvents buttonRequestAddNew As Button
    Friend WithEvents buttonRequestConfirm As Button
    Friend WithEvents valueCurrency As ComboBox
    Friend WithEvents labelCurrency As Label
    Friend WithEvents tabOffered As TabPage
    Friend WithEvents valueCurrencyOffered As ComboBox
    Friend WithEvents labelCurrencyOffered As Label
    Friend WithEvents buttonDeleteOffered As Button
    Friend WithEvents buttonOfferedUpdate As Button
    Friend WithEvents buttonOfferedAddNew As Button
    Friend WithEvents buttonOfferedConfirm As Button
    Friend WithEvents gridOffered As DataGridView
    Friend WithEvents valueAmountOffered As TextBox
    Friend WithEvents labelQuantityOffered As Label
    Friend WithEvents valueDescriptionOffered As TextBox
    Friend WithEvents labelDescriptionOffered As Label
    Friend WithEvents valueTypeOffered As ComboBox
    Friend WithEvents labelTypeOffered As Label
End Class
