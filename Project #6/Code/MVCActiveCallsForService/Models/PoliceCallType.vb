Imports System.ComponentModel.DataAnnotations

Public Class PoliceCallType
    Public Property Id As Integer

    <Display(Name:="Description")>
    Public Property CallType As String

    Public Overridable Property PoliceCalls As ICollection(Of PoliceCall)

End Class
