using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zh2gyak
{

    public partial class FormEdit : Form
    {
        public lekepezes lekepezes = new();
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = lekepezes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
