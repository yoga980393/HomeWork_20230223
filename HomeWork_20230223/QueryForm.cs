using HomeWork_20230223.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork_20230223
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
            ComboBoxSetting();
        }

        private void ComboBoxSetting()
        {
            var product = new ProductModel();
            foreach (var item in product.ProductTable)
            {
                comboBox1.Items.Add(item.Id);
                comboBox2.Items.Add(item.Name);
            }

            foreach (var item in product.ProductTable.Select(x => x.Type).Distinct())
            {
                comboBox3.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            var list = product.ProductTable.Where(x => x.Id == comboBox1.Text).ToList();
            ShowViewForm(list);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            var list = product.ProductTable.Where(x => x.Name == comboBox2.Text).ToList();
            ShowViewForm(list);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            var list = product.ProductTable.Where(x => x.Type == comboBox3.Text).ToList();
            ShowViewForm(list);
        }

        private void ShowViewForm(List<ProductTable> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("無資料");
            }
            else
            {
                var form = new ViewForm();
                form.Query(list);
                form.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            int Max = textBox6.Text == "" ? int.MaxValue : int.Parse(textBox6.Text);
            int Min = textBox7.Text == "" ? 0 : int.Parse(textBox7.Text);
            var list = product.ProductTable.Where(x => x.Quantity <= Max && x.Quantity >= Min).ToList();
            ShowViewForm(list);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            int Max = textBox4.Text == "" ? int.MaxValue : int.Parse(textBox4.Text);
            int Min = textBox3.Text == "" ? 0 : int.Parse(textBox3.Text);
            var list = product.ProductTable.Where(x => x.Price <= Max && x.Price >= Min).ToList();
            ShowViewForm(list);
        }
    }
}
