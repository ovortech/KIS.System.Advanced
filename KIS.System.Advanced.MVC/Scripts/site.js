function callActionPost(controler, action, parameter, errorMetod, successMetod) {
    debugger;
    $.ajax({
        type: "POST",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,       
    });
}

function callActionGet(controler, action, parameter, errorMetod, successMetod) {
    debugger;
    $.ajax({
        type: "Get",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,
    });
}
