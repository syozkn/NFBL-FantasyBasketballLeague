using Bigbang.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigbang
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(Resources.sarki1);
            soundPlayer.PlayLooping();
            pictureBox12.Image = staticdatabase.teams.secilentakim.logo;
            oyuncular();
            timer1.Start();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void oyuncular()
        {
            pictureBox2.Image = staticdatabase.teams.secilentakim.pg1.foto;
            pictureBox3.Image = staticdatabase.teams.secilentakim.pg2.foto;
            pictureBox4.Image = staticdatabase.teams.secilentakim.sg1.foto;
            pictureBox5.Image = staticdatabase.teams.secilentakim.sg2.foto;
            pictureBox6.Image = staticdatabase.teams.secilentakim.sf1.foto;
            pictureBox7.Image = staticdatabase.teams.secilentakim.sf2.foto;
            pictureBox8.Image = staticdatabase.teams.secilentakim.pf1.foto;
            pictureBox9.Image = staticdatabase.teams.secilentakim.pf2.foto;
            pictureBox10.Image = staticdatabase.teams.secilentakim.c1.foto;
            pictureBox11.Image = staticdatabase.teams.secilentakim.c2.foto;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox7.Visible = true;
            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            pictureBox8.Visible = true;
            timer3.Start();
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox9.Visible = true;
            timer4.Start();
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox5.Visible = true;
            pictureBox10.Visible = true;
            timer5.Start();
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
            pictureBox11.Visible = true;
            

            timer6.Start();
            timer5.Stop();
        }
       
        private void timer6_Tick(object sender, EventArgs e)
        {
            if(cong.Visible==false)
                cong.Visible= true;
            else
                cong.Visible= false;

            if (champ.Visible == false)
                champ.Visible = true;
            else champ.Visible = false;

            btnexit.Visible = true;

         

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
