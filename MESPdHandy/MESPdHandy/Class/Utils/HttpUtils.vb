Imports System.Net
Imports System.IO

''' <summary>
''' HTTP Utility
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class HttpUtils

    Private Sub New()
    End Sub


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="url"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetRequest(ByVal url As String) As String

        If String.IsNullOrEmpty(url) Then Return String.Empty

        Dim request As HttpWebRequest = WebRequest.Create(url)
        request.Proxy = Nothing

        Dim result As String = String.Empty

        Using response As HttpWebResponse = request.GetResponse()
            Using stream As Stream = response.GetResponseStream()
                Using reader As New StreamReader(stream)
                    result = reader.ReadToEnd()
                End Using
            End Using
        End Using

        Return result

    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="url"></param>
    ''' <param name="params"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetRequest(ByVal url As String, ByVal params As Dictionary(Of String, Object)) As String

        Dim paramString As New List(Of String)

        For Each key As String In params.Keys
            paramString.Add(String.Format("{0}={1}", key, params(key).ToString()))
        Next

        Return GetRequest(url & "?" & String.Join("&", paramString.ToArray()))

    End Function


    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="StringToEncode"></param>
    ''' <param name="UsePlusRatherThanHexForSpace"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function URLEncode(ByVal StringToEncode As String, Optional ByVal _
   UsePlusRatherThanHexForSpace As Boolean = False) As String

        Dim TempAns As String
        Dim CurChr As Integer
        CurChr = 1
        TempAns = ""
        Do Until CurChr - 1 = Len(StringToEncode)
            Select Case Asc(Mid(StringToEncode, CurChr, 1))
                Case 48 To 57, 65 To 90, 97 To 122
                    TempAns = TempAns & Mid(StringToEncode, CurChr, 1)
                Case 32
                    If UsePlusRatherThanHexForSpace = True Then
                        TempAns = TempAns & "+"
                    Else
                        TempAns = TempAns & "%" & Hex(32)
                    End If
                Case Else
                    'TempAns = TempAns & "%" & Format(Hex(Asc(Mid(StringToEncode, CurChr, 1))), "00")
                    TempAns = TempAns & "%" & Hex(Asc(Mid(StringToEncode, CurChr, 1)))
            End Select

            CurChr = CurChr + 1
        Loop

        URLEncode = TempAns
    End Function



End Class
