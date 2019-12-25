Namespace My

    Partial Friend Class MyApplication

        Private WithEvents Domain As AppDomain = AppDomain.CurrentDomain

        Private Function DomainCheck(sender As Object, e As System.ResolveEventArgs) As System.Reflection.Assembly Handles Domain.AssemblyResolve

            If e.Name.Contains("Newtonsoft.Json") Then
                Return System.Reflection.Assembly.Load(My.Resources.AppResources.Newtonsoft_Json)
            ElseIf e.Name.Contains("CHCCommonLibrary") Then
                Return System.Reflection.Assembly.Load(My.Resources.AppResources.CHCCommonLibrary)
            Else
                Return Nothing
            End If
        End Function

        Protected Overrides Function OnInitialize(ByVal commandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)) As Boolean
            Me.MinimumSplashScreenDisplayTime = 3000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function


    End Class


End Namespace