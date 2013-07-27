<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Website.admin.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script src="/Content/ckfinder/ckfinder.js" type="text/javascript"></script>

    <script type="text/javascript">
        var finder = new CKFinder();
        finder.BasePath = "/Content/ckfinder/";
        finder.SelectFunction = MyFunc;
        finder.Create();

        function MyFunc(fileUrl, data) {
            alert('The selected file URL is "' + fileUrl + '"');

            var formatDate = function(date) {
                return date.substr(0, 4) + "-" + date.substr(4, 2) + "-" + date.substr(6, 2) + " " + date.substr(8, 2) + ":" + date.substr(10, 2);
            };

            alert('The selected file URL is: "' + data['fileUrl'] + '"');
            alert('The size of selected file is: "' + data['fileSize'] + 'KB"');
            alert('The selected file was last modifed on: "' + formatDate(data['fileDate']) + '"');
            alert('The data passed to the function is: "' + data['selectFunctionData'] + '"');
        }
    </script>

</head>
<body>
    CartUtility.js:137<table class="tbl_Giohang">
        <tr class="tbl_head">
            <th scope="col">
                Sản phẩm
            </th>
            <th scope="col">
                Giá bán
            </th>
            <th scope="col">
                Số lượng
            </th>
            <th scope="col">
                Hủy
            </th>
        </tr>
        <tr>
            <td>
                NaN<tr>
                    <td>
                        <img src="/ImageHandler.ashx?height=70&image=/0/8/" alt="12e2" style="height: 70px" />
                    </td>
                    <td>
                        <a href="/dieu-hoa-dan-dung-nakawada/udw-c24p8s3.aspx" title="ưdw">ưdw</a>
                    </td>
                </tr>
    </table>
    </td><td>
        1222424
    </td>
    <td>
        <div style="margin-bottom: 5px;">
            <div style="margin: 5px 5px 5px 5px; text-align: center">
                <input type="text" value="1222424" style="width: 50px;" class="input-row-quan" /></div>
        </div>
    </td>
    <td align="center">
        <a href=''>Cập nhật</a> | <a href="">Xóa</a>
    </td>
    </tr><tr>
        <td>
            NaN<tr>
                <td>
                    <img src="/ImageHandler.ashx?height=70&image=/0/10/" alt="222" style="height: 70px" />
                </td>
                <td>
                    <a href="/dieu-hoa-dan-dung-nakawada/fgefef-c24p10s3.aspx" title="fgefef">fgefef</a>
                </td>
            </tr>
            </table>
        </td>
        <td>
            123445
        </td>
        <td>
            <div style="margin-bottom: 5px;">
                <div style="margin: 5px 5px 5px 5px; text-align: center">
                    <input type="text" value="123445" style="width: 50px;" class="input-row-quan" /></div>
            </div>
        </td>
        <td align="center">
            <a href=''>Cập nhật</a> | <a href="">Xóa</a>
        </td>
    </tr>
    <tr>
        <td>
            NaN<tr>
                <td>
                    <img src="/ImageHandler.ashx?height=70&image=/0/6/dieu-hoa-reetech-rd-l1e.jpg" alt="eeee"
                        style="height: 70px" />
                </td>
                <td>
                    <a href="/dieu-hoa-dan-dung-nakawada/dieu-hoa-reetech-rd-l1e-c24p6s3.aspx" title="ĐIỀU HÒA REETECH RD-L1E">
                        ĐIỀU HÒA REETECH RD-L1E</a>
                </td>
            </tr>
            </table>
        </td>
        <td>
            15000
        </td>
        <td>
            <div style="margin-bottom: 5px;">
                <div style="margin: 5px 5px 5px 5px; text-align: center">
                    <input type="text" value="45000" style="width: 50px;" class="input-row-quan" /></div>
            </div>
        </td>
        <td align="center">
            <a href=''>Cập nhật</a> | <a href="">Xóa</a>
        </td>
    </tr>
    </table>
</body>
</html>
