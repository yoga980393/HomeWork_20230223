using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWork_20230223.Models;

namespace HomeWork_20230223
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductTable data = new ProductTable()
            {
                Id = textBox1.Text.Trim(),
                Name = textBox2.Text.Trim(),
                Quantity = int.Parse(textBox3.Text.Trim()),
                Price = int.Parse(textBox4.Text.Trim()),
                Type = textBox5.Text.Trim(),
            };

            try
            {
                ProductModel product= new ProductModel();
                product.ProductTable.Add(data);
                product.SaveChangesAsync();
                MessageBox.Show("新增成功");
                ClearTextBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBox()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}
