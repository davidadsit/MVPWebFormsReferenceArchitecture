<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductDetails.aspx.cs"
	Inherits="WebApplication.ProductDetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>Product Details</title>
	<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.3/jquery.js" type="text/javascript"></script>
	<script type="text/javascript">//<![CDATA[
		$(function () {
			var url = 'ProductNotes.ashx?ProductId=' + $('.IdLiteral').val();
			alert(url);
			$.get(url, function (data) {
				$('Notes').html(data);
				alert('Load was performed.');
			});
		});
		//]]</script>
</head>
<body>
	<form id="form1" runat="server">
	<div>
		<h2>
			Product Details
		</h2>
		ID:
		<asp:Literal ID="IdLiteral" runat="server"></asp:Literal><br />
		Description:
		<asp:Literal ID="DescriptionLiteral" runat="server"></asp:Literal><br />
		Price:
		<asp:Literal ID="PriceLiteral" runat="server"></asp:Literal><br />
		<div class="Notes" style="display: block;">
		</div>
		<h4>
			<a href="Default.aspx">Home</a>
		</h4>
	</div>
	</form>
</body>
</html>
