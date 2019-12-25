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
    Public Class advertisementEngine

        'Inherits AreaBase.BaseFileDB(Of advertisement)
        Inherits CHCCommonLibrary.CHCEngines.Common.BaseFileDB(Of advertisement)



        ''' <summary>
        ''' This method provide to create path into base directory
        ''' and set file name
        ''' </summary>
        ''' <param name="path"></param>
        ''' <returns></returns>
        Public Function createIntoFilePath(ByVal path As String) As Boolean

            Try

                path = IO.Path.Combine(path, data.id.ToString())

                If Not IO.Directory.Exists(path) Then

                    IO.Directory.CreateDirectory(path)

                End If

                MyBase.fileName = IO.Path.Combine(path, "adv-" & data.dateUpdate.ToUniversalTime.ToFileTimeUtc & ".revision")

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Function



    End Class



    ''' <summary>
    ''' This class contain all data and method to manage a list of advertisement
    ''' </summary>
    Public Class advertisements

        'Inherits AreaBase.BaseFileDB(Of List(Of advertisement))
        Inherits CHCCommonLibrary.CHCEngines.Common.BaseFileDB(Of List(Of advertisement))

        Private _KeyAdverts As New Dictionary(Of Guid, advertisement)


        Public pathBaseAdvertisement As String






        ''' <summary>
        ''' This method provide to rebuild a complete list
        ''' </summary>
        ''' <returns></returns>
        Private Function rebuidIndex() As Boolean

            Try

                _KeyAdverts = New Dictionary(Of Guid, advertisement)

                For Each item In data

                    _KeyAdverts.Add(item.id, item)

                Next

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Function



        ''' <summary>
        ''' This methdo provide a get an active element of a list
        ''' </summary>
        ''' <returns></returns>
        Public Function getActive() As List(Of advertisement)

            Dim result As New List(Of advertisement)

            Try

                For Each item In data

                    If (item.state = enumState.visible) And
                       (item.dateAdvertisementStart >= Now) And (item.dateAdvertisementEnd <= Now) Then

                        result.Add(item)

                    End If

                Next

            Catch ex As Exception

            End Try

            Return result

        End Function



        ''' <summary>
        ''' This method provide to save an history of data and update the list
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Overloads Function save(ByVal id As Guid, Optional ByVal saveList As Boolean = True) As Boolean

            Dim advEngine As New advertisementEngine

            Try

                If _KeyAdverts.ContainsKey(id) Then

                    advEngine.data = _KeyAdverts.Item(id)

                    advEngine.data.dateUpdate = Now.ToUniversalTime()

                    advEngine.createIntoFilePath(pathBaseAdvertisement)

                    advEngine.save()

                    If saveList Then

                        MyBase.save()

                    End If

                    Return True

                End If

            Catch ex As Exception
            End Try

            Return False

        End Function



        ''' <summary>
        ''' This method provide to add a new record into list and mange the history
        ''' </summary>
        ''' <returns></returns>
        Public Function add() As advertisement

            Dim newElement As New advertisement

            Try

                newElement.id = Guid.NewGuid

                MyBase.data.Add(newElement)

                _KeyAdverts.Add(newElement.id, newElement)

            Catch ex As Exception

            End Try

            Return newElement

        End Function



        ''' <summary>
        ''' This method provide to delete data into list and into key.
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function deleteData(ByVal id As Guid) As Boolean

            Try

                For Each item In data

                    If (item.id.CompareTo(id) = 0) Then

                        data.Remove(item)
                        _KeyAdverts.Remove(id)

                        Return True

                    End If

                Next

            Catch ex As Exception

            End Try

            Return False

        End Function



        ''' <summary>
        ''' This method provide to check into list the exact key
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function containsKey(ByVal id As Guid) As Boolean

            Try

                Return _KeyAdverts.ContainsKey(id)

            Catch ex As Exception

            End Try

            Return False

        End Function



        ''' <summary>
        ''' This method provide to get an item of a list
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        Public Function getData(ByVal id As Guid) As advertisement

            Try

                If _KeyAdverts.ContainsKey(id) Then

                    Return _KeyAdverts.Item(id)

                End If

            Catch ex As Exception

            End Try

            Return New advertisement

        End Function



        ''' <summary>
        ''' This method provide to execute an init code
        ''' </summary>
        ''' <param name="PathBaseDB"></param>
        ''' <returns></returns>
        Public Function init(ByVal PathBaseDB As String) As Boolean

            Try

                Dim strAdvertsing As String = IO.Path.Combine(PathBaseDB, "Advertisements")

                If Not IO.Directory.Exists(strAdvertsing) Then

                    IO.Directory.CreateDirectory(strAdvertsing)

                    pathBaseAdvertisement = strAdvertsing

                End If

                MyBase.fileName = IO.Path.Combine(strAdvertsing, "CurrentList.adverts")

                If MyBase.read() Then

                    rebuidIndex()

                    Return True

                End If

            Catch ex As Exception

            End Try

            Return False

        End Function



    End Class



End Namespace