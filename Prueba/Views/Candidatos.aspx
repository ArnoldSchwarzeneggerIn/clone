<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Candidatos.aspx.cs" Inherits="Prueba.Views.Candidatos" %>

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
    <script type="text/javascript" src="assets/js/plugins/uploaders/fileinput.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/uploaders/plupload/plupload.full.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/uploaders/plupload/plupload.queue.min.js"></script>

    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/uploader_bootstrap.js"></script>
    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/components_navs.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <!-- /theme JS files -->
    <script> function prueba() {
     _doPostBack('AS');
 }

    </script>

</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

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

                        <ul class="dropdown-menu dropdown-menu-right">
                            <li>
                                <%--  <asp:LinkButton ID="Salir" runat="server" OnClick="Salir_Click"> <i class="icon-switch2"></i>  Salir </asp:LinkButton>--%>
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
                                    <li><a href="Index.aspx"><i class="icon-home4"></i><span>Principal</span></a></li>
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
                                    <li class="active">
                                        <a href="#"><i class="icon-puzzle"></i><span>Parametricas</span></a>
                                        <ul>
                                            <li><a href="VCobertura.aspx">Cobertura</a></li>
                                            <li><a href="Causaderetiro.aspx">Causa de retiro</a></li>
                                            <li class="active"><a href="Instancias.aspx">Instancias</a></li>
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
                    <div class="page-header">
                        <div class="breadcrumb-line">
                            <ul class="breadcrumb">
                                <li><a href="Index.aspx"><i class="icon-home2 position-left"></i>Index/Instancia</a></li>
                            </ul>
                            <ul class="breadcrumb-elements">
                                <li><a data-toggle="modal" href="#Agregar_instancia"><i class="icon-add-to-list position-left"></i>Agregar Instancia</a></li>
                            </ul>



                        </div>
                    </div>
                    <!-- /page header -->


                    <!-- Content area -->
                    <div class="content">


                        <div class="row">
                            <div class="col-lg-8">

                                <div class="panel panel-flat">
                                    <div class="panel-heading">
                                        <h5 class="panel-title">Datos Convocatoria</h5>

                                        <div class="panel-body">
                                            <div class="row">
                                                <div class="row">
                                                    <div class="col-md-4">
                                                        <div class="form-group">
                                                            <label>Número convocatoria </label>
                                                            <asp:TextBox runat="server" ID="NumeroConvo" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <div class="form-group">
                                                            <label>Cargo</label>
                                                            <asp:TextBox runat="server" ID="cargo" CssClass="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </div>
                                                <br />
                                                <h5 class="panel-title">Datos persona</h5>
                                                <div class="row">

                                                    <div class="col-md-4">
                                                        <div class="form-group">
                                                            <label>Nombres <span class="text-danger">*</span></label>
                                                            <asp:TextBox runat="server" ID="Nombre" ValidateRequestMode="Disabled" Class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <div class="form-group">
                                                            <label>Apellidos</label>
                                                            <asp:TextBox runat="server" ID="Apellido" class="form-control" ValidateRequestMode="Disabled"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-4">
                                                        <div class="form-group">
                                                            <label>Identificación</label>
                                                            <asp:TextBox runat="server" ID="Identificacion" class="form-control" ValidateRequestMode="Disabled"></asp:TextBox>
                                                        </div>
                                                    </div>

                                                </div>
                                                <div class="row">
                                                    <div class="col-md-4">
                                                        <div class="form-group">
                                                            <label>Fecha inscripción</label>
                                                            <asp:TextBox runat="server" ID="fecha" Class="form-control"></asp:TextBox>
                                                        </div>
                                                    </div>
                                                    <div class="col-md-8">
                                                        <div class="form-group">
                                                            <label class="control-label col-lg-2">Observaciones</label>
                                                            <div>
                                                                <textarea rows="5" cols="5" class="form-control" placeholder="" id="obser" runat="server"></textarea>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div>
                            </div>
                            <div class="col-lg-4">

                                <div>
                                    <div>
                                        <div class="thumbnail no-padding">
                                            <div class="thumb">
                                                <img src="assets/images/placeholder.jpg" alt="" />
                                                <div class="caption-overflow">
                                                    <span>
                                                        <a href="assets/images/placeholder.jpg" class="btn bg-success-400 btn-icon btn-xs" data-popup="lightbox"><i class="icon-plus2"></i></a>
                                                        <a href="user_pages_profile.html" class="btn bg-success-400 btn-icon btn-xs"><i class="icon-link"></i></a>
                                                    </span>
                                                </div>
                                            </div>

                                            <div class="caption text-center">
                                                <h6 class="text-semibold no-margin">NOMBRE PISCO</h6>

                                            </div>
                                        </div>
                                    </div>
                                </div>

                            </div>


                           
                                

                            </div>


                        <div class="panel panel-flat">
                            <div class="datatable-scroll">
                                <table class="table datatable-basic dataTable no-footer" id="DataTables_Table_0" role="grid" aria-describedby="DataTables_Table_0_info">
                                    <thead>
                                        <tr role="row">
                                            <th class="sorting" tabindex="0" aria-controls="DataTables_Table_1" rowspan="1" colspan="1" aria-label="First Name: activate to sort column ascending">Nombre </th>
                                            <th class="sorting" tabindex="0" aria-controls="DataTables_Table_1" rowspan="1" colspan="1" aria-label="First Name: activate to sort column ascending">Estado</th>
                                            <th class="sorting" tabindex="0" aria-controls="DataTables_Table_1" rowspan="1" colspan="1" aria-label="First Name: activate to sort column ascending">Soporte</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <asp:ListView ID="requisitos" runat="server">
                                            <ItemTemplate>
                                                <tr role="row" class="">
                                                    <%--  <td class="sorting_1">
                                                        <asp:Label runat="server" ID="Label2" class="text-semibold" Text='<%#Eval("REQU_ID")%>'> </asp:Label>
                                                    </td>--%>

                                                    <td>
                                                        <asp:Label runat="server" ID="coberturaid" class="text-semibold" Text='<%#Eval("REQU_NOMBRE")%>'> </asp:Label>
                                                    </td>
                                                    <td>
                                                        <span class='label label-success'>
                                                            <asp:Label class="" data-toggle="dropdown" ID="Estadolabel" runat="server" Text='<%#Eval("REQU_ESTADO")%>'></asp:Label>
                                                        </span>

                                                    </td>
                                                    <td>
                                                        <span class='label label-success'>
                                                            <asp:Label class="" data-toggle="dropdown" ID="Label1" runat="server" Text='<%#Eval("REQU_SOPORTE")%>'></asp:Label>
                                                        </span>

                                                    </td>
                                                    
                                                      <td class="text-center">
										<ul class="icons-list">
											<li class="dropdown">
												<a href="#" class="dropdown-toggle" data-toggle="modal" data-target="#modal_default" >
													<i class="icon-file-plus" ></i>
												</a>

											<%--	<ul class="dropdown-menu dropdown-menu-right">
													<li><a href="#"><i class="icon-file-pdf"></i> Export to .pdf</a></li>
													<li><a href="#"><i class="icon-file-excel"></i> Export to .csv</a></li>
													<li><a href="#"><i class="icon-file-word"></i> Export to .doc</a></li>
												</ul>--%>
											</li>
										</ul>
									</td>

                                                  
                                                </tr>
                                            </ItemTemplate>
                                            <EditItemTemplate>

                                            </EditItemTemplate>
                                        </asp:ListView>

                                    </tbody>
                                </table>



                            </div>
                            </div>

                            <%--     <div>
                                <label class="control-label">Adjuntar archivos</label>
                                <asp:FileUpload ID="input24" name="input24[]" class="file-input" runat="server" />
                              
                                <script>
                                    $(document).on('ready', function () {
                                        $("#input24").fileinput({
                                            uploadUrl: "prueba()",
                                            initialPreview: [

                                            ],
                                            initialPreviewAsData: true,
                                            initialPreviewConfig: [

                                            ],
                                            deleteUrl: "/site/file-delete",
                                            overwriteInitial: false,
                                            maxFileSize: 100,
                                            initialCaption: "The Moon and the Earth"
                                        });
                                    });
                                </script>
                            </div>--%>


                            <div class="text-right">
                                <asp:Button runat="server" ID="Button" Class="btn btn-primary" Text="Guardar" OnClick="Button_Click" />
                            </div>
                            <div class="row">
                            </div>
                            <!-- Footer -->
                            <div class="footer text-muted">
                                &copy; 2016. <a href="#">Sistema electoral</a> by <a href="#" target="_blank">Giecom</a>
                            </div>
                            <!-- /footer -->

                        <!-- modal-->
                       <div id="modal_default" class="modal fade">
						<div class="modal-dialog">
							<div class="modal-content">
								<div class="modal-header">
									<button type="button" class="close" data-dismiss="modal">×</button>
									<h5 class="modal-title">Basic modal</h5>
								</div>

								<div class="modal-body">
									<h6 class="text-semibold">Cargue su documento</h6>
                                    <asp:FileUpload ID="FileUpload1" runat="server" class="file-input"/>
                                    <asp:Label ID="Label1" runat="server"></asp:Label>
									<hr/>
                                    

								
								</div>

								<div class="modal-footer">
									<button type="button" class="btn btn-link" data-dismiss="modal">Cerrar</button>
									<button type="button" class="btn btn-primary">Guardar</button>
								</div>
							</div>
						</div>
					</div>
                        <!-- /modal -->

                        </div>
                    </div>
                </div>
            </div>
            <!-- /content area -->
        </div>
        <!-- /main content -->
        </div>
        <!-- /page content -->
        </div>
   
    </form>
</body>
</html>
