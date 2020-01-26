<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Advertisements
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Advertisements))
        Me.gridMain = New System.Windows.Forms.DataGridView()
        Me.refreshData = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.filterAction = New System.Windows.Forms.Button()
        Me.addAction = New System.Windows.Forms.Button()
        Me.buttonModify = New System.Windows.Forms.Button()
        Me.buttonRemove = New System.Windows.Forms.Button()
        Me.benchMarkButton = New System.Windows.Forms.Button()
        CType(Me.gridMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridMain
        '
        Me.gridMain.AllowUserToAddRows = False
        Me.gridMain.AllowUserToDeleteRows = False
        Me.gridMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridMain.Location = New System.Drawing.Point(12, 12)
        Me.gridMain.Name = "gridMain"
        Me.gridMain.ReadOnly = True
        Me.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridMain.Size = New System.Drawing.Size(683, 451)
        Me.gridMain.TabIndex = 0
        '
        'refreshData
        '
        Me.refreshData.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.refreshData.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshData.Location = New System.Drawing.Point(701, 12)
        Me.refreshData.Name = "refreshData"
        Me.refreshData.Size = New System.Drawing.Size(90, 41)
        Me.refreshData.TabIndex = 1
        Me.refreshData.Text = "Refresh"
        Me.refreshData.UseVisualStyleBackColor = True
        '
        'Cancel
        '
        Me.Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cancel.Location = New System.Drawing.Point(701, 440)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(90, 23)
        Me.Cancel.TabIndex = 2
        Me.Cancel.Text = "Close"
        Me.Cancel.UseVisualStyleBackColor = True
        '
        'filterAction
        '
        Me.filterAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.filterAction.Location = New System.Drawing.Point(701, 87)
        Me.filterAction.Name = "filterAction"
        Me.filterAction.Size = New System.Drawing.Size(90, 23)
        Me.filterAction.TabIndex = 3
        Me.filterAction.Text = "Filter"
        Me.filterAction.UseVisualStyleBackColor = True
        '
        'addAction
        '
        Me.addAction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addAction.Location = New System.Drawing.Point(700, 116)
        Me.addAction.Name = "addAction"
        Me.addAction.Size = New System.Drawing.Size(90, 23)
        Me.addAction.TabIndex = 4
        Me.addAction.Text = "Insert"
        Me.addAction.UseVisualStyleBackColor = True
        '
        'buttonModify
        '
        Me.buttonModify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonModify.Location = New System.Drawing.Point(701, 145)
        Me.buttonModify.Name = "buttonModify"
        Me.buttonModify.Size = New System.Drawing.Size(90, 23)
        Me.buttonModify.TabIndex = 5
        Me.buttonModify.Text = "Modify"
        Me.buttonModify.UseVisualStyleBackColor = True
        '
        'buttonRemove
        '
        Me.buttonRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonRemove.Location = New System.Drawing.Point(701, 174)
        Me.buttonRemove.Name = "buttonRemove"
        Me.buttonRemove.Size = New System.Drawing.Size(90, 23)
        Me.buttonRemove.TabIndex = 6
        Me.buttonRemove.Text = "Remove"
        Me.buttonRemove.UseVisualStyleBackColor = True
        '
        'benchMarkButton
        '
        Me.benchMarkButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.benchMarkButton.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.benchMarkButton.Location = New System.Drawing.Point(701, 228)
        Me.benchMarkButton.Name = "benchMarkButton"
        Me.benchMarkButton.Size = New System.Drawing.Size(90, 23)
        Me.benchMarkButton.TabIndex = 7
        Me.benchMarkButton.Text = "Benchmark"
        Me.benchMarkButton.UseVisualStyleBackColor = True
        '
        'Advertisements
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 475)
        Me.Controls.Add(Me.benchMarkButton)
        Me.Controls.Add(Me.buttonRemove)
        Me.Controls.Add(Me.buttonModify)
        Me.Controls.Add(Me.addAction)
        Me.Controls.Add(Me.filterAction)
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.refreshData)
        Me.Controls.Add(Me.gridMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Advertisements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "[Advertisements List] - Private Market - Take My Tokens"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.gridMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gridMain As DataGridView
    Friend WithEvents refreshData As Button
    Friend WithEvents Cancel As Button
    Friend WithEvents filterAction As Button
    Friend WithEvents addAction As Button
    Friend WithEvents buttonModify As Button
    Friend WithEvents buttonRemove As Button
    Friend WithEvents benchMarkButton As Button
End Class
