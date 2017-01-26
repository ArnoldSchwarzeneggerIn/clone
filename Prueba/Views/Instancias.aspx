<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instancias.aspx.cs" Inherits="Prueba.views.Instancias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Sistema Electoral</title>

    <%--<!-- Global stylesheets -->
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
    <!-- /core JS files -->

    <!-- Theme JS files -->

    <%--    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/components_navs.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>--%>
    <!-- /theme JS files -->


    <!-- Theme JS files -->
    <%-- <script type="text/javascript" src="assets/js/plugins/tables/datatables/datatables.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/selects/select2.min.js"></script>--%>

    <%--<script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/datatables_data_sources.js"></script>--%>
    <!-- /theme JS files -->

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
	<!-- /core JS files -->

	<!-- Theme JS files -->
	<script type="text/javascript" src="assets/js/plugins/tables/datatables/datatables.min.js"></script>
	<script type="text/javascript" src="assets/js/plugins/forms/selects/select2.min.js"></script>

	<script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/datatables_data_sources.js"></script>
	<%--<script type="text/javascript" src="assets/js/pages/datatables_api.js"></script>--%>
    <!-- /theme JS files -->


    <script>


        function rinsd() {
            var x = document.getElementById('rinsd');
            x.click();
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <a id="rinsd" data-toggle="modal" href="#modal_form_vertical"></a>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <!-- Main navbar -->
        <div class="navbar navbar-inverse">
            <div class="navbar-header">
                <a class="navbar-brand" href="index.aspx">
                    <img src="assets/images/si.png" style="width: 11em; height: 1.5em;">
                </a>

                <ul class="nav navbar-nav visible-xs-block">
                    <li><a data-toggle="collapse" data-target="#navbar-mobile"><i class="icon-tree5"></i></a></li>
                    <li><a class="sidebar-mobile-main-toggle"><i class="icon-paragraph-justify3"></i></a></li>
                </ul>
            </div>

            <div class="navbar-collapse collapse" id="navbar-mobile">
                <ul class="nav navbar-nav">
                    <li><a class="sidebar-control sidebar-main-toggle hidden-xs"><i class="icon-paragraph-justify3"></i></a></li>
                </ul>

                <ul class="nav navbar-nav navbar-right">
                    <li class="dropdown dropdown-user">
                        <a class="dropdown-toggle" data-toggle="dropdown">
                            <img src="assets/images/placeholder.jpg" alt="" runat="server" id="imagen_Perfil">
                            <span>
                                <asp:Label ID="Nombre1" runat="server" Text="Label"></asp:Label>
                            </span>
                            <i class="caret"></i>
                        </a>

                        <ul class="dropdown-menu dropdown-menu-right">
                            <li>
                                <asp:LinkButton ID="Salir" runat="server" OnClick="Salir_Click"> <i class="icon-switch2"></i>  Salir </asp:LinkButton>
                            </li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <!-- /main navbar -->

        <div class="page-container">

            <!-- Page content -->
            <div class="page-content">

                <!-- Main sidebar -->
                <div class="sidebar sidebar-main">
                    <div class="sidebar-content">

                        <!-- User menu -->
                        <div class="sidebar-user">
                            <div class="category-content">
                                <div class="media">
                                    <a href="#" class="media-left">
                                        <img src="" class="img-circle img-sm" alt="" runat="server" id="Imagen_perfil2"></a>
                                    <div class="media-body">
                                        <span class="media-heading text-semibold">
                                            <asp:Label ID="Nombre2" runat="server" Text="Label"></asp:Label>
                                        </span>
                                        <div class="text-size-mini text-muted">
                                            <i class="icon-pin text-size-small">
                                                <asp:Label ID="Ubicacion" runat="server" Text="Label"></asp:Label>
                                            </i>
                                        </div>
                                    </div>

                                    <div class="media-right media-middle">
                                        <ul class="icons-list">
                                            <li>
                                                <a href="#"><i class="icon-cog3"></i></a>
                                            </li>
                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <!-- /user menu -->


                        <!-- Main navigation -->
                        <div class="sidebar-category sidebar-category-visible">
                            <div class="category-content no-padding">
                                <ul class="navigation navigation-main navigation-accordion">

                                    <!-- Main -->
                                    <li class="navigation-header"><span>Convocatorias</span> <i class="icon-menu" title="Convocatorias"></i></li>
                                    <li><a href="Index.aspx"><i class="icon-home4"></i><span>Principal</span></a></li>
                                    <li>
                                        <a href="#"><i class="icon-stack2"></i><span>Convocatorias</span></a>
                                        <ul>
                                            <li><a href="VConvocatoria.aspx">Gestionar convocatoria</a></li>
                                            <li><a href="#">Lanzar convocatoria</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#"><i class="icon-vcard"></i><span>Candidatos</span></a>
                                        <ul>
                                            <li><a href="VCandidato.aspx">Gestionar candidatos</a></li>
                                            <li><a href="#">Mi candidatura</a></li>
                                        </ul>
                                    </li>
                                    <li class="active">
                                        <a href="#"><i class="icon-puzzle"></i><span>Parametricas</span></a>
                                        <ul>
                                            <li><a href="VCobertura.aspx">Cobertura</a></li>
                                            <li><a href="Causaderetiro.aspx">Causa de retiro</a></li>
                                            <li class="active"><a href="Instancias.aspx">Instancias</a></li>
                                            <li><a href="InstancConformacion.aspx">Instancia conformacion</a></li>
                                        </ul>
                                    </li>
                                    <li>
                                        <a href="#"><i class="icon-stack-text"></i><span>Votaciones</span></a>
                                        <ul>
                                            <li><a href="Votar.aspx">Votar</a></li>
                                            <li><a href="#">Resultados</a></li>
                                        </ul>
                                    </li>

                                </ul>
                            </div>
                        </div>
                        <!-- /main navigation -->

                    </div>
                </div>
                <!-- /main sidebar -->


                <!-- Main content -->
                <div class="content-wrapper">
                    <div class="page-header">
                        <div class="breadcrumb-line">
                            <ul class="breadcrumb">
                                <li><a href="Index.aspx"><i class="icon-home2 position-left"></i>Index/Instancia</a></li>
                            </ul>
                            <ul class="breadcrumb-elements">
                                <li><a data-toggle="modal" href="#Agregar_instancia"><i class="icon-add-to-list position-left"></i>Agregar Instancia</a></li>
                            </ul>



                        </div>
                    </div>
                    <!-- /page header -->


                    <!-- Content area -->
                    <div class="content">

                        <div class="panel panel-flat">
                            <div class="panel-heading">
                                <h5 class="panel-title">Lista de instancias</h5>
                                <div class="heading-elements">
                                    <ul class="icons-list">
                                        <li><a data-action="collapse"></a></li>
                                        <li><a data-action="reload"></a></li>
                                        <li><a data-action="close"></a></li>
                                    </ul>
                                </div>
                                <div class="heading-elements visible">
                                    <span class="label bg-success heading-text"><span id="NumeroR">12</span>  Registros</span>
                                    <ul class="icons-list">
                                        <li><a data-toggle="modal" href="#modal_form_vertical2" title="Agregar"><i class="icon-add"></i></a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="panel-body">
                                Instancias conformadas en la Universidad de la Amazonia
                            </div>

                            <table class="table datatable-html">
                                <thead>
                                    <tr role="row">
                                        <th>Nombre instancia</th>
                                        <th>Cobertura</th>
                                        <th>Estado</th>
                                        <th style="width: 200px;">Acciones</th>
                                    </tr>
                                </thead>
                              <%--  <tfoot>
                                    <tr role="row">
                                        <th>Nombre instancia</th>
                                        <th>Cobertura</th>
                                        <th>Estado</th>
                                        <th style="width: 200px;">Acciones</th>
                                    </tr>
                                </tfoot>--%>
                                <tbody>
                                    <asp:ListView ID="Instancialista" runat="server" OnItemEditing="Instancialista_ItemEditing" DataKeyNames="IdInstancia" OnItemCanceling="Instancialista_ItemCanceling" OnItemUpdating="Instancialista_ItemUpdating" OnItemCommand="Instancialista_ItemCommand">
                                        <ItemTemplate>
                                            <tr>
                                                <td>
                                                    <asp:LinkButton ID="LinkButton1" runat="server" CommandArgument='<%#Eval("IdInstancia") %>' Text='<%#Eval("NombreInstancia")%>' CommandName="ver"></asp:LinkButton>
                                                </td>
                                                <td>
                                                    <asp:Label runat="server" ID="coberturaid" class="text-semibold" Text='<%#Eval("IdCobertura")%>'> </asp:Label>
                                                </td>
                                                <td>
                                                    <span class='<%#(Eval("ESTADOINSTANCIA").ToString()=="ACTIVO")?"label label-success":"label label-default"%>'>
                                                        <asp:Label class="" data-toggle="dropdown" ID="Estadolabel" runat="server" Text='<%#Eval("ESTADOINSTANCIA")%>'></asp:Label>
                                                    </span>

                                                </td>
                                                <td class="text-center">
                                                    <ul class="icons-list">
                                                        <li>
                                                            <asp:LinkButton ID="Agregarcargo" runat="server" CommandArgument='<%#Eval("IdInstancia")%>' data-popup="tooltip" title data-original-title="Editar" CommandName="Edit"> <i class="icon-pencil7" title="Agregar cargo"></i></asp:LinkButton>
                                                        </li>
                                                        <li>
                                                            <asp:LinkButton ID="LinkButton2" runat="server" CommandArgument='<%#Eval("IdInstancia")%>' data-popup="tooltip" title data-original-title="Configurar" OnCommand="LinkButton2_Command"> <i class="icon-cog7" title="Agregar cargo"></i></asp:LinkButton>


                                                        </li>
                                                    </ul>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                        <EditItemTemplate>
                                            <tr>
                                                <td>
                                                    <asp:TextBox ID="nombre" CssClass="form-control" runat="server"></asp:TextBox>
                                                </td>

                                                <td>
                                                    <asp:DropDownList ID="COberItem" runat="server" CssClass="form-control">
                                                    </asp:DropDownList>
                                                </td>
                                                <td>
                                                    <span class='<%#(Eval("ESTADOINSTANCIA").ToString()=="ACTIVO")?"label label-success":"label label-default"%>'>
                                                        <asp:DropDownList ID="EstadoInst" runat="server" CssClass="form-control">
                                                            <asp:ListItem Value=""> Seleccione</asp:ListItem>
                                                            <asp:ListItem Value="ACTIVO"> ACTIVO</asp:ListItem>
                                                            <asp:ListItem Value="INACTIVO">INACTIVO </asp:ListItem>
                                                        </asp:DropDownList>
                                                    </span>

                                                </td>
                                                <td class="text-center">
                                                    <ul class="icons-list">
                                                        <li>
                                                            <asp:LinkButton ID="Actualizar" runat="server" Text="Actualizar" CommandName="Update" title data-original-title="Guardar">
                                                                            <i class="icon-floppy-disk"  ></i>
                                                            </asp:LinkButton>
                                                        </li>
                                                        <li>
                                                            <asp:LinkButton ID="Cancelar" runat="server" Text="Cancelar" CommandName="Cancel" title data-original-title="Cancelar">
                                                                          <i class="icon-cancel-square" ></i>
                                                            </asp:LinkButton>
                                                        </li>
                                                    </ul>
                                                </td>
                                            </tr>
                                        </EditItemTemplate>
                                    </asp:ListView>
                                </tbody>
                            </table>
                        </div>



                        <div class="row">
                        </div>
                        <!-- Footer -->
                        <div class="footer text-muted">
                            &copy; 2016. <a href="#">Sistema electoral</a> by <a href="#" target="_blank">Giecom</a>
                        </div>
                        <!-- /footer -->

                        <div id="modal_form_vertical" class="modal fade ">
                            <div class="modal-dialog modal-lg">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal" onclick="limpiar_textbox('Ins');">&times;</button>
                                        <h5 class="modal-title">Agregar cargo instancia</h5>
                                    </div>
                                    <div class="modal-body">
                                        <div class="row">
                                            <div class="col-md-8">
                                                <div class="form-group ">
                                                    <label>Nombre del cargo</label>
                                                    <input type="text" class="form-control" id="Ins" placeholder="Cargo instancia" runat="server" title="nombre del cargo" pattern="[A-Za-z]{15}" required="required" />
                                                </div>
                                            </div>


                                            <div class="col-md-4">
                                                <div class="form-group ">
                                                    <label>Tipo elector</label>
                                                    <asp:DropDownList ID="TipoE" runat="server" CssClass="form-control" AppendDataBoundItems="True" required="true">
                                                        <asp:ListItem Value="" Selected="true">Seleccione opcion...</asp:ListItem>
                                                        <asp:ListItem Value="1">1</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label>Cupos</label>
                                                    <asp:DropDownList ID="Cupos" runat="server" AppendDataBoundItems="True" CssClass="form-control" required="true">
                                                        <asp:ListItem Value="">Seleccione opción...</asp:ListItem>
                                                        <asp:ListItem Value="1">1</asp:ListItem>
                                                        <asp:ListItem Value="2">2</asp:ListItem>
                                                        <asp:ListItem Value="3">3</asp:ListItem>
                                                        <asp:ListItem Value="4">4</asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>

                                            </div>
                                            <div class="col-md-4">
                                                <label>Votacion</label>
                                                <asp:DropDownList ID="TipoV" runat="server" class="form-control">
                                                    <asp:ListItem Value="">Seleccione opcion...</asp:ListItem>
                                                    <asp:ListItem Value="Elegible">Elegible</asp:ListItem>
                                                    <asp:ListItem Value="Designado">Designado  </asp:ListItem>
                                                </asp:DropDownList>
                                            </div>
                                            <div class="col-md-4">
                                                <div class="form-group">
                                                    <label>Perido</label>
                                                    <asp:DropDownList ID="Perido" runat="server" class="form-control">
                                                        <asp:ListItem Value="">Seleccione opcion...</asp:ListItem>
                                                        <asp:ListItem Value="12">12</asp:ListItem>
                                                        <asp:ListItem Value="24">24 </asp:ListItem>
                                                        <asp:ListItem Value="36">36 </asp:ListItem>
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="row">
                                            <div class="col-md-12">
                                                <div class="form-group">
                                                    <label>Cargos</label>

                                                </div>
                                            </div>
                                        </div>

                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-link" data-dismiss="modal" onclick="limpiar_textbox('cober');">Cerrar</button>
                                        <asp:Button ID="Agregar_Modif" runat="server" CssClass="btn btn-fill btn-info" Text="Agregar" OnCommand="Agregar_Modif_Command" CommandName="Insertar" UseSubmitBehavior="false" />
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div id="Agregar_instancia" class="modal fade">
                            <div class="modal-dialog">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <button type="button" class="close" data-dismiss="modal" onclick="limpiar_textbox('cober');">&times;</button>
                                        <h5 class="modal-title">Agregar cargo instancia</h5>
                                    </div>
                                    <div class="modal-body">
                                        <div class="form-group">
                                            <label>Nombre instancia</label>
                                            <input type="text" class="form-control" id="NombreIns" placeholder="Cargo instancia" runat="server" required="required" />
                                        </div>
                                        <div class="form-group">
                                            <label>Estado</label>
                                            <asp:DropDownList ID="InsEstadi" runat="server" CssClass="form-control" AppendDataBoundItems="True" required>
                                                <asp:ListItem Value=""> Seleccione</asp:ListItem>
                                                <asp:ListItem Value="ACTIVO">ACTIVO</asp:ListItem>
                                                <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                                            </asp:DropDownList>
                                        </div>
                                        <div class="form-group">
                                            <label>Cobertura</label>
                                            <asp:DropDownList ID="CoberturaIns" runat="server" CssClass="form-control" AppendDataBoundItems="True" required>
                                            </asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-link" data-dismiss="modal" onclick="limpiar_textbox('cober');">Cerrar</button>
                                        <asp:Button ID="Agregar_Inst" runat="server" CssClass="btn btn-fill btn-info" Text="Agregar" OnClick="Agregar_Inst_Click" UseSubmitBehavior="false" data-dismiss="modal" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- /content area -->
                </div>
                <!-- /main content -->
            </div>
            <!-- /page content -->
        </div>
        <!--Ventana modal Formulario registro -->
        <div id="modal_form_vertical2" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" onclick="limpiar_textbox('Causar');">&times;</button>
                        <h5 class="modal-title">Agregar instancia</h5>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <label>Nombre Instancia</label>
                            <input type="text" class="form-control" id="instancian" placeholder="Nombre Instancia" runat="server">
                            <label>Cobertura</label>
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control" AppendDataBoundItems="true">
                                <asp:ListItem Value="null">Seleccione opcion...</asp:ListItem>
                            </asp:DropDownList>
                            <%-- <select type="text" class="form-control" id="select1" placeholder="Causa retiro" runat="server"></select>--%>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-link" data-dismiss="modal" onclick="limpiar_textbox('Causar');">Cerrar</button>
                        <asp:Button ID="AgregarCausa" runat="server" CssClass="btn btn-fill btn-info" Text="Agregar" OnClick="AgregarInstancia_Click" data-dismiss="modal" UseSubmitBehavior="false" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script>

        $(document).ready(function () {
            $('#example').DataTable();
        });

    </script>
</body>
</html>
