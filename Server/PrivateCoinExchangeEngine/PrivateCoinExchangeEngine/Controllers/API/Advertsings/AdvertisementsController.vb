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

        Dim adapterLog As CHCServerSupport.Support.LogEngine

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            adapterLog.track("AdvertisementsController.getValues", "Begin")

            AreaCommon.counter.increase("AdvertisementsController.getValues",, adapterLog)

            If Not Active Then

                Return AreaCommon.adverts.getActive(False, adapterLog)

            End If

        Catch ex As Exception

            adapterLog.track("AdvertisementsController.getValues", "Error:" & ex.Message, "Fatal")

        Finally

            adapterLog.track("AdvertisementsController.getValues", "Complete")

        End Try

        Return AreaCommon.adverts.data.AsEnumerable

    End Function

    ' GET api/Advertsings/id
    Public Function getValue(ByVal id As String) As APIPrivateMarketEngine.AreaAdvertisement.advertisement

        Dim idGUID As Guid
        Dim adapterLog As CHCServerSupport.Support.LogEngine

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            adapterLog.track("AdvertisementsController.getValue", "Begin")

            AreaCommon.counter.increase("AdvertisementsController.getValue",, adapterLog)

            Guid.TryParse(id, idGUID)

            Return AreaCommon.adverts.getData(idGUID, False, adapterLog)

        Catch ex As Exception

            adapterLog.track("AdvertisementsController.getValue", "Error:" & ex.Message, "Fatal")

        Finally

            adapterLog.track("AdvertisementsController.getValue", "Complete")

        End Try

        Return New APIPrivateMarketEngine.AreaAdvertisement.Advertisement

    End Function



    ' POST api/Advertsings
    Public Sub postValue(<FromBody()> ByVal value As APIPrivateMarketEngine.AreaAdvertisement.newAdvertisement)

        Dim newElement As APIPrivateMarketEngine.AreaAdvertisement.item
        Dim newAdv As APIPrivateMarketEngine.AreaAdvertisement.advertisement
        Dim adapterLog As CHCServerSupport.Support.LogEngine

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            adapterLog.track("AdvertisementsController.postValue", "Begin")

            AreaCommon.counter.increase("AdvertisementsController.postValue",, adapterLog)

            newAdv = AreaCommon.adverts.add(False, adapterLog)

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

            AreaCommon.adverts.save(newAdv.id, , False, adapterLog)

        Catch ex As Exception

            adapterLog.track("AdvertisementsController.postValue", "Error:" & ex.Message, "Fatal")

        End Try

    End Sub



    ' PUT api/Advertsings/id
    Public Sub putValue(ByVal id As String, <FromBody()> ByVal value As APIPrivateMarketEngine.AreaAdvertisement.updateAdvertisement)

        Dim newElement As APIPrivateMarketEngine.AreaAdvertisement.item
        Dim adapterLog As CHCServerSupport.Support.LogEngine
        Dim idGUID As Guid

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            adapterLog.track("AdvertisementsController.putValue", "Begin")

            AreaCommon.counter.increase("AdvertisementsController.putValue",, adapterLog)

            Guid.TryParse(id, idGUID)

            With AreaCommon.adverts.getData(idGUID, False, adapterLog)

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
            AreaCommon.adverts.save(idGUID,, False, adapterLog)

        Catch ex As Exception

            adapterLog.track("AdvertisementsController.putValue", "Error:" & ex.Message, "Fatal")

        End Try

    End Sub



    ' DELETE api/values/5
    Public Sub deleteValue(ByVal id As String)

        Dim idGUID As Guid
        Dim adapterLog As CHCServerSupport.Support.LogEngine

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            AreaCommon.counter.increase("AdvertisementsController.deleteValue",, adapterLog)

            Guid.TryParse(id, idGUID)

            With AreaCommon.adverts

                .getData(idGUID).state = APIPrivateMarketEngine.AreaAdvertisement.enumState.deleted

                .pathBaseAdvertisement = IO.Path.Combine(AreaCommon.pathBaseDB, "Advertisements")

                .save(idGUID, False, False, adapterLog)

                .deleteData(idGUID, False, adapterLog)

                .save(False, adapterLog)

            End With

        Catch ex As Exception

            adapterLog.track("AdvertisementsController.deleteValue", "Error:" & ex.Message, "Fatal")

        End Try

    End Sub


End Class
