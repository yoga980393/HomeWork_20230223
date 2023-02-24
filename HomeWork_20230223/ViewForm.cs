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
    public partial class ViewForm : Form
    {
        public ViewForm()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            var product = new ProductModel();
            var list = product.ProductTable.ToList();
            dataGridView1.DataSource = list;
        }

        public void Query(List<ProductTable> list)
        {
            dataGridView1.DataSource = list;
        }
    }
}
