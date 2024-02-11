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
    public partial class employee : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-SE57Q19;Initial Catalog=abdulasp;Integrated Security=true");

        protected void Page_Load(object sender, EventArgs e)
        {
           
              
           
        }

        protected void emp_submit_btn_Click(object sender, EventArgs e)
        {
            try { 
            
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_emp_ins", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param5 = new SqlParameter("@emp_id", SqlDbType.Int);
            cmd.Parameters.Add(param5).Value = emp_id.Text;
            SqlParameter param1 = new SqlParameter("@emp_name", SqlDbType.NVarChar);
            cmd.Parameters.Add(param1).Value = emp_name_txt.Text;
            SqlParameter param2 = new SqlParameter("@emp_age", SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = emp_age_txt.Text;
            SqlParameter param3 = new SqlParameter("@emp_salary", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value = emp_salary_txt.Text;
            SqlParameter param4 = new SqlParameter("@emp_mob", SqlDbType.NVarChar);
            cmd.Parameters.Add(param4).Value = emp_mob_txt.Text;
            int i = cmd.ExecuteNonQuery();
           
            if (i > 0)
            {
                Response.Write("Data Inserted Sucessfully");
            }
            else
            {
                Response.Write("Data Insertion Failed");
            }
            con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
    

        protected void emp_upd_btn_Click(object sender, EventArgs e)
        {
            //con.Open();  // Open the connection here

            //SqlCommand cmd = new SqlCommand("sp_tbl_emp_upd", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //SqlParameter param1 = new SqlParameter("@emp_id", SqlDbType.Int);
            //cmd.Parameters.Add(param1).Value = emp_id.Text;
            //SqlParameter param2 = new SqlParameter("@emp_name", SqlDbType.NVarChar);
            //cmd.Parameters.Add(param2).Value = emp_name_txt.Text;
            //SqlParameter param3 = new SqlParameter("@emp_age", SqlDbType.NVarChar);
            //cmd.Parameters.Add(param3).Value = emp_age_txt.Text;
            //SqlParameter param4 = new SqlParameter("@emp_salary", SqlDbType.NVarChar);
            //cmd.Parameters.Add(param4).Value = emp_salary_txt.Text;
            //SqlParameter param5 = new SqlParameter("@emp_mob", SqlDbType.NVarChar);
            //cmd.Parameters.Add(param5).Value = emp_mob_txt.Text;
            //int i = cmd.ExecuteNonQuery();
            

            //if (i > 0)
            //{
            //    Response.Write("Data Updated Successfully");
            //}
            //else
            //{
            //    Response.Write("Data Updated Failed");
            //}

            //con.Close();
        }

        protected void emp_dlt_btn_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_tbl_emp_dlt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@emp_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = emp_id.Text;

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
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void search_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("sp_getstd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@emp_id", emp_id.Text);
            using (SqlDataReader r= cmd.ExecuteReader())
            {
                if(r.Read())
                {
                    emp_name_txt.Text = r["emp_name"].ToString();
                    emp_age_txt.Text = r["emp_age"].ToString();
                    emp_salary_txt.Text = r["emp_salary"].ToString();
                    emp_mob_txt.Text = r["emp_mob"].ToString();
                }
                else
                {
                    Response.Write("No data found for the provided Mobile number.");
                }
            }
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }

        }

        protected void Btnview_Click(object sender, EventArgs e)
        {
            try { 
            SqlCommand cmd = new SqlCommand("exec sp_tbl_emp_view", con);
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

        protected void emp_upd_btn_Click1(object sender, EventArgs e)
        {
            try { 
            con.Open();  // Open the connection here

            SqlCommand cmd = new SqlCommand("sp_tbl_emp_upd", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter param1 = new SqlParameter("@emp_id", SqlDbType.Int);
            cmd.Parameters.Add(param1).Value = emp_id.Text;
            SqlParameter param2 = new SqlParameter("@emp_name", SqlDbType.NVarChar);
            cmd.Parameters.Add(param2).Value = emp_name_txt.Text;
            SqlParameter param3 = new SqlParameter("@emp_age", SqlDbType.NVarChar);
            cmd.Parameters.Add(param3).Value = emp_age_txt.Text;
            SqlParameter param4 = new SqlParameter("@emp_salary", SqlDbType.NVarChar);
            cmd.Parameters.Add(param4).Value = emp_salary_txt.Text;
            SqlParameter param5 = new SqlParameter("@emp_mob", SqlDbType.NVarChar);
            cmd.Parameters.Add(param5).Value = emp_mob_txt.Text;
            int i = cmd.ExecuteNonQuery();


            if (i > 0)
            {
                Response.Write("Data Updated Successfully");
            }
            else
            {
                Response.Write("Data Updated Failed");
            }

            con.Close();
            }
            catch(Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}