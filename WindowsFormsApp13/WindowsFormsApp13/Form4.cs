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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_1DataSet.Buyers". При необходимости она может быть перемещена или удалена.
            this.buyersTableAdapter.Fill(this._1DataSet.Buyers);

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buyersBindingSource.RemoveCurrent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MoveFirst();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            buyersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           buyersBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void buyersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buyersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1DataSet);

        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasportnie_danieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fIOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void sexTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_of_birthTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
