Imports System.Data.Entity

Public Class ActiveCallsForServiceContext
    Inherits DbContext

    Public Sub New()
        'MyBase.New("Data Source=(localdb)\ProjectsV12;Initial Catalog=MyClearwater;Integrated Security=True;")
    End Sub

    Public Property PoliceCallTypes As DbSet(Of PoliceCallType)
    Public Property PoliceCalls As DbSet(Of PoliceCall)
End Class
