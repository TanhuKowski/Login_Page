using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Login_Page
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection SQLConn = new SqlConnection("Data Source=MSI\\SQLEXPRESS; Initial Catalog=ASP_Login;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            lblmsg.Text = "";
            SqlDataAdapter SQLAdapter = new SqlDataAdapter("Select * from Accounts where username='" + txt_user.Text + "' and password='" + txt_pass.Text + "'", SQLConn);
            DataTable DT = new DataTable();
            SQLAdapter.Fill(DT);

            if (DT.Rows.Count > 0)
            {
                lblmsg.Text = "Welcome to the System";
                lblmsg.ForeColor = System.Drawing.Color.Green;
                lblmsg.Font.Bold = true;
            }

            else
            {
                lblmsg.Text = "Invalid username or password";
                lblmsg.ForeColor = System.Drawing.Color.Red;
                lblmsg.Font.Bold = true;
            }
        }

        protected void btn_register_Click(object sender, EventArgs e)
        {

            Response.Redirect("RegisterPage.aspx");
        }
    }
}