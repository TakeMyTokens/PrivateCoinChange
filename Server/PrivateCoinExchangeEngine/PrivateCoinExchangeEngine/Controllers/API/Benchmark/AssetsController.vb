Imports System.Net
Imports System.Web.Http



Public Class AssetsController

    Inherits ApiController



    ' GET api/Assets
    ''' <summary>
    ''' This method provides to return a complete list of advertisement archive (with or not filters)
    ''' </summary>
    ''' <returns></returns>
    Public Function getValues() As IEnumerable(Of APIPrivateMarketEngine.AreaAdvertisement.AdvertisementsProcessor.AdvertExchangeAsset)

        Dim adapterLog As CHCServerSupport.Support.LogEngine

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            adapterLog.track("AssetsController.getValues", "Begin")

            AreaCommon.counter.increase("AssetsController.getValues", False, adapterLog)

            Return AreaCommon.benchmark.getAssetsCouple(False, adapterLog)

        Catch ex As Exception

            adapterLog.track("AssetsController.getValues", "Error:" & ex.Message, "Fatal")

        Finally

            adapterLog.track("AssetsController.getValues", "Complete")

        End Try

        Return AreaCommon.adverts.data.AsEnumerable

    End Function



End Class