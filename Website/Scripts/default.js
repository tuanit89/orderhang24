$(window).load(function () { 
    $(".thuonghieu ul li a img").each(function () {
        $(this).css("margin-top", (83 - $(this).height())/2);
    });
});
$(document).ready(function () {

    $(".thuonghieu ul li a img").each(function () {
        $(this).css("margin-top", (83 - $(this).height())/2);
    });
    $('#mycarousel').jcarousel({
        auto: 2,
        wrap: 'last',
        initCallback: mycarousel_initCallback
    });
    //gender
    $(".gender a").live('click', function (e) {
        e.preventDefault();
        $(".gender a span.chk").removeClass("yes");
        $(this).find("span.chk").addClass("yes");
        var ids = "";
        if ($(".gender a #spMale").hasClass("yes")) {
            ids = "Nam";
        }
        if ($(".gender a #spFemale").hasClass("yes")) {
            ids = "Nữ";
        }
        $("#gender").val(ids);

    });
    //register
    $(".singup_form .btn_reg").click(function () {

        var u = document.getElementById("username");
        var p = document.getElementById("pass");
        var pc = document.getElementById("passcomfig");
        var fn = document.getElementById("fullname");
        var m = document.getElementById("email");
        var ph = document.getElementById("phone");
        var h = document.getElementById("homenumber");
        var s = document.getElementById("street");
        var q = document.getElementById("quanhuyen");
        var c = document.getElementById("city");
        //
        var username = $(".from_left .username").val();
        var pass = $(".from_left .password").val();
        var passcomfig = $(".from_left .passwordcomfig").val();
        var fullname = $(".from_left .fullname").val();
        var mail = $(".from_left .email").val();
        var phone = $(".from_left .phone").val();
        var gender = $(".from_left .genderss").val();
        var birthday = $(".from_left .birthday").val();

        var homenumber = $(".from_left .homenumber").val();
        var street = $(".from_left .street").val();
        var quanhuyen = $(".from_left .quanhuyen").val();
        var city = $(".from_left .city").val();
        var option = $(".from_left .option").val();
        var erro = document.getElementById("er_ct");
        if (username == '') {
            erro.innerHTML = "Bạn chưa nhập Tên đăng nhập";
            $(".from_left .username").focus();
            return;
        }
        if (check_save_users(username) == false) {
            return;
        }
        if (pass == "") {
            erro.innerHTML = "Bạn chưa nhập Mật khẩu";
            $(".from_left .password").focus();
            return;
        }
        if (passcomfig == "") {
            erro.innerHTML = "Bạn chưa nhập lại Mật khẩu";
            $(".from_left .passwordcomfig").focus();
            return;
        }
        if (passcomfig != pass) {
            erro.innerHTML = "Mật khẩu không trùng khớp";
            $(".from_left .passwordcomfig").focus();
            return;
        }
        if (fullname == "") {
            erro.innerHTML = "Bạn chưa nhập Họ tên";
            $(".from_left .fullname").focus();
            return;
        }
        if (mail == "") {
            erro.innerHTML = "Bạn chưa nhập Email";
            $(".from_left .email").focus();
            return;
        }
        if (phone == "") {
            erro.innerHTML = "Bạn chưa nhập Số điện thoại";
            $(".from_left .phone").focus();
            return;
        }
        if (gender == "") {
            erro.innerHTML = "Bạn chưa chọn Giới tính";
            $(".from_left .genderss").focus();
            return;
        }

        if (birthday == "") {
            erro.innerHTML = "Bạn chưa nhập Ngày sinh";
            $(".from_left .birthday").focus();
            return;
        }
        if (homenumber == "") {
            erro.innerHTML = "Bạn chưa nhập Số nhà";
            $(".from_left .homenumber").focus();
            return;
        }
        if (street == "") {
            erro.innerHTML = "Bạn chưa nhập Đường/Phố";
            $(".from_left .street").focus();
            return;
        }
        if (quanhuyen == "") {
            erro.innerHTML = "Bạn chưa nhập Quận/Huyện";
            $(".from_left .quanhuyen").focus();
            return;
        }
        if (city == "") {
            erro.innerHTML = "Bạn chưa nhập Thành phố";
            $(".from_left .city").focus();
            return;
        }

        else {
            $("#Loading").css({ display: 'block' });
            $("#Loading").fadeIn(); //show when submitting
            erro.innerHTML = "";
            $.ajax({
                url: "/ajax/Register.cshtml",
                data: { username: username, pass: pass, fullname: fullname, phone: phone, mail: mail, homenumber: homenumber, gender: gender, birthday: birthday, street: street, quanhuyen: quanhuyen, city: city, option: option },
                success: function (data) {
                    if (data == "1") {
                        alert("Chúc mừng bạn đã đăng ký thành công!");
                        $("#Loading").fadeOut("fast");
                        if ($("#Loading").fadeOut()) {
                            $(".from_left .username").val("");
                            $(".from_left .password").val("");
                            $(".from_left .passwordcomfig").val("");
                            $(".from_left .fullname").val("");
                            $(".from_left .email").val("");
                            $(".from_left .phone").val("");
                            $(".from_left .homenumber").val("");
                            $(".from_left .genderss").val("");
                            $(".from_left .birthday").val("");
                            $(".from_left .street").val("");
                            $(".from_left .quanhuyen").val("");
                            $(".from_left .city").val("");
                        }
                    }
                    else if (data == "2") {
                        alert("Email không hợp lệ");
                        $("#Loading").fadeOut("fast");
                        $(".from_left .email").select();
                    }
                    else if (data == "3") {
                        alert("Email đã được đăng ký! Bạn vui lòng kiểm tra lại");
                        $("#Loading").fadeOut("fast");
                        $(".from_left .email").select();
                    }
                    else if (data == "4") {
                        alert("Tài khoản đã được đăng ký! Bạn vui lòng kiểm tra lại.");
                        $("#Loading").fadeOut("fast");
                        $(".from_left .username").select();
                    }
                }
            });
        }
    });
    //chang pass
    $(".singin-infor .btn_forpass").click(function () {
        var email = $(".singin-infor .email").val();
        if (email == "") {
            alert("Bạn chưa nhập địa chỉ email");
        }
        else {
            $("#Loading").css({ display: 'block' });
            $("#Loading").fadeIn(); //show when submitting
            $.ajax({
                url: "/ajax/ForgetPass.cshtml",
                data: { email: email },
                success: function (data) {
                    if (data == "1") {
                        alert("Mật khẩu của bạn đã được gửi vào mail.\n Vui lòng check mail để lấy lại mật khẩu");
                        $("#Loading").fadeOut("fast");
                        $(".singin-infor .email").val("");
                    }
                    else if (data == "2") {
                        alert("Email không tồn tại");
                        $("#Loading").fadeOut("fast");
                        $(".singin-infor .email").select();
                    }
                    else if (data == "3") {
                        alert("Đã có lỗi xảy ra! Vui lòng thử lại.");
                        $("#Loading").fadeOut("fast");
                        $(".singin-infor .email").select();
                    }
                }
            });
        }
    });

    //select checklist
    $(".options a").live('click', function (e) {
        e.preventDefault();
        if ($(this).find("span.chk").hasClass("yes")) {
            $(this).find("span.chk").removeClass("yes");
        }
        else {
            $(this).find("span.chk").addClass("yes");
        }
        var ids = "";
        $(".options a").each(function () {
            if ($(this).find("span.chk").hasClass("yes")) {
                ids = ids + $(this).attr("href") + ",";
            }
        });
        $("#option").val(ids);
    });
    //load poll
    $(".lst-cate li a").live('click', function (e) {
        e.preventDefault();
        if ($(this).find("span.chk").hasClass("yes")) {
            $(this).find("span.chk").removeClass("yes");
        }
        else {
            $(this).find("span.chk").addClass("yes");
        }
        var ids = "";
        $(".lst-cate li a").each(function () {
            if ($(this).find("span.chk").hasClass("yes")) {
                ids = ids + $(this).attr("href") + ",";
            }
        });
        $("#cateids").val(ids);
    });

    //send poll
    $(".box_content .send").click(function () {
        var id = $(".box_content .idpol").val();
        if (id == "") {
            alert("Bạn chưa cho ý kiến đánh giá!");
        }
        else {
            $.ajax({
                url: "/ajax/Savepoll.aspx",
                data: { id: id },
                success: function (data) {
                    alert("Bạn đã gửi đánh giá thành công!");
                }
            });
        }
    });
    //send contact
    $(".box_content_big .send_contact").click(function () {
        var ero = document.getElementById("er_ct");
        var message = document.getElementById("message-contact");
        var fullname = $(".box_content_big .fullname").val();
        var phone = $(".box_content_big .phone").val();
        var email = $(".box_content_big .email").val();
        var content = $(".box_content_big .content").val();
        var contactid = $(".box_content_big .hi_id").val();
        var memLogin = $(".sessionLogin").attr("rel");
        if (fullname == '') {
            ero.innerHTML = "<strong>Lỗi</strong> : Bạn chưa nhập họ tên";
            return;
        }
        if (phone == '') {
            ero.innerHTML = "<strong>Lỗi</strong> : Bạn chưa nhập số điện thoại";
            return;
        }
        if (email == '') {
            ero.innerHTML = "<strong>Lỗi</strong> : Bạn chưa nhập email";
            return;
        }
        //        if (content == '') {
        //            ero.innerHTML = "<strong>Lỗi</strong> : Bạn chưa nhập nội dung";
        //            return;
        //        }
        ero.innerHTML = "";
        $("#Loading").css({ display: 'block' });
        $("#Loading").fadeIn(); //show when submitting
        if (memLogin != 'undefined' && memLogin.toString() == '1') {
            $.ajax({
                url: "/ajax/SaveContact.aspx",
                data: { fullname: fullname, phone: phone, email: email, content: content, contactid: contactid },
                success: function (data) {
                    if (data == "1") {
                        alert("Bạn đã gửi thông tin liên hệ thành công");
                        // message.innerHTML = "Bạn đã gửi thông tin liên hệ thành công !";
                        $("#Loading").fadeOut("fast");
                        if ($("#Loading").fadeOut()) {
                            $(".box_content_big .fullname").val("");
                            $(".box_content_big .phone").val("");
                            $(".box_content_big .email").val("");
                            $(".box_content_big .content").val("");
                        }
                    }
                    else if (data == "2") {
                        $("#Loading").fadeOut("fast");
                        //alert("Địa chỉ email không hợp lệ!");
                        ero.innerHTML = "<strong>Lỗi</strong> :Địa chỉ email không hợp lệ!";
                        $(".box_content_big .email").select();
                    }
                    else {
                        $("#Loading").fadeOut("fast");
                        // alert("Đã có lỗi xảy ra, vui lòng kiểm tra lai!");
                        message.innerHTML = "Đã có lỗi xảy ra, vui lòng kiểm tra lại!";
                    }
                }
            });
        } else {
            message.innerHTML = "Bạn phải đăng nhập trước khi gửi liên hệ !";
            $("#Loading").fadeOut("fast");
        }

    });

    /* Send feedback */
    $(".feedback_content .btnSend-fb").click(function () {
        var name = $(".feedback_content  .name").val();
        var email = $(".feedback_content  .email").val();
        var content = $(".feedback_content .content").val();
        var productId = $(".feedback_content .productId").val();
        var memLogin = $(".sessionLogin").attr("rel");
        var message = document.getElementById("message-fb");
        if (name == 'Họ tên') {
            message.innerHTML = "Bạn chưa nhập tên";
            return;
        }
        else {
            message.innerHTML = "";
        }
        if (email == 'Email của bạn') {
            message.innerHTML = "Bạn chưa email";
            return;
        }
        else {
            message.innerHTML = "";
        }
        if (content == '') {
            message.innerHTML = "Bạn chưa nhập nội dung phản hồi";
            return;
        }
        else {
            message.innerHTML = "";
        }
        $("#Loading").fadeIn();
        if (memLogin.toString() == "1") {
            $.ajax({
                url: "/ajax/SendFeedback.aspx",
                data: { name: name, email: email, content: content, productId: productId },
                success: function (data) {
                    if (data == "1") {
                        message.innerHTML = "";
                        alert("Bạn đã gửi phản hồi thành công!");
                        $("#Loading").fadeOut('fast');
                    }
                    else {
                        //alert("Việc gửi phản hồi của bạn thất bại,vui lòng thử lại !");
                        message.innerHTML = "Việc gửi phản hồi của bạn thất bại,vui lòng thử lại !";
                        $("#Loading").fadeOut('fast');
                    }
                }
            });
        }
        else {
            //alert("Bạn phải đăng nhập trước khi gửi phản  hồi !");
            message.innerHTML = "Bạn phải đăng nhập trước khi gửi phản  hồi !";
            $("#Loading").fadeOut("fast");
        }
    });

    /*Play video*/
    flowplayer(".player", "/css/flowplayer/flowplayer-3.2.11.swf", {
        plugins: {
            lighttpd: {
                url: "flowplayer.pseudostreaming-3.2.9.swf"
            }
        }
    });
    $(".ajax").colorbox({ width: "50%" });
});
function mycarousel_initCallback(carousel) {
    // Disable autoscrolling if the user clicks the prev or next button.
    carousel.buttonNext.bind('click', function () {
        carousel.startAuto(0);
    });

    carousel.buttonPrev.bind('click', function () {
        carousel.startAuto(0);
    });

    // Pause autoscrolling if the user moves with the cursor over the clip.
    carousel.clip.hover(function () {
        carousel.stopAuto();
    }, function () {
        carousel.startAuto();
    });
};
function CallPrint(strid) {
    var prtContent = document.getElementById(strid);
    var WinPrint = window.open('', 'TrackHistoryData', 'width=420,height=225,top=250,left=345,toolbars=no,scrollbars=no,status=no,resizable=no');
    WinPrint.document.write(prtContent.innerHTML);
    WinPrint.document.close();
    //WinPrint.focus();
    WinPrint.print();
    WinPrint.close();
}
function check_save_users(obuser) {
    var specialchar = new Array(32);
    specialchar[0] = " ";
    specialchar[1] = ".";
    specialchar[2] = "!";
    specialchar[3] = "@";
    specialchar[4] = "#";
    specialchar[5] = "$";
    specialchar[6] = "%";
    specialchar[7] = "^";
    specialchar[8] = "&";
    specialchar[9] = "*";
    specialchar[10] = "`";
    specialchar[11] = ".";
    specialchar[12] = ">";
    specialchar[13] = "<";
    specialchar[14] = "?";
    specialchar[15] = "{";
    specialchar[16] = "}";
    specialchar[17] = "[";
    specialchar[18] = "]";
    specialchar[19] = ",";
    specialchar[20] = "?";
    specialchar[21] = ":";
    specialchar[22] = ";";
    specialchar[23] = "'";
    specialchar[24] = "\"";
    specialchar[25] = "\\";
    specialchar[26] = "\/";
    specialchar[27] = "\|";
    specialchar[28] = "+";
    specialchar[29] = "=";
    specialchar[30] = "-";
    specialchar[31] = "~";
    var Name = obuser;
    var Messageerro = document.getElementById("er_ct");

    if (Name.length != "") {
        if (Name.length < 5) {
            Messageerro.innerHTML = "Tài khoản đăng nhập ít nhất 5 ký tự !";
            document.getElementById("username").focus();
            return false;
        }  
        else {
            var i = -1;
            var x = 0;
            for (x = 0; x < 32; x++) {
                i = Name.indexOf(specialchar[x]);
                if (i >= 0) {
                    Messageerro.innerHTML = "Tài khoản đăng nhập không được chứa ký tự đặc biệt <font style='color:green'>" + specialchar[x] + "</font>";
                    document.getElementById("username").focus();
                    return false;

                }
            }
        }
    }
} 