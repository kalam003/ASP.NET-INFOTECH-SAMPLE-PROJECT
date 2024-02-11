<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <center>
                    <asp:Label ID="login_lbl" runat="server" Text="Login"></asp:Label>
                </center>
            </div><br /><br />
            <div>
                <center>
                    <asp:TextBox ID="username_txt" runat="server" placeholder="User Name"></asp:TextBox>
                </center>
            </div><br />
            <div>
                <center>
                    <asp:TextBox ID="userpwd_txt" runat="server" placeholder="PassWord"></asp:TextBox>
                </center>
            </div><br />
            <div>
                <center>
                <asp:Button ID="login_btn" runat="server" Text="Login" />
                    <asp:Button ID="register_btn" runat="server" Text="Register" OnClick="register_btn_Click" />

                </center>
            </div>
        </div>
    </form>
</body>
</html>
