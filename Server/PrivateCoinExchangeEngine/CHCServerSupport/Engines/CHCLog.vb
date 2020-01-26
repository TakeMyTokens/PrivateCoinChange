Option Explicit On
Option Compare Text






Namespace Support


    Public Class LogEngine

        Public Class TrackData

            Public istant As String
            Public dateTime As String
            Public messageType As String
            Public position As String
            Public content As String

        End Class


        Private _cache As New List(Of String)

        Private _completeFileName As String
        Private _path As String
        Private _lastInfoTrack As String
        Private _called As Boolean = False


        Public noSave As Boolean = False
        Public useCache As Boolean = True

        Public ReadOnly Property called() As Boolean
            Get
                Return _called
            End Get
        End Property











        Private Sub flushCache()

            Try

                If Not noSave Then

                    Using fileData As IO.StreamWriter = IO.File.AppendText(_completeFileName)

                        For Each strTmp In _cache

                            fileData.WriteLine(strTmp)

                        Next

                    End Using

                End If

            Catch ex As Exception

            End Try

        End Sub



        Public Function init(ByVal basePath As String, Optional ByVal fileName As String = "Main") As Boolean

            Try

                If fileName = "main" Then

                    fileName += "-" & Now.ToUniversalTime().ToString("yyyy-MM-dd") & ".track"

                End If

                _path = basePath
                _completeFileName = IO.Path.Combine(basePath, fileName)

                If Not IO.Directory.Exists(_path) Then

                    IO.Directory.CreateDirectory(_path)

                End If

                If (_cache.Count > 0) Then

                    flushCache()

                End If

                useCache = False

                _cache.Clear()

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Function



        Public Sub track(ByVal position As String, ByVal content As String, Optional ByVal messageType As String = "info")

            Try

                If Not noSave Then

                    _lastInfoTrack = CHCCommonLibrary.CHCEngines.Miscellaneous.timestampFromDateTime() & "|" & CHCCommonLibrary.CHCEngines.Miscellaneous.atMomentGMT() & "|" & messageType & "|" & position & "|" & content

                    If IsNothing(_completeFileName) And useCache Then

                        _cache.Add(_lastInfoTrack)

                        Return

                    End If

                    Using fileData As IO.StreamWriter = IO.File.AppendText(_completeFileName)

                        fileData.WriteLine(_lastInfoTrack)

                    End Using

                End If

            Catch ex As Exception

            End Try

        End Sub



        Public Function getLastTrack() As TrackData

            Dim tmp = _lastInfoTrack.Split("|")
            Dim result As New TrackData

            If (tmp.Count > 0) Then

                result.istant = tmp(0)
                result.dateTime = tmp(1)
                result.messageType = tmp(2)
                result.position = tmp(3)
                result.content = tmp(4)

            End If

            Return result

        End Function



        Public Function createAccess() As LogEngine

            Dim tmp As New LogEngine

            tmp.init(_path, "Access-" & Now.ToUniversalTime().ToString("yyyyMMdd") & "-" & Guid.NewGuid().ToString() & ".track")

            _called = True

            Return tmp

        End Function


    End Class


End Namespace

