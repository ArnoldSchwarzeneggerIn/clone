<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvocatoriaPublica.aspx.cs" Inherits="Prueba.Views.ConvocatoriaPublica" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Sistema Electoral</title>




    <!--Organizando los datos de la seleccion de los cargo-->
    <style>
        .invisible {
            display: none;
        }

        .flotarIzquierda {
            float: left;
        }

        .camuflaje {
            color: rgba(252, 252, 252,0.0);
        }


        .buttl2 {
            /*margin-left:90%;*/
            float: left;
            padding-top: 0.7em;
            padding-bottom: 0.6em;
            padding-left: 1.8em;
            padding-right: 1.8em;
            background-color: #26A69A;
            color: white;
            border: none;
            border-bottom-right-radius: 20%;
            border-top-right-radius: 20%;
            /*clear: both;*/
            font-weight: bold;
        }

        .butt {
            margin-top: 5%;
            margin-bottom: 5%;
            /*margin-left:90%;*/
            float: right;
            padding-top: 0.8em;
            padding-bottom: 0.8em;
            padding-left: 1.8em;
            padding-right: 1.8em;
            background-color: #26A69A;
            color: white;
            border: none;
            border-radius: 8%;
            /*clear: both;*/
            font-weight: bold;
        }

        .buttE {
            margin-top: 5%;
            /*margin-left:90%;*/
            float: right;
            padding-top: 0.8em;
            padding-bottom: 0.8em;
            padding-left: 1.8em;
            padding-right: 1.8em;
            background-color: red;
            color: white;
            border: none;
            border-radius: 8%;
            font-weight: bold;
        }

        .hTittle {
            color: white;
            font-size: 1em;
            text-align: center;
        }

        .widget-header + .widget-content {
            border-top: none;
            -webkit-border-top-left-radius: 0;
            -webkit-border-top-right-radius: 0;
            -moz-border-radius-topleft: 0;
            -moz-border-radius-topright: 0;
            border-top-left-radius: 0;
            border-top-right-radius: 0;
        }



        .widget-content {
            padding: 20px 15px 15px;
            background: #FFF;
            border: 1px solid #D5D5D5;
            -moz-border-radius: 5px;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            zoom: 1;
        }



        /*
    .widget-content:before, .widget-content:after {
    content: "";
    display: table;
}



        .widget-content:after {
    content: "";
    display: table;
        clear: both;
}*/



        .widget-header {
            background-color: #26A69A;
            position: relative;
            height: 40px;
            line-height: 40px;
            /*background: -webkit-linear-gradient(top, #f9f6f1 0%,#f2efea 100%);*/
            border: 1px solid #d6d6d6;
        }

        .widget {
            position: relative;
            clear: both;
            width: auto;
            margin-bottom: 2em;
            overflow: hidden;
        }

        .accordion-group {
            margin-bottom: 2px;
            border: 1px solid #e5e5e5;
            -webkit-border-radius: 4px;
            -moz-border-radius: 4px;
            border-radius: 4px;
        }

        /*.accordion-heading .accordion-toggle {
            display: block;
            padding: 8px 15px;
        }*/

        .accordion-heading {
            /*color: #545454;*/
            color: white;
            text-decoration: none;
            font-weight: bold;
            display: block;
            padding: 8px 15px;
            background-color: #26A69A;
            /*background-color:black;*/
        }

            .accordion-heading a {
                /*color: #545454;*/
                color: white;
                text-decoration: none;
                font-weight: bold;
            }



        .accordion-inner {
            padding: 9px 15px;
            border-top: 1px solid #e5e5e5;
        }



        .ArregloCheckCargos {
            margin-left: 5px;
        }

        .ArregloLabelCargos {
            margin-left: 20px;
        }

        .ArregloDropDownListCargos {
            float: right;
            margin-right: 100px;
        }


        .ui-datepicker-calendar {
            display: none;
        }
    </style>







    <!-- Global stylesheets -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css"/>
    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css"/>
    <link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css"/>

    <!-- Fileinput-->
    <%--  <link href="../css/fileinput.css" media="all" rel="stylesheet" type="text/css" />--%>
    <%--/Fileinput--%>

    <link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css"/>
    <link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css"/>
    <link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css"/>
    <!-- /global stylesheets -->

    <!-- Core JS files -->
    <%--<script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>--%>
    <script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    <script src="http://code.jquery.com/ui/1.9.1/jquery-ui.js"></script>

    <!-- Fileinput-->
    <%--  <script src="../js/fileinput.js" type="text/javascript"></script>--%>
    <!--/Fileinput-->


    <!-- /core JS files -->

    <!-- Theme JS files -->
    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <%-- <script type="text/javascript" src="assets/js/core/libraries/jasny_bootstrap.min.js"></script>--%>
    <%--no deja mostrar el fileuploap dentro de un tab con steps.js en otro lugar si funciona---%>
    <script type="text/javascript" src="assets/js/plugins/forms/validation/validate.min.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
    <script type="text/javascript" src="assets/js/pages/wizard_steps.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
    <%--No deja lanzar la alerta--%>

    <!-- /Theme JS files -->





    <%--    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>--%>

    <%--<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js" type="text/javascript"></script>--%>






    <script>


        function RedirectCandidato(id,c) {
            alert(id, c +'wtf');
            document.location.href = "http://localhost:25597/electoral/views/VConvocatoria.aspx?id=" + id + "?c=" + c;
        }

        function IrAPanel(e) {
            var x;
            switch (e) {
                case "PPblc":
                    x = document.getElementById('ad');
                    x.click();
                    break;
                case "TBrrd":
                    x = document.getElementById('LTBrrd');
                    x.click();
                    break;
                case "PBrrd":
                    x = document.getElementById('ad');
                    x.click();
                    break;
            }
        }



    </script>

    <script>



        //function Refresh_page() {
        //    document.location.href = document.location.href
        //}



        //function Refresh_page2() {
        //    setTimeout(Refresh_page, 1500);
        //}


    </script>
    </head>

    <body>

        <form id="Formulario" runat="server">

            <%--<asp:Button ID="Buttonttt" runat="server" Text="Button" OnClick="NuevoClick12" Style="display: none" />--%>
            <%--   <asp:Button ID="Button5" runat="server" Text="Button" OnClick="ICnvtC" Style="display: none" />--%>




            <a id="aa" data-toggle="modal" href="#modal_form_vertical" title="Agregar" style="display: none"><i class="icon-add"></i></a>
            <a id="ab" data-toggle="modal" href="#modal_registro" title="Agregar" style="display: none"><i class="icon-add"></i></a>

            <%-- <asp:Button ID="ICnvt" runat="server" Text="Button" OnClick="ICnvtC" Style="display: none" />--%>
            <%-- <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button4_Click" Style="display: none" />--%>
            <asp:Label ID="Label1" runat="server" Text="1" Style="display: none"></asp:Label>
            <asp:Label ID="Label2" runat="server" Text="Label" Style="display: none"></asp:Label>

            <!-- Main navbar -->
            <div class="navbar navbar-inverse">
                <div class="navbar-header">
                    <a class="navbar-brand" href="index.aspx">
                        <img src="assets/images/si.png" style="width: 11em; height: 1.5em;" />
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
                                        <li class="active"><a href="Index.aspx"><i class="icon-home4"></i><span>Principal</span></a></li>
                                        <li>
                                            <a href="#"><i class="icon-stack2"></i><span>Convocatorias</span></a>
                                            <ul>
                                                <li><a id="recargar" href="VConvocatoria.aspx">Gestionar convocatoria</a></li>
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
                        <div class="page-header no-margin">
                            <div class="page-header-content">
                            </div>

                            <div class="breadcrumb-line">
                                <ul class="breadcrumb">
                                    <li><a href="index.aspx"><i class="icon-home2 position-left"></i>Index</a></li>

                                </ul>


                            </div>
                        </div>
                        <!-- /page header -->
                        <!-- Toolbar -->
                        <div class="navbar navbar-default navbar-xs content-group">
                            <ul class="nav navbar-nav visible-xs-block">
                                <li class="full-width text-center"><a data-toggle="collapse" data-target="#navbar-filter"><i class="icon-menu7"></i></a></li>
                            </ul>

                            <div class="navbar-collapse collapse" id="navbar-filter">
                                <ul class="nav navbar-nav element-active-slate-400">
                                    <li id="liTRBrrd" class="active"><a href="#TPblc" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Convocatorias Publicadas </a></li>
                                    <li style="display: none"><a id="ad" href="#PPblc" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Consultar Publicada  </a></li>
                                </ul>
                            </div>
                        </div>
                        <div class="content">
                            <div class="row">
                                <div class="col-lg-12">
                                    <div class="tabbable">

                                        <div class="tab-content">

                                            <%--tab convocatorias publicadas--%>

                                            <div class="tab-pane fade in active" id="TPblc">
                                                <div class="panel col-md-10 col-md-offset-1">
                                                    <div class="panel-heading">
                                                        <%--<h6 class="panel-title">Borradores</h6>--%>
                                                        <div class="heading-elements" style="margin-top: 0.5%">
                                                            <span class="label bg-success heading-text">
                                                                <asp:Label ID="NmroPblcs" runat="server" Text="Label"></asp:Label>
                                                                Convocatoria publicada </span>
                                                            <ul class="icons-list">
                                                                <li><a data-toggle="modal" href="#" title="Agregar"><i class="icon-add"></i></a></li>
                                                            </ul>
                                                        </div>
                                                    </div>
                                                    <div class="panel-body">
                                                        <p style="font-size: 2em; width: 100%; text-align: center">Lista de convocatorias publicadas </p>
                                                        <br />


                                                        <asp:ListView ID="LVPblc" runat="server">
                                                            <itemtemplate>
                                                            <div class="col-md-10 col-md-offset-1">
                                                                <div class="thumbnail">
                                                                    <div class="thumb text-center">
                                                                        <label style="font-size: 2em; margin-top: 2em">
                                                                            CONVOCATORIA ELECTORAL
                                                                            <br />
                                                                            N#
                                                                        <asp:Label ID="titu" runat="server" Text='<%#Eval("NUMEROCONVOCATORIA") %>'>  </asp:Label>
                                                                            de 
                                                                            <asp:Label ID="Label5" runat="server" Text='<%#Eval("fecharegistro") %>'>  </asp:Label>
                                                                        </label>
                                                                    </div>

                                                                    <div class="caption">
                                                                        <%-- <h6 class="text-semibold no-margin-top text-uppercase">
                                                                            <asp:Label ID="tituloconv" runat="server" Text='<%#Eval("TituloConvocatoria")%>'> </asp:Label>
                                                                        </h6>--%>

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

                                                                            <div class="col-sm-6">
                                                                                <h6 class="text-semibold text-right no-margin-top"></h6>
                                                                                <ul class="list list-unstyled text-right">
                                                                                    <li>
                                                                                        Estado: <span class="text-semibold"><%#Eval("estado") %></span>

                                                                                    </li>
                                                                                </ul>
                                                                            </div>
                                                                        </div>


                                                                    </div>

                                                                    <div class="panel-footer">
                                                                        <ul>
                                                                            <li>
                                                                                <asp:LinkButton ID="LBPblc" runat="server" CssClass="icon-eye8" CommandArgument='<%#Eval("IDCONVOCATORIA")%>' OnCommand="VerPblc"> </asp:LinkButton>
                                                                            </li>
                                                                        </ul>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </itemtemplate>
                                                        </asp:ListView>
                                                    </div>
                                                </div>
                                            </div>




                                            <%-- panel publicados --%>

                                            <div class="tab-pane fade" id="PPblc">
                                                <div class="panel col-md-10 col-md-offset-1">
                                                    <div class="panel-heading">
                                                        <div class="panel-body">
                                                            <div class="col-md-12">
                                                                <div class="widget">
                                                                    <div class="widget-header text-center">
                                                                        <label class="hTittle" style="align-content: center; align-items: center; font-weight: bold;">
                                                                            CARGOS SOLICITADOS EN CONVOCATORIA N#
                                                                <label id="CntvPblc" runat="server"></label>
                                                                        </label>
                                                                        <%--<h3 class="hTittle">Selecciona los cargos a convocar</h3>--%>
                                                                    </div>

                                                                    <div class="widget-content">
                                                                        <div id="Panel3" runat="server">
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="col-md-10 col-md-offset-1">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label id="Label3" runat="server" style="float: left; padding-right: 20%" class="btn btn-default btn-file text-left">
                                                                        </label>
                                                                        <%--<asp:LinkButton runat="server" >LinkButton</asp:LinkButton>--%>

                                                                        <asp:Button ID="Button8" runat="server" Text="Ver" CssClass="buttl2" OnClick="Button8_Click2" />

                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
            <!-- Footer -->
                                        <div class="footer text-muted">
                                            &copy; 2016. <a href="#">Sistema electoral</a> by <a href="#" target="_blank">Giecom</a>
                                        </div>
                                        <!-- /footer -->
        </form>
    </body>
</html>
