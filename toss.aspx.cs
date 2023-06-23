using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourNamespace
{
    public partial class Toss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnhead_Click(object sender, EventArgs e)
        {
            // Redirect to the signup page
            Response.Redirect("signup.aspx");
        }

        protected void btntail_Click(object sender, EventArgs e)
        {
            // Redirect to the signup page
            Response.Redirect("login.aspx");
        }
    }
}