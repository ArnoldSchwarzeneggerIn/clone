<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="Prueba.Views.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="ListView1" runat="server">
                <ItemTemplate>
                    <div>
                        <asp:Literal ID="lblForename" Text='<%# Eval("TituloCovocatoria") %>' runat="server" />
                        <asp:Literal ID="lblSurname" Text='<%# Eval("TituloCovocatoria") %>' runat="server" />
                        �
                        <div>
                            <asp:CheckBoxList ID="cblRoles"
                                DataSourceID="odsRole"
                                DataValueField="ID"
                                DataTextField="Name"
                                OnDataBound="cblRoles_OnDataBound"
                                runat="server">
                            </asp:CheckBoxList>
                        </div>
                        �
                        <div>
                            <asp:Button ID="btnSaveRoles"
                                Text="Save Roles"
                                CommandName="SaveRoles"
                                CommandArgument='<%# Container.DataItemIndex %>'
                                runat="server" />
                        </div>
                    </div>
                </ItemTemplate>

            </asp:ListView>

        </div>
    </form>
</body>
</html>
