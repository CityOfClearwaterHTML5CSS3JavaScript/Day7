Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class PoliceCall
    Public Property Id As Integer

    <Display(Name:="Incident Number")>
    Public Property IncidentNumber As String

    <Display(Name:="Description ID")>
    Public Property PoliceCallTypeId As Integer

    <Display(Name:="Street Address")>
    Public Property StreetAddress As String

    <Display(Name:="Response Time")>
    <DisplayFormat(DataFormatString:="{0:t}")>
    Public Property ResponseTime As Date

    Public Property CallType As PoliceCallType
End Class
