﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeNCrawLer_0._1._0
{
    public partial class FrmEditHeader : Form
    {
        public string header;
        public FrmEditHeader(string header)
        {
            InitializeComponent();

            textBox1.Text = header;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            header = textBox1.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
