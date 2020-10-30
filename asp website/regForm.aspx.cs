using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace October_29th
{
    public partial class regForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString2"].ConnectionString);
            connect.Open();
            var insertQuery = "insert into RegistrationForm(Username,Email,Password,Gender,Country) values(@U,@E,@P,@G,@C)";

            SqlCommand cmd = new SqlCommand(insertQuery, connect);

            string gender = "";
            if (RadioButton1.Checked)
                gender = "Male";
            else if(RadioButton2.Checked)
                gender = "Female";

            cmd.Parameters.AddWithValue("@U", TextBox1.Text);
            cmd.Parameters.AddWithValue("@E", TextBox2.Text);
            cmd.Parameters.AddWithValue("@P", TextBox3.Text);
            cmd.Parameters.AddWithValue("@G", gender);
            cmd.Parameters.AddWithValue("@C", DropDownList1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            Response.Write("Records have been Submitted!!");

            connect.Close();

            Response.Redirect("regForm.aspx");
        }
    }
}