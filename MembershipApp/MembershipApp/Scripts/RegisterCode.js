$(".register-code-panel button").click(function (e) {
    $(".register-code-panel .alert").addClass('hidden');

    if (code.val().length == 0) {
        displayMessage(false, "Enter a code");
        return;
    }

    $.post('/RegisterCode/Register', { code: code.val() },
        function (data) {
            displayMessage(true, "The code was successfully registered. \n\r Please reload the page.");
            code.val('');
        }).fail(function (xhr, status, error) {
            displayMessage(false, "Could not register code");
        });
});