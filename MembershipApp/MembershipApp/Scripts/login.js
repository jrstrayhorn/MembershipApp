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
});