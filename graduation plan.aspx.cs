using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class graduation_plan : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
               
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.[FN_StudentViewGP](@student_ID)", conn);
                command.Parameters.AddWithValue("@student_ID", Session["user"]);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable resultTable = new DataTable();

                conn.Open();

                adapter.Fill(resultTable);

                conn.Close();


                GridView3.DataSource = resultTable;
                GridView3.DataBind();


            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2.aspx");
        }
    }
}