using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourNamespace
{
    public partial class B4toss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnstart_Click(object sender, EventArgs e)
        {
            // Redirect to the signup page
            Random choice = new Random();
            int toss = choice.Next(0, 2);
            toss = 0;
            if(toss == 1)
            {
                Response.Redirect("welcome.aspx");
            }
                
            else
            {
                toss = choice.Next(0, 2);
                if (toss == 1)
                {
                    int a1 = 2;
                    Session["TossResult"] = a1;
                    Response.Redirect("tossresult.aspx");
                }
                else
                {
                    int a1 = 2;
                    Session["TossResult"] = a1;
                    Response.Redirect("tossresult.aspx");

                }
            }
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }
    }
}