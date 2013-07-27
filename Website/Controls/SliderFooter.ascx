<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SliderFooter.ascx.cs"
    Inherits="tratancuonghoangbinh.Controls.SliderFooter" %>
<div id="container-partner">
    <a id="prev" class="btnNav" href="#">
        <img src="/Content/images/back.png" />
     </a> 
     <a id="next" class="btnNav" href="#">
            <img src="/Content/images/next.png" />
     </a>
     <div class="partner-jcarouse">
         <ul id="parner-js">
            <%=ListSlide%>
          </ul>
    </div>
    <div class="clear"></div>
</div>
<script type="text/javascript">
     $("#parner-js").carouFredSel({
            auto: true,
            prev: "#prev",
            next: "#next",
            width:934,
            height: 100,
            items: 6,
            scroll: {
                items: 1,
                fx: "directscroll"
            }
        });
</script>
