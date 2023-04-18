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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Car_sale". При необходимости она может быть перемещена или удалена.
            this.car_saleTableAdapter.Fill(this._1DataSet.Car_sale);

        }

        private void zavod_proizvoditelyaLabel_Click(object sender, EventArgs e)
        {

        }

        private void strana_proizvoditelyaLabel_Click(object sender, EventArgs e)
        {

        }

        private void name_BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void name_BrandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
                    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.RemoveCurrent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.MovePrevious();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.MoveLast();
        }

        private void car_saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.car_saleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1DataSet);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Visible = true;
        }
    }
}
