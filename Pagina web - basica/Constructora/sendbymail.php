<?php
    //Estoy recibiendo el formulario, compongo el cuerpo
    $cuerpo = "Formulario enviado\n";
    $cuerpo .= "nombre: " . $HTTP_POST_VARS["nombre"] . "\n";
    $cuerpo .= "telefono: " . $HTTP_POST_VARS["telefono"] . "\n";
    $cuerpo .= "email: " . $HTTP_POST_VARS["email"] . "\n";
    $cuerpo .= "mensaje: " . $HTTP_POST_VARS["mensaje"] . "\n";

    //mando el correo...
    mail("robertosaldias@vallesspa.cl","Formulario recibido",$cuerpo);

    //doy las gracias por el envío
    echo "Gracias por rellenar el formulario. Se ha enviado correctamente."; 
?>
