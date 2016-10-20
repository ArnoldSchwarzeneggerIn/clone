<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VCobertura.aspx.cs" Inherits="Prueba.Views.VCobertura" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head> 
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

    


	<!-- /theme JS files -->
</head>
<body>
    <form id="form1" runat="server" class="">
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
								<li ><a href="Index.aspx"><i class="icon-home4"></i> <span>Principal</span></a></li>
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
                                <li class="active">
									<a href="#"><i class="icon-puzzle"></i> <span>Parametricas</span></a>
									<ul>
										<li class="active"><a href="VCobertura.aspx">Cobertura</a></li>
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
									<h6 class="panel-title">Cobertura de instancia</h6>
									<div class="heading-elements">
										<span class="label bg-success heading-text"> <asp:Label ID="NumeroR" runat="server" Text="Label"></asp:Label>  Registros</span>
                                        <ul class="icons-list">
                                      	    <li><a data-toggle="modal" href="#modal_form_vertical" title="Agregar"> <i class="icon-add"></i></a></li>
                                         </ul>
				                	</div>
								</div>     
                         <div class="panel-body">
                            Las coberturas es el rango de alcanse de una instancia en la universidad de la amazonia ejemplo programa,universidad, solo distancia Etc
						</div>
        
                       <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                        <Triggers>
                                            <asp:AsyncPostBackTrigger ControlID="AgregarCober" EventName="Click"/>
                                        </Triggers>

                                   <ContentTemplate>

                                   
                                     <asp:GridView runat="server" ID="Cobertura_t" cssclass="table text-nowrap" AutoGenerateColumns="false" DataKeyNames="IDCOBERTURA" OnRowCancelingEdit="Cobertura_t_RowCancelingEdit" OnRowEditing="Cobertura_t_RowEditing" OnRowUpdating="Cobertura_t_RowUpdating" EmptyDataText="No se han registrado datos" GridLines="None" >
                                       <Columns>
                                           <asp:TemplateField HeaderText="ID">
                                                <EditItemTemplate>
                                                            <asp:TextBox ID="id" runat="server" Enabled="false" CssClass="form-control" Text='<%# Eval("IDCOBERTURA") %>'></asp:TextBox>
                                               </EditItemTemplate>
                                                <ItemTemplate>
                                                         <asp:Label ID="idl" runat="server" Text='<%# Eval("IDCOBERTURA") %>' ></asp:Label>
                                               </ItemTemplate>
                                           </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Nombre">
                                                <EditItemTemplate>
                                                       <asp:TextBox ID="Nombre" runat="server" CssClass="form-control" Enabled="true" Text='<%# Eval("NOMBRECOBERTURA") %>'></asp:TextBox>
                                               </EditItemTemplate>
                                                <ItemTemplate>
                                                         <asp:Label ID="Nombrel" runat="server" Text='<%# Eval("NOMBRECOBERTURA") %>'></asp:Label>
                                               </ItemTemplate>
                                           </asp:TemplateField>

                                              <asp:TemplateField HeaderText="Estado">
                                                <EditItemTemplate>
                                                      <asp:DropDownList ID="estado" runat="server" CssClass="select2-choice">
                                                                <asp:ListItem Value="ACTIVO">ACTIVO</asp:ListItem>
                                                                <asp:ListItem Value="INACTIVO">INACTIVO</asp:ListItem>
                                                            </asp:DropDownList>

                                               </EditItemTemplate>
                                                <ItemTemplate>
                                                         <asp:Label ID="Estadol" runat="server" Text='<%# Eval("ESTADOCOBERTURA") %>'></asp:Label>
                                               </ItemTemplate>
                                           </asp:TemplateField>

                                           <asp:CommandField  ShowEditButton="true"/>

                                       </Columns>


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
									<button type="button" class="close" data-dismiss="modal" onclick="limpiar_textbox('cober');" >&times;</button>
									<h5 class="modal-title">Agregar cobertura</h5>
								</div>
									<div class="modal-body">
                                            <div class="form-group">
                                                <label>cobertura</label>
                                                <input type="text" class="form-control" id="cober" placeholder="Cobertura"  runat="server" required="required" pattern="[a-z]"  title="Ingrese solo letras" >
                                            </div>
                                    </div>
									<div class="modal-footer">
									   <button type="button" class="btn btn-link" data-dismiss="modal" onclick="limpiar_textbox('cober');" >Cerrar</button>
                                       <asp:Button ID="AgregarCober" runat="server" CssClass="btn btn-fill btn-info" Text="Agregar" OnClick="AgregarCober_Click"  data-dismiss="modal" UseSubmitBehavior="false" />
                                    </div>
							</div>
						</div>
					</div>
      
        
    
                       
    
    </form>
</body>
 </html>
