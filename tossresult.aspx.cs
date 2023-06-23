using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourNamespace
{
    public partial class Tossresult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Retrieve the session variable
            int userInput = Convert.ToInt32(Session["TossResult"]);

            // Set the result message based on the user input
            string resultMessage = "";
            switch (userInput)
            {
                case 0:
                    resultMessage = "waiting";
                    break;
                case 1:
                    resultMessage = "waiting1";
                    break;
                case 2:
                    resultMessage = "computer won the toss and choose to bowl";
                    break;
                default:
                    resultMessage = "waiting2";
                    break;
            }

            // Display the result message
            lblResult.Text = resultMessage;

        }
        protected void btnstart_Click(object sender, EventArgs e)
        {
            Response.Redirect("b4toss.aspx");
        }
    }
}