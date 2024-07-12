using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Available : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    conn.Open();

                    using (var ex = conn.CreateCommand())
                    {
                        ex.CommandText = "SELECT * FROM [FN_SemsterAvailableCourses](@semstercode)";
                        if (Session["sems"] is string sems)
                        {
                            ex.Parameters.AddWithValue("@semstercode", sems);
                        }
                        else
                        {
                            Response.Write("Please Enter A Valid Current Semester Code");
                        }


                        using (SqlDataReader rdr = ex.ExecuteReader())
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