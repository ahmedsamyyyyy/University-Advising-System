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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int student_ID = Int16.Parse(username.Text);
            int instructor_ID = Int16.Parse(instructorid.Text);
            int course_ID = Int16.Parse(courseid.Text);
            string semscode = semestercode.Text;

            SqlCommand chooseins = new SqlCommand("Procedures_Chooseinstructor", conn);


            chooseins.CommandType = CommandType.StoredProcedure;
            chooseins.Parameters.Add(new SqlParameter("@StudentID",student_ID));
            chooseins.Parameters.Add(new SqlParameter("@instrucorID", instructor_ID));
            chooseins.Parameters.Add(new SqlParameter("@CourseID", course_ID));
            chooseins.Parameters.Add(new SqlParameter("@current_semester_code", semscode));

            conn.Open();
            chooseins.ExecuteNonQuery();

            Response.Write("instructor chosen successfully");

            conn.Close();
        







        }
        //repeattt
        protected void firstmakeup(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int student_id = Int16.Parse(student_id3.Text);
            int course_id44 = Int16.Parse(course_id.Text);
            string semscode = semestercode1.Text;
            

            SqlCommand firstmakeup = new SqlCommand("Procedures_StudentRegisterFirstMakeup", conn);


            firstmakeup.CommandType = CommandType.StoredProcedure;
            firstmakeup.Parameters.Add(new SqlParameter("@StudentID", student_id));
            firstmakeup.Parameters.Add(new SqlParameter("@courseID", course_id44));
            firstmakeup.Parameters.Add(new SqlParameter("@studentCurr_sem", semscode));
           

            conn.Open();
            firstmakeup.ExecuteNonQuery();


            Response.Write("first makeup is registered successfully");

            conn.Close();







        }
        protected void secondmakeup(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int student_id1 = Int16.Parse(student_id.Text);
            int course_id12 = Int16.Parse(course_id11.Text);
            string semestercde = semestercode.Text;


            SqlCommand firstmakeup = new SqlCommand("Procedures_StudentRegisterFirstMakeup", conn);


            firstmakeup.CommandType = CommandType.StoredProcedure;
            firstmakeup.Parameters.Add(new SqlParameter("@StudentID", student_id1));
            firstmakeup.Parameters.Add(new SqlParameter("@courseID", course_id12));
            firstmakeup.Parameters.Add(new SqlParameter("@studentCurr_sem", semestercde));


            conn.Open();
            firstmakeup.ExecuteNonQuery();


            Response.Write("  second makeup is registered successfully");

            conn.Close();







        }




        protected void viewexam (object sender, EventArgs e)
        {
            Response.Redirect("Courses_MakeupExams.aspx"); 
        }
        protected void slot_course(object sender, EventArgs e)
        {
            Response.Redirect("Courses_Slots_Instructor.aspx");
        }
        protected void view_Course(object sender, EventArgs e)
        {
            Response.Redirect("view_Course_prerequisites.aspx");
        }
        protected void graduatonplan(object sender, EventArgs e)
        {
            Response.Redirect("graduation plan.aspx");
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("unpaid installment.aspx");
        }

        protected void course(object sender, EventArgs e)
        {
            Response.Redirect("slot of course .aspx");

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}

            
            

            


                    

        

            
            

            

        



        
    