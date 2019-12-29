Imports System.Web.Http
Imports System.Web.Optimization

Public Class WebApiApplication
    Inherits System.Web.HttpApplication

    Protected Sub Application_Start()

        AreaRegistration.RegisterAllAreas()
        GlobalConfiguration.Configure(AddressOf WebApiConfig.Register)
        FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
        RouteConfig.RegisterRoutes(RouteTable.Routes)
        BundleConfig.RegisterBundles(BundleTable.Bundles)

        AreaCommon.pathBaseDB = HttpContext.Current.Server.MapPath("~/App_Data")
        AreaCommon.run()

    End Sub

    Protected Sub Application_End()

        AreaCommon.complete()

    End Sub

End Class


