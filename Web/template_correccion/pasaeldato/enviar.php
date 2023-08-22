<?php
    include("phpmailer/class.phpmailer.php"); 
    include("phpmailer/class.smtp.php"); 
 
    $mail = new PHPMailer();
    $mail->IsSMTP();
    $mail->SMTPAuth = true;
	$mail->SMTPDebug = 1;
	$mail->Mailer = "smtp";
    $mail->SMTPSecure = "tls"; //he probado con TLS o SSL
    $mail->Host = "mail.voxcore.cl"; //he probado tambien con "ssl://smtp.gmail.com";
    $mail->Port = 587; //he probado 465 tambien
    $mail->Username = "info@pasaeldato.cl";
    $mail->Password = "36T5j95f";
 
	$email_message = "Detalles del formulario de contacto:\n\n  <br>";
	$email_message .= "Nombre Local: " . $_POST['nombre'] . "\n <br>";
	$email_message .= "E-mail: " . $_POST['email'] . "\n <br>";
	$email_message .= "Telefono: " . $_POST['telefono'] . "\n <br>" ;
	$email_message .= "Comentarios: " . $_POST['content'] . "\n\n <br>";
 
    $mail->From = "info@pasaeldato.cl";
    $mail->FromName = "Pagina Pasa el Dato";
    $mail->Subject = $_POST['title'];
    $mail->AltBody = $_POST['title'];
	$mail->MsgHTML($email_message);
    $mail->AddAddress("info@pasaeldato.cl", $_POST['email']);
    $mail->IsHTML(true);
 
    if(!$mail->Send()) {
		echo '<script type="text/javascript">
		alert($mail->ErrorInfo);
		window.location.assign("http://www.pasaeldato.cl/contacto.html");
		</script>';	
    } else {
		echo '<script type="text/javascript">
		alert("Cotizacion Enviada, Nos pondremos en contacto con Usted.");
		window.location.assign("http://www.pasaeldato.cl/comida.html");
		</script>';	
    }

?>

