Option Compare Text
Option Explicit On

Imports System.Collections





Namespace areaCommon


    Module moduleMain

        Public Enum enumEnvironmentPosition

            localHost
            testNet
            stage
            production
            demo
            beta

        End Enum

        Public pathBaseDB As String = ""

        Public adverts As New APIPrivateMarketEngine.AreaAdvertisement.advertisements
        Public coinArchive As New APIPrivateMarketEngine.Coins

        Public environmentPosition As enumEnvironmentPosition = enumEnvironmentPosition.localHost





        Public Function Run() As Boolean

            If IO.File.Exists(IO.Path.Combine(pathBaseDB, "SystemConfiguration", "testNet.environment")) Then

                environmentPosition = enumEnvironmentPosition.testNet

            ElseIf IO.File.Exists(IO.Path.Combine(pathBaseDB, "SystemConfiguration", "production.environment")) Then

                environmentPosition = enumEnvironmentPosition.production

            End If

            If coinArchive.Init(pathBaseDB) Then Return adverts.init(pathBaseDB)

            Return False

        End Function




    End Module



End Namespace
