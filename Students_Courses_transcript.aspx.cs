using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin
{
    public partial class Students_Courses_transcript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                string query = "SELECT * FROM Students_Courses_transcript ";

                conn.Open();

                using (SqlCommand optionalproc = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rdr = optionalproc.ExecuteReader())
                    {
                        GridView93.DataSource = rdr;
                        GridView93.DataBind();
                    }
                }
            }


        }
        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");


        }
    }
}