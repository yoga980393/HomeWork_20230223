﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AddForm();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var form = new ViewForm();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new QueryForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new DeleteForm();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new UpdateForm();
            form.Show();
        }
    }
}
