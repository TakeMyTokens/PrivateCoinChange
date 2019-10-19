Imports System
Imports Newtonsoft.Json






Module Program

    Function fnCompleteProcessServer() As String

        If False Then

            Return "https://localhost:44305/api/v1/"

        Else

            Return "https://test-ws-private-market.takemytokens.com/api/v1/"

        End If

    End Function


    Private Sub AddNewExample()

        Dim clsEngine As New AreaInternal.ProxyWS(Of AreaModels.newAdvertisement)
        Dim clsElement As AreaModels.item

        clsEngine.URL = fnCompleteProcessServer() & "advertisements"

        clsEngine.Data = New AreaModels.newAdvertisement

        With clsEngine.Data

            .exchangeArea = "Catania - Barriera"

            .id = Guid.NewGuid

            clsElement = New AreaModels.item

            clsElement.amount = 1
            clsElement.description = "CHCS"
            clsElement.type = AreaModels.item.enumType.currency

            .offeredItems.Add(clsElement)

            clsElement = New AreaModels.item

            clsElement.amount = 480.9
            clsElement.description = "EUR"
            clsElement.type = AreaModels.item.enumType.currency

            '.requestedItems.Add(clsElement)

            .acceptOtherItems = True
            .negotiable = True
            .onlyEntireAmount = False
            .dateAdvertisementStart = Now
            .dateAdvertisementEnd = New Date(2039, 10, 15)

            .walletID = "0-1-0cbb5c3a-3449-4cf6-b21a-6c56b1d81607"

            .visible = True

            .signature = "ABCDEFGHIJKLM"

        End With

        clsEngine.SendData("POST")

        Console.WriteLine("Send this!")

    End Sub



    Private Sub UpdateExample()

        Dim clsEngine As New AreaInternal.ProxyWS(Of AreaModels.updateAdvertisement)
        Dim clsElement As AreaModels.item

        clsEngine.URL = fnCompleteProcessServer() & "advertisements/fa2e5303-302d-43a5-bb04-67657f6cab7f"

        clsEngine.Data = New AreaModels.updateAdvertisement

        With clsEngine.Data

            .exchangeArea = "Catania - Barriera"

            clsElement = New AreaModels.item

            clsElement.amount = 1
            clsElement.description = "CHCS"
            clsElement.type = AreaModels.item.enumType.currency

            .offeredItems.Add(clsElement)

            clsElement = New AreaModels.item

            clsElement.amount = 480.9
            clsElement.description = "EUR"
            clsElement.type = AreaModels.item.enumType.currency

            .requestedItems.Add(clsElement)

            .acceptOtherItems = True
            .negotiable = True
            .onlyEntireAmount = False
            .dateAdvertisementStart = Now
            .dateAdvertisementEnd = New Date(2039, 10, 15)

            .state = AreaModels.enumState.visible

            .signature = "ABCDEFGHIJKLM"

        End With

        clsEngine.SendData("PUT")

        Console.WriteLine("Send this!")

    End Sub


    Private Sub DeleteExample()

        Dim clsEngine As New AreaInternal.ProxyWS(Of AreaModels.Advertisement)

        clsEngine.URL = fnCompleteProcessServer() & "advertisements/fa2e5303-302d-43a5-bb04-67657f6cab7f"

        clsEngine.Data = New AreaModels.Advertisement

        clsEngine.SendData("DELETE")

        Console.WriteLine("Delete this!")

    End Sub


    Sub Main(args As String())

        'AddNewExample()
        'UpdateExample()
        'DeleteExample()

    End Sub

End Module
