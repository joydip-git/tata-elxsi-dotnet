<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SampleOldWebApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        function call() {
            alert('html button clicked');
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 280px">
            <br />
            <br />
            <br />
            <br />
            <br />
            Enter Value: &nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <!-- aspnet server control-->
            <asp:Button ID="btnClick" runat="server" Text="Click" OnClick="btnClick_Click" />
            <br />
            <input type="button" value="Click HTML" id="btnClick1" onclick="return call()" />
        </div>
    </form>
</body>
</html>
