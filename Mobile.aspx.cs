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
    public partial class Mobile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand mobileproc = new SqlCommand("Procedures_StudentaddMobile", conn);
                String mobilenum = number.Text;
                mobileproc.Parameters.Add(new SqlParameter("@StudentID", Session["user"]));
                if (int.TryParse(mobilenum, out int mobileNumber))
                {
                    mobileproc.Parameters.Add(new SqlParameter("@mobile_number", mobileNumber));

                    mobileproc.CommandType = CommandType.StoredProcedure;

                    conn.Open();
                    mobileproc.ExecuteNonQuery();
                    Response.Write("Phone Number Is Added Successfully");
                    conn.Close();
                }
                else
                {
                    Response.Write("Please enter a valid number");
                }
            }
            catch (Exception ex)
            {
                Response.Write("This Number already Exists In The DataBase");
                Console.WriteLine("This Number already Exists In The DataBase" + ex.Message);
            }

        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}