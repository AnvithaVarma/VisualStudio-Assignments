using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEg3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button C = new Button();
            C.Text = "Hey, Click Me!";
            C.Size = new Size(300, 300);
            C.Location = new Point(670, 400);
            this.Controls.Add(C);

            C.Click += delegate (object sender1, EventArgs e1)
             {
                 MessageBox.Show("This is Printing");
             };
                
        }
    }
}
