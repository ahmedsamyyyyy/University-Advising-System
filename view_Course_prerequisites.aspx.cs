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
    public partial class view_Course_prerequisites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {



                string query = "SELECT * FROM view_Course_prerequisites ";

                conn.Open();

                using (SqlCommand optionalproc = new SqlCommand(query, conn))
                {

                    // Use SqlDataReader to retrieve the result set
                    using (SqlDataReader rdr = optionalproc.ExecuteReader())
                    {
                        // Check if the reader has rows
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