using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace October27th
{
    public partial class httpCookieAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie movie1 = new HttpCookie("Movies1");
            HttpCookie movie2 = new HttpCookie("Movies2");
            HttpCookie movie3 = new HttpCookie("Movies3");
            HttpCookie movie4 = new HttpCookie("Movies4");
            HttpCookie movie5 = new HttpCookie("Movies5");

            movie1.Value = "Iron Man";
            movie2.Value = "Lucy";
            movie3.Value = "Avengers";
            movie4.Value = "Tangled";
            movie5.Value = "Frozen";

            Response.Cookies.Add(movie1);
            Response.Cookies.Add(movie2);
            Response.Cookies.Add(movie3);
            Response.Cookies.Add(movie4);
            Response.Cookies.Add(movie5);

            var Cookie_Value1 = "First Movie is : " + Response.Cookies["Movies1"].Value + "\n";
            var Cookie_Value2 = "Second Movie is : " + Response.Cookies["Movies2"].Value + "\n";
            var Cookie_Value3 = "Third Movie is : " + Response.Cookies["Movies3"].Value + "\n";
            var Cookie_Value4 = "Fourth Movie is : " + Response.Cookies["Movies4"].Value + "\n";
            var Cookie_Value5 = "Fifth Movie is : " + Response.Cookies["Movies5"].Value;

            Label1.Text = Cookie_Value1;
            Label2.Text = Cookie_Value2;
            Label3.Text = Cookie_Value3;
            Label4.Text = Cookie_Value4;
            Label5.Text = Cookie_Value5;

        }
    }
}