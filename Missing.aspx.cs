using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Missing : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand missingproc = new SqlCommand("Procedures_ViewMS", conn))
                    {
                        missingproc.Parameters.Add(new SqlParameter("@StudentID", Session["user"]));
                        missingproc.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader rdr = missingproc.ExecuteReader())
                        {
                            GridView1.DataSource = rdr;
                            GridView1.DataBind();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}