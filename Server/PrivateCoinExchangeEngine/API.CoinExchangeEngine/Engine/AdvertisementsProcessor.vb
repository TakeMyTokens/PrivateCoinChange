Option Compare Text
Option Explicit On

Namespace AreaAdvertisement

    Public Class AdvertisementsProcessor



        Private _logEngine As CHCServerSupport.Support.LogEngine

        Public data As New List(Of BenchMarkData)
        Private _keys As New Dictionary(Of String, BenchMarkData)




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




        Private Sub trackLog(ByVal position As String, ByVal content As String, Optional ByVal messageType As String = "info")

            If Not IsNothing(_logEngine) Then

                _logEngine.track(position, content, messageType)

            End If

        End Sub



        Private Function getLocalBenchMark(ByVal shortNameOffered As String, shortNameRequest As String) As BenchMarkData

            Dim key As String = shortNameOffered & "-" & shortNameRequest
            Dim result As BenchMarkData

            If _keys.ContainsKey(key) Then

                result = _keys(key)

            Else

                result = New BenchMarkData

                result.assetBenchmark.shortNameReferement = shortNameOffered
                result.assetBenchmark.shortNameComparison = shortNameRequest

                result.referementDate = CHCCommonLibrary.CHCEngines.Miscellaneous.atMomentGMT()

                data.Add(result)
                _keys.Add(key, result)

            End If

            Return result

        End Function

        Public Function getBenchMark(ByVal key As String) As BenchMarkData

            Dim keys() As String = key.Split("-")

            If (keys.Count = 2) Then

                Return getLocalBenchMark(keys(0), keys(1))

            End If

            Return New BenchMarkData

        End Function



        Private Function getSingleBenchMark(ByRef newBenchMark As Boolean, ByVal benchMarkList As List(Of BenchMarkElement), ByVal benchMarkName As String) As BenchMarkElement

            Dim result As New BenchMarkElement

            If newBenchMark Then

                result.shortName = benchMarkName

                benchMarkList.Add(result)

            Else

                For Each item In benchMarkList

                    If (item.shortName = benchMarkName) Then

                        Return item

                    End If

                Next

                result.shortName = benchMarkName

                benchMarkList.Add(result)

            End If

            Return result

        End Function



        Private Function manageBenchMarkAdvAvailable(ByVal offered As AreaAdvertisement.Item, ByVal request As AreaAdvertisement.Item) As Boolean

            Dim benchMark As BenchMarkData
            Dim benchMarkInformation As BenchMarkElement
            Dim newBenchMark As Boolean

            Try

                benchMark = getLocalBenchMark(offered.description, request.description)

                newBenchMark = (benchMark.benchMarkList.Count = 0)

                benchMarkInformation = getSingleBenchMark(newBenchMark, benchMark.benchMarkList, "VOONX")

                benchMarkInformation.quantity += offered.amount
                benchMarkInformation.value += request.amount

                Dim support As Decimal = benchMarkInformation.value / benchMarkInformation.quantity

                benchMarkInformation = getSingleBenchMark(newBenchMark, benchMark.benchMarkList, "AWOVNX")

                benchMarkInformation.quantity = 1
                benchMarkInformation.value = support

                benchMarkInformation = getSingleBenchMark(newBenchMark, benchMark.benchMarkList, "BOANX")

                benchMarkInformation.quantity = 1

                support = (request.amount / offered.amount)

                If (support < benchMarkInformation.value) Or (benchMarkInformation.value = 0) Then

                    benchMarkInformation.value = support

                End If

                Return True

            Catch ex As Exception

                trackLog("AdvertisementsProcessor.manageBenchMarkAdvAvailable", "Error during run manageBenchMarkAdvAvailable err:" & ex.Message)

                Return False

            End Try

        End Function



        Private Function manageBenchMarkAdvRequest(ByVal offered As AreaAdvertisement.Item, ByVal request As AreaAdvertisement.Item) As Boolean

            Dim benchMark As BenchMarkData
            Dim benchMarkInformation As BenchMarkElement
            Dim newBenchMark As Boolean

            Try

                benchMark = getLocalBenchMark(request.description, offered.description)

                newBenchMark = (benchMark.benchMarkList.Count = 0)

                benchMarkInformation = getSingleBenchMark(newBenchMark, benchMark.benchMarkList, "OVRNX")

                benchMarkInformation.quantity += request.amount
                benchMarkInformation.value += offered.amount

                Dim support As Decimal = benchMarkInformation.value / benchMarkInformation.quantity

                benchMarkInformation = getSingleBenchMark(newBenchMark, benchMark.benchMarkList, "AWRVNX")

                benchMarkInformation.quantity = 1
                benchMarkInformation.value = support

                benchMarkInformation = getSingleBenchMark(newBenchMark, benchMark.benchMarkList, "BRANX")

                benchMarkInformation.quantity = 1

                support = (offered.amount / request.amount)

                If (support < benchMarkInformation.value) Or (benchMarkInformation.value = 0) Then

                    benchMarkInformation.value = support

                End If

                Return True

            Catch ex As Exception

                trackLog("AdvertisementsProcessor.manageBenchMarkAdvRequest", "Error during run manageBenchMarkAdvRequest err:" & ex.Message)

                Return False

            End Try

        End Function



        Private Function completeEvaluation() As Boolean

            Dim boanxValue As Decimal, branxValue As Decimal

            Try

                For Each item In data

                    If (item.assetBenchmark.shortNameReferement = "CHCS") Then

                        For Each tmp In item.benchMarkList

                            tmp.capitalizationReferement = CLng(237000000 * tmp.value / tmp.quantity)

                        Next

                    End If

                    boanxValue = 0 : branxValue = 0

                    For Each singleBenchMark In item.benchMarkList

                        If (singleBenchMark.shortName = "BOANX") Then

                            boanxValue = singleBenchMark.value

                        End If

                        If (singleBenchMark.shortName = "BRANX") Then

                            branxValue = singleBenchMark.value

                        End If

                    Next

                    With getSingleBenchMark(True, item.benchMarkList, "CANX")

                        .value = (boanxValue - branxValue) / 2

                    End With

                Next

                Return True

            Catch ex As Exception

                trackLog("AdvertisementsProcessor.completeEvaluation", "Error during run during completeEvaluation err:" & ex.Message)

                Return False

            End Try

        End Function



        Public Function init(ByVal dataADV As List(Of AreaAdvertisement.Advertisement), Optional ByVal logAdapter As CHCServerSupport.Support.LogEngine = Nothing) As Boolean

            Try

                _logEngine = logAdapter

                trackLog("AdvertisementsProcessor.init", "Begin")

                For Each item In dataADV

                    If (item.state = enumState.visible) Then

                        For Each itemOffered In item.offeredItems

                            If (itemOffered.type = AreaAdvertisement.Item.enumType.currency) Then

                                For Each itemRequest In item.requestedItems

                                    If (itemRequest.type = AreaAdvertisement.Item.enumType.currency) Then

                                        If Not manageBenchMarkAdvAvailable(itemOffered, itemRequest) Then

                                            trackLog("AdvertisementsProcessor.init", "Problem during execute manageBenchMarkAdvAvailable")
                                            Return False

                                        End If

                                        If Not manageBenchMarkAdvRequest(itemOffered, itemRequest) Then

                                            trackLog("AdvertisementsProcessor.init", "Problem during execute manageBenchMarkAdvRequest")
                                            Return False

                                        End If

                                    End If

                                Next

                            End If

                        Next

                    End If

                Next

                If Not completeEvaluation() Then

                    trackLog("AdvertisementsProcessor.init", "Problem during execute addCapitaliation")
                    Return False

                End If

                trackLog("AdvertisementsProcessor.init", "Return with true")

                Return True

            Catch ex As Exception

                trackLog("AdvertisementsProcessor.init", "Error:" & ex.Message, "Fatal")

                Return False

            Finally

                trackLog("AdvertisementsProcessor.init", "Finally")

            End Try

        End Function


        Public Function getAssetsCouple(Optional ByVal useLogEngineAccess As Boolean = False, Optional adapterLog As CHCServerSupport.Support.LogEngine = Nothing) As List(Of AdvertExchangeAsset)

            Dim result As New List(Of AdvertExchangeAsset)

            Try

                If useLogEngineAccess Then

                    adapterLog = _logEngine.createAccess()

                End If

                trackLog("AdvertisementsProcessor.getAssetsCouple", "Begin")

                Dim singleItem As AdvertExchangeAsset

                For Each item In data

                    singleItem = New AdvertExchangeAsset

                    singleItem.shortNameReferement = item.assetBenchmark.shortNameReferement
                    singleItem.shortNameComparison = item.assetBenchmark.shortNameComparison

                    result.Add(singleItem)

                Next

                trackLog("AdvertisementsProcessor.getAssetsCouple", "Return with true")

            Catch ex As Exception

                trackLog("AdvertisementsProcessor.getAssetsCouple", "Error:" & ex.Message, "Fatal")

            Finally

                trackLog("AdvertisementsProcessor.getAssetsCouple", "After rebuildIndex")

            End Try

            Return result

        End Function




    End Class

End Namespace