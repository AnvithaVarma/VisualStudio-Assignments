using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEg2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button B = new Button();
            B.Text = "Click Here!!";
            B.Size = new Size(200, 70);
            B.Location = new Point(645, 330);
            this.Controls.Add(B);

            B.Click += delegate (object sender1, EventArgs e1)
             {
                 MessageBox.Show("Programming is Fun :)");
             };
        }
    }
}
