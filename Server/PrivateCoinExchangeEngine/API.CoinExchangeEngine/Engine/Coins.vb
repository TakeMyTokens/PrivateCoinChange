Option Compare Text
Option Explicit On


Namespace AreaCoin

    Public Class Coins

        Inherits CHCCommonLibrary.CHCEngines.Common.BaseFileDB(Of List(Of Coin))


        Private _keyCoin As New Dictionary(Of String, Coin)

        Private _logEngine As CHCServerSupport.Support.LogEngine



        Public Class Coin

            Public identity As Integer = 0
            Public shortName As String = ""
            Public description As String = ""

            Public isFiat As Boolean = False

            Public symbol As String = ""

        End Class




        Private Sub trackLog(ByVal position As String, ByVal content As String, Optional ByVal messageType As String = "info")

            If Not IsNothing(_logEngine) Then

                _logEngine.track(position, content, messageType)

            End If

        End Sub



        Private Function rebuildIndex() As Boolean

            trackLog("Coins.rebuildIndex", "Begin")

            _keyCoin = New Dictionary(Of String, Coin)

            trackLog("Coins.rebuildIndex", "New Dictionary")

            For Each Coin In data

                _keyCoin.Add(Coin.shortName, Coin)

            Next

            trackLog("Coins.rebuildIndex", "For each ... completed")

            Return True

        End Function






        Public Function addNewCoin(ByVal shortName As String, ByVal symbol As String, Optional ByVal fiatCurrency As Boolean = False) As Coin

            Dim newElement As New Coin

            Try

                trackLog("Coins.addNewCoin", "Enter with shortName = " & shortName)

                newElement.shortName = shortName
                newElement.symbol = symbol
                newElement.identity = data.Count + 1
                newElement.isFiat = fiatCurrency

                trackLog("Coins.addNewCoin", "complete set")

                data.Add(newElement)
                _keyCoin.Add(shortName, newElement)

                trackLog("Coins.addNewCoin", "Element add")

            Catch ex As Exception

                trackLog("Coins.addNewCoin", "Error:" & ex.Message, "Fatal")

            End Try

            Return newElement

        End Function



        Public Function getCoin(ByVal shortName As String) As Coin

            Try

                trackLog("Coins.getCoin", "Begin")

                If _keyCoin.ContainsKey(shortName) Then

                    trackLog("Coins.getCoin", "ContainsKey")

                    Return _keyCoin.Item(shortName)

                End If

            Catch ex As Exception

                trackLog("Coins.getCoin", "Error:" & ex.Message, "Fatal")

            End Try

            Return New Coin

        End Function




        Public Function init(ByVal PathBaseDB As String, Optional ByVal logAdapter As CHCServerSupport.Support.LogEngine = Nothing) As Boolean

            Try

                Dim pathCoin As String

                _logEngine = logAdapter

                trackLog("Coins.init", "Begin")

                pathCoin = IO.Path.Combine(PathBaseDB, "Coins")

                trackLog("Coins.init", "PathBaseDB = " & pathCoin)

                If Not IO.Directory.Exists(pathCoin) Then

                    trackLog("Coins.init", "Path not exist")

                    IO.Directory.CreateDirectory(pathCoin)

                    trackLog("Coins.init", "Directory created")

                End If

                MyBase.fileName = IO.Path.Combine(pathCoin, "CurrentList.coins")

                trackLog("Coins.init", "fileName = " & MyBase.fileName)

                If Not MyBase.read() Then

                    trackLog("Coins.init", "Coin file not exist")

                    addNewCoin("EUR", "€", True).description = "Euro"
                    addNewCoin("USD", "$", True).description = "Dollar"
                    addNewCoin("BTC", "B").description = "Bitcoin"
                    addNewCoin("ETH", "E").description = "Ethereum"
                    addNewCoin("CHCS", "§").description = "Crypto Hide Coin"

                    trackLog("Coins.init", "Coin file not exist")

                    Return MyBase.save()

                End If

                trackLog("Coins.init", "Return with true")

                Return True

            Catch ex As Exception

                trackLog("Coins.init", "Error:" & ex.Message, "Fatal")

                Return False

            Finally

                trackLog("Coins.init", "Before rebuildIndex")

                rebuildIndex()

                trackLog("Coins.init", "After rebuildIndex")

            End Try

        End Function





    End Class

End Namespace