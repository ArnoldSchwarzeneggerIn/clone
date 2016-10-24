<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instanciaDetalle.aspx.cs" Inherits="Prueba.Views.instanciaDetalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


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


</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

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

                        <div class="row">
                            <div class="col-lg-12">
                                <div class="panel panel-flat">
                                    <div class="panel-heading">
                                        <h6 class="panel-title">
                                            <asp:Label ID="nombreInstancia" runat="server" Text="Label"></asp:Label>
                                        </h6>
                                        <div class="heading-elements">
                                            <span class="label bg-success heading-text">
                                                <asp:Label ID="EstadoInstancia" runat="server" Text="Label"></asp:Label>

                                            </span>
                                            <ul class="icons-list">
                                                <li class="dropdown">
                                                    <a href="#" class="dropdown-toggle" data-toggle="dropdown" aria-expanded="false"><i class="icon-menu7"></i><span class="caret"></span></a>
                                                    <ul class="dropdown-menu dropdown-menu-right">
                                                        <li><a href="#"><i class="icon-cross3"></i>Accion </a></li>
                                                    </ul>
                                                </li>
                                            </ul>
                                        </div>
                                        <a class="heading-elements-toggle"><i class="icon-menu"></i></a>
                                    </div>


                                    <div class="table-responsive">
                                        <table class="table text-nowrap">
                                            <thead>
                                                <tr>
                                                    <th>Foto</th>
                                                    <th class="col-md-2">Nombre</th>
                                                    <th class="col-md-2">Periodo</th>
                                                    <th class="col-md-2">Estado</th>
                                                    <th class="text-center" style="width: 20px;"><i class="icon-arrow-down12"></i></th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                <asp:ListView ID="cargosInsta" runat="server">
                                                    <ItemTemplate>
                                                        <tr class="active border-double">
                                                            <td colspan="4"> <%#Eval("NOMBREINSTANCIADETALLE") %> </td>
                                                            <td class="text-right">
                                                                <span class="progress-meter" id="today-progress" data-progress="30">
                                                                    <svg width="20" height="20">
                                                                        <g transform="translate(10,10)">
                                                                            <g class="progress-meter">
                                                                                <path d="M0,8A8,8 0 1,1 0,-8A8,8 0 1,1 0,8Z" style="fill: rgb(255, 255, 255); stroke: rgb(121, 134, 203); stroke-width: 1.5;"></path>
                                                                                <path d="M4.898587196589413e-16,-8A8,8 0 0,1 7.608452130361228,2.472135954999579L0,0Z" style="fill: rgb(121, 134, 203);"></path>
                                                                            </g>
                                                                        </g></svg></span>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <asp:ListView ID="ListView2" runat="server">
                                                                <ItemTemplate>

                                                               
                                                            <td>
                                                                <div class="media-left media-middle">
                                                                    <a href="#">
                                                                        <img src="assets/images/placeholder.jpg" class="img-circle img-xs" alt=""></a>
                                                                </div>
                                                                <div class="media-left">
                                                                    <div class=""><a href="#" class="text-default text-semibold">Pepe</a></div>
                                                                    <div class="text-muted text-size-small">
                                                                        <span class="status-mark border-blue position-left"></span>
                                                                        02:00 - 03:00
                                                                    </div>
                                                                </div>
                                                            </td>
                                                            <td><span class="text-muted">Mintlime</span></td>
                                                            <td><span class="text-success-600"><i class="icon-stats-growth2 position-left"></i>2.43%</span></td>
                                                            <td><span class="label bg-blue">Active</span></td>
                                                             <td class="text-center">
                                                                        <ul class="icons-list">
                                                                            <li class="dropdown">
                                                                                <a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu7"></i></a>
                                                                                <ul class="dropdown-menu dropdown-menu-right">
                                                                                    <li><a href="#"><i class="icon-file-stats"></i>Editar</a></li>
                                                                                </ul>
                                                                            </li>
                                                                        </ul>
                                                                    </td>

                                                              </ItemTemplate>
                                                          </asp:ListView>

                                                                <td>
                                                                <div class="media-left media-middle">
                                                                    <a href="#">
                                                                        <img src="assets/images/placeholder.jpg" class="img-circle img-xs" alt=""></a>
                                                                </div>
                                                                <div class="media-left">
                                                                    <div class=""><a href="#" class="text-default text-semibold">Pepe</a></div>
                                                                    <div class="text-muted text-size-small">
                                                                        <span class="status-mark border-blue position-left"></span>
                                                                        02:00 - 03:00
                                                                    </div>
                                                                </div>
                                                            </td>
                                                            <td><span class="text-muted"> Activo</span></td>
                                                            <td><span class="text-success-600"> </span></td>
                                                            <td><span class="label bg-blue">Elegible</span></td>
                                                             <td class="text-center">
                                                                        <ul class="icons-list">
                                                                            <li class="dropdown">
                                                                                <a href="#" class="dropdown-toggle" data-toggle="dropdown"><i class="icon-menu7"></i></a>
                                                                                <ul class="dropdown-menu dropdown-menu-right">
                                                                                    <li><a href="#"><i class="icon-file-stats"></i>Editar</a></li>
                                                                                </ul>
                                                                            </li>
                                                                        </ul>
                                                                    </td>

                                                        </tr>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>


                            </div>

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
    </form>
</body>



</html>
