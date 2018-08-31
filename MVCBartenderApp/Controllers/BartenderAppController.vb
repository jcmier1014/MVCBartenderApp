Imports System.Web.Mvc

Namespace Controllers
    Public Class BartenderAppController
        Inherits Controller

        ' GET: BartenderApp
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace