<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instancias.aspx.cs" Inherits="Prueba.views.Instancias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Sistema Electoral</title>

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

    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/components_navs.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <!-- /theme JS files -->
</head>
<body>
    <form id="form1" runat="server">
        <!-- Main navbar -->
        <div class="navbar navbar-inverse">
            <div class="navbar-header">
                <a class="navbar-brand" href="index.html">
                    <img src="assets/images/logo_light.png" alt=""></a>

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
                            <img src="assets/images/placeholder.jpg" alt="">
                            <span>Usuario</span>
                            <i class="caret"></i>
                        </a>

                        <ul class="dropdown-menu dropdown-menu-right">
                            <li><a href="#"><i class="icon-switch2"></i>Salir</a></li>
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
                                        <img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
                                    <div class="media-body">
                                        <span class="media-heading text-semibold">Electoral</span>
                                        <div class="text-size-mini text-muted">
                                            <i class="icon-pin text-size-small">Prueba Token</i>
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
                                    <li class="active"><a href="Index.aspx"><i class="icon-home4"></i><span>Principal</span></a></li>
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
                                    <li>
                                        <a href="#"><i class="icon-puzzle"></i><span>Parametricas</span></a>
                                        <ul>
                                            <li><a href="VCobertura.aspx">Cobertura</a></li>
                                            <li><a href="Causaderetiro.aspx">Causa de retiro</a></li>
                                            <li><a href="Instancias.aspx">Instancias</a></li>
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
							<li><a data-toggle="modal" href="#Agregar_instancia"  ><i class="icon-add-to-list position-left"></i> Agregar Instancia</a></li>
							</ul>



                        </div>
                    </div>
                    <!-- /page header -->


                    <!-- Content area -->
                    <div class="content">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                        <div class="row">
                            <asp:Repeater ID="Instanciaslista" runat="server" OnItemDataBound="Instanciaslista_ItemDataBound">
                                <ItemTemplate>
                                    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="Agregarcargo" EventName="Command" />
                                        </Triggers>
                                        <ContentTemplate>
                                            <div class="col-md-6 panel">
                                                <div class="panel-heading">
                                                    <h6 class="panel-title">
                                                        <small>
                                                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("NombreInstancia")%>'></asp:Label></small>
                                                    </h6>
                                                    <div class="heading-elements">
                                                        <span class="label bg-success heading-text">
                                                            <asp:Label ID="Cobertura" runat="server" Text='<% #Eval("IdCobertura") %>'></asp:Label>
                                                        </span>
                                                        <ul class="icons-list">
                                                            <li>
                                                                <asp:LinkButton ID="Agregarcargo" runat="server" CommandArgument='<%#Eval("IdInstancia")%>' OnCommand="LinkButton1_Command"> <i class="icon-add" title="Agregar cargo"></i></asp:LinkButton>
                                                            </li>
                                                            <li>
                                                               <asp:LinkButton ID="EditarInstancia" runat="server" CommandArgument='<%#Eval("IdInstancia")%>' OnCommand="EditarInstancia_Command"> <i class="icon-add" title="Editar Instancia"></i></asp:LinkButton>

                                                            </li>
                                                            <li>
                                                            </li>
                                                        </ul>
                                                    </div>
                                                    <a class="heading-elements-toggle"><i class="icon-menu"></i></a>
                                                </div>


                                                <div class="panel-group panel-group-control content-group-lg" id="accordion-control">

                                                    <asp:Repeater ID="InstanCargos" runat="server">
                                                        <ItemTemplate>
                                                            <div class="panel panel-white">
                                                                <div class="panel-heading">
                                                                    <h6 class="panel-title">
                                                                        <a data-toggle="collapse" data-parent="#accordion-control" href="#accordion<%#Eval("IdInstanciadetalle") %>" aria-expanded="false" class="collapsed"> <asp:Label ID="Label2" runat="server" Text='<%#Eval("NombreInstanciadetalle")%>'></asp:Label>   </a>
                                                                    </h6>
                                                                    <div class="heading-elements">
                                                                        <ul class="icons-list">
                                                                            <li><a data-action="reload"></a></li>
                                                                            <li><a data-action=""></a></li>
                                                                            <li><a data-action=""></a></li>
                                                                        </ul>
                                                                    </div>
                                                                </div>
                                                                <div id="accordion<%#Eval("IdInstanciadetalle") %>" class="panel-collapse collapse" aria-expanded="false" style="height: 0px;">
                                                                    <div class="panel-body">
                                                                        cargar conformacion Instancia
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </ItemTemplate>
                                                    </asp:Repeater>


                                                </div>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>

                                </ItemTemplate>
                            </asp:Repeater>
                        </div>

                        <!-- Footer -->
                        <div class="footer text-muted">
                            &copy; 2016. <a href="#">Sistema electoral</a> by <a href="#" target="_blank">Giecom</a>
                        </div>
                        <!-- /footer -->

                    </div>
                    <!-- /content area -->

                </div>
                <!-- /main content -->

            </div>
            <!-- /page content -->

        </div>

        <div id="modal_form_vertical" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" onclick="limpiar_textbox('Ins');">&times;</button>
                        <h5 class="modal-title">Agregar cargo instancia</h5>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <label>Nombre del cargo</label>
                            <input type="text" class="form-control" id="Ins" placeholder="Cargo instancia" runat="server" pattern="[A-Za-z]{15}" required="required">
                        </div>
                        <div class="form-group">
                            <label>Tipo elector</label>
                            <asp:DropDownList ID="TipoE" runat="server" CssClass="form-control" AppendDataBoundItems="True" required>
                                <asp:ListItem Value="" Selected="true">Seleccione opcion...</asp:ListItem>
                                <asp:ListItem Value="1">1</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Cupos</label>
                            <asp:DropDownList ID="Cupos" runat="server" AppendDataBoundItems="True" CssClass="form-control" required>
                                <asp:ListItem Value="">Seleccione opción...</asp:ListItem>
                                <asp:ListItem Value="1">1</asp:ListItem>
                                <asp:ListItem Value="2">2</asp:ListItem>
                                <asp:ListItem Value="3">3</asp:ListItem>
                                <asp:ListItem Value="4">4</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>Votacion</label>
                            <asp:DropDownList ID="TipoV" runat="server" class="form-control">
                                <asp:ListItem Value="">Seleccione opcion...</asp:ListItem>
                                <asp:ListItem Value="Elegible">Elegible</asp:ListItem>
                                <asp:ListItem Value="Designado">Designado  </asp:ListItem>
                            </asp:DropDownList>
                        </div>
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
                            <input type="text" class="form-control" id="NombreIns" placeholder="Cargo instancia" runat="server" pattern="[a-z]" required="required">
                        </div>
                        <div class="form-group">
                            <label>Cobertura</label>
                            <asp:DropDownList ID="CoberturaIns" runat="server" CssClass="form-control" AppendDataBoundItems="True" required>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-link" data-dismiss="modal" onclick="limpiar_textbox('cober');">Cerrar</button>
                        <asp:Button ID="Agregar_Inst" runat="server" CssClass="btn btn-fill btn-info" Text="Agregar" OnClick="Agregar_Inst_Click" />
                    </div>
                </div>
            </div>

        </div>

    </form>
</body>





</html>
