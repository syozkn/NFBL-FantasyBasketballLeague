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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

            lblcast.Visible = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblcast.Visible = true;
            lblcast.Text = "Programmer: Ozkan SAY";
            timer2.Start();
            timer1.Stop();
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblcast.Text = "Devoloped in Forms";


            timer3.Start();
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
           
            lblcast.Text = "Musics: Coma-Media";
            
            timer4.Start();
            timer3.Stop();


        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            
            lblcast.Text = "Design: Ozkan SAY";
            
            timer5.Start();
            timer4.Stop();

        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            
            lblcast.Text = "The Werve Games 2023";
            btnexit.Visible = true;
            timer1.Start();
            timer5.Stop();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
