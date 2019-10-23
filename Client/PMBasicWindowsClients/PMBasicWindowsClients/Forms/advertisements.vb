Option Compare Text
Option Explicit On



Public Class Advertisements


    Private _AdvList As List(Of AreaAdvertisement.advertisement)




    Private Sub addColumn(ByVal colNum As Integer, ByVal caption As String, ByVal minSize As Double, ByVal width As Double, Optional ByVal fontBold As Boolean = False, Optional ByVal alignment As ContentAlignment = ContentAlignment.TopRight, Optional ByVal highlight As Boolean = False, Optional nameColumn As String = "")

        Try

            With gridMain.Columns(colNum)

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
                    .HeaderCell.Style.Font = New Font("Courier New", 8.25!, FontStyle.Bold)
                    .DefaultCellStyle.Font = New Font("Courier New", 8.25!, FontStyle.Bold)
                Else
                    .HeaderCell.Style.Font = New Font("Courier New", 8.25!)
                    .DefaultCellStyle.Font = New Font("Courier New", 8.25!)
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



    Private Sub showData()

        Try

            Dim row As ArrayList

            gridMain.Rows.Clear()

            For Each item In _AdvList

                row = New ArrayList

                row.Add(item.dateAdvertisementEnd.ToString("dd/MM/yyyy"))
                row.Add(item.walletID)
                row.Add(item.offeredItems(0).description)
                row.Add(Format(item.offeredItems(0).amount, "#,##0.00"))
                row.Add("")
                row.Add(item.requestedItems(0).description)
                row.Add(Format(item.requestedItems(0).amount, "#,##0.00"))
                row.Add(item.exchangeArea)
                row.Add(item.id)
                row.Add(item.currentNumberQueue)

                gridMain.Rows.Add(row.ToArray)

            Next

        Catch ex As Exception

        End Try

    End Sub



    Private Sub initGrid()

        Try

            gridMain.ColumnCount = 10

            addColumn(0, "End", 80, 90,, ContentAlignment.MiddleLeft)
            addColumn(1, "Wallet", 140, 300,, ContentAlignment.MiddleLeft, True)
            addColumn(2, "Offered", 80, 100,, ContentAlignment.MiddleLeft)
            addColumn(3, "Amount", 80, 110,, ContentAlignment.MiddleRight)
            addColumn(4, "<->", 40, 40,, ContentAlignment.MiddleCenter,, "sepCol")
            addColumn(5, "Request", 80, 100,, ContentAlignment.MiddleLeft)
            addColumn(6, "Amount", 80, 110,, ContentAlignment.MiddleRight)
            addColumn(7, "Area", 150, 500,, ContentAlignment.MiddleLeft)
            addColumn(8, "id", 150, 30,, ContentAlignment.MiddleLeft)
            addColumn(9, "Queue", 100, 100,, ContentAlignment.MiddleCenter)

            gridMain.Columns(8).Visible = False

        Catch ex As Exception

        End Try

    End Sub


    Private Sub downloadData()

        Try

            Dim webReader As New AreaInternal.ProxyWS(Of List(Of AreaAdvertisement.advertisement))

            webReader.url = AreaCommon.configApplication.urlServer & "/api/v1/advertisements/?active=true"

            If webReader.getData() Then

                _AdvList = webReader.data

                showData()

            End If

        Catch ex As Exception

        End Try

    End Sub



    Private Sub Advertisements_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            AreaCommon.init()

            Text = Text & " rel. " & My.Application.Info.Version.ToString

            initGrid()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub refreshData_Click(sender As Object, e As EventArgs) Handles refreshData.Click

        downloadData()

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        Me.Close()

    End Sub

    Private Sub addAction_Click(sender As Object, e As EventArgs) Handles addAction.Click

        Dim addNew As New addAdvertisement

        addNew.ShowDialog()

        downloadData()

    End Sub

    Private Sub buttonModify_Click(sender As Object, e As EventArgs) Handles buttonModify.Click

        If Not IsNothing(gridMain.CurrentRow) Then

            Dim updateData As New updateAdvertisement

            updateData.advertisementData = _AdvList(gridMain.CurrentRow.Index)

            updateData.ShowDialog()

            showData()

        End If

    End Sub

    Private Sub buttonRemove_Click(sender As Object, e As EventArgs) Handles buttonRemove.Click

        If Not IsNothing(gridMain.CurrentRow) Then

            Dim webSender As New AreaInternal.ProxyWS(Of AreaAdvertisement.advertisement)

            webSender.url = AreaCommon.configApplication.urlServer & "/api/v1/advertisements/" & _AdvList(gridMain.CurrentRow.Index).id.ToString

            If webSender.sendData("DELETE") Then

                MessageBox.Show("Data deleted")

            Else

                MessageBox.Show("Error during transfer data")

            End If

        End If

    End Sub


End Class
