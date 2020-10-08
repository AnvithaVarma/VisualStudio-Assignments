using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsEg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button A = new Button();
            A.Text = "Press Me";
            A.Size = new Size(170, 60);
            A.Location = new Point(635, 320);
            this.Controls.Add(A);

            A.Click += delegate (object sender1, EventArgs e1)
                {
                    MessageBox.Show("Hello World");
                    
                };
            
        }
    }
}
