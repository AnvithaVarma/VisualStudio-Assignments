using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEg6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button F = new Button();  //refernce to button
            F.Text = "Click Me";
            F.Size = new Size(100, 50);
            F.Location = new Point(640, 320);
            this.Controls.Add(F);

            
            F.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("FINALLY!  **Last One**");
            };
        }
    }
}
