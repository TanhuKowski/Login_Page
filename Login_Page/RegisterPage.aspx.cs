using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
            SqlCommand cmd = new SqlCommand("register", con);
            con.Open();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", txt_user_regs.Text);
            cmd.Parameters.AddWithValue("@password", txt_pass_regs.Text);
            cmd.Parameters.Add(new SqlParameter()
            {
                Direction = ParameterDirection.Output,
                ParameterName = "@status",
                SqlDbType = SqlDbType.Int
            });
            con.Close();
            cmd.ExecuteNonQuery();
            lblmsg.Text = "The user has been created!";

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}