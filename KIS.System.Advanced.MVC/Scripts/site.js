﻿
function callActionPost(controler, action, parameter, redirect = null) {
    let retorno;
    $.ajax({
        type: "POST",
        url: "/" + controler + "/" + action,
        data: parameter,
        processData: true,
        async: false,
        success: function (data) {
            if (data)
                retorno = data;

            if (redirect != "" && redirect != undefined) {
                window.location = window.location.origin + '/' + redirect;
            }            
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
            if (data)
                retorno = data;

            if (redirect != "" && redirect != undefined) {
                window.location = window.location.origin + '/' + redirect;
            }           
        },
        error: function (err) {
            console.log(err);
        }
    });
    if (retorno)
        return retorno;
}

function salvaModel(controller, action, model) {
    $.ajax({
        type: "POST",
        url: `/${controller}/${action}`,
        data: model,
        processData: true,
        async: false,
        success: function (data) {
            if (data.isValid) {
                window.location = window.location.origin + '/' + controller;
            } else {

                $.ajax({
                    type: "GET",
                    processData: true,
                    async: false,
                    url: `/${controller}/GetForm/`,
                    data: data.model,
                    success: function (resp) {
                        $("#conteudoModal").html(resp);
                    },
                    error: function (err) {
                        console.log(err);
                    }
                })
            }
        },
        error: function (err) {
            console.log(err);
        }
    });
}

function imprimeFormatadoSemSimbolo(valor) {
    return (valor).toLocaleString(`pt-BR`, { style: 'currency', currency: 'BRL' }).replace(/R\$\s/, '')
}

function imprimeFormatadoComSimbolo(valor) {
    return (valor).toLocaleString(`pt-BR`, { style: 'currency', currency: 'BRL' })
}

function recarregaMascaras() {
    $(`.inputNumerico`).maskMoney({ thousands: '.', decimal: ',', allowZero: true, });
    $(`.inputNumerico`).focus();
    $(`.inputNumerico`).blur();
}