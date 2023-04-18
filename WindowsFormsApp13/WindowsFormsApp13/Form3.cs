using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form3 : Form
    {
        private Users users;
        private Form4 Pokupateli;
        private Form5 Sale;
        private Form6 Car;
        private Form7 Personal;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users a = new Users();
            a.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 b = new Form4();
            b.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 c = new Form5();
            c.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 d = new Form6();
            d.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 f = new Form7();
            f.Visible = true;
        }
    }
}
