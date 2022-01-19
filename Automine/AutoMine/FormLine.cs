using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMine.Models;

namespace AutoMine
{


    public partial class FormLine : Form
    {
        public FormLine()
        {
            InitializeComponent();
        }

        private void FormLine_Load(object sender, EventArgs e)
        {
            txtToken.Text = Globals.TOKEN_LINE;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Globals.TOKEN_LINE = txtToken.Text;
            this.Close();
        }
    }
}
