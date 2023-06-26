using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace YourNamespace
{
    public partial class profile : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Simulated data, replace with your logic to retrieve user information
                string email = Session["Email"] as string;

               
                string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT NAME FROM signup WHERE Email = @Email";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Email", email);
                    string name = "";
                    try
                    {
                        connection.Open();
                        name = command.ExecuteScalar()?.ToString();
                    }
                    catch
                    {
                        name = "NULL";
                    }
                    emailLabel.Text = email;
                    Label1.Text = name;
                }

                // Show the "Update Profile" button
                updateProfileButton.Visible = true;
            }
        }

        protected void updateProfileButton_Click(object sender, EventArgs e)
        {
            // Handle the "Update Profile" button click event
            // Redirect to the profile update page or perform any desired action
            Response.Redirect("updateprofile.aspx");
        }

        protected void delete_Click(object sender, EventArgs e)
        {   
            string email = Session["Email"] as string;

            Session.Remove("Email");

            Session.Clear();

            string Query = "Delete from signup where email = @email";

            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(Query, connection);
                command.Parameters.AddWithValue("@Email", email);
                
                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Response.Redirect("profile.aspx");
                }
                
            }
            Response.Redirect("login.aspx");
        }
    }
}
