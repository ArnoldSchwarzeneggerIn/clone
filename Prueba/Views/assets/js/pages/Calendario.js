function Calendario(Clase, eventsColors,fecha_servidor) {
    var datos = eventsColors;
    $(function ()  {
    
    $('.schedule').fullCalendar({
        header: {
            left: 'prev,next today',
            center: 'title',
            right: 'month,agendaWeek,agendaDay'
        },
        defaultDate: fecha_servidor,
        editable: false,
        events: eventsColors
    });
    // Render in hidden elements
    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
        $('.schedule').fullCalendar('render');
    });
    });
}