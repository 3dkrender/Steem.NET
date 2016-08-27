Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class CSteemAPI
    Inherits CJson

#Region "Constructors"
    Sub New(strHostname As String, nPort As UShort)
        MyBase.New(strHostname, nPort, "/rpc")
    End Sub

#End Region

#Region "Protected methods"
    Protected Function call_api(strMethod As String) As JObject
        Return JsonConvert.DeserializeObject(SendRequest(strMethod)).Item("result")
    End Function

    Protected Function call_api(strMethod As String, arrParams As ArrayList) As JObject
        Return JsonConvert.DeserializeObject(SendRequest(strMethod, arrParams)).Item("result")
    End Function

    Protected Function call_api_array(strMethod As String, arrParams As ArrayList) As JArray
        Return JsonConvert.DeserializeObject(SendRequest(strMethod, arrParams)).Item("result")
    End Function

    Protected Function call_api_array(strMethod As String) As JArray
        Return JsonConvert.DeserializeObject(SendRequest(strMethod)).Item("result")
    End Function

    Protected Function call_api_value(strMethod As String) As JValue
        Return JsonConvert.DeserializeObject(SendRequest(strMethod)).Item("result")
    End Function

    Protected Function call_api_value(strMethod As String, arrParams As ArrayList) As JValue
        Return JsonConvert.DeserializeObject(SendRequest(strMethod, arrParams)).Item("result")
    End Function

    Protected Function call_api_token(strMethod As String, arrParams As ArrayList) As JToken
        Return JsonConvert.DeserializeObject(SendRequest(strMethod, arrParams)).Item("result")
    End Function

    Protected Function call_api_token(strMethod As String) As JToken
        Return JsonConvert.DeserializeObject(SendRequest(strMethod)).Item("result")
    End Function

#End Region

End Class
