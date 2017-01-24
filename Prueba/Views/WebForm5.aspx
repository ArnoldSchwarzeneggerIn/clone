<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="Prueba.Views.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Sistema Electoral</title>

    <!-- Global stylesheets -->
    <link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css" />
    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css" />
    <!-- /global stylesheets -->

    <!-- Core JS files -->
    <script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    <!-- /core JS files -->

    <!-- Theme JS files -->
    <script type="text/javascript" src="assets/js/plugins/visualization/d3/d3.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/visualization/d3/d3_tooltip.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/styling/switchery.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/styling/uniform.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/selects/bootstrap_multiselect.js"></script>
    <script type="text/javascript" src="assets/js/plugins/ui/moment/moment.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/pickers/daterangepicker.js"></script>

    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/dashboard.js"></script>
    <!-- /theme JS files -->
    <style>
        .invisible{
            display:none;
        }

    </style>



    <script>
        function loggin(id) {
            __doPostBack(id);

        }
    </script>

</head>
<body>

   


                    <form id="form1" runat="server">
                         <!-- Main navbar -->
    <div class="navbar navbar-inverse">
        <div class="navbar-header">
            <a class="navbar-brand" href="index.aspx">
                <img src="assets/images/si.png" style="width: 11em; height: 1.5em;">
            </a>

            <ul class="nav navbar-nav pull-right visible-xs-block">
                <li><a data-toggle="collapse" data-target="#navbar-mobile"><i class="icon-tree5"></i></a></li>
            </ul>
        </div>

        <div class="navbar-collapse collapse" id="navbar-mobile">
            <ul class="nav navbar-nav navbar-right">
                <li>
                    <a href="#">
                        <i class="icon-display4"></i><span class="visible-xs-inline-block position-right">Go to website</span>
                    </a>
                </li>

                <li>
                    <a href="#">
                        <i class="icon-user-tie"></i><span class="visible-xs-inline-block position-right">Contact admin</span>
                    </a>
                </li>

                <li class="dropdown">
                    <a class="dropdown-toggle" data-toggle="dropdown">
                        <i class="icon-cog3"></i>
                        <span class="visible-xs-inline-block position-right">Options</span>
                    </a>
                </li>
            </ul>
        </div>
    </div>
    <!-- /main navbar -->


    <!-- Page container -->
    <div class="page-container login-container">

        <!-- Page content -->
        <div class="page-content">

            <!-- Main content -->
            <div class="content-wrapper">

                <!-- Content area -->
                <div class="content">


                        <div class="panel login-form">
                            <div class="thumb">
                                <img src="assets/images/LogoGIECOM.png" alt="" />
                            </div>

                            <div class="panel-body">
                                <h6 class="content-group text-center text-semibold no-margin-top">Sistema Electoral </h6>
                                <!--<a class="btn btn-primary btn-block" href="http://chaira.udla.edu.co/api/v0.1/oauth2/authorize.asmx/auth?response_type=code&client_id=503998150027&redirect_uri=http://191.102.85.226/electoral/views/index.aspx&state=x">Ingresar <i class="icon-arrow-right14 position-right"></i></a>-->


                                <div class="form-group has-feedback">
                                    <input id="usser" class="form-control" placeholder="Ingrese su usuario" runat="server" type="text" />
                                    <div class="form-control-feedback">
                                        <i class="glyphicon glyphicon-user"></i>
                                    </div>
                                </div>

                                <div class="form-group has-feedback">
                                    <input id="pwd" class="form-control" placeholder="Ingrese su contraceña" type="password" runat="server" required="required" />
                                    <div class="form-control-feedback">
                                        <i class="icon icon-lock2"></i>
                                    </div>
                                </div>

                                <div class="row col-md-10 col-md-offset-3">
                                    <button id="IniciarSesion" type="submit" class="btn btn-primary position-right" onclick="loggin('login')">
                                        Iniciar sesion <i class="icon-home2 position-right"></i>
                                    </button>
                                </div>
                                <asp:Button ID="Button1" runat="server" Text="Button" CssClass="invisible" OnClick="Button1_Click" />
                                <asp:Button ID="Button2" runat="server" Text="Button" CssClass="invisible" OnClick="Button1_Click" />

                                <%--  <a class="btn btn-primary btn-block" href="index.aspx">Ingresar <i class="icon-arrow-right14 position-right"></i></a>--%>
                            </div>
                        </div>
                              <!-- Footer -->
                    <div class="footer text-muted">
                        &copy; 2016. <a href="#">Sistema electoral</a> by <a href="200.21.7.94" target="_blank">Giecom</a>
                    </div>
                    <!-- /footer -->

                </div>
                <!-- /content area -->

            </div>
            <!-- /main content -->

        </div>
    </div>
    <!-- /page container -->

                    </form>
                    <!-- /unlock user -->


          
</body>
</html>
