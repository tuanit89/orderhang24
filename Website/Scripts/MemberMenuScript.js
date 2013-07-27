(function() {
    var bool = false;
    $("#navigate li").stop().mouseenter(function() {
//        if ($(this).children("a").hasClass("active")) {
//            bool = true;
//        } else {
//            $(this).children("a").addClass("hovers");
//        }
        $(this).children("ul").show();
    }).mouseleave(function() {
        if (bool) {
            $(this).children("a").addClass("active");
            bool = false;
        }
        $(this).children("ul").hide();
        $(this).children("a").removeClass("hovers");
    });
    $(".tblList th input[type=checkbox]").change(function() {
        if ($(this).is(':checked')) {
            $(".tblList td input[type=checkbox]").attr("checked", true);
            $(".tblList td").parent("tr").addClass('selectRow');
        } else {
            $(".tblList td input[type=checkbox]").attr("checked", false);
            $(".tblList td").parent("tr").removeClass("selectRow");
        }
    });
    $(".tblList td input[type=checkbox]").change(function() {
        if ($(this).is(':checked')) {
            $(this).parent("td").parent("tr").addClass("selectRow");
        } else {
            $(this).parent("td").parent("tr").removeClass("selectRow");
        }
    });
    $(".tblList tr:odd").addClass("oddRow");

    var url = window.location.toString();
    var url2 = url.substring(url.lastIndexOf('-') + 1, url.lastIndexOf('.'));
    $("#navigate li > a").each(function() {
        if ($(this).data("name") == url2) {
            $("#navigate li > a").removeClass("active");
            $(this).addClass("active");
        }
    });
})();


$(document).scroll(function() {
    //    if ($(this).scrollTop() > 150) {
    //        $("div.toolbar").addClass("topbar");
    //    } else {
    //        $("div.toolbar").removeClass("topbar");
    //    }
    $(window).scroll(function() {
        var s = $(window).scrollTop();
        $(".fixedScrollDetector").each(function() {
            var a = $(this);
            var b = a.next();
            var c = 0;
            if (a.attr("data-fixedTop") !== undefined) c = a.attr("data-fixedTop");
            if (a.offset().top - c <= s) {
                b.css({ position: "fixed", top: c + "px" });
                b.addClass("topbar");
            } else {
            b.css({ position: "relative", top: "" });
            b.removeClass("topbar");
            }
        });
    });
});

$("#need-support").on("click", function() {
    if ($("#showyahoosupport").is(":hidden")) {
        $("#showyahoosupport").slideDown();
    } else {
        $("#showyahoosupport").slideUp();
    }
});

$(".mota-seo").on("keyup copy paste", function(e) {
    if ($(this).parent().find(".notify").length == 0) {
        $(this).parent().append("<strong style=\"color: red\" class=\"notify\"></strong>");
    }
    var fixlength = $(this).data("length");
    var t = fixlength - $(this).val().length;

    if ($(this).val().length >= fixlength) {
        $(this).val($(this).val().substring(0, fixlength));
        $(this).parent().find(".notify").html("Số ký tự còn lại: " + t);
        return false;
    }

    $(this).parent().find(".notify").html("Số ký tự còn lại: " + t);

    return true;
});