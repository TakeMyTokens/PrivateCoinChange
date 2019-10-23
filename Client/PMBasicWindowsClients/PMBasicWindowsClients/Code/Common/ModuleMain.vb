Namespace AreaCommon


    Module ModuleMain

        Public configApplication As New AreaModel.configuration



        Public Function init() As Boolean

            If IO.File.Exists("appConfig.PMBasic") Then

                Dim serviceFile As New AreaBase.BaseFileDB(Of AreaModel.configuration)

                serviceFile.fileName = "appConfig.PMBasic"

                If serviceFile.read() Then

                    configApplication = serviceFile.data

                End If

                Return True

            Else

                Return False

            End If

        End Function


    End Module


End Namespace
