using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigbang
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }



        private void btngo_Click(object sender, EventArgs e)
        {
            
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void btngo_Click_1(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }
    }
}
