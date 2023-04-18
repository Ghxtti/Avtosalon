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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this._1DataSet.Personal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
         personalBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personalBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            personalBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            personalBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            personalBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            personalBindingSource.RemoveCurrent();
        }

        private void personalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personalBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1DataSet);

        }

        private void strana_proizvoditelyaTextBox_TextChanged(object sender, EventArgs e)
        {
                    }

        private void experienceLabel_Click(object sender, EventArgs e)
        {
                    }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
