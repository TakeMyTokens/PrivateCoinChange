Option Compare Text
Option Explicit On


Namespace AreaAdvertisement


    Public Enum enumState

        notVisible
        visible
        deleted
        closed

    End Enum


    ''' <summary>
    ''' This class contain the Item data
    ''' </summary>
    Public Class item

        Public Enum enumType

            currency
            other

        End Enum

        Public amount As Decimal = 1
        Public type As enumType = enumType.currency
        Public description As String = ""

    End Class



    ''' <summary>
    ''' This class is a base of Advertisement
    ''' </summary>
    Public Class baseAdvertisement

        Public id As Guid

        Public dateAdvertisementStart As DateTime = DateTime.MinValue
        Public dateAdvertisementEnd As DateTime = DateTime.MinValue

        Public offeredItems As New List(Of item)
        Public requestedItems As New List(Of item)

        Public acceptOtherItems As Boolean = False
        Public negotiable As Boolean = False
        Public onlyEntireAmount As Boolean = False

        Public exchangeArea As String = ""

    End Class



    ''' <summary>
    ''' This class contain the information reguard a New Advert data
    ''' </summary>
    Public Class newAdvertisement

        Inherits baseAdvertisement

        Public walletID As String = ""
        Public signature As String = ""

        Public visible As Boolean = False

    End Class



    ''' <summary>
    ''' This class contain the information reguard an Edit Advert data
    ''' </summary>
    Public Class updateAdvertisement

        Inherits baseAdvertisement

        Public signature As String = ""

        Public state As enumState

    End Class



    ''' <summary>
    ''' This class contain the information reguard the advertisement
    ''' </summary>
    Public Class advertisement

        Inherits baseAdvertisement

        Public dateUpdate As DateTime = DateTime.MinValue

        Public walletID As String = ""

        Public state As enumState = enumState.visible

        Public currentNumberQueue As Integer = 0

    End Class



    ''' <summary>
    ''' This class contain all member to manage a single advertisement
    ''' </summary>
    Public Class AdvertisementEngine

        Inherits CHCCommonLibrary.CHCEngines.Common.BaseFileDB(Of advertisement)

        Private _logEngine As CHCServerSupport.Support.LogEngine






        Private Sub trackLog(ByVal position As String, ByVal content As String, Optional ByVal messageType As String = "info")

            If Not IsNothing(_logEngine) Then

                _logEngine.track(position, content, messageType)

            End If

        End Sub



        ''' <summary>
        ''' This method provide to create path into base directory
        ''' and set file name
        ''' </summary>
        ''' <param name="path"></param>
        ''' <returns></returns>
        Public Function createIntoFilePath(ByVal path As String) As Boolean

            Try

                trackLog("AdvertisementEngine.createIntoFilePath", "Begin")

                path = IO.Path.Combine(path, data.id.ToString())

                trackLog("AdvertisementEngine.createIntoFilePath", "Set path = " & path)

                If Not IO.Directory.Exists(path) Then

                    trackLog("AdvertisementEngine.createIntoFilePath", "file not exist")

                    IO.Directory.CreateDirectory(path)

                    trackLog("AdvertisementEngine.createIntoFilePath", "Directory created")

                End If

                MyBase.fileName = IO.Path.Combine(path, "adv-" & data.dateUpdate.ToUniversalTime.ToFileTimeUtc & ".revision")

                trackLog("AdvertisementEngine.createIntoFilePath", "Set fileName = " & MyBase.fileName)

                Return True

            Catch ex As Exception

                trackLog("AdvertisementEngine.createIntoFilePath", "Error:" & ex.Message, "Fatal")

                Return False

            End Try

        End Function



    End Class



    ''' <summary>
    ''' This class contain all data and method to manage a list of advertisement
    ''' </summary>
    Public Class Advertisements

        'Inherits AreaBase.BaseFileDB(Of List(Of advertisement))
        Inherits CHCCommonLibrary.CHCEngines.Common.BaseFileDB(Of List(Of advertisement))

        Private _keyAdverts As New Dictionary(Of Guid, advertisement)

        Private _logEngine As CHCServerSupport.Support.LogEngine


        Public pathBaseAdvertisement As String





        Private Sub trackLog(ByVal position As String, ByVal content As String, Optional ByVal messageType As String = "info", Optional ByVal adapterLog As CHCServerSupport.Support.LogEngine = Nothing)

            If Not IsNothing(adapterLog) Then

                adapterLog.track(position, content, messageType)

            ElseIf Not IsNothing(_logEngine) Then

                _logEngine.track(position, content, messageType)

            End If

        End Sub



        ''' <summary>
        ''' This method provide to rebuild a complete list
        ''' </summary>
        ''' <returns></returns>
        Private Function rebuildIndex() As Boolean

            Try

                trackLog("Advertisements.rebuildIndex", "Begin")

                _keyAdverts = New Dictionary(Of Guid, advertisement)

                trackLog("Advertisements.rebuildIndex", "new Dictionary")

                For Each item In data

                    _keyAdverts.Add(item.id, item)

                Next

                trackLog("Advertisements.rebuildIndex", "For...each completed")

                Return True

            Catch ex As Exception

                trackLog("Advertisements.rebuidIndex", "Error:" & ex.Message, "Fatal")

                Return False

            End Try

        End Function



        ''' <summary>
        ''' This methdo provide a get an active element of a list
        ''' </summary>
        ''' <returns></returns>
        Public Function getActive(Optional ByVal useLogEngineAccess As Boolean = False, Optional adapterLog As CHCServerSupport.Support.LogEngine = Nothing) As List(Of advertisement)

            If useLogEngineAccess Then

                adapterLog = _logEngine.createAccess()

            End If

            trackLog("Advertisements.getActive", "Begin", , adapterLog)

            Dim result As New List(Of advertisement)

            trackLog("Advertisements.getActive", "Set New List",, adapterLog)

            Try

                For Each item In data

                    If (item.state = enumState.visible) And
                       (item.dateAdvertisementStart >= Now) And (item.dateAdvertisementEnd <= Now) Then

                        result.Add(item)

                    End If

                Next

                trackLog("Advertisements.getActive", "For...each completed",, adapterLog)

            Catch ex As Exception

                trackLog("Advertisements.getActive", "Error:" & ex.Message, "Fatal", adapterLog)

            End Try

            Return result

        End Function



        ''' <summary>
        ''' This method provide to save an history of data and update the list
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Overloads Function save(ByVal id As Guid, Optional ByVal saveList As Boolean = True, Optional ByVal useLogEngineAccess As Boolean = False, Optional adapterLog As CHCServerSupport.Support.LogEngine = Nothing) As Boolean

            If useLogEngineAccess Then

                adapterLog = _logEngine.createAccess()

            End If

            trackLog("Advertisements.save", "Enter with id=" & id.ToString(),, adapterLog)

            Dim advEngine As New AdvertisementEngine

            trackLog("Advertisements.save", "new AdvertisementEngine",, adapterLog)

            Try

                If _keyAdverts.ContainsKey(id) Then

                    trackLog("Advertisements.save", "ContainsKey",, adapterLog)

                    advEngine.data = _keyAdverts.Item(id)

                    trackLog("Advertisements.save", "Before set data",, adapterLog)

                    advEngine.data.dateUpdate = Now.ToUniversalTime()

                    trackLog("Advertisements.save", "Before createIntoFilePath = " & pathBaseAdvertisement,, adapterLog)

                    advEngine.createIntoFilePath(pathBaseAdvertisement)

                    trackLog("Advertisements.save", "Before advEngine.save",, adapterLog)

                    advEngine.save()

                    trackLog("Advertisements.save", "After advEngine.save",, adapterLog)

                    If saveList Then

                        trackLog("Advertisements.save", "Before MyBase.save",, adapterLog)

                        MyBase.save()

                        trackLog("Advertisements.save", "After MyBase.save",, adapterLog)

                    End If

                    trackLog("Advertisements.save", "Return true",, adapterLog)

                    Return True

                End If

            Catch ex As Exception

                trackLog("Advertisements.save", "Error:" & ex.Message, "Fatal", adapterLog)

            End Try

            trackLog("Advertisements.save", "Return false",, adapterLog)

            Return False

        End Function



        ''' <summary>
        ''' This method provide to save an history of data and update the list
        ''' </summary>
        ''' <returns></returns>
        Public Overloads Function save(Optional ByVal useLogEngineAccess As Boolean = False, Optional adapterLog As CHCServerSupport.Support.LogEngine = Nothing) As Boolean

            If useLogEngineAccess Then

                adapterLog = _logEngine.createAccess()

            End If

            trackLog("Advertisements.save", "Begin")

            Return MyBase.save()

        End Function



        ''' <summary>
        ''' This method provide to add a new record into list and mange the history
        ''' </summary>
        ''' <returns></returns>
        Public Function add(Optional ByVal createLogEngineAccess As Boolean = False, Optional adapterLog As CHCServerSupport.Support.LogEngine = Nothing) As advertisement

            If createLogEngineAccess Then

                adapterLog = _logEngine.createAccess()

            End If

            trackLog("Advertisements.add", "Begin", , adapterLog)

            Dim newElement As New advertisement

            trackLog("Advertisements.add", "new advertisement", , adapterLog)

            Try

                newElement.id = Guid.NewGuid

                trackLog("Advertisements.add", "Set id = " & newElement.id.ToString(),, adapterLog)

                MyBase.data.Add(newElement)

                trackLog("Advertisements.add", "Before add",, adapterLog)

                _keyAdverts.Add(newElement.id, newElement)

                trackLog("Advertisements.add", "After add",, adapterLog)

            Catch ex As Exception

                trackLog("Advertisements.add", "Error:" & ex.Message, "Fatal", adapterLog)

            End Try

            Return newElement

        End Function



        ''' <summary>
        ''' This method provide to delete data into list and into key.
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function deleteData(ByVal id As Guid, Optional ByVal createLogEngineAccess As Boolean = False, Optional adapterLog As CHCServerSupport.Support.LogEngine = Nothing) As Boolean

            If createLogEngineAccess Then

                adapterLog = _logEngine.createAccess()

            End If

            trackLog("Advertisements.deleteData", "Begin",, adapterLog)

            Try

                For Each item In data

                    If (item.id.CompareTo(id) = 0) Then

                        trackLog("Advertisements.deleteData", "Data found",, adapterLog)

                        data.Remove(item)
                        _keyAdverts.Remove(id)

                        trackLog("Advertisements.deleteData", "Data removed",, adapterLog)

                        Return True

                    End If

                Next

                trackLog("Advertisements.deleteData", "For...each completed",, adapterLog)

            Catch ex As Exception

                trackLog("Advertisements.deleteData", "Error:" & ex.Message, "Fatal", adapterLog)

            End Try

            Return False

        End Function



        ''' <summary>
        ''' This method provide to check into list the exact key
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function containsKey(ByVal id As Guid) As Boolean

            trackLog("Advertisements.containsKey", "Begin")

            Try

                Return _KeyAdverts.ContainsKey(id)

            Catch ex As Exception

                trackLog("Advertisements.containsKey", "Error:" & ex.Message, "Fatal")

            End Try

            Return False

        End Function



        ''' <summary>
        ''' This method provide to get an item of a list
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function getData(ByVal id As Guid, Optional ByVal useLogEngineAccess As Boolean = False, Optional adapterLog As CHCServerSupport.Support.LogEngine = Nothing) As advertisement

            If useLogEngineAccess Then

                adapterLog = _logEngine.createAccess()

            End If

            trackLog("Advertisements.getData", "Begin",, adapterLog)

            Try

                If _keyAdverts.ContainsKey(id) Then

                    trackLog("Advertisements.getData", "ContainsKey",, adapterLog)

                    Return _keyAdverts.Item(id)

                End If

            Catch ex As Exception

                trackLog("Advertisements.getData", "Error:" & ex.Message, "Fatal", adapterLog)

            End Try

            Return New advertisement

        End Function



        ''' <summary>
        ''' This method provide to execute an init code
        ''' </summary>
        ''' <param name="PathBaseDB"></param>
        ''' <returns></returns>
        Public Function init(ByVal PathBaseDB As String, Optional ByVal logAdapter As CHCServerSupport.Support.LogEngine = Nothing) As Boolean

            Try

                _logEngine = logAdapter

                trackLog("Advertisements.init", "Begin")

                Dim advertsing As String = IO.Path.Combine(PathBaseDB, "Advertisements")

                trackLog("Advertisements.init", "advertsing = " & advertsing)

                If Not IO.Directory.Exists(advertsing) Then

                    trackLog("Advertisements.init", "Exist")

                    IO.Directory.CreateDirectory(advertsing)

                    trackLog("Advertisements.init", "CreateDirectory OK")

                    pathBaseAdvertisement = advertsing

                End If

                MyBase.fileName = IO.Path.Combine(advertsing, "CurrentList.adverts")

                trackLog("Advertisements.init", "Set fileName = " & MyBase.fileName)

                If MyBase.read() Then

                    trackLog("Advertisements.init", "read completed")

                    rebuildIndex()

                    trackLog("Advertisements.init", "rebuildIndex completed")

                    Return True

                End If

            Catch ex As Exception

                trackLog("Advertisements.init", "Error:" & ex.Message, "Fatal")

            End Try

            Return False

        End Function



    End Class



End Namespace