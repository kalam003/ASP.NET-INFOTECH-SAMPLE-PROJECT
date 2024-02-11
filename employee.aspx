<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="employee.aspx.cs" Inherits="WebApplication1.employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <center><asp:Label ID="emp_lbl" runat="server" Text="Employee Details"></asp:Label></center>
            </div><br /><br /><br />
          <div>
             <center>
             <asp:TextBox ID="emp_id" runat="server" Placeholder="Employee Id"></asp:TextBox>
                 <asp:Button ID="search" runat="server" Text="search_btn" OnClick="search_Click" />
             </center><br />
          </div>
            <div>
                <center>
                    <asp:TextBox ID="emp_name_txt" runat="server" Placeholder="Employee Name"></asp:TextBox>
                </center><br />
            </div>
            <div>
                <center>
                     <asp:TextBox ID="emp_age_txt" runat="server" Placeholder="Employee Age"></asp:TextBox>
                </center><br />
            </div>
           <div>
               <center>
                   <asp:TextBox ID="emp_salary_txt" runat="server" Placeholder="Employee Salary"></asp:TextBox>
               </center><br />
           </div>
            <div>
                <center>
                    <asp:TextBox ID="emp_mob_txt" runat="server" Placeholder="Employee Mobile Number"></asp:TextBox>
                </center><br /><br />
            </div>
            <div>
                <center>
                    <asp:Button ID="emp_submit_btn" runat="server" Text="Submit" OnClick="emp_submit_btn_Click" BackColor="green"/><asp:Button ID="Btnview" runat="server" Text="View" OnClick="Btnview_Click" />
                    <asp:Button ID="emp_upd_btn" runat="server" Text="Update" OnClick="emp_upd_btn_Click1" />
                    <asp:Button ID="emp_dlt_btn" runat="server" Text="Delete" OnClick="emp_dlt_btn_Click" />
                </center>
            </div>
            <div>
                <center><asp:GridView ID="GridView1" runat="server"></asp:GridView></center>
            </div>
        </div>
    </form>
</body>
</html>
