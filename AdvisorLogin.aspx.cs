using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //new connection

            SqlConnection conn = new SqlConnection(connStr);

                int id = Int16.Parse(username.Text);
                String pass= password.Text;
            SqlCommand loginproc = new SqlCommand("userLogin",conn);
            loginproc.Parameters.Add(new SqlParameter("@id", id));
            loginproc.Parameters.Add(new SqlParameter("@password", pass));

            SqlParameter success = loginproc.Parameters.Add(new SqlParameter("@success",System.Data.SqlDbType.Int));
            SqlParameter type = loginproc.Parameters.Add(new SqlParameter("@type", System.Data.SqlDbType.Int));

            success.Direction = ParameterDirection.Output;
            type.Direction = ParameterDirection.Output;

            conn.Open();
            loginproc.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() == "1")
            {
                Session["user"] = id;
                Response.Write("Hello");
                Response.Redirect("courses.aspx");

            }

        }
    }
}