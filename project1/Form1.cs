using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            Outputname.Text = "Halo " + name;
        }

        private void TP_MOD_2_KPL_Load(object sender, EventArgs e)
        {
            
        }

        private void labelNama_Click(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelOutput_Click(object sender, EventArgs e)
        {

        }

        private void Outputname_Click(object sender, EventArgs e)
        {

        }
    }
}
