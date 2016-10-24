<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConvocatoriaDetalle.aspx.cs" Inherits="Prueba.Views.ConvocatoriaDetalle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <meta charset="utf-8" />
    <title>Sistema Electoral</title>
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css">
    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css">

    <script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    <!-- /core JS files -->

    <!-- Theme JS files -->
    <script type="text/javascript" src="assets/js/plugins/forms/selects/select2.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/styling/uniform.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/ui/moment/moment.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/ui/fullcalendar/fullcalendar.min.js"></script>
        <script type="text/javascript" src="assets/js/plugins/ui/fullcalendar/lang/es.js"></script>

    <script type="text/javascript" src="assets/js/plugins/visualization/echarts/echarts.js"></script>

    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/user_pages_profile.js"></script>

</head>
<body>
    <form id="form1" runat="server">
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


        <!-- Page container -->
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
                    <div class="page-header no-margin">
                        <div class="page-header-content">
                            <div class="page-title">
                                <h4><i class="icon-arrow-left52 position-left"></i> <asp:Label ID="NombreConv" runat="server" Text="Label"></asp:Label>  </h4>
                            </div>
                        </div>

                        <div class="breadcrumb-line">
                            <ul class="breadcrumb">
                                <li><a href="Index.aspx"><i class="icon-home2 position-left"></i>index</a></li>
                                <li><a href="#">Convocatoria</a></li>
                                <li class="active">Detalle convocatoria</li>
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
                                <li class="active"><a href="#activity" data-toggle="tab"><i class="icon-menu7 position-left"></i>Candidatos </a></li>
                                <li><a href="#schedule" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Información  </a></li>
                                <li><a href="#settings" data-toggle="tab"><i class="icon-cog3 position-left"></i>Configuración </a></li>
                            </ul>
                        </div>
                    </div>
                    <!-- /page header -->


                    <!-- Content area -->
                    <div class="content">

                        <div class="row">
                            <div class="col-lg-12">
                                <div class="tabbable">
                                    <div class="tab-content">
                                        <div class="tab-pane fade in active" id="activity">

                                            <!-- Timeline -->
                                            <div class="timeline timeline-left content-group">
                                                <div class="timeline-container">

                                                    <!-- Sales stats -->
                                                    <div class="timeline-row">
                                                        <div class="timeline-icon">
                                                            <a href="#">
                                                                <img src="assets/images/placeholder.jpg" alt=""></a>
                                                        </div>

                                                        <div class="panel panel-flat timeline-content">
                                                            <div class="panel-heading">
                                                                <h6 class="panel-title">Candidatos inscritos</h6>
                                                                <div class="heading-elements">
                                                                    <span class="heading-text"><i class="icon-history position-left text-success"></i></span>

                                                                    <ul class="icons-list">
                                                                        <li><a data-action="reload"></a></li>
                                                                    </ul>
                                                                </div>
                                                            </div>

                                                            <div class="panel-body">
                                                                <div class="panel panel-flat">
                                                                    <div class="panel-heading">
                                                                        <h6 class="panel-title">Calendario</h6>
                                                                        <div class="heading-elements">
                                                                            <ul class="icons-list">
                                                                                <li><a data-action="collapse"></a></li>
                                                                                <li><a data-action="reload"></a></li>
                                                                                <li><a data-action="close"></a></li>
                                                                            </ul>
                                                                        </div>
                                                                    </div>

                                                                    <div class="panel-body">
                                                                        <div class="schedule"></div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                    <!-- /sales stats -->
                                                </div>
                                            </div>
                                            <!-- /timeline -->

                                        </div>

                                        <div class="tab-pane fade" id="schedule">

                                            <!-- Available hours -->
                                            <div class="panel panel-flat">
                                                <div class="panel-heading">
                                                    <h6 class="panel-title">Available hours</h6>
                                                    <div class="heading-elements">
                                                        <ul class="icons-list">
                                                            <li><a data-action="collapse"></a></li>
                                                            <li><a data-action="reload"></a></li>
                                                        </ul>
                                                    </div>
                                                </div>

                                                <div class="panel-body">
                                                  
                                                </div>
                                            </div>
                                            <!-- /available hours -->


                                            <!-- Calendar -->

                                            <!-- /calendar -->

                                        </div>

                                        <div class="tab-pane fade" id="settings">

                                            <!-- Profile info -->
                                            <div class="panel panel-flat">
                                                <div class="panel-heading">
                                                    <h6 class="panel-title">Profile information</h6>
                                                    <div class="heading-elements">
                                                        <ul class="icons-list">
                                                            <li><a data-action="collapse"></a></li>
                                                            <li><a data-action="reload"></a></li>
                                                        </ul>
                                                    </div>
                                                </div>

                                                <div class="panel-body">
                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <label>Username</label>
                                                                    <input type="text" value="Eugene" class="form-control">
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <label>Full name</label>
                                                                    <input type="text" value="Kopyov" class="form-control">
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <label>Address line 1</label>
                                                                    <input type="text" value="Ring street 12" class="form-control">
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <label>Address line 2</label>
                                                                    <input type="text" value="building D, flat #67" class="form-control">
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <label>City</label>
                                                                    <input type="text" value="Munich" class="form-control">
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <label>State/Province</label>
                                                                    <input type="text" value="Bayern" class="form-control">
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <label>ZIP code</label>
                                                                    <input type="text" value="1031" class="form-control">
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <label>Email</label>
                                                                    <input type="text" readonly="readonly" value="eugene@kopyov.com" class="form-control">
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <label>Your country</label>
                                                                    <select class="select">
                                                                        <option value="germany" selected="selected">Germany</option>
                                                                        <option value="france">France</option>
                                                                        <option value="spain">Spain</option>
                                                                        <option value="netherlands">Netherlands</option>
                                                                        <option value="other">...</option>
                                                                        <option value="uk">United Kingdom</option>
                                                                    </select>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <label>Phone #</label>
                                                                    <input type="text" value="+99-99-9999-9999" class="form-control">
                                                                    <span class="help-block">+99-99-9999-9999</span>
                                                                </div>

                                                                <div class="col-md-6">
                                                                    <label>Upload profile image</label>
                                                                    <input type="file" class="file-styled">
                                                                    <span class="help-block">Accepted formats: gif, png, jpg. Max file size 2Mb</span>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="text-right">
                                                            <button type="submit" class="btn btn-primary">Save <i class="icon-arrow-right14 position-right"></i></button>
                                                        </div>
                                                   
                                                </div>
                                            </div>
                                            <!-- /profile info -->


                                            <!-- Account settings -->
                                            <div class="panel panel-flat">
                                                <div class="panel-heading">
                                                    <h6 class="panel-title">Account settings</h6>
                                                    <div class="heading-elements">
                                                        <ul class="icons-list">
                                                            <li><a data-action="collapse"></a></li>
                                                            <li><a data-action="reload"></a></li>
                                                            <li><a data-action="close"></a></li>
                                                        </ul>
                                                    </div>
                                                </div>

                                                <div class="panel-body">
                                                    <form action="#">
                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <label>Username</label>
                                                                    <input type="text" value="Kopyov" readonly="readonly" class="form-control">
                                                                </div>

                                                                <div class="col-md-6">
                                                                    <label>Current password</label>
                                                                    <input type="password" value="password" readonly="readonly" class="form-control">
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <label>New password</label>
                                                                    <input type="password" placeholder="Enter new password" class="form-control">
                                                                </div>

                                                                <div class="col-md-6">
                                                                    <label>Repeat password</label>
                                                                    <input type="password" placeholder="Repeat new password" class="form-control">
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="form-group">
                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <label>Profile visibility</label>

                                                                    <div class="radio">
                                                                        <label>
                                                                            <input type="radio" name="visibility" class="styled" checked="checked">
                                                                            Visible to everyone
                                                                        </label>
                                                                    </div>

                                                                    <div class="radio">
                                                                        <label>
                                                                            <input type="radio" name="visibility" class="styled">
                                                                            Visible to friends only
                                                                        </label>
                                                                    </div>

                                                                    <div class="radio">
                                                                        <label>
                                                                            <input type="radio" name="visibility" class="styled">
                                                                            Visible to my connections only
                                                                        </label>
                                                                    </div>

                                                                    <div class="radio">
                                                                        <label>
                                                                            <input type="radio" name="visibility" class="styled">
                                                                            Visible to my colleagues only
                                                                        </label>
                                                                    </div>
                                                                </div>

                                                                <div class="col-md-6">
                                                                    <label>Notifications</label>

                                                                    <div class="checkbox">
                                                                        <label>
                                                                            <input type="checkbox" class="styled" checked="checked">
                                                                            Password expiration notification
                                                                        </label>
                                                                    </div>

                                                                    <div class="checkbox">
                                                                        <label>
                                                                            <input type="checkbox" class="styled" checked="checked">
                                                                            New message notification
                                                                        </label>
                                                                    </div>

                                                                    <div class="checkbox">
                                                                        <label>
                                                                            <input type="checkbox" class="styled" checked="checked">
                                                                            New task notification
                                                                        </label>
                                                                    </div>

                                                                    <div class="checkbox">
                                                                        <label>
                                                                            <input type="checkbox" class="styled">
                                                                            New contact request notification
                                                                        </label>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="text-right">
                                                            <button type="submit" class="btn btn-primary">Save <i class="icon-arrow-right14 position-right"></i></button>
                                                        </div>
                                                    </form>
                                                </div>
                                            </div>
                                            <!-- /account settings -->

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
                    </div>
                    <!-- /content area -->
                </div>
                <!-- /main content -->
            </div>
            <!-- /page content -->
        </div>
        <!-- /page container -->
    </form>
</body>
</html>
