<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prueba.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:TextBox runat="server" ID="cand"></asp:TextBox>
         <asp:TextBox runat="server" ID="ruta"></asp:TextBox>
             <asp:TextBox runat="server" ID="obser"></asp:TextBox>
             <asp:FileUpload runat="server" ID="docu" />
        <asp:Button runat="server" ID="boton" OnClick="boton_Click"/>
    </div>
    </form>
</body>
</html>
