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


    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/Calendario.js"></script>

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
						<img src="assets/images/placeholder.jpg" alt="" runat="server" id="imagen_Perfil">
						<span>
                            <asp:Label ID="Nombre1" runat="server" Text="Label"></asp:Label> 
						</span>
						<i class="caret"></i>
					</a>

					<ul class="dropdown-menu dropdown-menu-right">
						<li>
                           <asp:LinkButton ID="Salir" runat="server" OnClick="Salir_Click" > <i class="icon-switch2"></i>  Salir </asp:LinkButton>
						</li>
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
								<a href="#" class="media-left"><img src="" class="img-circle img-sm" alt="" runat="server" id="Imagen_perfil2"></a>
								<div class="media-body">
									<span class="media-heading text-semibold">
                                        <asp:Label ID="Nombre2" runat="server" Text="Label"></asp:Label>
									</span>
									<div class="text-size-mini text-muted">
										<i class="icon-pin text-size-small" >
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
                                <li class="active"><a href="#activity" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Candidatos </a></li>
                                <li><a href="#schedule" data-toggle="tab"><i class="icon-menu position-left"></i>Información  </a></li>
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
                                            <div class=" content-group">
                                                        <div class="panel panel-flat">
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
                                                                            </ul>
                                                                        </div>
                                                                    </div>

                                                                    <div class="panel-body">
                                                                        <div class="schedule">

                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
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


                                        </div>

                                        <div class="tab-pane fade" id="settings">

                                            <!-- Profile info -->
                                            <div class="panel panel-flat">
                                                <div class="panel-heading">
                                                    <h6 class="panel-title">Configuración de convocatoria</h6>
                                                    <div class="heading-elements">
                                                        <ul class="icons-list">
                                                            <li><a data-action="collapse"></a></li>
                                                            <li><a data-action="reload"></a></li>
                                                        </ul>
                                                    </div>
                                                </div>

                                                <div class="panel-body">
                                                        <div class="row">
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Titulo Convocatoria <span class="text-danger">*</span>  </label>
                                                                        <input type="text" class="form-control" placeholder="Titulo Convocatoria" runat="server" id="tituloconvo" required="required" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Inicio de inscripciones</label>
                                                                        <input type="date" class="form-control" runat="server" id="finscripcionconvo" required="required">
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label for="exampleInputEmail1">fin de inscripciones</label>
                                                                        <input type="date" class="form-control" placeholder="DD/MM/YY" runat="server" id="ffindeinscripcion">
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Publicacion candidatos habilitados</label>
                                                                        <input type="date" class="form-control" runat="server" id="candidatoshconvo" />
                                                                          </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Publicacion de jurados</label>
                                                                        <input type="date" class="form-control" runat="server" id="juradosconvoca">
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Publicacion de resultados</label>
                                                                        <input type="date" class="form-control" runat="server" id="resultadosconvo">
                                                                    </div>
                                                                </div>


                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-6">
                                                                    <div class="form-group">
                                                                        <label>Fecha elecciones presenciales</label>
                                                                        <input type="date" class="form-control" runat="server" id="epresenciaconvo" required>
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-6">
                                                                    <div class="form-group">
                                                                        <label>Fecha elecciones distancia </label>
                                                                        <input type="date" class="form-control" runat="server" id="edistanciaconvo">
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label>Observacion</label>
                                                                        <textarea rows="5" class="form-control" placeholder="Detalles" id="observacionconvo" runat="server"></textarea>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                        </div>

                                                        <div class="text-right">
                                                            <asp:Button ID="guardar" runat="server" Text="Guardar" CssClass="btn btn-primary" OnClick="guardar_Click" />
                                                        </div>
                                                   
                                                </div>
                                            </div>
                                            <!-- /profile info -->
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
