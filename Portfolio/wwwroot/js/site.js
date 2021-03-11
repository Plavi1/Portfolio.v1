$(document).ready(function () {
    $("html body .sidebar ul li a").click(function () {
        var clicked = $(this).attr('id');
        $('html, body').animate({
            scrollTop: $(".section-" + clicked).offset().top
        }, 500);
    });
});


$(document).ready(function () {
    $("html body main .topbar .dropdown .dropdown-content a").click(function () {
        var clicked = $(this).attr('id');
        $('html, body').animate({
            scrollTop: $(".section-" + clicked).offset().top
        }, 500);
    });
});

$(document).ready(function () {
    $("html body main .section-about .container .my-work").click(function () {
        $('html, body').animate({
            scrollTop: $(".section-projects").offset().top
        }, 500);
    });
});

$(window).on("scroll", function () {
    var page = $(window).scrollTop();
    var actionlist = $('html body .sidebar ul li a');

    if (page < 500) {
        actionlist.removeClass("on-page");
        $('html body .sidebar ul li #home').addClass("on-page");
    }
    else {
        $('html body .sidebar ul li #home').removeClass("on-page");
    }

    if (page >= 500) {
        actionlist.removeClass("on-page");
        $('html body .sidebar ul li #about').addClass("on-page");
    }
    else {
        $('html body .sidebar ul li #about').removeClass("on-page");
    }

    if (page >= 1400) {
        actionlist.removeClass("on-page");
        $('html body .sidebar ul li #skills').addClass("on-page");
    }
    else {
        $('html body .sidebar ul li #skills').removeClass("on-page");
    }

    if (page >= 2100) {
        actionlist.removeClass("on-page");
        $('html body .sidebar ul li #projects').addClass("on-page");
    }
    else {
        $('html body .sidebar ul li #projects').removeClass("on-page");
    }
    if (page >= 2800) {
        actionlist.removeClass("on-page");
        $('html body .sidebar ul li #contact').addClass("on-page");
    }
    else {
        $('html body .sidebar ul li #contact').removeClass("on-page");
    }
    
});

