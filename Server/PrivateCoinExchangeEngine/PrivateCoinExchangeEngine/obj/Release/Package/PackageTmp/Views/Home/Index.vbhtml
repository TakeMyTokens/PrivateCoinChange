<div class="jumbotron">
    <h1>API - Private Market</h1>
    @If (ViewBag.environment = "0") Then
        @<h2>Local Environment</h2>
    elseIf (ViewBag.environment = "1") Then
        @<h2>Test Environment</h2>
    elseIf (ViewBag.environment = "2") Then
        @<h2>Stage Environment</h2>
    elseIf (ViewBag.environment = "3") Then
        @<h2>User Environment</h2>
    End If
    <p Class="lead">by TakeMyTokens</p>
</div>