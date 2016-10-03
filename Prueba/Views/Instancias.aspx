<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Instancias.aspx.cs" Inherits="Prueba.views.Instancias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<meta charset="utf-8" />
    <meta charset="utf-8" />
    <link rel="icon" type="image/png" href="assets/img/favicon.ico">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1" />
    <title>HOME</title>
    <meta content='width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0' name='viewport' />
    <meta name="viewport" content="width=device-width" />
    <!-- Bootstrap core CSS     -->
    <link href="../Contents/css/bootstrap.min.css" rel="stylesheet" />
    <!-- Animation library for notifications   -->
    <link href="../Contents/css/animate.min.css" rel="stylesheet" />
    <!--  Light Bootstrap Table core CSS    -->
    <link href="../Contents/css/light-bootstrap-dashboard.css" rel="stylesheet" />
    <!--  CSS for Demo Purpose, don't include it in your project     -->
    <link href="../Contents/JU/css/demo.css" rel="stylesheet" />
    <!--     Fonts and icons     -->
    <link href="http://maxcdn.bootstrapcdn.com/font-awesome/4.2.0/css/font-awesome.min.css" rel="stylesheet">
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,700,300' rel='stylesheet' type='text/css'>
    <link href="../Contents/JU/css/pe-icon-7-stroke.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

     <div class="wrapper">
        <div class="sidebar" data-color="purple" data-image="../Contents/img/sidebar-1.jpg">
            <div class="sidebar-wrapper">
                <div class="logo">
                    <a href="#" class="simple-text">
                       Sistema Electoral
                    </a>
                </div>

                <ul class="nav">
                    <li class="active">
                        <a data-toggle="collapse" href="#collapseExample" class="collapsed">
                            Parametricas
                            <b class="caret"> </b>
                        </a>
                     <div class="collapse" id="collapseExample">
                        <ul class="nav">
                            <li><a href="#">Instancia</a></li>
                            <li><a href="#">Coberturas</a></li>
                            <li><a href="#"></a></li>
                        </ul>
                    </div>
                    </li>
                </ul>
            </div>
        </div>

        <div class="main-panel">
            <nav class="navbar navbar-default navbar-fixed">
                <div class="container-fluid">
                    <div class="navbar-header">
                        <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navigation-example-2">
                            <span class="sr-only">Toggle navigation</span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                            <span class="icon-bar"></span>
                        </button>
                        <a class="navbar-brand" href="#">Instancia</a>
                    </div>
                    <div class="collapse navbar-collapse">
                        <ul class="nav navbar-nav navbar-left">
                            <li>
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <i class="fa fa-dashboard"></i>
                                </a>
                            </li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                    <i class="fa fa-globe"></i>
                                    <b class="caret"></b>
                                    <span class="notification">1</span>
                                </a>
                                <ul class="dropdown-menu">
                                    <li><a href="#">Notificacion </a></li>
                                    
                                </ul>
                            </li>
                            <li>
                                <a href="">
                                    <i class="fa fa-search"></i>
                                </a>
                            </li>
                        </ul>

                        <ul class="nav navbar-nav navbar-right">
                            <li>
                                <a href="">
                                    Cuenta
                                </a>
                            </li>
                            <li class="dropdown">
                                <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                   Opciones
                                    <b class="caret"></b>
                                </a>
                                <ul class="dropdown-menu">
                                    
                                    <li><a href="#">opcion 1</a></li>
                                    <li class="divider"></li>
                                    <li><a href="#">2</a></li>
                                </ul>
                            </li>
                            <li>
                                <a href="#">
                                    salir
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </nav>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            
            <div class="content">
                <div class="container-fluid">
                    <div class="row">
                        <div class="col-md-8">
                            <div class="card">
                                <div class="header">
                                    <h4 class="title">Instancias registradas</h4>
                                    <p class="category"></p>
                                </div>
                                <div class="content table-responsive" >
                                    
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click"/>
                                        </Triggers>

                                   <ContentTemplate>

                                   
                                     <asp:GridView runat="server" ID="Instancia_tabla" cssclass="table table-hover table-striped" >
                                       


                                    </asp:GridView>
                                       </ContentTemplate>
                                   </asp:UpdatePanel>
                                </div>
                            </div>
                        </div>                      
                    
                        <div class="col-md-4">
                            <div class="card">
                                <div class="header">
                                    <h4 class="title">Instancias</h4>
                                    <p class="category">Creacion de instancias </p>
                                </div>
                                <div class="content">
                               
                              
                                            <div class="form-group">
                                                <label>Instancia</label>
                                                <input type="text" class="form-control" id="Ins" placeholder="Instancia"  runat="server">
                                            </div>
                                             <div class="form-group">
                                                <label>Estado</label>
                                                <asp:DropDownList ID="Estado" runat="server" CssClass="btn dropdown-toggle dtn-desault btn-block">
                                                               
                                                 </asp:DropDownList>
                                            </div>
                                    
                                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-fill btn-info" Text="Agregar" OnClick="Button1_Click" />
                                    <div class="footer">

                                    </div>
                                </div>
                            </div>
                        </div>

                    
                    
                    </div>
                </div>
            </div>


            <footer class="footer">
                <div class="container-fluid">
                    <nav class="pull-left">
                        <ul>
                            <li>
                                <a href="#">
                                    Home
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    Company
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    Portfolio
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    Blog
                                </a>
                            </li>
                        </ul>
                    </nav>
                    <p class="copyright pull-right">
                        &copy; 2016 <a href="http://www.creative-tim.com">Creative Tim</a>, made with love for a better web
                    </p>
                </div>
            </footer>

        </div>
    </div>
    </form>
</body>
 



<!--   Core JS Files   -->
<script src="../Contents/js/jquery-1.10.2.js" type="text/javascript"></script>
<script src="../Contents/js/bootstrap.min.js" type="text/javascript"></script>

<!--  Checkbox, Radio & Switch Plugins -->
<script src="../Contents/js/bootstrap-checkbox-radio-switch.js"></script>

<!--  Charts Plugin -->
<script src="../Contents/js/chartist.min.js"></script>

<!--  Notifications Plugin    -->
<script src="../Contents/js/bootstrap-notify.js"></script>

<!--  Google Maps Plugin    -->
<script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?sensor=false"></script>

<!-- Light Bootstrap Table Core javascript and methods for Demo purpose -->
<script src="../Contents/js/light-bootstrap-dashboard.js"></script>

<!-- Light Bootstrap Table DEMO methods, don't include it in your project! -->
<script src="../Contents/js/demo.js"></script>


</html>
