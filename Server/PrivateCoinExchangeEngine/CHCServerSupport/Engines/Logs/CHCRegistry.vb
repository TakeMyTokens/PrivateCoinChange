﻿Option Explicit On
Option Compare Text








Namespace Support


    Public Class RegistryEngine

        Inherits CHCCommonLibrary.CHCEngines.Common.BaseFileDB(Of List(Of RegistryData))


        Public Class RegistryData

            Public Enum TypeEvent

                applicationStartUp
                applicationShutdown
                applicationError
                other

            End Enum


            Public istant As DateTime
            Public type As TypeEvent
            Public description As String
            Public fileDetail As String

        End Class

        Private _Path As String = ""
        Private _Day As String = ""



        Public Function addNew(ByVal type As RegistryData.TypeEvent, Optional ByVal description As String = "", Optional ByVal fileDetail As String = "") As Boolean

            Try

                Dim item As New RegistryData

                item.istant = Now
                item.type = type
                item.description = description
                item.fileDetail = fileDetail

                MyBase.data.Add(item)

                MyBase.save()

                Return init()

            Catch ex As Exception

                Return False

            End Try

        End Function



        ''' <summary>
        ''' This method provide to create path into base directory
        ''' and set file name
        ''' </summary>
        ''' <param name="path"></param>
        ''' <returns></returns>
        Public Function init(Optional ByVal path As String = "") As Boolean

            Try

                If (_Day <> Now.ToUniversalTime().ToString("yyyy-MM-dd")) Then

                    _Path = path

                    If Not IO.Directory.Exists(path) Then

                        IO.Directory.CreateDirectory(path)

                    End If

                    path = IO.Path.Combine(path, "Events")

                    If Not IO.Directory.Exists(path) Then

                        IO.Directory.CreateDirectory(path)

                    End If

                    _Day = Now.ToUniversalTime().ToString("yyyy-MM-dd")

                    MyBase.fileName = IO.Path.Combine(path, _Day & ".registry")

                    MyBase.read()

                End If

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Function


    End Class


End Namespace
