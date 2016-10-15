<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Votar.aspx.cs" Inherits="Prueba.Views.Votar" %>

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
	<script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
	<script type="text/javascript" src="assets/js/plugins/forms/selects/select2.min.js"></script>
	<script type="text/javascript" src="assets/js/plugins/forms/styling/uniform.min.js"></script>
	<script type="text/javascript" src="assets/js/core/libraries/jasny_bootstrap.min.js"></script>
	<script type="text/javascript" src="assets/js/plugins/forms/validation/validate.min.js"></script>
	<script type="text/javascript" src="assets/js/plugins/extensions/cookie.js"></script>

	<script type="text/javascript" src="assets/js/core/app.js"></script>
	<script type="text/javascript" src="assets/js/pages/wizard_steps.js"></script>

</head>

<body>

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
								<li class="active"><a href="Index.aspx"><i class="icon-home4"></i> <span>Principal</span></a></li>
								<li>
									<a href="#"><i class="icon-stack2"></i> <span>Convocatorias</span></a>
									<ul>
										<li><a href="VConvocatoria.aspx">Gestionar convocatoria</a></li>
                                        <li><a href="#">Lanzar convocatoria</a></li>
									</ul>
								</li>
                                <li>
									<a href="#"><i class="icon-vcard"></i> <span>Candidatos</span></a>
									<ul>
										<li><a href="VCandidato.aspx">Gestionar candidatos</a></li>
                                        <li><a href="#">Mi candidatura</a></li>
									</ul>
								</li>
                                <li>
									<a href="#"><i class="icon-puzzle"></i> <span>Parametricas</span></a>
									<ul>
										<li><a href="VCobertura.aspx">Cobertura</a></li>
                                        <li><a href="Causaderetiro.aspx">Causa de retiro</a></li>
                                        <li><a href="Instancias.aspx">Instancias</a></li>
                                        <li><a href="InstancConformacion.aspx">Instancia conformacion</a></li>
									</ul>
								</li>
                                 <li>
									<a href="#"><i class="icon-stack-text"></i> <span>Votaciones</span></a>
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
							<li><a href="Index.aspx"><i class="icon-home2 position-left"></i> Index</a></li>
						</ul>
					</div>
				</div>
				<!-- /page header -->


				<!-- Content area -->
				<div class="content">
                       <div class="panel panel-white">
						<div class="panel-heading">
							<h6 class="panel-title">Tarjeton </h6>
							<div class="heading-elements">
								<ul class="icons-list">
			                		
			                		<li><a data-action=""></a></li>
			                	</ul>
		                	</div>
						</div>

	                	<form class="steps-basic" action="#">
							<h6>Instancia uno</h6>
							<fieldset>
	                  <div class="row">
						<div class="col-lg-3 col-md-6">
							<div class="thumbnail no-padding">
								<div class="thumb">
									<img src="assets/images/placeholder.jpg" alt="">
									<div class="caption-overflow">
										<span>
											<a href="assets/images/placeholder.jpg" class="btn bg-success-400 btn-icon btn-xs" data-popup="lightbox"><i class="icon-plus2"></i></a>
											<a href="user_pages_profile.html" class="btn bg-success-400 btn-icon btn-xs"><i class="icon-link"></i></a>
										</span>
									</div>
								</div>
							
						    	<div class="caption text-center">
						    		<h6 class="text-semibold no-margin">Candidato 1 <small class="display-block">Candiato</small></h6>
					    			<ul class="icons-list mt-15">
                                    
                                    </ul>
						    	</div>
					    	</div>
						</div>
                          </div>
							</fieldset>

							<h6>Instancia dos</h6>
							<fieldset>
							
							</fieldset>

							<h6>Instancia tres</h6>
							<fieldset>
							</fieldset>
						</form>
		            </div>
		            <!-- /basic setup -->


		      

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

</body>
</html>

