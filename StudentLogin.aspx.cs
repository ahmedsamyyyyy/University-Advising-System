using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUCera
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Loginbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    int id;
                    if (!Int32.TryParse(username.Text, out id))
                    {
                        Response.Write("Invalid user id.");
                        return;
                    }
                    String pass1 = password.Text;
                    int success = 0;

                    conn.Open();
                    using (var ex = conn.CreateCommand())
                    {
                        ex.CommandText = "SELECT dbo.FN_StudentLogin(@Student_id, @password) AS studentlogin";

                        ex.Parameters.AddWithValue("@Student_id", id);
                        ex.Parameters.AddWithValue("@password", pass1);

                        using (SqlDataReader rdr = ex.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                success = Convert.ToInt32(rdr["studentlogin"]);
                            }
                        }
                    }
                    if (success == 1)
                    {
                        Session["user"] = id;
                        Response.Redirect("home.aspx");
                    }
                    else
                    {
                        Response.Write("Unable To Login");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

       
    protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("M3_Advising_System.aspx");
        }
    }
}
