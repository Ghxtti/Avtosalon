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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void brand_carBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brand_carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1DataSet);

        }

        private void Users_Load(object sender, EventArgs e)
        {
            this.brand_carTableAdapter.Fill(this._1DataSet.Brand_car);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void zavod_proizvoditelyaLabel_Click(object sender, EventArgs e)
        {
                    }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zavod_proizvoditelyaLabel_Click_1(object sender, EventArgs e)
        {

        }

        private void strana_proizvoditelyaLabel_Click(object sender, EventArgs e)
        {

        }

        private void name_BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void name_BrandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void iD_BrandLabel_Click(object sender, EventArgs e)
        {

        }

        private void iD_BrandTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressLabel_Click(object sender, EventArgs e)
        {

        }

        private void zavod_proizvoditelyaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void strana_proizvoditelyaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.brand_carBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1DataSet);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            brand_carBindingSource.MoveNext();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            brand_carBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            brand_carBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            brand_carBindingSource.MoveLast();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            brand_carBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            brand_carBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void brand_carBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
