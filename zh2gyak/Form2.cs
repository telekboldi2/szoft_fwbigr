﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh2gyak
{
    public partial class Form2 : Form
    {
        public lekepezes lekepezes = new();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = lekepezes;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            return;
        }
    }
}
