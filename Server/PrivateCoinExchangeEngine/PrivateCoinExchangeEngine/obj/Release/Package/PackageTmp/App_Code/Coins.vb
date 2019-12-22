Option Compare Text
Option Explicit On





Public Class Coins




    Private _Coins As New List(Of Coin)



    Public Class Coin

        Public Identity As Integer = 0
        Public CoinShort As String = ""
        Public Description As String = ""

    End Class

End Class
