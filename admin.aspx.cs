using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("list advisor.aspx");

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("list student and advisor.aspx");
        }
        protected void Button4_Click(object sender, EventArgs e)  
        {
            Response.Redirect("pending request.aspx");

        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            try
            {

                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                DateTime start_date = DateTime.Parse(startdate.Text);
                DateTime end_date = DateTime.Parse(enddate.Text);
                String semester = semester_code.Text;
                SqlCommand addsemester = new SqlCommand("AdminAddingSemester", conn);

                addsemester.CommandType = System.Data.CommandType.StoredProcedure;
                addsemester.Parameters.Add(new SqlParameter("@start_date", start_date));
                addsemester.Parameters.Add(new SqlParameter("@end_date", end_date));
                addsemester.Parameters.Add(new SqlParameter("@semester_code", semester));

                conn.Open();
                addsemester.ExecuteNonQuery();
                Response.Write("A new semester is added !");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }

        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            try
            {


                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);
                String m = major.Text;
                int s = Int16.Parse(semester.Text);
                int ch = Int16.Parse(credit_hours.Text);
                string name = course_name.Text;
                int offe = Int16.Parse(offered.Text);

                SqlCommand addcourse = new SqlCommand("Procedures_AdminAddingCourse", conn);
                addcourse.CommandType = System.Data.CommandType.StoredProcedure;
                addcourse.Parameters.Add(new SqlParameter("@major", m));
                addcourse.Parameters.Add(new SqlParameter("@semester", s));
                addcourse.Parameters.Add(new SqlParameter("@credit_hours", ch));
                addcourse.Parameters.Add(new SqlParameter("@name", name));
                addcourse.Parameters.Add(new SqlParameter("@is_offered", offe));


                conn.Open();
                addcourse.ExecuteNonQuery();
                Response.Write("A new course is added !");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }

        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                int IID = Int16.Parse(instructor_id.Text);
                int CID = Int16.Parse(course_id.Text);
                int SID = Int16.Parse(slot_id.Text);

                SqlCommand linkInstructortocourse = new SqlCommand("Procedures_AdminLinkInstructor", conn);
                linkInstructortocourse.CommandType = System.Data.CommandType.StoredProcedure;
                linkInstructortocourse.Parameters.Add(new SqlParameter("@cours_id", CID));
                linkInstructortocourse.Parameters.Add(new SqlParameter("@instructor_id", IID));
                linkInstructortocourse.Parameters.Add(new SqlParameter("@slot_id", SID));


                conn.Open();
                linkInstructortocourse.ExecuteNonQuery();
                Response.Write("Linked instructor of course to a slot !");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }

        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);
                int aID = Int16.Parse(advisor_id.Text);
                int sID = Int16.Parse(student_id.Text);

                SqlCommand linkstudenttoadvisor = new SqlCommand("Procedures_AdminLinkStudentToAdvisor", conn);
                linkstudenttoadvisor.CommandType = System.Data.CommandType.StoredProcedure;
                linkstudenttoadvisor.Parameters.Add(new SqlParameter("@advisorID", aID));
                linkstudenttoadvisor.Parameters.Add(new SqlParameter("@studentID", sID));


                conn.Open();
                linkstudenttoadvisor.ExecuteNonQuery();
                Response.Write("Student linked to an Advisor !");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }

        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            try { 
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            SqlConnection conn = new SqlConnection(connStr);

            int iID = Int16.Parse(TextBox1.Text);
            int sID = Int16.Parse(TextBox4.Text);
            int cID = Int16.Parse(TextBox2.Text);
            string semcode = TextBox3.Text;

            SqlCommand linkstudenttocourse = new SqlCommand("Procedures_AdminLinkStudent", conn);

            linkstudenttocourse.CommandType = System.Data.CommandType.StoredProcedure;

            linkstudenttocourse.Parameters.Add(new SqlParameter("@instructor_id", iID));
            linkstudenttocourse.Parameters.Add(new SqlParameter("@cours_id", cID));
            linkstudenttocourse.Parameters.Add(new SqlParameter("@studentID", sID));
            linkstudenttocourse.Parameters.Add(new SqlParameter("@semester_code", semcode));

            conn.Open();
            linkstudenttocourse.ExecuteNonQuery();
            Response.Write("Student linked to course with instructor !");
            conn.Close();
        }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }
        }
        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("view instructor with assigned hours.aspx");

        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Semster_offered_Courses.aspx");
        }



        /////////////////////////////////////
        ///

        protected void Button91_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
               
                SqlConnection conn = new SqlConnection(connStr);

                int courseid = Int16.Parse( TextBox91.Text);
                SqlCommand deletecourse = new SqlCommand("Procedures_AdminDeleteCourse", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                deletecourse.Parameters.Add(new SqlParameter("@courseID", courseid));

                conn.Open();
                _ = deletecourse.ExecuteNonQuery();
                Response.Write("The Course is deleted with it's slots");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }

        }

        protected void Button92_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
          
                SqlConnection conn = new SqlConnection(connStr);

                string current_semester = TextBox92.Text;
                SqlCommand deleteslot = new SqlCommand("Procedures_AdminDeleteSlots", conn)
                {
                    CommandType = System.Data.CommandType.StoredProcedure
                };
                deleteslot.Parameters.Add(new SqlParameter("@current_semester", current_semester));

                conn.Open();
                deleteslot.ExecuteNonQuery();
                Response.Write("Deleted the slots of course because it is not offered in this semester !");

                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }

        
        }

        protected void Button93_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                string examtype = TextBox931.Text;
                DateTime date = DateTime.Parse(TextBox932.Text);
                int courseid = Int16.Parse(TextBox933.Text);
                SqlCommand addexam = new SqlCommand("Procedures_AdminAddExam", conn);
                addexam.CommandType = System.Data.CommandType.StoredProcedure;
                addexam.Parameters.Add(new SqlParameter("@Type", examtype));
                addexam.Parameters.Add(new SqlParameter("@date", date));
                addexam.Parameters.Add(new SqlParameter("@courseID", courseid));

                conn.Open();
                addexam.ExecuteNonQuery();
                Response.Write("Added makeup exam for the course !");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }
        }

        protected void Button94_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_payment.aspx");


        }

        protected void Button95_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);

                int payment_id = Int16.Parse(TextBox94.Text);
                SqlCommand IssueInstallment = new SqlCommand("Procedures_AdminIssueInstallment ", conn);
                IssueInstallment.CommandType = System.Data.CommandType.StoredProcedure;

                IssueInstallment.Parameters.Add(new SqlParameter("@payment_id", payment_id));

                conn.Open();
                IssueInstallment.ExecuteNonQuery();
                Response.Write("Issued installments for the payment !");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message + "  Please try again");
            }
        }

        protected void Button96_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                SqlConnection conn = new SqlConnection(connStr);

                int student_id = Int16.Parse(TextBox95.Text);
                SqlCommand updatestatus = new SqlCommand("Procedure_AdminUpdateStudentStatus ", conn);
                updatestatus.CommandType = System.Data.CommandType.StoredProcedure;

                updatestatus.Parameters.Add(new SqlParameter("@Student_id", student_id));

                conn.Open();
                updatestatus.ExecuteNonQuery();
                Response.Write("The status of the student is updated !");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Response.Write("An error occurred: " + ex.Message +"  Please try again");
            }
        }

        protected void Button97_Click(object sender, EventArgs e)
        {
            Response.Redirect("view_Students.aspx");

        }

    

        protected void Button98_Click(object sender, EventArgs e)
        {
            Response.Redirect("Advisors_Graduation_Plan.aspx");
       

        }

        protected void Button99_Click(object sender, EventArgs e)
        {
            Response.Redirect("Students_Courses_transcript.aspx");
        }

        protected void Button910_Click(object sender, EventArgs e)
        {
            Response.Redirect("Semster_offered_Courses.aspx");
        }
        
        protected void Button999_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }
    }
}