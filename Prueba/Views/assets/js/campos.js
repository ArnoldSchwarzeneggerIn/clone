
function limpiar_textbox(campo1)
{
    document.getElementById(campo1).value = '';
}
function limpiar_form(id_e) {
    var elemento=document.getElementById(id_e);
    var arreglo = elemento.getElementsByTagName("input");
    for (var i = 0; i < arreglo.length; i++) {
        arreglo[i].value = '';
    }
    
}