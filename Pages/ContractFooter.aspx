<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContractFooter.aspx.cs" Inherits="JG_Prospect.Sr_App.ContractFooter" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script  type="text/javascript">
        function subst() {
            document.getElementById('spnh').innerHTML = "tesgsas";
            var vars = {};
            var x = document.location.search.substring(1).split('&');

            for (var i in x) {
                var z = x[i].split('=', 2);

                if (!vars[z[0]]) {
                    vars[z[0]] = unescape(z[1]);
                }
            }
            if (vars.page == vars.topage) {
                document.getElementById('spnh').innerHTML = "testFFF";
                var height = document.getElementById("tblItemsBody").offsetHeight;
                document.getElementById('spnh').innerHTML = "test" + height;
            }

        }

    </script>
</head>
<body onload="subst()">
    <form id="form1" runat="server">
    <div align="center" >
    <asp:Image ID="img1" runat="server" style="width:96%" />
    </div>
    </form>
</body>
</html>
