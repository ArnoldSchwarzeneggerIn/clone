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
    <script>
        function guardar() {
            var form = documnet.getElementById("Formulario");
            document.getElementById('<%=Agregar.ClientID%>').click();
        }
    </script>

    <script>
        $(function () {
            $("#Formulario").validate({

                onfocusout: function (tituloconvo) {
                    $(tituloconvo).valid()

                },
                onfocusout: function (finscripcionconvo) {
                    $(finscripcionconvo).valid();
                },
                onkeyup: false,
                onfocusout: function (ffindeinscripcion) {
                    $(ffindeinscripcion).valid();
                },
                onfocusout: function (candidatoshconvo) {
                    $(candidatoshconvo).valid();
                },
                onfocusout: function (juradosconvoca) {
                    $(juradosconvoca).valid();
                },
                onfocusout: function (resultadosconvo) {
                    $(resultadosconvo).valid();
                },
                onfocusout: function (epresenciaconvo) {
                    $(epresenciaconvo).valid();
                },
                onfocusout: function (edistanciaconvo) {
                    $(epresenciaconvo).valid();
                },
                onfocusout: function (observacionconvo) {
                    $(observacionconvo).valid();
                },







                errorClass: 'validation-error-label',
                successClass: 'validation-valid-label',
                highlight: function (element, errorClass) {
                    $(element).removeClass(errorClass);
                },
                unhighlight: function (element, errorClass) {
                    $(element).removeClass(errorClass);
                },
                errorPlacement: function (error, element) {
                    if (element.parents('div').hasClass("checker") || element.parents('div').hasClass("choice") || element.parent().hasClass('bootstrap-switch-container')) {
                        if (element.parents('label').hasClass('checkbox-inline') || element.parents('label').hasClass('radio-inline')) {
                            error.appendTo(element.parent().parent().parent().parent());
                        }
                        else {
                            error.appendTo(element.parent().parent().parent().parent().parent());
                        }
                    }
                    else if (element.parents('div').hasClass('checkbox') || element.parents('div').hasClass('radio')) {
                        error.appendTo(element.parent().parent().parent());
                    }
                    else if (element.parents('label').hasClass('checkbox-inline') || element.parents('label').hasClass('radio-inline')) {
                        error.appendTo(element.parent().parent());
                    }
                    else if (element.parent().hasClass('uploader') || element.parents().hasClass('input-group')) {
                        error.appendTo(element.parent().parent());
                    }
                    else {
                        error.insertAfter(element);
                    }
                },
                rules: {
                    "tituloconvo": {
                        required: true,
                        minlength: 5
                    },
                    "finscripcionconvo": {
                        required: true,
                    },
                    "ffindeinscripcion": {
                        required: true,
                    },
                    "candidatoshconvo": {
                        required: true,
                    },
                    "juradosconvoca": {
                        required: true,
                    },
                    "resultadosconvo": {
                        required: true,
                    },
                    "epresenciaconvo": {
                        required: true,
                    },
                    "edistanciaconvo": {
                        required: true,
                    },
                    "observacionconvo": {
                        required: true,
                    }
                },
                messages: {
                    "tituloconvo": {
                        required: "Datos no validos",
                        minlength: "Ingrese un nombre mas largo"
                    },
                    "finscripcionconvo": {
                        required: "Datos no validos",
                    },
                    "ffindeinscripcion": {
                        required: "Datos no validos",
                    },
                    "candidatoshconvo": {
                        required: "Datos no validos",
                    },
                    "juradosconvoca": {
                        required: "Datos no validos",
                    },
                    "resultadosconvo": {
                        required: "Datos no validos",
                    },
                    "epresenciaconvo": {
                        required: "Datos no validos",
                    },
                    "edistanciaconvo": {
                        required: "Datos no validos",
                    },
                    "observacionconvo": {
                        required: "Datos no validos",
                    }
                }


            });
        });
    </script>
    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/jasny_bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/validation/validate.min.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
    <script type="text/javascript" src="assets/js/pages/wizard_steps.js"></script>

    <!-- /theme JS files -->


