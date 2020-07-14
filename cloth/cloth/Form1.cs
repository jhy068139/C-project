using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cloth
{
    public partial class HOME : Form
    {
        public HOME()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();

            Form2 colortop = new Form2();

            colortop.Show();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Bottom bottom = new Bottom();

            bottom.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Shoes shoes = new Shoes();

            shoes.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            HAT hat = new HAT();

            hat.Show();
        }
    }
}
