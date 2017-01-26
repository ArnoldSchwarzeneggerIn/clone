<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Propuestas.aspx.cs" Inherits="Prueba.Propuestas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <!-- Global stylesheets -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css">
    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css">


    <!-- /global stylesheets -->

    <!-- Core JS files -->
    <script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    <script type="text/javascript" src="assets/js/cespas.js"></script>
    <!-- /core JS files -->

    <!-- Theme JS files -->
    <script type="text/javascript" src="http://code.jquery.com/jquery.js"></script>
    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/jasny_bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/validation/validate.min.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <!--  Content Ventana Modal Propuestas -->
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
                    <h4 class="modal-title" id="myModalLabel">Propuestas</h4>
                </div>
                <div class="modal-body">
                    <asp:ListView ID="Listapropuestas" runat="server">
                        <ItemTemplate>
                            <div class="col-md-12">
                                <div class="thumbnail">
                                    <div class="caption">
                                        <h6 class="text-semibold no-margin-top text-uppercase">
                                            <div class="col-sm-12 text-center">
                                                <h6 class="text-semibold text-right no-margin-top"></h6>
                                                <ul class="list list-unstyled text-center">
                                                    <p>Propuesta # <small class="text-semibold"><%#Eval("PROP_ID")%></small></p>
                                                </ul>
                                            </div>
                                            <div class="modal-body">                                               
                                                <p class="text-center"><%#Eval("PROP_DETALLE")%></p>
                                            </div>
                                        </h6>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:ListView>
                </div>
                <div class="modal-footer">
                    <button type="button"  class="btn btn-default" onclick="proclick()" data-dismiss="modal">Cerrar</button>
                    <button type="button"  class="btn" data-dismiss="modal" OnCommand="Verconvocatoria_Command" CommandArgument='<%#Eval("CODIGO")%>' CommandName="Votar">Votar</button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
