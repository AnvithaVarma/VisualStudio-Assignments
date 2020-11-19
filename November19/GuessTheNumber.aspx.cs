using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleGame
{
	public partial class GuessTheNumber : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!IsPostBack)
				TextBox1.Focus();
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			if (TextBox1.Text == "3")
				Response.Redirect("Congrats.aspx?Name=" + TextBox1.Text);
			else
			{
				Label1.Text = "Oops! Wrong Guess:(:(     Better Luck Next Time!!!";
			}
				

		}
	}
}