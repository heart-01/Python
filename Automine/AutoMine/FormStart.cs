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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            foreach (var item in GetFile.FileBot)
            {
                lsbFile.Items.Add(item.FileName);
            }
        }

        private void LsbFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            var PathBot = GetFile.FileBot.Where(x=>x.FileName == lsbFile.SelectedItem.ToString()).FirstOrDefault();
        
            Globals.PATH_FILE = PathBot.PathFile;

            this.Close();
        }
    }
}
