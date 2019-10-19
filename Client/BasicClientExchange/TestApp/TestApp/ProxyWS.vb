Option Explicit On
Option Compare Text


Imports System.Net
Imports Newtonsoft.Json
Imports System.Text







Namespace AreaInternal


    Public Class ProxyWS(Of ClassType As {New})


        Public Data As New ClassType



        Public URL As String






        ''' <summary>
        ''' Questo metodo si occupa di effettuare il download dei dati 
        ''' </summary>
        ''' <returns></returns>
        Public Function GetData() As Boolean

            Try

                Dim request As WebRequest = WebRequest.Create(URL)
                Dim response As WebResponse = request.GetResponse()
                Dim dataStream As IO.Stream = response.GetResponseStream()
                Dim reader As New IO.StreamReader(dataStream)
                Dim responseFromServer As String = reader.ReadToEnd()

                Data = JsonConvert.DeserializeObject(Of ClassType)(responseFromServer)

                reader.Close()
                response.Close()

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Function


        ''' <summary>
        ''' Questo metodo si occupa di inviare dei dati all' URL
        ''' </summary>
        ''' <returns></returns>
        Public Function SendData() As Boolean

            Dim webClient As New WebClient()
            Dim reqString() As Byte

            Try

                reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(Data, Formatting.Indented))

                Dim req As WebRequest = WebRequest.Create(URL)

                req.ContentType = "application/json"
                req.Method = "put"
                req.ContentLength = reqString.Length


                Dim stream = req.GetRequestStream()
                stream.Write(reqString, 0, reqString.Length)
                stream.Close()

                Dim response = req.GetResponse().GetResponseStream()

                Dim reader As New IO.StreamReader(response)
                Dim res = reader.ReadToEnd()
                reader.Close()
                response.Close()

                Return True

            Catch ex As Exception

                Return False

            End Try

        End Function



    End Class


End Namespace