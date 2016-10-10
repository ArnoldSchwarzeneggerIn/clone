<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Causaderetiro.aspx.cs" Inherits="Prueba.Views.Causaderetiro" %>

<!DOCTYPE html>

<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1">
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
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
	<!-- /theme JS files -->

    


	<!-- /theme JS files -->

</head>

<body>
    <form runat="server" id="Form1">

    
	<!-- Main navbar -->
	<div class="navbar navbar-inverse">
		<div class="navbar-header">
			<a class="navbar-brand" href="index.html"><img src="assets/images/logo_light.png" alt=""></a>

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
						<li><a href="#"><i class="icon-switch2"></i> Salir</a></li>
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
								<a href="#" class="media-left"><img src="assets/images/placeholder.jpg" class="img-circle img-sm" alt=""></a>
								<div class="media-body">
									<span class="media-heading text-semibold">Electoral</span>
									<div class="text-size-mini text-muted">
										<i class="icon-pin text-size-small" > Prueba Token</i> 
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
								<li><a href="Index.aspx"><i class="icon-home4"></i> <span>Principal</span></a></li>
								<li>
									<a href="#"><i class="icon-stack2"></i> <span>Convocatorias</span></a>
									<ul>
										<li><a href="layout_navbar_fixed.html">Gestionar convocatoria</a></li>
                                        <li><a href="layout_navbar_fixed.html">Lanzar convocatoria</a></li>
									</ul>
								</li>
                                <li>
									<a href="#"><i class="icon-vcard"></i> <span>Candidatos</span></a>
									<ul>
										<li><a href="layout_navbar_fixed.html">Gestionar candidatos</a></li>
                                        <li><a href="layout_navbar_fixed.html">Mi candidatura</a></li>
									</ul>
								</li>
                                <li class="active">
									<a href="#"><i class="icon-puzzle"></i> <span>Parametricas</span></a>
									<ul>
										<li class="active"><a href="layout_navbar_fixed.html">Cobertura</a></li>
                                        <li><a href="Causaderetiro.aspx">Causa de retiro</a></li>
                                        <li><a href="layout_navbar_fixed.html">Instancias</a></li>
                                        <li><a href="layout_navbar_fixed.html">Instancia conformacion</a></li>
									</ul>
								</li>
                                 <li>
									<a href="#"><i class="icon-stack-text"></i> <span>Votaciones</span></a>
									<ul>
										<li><a href="layout_navbar_fixed.html">Votar</a></li>
                                        <li><a href="layout_navbar_fixed.html">Resultados</a></li>
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
							<li><a href="Index.aspx"><i class="icon-home2 position-left"></i> Index</a></li>
						</ul>
					</div>
				</div>
				<!-- /page header -->


				<!-- Content area -->
				<div class="content">
				<div class="row">
                        <div class="panel panel-flat">
                        <div class="panel-heading">
									<h6 class="panel-title">Causa de retiro</h6>
									<div class="heading-elements">
										<span class="label bg-success heading-text"> <asp:Label ID="NumeroR" runat="server" Text="Label"></asp:Label>  Registros</span>
                                        <ul class="icons-list">
                                      	    <li><a data-toggle="modal" href="#modal_form_vertical" title="Agregar"> <i class="icon-add"></i></a></li>
                                         </ul>
				                	</div>
								</div>
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server" >
                               <Triggers>
                                   <asp:AsyncPostBackTrigger  ControlID="AgregarCausa" EventName="click"/>
                               </Triggers>
                                 <ContentTemplate>
                                   <asp:GridView ID="Causaretiro" runat="server" EmptyDataText="No se encontraron registros" CssClass="table datatable-basic" GridLines="None">
                              </asp:GridView>
                              </ContentTemplate>
                            </asp:UpdatePanel>
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
        <!--Ventana modal Formulario registro -->
   	<div id="modal_form_vertical" class="modal fade">
						<div class="modal-dialog">
							<div class="modal-content">
								<div class="modal-header">
									<button type="button" class="close" data-dismiss="modal" onclick="limpiar_textbox('Causar');" >&times;</button>
									<h5 class="modal-title">Agregar causa de retiro</h5>
								</div>
									<div class="modal-body">
                                       <div class="form-group">
                                                <label>Causa retiro</label>
                                                <input type="text" class="form-control" id="Causar" placeholder="Causa retiro"  runat="server">
                                            </div>
									</div>
									<div class="modal-footer">
									   <button type="button" class="btn btn-link" data-dismiss="modal" onclick="limpiar_textbox('Causar');" >Cerrar</button>
                                       <asp:Button ID="AgregarCausa" runat="server" CssClass="btn btn-fill btn-info" Text="Agregar" OnClick="AgregarCausa_Click" data-dismiss="modal" UseSubmitBehavior="false" />
                                    </div>
							</div>
						</div>
					</div>





    </form>
</body>
</html>

