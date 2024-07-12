using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand registerproc = new SqlCommand("Procedures_StudentRegistration", conn);
                String firstname = firstname1.Text;
                String lastname = lastname1.Text;
                String password = password1.Text;
                String faculty = faculty1.Text;
                String email = email1.Text;
                String major = major1.Text;
                if (int.TryParse(semester1.Text, out int semester))
                {
                    registerproc.Parameters.Add(new SqlParameter("@semester", semester));
                }
                else
                {
                    Response.Write("Invalid Semester Number");
                }

                registerproc.Parameters.Add(new SqlParameter("@first_name", firstname));
                registerproc.Parameters.Add(new SqlParameter("@last_name", lastname));
                registerproc.Parameters.Add(new SqlParameter("@password", password));
                registerproc.Parameters.Add(new SqlParameter("@faculty", faculty));
                registerproc.Parameters.Add(new SqlParameter("@email", email));
                registerproc.Parameters.Add(new SqlParameter("@major", major));
                
                SqlParameter Studentid = registerproc.Parameters.Add("@Student_id", SqlDbType.Int);

                registerproc.CommandType = CommandType.StoredProcedure;

                Studentid.Direction = ParameterDirection.Output;

                conn.Open();
                registerproc.ExecuteNonQuery();
                int Value = Convert.ToInt32(Studentid.Value);
                Response.Write("Registered successfully<br />");
                Response.Write("Your ID is:" + Value + "<br />");
                conn.Close();
            }
            catch (Exception ex)
            {
              Console.WriteLine("An error occurred: " + ex.Message);
            }
        
        }

        protected void login_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentLogin.aspx");
        }
    }
}