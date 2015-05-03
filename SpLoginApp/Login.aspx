<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SpLoginApp.Login" %>

<style>
    .center {
        float: none;
        margin-left: auto;
        margin-right: auto;
    }
</style>


<meta charset="utf-8">
<meta http-equiv="X-UA-Compatible" content="IE=edge">
<meta name="viewport" content="width=device-width, initial-scale=1">
<title>Login Page</title>
<form runat="server">
<div class="container center">
    <div class="col-sm-12 testimonials-title wow fadeIn">
        <h2>User Login</h2>
    </div>
</div>
    <div class="row center">
                <div class="col-md-7 center">
<div class="form-group">
    <div class="input-group">
        <span class="input-group-addon"><i class="glyphicon glyphicon-user"></i></span>
        <asp:textbox id="TextBoxUsername" placeholder="Enter Username" runat="server" class="form-control"></asp:textbox>
    </div>
</div>

<div class="form-group">
    <div class="input-group">
        <span class="input-group-addon"><i class="fa fa-key"></i></span>
        <asp:textbox id="TextBoxPassword" TextMode="Password" placeholder="Enter Password" runat="server" class="form-control"></asp:textbox>
    </div>
</div>

<div class="form-group">
    <div class="input-group">
        <asp:button ID="btnLogin" Text="Login" runat="server" class="btn btn-success" onclick="btnLogin_Click"></asp:button>
        
    </div>
</div>

<div class="form-group">
    <div class="input-group">
        <asp:label id="msg" runat="server"></asp:label>
    </div>
</div>
                    </div>
        </div>
    </form>


        




