

function cargo() {

    $('#primera').removeClass('disable first current');
    $('#primera').addClass('disable first done');
    $('#segunda').removeClass('disable disabled');
    $('#segunda').addClass('disabled current');

    document.getElementById('steps-uid-0-p-0').style.display = 'none';
    document.getElementById('steps-uid-0-p-1').style.display = 'block';

}

function car() {

}

function cargo2() {
   
    $('#primera').removeClass('disable first current');
    $('#primera').addClass('disable first done');
    $('#segunda').removeClass('disabled current');
    $('#segunda').addClass('disable done');
    $('#tercera').removeClass('disable disabled last');
    $('#tercera').addClass('disable last current');

    document.getElementById('steps-uid-0-p-0').style.display = 'none';
    document.getElementById('steps-uid-0-p-1').style.display = 'none';
    document.getElementById('steps-uid-0-p-2').style.display = 'block';

}

function proclick() {    
    window.history.back();   
}