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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HomeWork_20230223
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
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
            }
        }

        string id;

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            var item = product.ProductTable.Where(x => x.Id == comboBox1.Text).First();
            id = comboBox1.Text;
            textBox1.Text = item.Id;
            textBox2.Text = item.Name;
            textBox3.Text = item.Quantity.ToString();
            textBox4.Text = item.Price.ToString();
            textBox5.Text = item.Type;
            button2.Enabled= true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            var item = product.ProductTable.Where(x => x.Id == comboBox1.Text).First();
            product.ProductTable.Remove(item);

            ProductTable data = new ProductTable()
            {
                Id = textBox1.Text.Trim(),
                Name = textBox2.Text.Trim(),
                Quantity = int.Parse(textBox3.Text.Trim()),
                Price = int.Parse(textBox4.Text.Trim()),
                Type = textBox5.Text.Trim(),
            };
            product.ProductTable.Add(data);
            product.SaveChangesAsync();
            MessageBox.Show("修改成功");
            ClearTextBox();
        }

        private void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            button2.Enabled = false;
        }
    }
}
