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
    public partial class unpaid_installment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand sql123 = new SqlCommand("SELECT dbo.[FN_StudentUpcoming_installment](@student_ID)", conn);
                sql123.Parameters.AddWithValue("@student_ID", Session["user"]);

                

                conn.Open();
                object res = sql123.ExecuteScalar();
                
                conn.Close();
                
                if (res != null)
                {
                    Response.Write(res.ToString());

                }
                




            }
        }

        protected void Button99_Click(object sender, EventArgs e)
        {
            Response.Redirect("StudentPart2.aspx");
        }
    }
}