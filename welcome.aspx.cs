using System;
using System.Web.UI;

namespace YourNamespace
{
    public partial class Welcome : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnWelcome_Click(object sender, EventArgs e)
        {
            // Redirect to the signup page
            Response.Redirect("signup.aspx");
        }
    }
}
