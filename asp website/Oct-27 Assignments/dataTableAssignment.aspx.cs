using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace October27th
{
    public partial class dataTableAssignment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Designation");
            dataTable.Columns.Add("Location");
            dataTable.Columns.Add("Country");

            dataTable.Rows.Add(1, "Sirlapu", "Sravya", "Tester","Vizag","India");
            dataTable.Rows.Add(2, "Vadapalli", "Anvitha", "Developer","Seoul","Korea");
            dataTable.Rows.Add(3, "Bhamidimukkula", "Ankita", "Engineer","Berlin","Germany");
            dataTable.Rows.Add(4, "Gogineni", "Jahnavi", "Engineer","Chennai","India");
            dataTable.Rows.Add(5, "Malasala", "Sai Kumar", "HR","Bangalore","India");
            dataTable.Rows.Add(6, "Sachin", "Pratik", "Tech Lead","California","America");
            dataTable.Rows.Add(7, "Swati", "Mehla", "Engineer","Delhi","India");
            dataTable.Rows.Add(8, "Vegi", "Venkatesh", "Business","Vizag","India");
            dataTable.Rows.Add(9, "Velaga", "Yash", "Planner","London","UK");
            dataTable.Rows.Add(10, "Deepak", "Kumar", "Engineer","Hyderabad","India");

            DataList1.DataSource = dataTable;
            DataList1.DataBind();
        }
    }
}