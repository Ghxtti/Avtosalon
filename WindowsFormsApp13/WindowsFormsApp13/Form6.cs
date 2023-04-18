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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Cars". При необходимости она может быть перемещена или удалена.
            this.carsTableAdapter.Fill(this._1DataSet.Cars);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Personal". При необходимости она может быть перемещена или удалена.
            this.personalTableAdapter.Fill(this._1DataSet.Personal);

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void strana_proizvoditelyaLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void zavod_proizvoditelyaLabel_Click(object sender, EventArgs e)
        {

        }

        private void name_BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void iD_BrandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            carsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            carsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            carsBindingSource.RemoveCurrent();
        }

        private void carsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void iD_CarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.carsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1DataSet);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
