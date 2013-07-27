<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Sliderbody.ascx.cs" Inherits="tratancuonghoangbinh.Controls.Sliderbody" %>
<%= Sliders %>
<script type="text/javascript">
     $("#coin-slide").coinslider({
        width:986,
        height:350,
        delay:5000,
        navigation:true,
        opacity:1
    });

</script>