Option Compare Text
Option Explicit On



Public Class addAdvertisement

    Private Enum stateEdit
        insert
        update
        delete
    End Enum

    Public advertisementData As New AreaAdvertisement.newAdvertisement

    Private _StateEditRowRequest As stateEdit
    Private _ItemRequest As AreaAdvertisement.item
    Private _StateEditRowOffered As stateEdit
    Private _ItemOffered As AreaAdvertisement.item




    Private Sub addColumn(ByRef gridName As DataGridView, ByVal colNum As Integer, ByVal caption As String, ByVal minSize As Double, ByVal width As Double, Optional ByVal fontBold As Boolean = False, Optional ByVal alignment As ContentAlignment = ContentAlignment.TopRight, Optional ByVal highlight As Boolean = False, Optional nameColumn As String = "")

        Try

            With gridName.Columns(colNum)

                If nameColumn.Length = 0 Then
                    .Name = caption
                Else
                    .Name = nameColumn
                End If

                .HeaderText = caption
                .MinimumWidth = minSize
                .ReadOnly = True
                .Width = width
                .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter

                If fontBold Then
                    .HeaderCell.Style.Font = New Font("Tahoma", 8.25!, FontStyle.Bold)
                    .DefaultCellStyle.Font = New Font("Tahoma", 8.25!, FontStyle.Bold)
                End If

                .DefaultCellStyle.Alignment = alignment

                If highlight Then
                    .DefaultCellStyle.BackColor = SystemColors.Info
                Else
                    .DefaultCellStyle.BackColor = Color.GhostWhite
                End If

            End With

        Catch ex As Exception

        End Try

    End Sub


    Private Sub showData(ByRef gridName As DataGridView, ByRef items As List(Of AreaAdvertisement.item))

        Try

            Dim row As ArrayList

            gridName.Rows.Clear()

            For Each item In items

                row = New ArrayList

                If item.type = AreaAdvertisement.item.enumType.currency Then

                    row.Add("currency")

                Else

                    row.Add("other")

                End If

                row.Add(item.description)
                row.Add(item.amount.ToString())

                gridName.Rows.Add(row.ToArray)

            Next

        Catch ex As Exception

        End Try

    End Sub



    Private Sub initGrid()

        Try

            gridRequests.ColumnCount = 3

            addColumn(gridRequests, 0, "Type", 80, 80,, ContentAlignment.MiddleLeft)
            addColumn(gridRequests, 1, "Description", 120, 200,, ContentAlignment.MiddleLeft, True)
            addColumn(gridRequests, 2, "Amount", 80, 100,, ContentAlignment.MiddleRight)

            gridOffered.ColumnCount = 3

            addColumn(gridOffered, 0, "Type", 80, 80,, ContentAlignment.MiddleLeft)
            addColumn(gridOffered, 1, "Description", 120, 200,, ContentAlignment.MiddleLeft, True)
            addColumn(gridOffered, 2, "Amount", 80, 100,, ContentAlignment.MiddleRight)

        Catch ex As Exception

        End Try

    End Sub


    Private Sub addAdvertisement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        advertisementData.id = Guid.NewGuid

        valueAdvID.Text = advertisementData.id.ToString()

        initGrid()

    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click

        Me.Close()

    End Sub


    Private Sub insertModeRequest()

        _StateEditRowRequest = stateEdit.insert

        valueTypeRequest.SelectedIndex = -1
        valueDescriptionRequest.Text = ""
        valueAmountRequest.Text = ""
        labelCurrency.Enabled = False
        valueCurrency.SelectedIndex = -1
        valueCurrency.Enabled = False

        valueTypeRequest.Select()

    End Sub


    Private Sub insertModeOffered()

        _StateEditRowOffered = stateEdit.insert

        valueTypeOffered.SelectedIndex = -1
        valueDescriptionOffered.Text = ""
        valueAmountOffered.Text = ""
        labelCurrencyOffered.Enabled = False
        valueCurrencyOffered.SelectedIndex = -1
        valueCurrencyOffered.Enabled = False

        valueTypeOffered.Select()

    End Sub


    Private Sub buttonRequestConfirm_Click(sender As Object, e As EventArgs) Handles buttonRequestConfirm.Click

        If (valueTypeRequest.SelectedIndex = -1) Or (valueDescriptionRequest.Text.Length = 0) Or (valueAmountRequest.Text.Length = 0) Then

            Return

        End If

        If (_StateEditRowRequest = stateEdit.insert) Then

            Dim element As New AreaAdvertisement.item

            element.type = valueTypeRequest.SelectedIndex
            element.description = valueDescriptionRequest.Text
            element.amount = valueAmountRequest.Text

            advertisementData.requestedItems.Add(element)

            showData(gridRequests, advertisementData.requestedItems)

        Else

            _ItemRequest.type = valueTypeRequest.SelectedIndex
            _ItemRequest.description = valueDescriptionRequest.Text
            _ItemRequest.amount = valueAmountRequest.Text

            showData(gridRequests, advertisementData.requestedItems)

        End If

        insertModeRequest()

    End Sub

    Private Sub valueTypeRequest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles valueTypeRequest.SelectedIndexChanged

        Select Case valueTypeRequest.SelectedIndex

            Case 0

                labelCurrency.Enabled = True
                valueCurrency.Enabled = True
                valueCurrency.SelectedIndex = -1

            Case 1

                labelCurrency.Enabled = False
                valueCurrency.Enabled = False
                valueCurrency.SelectedIndex = -1

        End Select

    End Sub


    Private Sub valueCurrency_SelectedIndexChanged(sender As Object, e As EventArgs) Handles valueCurrency.SelectedIndexChanged

        Select Case valueCurrency.SelectedIndex

            Case 0 : valueDescriptionRequest.Text = "EUR"
            Case 1 : valueDescriptionRequest.Text = "USD"
            Case 2 : valueDescriptionRequest.Text = "BTC"
            Case 3 : valueDescriptionRequest.Text = "ETH"
            Case 4 : valueDescriptionRequest.Text = "XRP"
            Case 5 : valueDescriptionRequest.Text = "CHCS"
            Case 6 : valueDescriptionRequest.Text = "" : valueDescriptionRequest.Select()

        End Select

    End Sub


    Private Sub buttonRequestAddNew_Click(sender As Object, e As EventArgs) Handles buttonRequestAddNew.Click

        insertModeRequest()

    End Sub

    Private Sub buttonRequestUpdate_Click(sender As Object, e As EventArgs) Handles buttonRequestUpdate.Click

        If Not IsNothing(gridRequests.SelectedRows) Then

            _StateEditRowRequest = stateEdit.update
            _ItemRequest = advertisementData.requestedItems(gridRequests.CurrentRow.Index)

            If (gridRequests.CurrentRow.Cells(0).Value = "currency") Then
                valueTypeRequest.SelectedIndex = 0

                Select Case gridRequests.CurrentRow.Cells(1).Value
                    Case "EUR" : valueCurrency.SelectedIndex = 0
                    Case "USD" : valueCurrency.SelectedIndex = 1
                    Case "BTC" : valueCurrency.SelectedIndex = 2
                    Case "ETH" : valueCurrency.SelectedIndex = 3
                    Case "XRP" : valueCurrency.SelectedIndex = 4
                    Case "CHCS" : valueCurrency.SelectedIndex = 5
                    Case Else : valueDescriptionRequest.Text = gridRequests.CurrentRow.Cells(1).Value
                End Select

            Else
                valueTypeRequest.SelectedIndex = 1
                valueDescriptionRequest.Text = gridRequests.CurrentRow.Cells(1).Value
            End If

            valueAmountRequest.Text = gridRequests.CurrentRow.Cells(2).Value

        End If

    End Sub

    Private Sub buttonDeleteRequest_Click(sender As Object, e As EventArgs) Handles buttonDeleteRequest.Click

        If Not IsNothing(gridRequests.SelectedRows) Then

            advertisementData.requestedItems.RemoveAt(gridRequests.CurrentRow.Index)

            showData(gridRequests, advertisementData.requestedItems)

            insertModeRequest()

        End If

    End Sub

    Private Sub valueTypeOffered_SelectedIndexChanged(sender As Object, e As EventArgs) Handles valueTypeOffered.SelectedIndexChanged

        Select Case valueTypeOffered.SelectedIndex

            Case 0

                labelCurrencyOffered.Enabled = True
                valueCurrencyOffered.Enabled = True
                valueCurrencyOffered.SelectedIndex = -1

            Case 1

                labelCurrencyOffered.Enabled = False
                valueCurrencyOffered.Enabled = False
                valueCurrencyOffered.SelectedIndex = -1

        End Select

    End Sub

    Private Sub valueCurrencyOffered_SelectedIndexChanged(sender As Object, e As EventArgs) Handles valueCurrencyOffered.SelectedIndexChanged

        Select Case valueCurrencyOffered.SelectedIndex

            Case 0 : valueDescriptionOffered.Text = "EUR"
            Case 1 : valueDescriptionOffered.Text = "USD"
            Case 2 : valueDescriptionOffered.Text = "BTC"
            Case 3 : valueDescriptionOffered.Text = "ETH"
            Case 4 : valueDescriptionOffered.Text = "XRP"
            Case 5 : valueDescriptionOffered.Text = "CHCS"
            Case 6 : valueDescriptionOffered.Text = "" : valueDescriptionOffered.Select()

        End Select

    End Sub


    Private Sub buttonOfferedConfirm_Click(sender As Object, e As EventArgs) Handles buttonOfferedConfirm.Click

        If (valueTypeOffered.SelectedIndex = -1) Or (valueDescriptionOffered.Text.Length = 0) Or (valueAmountOffered.Text.Length = 0) Then

            Return

        End If

        If (_StateEditRowOffered = stateEdit.insert) Then

            Dim element As New AreaAdvertisement.item

            element.type = valueTypeOffered.SelectedIndex
            element.description = valueDescriptionOffered.Text
            element.amount = valueAmountOffered.Text

            advertisementData.offeredItems.Add(element)

            showData(gridOffered, advertisementData.offeredItems)

        Else

            _ItemOffered.type = valueTypeOffered.SelectedIndex
            _ItemOffered.description = valueDescriptionOffered.Text
            _ItemOffered.amount = valueAmountOffered.Text

            showData(gridOffered, advertisementData.offeredItems)

        End If

        insertModeOffered()

    End Sub

    Private Sub buttonOfferedAddNew_Click(sender As Object, e As EventArgs) Handles buttonOfferedAddNew.Click

        insertModeOffered()

    End Sub

    Private Sub buttonOfferedUpdate_Click(sender As Object, e As EventArgs) Handles buttonOfferedUpdate.Click

        If Not IsNothing(gridOffered.SelectedRows) Then

            _StateEditRowOffered = stateEdit.update
            _ItemOffered = advertisementData.offeredItems(gridOffered.CurrentRow.Index)

            If (gridOffered.CurrentRow.Cells(0).Value = "currency") Then
                valueTypeOffered.SelectedIndex = 0

                Select Case gridOffered.CurrentRow.Cells(1).Value
                    Case "EUR" : valueCurrencyOffered.SelectedIndex = 0
                    Case "USD" : valueCurrencyOffered.SelectedIndex = 1
                    Case "BTC" : valueCurrencyOffered.SelectedIndex = 2
                    Case "ETH" : valueCurrencyOffered.SelectedIndex = 3
                    Case "XRP" : valueCurrencyOffered.SelectedIndex = 4
                    Case "CHCS" : valueCurrencyOffered.SelectedIndex = 5
                    Case Else : valueDescriptionOffered.Text = gridOffered.CurrentRow.Cells(1).Value
                End Select

            Else
                valueTypeOffered.SelectedIndex = 1
                valueDescriptionOffered.Text = gridOffered.CurrentRow.Cells(1).Value
            End If

            valueAmountOffered.Text = gridOffered.CurrentRow.Cells(2).Value

        End If

    End Sub

    Private Sub buttonDeleteOffered_Click(sender As Object, e As EventArgs) Handles buttonDeleteOffered.Click

        If Not IsNothing(gridOffered.SelectedRows) Then

            advertisementData.offeredItems.RemoveAt(gridOffered.CurrentRow.Index)

            showData(gridOffered, advertisementData.offeredItems)

            insertModeOffered()

        End If

    End Sub

    Private Sub buttonConfirm_Click(sender As Object, e As EventArgs) Handles buttonConfirm.Click

        advertisementData.acceptOtherItems = checkAcceptOtherItems.Checked
        advertisementData.dateAdvertisementStart = dateAdvStart.Value
        advertisementData.dateAdvertisementEnd = dateEnd.Value
        advertisementData.exchangeArea = valueArea.Text.ToString()
        advertisementData.negotiable = checkNegotiable.Checked
        advertisementData.onlyEntireAmount = checkOnlyEntireAmount.Checked
        advertisementData.signature = valueSignature.Text.ToString
        advertisementData.visible = checkVisible.Checked
        advertisementData.walletID = valueWalletId.Text

        Dim webSender As New AreaInternal.ProxyWS(Of AreaAdvertisement.newAdvertisement)

        webSender.url = AreaCommon.configApplication.urlServer & "/api/v1/advertisements"

        webSender.data = advertisementData

        If webSender.sendData("POST") Then

            MessageBox.Show("Advertisement transmitted")

            Me.Close()

        Else

            MessageBox.Show("Error during transfer data")

        End If


    End Sub



End Class