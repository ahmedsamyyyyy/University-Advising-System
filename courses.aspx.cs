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
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["GUCera"].ToString();

            //new connection

            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand courses = new SqlCommand(connStr);
            courses.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr=courses.ExecuteReader(CommandBehavior.CloseConnection);
            conn.Open();
            while (rdr.Read())
            {
                String courseName = rdr.GetString(rdr.GetOrdinal("name"));
                Label name= new Label();
                name.Text = courseName;
                form1.Controls.Add(name);
            }


            Response.Write(Session["user"]);

        }
    }
}