</head>
<body>
    <form id="Formulario" runat="server">
        <!-- Main navbar -->
        <div class="navbar navbar-inverse">
            <div class="navbar-header">
                <a class="navbar-brand" href="index.aspx">
                    <img src="assets/images/si.png" style="width:11em; height:1.5em;">
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
                           <asp:LinkButton ID="Salir" runat="server" OnClick="Salir_Click" > <i class="icon-switch2"></i>  Salir </asp:LinkButton>
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
                        </div>

                        <div class="breadcrumb-line">
                            <ul class="breadcrumb">
                                <li><a href="index.aspx"><i class="icon-home2 position-left"></i>Index</a></li>

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
                                <li class="active"><a href="#convocatorias" data-toggle="tab"><i class="icon-menu7 position-left"></i>Convocatorias </a></li>
                                <li><a href="#registro" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Registrar convocatoria  </a></li>
                            </ul>
                        </div>
                    </div>





                    <!-- Content area -->
                    <div class="content">

                        <div class="row">
                            <div class="col-lg-12">
                                <div class="tabbable">
                                    <div class="tab-content">
                                        <div class="tab-pane fade in active" id="convocatorias">
                                            <div class="panel ">
                                                <div class="panel-heading">
                                                    <h6 class="panel-title">Convocatoria</h6>
                                                    <div class="heading-elements">
                                                        <span class="label bg-success heading-text">
                                                            <asp:Label ID="NumeroR" runat="server" Text="Label"></asp:Label>
                                                            Registros</span>
                                                        <ul class="icons-list">
                                                            <li><a data-toggle="modal" href="#Modal2" title="Agregar"><i class="icon-add"></i></a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="panel-body">
                                                    Lista de convocatoria en la Uniamazonia
                                            <br />


                                                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="Agregar" EventName="click" />
                                                        </Triggers>
                                                        <ContentTemplate>
                                                            <asp:ListView ID="ListaConvocatoria" runat="server">
                                                                <ItemTemplate>
                                                                    <div class="col-md-6">
                                                                        <div class="thumbnail">
                                                                            <div class="thumb">
                                                                                <img src="assets/images/r.jpg" alt="">
                                                                            </div>

                                                                            <div class="caption">
                                                                                <h6 class="text-semibold no-margin-top text-uppercase">
                                                                                    <asp:Label ID="tituloconv" runat="server" Text='<%#Eval("TituloCovocatoria")%>'> </asp:Label>
                                                                                </h6>
                                                                                <asp:Label ID="descripcionconv" CssClass="text-uppercase" runat="server" Text='<%#Eval("DescripcionConvocatoria") %>'></asp:Label>

                                                                                <div class="row">
                                                                                    <div class="col-sm-6">
                                                                                        <h6 class="text-semibold no-margin-top"></h6>
                                                                                        <ul class="list list-unstyled">
                                                                                            <li>Fecha inicio de inscripcion:</li>
                                                                                            <li>
                                                                                                <%#Eval("Fechainicioinscripcion")%>
                                                                                            </li>
                                                                                            <li>Fecha limite de inscripcion:
                                                                                            </li>
                                                                                            <li>
                                                                                                <%#Eval("Fechafininscripcion")%>
                                                                                            </li>
                                                                                        </ul>
                                                                                    </div>

                                                                                    <div class="col-sm-6">
                                                                                        <h6 class="text-semibold text-right no-margin-top"></h6>
                                                                                        <ul class="list list-unstyled text-right">
                                                                                            <li>Estado: <span class="text-semibold"><%#Eval("estado") %></span></li>
                                                                                        </ul>
                                                                                    </div>
                                                                                </div>


                                                                            </div>

                                                                            <div class="panel-footer">
                                                                                <ul>
                                                                                    <li>
                                                                                        <a href="#"><i class="icon-thumbs-up3 position-left"></i></a>
                                                                                    </li>
                                                                                    <li>
                                                                                        <asp:LinkButton ID="Verconvocatoria" runat="server" CssClass="icon-eye8" CommandArgument='<%#Eval("IDCONVOCATORIA")%>' OnCommand="Verconvocatoria_Command"> </asp:LinkButton>
                                                                                    </li>
                                                                                </ul>
                                                                            </div>
                                                                        </div>
                                                                    </div>
                                                                </ItemTemplate>
                                                            </asp:ListView>
                                                        </ContentTemplate>
                                                    </asp:UpdatePanel>
                                                </div>
                                            </div>
                                        </div>

                                        <div class="tab-pane fade" id="registro">
                                            <div class="panel">
                                                <div class="steps-basic">
                                                    <h6>Registro convocatoria</h6>
                                                    <fieldset>
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
                                                                        <input type="date" class="form-control" runat="server" id="candidatoshconvo">
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
                                                    </fieldset>

                                                    <h6>Instancias</h6>
                                                    <fieldset>
                                                    </fieldset>

                                                </div>


                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <asp:Button ID="Agregar" runat="server" Text="Button" OnClick="Agregar_Click" Style="display:none;" />
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
    </form>
</body>
</html>
