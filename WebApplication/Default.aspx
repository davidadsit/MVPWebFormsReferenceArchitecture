<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<a href="ProductDetails.aspx?ProductId=5">Show me product 5</a><br />
		<br />
		Login as <a href="Login.aspx?UserId=Blue">Blue</a> <a href="Login.aspx?UserId=Red">Red</a><br />
		<h4>
			<asp:Literal ID="LoggedInLiteral" runat="server"></asp:Literal>
			<a id="LogoutLink" runat="server" href="Login.aspx?UserId=">Logout</a>
		</h4>
	</div>
	</form>
</body>
</html>
