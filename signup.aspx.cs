using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;

namespace YourNamespace
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void SignUp_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Value;
            string name = txtName.Value;
            string password = txtPassword.Value;
            string confirmPassword = txtConfirmPassword.Value;
            
            if (password != confirmPassword && password.Length > 1 && name.Length > 2 )
            {
                lblErrorMessage.Text = "Password doesn't match";
                lblErrorMessage.Visible = true;
                Response.Redirect("signup.aspx");
            }

            string connectionString = ConfigurationManager.ConnectionStrings["YourConnectionString"].ConnectionString;
            
            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM signup WHERE email = @Email";
                using (SqlCommand command1 = new SqlCommand(query, connection1))
                {
                    command1.Parameters.AddWithValue("@Email", email);
                    try {
                        connection1.Open();
                        int count = (int)command1.ExecuteScalar();
                        if(count >= 1) Response.Redirect("signup.aspx");
                        }
                    catch {
                        Response.Redirect("signup.aspx");
                        }
                    
                }
            }

            // Assuming you have a "Users" table in your database with columns: Email, Name, Password
            string insertQuery = "INSERT INTO signup (Email, Name, Password) VALUES (@Email, @Name, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(insertQuery, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Password", password);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                catch
                {
                    Response.Redirect("signup.aspx");
                }
                finally
                {
                    Response.Redirect("login.aspx");
                }
            }

            // Redirect to a success page or perform any other desired action
            
        }
    }
}
