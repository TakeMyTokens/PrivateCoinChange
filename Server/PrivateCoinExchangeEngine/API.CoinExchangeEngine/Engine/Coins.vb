Option Compare Text
Option Explicit On


Public Class Coins

    Inherits AreaBase.BaseFileDB(Of List(Of Coin))


    Private _KeyCoin As New Dictionary(Of String, Coin)





    Private Function RebuildIndex() As Boolean

        _KeyCoin = New Dictionary(Of String, Coin)

        For Each Coin In Data

            _KeyCoin.Add(Coin.ShortName, Coin)

        Next

        Return True

    End Function



    Public Class Coin

        Public Identity As Integer = 0
        Public ShortName As String = ""
        Public Description As String = ""

        Public IsFiat As Boolean = False

        Public Symbol As String = ""

    End Class




    Public Function AddNewCoin(ByVal shortName As String, ByVal symbol As String, Optional ByVal fiatCurrency As Boolean = False) As Coin

        Dim newElement As New Coin

        Try

            newElement.ShortName = shortName
            newElement.Symbol = symbol
            newElement.Identity = Data.Count + 1
            newElement.IsFiat = fiatCurrency

            Data.Add(newElement)
            _KeyCoin.Add(shortName, newElement)

        Catch ex As Exception

        End Try

        Return newElement

    End Function


    Public Function GetCoin(ByVal shortName As String) As Coin

        Try

            If _KeyCoin.ContainsKey(shortName) Then

                Return _KeyCoin.Item(shortName)

            End If

        Catch ex As Exception

        End Try

        Return New Coin

    End Function



    Public Function Init(ByVal PathBaseDB As String) As Boolean

        Try

            Dim strPathCoin As String = IO.Path.Combine(PathBaseDB, "Coins")

            If Not IO.Directory.Exists(strPathCoin) Then

                IO.Directory.CreateDirectory(strPathCoin)

            End If

            MyBase.FileName = IO.Path.Combine(strPathCoin, "CurrentList.coins")

            If Not MyBase.Read() Then

                AddNewCoin("EUR", "€", True).Description = "Euro"
                AddNewCoin("USD", "$", True).Description = "Dollar"
                AddNewCoin("BTC", "B").Description = "Bitcoin"
                AddNewCoin("ETH", "E").Description = "Ethereum"
                AddNewCoin("CHCS", "§").Description = "Crypto Hide Coin"

                Return MyBase.Save()

            End If

            Return True

        Catch ex As Exception

            Return False

        Finally

            RebuildIndex()

        End Try

    End Function





End Class