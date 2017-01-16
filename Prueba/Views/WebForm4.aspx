<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="Prueba.Views.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <script runat="server">
    protected void Button1_Click(Object sender, EventArgs e)
    {
        Label1.Text = "Server click handler called.";
    }
</script>

</head>
<body>
    <form id="form1" runat="server">
    <asp:Button ID="Button1" Runat="server" 
      OnClick="Button1_Click" 
        OnClientClick="return confirm('Ready to submit.');" 
        Text="Test Client Click" />
    <br />
    <asp:Label ID="Label1" Runat="server" text="" />
  </form>
</body>
</html>
