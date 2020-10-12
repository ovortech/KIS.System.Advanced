
function callActionPost(controler, action, parameter, redirect = null) {
    let retorno;
    $.ajax({
        type: "POST",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,
        async: false,
        success: function (data) {
            if (redirect != "" && redirect != undefined) {
                window.location = window.location.origin + '/' + redirect;
            }
            if (data)
                retorno = data;
        },
        error: function (err) {
            console.log(err);
        }
    });
    if (retorno)
        return retorno;
}

function callActionGet(controler, action, parameter, redirect = null) {
    let retorno;
    $.ajax({
        type: "Get",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,
        async: false,
        success: function (data) {
            if (redirect != "" && redirect != undefined) {
                window.location = window.location.origin + '/' + redirect;
            }
            if (data)
                retorno = data;
        },
        error: function (err) {
            console.log(err);
        }
    });
    if (retorno)
        return retorno;
}





