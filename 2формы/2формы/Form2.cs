﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2формы
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            textBox1.Text = frm1.textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;
            frm1.textBox2.Text = textBox2.Text;
        }
    }
}
