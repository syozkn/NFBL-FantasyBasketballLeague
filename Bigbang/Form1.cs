using Bigbang.staticdatabase;
using Bigbang.classes;
using Bigbang.Properties;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bigbang
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void saveolustur()
        {
            

            File.Create("centersa.bin");
            File.Create("playoffa.bin");
            File.Create("playoff1a.bin");
            File.Create("playoff2a.bin");
            File.Create("listsa.bin");
            File.Create("lists2a.bin");
            File.Create("lists3a.bin");
            File.Create("lists4a.bin");
            File.Create("playersa.bin");
            File.Create("pointguardsa.bin");
            File.Create("powerforwardsa.bin");
            File.Create("shootingguardsa.bin");
            File.Create("smallforwardsa.bin");
            File.Create("teamsa.bin");
            File.Create("teams2a.bin");
            File.Create("teams3a.bin");
            File.Create("teams4a.bin");
            File.Create("teams5a.bin");

            File.Create("centers.bin");
            File.Create("playoff.bin");
            File.Create("playoff1.bin");
            File.Create("playoff2.bin");
            File.Create("lists.bin");
            File.Create("lists2.bin");
            File.Create("lists3.bin");
            File.Create("lists4.bin");
            File.Create("players.bin");
            File.Create("pointguards.bin");
            File.Create("powerforwards.bin");
            File.Create("shootingguards.bin");
            File.Create("smallforwards.bin");
            File.Create("teams.bin");
            File.Create("teams2.bin");
            File.Create("teams3.bin");
            File.Create("teams4.bin");
            File.Create("teams5.bin");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         

            
            staticdatabase.lists.arkafon.PlayLooping();
            pointguards.pointguardyarat();
            shootingguards.shootingguardyarat();
            smallforwards.smallforwardyarat();
            powerforwards.powerforwardyarat();
            centers.centeryarat();
            teams.takimyarat();
            lists.createtactic();
            
            pbteam1.Image = staticdatabase.teams.lig[0].logo;
            pbteam2.Image = staticdatabase.teams.lig[1].logo;
            pbteam3.Image = staticdatabase.teams.lig[2].logo;
            pbteam4.Image = staticdatabase.teams.lig[3].logo;
            pbteam5.Image = staticdatabase.teams.lig[4].logo;
            pbteam6.Image = staticdatabase.teams.lig[5].logo;
            pbteam7.Image = staticdatabase.teams.lig[6].logo;
            pbteam8.Image= staticdatabase.teams.lig[7].logo;
            pbteam9.Image= staticdatabase.teams.lig[8].logo;
            pbteam10.Image = staticdatabase.teams.lig[9].logo;
            pbteam11.Image = staticdatabase.teams.lig[10].logo;
            pbteam12.Image = staticdatabase.teams.lig[11].logo;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            btnexit.Visible = false;
            btnload.Visible = false;
            btnnew.Visible = false;
            pbteam1.Visible = true;
            pbteam2.Visible = true;
            pbteam3.Visible = true;
            pbteam4.Visible = true;
            pbteam5.Visible = true;
            pbteam6.Visible = true;
            pbteam7.Visible = true;
            pbteam8.Visible = true;
            pbteam9.Visible = true;
            pbteam10.Visible = true;
            pbteam11.Visible = true;
            pbteam12.Visible = true;
            btnpick.Visible = true;


        }

        bool secildimi = false;

        private void pbteam1_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[0];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam2_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[1];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam3_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[2];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam4_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[3];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam5_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[4];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam6_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[5];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam7_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[6];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam8_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[7];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam9_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[8];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam10_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[9];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam11_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[10];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void pbteam12_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim = staticdatabase.teams.lig[11];
            pictureBox2.Image = staticdatabase.teams.secilentakim.logo;
            btnpick.Text = staticdatabase.teams.secilentakim.name;
            secildimi = true;
        }

        private void btnpick_Click(object sender, EventArgs e)
        {
            if (secildimi == true)
            {
                
                staticdatabase.teams.secilentakim.salary = 150;
                zorlukseviyesi();
                btnpick.Visible = false;
                gplivefeed.Visible = true;
                lbldesc.Visible = true;
                lbldesc.Text = $"{staticdatabase.teams.secilentakim.name} picked as a team. Good Luck!  Set the difficulty level";


            }





           

        }
        public void gecis()
        {
            for (int i = 0; i <= staticdatabase.teams.lig.Count - 1; i++)
            {
                if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.lig[i].name)
                {
                    staticdatabase.teams.lig.Remove(staticdatabase.teams.lig[i]);
                }

            }
        }

        public void zorlukseviyesi()
        {
            btneasy.Visible = true;
            btnmedium.Visible = true;
            btnhard.Visible = true;
        }

        public void basla()
        {
            Form9 frm = new Form9();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btneasy_MouseHover(object sender, EventArgs e)
        {
            lbldesc.Visible = true;
            lbldesc.Text = "Easy : Every Match Won Brings 15 M, Every Lost Match Brings 8 M";
            
        }

        private void btnmedium_MouseHover(object sender, EventArgs e)
        {
            lbldesc.Visible = true;
            lbldesc.Text = "MEDIUM LEVEL: Every Match Won Brings 10 M, Every Lost Match Brings 5 M";
            
        }

        private void btnhard_MouseHover(object sender, EventArgs e)
        {
            lbldesc.Visible = true;
            lbldesc.Text = "HARD LEVEL: Every Match Won Brings 8 M, Every Lost Match Brings 4 M";
            
        }

        private void btneasy_Click(object sender, EventArgs e)
        {
            staticdatabase.lists.kazan = 15;
            staticdatabase.lists.kaybet = 8;
            gecis();
            basla();
            
        }

        private void btnmedium_Click(object sender, EventArgs e)
        {
            staticdatabase.lists.kazan = 10;
            staticdatabase.lists.kaybet = 5;
            gecis();
            basla();
        }

        private void btnhard_Click(object sender, EventArgs e)
        {
            staticdatabase.lists.kazan = 8;
            staticdatabase.lists.kaybet = 4;
            gecis();
            basla();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
 
                try
                {
                    staticdatabase.centers.LoadState();
                    staticdatabase.lists.LoadState();
                    staticdatabase.lists.LoadState2();
                    staticdatabase.lists.LoadState3();
                    staticdatabase.lists.LoadState4();

                    staticdatabase.players.LoadState();
                    staticdatabase.pointguards.LoadState();
                    staticdatabase.powerforwards.LoadState();
                    staticdatabase.shootingguards.LoadState();
                    staticdatabase.smallforwards.LoadState();
                    staticdatabase.teams.LoadState();
                    staticdatabase.teams.LoadState2();
                    staticdatabase.teams.LoadState3();
                    staticdatabase.teams.LoadState4();
                    staticdatabase.teams.LoadState5();
                    staticdatabase.lists.LoadStateForm6();
                    staticdatabase.lists.LoadStateForm7();
                    staticdatabase.lists.LoadStateForm8();
                    staticdatabase.lists.saveok = 1;

                }
                catch
                {
                    staticdatabase.centers.LoadStatey();
                    staticdatabase.lists.LoadStatey();
                    staticdatabase.lists.LoadState2y();
                    staticdatabase.lists.LoadState3y();
                    staticdatabase.lists.LoadState4y();

                    staticdatabase.players.LoadStatey();
                    staticdatabase.pointguards.LoadStatey();
                    staticdatabase.powerforwards.LoadStatey();
                    staticdatabase.shootingguards.LoadStatey();
                    staticdatabase.smallforwards.LoadStatey();
                    staticdatabase.teams.LoadStatey();
                    staticdatabase.teams.LoadState2y();
                    staticdatabase.teams.LoadState3y();
                    staticdatabase.teams.LoadState4y();
                    staticdatabase.teams.LoadState5y();
                    staticdatabase.lists.LoadStateForm6y();
                    staticdatabase.lists.LoadStateForm7y();
                    staticdatabase.lists.LoadStateForm8y();
                    staticdatabase.lists.saveok = 2;
                }


            if (staticdatabase.lists.saveload == 1)
            {
                staticdatabase.lists.macyapildimi = true;
                Form3 frm = new Form3();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
            else if (staticdatabase.lists.saveload == 2)
            {
                staticdatabase.lists.load = true;
                Form6 frm = new Form6();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
            else if (staticdatabase.lists.saveload == 3)
            {
                staticdatabase.lists.load = true;
                Form7 frm = new Form7();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
            else if (staticdatabase.lists.saveload == 4)
            {

                Form8 frm = new Form8();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }



          
        }
    }
}