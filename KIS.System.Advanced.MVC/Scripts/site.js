function callActionPost(controler, action, parameter) {
    $.ajax({
        type: "POST",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,       
    });
}

function callActionGet(controler, action, parameter) {
    debugger;
    $.ajax({
        type: "Get",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,
    });
}
