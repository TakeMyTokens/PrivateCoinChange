Namespace AreaCommon


    Public Module ModuleMain

        Public configApplication As New AreaModel.Configuration



        Public Function init() As Boolean

            'Dim serviceFile As New AreaBase._BaseFileDB(Of AreaModel.Configuration)
            Dim serviceFile As New CHCCommonLibrary.CHCEngines.Common.BaseFileDB(Of AreaModel.Configuration)

            serviceFile.fileName = "appConfig.PMBasic"

            If IO.File.Exists(serviceFile.fileName) Then

                If serviceFile.read() Then

                    configApplication = serviceFile.data

                End If

                Return True

            Else

                serviceFile.save()

                Return False

            End If

        End Function


    End Module


End Namespace
