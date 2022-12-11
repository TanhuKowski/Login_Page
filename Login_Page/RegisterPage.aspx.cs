using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Page
{
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void btn_register_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            string strcon = "Data Source = MSI\\SQLEXPRESS; Initial Catalog = ASP_Login; Integrated Security = True";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand com = new SqlCommand("register", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter p1 = new SqlParameter("username", txt_user_regs.Text);
            SqlParameter p2 = new SqlParameter("password", txt_pass_regs.Text);
            com.Parameters.Add(p1);
            com.Parameters.Add(p2);
            con.Open();
            SqlDataReader rd = com.ExecuteReader();
            if (rd.HasRows)
            {
                lblmsg.Text = "The User" + txt_user_regs.Text + "has been created!";
                lblmsg.ForeColor = System.Drawing.Color.Green;
                lblmsg.Font.Bold = true;
            }
            else
            {
                lblmsg.Text = "Registration failed!";
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Font.Bold = true;
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}