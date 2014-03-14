<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="IMSReportGenerator.Pages.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>IMS Report Generator</title>
</head>
<body>
    <form runat="server"></form>
    <div id="loginContainer" class="container text-center mtxl">
        <ul class="nav nav-tabs">
            <li class="active"><a id="loginNav" href="#">Login</a></li>
            <li><a id="registerNav" href="#">Register</a></li>
        </ul>
        <form id="signInForm" class="form-signin" role="form">
            <h2 class="form-signin-heading">Please sign in</h2>
            <input type="email" class="form-control" placeholder="Email address">
            <input type="password" class="form-control" placeholder="Password">
            <label class="checkbox">
                <input type="checkbox" value="remember-me">
                Remember me
            </label>
            <button id="btnSignIn" class="btn btn-lg btn-success btn-block" type="submit">Sign in</button>
            <br />
        </form>
        <form id="registerForm" class="form-signin hidden" role="form">
            <h2 class="form-signin-heading">Register</h2>
            <input type="email" class="form-control" placeholder="Email address">
            <input type="password" class="form-control" placeholder="Password">
            <input type="password" class="form-control" placeholder="Retype Password">
            <label class="checkbox">
                <input type="checkbox" value="remember-me">
                Remember me
            </label>
            <button id="btnRegister" class="btn btn-lg btn-success btn-block" type="submit">Register</button>
        </form>
    </div>
</body>
</html>
