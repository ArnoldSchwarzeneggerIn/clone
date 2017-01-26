<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Prueba.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8" />
    <title>Krajee JQuery Plugins - &copy; Kartik</title>
    <!-- Global stylesheets -->

    <!-- Fileinput-->



    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" rel="stylesheet" />
    <link href="../css/fileinput.css" media="all" rel="stylesheet" type="text/css" />
    <script src="http://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
    <script src="../js/fileinput.js" type="text/javascript"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js" type="text/javascript"></script>



    <%--    <link href="https://fonts.googleapis.com/css?family=Roboto:400,300,100,500,700,900" rel="stylesheet" type="text/css" />
    <link href="assets/css/icons/icomoon/styles.css" rel="stylesheet" type="text/css" />--%>
    <%--<link href="assets/css/minified/bootstrap.min.css" rel="stylesheet" type="text/css" />--%>
    <%--  <link href="assets/css/minified/core.min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/minified/components.min.css" rel="stylesheet" type="text/css" />
    <link href="assets/css/minified/colors.min.css" rel="stylesheet" type="text/css" />--%>


    <!-- /global stylesheets -->

    <!-- Core JS files -->
    <%--<script type="text/javascript" src="assets/js/plugins/loaders/pace.min.js"></script>
       
     <script type="text/javascript" src="assets/js/core/libraries/jquery.min.js"></script>--%>
    <%--<script type="text/javascript" src="assets/js/core/libraries/jquery-3.0.0.min.js"></script>--%>
    <%--<script type="text/javascript" src="assets/js/core/libraries/bootstrap.min.js"></script>--%>
    <%--    <script type="text/javascript" src="assets/js/plugins/loaders/blockui.min.js"></script>--%>

    <!-- /core JS files -->


    <!--NOTIFICACIONES-->



    <!--???-->
    <%-- <script type="text/javascript" src="assets/js/core/app.js"></script>--%>
    <%--<script type="text/javascript" src="assets/js/core/libraries/jasny_bootstrap.min.js"></script>--%> <%--no deja mostrar el fileuploap dentro de un tab con steps.js en otro lugar si funciona--%>
    <%--    <script type="text/javascript" src="assets/js/plugins/forms/validation/validate.min.js"></script>
    <script type="text/javascript" src="assets/js/campos.js"></script>
    <script type="text/javascript" src="assets/js/plugins/notifications/pnotify.min.js"></script>
    <script type="text/javascript" src="assets/js/pages/wizard_steps.js"></script>--%>
    <%--No deja lanzar la alerta--%>
</head>
<body>
    <!--<div class="container kv-main">
            <div class="page-header">
            <h1>Bootstrap File Input Example <small><a href="https://github.com/kartik-v/bootstrap-fileinput-samples"><i class="glyphicon glyphicon-download"></i> Download Sample Files</a></small></h1>
            </div>         --->

    <h4>Multi Language Inputs</h4>
    <form id="form1" runat="server">
        <div class="select2-container" id="s2id_autogen1"><a href="javascript:void(0)" class="select2-choice" tabindex="-1"><span class="select2-chosen" id="select2-chosen-2">10</span><abbr class="select2-search-choice-close"></abbr>
            <span class="select2-arrow" role="presentation"><b role="presentation"></b></span></a>
            <label for="s2id_autogen2" class="select2-offscreen"></label>
            <input class="select2-focusser select2-offscreen" type="text" aria-haspopup="true" role="button" aria-labelledby="select2-chosen-2" id="s2id_autogen2"/>

        </div>
    </form>
    <hr>
    <br>
</body>
<script>
    $('#file-fr').fileinput({
        language: 'fr',
        uploadUrl: '#',
        allowedFileExtensions: ['jpg', 'png', 'gif'],
    });
    $('#file-es').fileinput({
        language: 'es',
        uploadUrl: '#',
        allowedFileExtensions: ['jpg', 'png', 'gif'],
    });
    $("#file-0").fileinput({
        'allowedFileExtensions': ['jpg', 'png', 'gif'],
    });
    $("#file-1").fileinput({
        uploadUrl: '#', // you must set a valid URL here else you will get an error
        allowedFileExtensions: ['jpg', 'png', 'gif'],
        overwriteInitial: false,
        maxFileSize: 1000,
        maxFilesNum: 10,
        //allowedFileTypes: ['image', 'video', 'flash'],
        slugCallback: function (filename) {
            return filename.replace('(', '_').replace(']', '_');
        }
    });
    /*
    $(".file").on('fileselect', function(event, n, l) {
        alert('File Selected. Name: ' + l + ', Num: ' + n);
    });
    */
    $("#file-3").fileinput({
        showUpload: false,
        showCaption: false,
        browseClass: "btn btn-primary btn-lg",
        fileType: "any",
        previewFileIcon: "<i class='glyphicon glyphicon-king'></i>"
    });
    $("#file-4").fileinput({
        uploadExtraData: { kvId: '10' }
    });
    $(".btn-warning").on('click', function () {
        if ($('#file-4').attr('disabled')) {
            $('#file-4').fileinput('enable');
        } else {
            $('#file-4').fileinput('disable');
        }
    });
    $(".btn-info").on('click', function () {
        $('#file-4').fileinput('refresh', { previewClass: 'bg-info' });
    });
    /*
    $('#file-4').on('fileselectnone', function() {
        alert('Huh! You selected no files.');
    });
    $('#file-4').on('filebrowse', function() {
        alert('File browse clicked for #file-4');
    });
    */
    $(document).ready(function () {
        $("#test-upload").fileinput({
            'showPreview': false,
            'allowedFileExtensions': ['jpg', 'png', 'gif'],
            'elErrorContainer': '#errorBlock'
        });
        /*
        $("#test-upload").on('fileloaded', function(event, file, previewId, index) {
            alert('i = ' + index + ', id = ' + previewId + ', file = ' + file.name);
        });
        */
    });
</script>
</html>
