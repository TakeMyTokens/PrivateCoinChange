Option Compare Text
Option Explicit On



Namespace AreaModels


    Public Class CoinQuantity

        Public ID_Coin As Integer = 0
        Public Quantity As Decimal = 0

    End Class

    Public Class NewAdvert

        Public WalletID As String = ""

        Public Have As New CoinQuantity
        Public Wish As New List(Of CoinQuantity)

        Public IsVisible As Boolean = False
        Public IsAcceptOtherItems As Boolean = False
        Public IsNegotiable As Boolean = False
        Public IsOnlyEntireQuantity As Boolean = False

        Public ExchangeArea As String = ""

    End Class



End Namespace

Module Module1

    Function fnCompleteProcessServer() As String

        Return "https://localhost:44305/api/v1/NewAdvert"

    End Function


    Sub Main(args As String())

        Dim clsEngine As New AreaInternal.ProxyWS(Of AreaModels.NewAdvert)

        clsEngine.URL = fnCompleteProcessServer() & "/id=AAA"

        clsEngine.Data = New AreaModels.NewAdvert

        clsEngine.Data.ExchangeArea = "Acireale"
        clsEngine.Data.IsNegotiable = True

        clsEngine.SendData()

        Console.WriteLine("Hello World!")

    End Sub

End Module
