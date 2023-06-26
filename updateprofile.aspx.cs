using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace YourNamespace
{
    public partial class updateprofile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update_name(object sender, EventArgs e)
        {
            string name = txtName.Value;
            string email = Session["Email"] as string;

            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE signup SET name = @Name WHERE Email = @Email";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Name", name);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Response.Redirect("b4toss.aspx");
                }
            }

            Response.Redirect("profile.aspx");
        }
    }
}
