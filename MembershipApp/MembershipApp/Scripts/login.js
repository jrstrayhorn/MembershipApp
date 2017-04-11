$(function () {
    // wire up the hover event
    var loginLinkHover = $("#loginLink").hover(onLoginLinkHover);

    // the function called by the hover event
    function onLoginLinkHover() {
        $('div[data-login-user-area]').addClass('open');
    };
});