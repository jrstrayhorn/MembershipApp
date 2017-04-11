$(function () {
    // wire up the hover event
    var loginLinkHover = $("#loginLink").hover(onLoginLinkHover);

    // the function called by the hover event
    function onLoginLinkHover() {
        $('div[data-login-user-area]').addClass('open');
    };

    // wire up the click event
    var loginCloseBUtton = $("#close-login").click(onCloseLogin);

    // the function called by the click event
    function onCloseLogin() {
        $('div[data-login-user-area').removeClass('open');
    }

    // wire up the login event
    var loginButton = $("#login-button").click(onLoginClick);

    function onLoginClick() {
        var url = $('#login-button').attr('data-login-action');
        var return_url = $('#login-button').attr('data-login-return-url');
        var email = $('#Email').val();
        var pwd = $('#Password').val();
        var remember_me = $('#RememberMe').prop('checked');
        var antiforegry = $('[name="__RequestVerificationToken"]').val();

        $.post(url, { __RequestVerificationToken: antiforegry, email: email, password: pwd, RememberMe: remember_me },
            function (data) {
                var parsed = $.parseHTML(data);
                var hasErrors = $(parsed).find("[data-valmsg-summary]").text().replace(/\n|\r/g, "").length > 0;

                if (hasErrors == true) {
                    $("div[data-login-panel-partial]").html(data);
                    $('div[data-login-user-area').addClass('open');
                    $('#Email').addClass("data-login-error");
                    $('#Password').addClass("data-login-error");
                }
                else {
                    $('div[data-login-user-area]').removeClass('open');
                    $('#Email').removeClass("data-login-error");
                    $('#Password').removeClass("data-login-error");
                    location.href = return_url;
                }

                /* Wire up events */
                loginButton = $("#login-button").click(onLoginClick);
                loginLinkHover = $("#loginLink").hover(onLoginLinkHover);
                loginCloseBUtton = $("#close-login").click(onCloseLogin);
            }).fail(function (xhr, status, error) {
                $('#Email').addClass("data-login-error");
                $('#Password').addClass("data-login-error");
                /* Wire up events */
                loginButton = $("#login-button").click(onLoginClick);
                loginLinkHover = $("#loginLink").hover(onLoginLinkHover);
                loginCloseBUtton = $("#close-login").click(onCloseLogin);
            });
    }
});