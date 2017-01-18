<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VConvocatoria.aspx.cs" Inherits="Prueba.Views.VConvocatoria" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <title>Sistema Electoral</title>




    <!--Organizando los datos de la seleccion de los cargo-->
    <style>
        .invisible{
            display:none;
        }

        .flotarIzquierda{
            float:left;
        }

        .camuflaje {
            color: rgba(252, 252, 252,0.0);
        }


         .buttl2 {
            /*margin-left:90%;*/
            float: left;
            padding-top: 0.7em;
            padding-bottom: 0.6em;
            padding-left: 1.8em;
            padding-right: 1.8em;
            background-color: #26A69A;
            color: white;
            border: none;
            border-bottom-right-radius:20%;
            border-top-right-radius:20%;
            
            /*clear: both;*/
            font-weight: bold;
        }

        .butt {
            margin-top: 5%;
            margin-bottom: 5%;
            /*margin-left:90%;*/
            float: right;
            padding-top: 0.8em;
            padding-bottom: 0.8em;
            padding-left: 1.8em;
            padding-right: 1.8em;
            background-color: #26A69A;
            color: white;
            border: none;
            border-radius: 8%;
            /*clear: both;*/
            font-weight: bold;
        }

        .buttE {
            margin-top: 5%;
            /*margin-left:90%;*/
            float: right;
            padding-top: 0.8em;
            padding-bottom: 0.8em;
            padding-left: 1.8em;
            padding-right: 1.8em;
            background-color: red;
            color: white;
            border: none;
            border-radius: 8%;
            font-weight: bold;
        }

        .hTittle {
            color: white;
            font-size: 1em;
            text-align: center;
        }

        .widget-header + .widget-content {
            border-top: none;
            -webkit-border-top-left-radius: 0;
            -webkit-border-top-right-radius: 0;
            -moz-border-radius-topleft: 0;
            -moz-border-radius-topright: 0;
            border-top-left-radius: 0;
            border-top-right-radius: 0;
        }



        .widget-content {
            padding: 20px 15px 15px;
            background: #FFF;
            border: 1px solid #D5D5D5;
            -moz-border-radius: 5px;
            -webkit-border-radius: 5px;
            border-radius: 5px;
            zoom: 1;
        }



        /*
    .widget-content:before, .widget-content:after {
    content: "";
    display: table;
}



        .widget-content:after {
    content: "";
    display: table;
        clear: both;
}*/



        .widget-header {
            background-color: #26A69A;
            position: relative;
            height: 40px;
            line-height: 40px;
            /*background: -webkit-linear-gradient(top, #f9f6f1 0%,#f2efea 100%);*/
            border: 1px solid #d6d6d6;
        }

        .widget {
            position: relative;
            clear: both;
            width: auto;
            margin-bottom: 2em;
            overflow: hidden;
        }

        .accordion-group {
            margin-bottom: 2px;
            border: 1px solid #e5e5e5;
            -webkit-border-radius: 4px;
            -moz-border-radius: 4px;
            border-radius: 4px;
        }

        /*.accordion-heading .accordion-toggle {
            display: block;
            padding: 8px 15px;
        }*/

        .accordion-heading {
            /*color: #545454;*/
            color: white;
            text-decoration: none;
            font-weight: bold;
            display: block;
            padding: 8px 15px;
            background-color: #26A69A;
            /*background-color:black;*/
        }

            .accordion-heading a {
                /*color: #545454;*/
                color: white;
                text-decoration: none;
                font-weight: bold;
            }



        .accordion-inner {
            padding: 9px 15px;
            border-top: 1px solid #e5e5e5;
        }



        .ArregloCheckCargos {
            margin-left: 5px;
        }

        .ArregloLabelCargos {
            margin-left: 20px;
        }

        .ArregloDropDownListCargos {
            float: right;
            margin-right: 100px;
        }


        .ui-datepicker-calendar {
            display: none;
        }
    </style>







    <!-- Global stylesheets -->
  <%--  <link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css">--%>
    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css">

    <!-- Fileinput-->
    <link href="../css/fileinput.css" media="all" rel="stylesheet" type="text/css" />
    <%--/Fileinput--%>

    <link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css">
    <!-- /global stylesheets -->

    <!-- Core JS files -->
    <%--<script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>--%>
    <script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>
    <script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>
    <script src="http://code.jquery.com/ui/1.9.1/jquery-ui.js"></script>

    <!-- Fileinput-->
    <script src="../js/fileinput.js" type="text/javascript"></script>
    <!--/Fileinput-->


    <!-- /core JS files -->

    <!-- Theme JS files -->
    <script type="text/javascript" src="assets/js/core/app.js"></script>
    <%-- <script type="text/javascript" src="assets/js/core/libraries/jasny_bootstrap.min.js"></script>--%>
    <%--no deja mostrar el fileuploap dentro de un tab con steps.js en otro lugar si funciona---%>
    <script type="text/javascript" src="assets/js/plugins/forms/validation/validate.min.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
    <script type="text/javascript" src="assets/js/pages/wizard_steps.js"></script>
    <script type="text/javascript" src="assets/js/plugins/forms/wizards/steps.min.js"></script>
    <%--No deja lanzar la alerta--%>

    <!-- /Theme JS files -->





    <%--    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>--%>

    <%--<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js" type="text/javascript"></script>--%>






    <%--avoid resubmit of data from form--%>
    <%--  <script type="text/javascript">
        if (history.forward(1)) {
            location.replace(history.forward(1));
        }
    </script>--%>

    <%--end avoid resubmit of data from form--%>


    <%-- Script to called server from aspx --%>
    <%-- <script runat="server">
        protected void CNmroCnvt()
        {
            string s = FRegistro.Value;
            NConv.Value = Numero(s);
        }
    </script>--%>
    <%-- End Script to called server from aspx --%>



    <script>
        function CambiarDocumento(){
            
            x = document.getElementById('FileUpload2');
            x.click();
        }

        function CambiarDocumento2(){
            
            var x = document.getElementById('FileUpload2');
            var ar = x.value.substring(12,x.value.length);
            document.getElementById("MDocumento2").innerHTML = ar;
        }

        function PBrrd(){
            x = document.getElementById('ac');
            x.click();
        }
      

        function MBrrd(){
            var obj = document.getElementById('ae');
            obj.click();
        }

        function prueba() {


            //s='ListaConvocatoria_Verconvocatoria_0';
            var s = document.getElementById('ListaConvocatoria_Verconvocatoria_0')[0].getAttribute("class");
            console.log(s);
            var j;
            var k;

        }

        function guardar1() {

            var obj;
            var n = 0;
            var s = ""

            
            var s2 = '';
            var obj2 = document.getElementById('erros');
            obj2.innerText = "";
           
            for (var i = 1; i <= <%=TablaCargos.Rows.Count%>; i++)

            {
                s = 'ArregloCheckCargos'+i;
                obj = document.getElementById(s);             
                if(obj != null){
                    if (obj.checked) {
                        n = n + 1;
                    }
                }
            
            }

            if (n != 0) {

          

                var z = 0;

                var s1 = '';
                var obj1;


                var s3 = '';
                var obj3;

                var s4 = '';
                var s5 = '';
                var s6 = '';
                var obj4;

                var obj5 = document.getElementById('titleerror');

                for (var i = 1; i <= <%=TablaCargos.Rows.Count%>; i++)
                {

                    s = 'ArregloCheckCargos'+i;
                    obj = document.getElementById(s); 

                    s1 = 'ArregloDropDownListCargos'+i
                    obj1 = document.getElementById(s1);  



                    console.log(Math.ceil(1/5));
                    console.log(Math.ceil(6/5));
                    console.log(Math.ceil(11/5));
                    
                    //obtiene el valor actual del select console.log(obj1.options[obj1.selectedIndex].text);
                    
                    s3 ='ArregloLabelCargos'+i;
                    obj3 = document.getElementById(s3); 

                    s4 = 'link';                    
                    s5 = (Math.ceil(i/5)-1).toString();
                    s6 = s4+s5;
                    obj4 = document.getElementById(s6);


                    if(obj != null && obj1 != null){

                        if (obj.checked && obj1.selectedIndex  === 0)
                        {
                            // add_li('li'+i, obj4.innerHTML,'errors')

                            s2 +="Seleccione cupos para el cargo de " + obj3.innerHTML + "</br>";                     
                            z=z+1              
                        }
                    }
                }
                if (z != 0) {
                    obj2.innerHTML = s2;
                    obj5.innerHTML = "OLVIDO ALGO..."
                    return false;
                } else {
                    return true;
                }
            } else {
                obj2.innerText = "Por favor selecciona al menos un cargo"
                return false;
            }
        }


        /* Funcion que busca si existe ya el <li> dentrol del <ul>
         Devuelve true si no existe.
        */
        function find_li(contenido) {
            var el = document.getElementById("listaDesordenada").getElementsByTagName("li");
            for (var i = 0; i < el.length; i++) {
                if (el[i].innerHTML == contenido)
                    return false;
            }
            return true;
        }


        function add_li(idLi, value, idUl) {
            var nuevoLi = document.getElementById(idLi).value;
            if (nuevoLi.length > 0) {
                if (find_li(nuevoLi)) {
                    var li = document.createElement('li');
                    li.id = nuevoLi;
                    li.innerHTML = value;
                    //"<span onclick='eliminar(this)'>X</span>"+nuevoLi;
                    document.getElementById(idUl).appendChild(li);
                }
            }
            return false;
        }


        function redondeo(numero) {
            var flotante = parseFloat(numero);
            var resultado = Math.round(flotante * 100) / 100;
            return resultado;
        }

        function modalE() {
            var obj = document.getElementById('aa');
            obj.click();

        }


        function modalR() {
            var obj = document.getElementById('ab');
            obj.click();
        }

        function Guardar() {
            var obj = document.getElementById('Button5');
            obj.click();
          

        }

        function nueva() {
            var obj = document.getElementById('ac');
            obj.click();
        }

        function publicar(){
            var x = document.getElementById('Button3');
            x.click();
        }

        
        function IrAPanel(e){
            var x; 
            switch (e){
                case "PPblc":
                    x = document.getElementById('ad');
                    x.click();
                    break;
                case "TBrrd":
                    //FRegistro.value = "";
                    //NConv.value = "";
                    //InicioInscripcion.value= null;
                    //ffindeinscripcion.value= null;
                    //resultadosconvo.value = null;
                    //juradosconvoca.value= null;
                    //candidatoshconvo.value= null;
                    //epresenciaconvo.value= null;
                    //edistanciaconvo.value= null;
                    //descripcion.value="";

                    //window.location.href="http://localhost:25597/Views/VConvocatoria.aspx
                    //window.location.assign("http://localhost:25597/Views/VConvocatoria.aspx");
                        
                    //$("#liTRBrrd").attr("class", "");
                    //$("#liTBrrd").attr("class", "active");

                    CallServer('asdf')

                    x = document.getElementById('LTBrrd');
                    x.click();
                    break;
                case "PBrrd":
                    x = document.getElementById('ad');
                    x.click();
                    break;
            }
        }

        function Refresh_page(){
            window.location.assign('http://localhost:25597/Views/VConvocatoria.aspx')        
        };


        function hola(){
            alert('wtf');
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

        // Call server from aspx with javascript
        function CallServer(id) {
            //the attribute that recive the method _doPostBack is identifier, this is listening in the method page_load with a parameter 
            __doPostBack(id);
        }


        function EstablecerFechaMin(e){
            
            switch (e){
                case "InicioInscripcion":

                    $("#ffindeinscripcion").attr("min", new Date($("#InicioInscripcion").val()).toISOString().substring(0, 10));
                    $("#resultadosconvo").attr("min", new Date($("#InicioInscripcion").val()).toISOString().substring(0, 10));
                    $("#juradosconvoca").attr("min", new Date($("#InicioInscripcion").val()).toISOString().substring(0, 10) );
                    $("#candidatoshconvo").attr("min", new Date($("#InicioInscripcion").val()).toISOString().substring(0, 10));
                    $("#epresenciaconvo").attr("min",  new Date($("#InicioInscripcion").val()).toISOString().substring(0, 10));
                    $("#edistanciaconvo").attr("min",  new Date($("#InicioInscripcion").val()).toISOString().substring(0, 10));
            
                    break;

                case "ffindeinscripcion":

                    $("#resultadosconvo").attr("min",  new Date($("#ffindeinscripcion").val()).toISOString().substring(0, 10));
                    $("#juradosconvoca").attr("min", new Date($("#ffindeinscripcion").val()).toISOString().substring(0, 10));
                    $("#candidatoshconvo").attr("min",  new Date($("#ffindeinscripcion").val()).toISOString().substring(0, 10));
                    $("#epresenciaconvo").attr("min",new Date($("#ffindeinscripcion").val()).toISOString().substring(0, 10));
                    $("#edistanciaconvo").attr("min",  new Date($("#ffindeinscripcion").val()).toISOString().substring(0, 10));
                    break;

                case "Date2":
                    $("#Date3").attr("min", new Date($("#Date2").val()).toISOString().substring(0, 10));
                    $("#Date4").attr("min", new Date($("#Date2").val()).toISOString().substring(0, 10));
                    $("#Date5").attr("min", new Date($("#Date2").val()).toISOString().substring(0, 10) );
                    $("#Date6").attr("min", new Date($("#Date2").val()).toISOString().substring(0, 10));
                    $("#Date7").attr("min",  new Date($("#Date2").val()).toISOString().substring(0, 10));
                    $("#Date8").attr("min",  new Date($("#Date2").val()).toISOString().substring(0, 10));
            
                    break;
                case "Date3":
                    
                    $("#Date4").attr("min",  new Date($("#Date3").val()).toISOString().substring(0, 10));
                    $("#Date5").attr("min", new Date($("#Date3").val()).toISOString().substring(0, 10));
                    $("#Date6").attr("min",  new Date($("#Date3").val()).toISOString().substring(0, 10));
                    $("#Date7").attr("min",new Date($("#Date3").val()).toISOString().substring(0, 10));
                    $("#Date8").attr("min",  new Date($("#Date3").val()).toISOString().substring(0, 10));
                    break;


            }

      
        }


    

     

    </script>




    <script>
        <%-- Datapiker only years --%>
    
        //$(function() {
        //    $( "#Datepicker1" ).datepicker({dateFormat: 'yy'});
        //});
    
        <%--End Datapiker only years --%>
    </script>


    <script type="text/javascript">
        window.onerror = function(msg, url, line, col, error) {
            // Note that col & error are new to the HTML 5 spec and may not be 
            // supported in every browser.  It worked for me in Chrome.
            var extra = !col ? '' : '\ncolumn: ' + col;
            extra += !error ? '' : '\nerror: ' + error;

            // You can view the information in an alert to see things working like this:
            alert("Error: " + msg + "\nurl: " + url + "\nline: " + line + extra);

            // TODO: Report this error via ajax so you can keep track
            //       of what pages have JS issues

            var suppressErrorAlert = true;
            // If you return true, then error alerts (like in older versions of 
            // Internet Explorer) will be suppressed.
            return suppressErrorAlert;
        };
    </script>

</head>
<body>


    <form id="Formulario" runat="server">

        <asp:Button ID="Buttonttt" runat="server" Text="Button" OnClick="NuevoClick12" Style="display: none" />
        <asp:Button ID="Button5" runat="server" Text="Button" OnClick="ICnvtC" Style="display: none" />




        <a id="aa" data-toggle="modal" href="#modal_form_vertical" title="Agregar" style="display: none"><i class="icon-add"></i></a>
        <a id="ab" data-toggle="modal" href="#modal_registro" title="Agregar" style="display: none"><i class="icon-add"></i></a>

        <asp:Button ID="ICnvt" runat="server" Text="Button" OnClick="ICnvtC" Style="display: none" />
        <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button4_Click" Style="display: none" />
        <asp:Label ID="Label1" runat="server" Text="1" Style="display: none"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Label" Style="display: none"></asp:Label>

        <!-- Main navbar -->
        <div class="navbar navbar-inverse">
            <div class="navbar-header">
                <a class="navbar-brand" href="index.aspx">
                    <img src="assets/images/si.png" style="width: 11em; height: 1.5em;" />
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
                                <asp:LinkButton ID="Salir" runat="server" OnClick="Salir_Click"> <i class="icon-switch2"></i>  Salir </asp:LinkButton>
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
                                    <li class="active"><a href="Index.aspx"><i class="icon-home4"></i><span>Principal</span></a></li>
                                    <li>
                                        <a href="#"><i class="icon-stack2"></i><span>Convocatorias</span></a>
                                        <ul>
                                            <li><a id="recargar" href="VConvocatoria.aspx">Gestionar convocatoria</a></li>
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
                                <li id="liTRBrrd" class="active"><a href="#TRBrrd" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Registrar borrador  </a></li>
                                <li id="liTBrrd"><a id="LTBrrd" href="#TBrrd" data-toggle="tab"><i class="icon-menu7 position-left"></i>Revisar Borrador</a></li>
                                <li><a href="#TPblc" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Consultar Publicada  </a></li>
                                <li style="display: none"><a id="ac" href="#PBrrd" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Consultar Publicada  </a></li>
                                <li style="display: none"><a id="ad" href="#PPblc" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Consultar Publicada  </a></li>
                                <li style="display: none"><a id="ae" href="#RBrrd" data-toggle="tab"><i class="icon-calendar3 position-left"></i>Consultar Publicada  </a></li>
                            </ul>
                        </div>
                    </div>





                    <!-- Content area -->
                    <div class="content">


                        <div class="row">
                            <div class="col-lg-12">
                                <div class="tabbable">
                                    <div class="tab-content">
                                        <div class="tab-pane fade in active" id="TRBrrd">
                                            <div class="panel col-md-10 col-md-offset-1 ">
                                                <div class="steps-basic">
                                                    <h6>Datos convocatoria</h6>
                                                    <fieldset>
                                                        <div class="row col-md-10 col-md-offset-1 ">
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Fecha de creación <span class="text-danger">*</span>  </label>
                                                                        <%--<input type="text" runat="server" id="Datepicker1"  required="required" />--%>
                                                                        <input id="FRegistro" type="date" runat="server" onchange="CallServer('CNmroCnvt')" class="form-control" />
                                                                    </div>
                                                                </div>

                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Numero <span class="text-danger">*</span>  </label>
                                                                        <input type="text" class="form-control" runat="server" id="NConv" required="required" readonly="true" />

                                                                    </div>
                                                                </div>

                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>Inicio de inscripciones <span class="text-danger">*</span>  </label>
                                                                        <input type="date" class="form-control" runat="server" id="InicioInscripcion" required="required" onchange="EstablecerFechaMin('InicioInscripcion')" />
                                                                    </div>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label for="exampleInputEmail1">
                                                                            Fin de
                                                                            <br />
                                                                            inscripciones  <span class="text-danger">*</span>
                                                                        </label>
                                                                        <input type="date" class="form-control" placeholder="DD/MM/YY" runat="server" id="ffindeinscripcion" required="required" onchange="EstablecerFechaMin('ffindeinscripcion')" />
                                                                    </div>
                                                                </div>

                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>
                                                                            Publicación de
                                                                            <br />
                                                                            resultados <span class="text-danger">*</span>
                                                                        </label>
                                                                        <input type="date" class="form-control" runat="server" id="resultadosconvo" required="required" />
                                                                    </div>

                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>
                                                                            Publicación de jurados
                                                                            <br />
                                                                            habilitados <span class="text-danger">*</span>
                                                                        </label>
                                                                        <input type="date" class="form-control" runat="server" id="juradosconvoca" required="required" />
                                                                    </div>
                                                                </div>

                                                            </div>
                                                            <div class="row">
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>
                                                                            Publicación de candidatos  y
                                                                            <br />
                                                                            testigos habilitados  <span class="text-danger">*</span>
                                                                        </label>
                                                                        <input type="date" class="form-control" runat="server" id="candidatoshconvo" required="required" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>
                                                                            Elecciones modalidad
                                                                            <br />
                                                                            presencial  <span class="text-danger">*</span>
                                                                        </label>
                                                                        <input type="date" class="form-control" runat="server" id="epresenciaconvo" required="required" />
                                                                    </div>
                                                                </div>
                                                                <div class="col-md-4">
                                                                    <div class="form-group">
                                                                        <label>
                                                                            Elecciones modalidad  a
                                                                            <br />
                                                                            distancia <span class="text-danger">*</span>
                                                                        </label>
                                                                        <input type="date" class="form-control" runat="server" id="edistanciaconvo" required="required" />
                                                                    </div>
                                                                </div>
                                                            </div>



                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <label>Descripción <span class="text-danger">*</span>  </label>
                                                                        <textarea rows="5" class="form-control" placeholder="Detalles" id="descripcion" runat="server" required="required"></textarea>
                                                                    </div>
                                                                </div>
                                                            </div>

                                                            <div class="row">
                                                                <div class="col-md-12">
                                                                    <div class="form-group">
                                                                        <asp:FileUpload ID="FileUpload1" CssClass="file-input" runat ="server" />
                                                                       <%-- <input type="file" class="file-input" runat="server"/>--%>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <%-- <input id="input-44" name="input44[]" type="file" multiple class="file-loading">--%>
                                                    </fieldset>

                                                    <h6>Cargos a convocar</h6>
                                                    <fieldset>
                                                        <div class="widget">
                                                            <div class="widget-header text-center">
                                                                <label class="hTittle" style="align-content: center; align-items: center; font-weight: bold;">PORFAVOR SELECCIONE LOS CARGOS A CONVOCAR...</label>
                                                                <%--<h3 class="hTittle">Selecciona los cargos a convocar</h3>--%>
                                                            </div>

                                                            <div class="widget-content">
                                                                <div id="Panel1" runat="server">
                                                                </div>

                                                            </div>
                                                        </div>
                                                        <%--<asp:Label ID="error" runat="server" Text="Label"></asp:Label>--%>
                                                    </fieldset>
                                                </div>


                                            </div>
                                        </div>

                                        <div class="tab-pane fade" id="TBrrd">
                                            <div class="panel ">
                                                <div class="panel-heading">
                                                    <h6 class="panel-title" style="font-size: 1em"></h6>
                                                    <div class="heading-elements" style="margin-top: 0.5%">
                                                        <span class="label bg-success heading-text">
                                                            <asp:Label ID="NumeroR" runat="server" Text="Label" CssClass=""></asp:Label>
                                                            Borradores </span>
                                                        <ul class="icons-list">
                                                            <li><a data-toggle="modal" href="#" title="Agregar"><i class="icon-add"></i></a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="panel-body">
                                                    <p style="font-size: 2em; width: 100%; text-align: center">Lista de borradores </p>
                                                    <br />


                                                    <%--        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                                                    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="Agregar1" EventName="click" />
                                                        </Triggers>--%>
                                                    <%--  <ContentTemplate>--%>

                                                    <%--  //  --%>

                                                    <asp:ListView ID="LVBrrd" runat="server">
                                                        <ItemTemplate>
                                                            <div class="col-md-10 col-md-offset-1">
                                                                <div class="thumbnail">
                                                                    <div class="thumb text-center">
                                                                        <label style="font-size: 2em; margin-top: 2em">
                                                                            CONVOCATORIA ELECTORAL
                                                                            <br />
                                                                            N#
                                                                        <asp:Label ID="titu" runat="server" Text='<%#Eval("NUMEROCONVOCATORIA") %>'>  </asp:Label>
                                                                            de 
                                                                            <asp:Label ID="Label5" runat="server" Text='<%#Eval("fecharegistro") %>'>  </asp:Label>
                                                                        </label>

                                                                    </div>

                                                                    <div class="caption">
                                                                        <h6 class="text-semibold no-margin-top text-uppercase">

                                                                            <%--  <asp:Label ID="tituloconv" runat="server" Text='<%#Eval("TituloConvocatoria")%>'> </asp:Label>--%>
                                                                        </h6>

                                                                        <asp:Label ID="descripcionconv" CssClass="text-uppercase" runat="server" Text='<%#Eval("DescripcionConvocatoria") %>'></asp:Label>

                                                                        <div class="row">

                                                                            <div class="col-sm-6">
                                                                                <h6 class="text-semibold no-margin-top"></h6>
                                                                                <ul class="list list-unstyled">
                                                                                    <li>Fecha inicio de inscripcion:</li>
                                                                                    <li>'<%#Eval("Fechainicioinscripcion")%>'
                                                                                    </li>
                                                                                    <li>Fecha limite de inscripcion:
                                                                                    </li>
                                                                                    <li>'<%#Eval("Fechafininscripcion")%>'
                                                                                    </li>
                                                                                </ul>

                                                                            </div>

                                                                            <div class="col-sm-6">
                                                                                <h6 class="text-semibold text-right no-margin-top"></h6>
                                                                                <ul class="list list-unstyled text-right">
                                                                                    <li>Estado: <span class="text-semibold">'<%#Eval("estado") %>'</span></li>
                                                                                </ul>
                                                                            </div>
                                                                        </div>


                                                                    </div>

                                                                    <div class="panel-footer">
                                                                        <ul>
                                                                            <li>
                                                                                <asp:LinkButton ID="LinkButton1" runat="server" CssClass="icon-thumbs-up3 position-left" CommandArgument='<%#Eval("IDCONVOCATORIA")%>' OnCommand="LinkButton1_Command" >  </asp:LinkButton>

                                                                            </li>
                                                                            <li>
                                                                                <asp:LinkButton ID="Verconvocatoria" runat="server" CssClass="icon-eye8" CommandArgument='<%#Eval("IDCONVOCATORIA")%>' OnCommand="Verconvocatoria_Command">  </asp:LinkButton>
                                                                            </li>
                                                                        </ul>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </ItemTemplate>
                                                    </asp:ListView>

                                                    <%--   </ContentTemplate>
                                                    </asp:UpdatePanel>--%>
                                                </div>

                                            </div>
                                        </div>

                                        <%--tab convocatorias publicadas--%>
                                        <div class="tab-pane fade" id="TPblc">
                                            <div class="panel-heading">
                                                <h6 class="panel-title">Borradores</h6>
                                                <div class="heading-elements">
                                                    <span class="label bg-success heading-text">
                                                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                                                        Publicadas </span>
                                                    <ul class="icons-list">
                                                        <li><a data-toggle="modal" href="#" title="Agregar"><i class="icon-add"></i></a></li>
                                                    </ul>
                                                </div>
                                            </div>
                                            <div class="panel-body">
                                                <%--Lista de convocatoria en la Uniamazonia--%>
                                                <br />
                                                <%--     <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                                                        <Triggers>
                                                            <asp:AsyncPostBackTrigger ControlID="Agregar1" EventName="click" />
                                                        </Triggers>
                                                        <ContentTemplate>--%>
                                                <%--lista de borradores de convocatoria--%>
                                                <asp:ListView ID="ListaConvocatoria" runat="server">
                                                    <ItemTemplate>
                                                        <div class="col-md-6">
                                                            <div class="thumbnail">
                                                                <div class="thumb">
                                                                    <img src="assets/images/r.jpg" alt="">
                                                                </div>

                                                                <div class="caption">
                                                                    <h6 class="text-semibold no-margin-top text-uppercase">
                                                                        <asp:Label ID="tituloconv" runat="server" Text='<%#Eval("TituloConvocatoria")%>'> </asp:Label>
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
                                                                            <asp:LinkButton ID="LBPblc" runat="server" CssClass="icon-eye8" CommandArgument='<%#Eval("IDCONVOCATORIA")%>' OnCommand="LBPblc_Command"> </asp:LinkButton>
                                                                        </li>
                                                                    </ul>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </ItemTemplate>
                                                </asp:ListView>
                                                <%--      </ContentTemplate>
                                                    </asp:UpdatePanel>--%>
                                            </div>
                                        </div>


                                        <%-- panel borradores --%>
                                        <div class="tab-pane fade" id="RBrrd">
                                            <div class="panel col-md-10 col-md-offset-1 ">
                                                <div style="width: 100%" class="text-center">
                                                    <h6 style="margin-bottom: 1.5em; margin-top: 1.5em; font-size:1.5em">Datos del borrador seleccionado</h6>
                                                </div>
                                                <fieldset>
                                                    <div class="row col-md-10 col-md-offset-1 ">
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>Fecha de creación <span class="text-danger">*</span>  </label>
                                                                    <%--<input type="text" runat="server" id="Datepicker1"  required="required" />--%>
                                                                    <input id="Date1" type="date" runat="server" onchange="CallServer('CNmroCnvt')" class="form-control" />
                                                                </div>
                                                            </div>

                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>Numero <span class="text-danger">*</span>  </label>
                                                                    <input type="text" class="form-control" runat="server" id="Text1" required="required" readonly="true" />

                                                                </div>
                                                            </div>

                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>Inicio de inscripciones <span class="text-danger">*</span>  </label>
                                                                    <input type="date" class="form-control" runat="server" id="Date2" required="required" onchange="EstablecerFechaMin('Date2')" />
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label for="exampleInputEmail1">
                                                                        Fin de
                                                                            <br />
                                                                        inscripciones  <span class="text-danger">*</span>
                                                                    </label>
                                                                    <input type="date" class="form-control" placeholder="DD/MM/YY" runat="server" id="Date3" required="required" onchange="EstablecerFechaMin('Date3')" />
                                                                </div>
                                                            </div>

                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>
                                                                        Publicación de
                                                                            <br />
                                                                        resultados <span class="text-danger">*</span>
                                                                    </label>
                                                                    <input type="date" class="form-control" runat="server" id="Date4" required="required" />
                                                                </div>

                                                            </div>
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>
                                                                        Publicación de jurados
                                                                            <br />
                                                                        habilitados <span class="text-danger">*</span>
                                                                    </label>
                                                                    <input type="date" class="form-control" runat="server" id="Date5" required="required" />
                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>
                                                                        Publicación de candidatos  y
                                                                            <br />
                                                                        testigos habilitados  <span class="text-danger">*</span>
                                                                    </label>
                                                                    <input type="date" class="form-control" runat="server" id="Date6" required="required" />
                                                                </div>
                                                            </div>
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>
                                                                        Elecciones modalidad
                                                                            <br />
                                                                        presencial  <span class="text-danger">*</span>
                                                                    </label>
                                                                    <input type="date" class="form-control" runat="server" id="Date7" required="required" />
                                                                </div>
                                                            </div>
                                                            <div class="col-md-4">
                                                                <div class="form-group">
                                                                    <label>
                                                                        Elecciones modalidad  a
                                                                            <br />
                                                                        distancia <span class="text-danger">*</span>
                                                                    </label>
                                                                    <input type="date" class="form-control" runat="server" id="Date8" required="required" />
                                                                </div>
                                                            </div>
                                                        </div>



                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label>Descripción <span class="text-danger">*</span>  </label>
                                                                    <textarea rows="5" class="form-control" placeholder="Detalles" id="Textarea1" runat="server" required="required"></textarea>
                                                                </div>
                                                            </div>
                                                        </div>

                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <label id="MDocumento2" runat="server" style="float:left;padding-right:20%" class="btn btn-default btn-file text-left">>                                                                        />
                                                                    </label>
                                                                    <input type="button" value="Editar" class="btn btn-success flotarIzquierda" onclick="CambiarDocumento()"  />
                                                                    
                                                                    <asp:Button ID="Button7" runat="server" Text="Ver" CssClass="buttl2" OnClick="Button7_Click" />

                                                                    <asp:FileUpload ID="FileUpload2" onchange="CambiarDocumento2()" CssClass="invisible" runat="server" />
                                                                   <%-- <input id="Documento" type="file" class="invisible" />   --%>                        
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <div class="row">
                                                            <div class="col-md-12">
                                                                <div class="form-group">
                                                                    <input type="button" value="Siguiente" onclick="PBrrd()" class="butt"/>
                                                                </div>
                                                            </div>
                                                        </div>
                                                        <%-- <input id="input-44" name="input44[]" type="file" multiple class="file-loading">--%>
                                                    </div>
                                                   
                                                </fieldset>
                                            </div>
                                        </div>
                                        <div class="tab-pane fade" id="PBrrd">
                                            <div class="panel col-md-10 col-md-offset-1 ">

<%--                                                <h6 style="margin-bottom: 1em; margin-top: 1em">Cargos a convocar</h6>--%>
                                                <fieldset>


                                                    <div class="widget" style="margin-top: 2em">
                                                        <div class="widget-header text-center">
                                                            <label class="hTittle" style="align-content: center; align-items: center; font-weight: bold;">CARGOS CONVOCADOS</label>
                                                            <%--<h3 class="hTittle">Selecciona los cargos a convocar</h3>--%>
                                                        </div>

                                                        <div class="widget-content">
                                                            <div id="Panel4" runat="server" style="margin-bottom: 1.5em">
                                                            </div>



                                                            <%--<label  style="background-color:rgb(33, 150, 243);padding:0.5em;color:white;"><strong>Adjuntar soporte</strong></label>--%>
                                                            <%-- <label><strong>Adjuntar soporte</strong></label>
                                                                <input id="file-es" name="file-es[]" type="file" multiple />--%>


                                                            <%--<label class="control-label">Select File</label>--%>
                                                            <%--<input id="input-44" name="input44[]" type="file" multiple class="file-loading">
                                                                <div id="errorBlock" class="help-block"></div>--%>




                                                             <asp:Button ID="Button3" runat="server" Text="Publicar" OnClick="Button3_Click" CssClass="butt" CausesValidation="false" />
                                                            <asp:Button ID="Button4" runat="server" Text="Eliminar" OnClick="Button4_Click1" CssClass="buttE" CausesValidation="false" />
                                                            

                                                        </div>
                                                    </div>

                                                </fieldset>
                                            </div>
                                        </div>


                                        <%-- panel publicados --%>

                                        <div class="tab-pane fade" id="PPblc">
                                            <div class="panel col-md-12">

                                                <div class="row col-md-10 col-md-offset-1 ">
                                                    <div class="panel-body">
                                                        <div class="widget">
                                                            <div class="widget-header text-center">
                                                                <label class="hTittle" style="align-content: center; align-items: center; font-weight: bold;">CONVOCATORIA N 004...</label>
                                                                <%--<h3 class="hTittle">Selecciona los cargos a convocar</h3>--%>
                                                            </div>

                                                            <div class="widget-content">
                                                                <div id="panel3" runat="server">
                                                                </div>

                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                        </div>
                                    </div>
                                </div>



                            </div>
                        </div>
                    </div>
                    <asp:Button ID="Agregar1" runat="server" Text="Button" OnClick="Agregar_Click" Style="display: none;" />
                    <asp:Button ID="Agregar" runat="server" Text="Button" OnClick="Agregar_Click" Style="display: none;" />
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
                <div class="modal-content" style="background-color: rgba(233, 97, 82, 0.8); border-color: white; border: outset; border-width: 0.3em">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" onclick="limpiar_textbox('cober');">&times;</button>
                        <label id="titleerror" style="color: white; font-size: 1.5em" class="modal-title"><strong>No has seleccionado ningun cargo</strong></label>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <asp:Label ID="erros" Style="color: white; font-size: 1em" runat="server" Text="Porfavor selecciona al menos un cargo"></asp:Label>
                            <%-- <ol id="errors">


                            </ol>--%>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-link" data-dismiss="modal" style="color: white; font-size: 1em; border-color: white; border: outset; border-radius: 10%; border-width: 0.3em">Entendido</button>
                        <%--onclick="limpiar_textbox('erros');"--%>
                    </div>
                </div>
            </div>
        </div>

        <div id="modal_registro" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content" style="background-color: rgba(63, 193, 165, 0.8); border-color: white; border: outset; border-width: 0.3em">
                    <div class="modal-header">
                        <%--<button type="button" class="close" data-dismiss="modal" ">&times;</button>--%>
                        <label style="color: white; font-size: 1.5em" class="modal-title"><strong>¿Desea guardar?</strong></label>
                    </div>
                    <div class="modal-body">
                        <div class="form-group">
                            <asp:Label ID="Label4" Style="color: white; font-size: 1em" runat="server" Text=""></asp:Label>


                        </div>
                    </div>
                    <div class="modal-footer">
                        <%--<asp:Button ID="Button5" runat="server" Text="blblablablalb" class="btn btn-link" data-dismiss="modal" style="color: white; font-size: 1em; border-color: white; border: outset; border-radius: 10%; border-width: 0.3em; width: 20%" OnClientClick="CallServer('Guardar')"/>--%>
                        <asp:Button ID="Button1" runat="server" Text="Ok" class="btn btn-link" data-dismiss="modal" Style="color: white; font-size: 1em; border-color: white; border: outset; border-radius: 10%; border-width: 0.3em; width: 20%" OnClientClick="Guardar()" />
                        <asp:Button ID="Button6" runat="server" Text="Cancel" class="btn btn-link" data-dismiss="modal" Style="color: white; font-size: 1em; border-color: white; border: outset; border-radius: 10%; border-width: 0.3em; width: 20%" />
                    </div>
                </div>
            </div>
        </div>



    </form>
</body>



<%--functions fileinputs--%>
<script>
    $(document).on('ready', function() {
        $("#input-44").fileinput({
            uploadUrl: 'assets/Js/fileinput/prueba.js',
            uploadAsync: false,
            maxFilePreviewSize: 10240,
            minFileCount: 1,
            maxFileCount: 5,
            showUpload: true,
            showRemove: false
        });
    });

    //$('#file-fr').fileinput({
    //    language: 'fr',
    //    uploadUrl: '#',
    //    allowedFileExtensions: ['jpg', 'png', 'gif'],
    //});
    //$('#file-es').fileinput({
    //    language: 'es',
    //    uploadUrl: '#',
    //    allowedFileExtensions: ['jpg', 'png', 'gif', 'pdf'],
    //});
    //$("#file-0").fileinput({
    //    'allowedFileExtensions': ['jpg', 'png', 'gif'],
    //});
    //$("#file-1").fileinput({
    //    uploadUrl: '#', // you must set a valid URL here else you will get an error
    //    allowedFileExtensions: ['jpg', 'png', 'gif'],
    //    overwriteInitial: false,
    //    maxFileSize: 1000,
    //    maxFilesNum: 10,
    //    //allowedFileTypes: ['image', 'video', 'flash'],
    //    slugCallback: function (filename) {
    //        return filename.replace('(', '_').replace(']', '_');
    //    }
    //});
    ///*
    //$(".file").on('fileselect', function(event, n, l) {
    //    alert('File Selected. Name: ' + l + ', Num: ' + n);
    //});
    //*/
    //$("#file-3").fileinput({
    //    showUpload: false,
    //    showCaption: false,
    //    browseClass: "btn btn-primary btn-lg",
    //    fileType: "any",
    //    previewFileIcon: "<i class='glyphicon glyphicon-king'></i>"
    //});
    //$("#file-4").fileinput({
    //    uploadExtraData: { kvId: '10' }
    //});
    //$(".btn-warning").on('click', function () {
    //    if ($('#file-4').attr('disabled')) {
    //        $('#file-4').fileinput('enable');
    //    } else {
    //        $('#file-4').fileinput('disable');
    //    }
    //});
    //$(".btn-info").on('click', function () {
    //    $('#file-4').fileinput('refresh', { previewClass: 'bg-info' });
    //});
    ///*
    //$('#file-4').on('fileselectnone', function() {
    //    alert('Huh! You selected no files.');
    //});
    //$('#file-4').on('filebrowse', function() {
    //    alert('File browse clicked for #file-4');
    //});
    //*/
    //$(document).ready(function () {
    //    $("#test-upload").fileinput({
    //        'showPreview': false,
    //        'allowedFileExtensions': ['jpg', 'png', 'gif'],
    //        'elErrorContainer': '#errorBlock'
    //    });
    //    /*
    //    $("#test-upload").on('fileloaded', function(event, file, previewId, index) {
    //        alert('i = ' + index + ', id = ' + previewId + ', file = ' + file.name);
    //    });
    //    */
    //});

   

</script>
<%--end functions fileinputs--%>
</html>
