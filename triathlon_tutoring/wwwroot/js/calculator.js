// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

$(document).ready(function () {

    $("#calcBtn").click(function () {
        var hours = parseFloat($("#hours").val());
        var rate = parseFloat($("#rate").val());

        // Validation: must enter a positive number
        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a positive number of hours.");
            $("#total").val("");
            $("#hours").focus();
            return;
        }

        var total = hours * rate;
        $("#total").val(total.toFixed(2));
    });

});