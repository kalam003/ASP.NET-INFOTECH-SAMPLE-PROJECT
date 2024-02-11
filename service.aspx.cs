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
    public partial class service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void insert_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=True");
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_service_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@service_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = service_id_txt.Text;
            SqlParameter param2 = new SqlParameter("@service_name", SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = service_name_txt.Text;
            SqlParameter param3 = new SqlParameter("@service_cost", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value = service_cost_txt.Text;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Inserted Successfully");

            }
            else
            {
                Response.Write("Data Not Inserted ");
            }
            con.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void view_btn_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=True");

            SqlCommand cmd = new SqlCommand("sp_tbl_service_view", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            }
            catch(Exception ex) { 
            }
        }

        protected void update_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_services_upd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@service_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = service_id_txt.Text;
            SqlParameter param2 = new SqlParameter("@service_name", SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = service_name_txt.Text;
            SqlParameter param3 = new SqlParameter("@service_cost", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value = service_cost_txt.Text;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Updated Successfully");

            }
            else
            {
                Response.Write("Data Not Updated ");
            }
            con.Close();

        }

        protected void delete_btn_Click(object sender, EventArgs e)
        {
            try { 
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_services_dlt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@service_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = service_id_txt.Text;
            int i = cmd.ExecuteNonQuery();

            if (i > 0)
            {
                Response.Write("Data Deleted Sucessfully");
            }
            else
            {
                Response.Write("Data Deleted Failed");
            }
            con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void get_btn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_services_get", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@service_id", service_id_txt.Text);
            using (SqlDataReader r = cmd.ExecuteReader())
            {
                if (r.Read())
                {
                    service_name_txt.Text = r["service_name"].ToString();
                    service_cost_txt.Text = r["service_cost"].ToString();

                }
                else
                {
                    Response.Write("No data found for the provided Mobile number.");
                }
                con.Close();
            }
        }
    }
}