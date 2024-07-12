using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Courses_MakeupExams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {



                string query = "SELECT * FROM Courses_MakeupExams ";

                conn.Open();

                using (SqlCommand optionalproc = new SqlCommand(query, conn))
                {

                    using (SqlDataReader rdr = optionalproc.ExecuteReader())
                    {
                        GridView1.DataSource = rdr;
                        GridView1.DataBind();

                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2.aspx");
        }
    }
}