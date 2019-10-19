Imports System.Net
Imports System.Web.Http



Public Class AdvertisementsController

    Inherits ApiController



    ' GET api/Advertsings
    ''' <summary>
    ''' This method provides to return a complete list of advertisement archive (with or not filters)
    ''' </summary>
    ''' <param name="Active"></param>
    ''' <returns></returns>
    Public Function getValues(ByVal Active As Boolean) As IEnumerable(Of APIPrivateMarketEngine.AreaAdvertisement.Advertisement)

        If Active Then

            Return AreaCommon.Adverts.Data.AsEnumerable

        Else

            Return AreaCommon.Adverts.GetActive()

        End If

    End Function

    ' GET api/Advertsings/id
    Public Function getValue(ByVal id As String) As APIPrivateMarketEngine.AreaAdvertisement.Advertisement

        Dim idGUID As Guid

        Try

            Guid.TryParse(id, idGUID)

            Return AreaCommon.Adverts.GetData(idGUID)

        Catch

        End Try

        Return New APIPrivateMarketEngine.AreaAdvertisement.Advertisement

    End Function



    ' POST api/Advertsings
    Public Sub postValue(<FromBody()> ByVal value As APIPrivateMarketEngine.AreaAdvertisement.newAdvertisement)

        Dim newElement As APIPrivateMarketEngine.AreaAdvertisement.item
        Dim newAdv As APIPrivateMarketEngine.AreaAdvertisement.advertisement

        Try

            newAdv = AreaCommon.Adverts.add()

            With newAdv

                .dateAdvertisementStart = value.dateAdvertisementStart
                .dateAdvertisementEnd = value.dateAdvertisementEnd

                .walletID = value.walletID

                For Each element In value.requestedItems

                    newElement = New APIPrivateMarketEngine.AreaAdvertisement.item

                    newElement.amount = element.amount
                    newElement.description = element.description
                    newElement.type = element.type

                    .requestedItems.Add(newElement)

                Next

                For Each element In value.offeredItems

                    newElement = New APIPrivateMarketEngine.AreaAdvertisement.item

                    newElement.amount = element.amount
                    newElement.description = element.description
                    newElement.type = element.type

                    .offeredItems.Add(newElement)

                Next

                If value.visible Then

                    .state = APIPrivateMarketEngine.AreaAdvertisement.enumState.visible

                Else

                    .state = APIPrivateMarketEngine.AreaAdvertisement.enumState.notVisible

                End If

                .acceptOtherItems = value.acceptOtherItems
                .negotiable = value.negotiable
                .onlyEntireAmount = value.onlyEntireAmount

                .exchangeArea = value.exchangeArea

            End With

            AreaCommon.adverts.pathBaseAdvertisement = IO.Path.Combine(AreaCommon.pathBaseDB, "Advertisements")

            AreaCommon.adverts.save(newAdv.id)

        Catch ex As Exception

        End Try

    End Sub



    ' PUT api/Advertsings/id
    Public Sub putValue(ByVal id As String, <FromBody()> ByVal value As APIPrivateMarketEngine.AreaAdvertisement.updateAdvertisement)

        Dim newElement As APIPrivateMarketEngine.AreaAdvertisement.item

        Dim idGUID As Guid

        Try

            Guid.TryParse(id, idGUID)

            With AreaCommon.Adverts.GetData(idGUID)

                .dateAdvertisementStart = value.dateAdvertisementStart
                .dateAdvertisementEnd = value.dateAdvertisementEnd

                .requestedItems.Clear()

                For Each element In value.requestedItems

                    newElement = New APIPrivateMarketEngine.AreaAdvertisement.item

                    newElement.amount = element.amount
                    newElement.description = element.description
                    newElement.type = element.type

                    .requestedItems.Add(newElement)

                Next

                .offeredItems.Clear()

                For Each element In value.offeredItems

                    newElement = New APIPrivateMarketEngine.AreaAdvertisement.item

                    newElement.amount = element.amount
                    newElement.description = element.description
                    newElement.type = element.type

                    .offeredItems.Add(newElement)

                Next

                .state = .state

                .acceptOtherItems = value.acceptOtherItems
                .negotiable = value.negotiable
                .onlyEntireAmount = value.onlyEntireAmount

                .exchangeArea = value.exchangeArea

            End With

            AreaCommon.adverts.pathBaseAdvertisement = IO.Path.Combine(AreaCommon.pathBaseDB, "Advertisements")
            AreaCommon.adverts.save(idGUID)

        Catch ex As Exception

        End Try

    End Sub



    ' DELETE api/values/5
    Public Sub deleteValue(ByVal id As String)

        Dim idGUID As Guid

        Try

            Guid.TryParse(id, idGUID)

            With AreaCommon.adverts

                .getData(idGUID).state = APIPrivateMarketEngine.AreaAdvertisement.enumState.deleted

                .pathBaseAdvertisement = IO.Path.Combine(AreaCommon.pathBaseDB, "Advertisements")

                .save(idGUID, False)

                .deleteData(idGUID)

                .save()

            End With

        Catch

        End Try

    End Sub


End Class
