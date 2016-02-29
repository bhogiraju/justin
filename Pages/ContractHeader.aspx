<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContractHeader.aspx.cs" Inherits="JG_Prospect.Sr_App.ContractHeader" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<script src="../js/jquery.js"></script>
<head id="Head1" runat="server">
    <title></title>
    <script type="text/javascript">
        //var pdfInfo = {};
        //var x = document.location.search.substring(1).split('&');
        //for (var i in x) { var z = x[i].split('=', 2); pdfInfo[z[0]] = unescape(z[1]); }
        function subst() {
            var body = document.body;
              var html = document.documentElement;

            var height = Math.max(body.scrollHeight, body.offsetHeight,
                                   html.clientHeight, html.scrollHeight, html.offsetHeight);
           // document.getElementById('spnHeight').innerHTML = height;
            }

        //tblItemsBody
    </script>
</head>
<body onload="subst()">
    <form id="form1" runat="server" >
        <div style="width:100%">
           
        <asp:Literal runat="server" ID="ltlHeader"></asp:Literal>
            
            </div>
       
    </form>
</body>
</html>
