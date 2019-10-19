<div class="jumbotron">
    <h1>API - Private Market</h1>
    @If (ViewBag.environment <> "0") Then
        @<h2>Develop Environment</h2>
    elseIf (ViewBag.environment <> "1") Then
        @<h2>Test Environment</h2>
    elseIf (ViewBag.environment <> "2") Then
        @<h2>Stage Environment</h2>
    End If
    <p Class="lead">by TakeMyTokens</p>
</div>