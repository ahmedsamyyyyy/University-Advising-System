using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Label = System.Web.UI.WebControls.Label;


namespace GUCera
{
    public partial class courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void mobilenumber_Click(object sender, EventArgs e)
        {
            Response.Redirect("Mobile.aspx");
        }

        protected void optionalcourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Optional.aspx");
        }

        protected void availablecourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Available.aspx");
        }

        protected void requiredcourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("required.aspx");
        }

        protected void missingcourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Missing.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String sems = currentsems.Text;
            Session["sems"] = sems;
        }

        protected void Credithours_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand request2proc = new SqlCommand("Procedures_StudentSendingCHRequest", conn);
                String typee = type2.Text;
                String commentt = comment2.Text;

                if(int.TryParse(credit2.Text, out int credit))
                {
                    request2proc.Parameters.Add(new SqlParameter("@credit_hours", credit));
                }
                else
                {
                    Response.Write("Enter A Valid Credit Hours Number");
                }

                request2proc.Parameters.Add(new SqlParameter("@StudentID", Session["user"]));
                
                request2proc.Parameters.Add(new SqlParameter("@type", typee));
                request2proc.Parameters.Add(new SqlParameter("@comment", commentt));

                request2proc.CommandType = CommandType.StoredProcedure;
                conn.Open();
                request2proc.ExecuteNonQuery();
                Response.Write("Requseted Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand request1proc = new SqlCommand("Procedures_StudentSendingCourseRequest", conn);
                String typee = type1.Text;
                String commentt = comment1.Text;

                if (int.TryParse(course1.Text, out int courseid))
                {
                    request1proc.Parameters.Add(new SqlParameter("@courseID", courseid));
                }
                else
                {
                    Response.Write("Enter A Valid Course ID");
                }

                request1proc.Parameters.Add(new SqlParameter("@StudentID", Session["user"]));
                request1proc.Parameters.Add(new SqlParameter("@type", typee));
                request1proc.Parameters.Add(new SqlParameter("@comment", commentt));

                request1proc.CommandType = CommandType.StoredProcedure;
                conn.Open();
                request1proc.ExecuteNonQuery();
                Response.Write("Requseted Successfully");
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentLogin.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2.aspx");
        }
    }
}