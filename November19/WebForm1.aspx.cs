using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StateManagementDemoWeb
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		//static int count=0;
		int count;
		protected void Page_Load(object sender, EventArgs e)
		{

		}
		
		protected void Button1_Click(object sender, EventArgs e)
		{
			//int count = 0;

			count = int.Parse(HiddenField1.Value);
			count += 1;
			Response.Write($"This button got hit {count} time/times!!!");
			HiddenField1.Value = count.ToString();
		}

		protected void HiddenField1_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}