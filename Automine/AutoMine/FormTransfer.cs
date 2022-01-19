using AutoMine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoMine
{
    public partial class FormTransfer : Form
    {
        public FormTransfer()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Globals.ACCOUNT_TRANSFER = txtAccount.Text;
            Globals.ACCOUNT_MEMO = txtMemo.Text;
            Globals.ACCOUNT_AMT = txtAmt.Text;
            this.Close();
        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            txtAccount.Text = Globals.ACCOUNT_TRANSFER;
            txtMemo.Text = Globals.ACCOUNT_MEMO;
            txtAmt.Text = Globals.ACCOUNT_AMT;
        }
    }
}
