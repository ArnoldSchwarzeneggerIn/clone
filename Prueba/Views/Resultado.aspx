<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Resultado.aspx.cs" Inherits="Prueba.Views.Resultado" %>

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
    <script type="text/javascript" src="assets/js/cespas.js"></script>
    <!-- /core JS files -->

    <!-- Theme JS files -->

    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/jasny_bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/validation/validate.min.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>


    <!-- /theme JS files -->


</head>
<body>
    <form id="Formulario" runat="server">
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
                                            <li><a href="Resultado.aspx">Resultados</a></li>
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
                                <li><a href="Index.aspx"><i class="icon-home2 position-left"></i>Index</a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- /page header -->


                    <!-- Content area -->
                    <div class="content">

                        <div class="panel panel-white">
                            <div class="panel-heading">
                                <h6 class="panel-title">Resultados </h6>
                                <div class="heading-elements">
                                    <ul class="icons-list">
                                        <li><a data-action=""></a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class="panel panel-white">
                                <div class="panel-heading">
                                    <h6 class="panel-title">Convocatoria Electoral Universidad De La Amazonia</h6>
                                    <div class="heading-elements">
                                        <ul class="icons-list">
                                            <li><a data-action="collapse"></a></li>
                                            <li><a data-action="reload"></a></li>
                                            <li><a data-action="close"></a></li>
                                        </ul>
                                    </div>
                                </div>

                                <div class="tab-pane fade active in" id="registro">
                                    <div class="panel">
                                        <div class="steps-basic wizard clearfix" role="application" id="steps-uid-0">
                                            <div class="steps clearfix">
                                                <ul role="tablist">
                                                    <li class="disable first current" id="primera" role="tab" aria-disabled="false" aria-selected="true"><a id="steps-uid-0-t-0" href="#steps-uid-0-h-0" aria-controls="steps-uid-0-p-0"><span class="current-info audible">current step: </span><span class="number">1</span> Convocatorias</a></li>
                                                    <li class="disable disabled" id="segunda" role="tab" aria-disabled="true"><a id="steps-uid-0-t-1" href="#steps-uid-0-h-1" aria-controls="steps-uid-0-p-1"><span class="number">2</span> Instnacias</a></li>
                                                    <li class="disable disabled last" id="tercera" role="tab" aria-disabled="true"><a id="steps-uid-0-t-2" href="#steps-uid-0-h-2" aria-controls="steps-uid-0-p-2"><span class="number">3</span> Candidatos</a></li>

                                                </ul>
                                            </div>
                                            <div class="content clearfix">
                                                <!-- Content Convocatoria -->
                                                <h6 id="steps-uid-0-h-0" tabindex="-1" class="title current">Convocatorias</h6>
                                                <fieldset id="steps-uid-0-p-0" role="tabpanel" aria-labelledby="steps-uid-0-h-0" class="body current" aria-hidden="false">
                                                    <div class="row">
                                                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                                                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                                            <Triggers>
                                                            </Triggers>
                                                            <ContentTemplate>
                                                                <asp:ListView ID="ListaConvocatoria" runat="server">
                                                                    <ItemTemplate>
                                                                        <div class="col-md-6 col-md-offset-3">
                                                                            <div class="thumbnail">
                                                                                <div class="caption ">
                                                                                    <h6 class="text-semibold no-margin-top text-uppercase">
                                                                                        <div class="col-sm-12 text-center ">
                                                                                            <h6 class="text-semibold text-right no-margin-top"></h6>
                                                                                            <ul class="list list-unstyled text-center">
                                                                                                Convocatoria numero
                                                                                                    <%--<asp:Label ID="tituloconv" display="block" runat="server" Text='<%#Eval("TituloCovocatoria")%>'> </asp:Label>--%>
                                                                                            </ul>
                                                                                        </div>
                                                                                    </h6>
                                                                                    <div class="thumb">
                                                                                        <asp:LinkButton ID="infoconvo" runat="server" OnCommand="Verconvocatoria_Command" CommandArgument='<%#Eval("IDCONVOCATORIA")%>' CommandName="convocatoria"> <img src="assets/images/r.jpg" alt=""> </asp:LinkButton>
                                                                                    </div>
                                                                                    <asp:Label ID="descripcionconv" CssClass="text-uppercase" runat="server" Text='<%#Eval("DescripcionConvocatoria") %>'></asp:Label>

                                                                                    <div class="row">
                                                                                        <div class="col-sm-6">
                                                                                            <h6 class="text-semibold no-margin-top"></h6>
                                                                                            <ul class="list list-unstyled">
                                                                                                <li>Fecha inicio de inscripcion:</li>
                                                                                                <li>
                                                                                                    <%#Eval("Fechainicioinscripcion")%>
                                                                                                </li>
                                                                                                <li>Fecha limite de inscripcion:
                                                                                                </li>
                                                                                                <li>
                                                                                                    <%#Eval("Fechafininscripcion")%>
                                                                                                </li>
                                                                                            </ul>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                                <div class="panel-footer">
                                                                                    <ul>
                                                                                        <li>
                                                                                            <a href="#"><i class="icon-thumbs-up3 position-left"></i></a>
                                                                                        </li>
                                                                                        <li>
                                                                                            <asp:LinkButton ID="Verconvocatoria" runat="server" CssClass="icon-eye8" OnCommand="Verconvocatoria_Command" CommandArgument='<%#Eval("IDCONVOCATORIA")%>' CommandName="calendario"> </asp:LinkButton>
                                                                                        </li>
                                                                                    </ul>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </ItemTemplate>
                                                                </asp:ListView>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </div>
                                                </fieldset>
                                                <!-- /Content Convocatoria -->

                                                <!-- Content Instacia -->
                                                <h6 id="steps-uid-0-h-1" tabindex="-1" class="title">Instnacias</h6>
                                                <fieldset id="steps-uid-0-p-1" role="tabpanel" aria-labelledby="steps-uid-0-h-1" class="body" aria-hidden="true" style="display: none;">
                                                    <div class="row">
                                                        <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                                            <Triggers>
                                                            </Triggers>
                                                            <ContentTemplate>
                                                                <asp:ListView ID="ListaInstacia" runat="server">
                                                                    <ItemTemplate>
                                                                        <div class="col-md-4">
                                                                            <div class="thumbnail">
                                                                                <div class="caption">
                                                                                    <h6 class="text-semibold no-margin-top text-uppercase">
                                                                                        <div class="col-sm-12 text-center">
                                                                                            <h6 class="text-semibold text-right no-margin-top"></h6>
                                                                                            <ul class="list list-unstyled text-center">
                                                                                                <asp:Label ID="tituloins" display="block" runat="server" Text='<%#Eval("INST_NOMBRE")%>'> </asp:Label>
                                                                                            </ul>
                                                                                            <ul class="list list-unstyled text-center">
                                                                                                <asp:Label ID="describ" display="block" runat="server" Text='<%#Eval("INSD_NOMBRE")%>'> </asp:Label>
                                                                                            </ul>
                                                                                        </div>
                                                                                    </h6>
                                                                                    <div class="thumb">
                                                                                        <asp:LinkButton ID="infoinsta" runat="server" OnCommand="Verconvocatoria_Command" CommandArgument='<%#Eval("CONV_ID")+","+Eval("INST_NOMBRE")+","+Eval("INSD_NOMBRE")%>' CommandName="instancia"> <img src="assets/images/esins.jpg" alt=""> </asp:LinkButton>
                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </ItemTemplate>
                                                                </asp:ListView>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </div>
                                                </fieldset>
                                                <!-- /Content Instacia -->

                                                <!-- Content Candidatos -->
                                                <h6 id="steps-uid-0-h-2" tabindex="-1" class="title">Candidatos</h6>
                                                <fieldset id="steps-uid-0-p-2" role="tabpanel" aria-labelledby="steps-uid-0-h-2" class="body" aria-hidden="true" style="display: none;">
                                                    <div class="row">
                                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                                                            <Triggers>
                                                            </Triggers>
                                                            <ContentTemplate>
                                                                <asp:ListView ID="Listacandidatos" runat="server">
                                                                    <ItemTemplate>
                                                                        <div class="col-md-3">
                                                                            <div class="thumbnail">
                                                                                <div class="caption">
                                                                                    <h6 class="text-semibold no-margin-top text-uppercase">
                                                                                        <div class="col-sm-6">
                                                                                            <h6 class="text-semibold text-right no-margin-top"></h6>
                                                                                            <ul class="list list-unstyled text-right">
                                                                                            </ul>

                                                                                        </div>

                                                                                    </h6>
                                                                                    <div class="thumb">
                                                                                        <asp:LinkButton ID="infocandi" runat="server" OnCommand="Verconvocatoria_Command" CommandArgument='<%#Eval("CONV_ID")%>' CommandName="candidato"> <img src="assets/images/trom.jpg" alt=""> </asp:LinkButton>
                                                                                    </div>
                                                                                    <div class="row">
                                                                                        <div class="col-sm-12 text-semibold">
                                                                                            <h6 class="text-semibold no-margin-top"></h6>
                                                                                            <ul class="list list-unstyled">
                                                                                                <li class="text-semibold text-center"><small><%#Eval("NOMBRE")%></small></li>
                                                                                                <li class="text-semibold text-center"><small><%#Eval("PROG_NOMBRE")%></small></li>
                                                                                                <li class="text-semibold text-center" style="font-size: 20px">Votos </li>
                                                                                                <li class="text-center" style="font-size: 50px">300 </li>
                                                                                            </ul>
                                                                                        </div>
                                                                                    </div>
                                                                                </div>
                                                                            </div>
                                                                        </div>
                                                                    </ItemTemplate>
                                                                </asp:ListView>
                                                            </ContentTemplate>
                                                        </asp:UpdatePanel>
                                                    </div>
                                                </fieldset>
                                                <!-- /Content Candidatos -->

                                            </div>
                                        </div>


                                    </div>
                                </div>

                            </div>
                            <!-- Footer -->
                            <div class="footer text-muted">
                                © 2016. <a href="#">Sistema electoral</a> by <a href="#" target="_blank">Giecom</a>
                            </div>
                            <!-- /footer -->
                        </div>
                        <!-- /Content area -->
                    </div>
                </div>
            </div>
        </div>
    </form>

</body>
</html>