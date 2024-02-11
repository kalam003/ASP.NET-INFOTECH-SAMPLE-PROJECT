<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

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
                    <asp:Label ID="register_lbl" runat="server" Text="Register"></asp:Label>
                </center>
            </div><br /><br />
            
            <div>
                <center>
                     <asp:TextBox ID="user_id_txt" runat="server" placeholder="User Id"></asp:TextBox>

                </center>
            </div><br />
            <div>
                <center>
                    <asp:TextBox ID="user_name_txt" runat="server" placeholder="User Name"></asp:TextBox>
                </center>
            </div><br />
            <div>
    <center>
        <asp:TextBox ID="mob_num_txt" runat="server" placeholder="Mobile Number"></asp:TextBox>
    </center>
</div><br />
            <div>
                <center>
                    <asp:Button ID="insert_btn" runat="server" Text="Insert" OnClick="insert_btn_Click" />
                    <asp:Button ID="view_btn" runat="server" Text="View" OnClick="view_btn_Click" />
                    <asp:Button ID="update_btn" runat="server" Text="Update" OnClick="update_btn_Click" />
                    <asp:Button ID="delete_btn" runat="server" Text="Delete" OnClick="delete_btn_Click" />
                    </center>
            </div>
            <div>
                <center>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </center>
            </div>
        </div>
    </form>
</body>
</html>
