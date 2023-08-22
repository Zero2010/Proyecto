$(document).ready(function () {
    $.ajax({
        url: '@Url.Action("GetChartData", "Administrador")',
        method: 'GET',
        success: function (data) {
            var ctx = document.getElementById('myChart').getContext('2d');

            // Modificar el color de fondo y borde para los valores negativos
            var backgroundColors = data.values.map(value => value < 0 ? 'rgba(255, 0, 0, 0.2)' : 'rgba(75, 192, 192, 0.2)');
            var borderColors = data.values.map(value => value < 0 ? 'rgba(255, 0, 0, 1)' : 'rgba(75, 192, 192, 1)');

            var myChart = new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: data.labels,
                    datasets: [{
                        label: 'Valores',
                        data: data.values,
                        backgroundColor: backgroundColors,
                        borderColor: borderColors,
                        borderWidth: 1
                    }]
                }
            });
        },
        error: function () {
            console.error('Error al obtener los datos.');
        }
    });
});