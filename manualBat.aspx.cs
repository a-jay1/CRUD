using System;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YourNamespace
{
    public partial class Scorecard : Page
    {
        int flag = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if it's a postback
            if (!IsPostBack)
            {
                // Initialize score to 0
                scoreLabel1.Text = "0";
                scoreLabel2.Text = "0";
                
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Get the value of the clicked button
            int input = int.Parse(clickedButton.Text);

            Random rand = new Random();

            int computerAction = rand.Next(0, 7);

            if(input == computerAction)
            {
                if(flag == 0)
                {
                    int n1 = int.Parse(scoreLabel1.Text);
                    int n2 = int.Parse(scoreLabel2.Text);

                    if (n1 > n2)
                    {
                        Label1.Visible = true;
                    }
                    else if(n1 < n2)
                    {
                        Label2.Visible = true;
                    }
                    else
                    {
                        Label3.Visible = true;
                    }
                }

                myLabel.Visible = true;
                flag = 0;

            }

            if(flag == 1)
            {
                // Get the current score from the scoreLabel
                int currentScore = int.Parse(scoreLabel1.Text);

                // Add the button value to the current score
                int newScore = currentScore + input;

                // Update the scoreLabel with the new score
                scoreLabel1.Text = newScore.ToString();
            }

            else
            {
                // Get the current score from the scoreLabel
                int currentScore = int.Parse(scoreLabel2.Text);

                // Add the button value to the current score
                int newScore = currentScore + input;

                // Update the scoreLabel with the new score
                scoreLabel2.Text = newScore.ToString();
            }
        }
    }
}