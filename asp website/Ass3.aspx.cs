using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Ass3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }

    

    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {      
         redbox.Visible = true;
     
    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        greenbox.Visible = true;
    }

    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        bluebox.Visible = true;
       
    }
}