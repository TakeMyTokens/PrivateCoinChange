Option Compare Text
Option Explicit On




Namespace AreaModel

    Public Class Configuration

        Public Enum enumConfigurationMode
            onlyRead
            complete
        End Enum


        Public mode As enumConfigurationMode = enumConfigurationMode.onlyRead
        Public urlServer As String = "https://ws-private-market.takemytokens.com"

    End Class

End Namespace

