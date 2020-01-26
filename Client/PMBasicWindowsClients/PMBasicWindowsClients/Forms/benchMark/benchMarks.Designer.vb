<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class benchMarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(benchMarks))
        Me.cryptoAssetLabel = New System.Windows.Forms.Label()
        Me.cryptoAssetSelect = New System.Windows.Forms.ComboBox()
        Me.showDataButton = New System.Windows.Forms.Button()
        Me.offerPanel = New System.Windows.Forms.GroupBox()
        Me.voonxLabel = New System.Windows.Forms.Label()
        Me.voonxQuantity = New System.Windows.Forms.TextBox()
        Me.quantityLabel = New System.Windows.Forms.Label()
        Me.voonxValue = New System.Windows.Forms.TextBox()
        Me.valueLabel = New System.Windows.Forms.Label()
        Me.voonxCapitalization = New System.Windows.Forms.TextBox()
        Me.capitalizationVOONXLabel = New System.Windows.Forms.Label()
        Me.awovnxLabel = New System.Windows.Forms.Label()
        Me.awovnxQuantity = New System.Windows.Forms.TextBox()
        Me.awovnxValue = New System.Windows.Forms.TextBox()
        Me.boanxCapitalization = New System.Windows.Forms.TextBox()
        Me.boanxLabel = New System.Windows.Forms.Label()
        Me.boanxQuantity = New System.Windows.Forms.TextBox()
        Me.boanxValue = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.branxValue = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.branxQuantity = New System.Windows.Forms.TextBox()
        Me.ovrnxQuantity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ovrnxValue = New System.Windows.Forms.TextBox()
        Me.branxCapitalization = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.awrvnxValue = New System.Windows.Forms.TextBox()
        Me.ovrnxCapitalization = New System.Windows.Forms.TextBox()
        Me.awrvnxQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.canxLabel = New System.Windows.Forms.Label()
        Me.canxValue = New System.Windows.Forms.TextBox()
        Me.vdnxLabel = New System.Windows.Forms.Label()
        Me.vdnxValue = New System.Windows.Forms.TextBox()
        Me.vdnxCapitalizationValue = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.offerPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cryptoAssetLabel
        '
        Me.cryptoAssetLabel.AutoSize = True
        Me.cryptoAssetLabel.Location = New System.Drawing.Point(54, 18)
        Me.cryptoAssetLabel.Name = "cryptoAssetLabel"
        Me.cryptoAssetLabel.Size = New System.Drawing.Size(38, 13)
        Me.cryptoAssetLabel.TabIndex = 0
        Me.cryptoAssetLabel.Text = "Asset"
        '
        'cryptoAssetSelect
        '
        Me.cryptoAssetSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cryptoAssetSelect.FormattingEnabled = True
        Me.cryptoAssetSelect.Location = New System.Drawing.Point(98, 13)
        Me.cryptoAssetSelect.Name = "cryptoAssetSelect"
        Me.cryptoAssetSelect.Size = New System.Drawing.Size(416, 21)
        Me.cryptoAssetSelect.TabIndex = 1
        '
        'showDataButton
        '
        Me.showDataButton.Location = New System.Drawing.Point(524, 12)
        Me.showDataButton.Name = "showDataButton"
        Me.showDataButton.Size = New System.Drawing.Size(75, 23)
        Me.showDataButton.TabIndex = 2
        Me.showDataButton.Text = "Show"
        Me.showDataButton.UseVisualStyleBackColor = True
        '
        'offerPanel
        '
        Me.offerPanel.Controls.Add(Me.quantityLabel)
        Me.offerPanel.Controls.Add(Me.boanxValue)
        Me.offerPanel.Controls.Add(Me.voonxLabel)
        Me.offerPanel.Controls.Add(Me.boanxQuantity)
        Me.offerPanel.Controls.Add(Me.voonxQuantity)
        Me.offerPanel.Controls.Add(Me.boanxLabel)
        Me.offerPanel.Controls.Add(Me.voonxValue)
        Me.offerPanel.Controls.Add(Me.boanxCapitalization)
        Me.offerPanel.Controls.Add(Me.valueLabel)
        Me.offerPanel.Controls.Add(Me.awovnxValue)
        Me.offerPanel.Controls.Add(Me.voonxCapitalization)
        Me.offerPanel.Controls.Add(Me.awovnxQuantity)
        Me.offerPanel.Controls.Add(Me.capitalizationVOONXLabel)
        Me.offerPanel.Controls.Add(Me.awovnxLabel)
        Me.offerPanel.Location = New System.Drawing.Point(22, 60)
        Me.offerPanel.Name = "offerPanel"
        Me.offerPanel.Size = New System.Drawing.Size(492, 151)
        Me.offerPanel.TabIndex = 19
        Me.offerPanel.TabStop = False
        Me.offerPanel.Text = "Offers"
        '
        'voonxLabel
        '
        Me.voonxLabel.AutoSize = True
        Me.voonxLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.voonxLabel.Location = New System.Drawing.Point(35, 52)
        Me.voonxLabel.Name = "voonxLabel"
        Me.voonxLabel.Size = New System.Drawing.Size(50, 13)
        Me.voonxLabel.TabIndex = 3
        Me.voonxLabel.Text = "VOONX"
        '
        'voonxQuantity
        '
        Me.voonxQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.voonxQuantity.ForeColor = System.Drawing.Color.CadetBlue
        Me.voonxQuantity.Location = New System.Drawing.Point(91, 49)
        Me.voonxQuantity.Name = "voonxQuantity"
        Me.voonxQuantity.ReadOnly = True
        Me.voonxQuantity.Size = New System.Drawing.Size(112, 21)
        Me.voonxQuantity.TabIndex = 4
        Me.voonxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'quantityLabel
        '
        Me.quantityLabel.AutoSize = True
        Me.quantityLabel.Location = New System.Drawing.Point(118, 33)
        Me.quantityLabel.Name = "quantityLabel"
        Me.quantityLabel.Size = New System.Drawing.Size(55, 13)
        Me.quantityLabel.TabIndex = 6
        Me.quantityLabel.Text = "Quantity"
        '
        'voonxValue
        '
        Me.voonxValue.BackColor = System.Drawing.SystemColors.Control
        Me.voonxValue.ForeColor = System.Drawing.Color.CadetBlue
        Me.voonxValue.Location = New System.Drawing.Point(209, 49)
        Me.voonxValue.Name = "voonxValue"
        Me.voonxValue.ReadOnly = True
        Me.voonxValue.Size = New System.Drawing.Size(112, 21)
        Me.voonxValue.TabIndex = 7
        Me.voonxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'valueLabel
        '
        Me.valueLabel.AutoSize = True
        Me.valueLabel.Location = New System.Drawing.Point(244, 33)
        Me.valueLabel.Name = "valueLabel"
        Me.valueLabel.Size = New System.Drawing.Size(38, 13)
        Me.valueLabel.TabIndex = 8
        Me.valueLabel.Text = "Value"
        '
        'voonxCapitalization
        '
        Me.voonxCapitalization.BackColor = System.Drawing.SystemColors.Control
        Me.voonxCapitalization.ForeColor = System.Drawing.Color.CadetBlue
        Me.voonxCapitalization.Location = New System.Drawing.Point(327, 64)
        Me.voonxCapitalization.Name = "voonxCapitalization"
        Me.voonxCapitalization.ReadOnly = True
        Me.voonxCapitalization.Size = New System.Drawing.Size(150, 21)
        Me.voonxCapitalization.TabIndex = 9
        Me.voonxCapitalization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'capitalizationVOONXLabel
        '
        Me.capitalizationVOONXLabel.AutoSize = True
        Me.capitalizationVOONXLabel.Location = New System.Drawing.Point(360, 33)
        Me.capitalizationVOONXLabel.Name = "capitalizationVOONXLabel"
        Me.capitalizationVOONXLabel.Size = New System.Drawing.Size(84, 13)
        Me.capitalizationVOONXLabel.TabIndex = 10
        Me.capitalizationVOONXLabel.Text = "Capitalization"
        '
        'awovnxLabel
        '
        Me.awovnxLabel.AutoSize = True
        Me.awovnxLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.awovnxLabel.Location = New System.Drawing.Point(23, 79)
        Me.awovnxLabel.Name = "awovnxLabel"
        Me.awovnxLabel.Size = New System.Drawing.Size(62, 13)
        Me.awovnxLabel.TabIndex = 11
        Me.awovnxLabel.Text = "AWOVNX"
        '
        'awovnxQuantity
        '
        Me.awovnxQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.awovnxQuantity.ForeColor = System.Drawing.Color.CadetBlue
        Me.awovnxQuantity.Location = New System.Drawing.Point(91, 76)
        Me.awovnxQuantity.Name = "awovnxQuantity"
        Me.awovnxQuantity.ReadOnly = True
        Me.awovnxQuantity.Size = New System.Drawing.Size(112, 21)
        Me.awovnxQuantity.TabIndex = 12
        Me.awovnxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'awovnxValue
        '
        Me.awovnxValue.BackColor = System.Drawing.SystemColors.Control
        Me.awovnxValue.ForeColor = System.Drawing.Color.CadetBlue
        Me.awovnxValue.Location = New System.Drawing.Point(209, 76)
        Me.awovnxValue.Name = "awovnxValue"
        Me.awovnxValue.ReadOnly = True
        Me.awovnxValue.Size = New System.Drawing.Size(112, 21)
        Me.awovnxValue.TabIndex = 14
        Me.awovnxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'boanxCapitalization
        '
        Me.boanxCapitalization.BackColor = System.Drawing.SystemColors.Control
        Me.boanxCapitalization.ForeColor = System.Drawing.Color.CadetBlue
        Me.boanxCapitalization.Location = New System.Drawing.Point(327, 103)
        Me.boanxCapitalization.Name = "boanxCapitalization"
        Me.boanxCapitalization.ReadOnly = True
        Me.boanxCapitalization.Size = New System.Drawing.Size(150, 21)
        Me.boanxCapitalization.TabIndex = 15
        Me.boanxCapitalization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'boanxLabel
        '
        Me.boanxLabel.AutoSize = True
        Me.boanxLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boanxLabel.Location = New System.Drawing.Point(34, 106)
        Me.boanxLabel.Name = "boanxLabel"
        Me.boanxLabel.Size = New System.Drawing.Size(50, 13)
        Me.boanxLabel.TabIndex = 16
        Me.boanxLabel.Text = "BOANX"
        '
        'boanxQuantity
        '
        Me.boanxQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.boanxQuantity.ForeColor = System.Drawing.Color.CadetBlue
        Me.boanxQuantity.Location = New System.Drawing.Point(91, 103)
        Me.boanxQuantity.Name = "boanxQuantity"
        Me.boanxQuantity.ReadOnly = True
        Me.boanxQuantity.Size = New System.Drawing.Size(112, 21)
        Me.boanxQuantity.TabIndex = 17
        Me.boanxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'boanxValue
        '
        Me.boanxValue.BackColor = System.Drawing.SystemColors.Control
        Me.boanxValue.ForeColor = System.Drawing.Color.CadetBlue
        Me.boanxValue.Location = New System.Drawing.Point(209, 103)
        Me.boanxValue.Name = "boanxValue"
        Me.boanxValue.ReadOnly = True
        Me.boanxValue.Size = New System.Drawing.Size(112, 21)
        Me.boanxValue.TabIndex = 18
        Me.boanxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.branxValue)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.branxQuantity)
        Me.GroupBox1.Controls.Add(Me.ovrnxQuantity)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ovrnxValue)
        Me.GroupBox1.Controls.Add(Me.branxCapitalization)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.awrvnxValue)
        Me.GroupBox1.Controls.Add(Me.ovrnxCapitalization)
        Me.GroupBox1.Controls.Add(Me.awrvnxQuantity)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 400)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 151)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(118, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Quantity"
        '
        'branxValue
        '
        Me.branxValue.BackColor = System.Drawing.SystemColors.Control
        Me.branxValue.ForeColor = System.Drawing.Color.Green
        Me.branxValue.Location = New System.Drawing.Point(209, 103)
        Me.branxValue.Name = "branxValue"
        Me.branxValue.ReadOnly = True
        Me.branxValue.Size = New System.Drawing.Size(112, 21)
        Me.branxValue.TabIndex = 18
        Me.branxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "OVRNX"
        '
        'branxQuantity
        '
        Me.branxQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.branxQuantity.ForeColor = System.Drawing.Color.Green
        Me.branxQuantity.Location = New System.Drawing.Point(91, 103)
        Me.branxQuantity.Name = "branxQuantity"
        Me.branxQuantity.ReadOnly = True
        Me.branxQuantity.Size = New System.Drawing.Size(112, 21)
        Me.branxQuantity.TabIndex = 17
        Me.branxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ovrnxQuantity
        '
        Me.ovrnxQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.ovrnxQuantity.ForeColor = System.Drawing.Color.Green
        Me.ovrnxQuantity.Location = New System.Drawing.Point(91, 49)
        Me.ovrnxQuantity.Name = "ovrnxQuantity"
        Me.ovrnxQuantity.ReadOnly = True
        Me.ovrnxQuantity.Size = New System.Drawing.Size(112, 21)
        Me.ovrnxQuantity.TabIndex = 4
        Me.ovrnxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "BRANX"
        '
        'ovrnxValue
        '
        Me.ovrnxValue.BackColor = System.Drawing.SystemColors.Control
        Me.ovrnxValue.ForeColor = System.Drawing.Color.Green
        Me.ovrnxValue.Location = New System.Drawing.Point(209, 49)
        Me.ovrnxValue.Name = "ovrnxValue"
        Me.ovrnxValue.ReadOnly = True
        Me.ovrnxValue.Size = New System.Drawing.Size(112, 21)
        Me.ovrnxValue.TabIndex = 7
        Me.ovrnxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'branxCapitalization
        '
        Me.branxCapitalization.BackColor = System.Drawing.SystemColors.Control
        Me.branxCapitalization.ForeColor = System.Drawing.Color.Green
        Me.branxCapitalization.Location = New System.Drawing.Point(327, 103)
        Me.branxCapitalization.Name = "branxCapitalization"
        Me.branxCapitalization.ReadOnly = True
        Me.branxCapitalization.Size = New System.Drawing.Size(150, 21)
        Me.branxCapitalization.TabIndex = 15
        Me.branxCapitalization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(244, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Value"
        '
        'awrvnxValue
        '
        Me.awrvnxValue.BackColor = System.Drawing.SystemColors.Control
        Me.awrvnxValue.ForeColor = System.Drawing.Color.Green
        Me.awrvnxValue.Location = New System.Drawing.Point(209, 76)
        Me.awrvnxValue.Name = "awrvnxValue"
        Me.awrvnxValue.ReadOnly = True
        Me.awrvnxValue.Size = New System.Drawing.Size(112, 21)
        Me.awrvnxValue.TabIndex = 14
        Me.awrvnxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ovrnxCapitalization
        '
        Me.ovrnxCapitalization.BackColor = System.Drawing.SystemColors.Control
        Me.ovrnxCapitalization.ForeColor = System.Drawing.Color.Green
        Me.ovrnxCapitalization.Location = New System.Drawing.Point(327, 64)
        Me.ovrnxCapitalization.Name = "ovrnxCapitalization"
        Me.ovrnxCapitalization.ReadOnly = True
        Me.ovrnxCapitalization.Size = New System.Drawing.Size(150, 21)
        Me.ovrnxCapitalization.TabIndex = 9
        Me.ovrnxCapitalization.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'awrvnxQuantity
        '
        Me.awrvnxQuantity.BackColor = System.Drawing.SystemColors.Control
        Me.awrvnxQuantity.ForeColor = System.Drawing.Color.Green
        Me.awrvnxQuantity.Location = New System.Drawing.Point(91, 76)
        Me.awrvnxQuantity.Name = "awrvnxQuantity"
        Me.awrvnxQuantity.ReadOnly = True
        Me.awrvnxQuantity.Size = New System.Drawing.Size(112, 21)
        Me.awrvnxQuantity.TabIndex = 12
        Me.awrvnxQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Capitalization"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "AWRVNX"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.TextBox11)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox5)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TextBox6)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(22, 217)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 177)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Exchange"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(118, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Quantity"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.ForeColor = System.Drawing.Color.Green
        Me.TextBox1.Location = New System.Drawing.Point(209, 103)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(112, 21)
        Me.TextBox1.TabIndex = 18
        Me.TextBox1.Text = "---"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(35, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "VEONX"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.ForeColor = System.Drawing.Color.Green
        Me.TextBox2.Location = New System.Drawing.Point(91, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(112, 21)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Text = "---"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox3.ForeColor = System.Drawing.Color.Green
        Me.TextBox3.Location = New System.Drawing.Point(91, 49)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(112, 21)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "---"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "MEPNX1"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox4.ForeColor = System.Drawing.Color.Green
        Me.TextBox4.Location = New System.Drawing.Point(209, 49)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(112, 21)
        Me.TextBox4.TabIndex = 7
        Me.TextBox4.Text = "---"
        Me.TextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox5.ForeColor = System.Drawing.Color.Green
        Me.TextBox5.Location = New System.Drawing.Point(327, 103)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(150, 21)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "---"
        Me.TextBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(244, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Value"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox6.ForeColor = System.Drawing.Color.Green
        Me.TextBox6.Location = New System.Drawing.Point(209, 76)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(112, 21)
        Me.TextBox6.TabIndex = 14
        Me.TextBox6.Text = "---"
        Me.TextBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox7.ForeColor = System.Drawing.Color.Green
        Me.TextBox7.Location = New System.Drawing.Point(327, 64)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(150, 21)
        Me.TextBox7.TabIndex = 9
        Me.TextBox7.Text = "---"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox8.ForeColor = System.Drawing.Color.Green
        Me.TextBox8.Location = New System.Drawing.Point(91, 76)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(112, 21)
        Me.TextBox8.TabIndex = 12
        Me.TextBox8.Text = "---"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(360, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Capitalization"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(23, 79)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "AWRVNX"
        '
        'canxLabel
        '
        Me.canxLabel.AutoSize = True
        Me.canxLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.canxLabel.Location = New System.Drawing.Point(57, 573)
        Me.canxLabel.Name = "canxLabel"
        Me.canxLabel.Size = New System.Drawing.Size(41, 13)
        Me.canxLabel.TabIndex = 22
        Me.canxLabel.Text = "CANX"
        '
        'canxValue
        '
        Me.canxValue.BackColor = System.Drawing.SystemColors.Control
        Me.canxValue.ForeColor = System.Drawing.Color.Green
        Me.canxValue.Location = New System.Drawing.Point(113, 570)
        Me.canxValue.Name = "canxValue"
        Me.canxValue.ReadOnly = True
        Me.canxValue.Size = New System.Drawing.Size(112, 21)
        Me.canxValue.TabIndex = 23
        Me.canxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'vdnxLabel
        '
        Me.vdnxLabel.AutoSize = True
        Me.vdnxLabel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vdnxLabel.Location = New System.Drawing.Point(263, 554)
        Me.vdnxLabel.Name = "vdnxLabel"
        Me.vdnxLabel.Size = New System.Drawing.Size(41, 13)
        Me.vdnxLabel.TabIndex = 24
        Me.vdnxLabel.Text = "VDNX"
        '
        'vdnxValue
        '
        Me.vdnxValue.BackColor = System.Drawing.SystemColors.Control
        Me.vdnxValue.ForeColor = System.Drawing.Color.Green
        Me.vdnxValue.Location = New System.Drawing.Point(231, 570)
        Me.vdnxValue.Name = "vdnxValue"
        Me.vdnxValue.Size = New System.Drawing.Size(112, 21)
        Me.vdnxValue.TabIndex = 25
        Me.vdnxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'vdnxCapitalizationValue
        '
        Me.vdnxCapitalizationValue.BackColor = System.Drawing.SystemColors.Control
        Me.vdnxCapitalizationValue.ForeColor = System.Drawing.Color.Green
        Me.vdnxCapitalizationValue.Location = New System.Drawing.Point(349, 570)
        Me.vdnxCapitalizationValue.Name = "vdnxCapitalizationValue"
        Me.vdnxCapitalizationValue.ReadOnly = True
        Me.vdnxCapitalizationValue.Size = New System.Drawing.Size(150, 21)
        Me.vdnxCapitalizationValue.TabIndex = 26
        Me.vdnxCapitalizationValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(382, 554)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Capitalization"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox9.ForeColor = System.Drawing.Color.Green
        Me.TextBox9.Location = New System.Drawing.Point(209, 130)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(112, 21)
        Me.TextBox9.TabIndex = 22
        Me.TextBox9.Text = "---"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox10.ForeColor = System.Drawing.Color.Green
        Me.TextBox10.Location = New System.Drawing.Point(91, 130)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(112, 21)
        Me.TextBox10.TabIndex = 21
        Me.TextBox10.Text = "---"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(27, 133)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "MEPNX2"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox11.ForeColor = System.Drawing.Color.Green
        Me.TextBox11.Location = New System.Drawing.Point(327, 130)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(150, 21)
        Me.TextBox11.TabIndex = 19
        Me.TextBox11.Text = "---"
        Me.TextBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'benchMarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 603)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.vdnxCapitalizationValue)
        Me.Controls.Add(Me.vdnxLabel)
        Me.Controls.Add(Me.vdnxValue)
        Me.Controls.Add(Me.canxLabel)
        Me.Controls.Add(Me.canxValue)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.offerPanel)
        Me.Controls.Add(Me.showDataButton)
        Me.Controls.Add(Me.cryptoAssetSelect)
        Me.Controls.Add(Me.cryptoAssetLabel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "benchMarks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Benchmark"
        Me.offerPanel.ResumeLayout(False)
        Me.offerPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cryptoAssetLabel As Label
    Friend WithEvents cryptoAssetSelect As ComboBox
    Friend WithEvents showDataButton As Button
    Friend WithEvents offerPanel As GroupBox
    Friend WithEvents quantityLabel As Label
    Friend WithEvents boanxValue As TextBox
    Friend WithEvents voonxLabel As Label
    Friend WithEvents boanxQuantity As TextBox
    Friend WithEvents voonxQuantity As TextBox
    Friend WithEvents boanxLabel As Label
    Friend WithEvents voonxValue As TextBox
    Friend WithEvents boanxCapitalization As TextBox
    Friend WithEvents valueLabel As Label
    Friend WithEvents awovnxValue As TextBox
    Friend WithEvents voonxCapitalization As TextBox
    Friend WithEvents awovnxQuantity As TextBox
    Friend WithEvents capitalizationVOONXLabel As Label
    Friend WithEvents awovnxLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents branxValue As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents branxQuantity As TextBox
    Friend WithEvents ovrnxQuantity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ovrnxValue As TextBox
    Friend WithEvents branxCapitalization As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents awrvnxValue As TextBox
    Friend WithEvents ovrnxCapitalization As TextBox
    Friend WithEvents awrvnxQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents canxLabel As Label
    Friend WithEvents canxValue As TextBox
    Friend WithEvents vdnxLabel As Label
    Friend WithEvents vdnxValue As TextBox
    Friend WithEvents vdnxCapitalizationValue As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox11 As TextBox
End Class
