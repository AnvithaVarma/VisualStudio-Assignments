using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formsEg4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button D = new Button();
            D.Text = "Hi, Don't Hesitate and click me!! ";
            D.Size = new Size(400, 100);
            D.Location = new Point(150, 100);
            this.Controls.Add(D);

            D.Click += delegate (object sender1, EventArgs e1)
              {
                  MessageBox.Show("It is Printing once again!!!");
              };
        }
    }
}
