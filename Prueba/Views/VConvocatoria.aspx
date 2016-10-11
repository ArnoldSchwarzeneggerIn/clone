<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VConvocatoria.aspx.cs" Inherits="Prueba.Views.VConvocatoria" %>

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
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
	<!-- /theme JS files -->


</head>
<body>
  <form id="Formulario" runat="server">
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
				<div class="row">
                        <div class="panel panel-flat">
                        <div class="panel-heading">
									<h6 class="panel-title">Convocatoria</h6>
									<div class="heading-elements">
										<span class="label bg-success heading-text"> <asp:Label ID="NumeroR" runat="server" Text="Label"></asp:Label>  Registros</span>
                                        <ul class="icons-list">
                                      	    <li><a data-toggle="modal" href="#modal_form_vertical" title="Agregar"> <i class="icon-add"></i></a></li>
                                         </ul>
				                	</div>
								</div>     
                         <div class="panel-body">
                            Lista de convocatoria en la unoversidad de la amazonia 
                         </div>
        
                       <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
              
                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="Agregar" EventName="click" />
                                        </Triggers>

                                        <ContentTemplate>
                                            <asp:GridView runat="server" ID="Convocatoria_tabla" GridLines="None" CssClass="table" EmptyDataText="No se encontraron datos registrados" AllowPaging="True" OnPageIndexChanging="Convocatoria_tabla_PageIndexChanging" PageSize="10">
                                                <Columns>
                                          
                                                </Columns>
                                                <PagerStyle HorizontalAlign = "Right" CssClass = "" />

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









  <div id="modal_form_vertical" class="modal fade">
						<div class="modal-dialog">
							<div class="modal-content">
								<div class="modal-header">
									<button type="button" class="close" data-dismiss="modal" onclick="limpiar_form('IdConvocatoria');" >&times;</button>
									<h5 class="modal-title">Agregar Convocatoria</h5>
								</div>
									<div class="modal-body" id="IdConvocatoria">
                                    <div class="row">
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label> Titulo Convocatoria</label>
                                                <input type="text" class="form-control"  placeholder="Titulo Convocatoria" runat="server" id="Numero">
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label>Inicio de inscripciones</label>
                                                <input type="date" class="form-control" placeholder="DD/MM/YY" runat="server" id="Fechai" >
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label for="exampleInputEmail1">fin de inscripciones</label>
                                                <input type="date" class="form-control" placeholder="DD/MM/YY" runat="server" id="FechaFin">
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label>Publicacion candidatos habilitados</label>
                                                <input type="date" class="form-control" runat="server" id="fechaCandidatos">
                                            </div>
                                        </div>
                                        <div class="col-md-4">
                                            <div class="form-group">
                                                <label> Publicacion de jurados</label>
                                                <input type="date" class="form-control"  runat="server" id="Fechajuradoa">
                                            </div>
                                        </div>
                                         <div class="col-md-4">
                                            <div class="form-group">
                                                <label> Publicacion de resultados</label>
                                                <input type="date" class="form-control"  runat="server" id="Fecharesulta">
                                            </div>
                                        </div>


                                    </div>

                                    <div class="row">
                                        <div class="col-md-6">
                                            <div class="form-group">
                                                <label>Fecha elecciones presenciales</label>
                                                <input type="date" class="form-control" runat="server" id="FechaE">
                                            </div>
                                        </div>
                                         <div class="col-md-6">
                                            <div class="form-group">
                                                <label> Fecha elecciones distancia </label>
                                                <input type="date" class="form-control" runat="server" id="FechaEdis">
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col-md-12">
                                            <div class="form-group">
                                                <label>Observacion</label>
                                                <textarea rows="5" class="form-control" placeholder="Detalles" id="Observacion" runat="server"></textarea>
                                            </div>
                                        </div>
                                    </div>
                                    </div>


                                   
									<div class="modal-footer">
									   <button type="button" class="btn btn-link" data-dismiss="modal" onclick="limpiar_form('IdConvocatoria');" >Cerrar</button>
                                       <asp:Button ID="Agregar" runat="server" Text="Agregar" CssClass="btn btn-info btn-fill pull-right" OnClick="Agregar_Click" data-dismiss="modal" UseSubmitBehavior="false"   />
                                    </div>
							</div>
						</div>
					</div>
  </form>
  
</body>
   
</html>
