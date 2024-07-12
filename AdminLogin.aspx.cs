using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Contexts;

namespace admin
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                int id = Int16.Parse(username.Text);
                String pass = password.Text;

                if (id == 1 & pass == "22")
                {
                    Response.Redirect("admin.aspx");
                }
                else
                {
                    Response.Write("Invalid Data");
                }
            }
            catch(Exception ex) {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("M3_Advising_System.aspx");
        }
    }
}