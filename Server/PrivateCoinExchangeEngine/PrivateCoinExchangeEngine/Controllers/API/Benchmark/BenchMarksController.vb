Imports System.Net
Imports System.Web.Http





Public Class BenchMarksController

    Inherits ApiController


    ' GET api/Assets
    Public Function getValues() As IEnumerable(Of APIPrivateMarketEngine.AreaAdvertisement.AdvertisementsProcessor.BenchMarkData)

        Dim adapterLog As CHCServerSupport.Support.LogEngine

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            adapterLog.track("RatingController.getValues", "Begin")

            AreaCommon.counter.increase("RatingController.getValues",, adapterLog)

            Return AreaCommon.benchMark.data

        Catch ex As Exception

            adapterLog.track("RatingController.getValues", "Error:" & ex.Message, "Fatal")

        Finally

            adapterLog.track("RatingController.getValues", "Complete")

        End Try

        Return AreaCommon.adverts.data.AsEnumerable

    End Function


End Class


