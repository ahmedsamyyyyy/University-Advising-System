using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace admin
{
    public partial class list_advisor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand optionalproc = new SqlCommand("Procedures_AdminListAdvisors", conn))
                {
                    optionalproc.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    using (SqlDataReader rdr = optionalproc.ExecuteReader())
                    {

                        GridView1.DataSource = rdr;
                        GridView1.DataBind();

                    }
                }
            }


        }
        protected void Back(object sender, EventArgs e)
        {
            Response.Redirect("admin.aspx");


        }
    }
}