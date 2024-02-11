<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="WebApplication1.product" %>

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
                    <asp:Label ID="product_lbl" runat="server" Text="Products "></asp:Label>
                </center>
            </div><br /><br /><br />
            <div>
                <center>
                    <asp:TextBox ID="product_id_txt" runat="server" placeholder="Product Id"></asp:TextBox>
                    <asp:Button ID="get_btn" runat="server" Text="Get" OnClick="get_btn_Click" />
                </center>
            </div><br />
            <div>
                <center>
                    <asp:TextBox ID="product_name_txt" runat="server" placeholder="Product Name"></asp:TextBox>
                </center>
            </div><br />
            <div>
                <center>
                    <asp:TextBox ID="product_cost_txt" runat="server" placeholder="Product Cost"></asp:TextBox>
                </center>
            </div><br />
           
            <div>
                <center>
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </center>
            </div>
            <div>
                <center>
                    <asp:Button ID="insert_btn" runat="server" Text="Insert" OnClick="insert_btn_Click" />
                    <asp:Button ID="view_btn" runat="server" Text="View" OnClick="view_btn_Click" />
                    <asp:Button ID="update_btn" runat="server" Text="Update" OnClick="update_btn_Click" />
                    <asp:Button ID="delete_btn" runat="server" Text="Delete" OnClick="delete_btn_Click" />
                </center>
            </div>
        </div>
    </form>
</body>
</html>
