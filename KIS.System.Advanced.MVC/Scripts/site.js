
function callActionPost(controler, action, parameter, redirect = null) {

    $.ajax({
        type: "POST",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,
        success: function (data) {            
            if (redirect != "" && redirect != undefined) {
                window.location = redirect;
            }
            if(data)
                return parseJSON(data);
        }
    });
}

function callActionGet(controler, action, parameter = null) {

    $.ajax({
        type: "Get",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,
        success: function (data) {
            if (redirect != "" && redirect != undefined) {
                window.location = redirect;
            }
            if (data)
                return parseJSON(data);
        }
    });
}

