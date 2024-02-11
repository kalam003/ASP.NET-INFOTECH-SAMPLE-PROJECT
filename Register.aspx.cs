using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=True");
        protected void insert_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_register_ins", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@user_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value= user_id_txt.Text;
            SqlParameter param2 = new SqlParameter("@user_name", SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = user_name_txt.Text;
            SqlParameter param3 = new SqlParameter("mob_no", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value=mob_num_txt.Text;
            int i=cmd.ExecuteNonQuery();
            if(i>0)
            {
                Response.Write("Data Inserted Successfully");
            }
            else
            {
                Response.Write("Data Not Inserted Successfully");
            }
            con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void view_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_register_view", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_register_update", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@user_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = user_id_txt.Text;
            SqlParameter param2 = new SqlParameter("@user_name", SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = user_name_txt.Text;
            SqlParameter param3 = new SqlParameter("mob_no", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value = mob_num_txt.Text;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Updated Successfully");
            }
            else
            {
                Response.Write("Data Not Updated Successfully");
            }
            con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void delete_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_register_dlt", con);
            cmd.CommandType= CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@user_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = user_id_txt.Text;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Deleted Successfully");
            }
            else
            {
                Response.Write("Data Not Deleted Successfully");
            }
            con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}