Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Title") = "Home Page"
        ViewData("environment") = areaCommon.environmentPosition

        Return View()
    End Function
End Class
