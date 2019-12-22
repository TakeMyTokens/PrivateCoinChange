Namespace AreaCommon


    Module ModuleMain

        Public configApplication As New AreaModel.configuration



        Public Function init() As Boolean

            Dim serviceFile As New AreaBase.BaseFileDB(Of AreaModel.configuration)

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
