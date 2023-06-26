using System;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace YourNamespace
{
    public partial class Login : System.Web.UI.Page
    {
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            // Retrieve the connection string from the Web.config file
            string connectionString = WebConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;

            // Check if the email exists in the database
            bool emailExists = CheckEmailExists(email, connectionString);

            if (!emailExists)
            {
                // Email not found, redirect to the signup page
                Response.Redirect("signup.aspx");
            }

            //Response.Redirect("welcome.aspx");
            else
            {
                // Check if the password is correct
                bool passwordCorrect = CheckPasswordCorrect(email, password, connectionString);

                if (passwordCorrect)
                {
                    // Password is correct, proceed to the authenticated page
                    Session["Email"] = email;
                    Response.Redirect("b4toss.aspx");
                }
                else
                {
                    // Password is incorrect, display error message
                    lblErrorMessage.Text = "Incorrect password";
                    lblErrorMessage.Visible = true;
                }
            }
        }

        private bool CheckEmailExists(string email, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM signup WHERE Email = @Email";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                int count = 0;
                try
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
                catch
                {
                    return false;
                }

                return count > 0;
            }
            //return false;
        }

        private bool CheckPasswordCorrect(string email, string password, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM signup WHERE Email = @Email AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                int count = 0;
                try
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();
                }
                catch
                {
                    return false;
                }

                return count > 0;
            }
            //return false;
        }
    }
}
