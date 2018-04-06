$(document).ready(function () {
    $('#main-nav ul li a').on('click', function () {
        $("#main-nav ul li a").removeClass('active');
        $(this).addClass('active');
    });
});

$("#button").click(function () {
    $("#hiddeninputs").show();
});
$("#button").click(function () {
    this.style.display = 'none';
})