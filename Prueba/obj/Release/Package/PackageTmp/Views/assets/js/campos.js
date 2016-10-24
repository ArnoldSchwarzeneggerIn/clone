
function limpiar_textbox(campo1)
{
    document.getElementById(campo1).value = '';
}

function openModal(id) {
    $('#'+id).modal('show');
}

function Alerta(titulo, mensaje, icono, tipo, cerrar) {
    $(function Alet() {
        new PNotify({
            title: titulo,
            text: mensaje,
            icon: icono,
            type: tipo
        });
        if (cerrar) {
            $('#modal_form_vertical').modal('hide');
        }
    });
}

function limpiar_form(id_e) {
    var elemento=document.getElementById(id_e);
    var arreglo = elemento.getElementsByTagName("input");
    for (var i = 0; i < arreglo.length; i++) {
        arreglo[i].value = '';
    }
}


