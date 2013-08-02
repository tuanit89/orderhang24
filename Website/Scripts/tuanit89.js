//Scripted by Vũ Anh Tuấn (tuan.it89@gmail.com)
var tuanva = {};
tuanva.defaultVal = function(obj, oldval, btnSubmit) {
    obj.focusin(function() {
        if (obj.val() == oldval) {
            obj.val("");
        }
    }).focusout(function() {
        if (obj.val() == "") {
            obj.val(oldval);
        }
    });

    btnSubmit.on("click", function() {
        if (obj.val() == oldval) {
            alert("Bạn chưa nhập từ tìm kiếm?");
            return;
        }
    });
};

//Google analytics
var _gaq;
tuanva.GoogleAnalytics = { };
tuanva.GoogleAnalytics.init = function() {
    _gaq = _gaq || [];
    _gaq.push(['_setAccount', "UA-42488037-1"]);
    _gaq.push(['_trackPageview']);
    (function() {
        var a = document.createElement('script');
        a.type = 'text/javascript';
        a.async = true;
        a.src = ('https:' == document.location.protocol ? 'https://ssl' : 'http://www') + '.google-analytics.com/ga.js';
        var s = document.getElementsByTagName('script')[0];
        s.parentNode.insertBefore(a, s);
    })();
};

//Facebook
tuanva.Facebook={};
tuanva.Facebook.init = function() {
    //var str = "<div id=\"fb-root\"></div>";
    (function(d, s, id) {
        var js, fjs = d.getElementsByTagName(s)[0];
        if (d.getElementById(id)) return;
        js = d.createElement(s);
        js.id = id;
        js.src = "//connect.facebook.net/vi_VN/all.js#xfbml=1";
        fjs.parentNode.insertBefore(js, fjs);
    } (document, 'script', 'facebook-jssdk'));
};

//Fixed Scroll
tuanva.fixWhenScroll = function() {
    $(window).scroll(function() {
        var s = $(window).scrollTop();
        $(".fixedScrollDetector").each(function() {
            var a = $(this);
            var b = a.next();
            var c = 5;
            if (a.attr("data-fixedTop") !== undefined) c = a.attr("data-fixedTop");
            if (a.offset().top - c <= s) {
                b.css({ position: "fixed", top: c + "px" });
            } else {
                b.css({ position: "relative", top: "" });
            }
        });
    });
};

//Social sharing
function  Get(provider) {
    console.log(provider);
}

$("#coin-slider").coinslider({ width: 700, height: 247, delay: 2000, navigation: true });
$("ul.newss").carouFredSel({
    auto: true,
    height: 380,
    scroll: {
        items: 1
    },
    direction: 'up',
    items: {
        visible: 3,
        height: "auto"
    }
});

$(".ulpartner").carouFredSel({
    auto: true,
    height: 550,
    scroll: {
        items: 1
    },
    direction: 'up',
    items: {
        visible: 3,
        height: "auto"
    }
});

var oldval = $("#txtSearch").val();
tuanva.defaultVal($("#txtSearch"), oldval, $("#btnSearch"));

$(".orders").fancybox({
    type: 'ajax'
});


var MainContentW = 1100;
var LeftBoxW = 120;
var RightBoxW = 120;
var LeftAdjust = 1;
var RightAdjust = 1;
var TopAdjust = 205;
var fSpeed = 20;
ShowAdDiv();
window.onresize = ShowAdDiv;

/* http://www.buaxua.vn */
function FloatTopDiv() {
    startLX = ((document.body.clientWidth - MainContentW) / 2) - LeftBoxW - LeftAdjust, startLY = TopAdjust; startRX = ((document.body.clientWidth - MainContentW) / 2) + MainContentW + RightAdjust, startRY = TopAdjust; var d = document; function ml(id)
    { var el = d.getElementById ? d.getElementById(id) : d.all ? d.all[id] : d.layers[id]; el.sP = function(x, y) { this.style.left = x + 'px'; this.style.top = y + 'px'; }; el.x = startRX; el.y = startRY; return el; }
    function m2(id)
    { var e2 = d.getElementById ? d.getElementById(id) : d.all ? d.all[id] : d.layers[id]; e2.sP = function(x, y) { this.style.left = x + 'px'; this.style.top = y + 'px'; }; e2.x = startLX; e2.y = startLY; return e2; }
    window.stayTopLeft = function() {
        if (document.documentElement && document.documentElement.scrollTop)
            var pY = document.documentElement.scrollTop; else if (document.body)
            var pY = document.body.scrollTop; if (document.body.scrollTop > 0) { startLY = TopAdjust; startRY = TopAdjust; } else { startLY = TopAdjust; startRY = TopAdjust; }; ftlObj.y += (pY + startRY - ftlObj.y) / fSpeed; ftlObj.sP(ftlObj.x, ftlObj.y); ftlObj2.y += (pY + startLY - ftlObj2.y) / fSpeed; ftlObj2.sP(ftlObj2.x, ftlObj2.y); setTimeout("stayTopLeft()", 1);
    }
    ftlObj = ml("divAdRight"); ftlObj2 = m2("divAdLeft"); stayTopLeft();
}
function ShowAdDiv() {
    var objAdDivRight = document.getElementById("divAdRight"); var objAdDivLeft = document.getElementById("divAdLeft"); if (document.body.clientWidth < (MainContentW + LeftBoxW + RightBoxW))
    { objAdDivRight.style.display = "none"; objAdDivLeft.style.display = "none"; }
    else
    { objAdDivRight.style.display = "block"; objAdDivLeft.style.display = "block"; FloatTopDiv(); }
}