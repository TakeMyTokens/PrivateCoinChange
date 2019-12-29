Option Compare Text
Option Explicit On






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

        Public adverts As New APIPrivateMarketEngine.AreaAdvertisement.advertisements
        Public coinArchive As New APIPrivateMarketEngine.Coins
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

                    log.track("moduleMain.run", "Set system as a testNet")

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

                    Return adverts.init(pathBaseDB, log)

                End If

                log.track("moduleMain.run", "coinArchive.init failed", "warning")

            Catch ex As Exception

                log.track("moduleMain.run", "Error:" & ex.Message, "fatal")

            Finally

                log.track("moduleMain.run", "Completed")

            End Try

            Return False

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
