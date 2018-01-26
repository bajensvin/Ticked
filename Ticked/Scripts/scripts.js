$(document).ready(function () {
    $('#main-nav ul li a').on('click', function () {
        $("#main-nav ul li a").removeClass('active');
        $(this).addClass('active');
    });
});