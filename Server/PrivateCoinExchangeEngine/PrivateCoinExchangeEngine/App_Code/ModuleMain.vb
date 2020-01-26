Option Compare Text
Option Explicit On

Imports System.Threading






Namespace AreaCommon


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

        Public adverts As New APIPrivateMarketEngine.AreaAdvertisement.Advertisements
        Public coinArchive As New APIPrivateMarketEngine.AreaCoin.Coins
        Public benchMark As New APIPrivateMarketEngine.AreaAdvertisement.AdvertisementsProcessor
        Public log As New CHCServerSupport.Support.LogEngine
        Public counter As New CHCServerSupport.Support.CounterEngine
        Public settings As New AppSettings

        Public environmentPosition As enumEnvironmentPosition = enumEnvironmentPosition.localHost





        Public Function run() As Boolean

            Try

                log.track("moduleMain.run", "Begin")

                If IO.File.Exists(IO.Path.Combine(pathBaseDB, "System", "TestNet.environment")) Then

                    log.track("moduleMain.run", "Set system as a testNet")

                    environmentPosition = enumEnvironmentPosition.testNet

                ElseIf IO.File.Exists(IO.Path.Combine(pathBaseDB, "System", "Production.environment")) Then

                    log.track("moduleMain.run", "Set system as a Production")

                    environmentPosition = enumEnvironmentPosition.production

                End If

                log.init(IO.Path.Combine(pathBaseDB, "System", "Logs"))
                log.track("moduleMain.run", "before coinArchive.init")

                settings.logAccessActive = True
                settings.logActive = True

                counter.init(IO.Path.Combine(pathBaseDB, "System", "Counters"))

                log.noSave = Not settings.logActive

                If coinArchive.init(pathBaseDB, log) Then

                    log.track("moduleMain.run", "before adverts.init")

                    If adverts.init(pathBaseDB, log) Then

                        log.track("moduleMain.run", "after adverts.init")

                        Return refreshBenchMarkAsynch(log)

                    Else

                        log.track("moduleMain.run", "after failed adverts.init")

                        Return False

                    End If

                End If

                log.track("moduleMain.run", "coinArchive.init failed", "warning")

            Catch ex As Exception

                log.track("moduleMain.run", "Error:" & ex.Message, "fatal")

            Finally

                log.track("moduleMain.run", "Completed")

            End Try

            Return False

        End Function



        Public Sub refreshBenchMark()

            Try

                Dim tmp As New APIPrivateMarketEngine.AreaAdvertisement.AdvertisementsProcessor

                tmp.init(adverts.data)

                benchMark = tmp

            Catch ex As Exception

                log.track("moduleMain.refreshBenchMark", "Error:" & ex.Message, "error")

            End Try

        End Sub



        Public Function refreshBenchMarkAsynch(ByRef adapterLog As CHCServerSupport.Support.LogEngine) As Boolean

            Try

                adapterLog.track("moduleMain.refreshBenchMarkAsynch", "Begin")

                Dim objAsynch As New Thread(AddressOf refreshBenchMark)

                objAsynch.Start()

                Return True

            Catch ex As Exception

                log.track("moduleMain.refreshBenchMarkAsynch", "Error:" & ex.Message, "error")

                Return False

            Finally

                log.track("moduleMain.refreshBenchMarkAsynch", "Completed")

            End Try

        End Function



        Public Function complete() As Boolean

            Try

                log.track("moduleMain.complete", "Begin")

                counter.Save()

            Catch ex As Exception

                log.track("moduleMain.run", "Error:" & ex.Message, "fatal")

            Finally

                log.track("moduleMain.complete", "Completed")

            End Try

            Return False

        End Function



    End Module



End Namespace
