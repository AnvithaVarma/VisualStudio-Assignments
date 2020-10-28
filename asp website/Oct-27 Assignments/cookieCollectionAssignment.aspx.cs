using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace October27th
{
    public partial class cookieCollectionAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cookies["Colors"].Expires = DateTime.Now.AddDays(-1);
        }

        protected void button_Click(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
                Response.Cookies["Colors"]["White"] = "     You have selected white color and cookie is triggered!" ;
            if (CheckBox2.Checked)
                Response.Cookies["Colors"]["Violet"] = "    You have selected Violet color and cookie is triggered!";
            if (CheckBox3.Checked)
                Response.Cookies["Colors"]["Black"] = "     You have selected Black color and cookie is triggered!" ;
            if (CheckBox4.Checked)
                Response.Cookies["Colors"]["Blue"] = "      You have selected Blue color and cookie is triggered!" ;
            if (CheckBox5.Checked)
                Response.Cookies["Colors"]["Red"] = "       You have selected Red color and cookie is triggered!" ;
            if (CheckBox6.Checked)
                Response.Cookies["Colors"]["Green"] = "     You have selected Green color and cookie is triggered!";
            if (CheckBox7.Checked)
                Response.Cookies["Colors"]["Pink"] = "      You have selected Pink color and cookie is triggered!";
            if (CheckBox8.Checked)
                Response.Cookies["Colors"]["Orange"] = "    You have selected Orange color and cookie is triggered!" ;
            if (CheckBox9.Checked)
                Response.Cookies["Colors"]["Lavender"] = "  You have selected Lavender color and cookie is triggered!" ;
            if (CheckBox10.Checked)
                Response.Cookies["Colors"]["Yellow"] = "    You have selected Yellow color and cookie is triggered!" ;

            if(Request.Cookies["Colors"].Values.ToString()!=null)
            {
                if (Request.Cookies["Colors"]["White"] != null)
                    Label2.Text += Response.Cookies["Colors"]["White"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Violet"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Violet"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Black"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Black"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Blue"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Blue"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Red"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Red"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Green"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Green"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Pink"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Pink"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Orange"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Orange"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Lavender"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Lavender"] + "\n " + "\n ";
                if (Request.Cookies["Colors"]["Yellow"] != null)
                    Label2.Text += Response.Cookies["Colors"]["Yellow"] + "\n " + "\n ";
            }
            else
            {
                Label2.Text = "Select any of the mentioned colors!";
            }
        }
    }
}