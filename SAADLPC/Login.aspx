<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SAADLPC.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="scripts/signin.css" rel="stylesheet" />
    <link href="scripts/bootstrap.min.css" rel="stylesheet" />
    <link href="scripts/StyleSheet.css" rel="stylesheet" />
</head> 
     <body class="text-center">
    <form class="form-signin" runat="server">
      <h1 class="h3 mb-3 font-weight-normal">Please sign in</h1>
      <label for="inputEmail" runat="server" class="sr-only">Email address</label>
     <asp:TextBox ID="inputEmail"  runat="server" class="form-control" placeholder="Email address" required autofocus></asp:TextBox>
      <label for="inputPassword" runat="server" type="email" class="sr-only">Password</label>
     <asp:TextBox ID="inputPassword" runat="server"  type="password" class="form-control" placeholder="Password" required></asp:TextBox>
     
      <div class="checkbox mb-3">
        <label>
          <input type="checkbox" value="remember-me"/> Remember me
        </label>
      </div>
        <div class="checkbox mb-3">
            <asp:Label id="lblerror" runat="server" Text="label error" Visible="false"></asp:Label>
                </div>
        <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" class="btn btn-lg btn-primary btn-block" type="submit"/>
            <p class="mt-5 mb-3 text-muted">&copy; 2017-2018</p>
    </form>
  </body>

</html>