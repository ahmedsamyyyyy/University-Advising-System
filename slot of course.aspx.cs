using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class slot_of_course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    int course_id = Int16.Parse(course_id1.Text);
                    int instructor_id = Int16.Parse(instructor_id1.Text);
                    SqlCommand command = new SqlCommand("SELECT * FROM dbo.[FN_StudentViewSlot](@CourseID)(@InstructorID)", conn);
                    command.Parameters.AddWithValue("@CourseID", course_id);
                    command.Parameters.AddWithValue("@InstructorID", instructor_id);


                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable resultTable = new DataTable();

                    conn.Open();


                    adapter.Fill(resultTable);

                    conn.Close();


                    GridView3.DataSource = resultTable;
                    GridView3.DataBind();


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        protected void Button99_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2.aspx");
        }
    }
}