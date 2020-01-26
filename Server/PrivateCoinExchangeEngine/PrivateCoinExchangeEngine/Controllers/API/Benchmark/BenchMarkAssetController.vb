Imports System.Net
Imports System.Web.Http




Public Class BenchMarkAssetController

    Inherits ApiController


    ' GET api/Assets
    Public Function getValues(ByVal key As String) As APIPrivateMarketEngine.AreaAdvertisement.AdvertisementsProcessor.BenchMarkData

        Dim adapterLog As CHCServerSupport.Support.LogEngine

        Try

            adapterLog = AreaCommon.log.createAccess()

            adapterLog.noSave = Not AreaCommon.settings.logAccessActive

            adapterLog.track("BenchMarkAsset.getValues", "Begin")

            AreaCommon.counter.increase("BenchMarkAsset.getValues",, adapterLog)

            Return AreaCommon.benchMark.getBenchMark(key)

        Catch ex As Exception

            adapterLog.track("BenchMarkAsset.getValues", "Error:" & ex.Message, "Fatal")

        Finally

            adapterLog.track("BenchMarkAsset.getValues", "Complete")

        End Try

        Return New APIPrivateMarketEngine.AreaAdvertisement.AdvertisementsProcessor.BenchMarkData

    End Function


End Class