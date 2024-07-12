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
    public partial class student_payment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {

                string query = "SELECT * FROM Student_Payment";

                conn.Open();

                using (SqlCommand optionalproc = new SqlCommand(query, conn))
                {

                    using (SqlDataReader rdr = optionalproc.ExecuteReader())
                    {
                        GridView91.DataSource = rdr;
                        GridView91.DataBind();
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