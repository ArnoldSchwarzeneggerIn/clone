<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Candidaturayy.aspx.cs" Inherits="Prueba.Views.Candidatos" %>

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

    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/uploader_bootstrap.js"></script>
    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/pages/components_navs.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <!-- /theme JS files -->
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
                                            <div class="col-md-4">
                                                <img src="" class="img-circle " alt="" runat="server" id="Img2" />
                                            </div>
                                        </div>
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
                                                    <asp:TextBox runat="server" ID="fecha" Class="form-control"  ></asp:TextBox>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                      <div class="form-group">
										<label class="control-label col-lg-2">Observaciones</label>
										<div class="col-lg-10">
											<textarea rows="5" cols="5" class="form-control" placeholder="" id="obser" runat="server"></textarea>
										</div>
									</div>
                                </div>

                              

                                <div class="datatable-scroll">
                                    <table class="table datatable-basic dataTable no-footer" id="DataTables_Table_0" role="grid" aria-describedby="DataTables_Table_0_info">

                                        <tbody>

                                            <asp:ListView ID="requisitos" runat="server">
                                                <ItemTemplate>
                                                    <tr role="row" class="">
                                                        <td class="sorting_1">
                                                            <asp:Label runat="server" ID="Label2" class="text-semibold" Text='<%#Eval("REQU_ID")%>'> </asp:Label>
                                                        </td>

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
                                                        <td>
                                                            <ul>

                                                                <div class="form-group">
                                                                    <label class="col-lg-2 control-label text-semibold"></label>
                                                                    <div class="col-lg-10">
                                                                        <input type="file" id="file1" class="file-input" data-show-preview="false">
                                                                        <span class="help-block"></span>
                                                                    </div>
                                                                </div>

                                                                <%--  <div class="btn btn-primary btn-xs btn-icon btn-file"> 

                                                                      <i class="icon-plus22"></i>
                                                                      <input  type="file" class="file-input" data-show-caption="false" data-show-upload="false" data-browse-class="btn btn-primary btn-xs btn-icon" data-remove-clas="btn btn-danger btn-xs btn-icon"/>
                                                                  </div>--%>
                                                            </ul>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                                <EditItemTemplate>
                                                    <tr role="row" class="">
                                                        <td class="sorting_1">
                                                            <asp:TextBox ID="nombre" CssClass="form-control" runat="server"></asp:TextBox>
                                                        </td>
                                                        <td>
                                                            </td>
                                                        <td>
                                                            <asp:DropDownList ID="COberItem" runat="server" CssClass="form-control">
                                                            </asp:DropDownList>
                                                        </td>
                                                        <td>
                                                            <span class='label label-success'>
                                                                <asp:DropDownList ID="EstadoInst" runat="server" CssClass="form-control">
                                                                    <asp:ListItem Value=""> Seleccione</asp:ListItem>
                                                                    <asp:ListItem Value="ACTIVO"> ACTIVO</asp:ListItem>
                                                                    <asp:ListItem Value="INACTIVO">INACTIVO </asp:ListItem>
                                                                </asp:DropDownList>
                                                            </span>

                                                        </td>
                                                        <td class="text-center">
                                                            <ul class="icons-list">
                                                                <li>
                                                                    <asp:LinkButton ID="Actualizar" runat="server" Text="Actualizar" CommandName="Update" title data-original-title="Guardar">
                                                                            <i class="icon-floppy-disk"  ></i>
                                                                        </asp:LinkButton>
                                                                </li>
                                                                <li>
                                                                    <asp:LinkButton ID="Cancelar" runat="server" Text="Cancelar" CommandName="Cancel" title data-original-title="Cancelar">
                                                                          <i class="icon-cancel-square" ></i>
                                                                        </asp:LinkButton>
                                                                </li>
                                                            </ul>
                                                        </td>
                                                    </tr>
                                                </EditItemTemplate>
                                            </asp:ListView>
                                        </tbody>
                                    </table>
                                </div>
                                <div class="text-right">
                                    <asp:Button runat="server" ID="Button" Class="btn btn-primary" Text="Guardar" OnClick="Button_Click"/>
                                </div>
                                <div class="row">
                                </div>
                                <!-- Footer -->
                                <div class="footer text-muted">
                                    &copy; 2016. <a href="#">Sistema electoral</a> by <a href="#" target="_blank">Giecom</a>
                                </div>
                                <!-- /footer -->

                                <div id="modal_form_vertical" class="modal fade">
                                    <div class="modal-dialog">
                                        <div class="modal-content">
                                            <div class="modal-header">
                                            </div>

                                            <div class="modal-footer">
                                            </div>
                                        </div>
                                    </div>

                                </div>
                                <div id="Agregar_instancia" class="modal fade">
                                </div>
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
