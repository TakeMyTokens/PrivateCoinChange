Option Compare Text
Option Explicit On

Public Class benchMarks

    Public Const SecureAuthorizationIntraPublic As String = "^jmabNT9VwNE@4"

    Public Class AdvertExchangeAsset

        Public shortNameReferement As String = ""
        Public shortNameComparison As String = ""

    End Class

    Public Class BenchMarkElement

        Public shortName As String = ""
        Public quantity As Decimal = 0.0
        Public value As Decimal = 0.0
        Public capitalizationReferement As Decimal = 0.0

    End Class

    Public Class BenchMarkData

        Public referementDate As New DateTime
        Public assetBenchmark As New AdvertExchangeAsset
        Public benchMarkList As New List(Of BenchMarkElement)

    End Class



    Public Class currentChangeCurrency

        Public shortCurrency As String
        Public [date] As DateTime
        Public currentValue As Decimal

    End Class



    Private Function getVdnxCurrentValue() As Decimal

        Try

            Dim webReader As New CHCCommonLibrary.CHCEngines.Communication.ProxyWS(Of currentChangeCurrency)

            webReader.url = "https://historyvalue.cryptohidecoin.org/api/v1/services/CurrentDataCurrency?SecurityToken=" & SecureAuthorizationIntraPublic

            If webReader.getData() Then

                Return webReader.data.currentValue

            End If

        Catch ex As Exception

        End Try

        Return 0

    End Function



    Private Sub loadCryptoList()

        Dim data As List(Of AdvertExchangeAsset)

        Try

            Dim webReader As New CHCCommonLibrary.CHCEngines.Communication.ProxyWS(Of List(Of AdvertExchangeAsset))

            webReader.url = AreaCommon.configApplication.urlServer & "/api/v1/Assets/"

            If webReader.getData() Then

                data = webReader.data

                cryptoAssetSelect.Items.Clear()

                For Each item In data

                    cryptoAssetSelect.Items.Add(item.shortNameReferement & "-" & item.shortNameComparison)

                Next

            Else

                MessageBox.Show("An error occurrent during loadCryptoList", "Error")

            End If

        Catch ex As Exception

            MessageBox.Show("An error occurrent during loadCryptoList - " & ex.Message, "Error")

        End Try

    End Sub


    Private Sub loadCryptoAssetData()

        Dim data As BenchMarkData
        Dim vdnx As Decimal

        Try

            Dim webReader As New CHCCommonLibrary.CHCEngines.Communication.ProxyWS(Of BenchMarkData)

            webReader.url = AreaCommon.configApplication.urlServer & "/api/v1/BenchMarkAsset?key=" & cryptoAssetSelect.Text

            If webReader.getData() Then

                vdnx = getVdnxCurrentValue()
                vdnxValue.Text = FormatNumber(vdnx, 6, TriState.True, TriState.False, TriState.True)
                vdnxCapitalizationValue.Text = FormatNumber(vdnx * 237000000, 0, TriState.True, TriState.False, TriState.True)

                data = webReader.data

                For Each item In data.benchMarkList

                    Select Case item.shortName

                        Case "VOONX"

                            voonxQuantity.Text = FormatNumber(item.quantity, 3, TriState.True, TriState.False, TriState.True)
                            voonxValue.Text = FormatNumber(item.value, 5, TriState.True, TriState.False, TriState.True)
                            voonxCapitalization.Text = FormatNumber(item.capitalizationReferement, 0, TriState.True, TriState.False, TriState.True)

                        Case "AWOVNX"

                            awovnxQuantity.Text = FormatNumber(item.quantity, 3, TriState.True, TriState.False, TriState.True)
                            awovnxValue.Text = FormatNumber(item.value, 5, TriState.True, TriState.False, TriState.True)

                        Case "BOANX"

                            boanxQuantity.Text = FormatNumber(item.quantity, 3, TriState.True, TriState.False, TriState.True)
                            boanxValue.Text = FormatNumber(item.value, 5, TriState.True, TriState.False, TriState.True)
                            boanxCapitalization.Text = FormatNumber(item.capitalizationReferement, 0, TriState.True, TriState.False, TriState.True)

                        Case "OVRNX"

                            ovrnxQuantity.Text = FormatNumber(item.quantity, 3, TriState.True, TriState.False, TriState.True)
                            ovrnxValue.Text = FormatNumber(item.value, 6, TriState.True, TriState.False, TriState.True)
                            ovrnxCapitalization.Text = FormatNumber(item.capitalizationReferement, 0, TriState.True, TriState.False, TriState.True)

                        Case "AWRVNX"

                            awrvnxQuantity.Text = FormatNumber(item.quantity, 3, TriState.True, TriState.False, TriState.True)
                            awrvnxValue.Text = FormatNumber(item.value, 6, TriState.True, TriState.False, TriState.True)

                        Case "BRANX"

                            branxQuantity.Text = FormatNumber(item.quantity, 3, TriState.True, TriState.False, TriState.True)
                            branxValue.Text = FormatNumber(item.value, 6, TriState.True, TriState.False, TriState.True)
                            branxCapitalization.Text = FormatNumber(item.capitalizationReferement, 0, TriState.True, TriState.False, TriState.True)

                        Case "CANX"

                            canxValue.Text = FormatNumber(item.value, 6, TriState.True, TriState.False, TriState.True)

                    End Select

                Next

            Else

                MessageBox.Show("An error occurrent during loadCryptoList", "Error")

            End If

        Catch ex As Exception

        End Try

    End Sub




    Private Sub benchMarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loadCryptoList()

    End Sub

    Private Sub showDataButton_Click(sender As Object, e As EventArgs) Handles showDataButton.Click

        If (cryptoAssetSelect.SelectedIndex > -1) Then

            loadCryptoAssetData()

        End If

    End Sub


End Class