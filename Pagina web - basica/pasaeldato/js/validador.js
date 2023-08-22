$(document).ready(function() {

  $('#myModal').on('shown.bs.modal', function () {
    $('#myInput').focus()
  })

    $('#contactForm').bootstrapValidator({
        container: '#messages',
        feedbackIcons: {
            valid: 'glyphicon glyphicon-ok',
            invalid: 'glyphicon glyphicon-remove',
            validating: 'glyphicon glyphicon-refresh'
        },
        fields: {
            nombre: {
                validators: {
                    notEmpty: {
                        nombre:/^[a-zA-Z0-9_\.]+$/,
                        message: 'Se Necesita Ingresar Nombre del Local'
                    }
                }
            },
						direccion: {
								validators: {
										notEmpty: {
												message: 'Debe Ingresar Dirección del Local'
										}
								}
						},
						telefono: {
								validators: {
										notEmpty: {
												message: 'Debe Ingresar el Teléfono del Local'
										}
								}
						},
            email: {
                validators: {
                    notEmpty: {
                        message: 'Debe Ingresar Email'
                    },
                    emailAdress: {
                        message: 'El Email Ingresado no es valido'
                    }
                }
            },
            title: {
                validators: {
                    notEmpty: {
                        message: 'Debe Ingresar Asunto'
                    },
                    stringLength: {
                        max: 50,
                        message: 'El asunto no puede exceder 50 caracteres'
                    }
                }
            },
            content: {
                validators: {
                    notEmpty: {
                        message: 'Debe Ingresar Mensaje'
                    },
                    stringLength: {
                        max: 500,
                        message: 'El Mensaje no puede exceder 500 caracteres'
                    }
                }
            }
        }
    });
});
