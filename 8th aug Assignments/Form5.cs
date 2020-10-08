using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEg5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button E = new Button();  //refernce to button
            E.Text = "Click Me";
            E.Size = new Size(100, 50);
            E.Location = new Point(640, 320);
            this.Controls.Add(E);

            
            E.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("YAYY!!! This is Crazy:):)");
            };
        }
    }
}
