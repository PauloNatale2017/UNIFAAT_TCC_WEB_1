jQuery(function ($) {
    $(".cnpj").mask("99.999.999/9999-99");
    $('.date').mask('00/00/0000');
    $('.time').mask('00:00:00');
    $('.date_time').mask('00/00/0000 00:00:00');
    $('.cep').mask('00000-000');
    $('.phone').mask('0000-0000');
    $('.phone_with_ddd').mask('(00) 0000-0000');
    $('.phone_us').mask('(000) 000-0000');
    $('.mixed').mask('AAA 000-S0S');
    $('.cpf').mask('000.000.000-00', { reverse: true });
    $('.cnpj').mask('00.000.000/0000-00', { reverse: true });
    $('.money').mask('000.000.000.000.000,00', { reverse: true });
    $('.money2').mask("#.##0,00", { reverse: true });

    function validateEmail(email) {
        var reg = /^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/;
        $("#emailvalid").text("");
        if (reg.test(email)) {
            $("#emailvalid").text("EMAIL VALIDO.");
            //return true;
        }
        else {
            $("#emailvalid").text("EMAIL INVALIDO.");
            //return false;
        }
    } 

    $(".email").keyup(function () {
        if ($('#emailid').val() !== "") {
            validateEmail($('#emailid').val());
        } else { $("#emailvalid").text("");}
    });

      
});