$(document).ready(function () {

    $.ajax({
        url: 'ConciertosRest/actualizarConcierto',
        type: 'PUT',
        data: {IdConcierto: 2, Pais: "Italia", FechaPresentacion: new Date().toLocaleDateString(),Lugar: "Munich", IdBanda: 5},
        dataType: 'json',
        success: function (data) {
            console.log(data);
        },
        error: function (error) {
            console.log(error.responseText);
        }
    });
});