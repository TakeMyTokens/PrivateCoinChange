Option Compare Text
Option Explicit On



Namespace AreaModels


    Public Enum enumState

        notVisible
        visible
        deleted
        closed

    End Enum


    ''' <summary>
    ''' This class contain the Item data
    ''' </summary>
    Public Class item

        Public Enum enumType

            currency
            other

        End Enum

        Public amount As Decimal = 1
        Public type As enumType = enumType.currency
        Public description As String = ""

    End Class



    ''' <summary>
    ''' This class is a base of Advertisement
    ''' </summary>
    Public Class baseAdvertisement

        Public id As Guid

        Public dateAdvertisementStart As DateTime = DateTime.MinValue
        Public dateAdvertisementEnd As DateTime = DateTime.MinValue

        Public offeredItems As New List(Of item)
        Public requestedItems As New List(Of item)

        Public acceptOtherItems As Boolean = False
        Public negotiable As Boolean = False
        Public onlyEntireAmount As Boolean = False

        Public exchangeArea As String = ""

    End Class


    ''' <summary>
    ''' This class contain the information reguard a New Advert data
    ''' </summary>
    Public Class newAdvertisement

        Inherits baseAdvertisement

        Public walletID As String = ""
        Public signature As String = ""

        Public visible As Boolean = False

    End Class


    ''' <summary>
    ''' This class contain the information reguard an Edit Advert data
    ''' </summary>
    Public Class updateAdvertisement

        Inherits baseAdvertisement

        Public signature As String = ""

        Public state As enumState

    End Class


    ''' <summary>
    ''' This class contain the information reguard the advertisement
    ''' </summary>
    Public Class Advertisement

        Inherits baseAdvertisement

        Public dateUpdate As DateTime = DateTime.MinValue

        Public walletID As String = ""

        Public state As enumState = enumState.visible

        Public currentNumberQueue As Integer = 0

    End Class



End Namespace