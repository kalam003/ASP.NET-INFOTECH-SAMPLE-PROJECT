<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="service.aspx.cs" Inherits="WebApplication1.service" %>

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
                    <asp:Label ID="service_lbl" runat="server" Text="Service Details" Font-Size="Large"></asp:Label>
                </center><br /><br /><br />
            </div>
            <div>
                <center>
                    <asp:TextBox ID="service_id_txt" runat="server" placeholder="Service Id"></asp:TextBox>
                    <asp:Button ID="get_btn" runat="server" Text="Get" OnClick="get_btn_Click" />
                </center>
            </div><br />
            <div>
                <center>
                    <asp:TextBox ID="service_name_txt" runat="server" placeholder="Service Name"></asp:TextBox>
                </center>
            </div><br />
            <div>
                <center>
                    <asp:TextBox ID="service_cost_txt" runat="server" placeholder="Service Cost"></asp:TextBox>
                </center>
            </div><br /><br />
            <div>
               <center> <asp:Button ID="insert_btn" runat="server" Text="Insert" BackColor="Green" OnClick="insert_btn_Click" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="view_btn" runat="server" Text="View" BackColor="Yellow" OnClick="view_btn_Click" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="update_btn" runat="server" Text="Update" BackColor="Blue" OnClick="update_btn_Click" />&nbsp;&nbsp;&nbsp;
                <asp:Button ID="delete_btn" runat="server" Text="Delete" BackColor="Red" OnClick="delete_btn_Click" />
                   </center>


            </div><br /><br /><br />
        </div>
        <center>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </center>
    </form>
</body>
</html>
