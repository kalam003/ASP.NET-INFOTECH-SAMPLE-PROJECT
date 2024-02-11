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
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=True");

        protected void insert_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_product_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@product_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = product_id_txt.Text;
            SqlParameter param2=new SqlParameter("@product_name",SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = product_name_txt.Text;
            SqlParameter param3 = new SqlParameter("@product_cost", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value = product_cost_txt.Text;
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
            SqlCommand cmd = new SqlCommand("sp_tbl_product_view", con);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
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
            SqlCommand cmd = new SqlCommand("sp_tbl_product_upd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@product_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = product_id_txt.Text;
            SqlParameter param2 = new SqlParameter("@product_name", SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = product_name_txt.Text;
            SqlParameter param3 = new SqlParameter("@product_cost", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value = product_cost_txt.Text;
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
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void delete_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_product_dlt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1=new SqlParameter("@product_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value=product_id_txt.Text;
            int i=cmd.ExecuteNonQuery();
            if (i > 0) {
                Response.Write("Data Deleted Successfully");
            }
            else
            {
                Response.Write("Data Not Deleted");
            }
            con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message );
            }
        }

        protected void get_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_product_get", con);
            cmd.CommandType=CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@product_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = product_id_txt.Text;
            using(
                SqlDataReader r=cmd.ExecuteReader())
            {
                if (r.Read())
                {
                    product_name_txt.Text = r["product_name"].ToString();
                    product_cost_txt.Text = r["product_cost"].ToString();

                }
                else
                {
                    Console.WriteLine("No Data Found for this Provided Information");
                }
            }
            con.Close();
            }
            catch( Exception ex )
            {
                Response.Write(ex.Message );
            }
        }
    }
}