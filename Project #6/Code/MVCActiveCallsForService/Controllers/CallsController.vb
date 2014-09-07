Imports System.Web.Mvc
Imports System.Data.Entity

Namespace Controllers
    Public Class CallsController
        Inherits Controller

        Private db As New ActiveCallsForServiceContext

        ' GET: Calls
        Function Index() As ActionResult
            ' Before EF
            'Dim model As New List(Of PoliceCall)
            'model.Add(New PoliceCall With {.IncidentNumber = "000000-00001",
            '                                .DescriptionId = 1, .ResponseTime = "12:00 am",
            '                                .StreetAddress = "123 Cleveland St"})
            'model.Add(New PoliceCall With {.IncidentNumber = "000000-00002",
            '                                .DescriptionId = 2, .ResponseTime = "1:00 am",
            '                                .StreetAddress = "456 Gulf to Bay Blvd"})
            'model.Add(New PoliceCall With {.IncidentNumber = "000000-00003",
            '                                .DescriptionId = 3, .ResponseTime = "2:00 am",
            '                                .StreetAddress = "789 Hercules St"})

            ' Before "join"
            'Dim model As List(Of PoliceCall) = db.PoliceCalls.ToList()

            ' Eager load CallType with include
            Dim model As List(Of PoliceCall) = db.PoliceCalls.Include(Function(b) b.CallType).ToList()
            Return View(model)
        End Function

        Function Helpers() As ActionResult
            Dim model As New Helpers With {.Name = "Fred Flintstone", .Age = 35, .Veteran = True,
                  .Interests = New String() {"Beer", "Bowling", "Drive-Ins"}}
            Return View(model)
        End Function

        Function LoadCallTypes() As ActionResult
            Dim model As List(Of PoliceCallType) = db.PoliceCallTypes.ToList()
            Return Content("Yeah!")
        End Function

        Function DataTable() As ActionResult
            Dim model As List(Of PoliceCall) = db.PoliceCalls.Include(Function(b) b.CallType).ToList()
            Return View(model)
        End Function

        Function Map() As ActionResult
            Return View()
        End Function
    End Class
End Namespace