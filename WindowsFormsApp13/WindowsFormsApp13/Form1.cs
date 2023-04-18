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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void car_saleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.car_saleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
                     this.car_saleTableAdapter.Fill(this._1DataSet.Car_sale);

        }

        private void car_saleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn COL = new System.Windows.Forms.DataGridViewColumn();
            switch (listBox2.SelectedIndex)
            {
                case 0:
                    COL = dataGridViewTextBoxColumn8;
                    break;
                case 1:
                    COL = dataGridViewTextBoxColumn5;
                    break;
            }            if (radioButton1.Checked)
                car_saleDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Ascending);
            else
                car_saleDataGridView.Sort(COL,
               System.ComponentModel.ListSortDirection.Descending);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.Filter = "NAME='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            car_saleBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < car_saleDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < car_saleDataGridView.RowCount - 1; j++)
                {
                    car_saleDataGridView[i, j].Style.BackColor = Color.White;
                    car_saleDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }
            for (int i = 0; i < car_saleDataGridView.ColumnCount - 1; i++)
            {
                for (int j = 0; j < car_saleDataGridView.RowCount - 1; j++)
                {
                    if (car_saleDataGridView[i,
                   j].Value.ToString().IndexOf(textBox1.Text) != -1)
                    {
                        car_saleDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        car_saleDataGridView[i, j].Style.ForeColor = Color.Blue;

                    }
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


