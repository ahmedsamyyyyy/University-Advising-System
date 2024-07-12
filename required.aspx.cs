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
    public partial class required : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    using (SqlCommand regproc = new SqlCommand("Procedures_ViewRequiredCourses", conn))
                    {
                        regproc.Parameters.Add(new SqlParameter("@StudentID", Session["user"]));

                        if (Session["sems"] is string sems)
                        {
                            regproc.Parameters.Add(new SqlParameter("@current_semester_code", sems));
                        }
                        else
                        {
                            Response.Write("Please Enter A Valid Current Semester Code");
                        }

                        regproc.CommandType = CommandType.StoredProcedure;

                        conn.Open();

                        using (SqlDataReader rdr = regproc.ExecuteReader())
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