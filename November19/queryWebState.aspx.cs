using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryStrings
{
	public partial class queryWebState : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			if(!IsPostBack)
			{
				TextBox1.Focus();
			}

		}

		protected void Button2_Click(object sender, EventArgs e)
		{
			if (TextBox1.Text == "admin" || TextBox1.Text=="Anvitha")
			{
				Response.Write("Login Successful!!");
				Response.Redirect("Homepage.aspx?Name="+TextBox1.Text+"&Password="+TextBox2.Text);
			}
				
			else
				Label1.Text = "Invalid User. Login failed!";
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}