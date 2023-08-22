function EliminarEmpleado(e) {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            var lista = JSON.parse(this.responseText);
            var stracum = "";
            console.log(lista);
            if (lista.length == 0) {
                document.getElementById("cuerpo").innerHTML = "<p>No hay productos en esta categoría</p>";
            } else {

                for (var i = 0; i < lista.length; i++) {
                    var consola = lista[i];
                    stracum += "<br><table id='cuerpo'>";
                    stracum += "<tr>";
                    stracum += "    <th>Nombre</th>";
                    stracum += "    <th>APaterno</th>";
                    stracum += "    <th>AMaterno</th>";
                    stracum += "    <th>Rut</th>";
                    stracum += "</tr>";
                    stracum += "    <tr>";
                    stracum += "        <td>" + consola.nombre + "</td>";
                    stracum += "        <td>" + consola.apaterno + "</td>";
                    stracum += "        <td>" + consola.amaterno + "</td>";
                    stracum += "        <td>" + consola.rut + "</td>";
                    stracum += "        <td>";
                    stracum += "           <a href=/Empleado/Modificar/" + consola.idempleado + ">Modificar</a>|";
                    stracum += "           <a href=/Empleado/Detalle/" + consola.idempleado + ">Detalle</a>|";
                    stracum += "           <a href=/Empleado/Eliminar/" + consola.idempleado + ">Elimianr</a>";
                    stracum += "         </td>";
                    stracum += "    </tr>";
                    stracum += "</table>";
                }
                document.getElementById("cuerpo").innerHTML = stracum;
            }
        }
    };
    xhttp.open("GET", "/DetalleConsola/EliminarConsola?id=" + e.value, true);
    xhttp.send();
}