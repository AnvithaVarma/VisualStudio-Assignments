using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleForm7
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = new Button();  //refernce to button
            b.Text = "Click Me";
            b.Size = new Size(100, 50);
            b.Location = new Point(640, 320);
            this.Controls.Add(b);

            
            b.Click += delegate (object sender1, EventArgs e1)
            {
                MessageBox.Show("Hello World");
                MessageBox.Show("Programming is FUN!!");
                MessageBox.Show("This is Printing:)");
                MessageBox.Show("Once More! Got printed!!!");
                MessageBox.Show("YAYY!!! This is Crazy");
                MessageBox.Show("Finally,  Last One:):)");
            };
        }
    }
}
