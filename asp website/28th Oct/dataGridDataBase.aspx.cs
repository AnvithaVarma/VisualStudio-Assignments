using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace October_28th
{
    public partial class dataGridDataBase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection("Server = GB-PG00N58V; DataBase = Dxc Training; integrated security = true"))
            {
               // SqlDataAdapter sda = new SqlDataAdapter("select * from student", connect);
               // SqlDataAdapter sda = new SqlDataAdapter("select * from Students", connect);
               // SqlDataAdapter sda = new SqlDataAdapter("select * from Employee1", connect);
                //SqlDataAdapter sda = new SqlDataAdapter("select * from IndianCricketTeam", connect);
               // SqlDataAdapter sda = new SqlDataAdapter("select * from IndianRailwaySystem", connect);
                SqlDataAdapter sda = new SqlDataAdapter("select * from BankTable", connect);

                DataSet ds = new DataSet();

                sda.Fill(ds);   

                DataGrid1.DataSource = ds;
                DataGrid1.DataBind();
            }

        }

        protected void DataGrid1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}