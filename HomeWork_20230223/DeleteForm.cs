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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
            ComboBoxSetting();
        }

        private void ComboBoxSetting()
        {
            var product = new ProductModel();
            foreach(var item in product.ProductTable)
            {
                comboBox1.Items.Add(item.Id);
                comboBox2.Items.Add(item.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            var item = product.ProductTable.Where(x => x.Id == comboBox1.Text).First();
            product.ProductTable.Remove(item);
            product.SaveChangesAsync();
            MessageBox.Show("刪除成功");
            comboBox1.Items.Remove(item.Id);
            comboBox2.Items.Remove(item.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var product = new ProductModel();
            var item = product.ProductTable.Where(x => x.Name == comboBox2.Text).First();
            product.ProductTable.Remove(item);
            product.SaveChangesAsync();
            MessageBox.Show("刪除成功");
            comboBox1.Items.Remove(item.Id);
            comboBox2.Items.Remove(item.Name);
        }
    }
}
