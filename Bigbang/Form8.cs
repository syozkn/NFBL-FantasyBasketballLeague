using Bigbang.classes;
using Bigbang.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigbang
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            staticdatabase.lists.saveload = 4;
            if (staticdatabase.lists.final is false)
            {
                benibul();
            }
            playofftablosu();
            eskitablo();

            headtohead();
            Coming();
            tiklanantakim = staticdatabase.teams.secilentakim;
            tiklananoyuncu = staticdatabase.teams.secilentakim.pg1;
            tiklanantakimdoldur();
            secilenoyuncudoldur();

            Random rnd = new Random();
            sarki = rnd.Next(1, 5);
            sarkisecimi();
            taktiktablosu();


        }
        private void taktiktablosu()
        {
            pbaktiftaktik1.Image = staticdatabase.teams.secilentakim.taktik1.resim;
            pbaktiftaktik2.Image = staticdatabase.teams.secilentakim.taktik2.resim;
            pbaktiftaktik3.Image = staticdatabase.teams.secilentakim.taktik3.resim;
            pbaktiftaktik4.Image = staticdatabase.teams.secilentakim.taktik4.resim;

        }

        public void Coming()
        {
            pbcomingteam1.Image = staticdatabase.teams.secilentakim.logo;
            pbcoming2.Image = staticdatabase.lists.finalrakip.logo;
            lblteamgalibiyet1.Text = staticdatabase.teams.secilentakim.finalgalibiyet.ToString();
            lblteamgalibiyet2.Text = staticdatabase.lists.finalrakip.finalgalibiyet.ToString();
            lblcoming1.Text = staticdatabase.teams.secilentakim.name;
            lblcoming2.Text = staticdatabase.lists.finalrakip.name;
            lbl1overall.Text = staticdatabase.teams.secilentakim.Overallteam.ToString();
            lbl2overall.Text = staticdatabase.lists.finalrakip.Overallteam.ToString();



        }


        public void eskitablo()
        {
            pbteam1.Image = staticdatabase.teams.play1.logo;
            pbteam2.Image = staticdatabase.teams.play2.logo;
            pbteam3.Image = staticdatabase.teams.play3.logo;
            pbteam4.Image = staticdatabase.teams.play4.logo;
            pbteam5.Image = staticdatabase.teams.play5.logo;
            pbteam6.Image = staticdatabase.teams.play6.logo;
            pbteam7.Image = staticdatabase.teams.play7.logo;
            pbteam8.Image = staticdatabase.teams.play8.logo;
            tur1t1.Text = staticdatabase.teams.play1.playoffgalibiyet.ToString();
            tur1t2.Text = staticdatabase.teams.play2.playoffgalibiyet.ToString();
            tur1t3.Text = staticdatabase.teams.play3.playoffgalibiyet.ToString();
            tur1t4.Text = staticdatabase.teams.play4.playoffgalibiyet.ToString();
            tur1t5.Text = staticdatabase.teams.play5.playoffgalibiyet.ToString();
            tur1t6.Text = staticdatabase.teams.play6.playoffgalibiyet.ToString();
            tur1t7.Text = staticdatabase.teams.play7.playoffgalibiyet.ToString();
            tur1t8.Text = staticdatabase.teams.play8.playoffgalibiyet.ToString();
            pbteam9.Image = staticdatabase.teams.play9.logo;
            pbteam10.Image = staticdatabase.teams.play10.logo;
            pbteam11.Image = staticdatabase.teams.play11.logo;
            pbteam12.Image = staticdatabase.teams.play12.logo;
            lblteam9win.Text = staticdatabase.teams.play9.playoffgalibiyet2.ToString();
            lblteam10win.Text = staticdatabase.teams.play10.playoffgalibiyet2.ToString();
            lblteam11win.Text = staticdatabase.teams.play11.playoffgalibiyet2.ToString();
            lblteam12win.Text = staticdatabase.teams.play12.playoffgalibiyet2.ToString();
        }

        public void playofftablosu()
        {
            if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play13.name)
            {
                pbteam13.Image = staticdatabase.teams.secilentakim.logo;
                pbteam14.Image = staticdatabase.lists.finalrakip.logo;
                team13final.Text = staticdatabase.teams.secilentakim.finalgalibiyet.ToString();
                team14final.Text = staticdatabase.lists.finalrakip.finalgalibiyet.ToString();
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play14.name)
            {
                pbteam14.Image = staticdatabase.teams.secilentakim.logo;
                pbteam13.Image = staticdatabase.lists.finalrakip.logo;
                team14final.Text = staticdatabase.teams.secilentakim.finalgalibiyet.ToString();
                team13final.Text = staticdatabase.lists.finalrakip.finalgalibiyet.ToString();
            }
        }

        public void headtohead()
        {
            team1pg1.Text = staticdatabase.teams.secilentakim.pg1.name;
            team1sg1.Text = staticdatabase.teams.secilentakim.sg1.name;
            team1sf1.Text = staticdatabase.teams.secilentakim.sf1.name;
            team1pf1.Text = staticdatabase.teams.secilentakim.pf1.name;
            team1c1.Text = staticdatabase.teams.secilentakim.c1.name;
            team1pg2.Text = staticdatabase.teams.secilentakim.pg2.name;
            team1sg2.Text = staticdatabase.teams.secilentakim.sg2.name;
            team1sf2.Text = staticdatabase.teams.secilentakim.sf2.name;
            team1pf2.Text = staticdatabase.teams.secilentakim.pf2.name;
            team1c2.Text = staticdatabase.teams.secilentakim.c2.name;

            team2pg1.Text = staticdatabase.lists.finalrakip.pg1.name;
            team2sg1.Text = staticdatabase.lists.finalrakip.sg1.name;
            team2sf1.Text = staticdatabase.lists.finalrakip.sf1.name;
            team2pf1.Text = staticdatabase.lists.finalrakip.pf1.name;
            team2c1.Text = staticdatabase.lists.finalrakip.c1.name;
            team2pg2.Text = staticdatabase.lists.finalrakip.pg2.name;
            team2sg2.Text = staticdatabase.lists.finalrakip.sg2.name;
            team2sf2.Text = staticdatabase.lists.finalrakip.sf2.name;
            team2pf2.Text = staticdatabase.lists.finalrakip.pf2.name;
            team2c2.Text = staticdatabase.lists.finalrakip.c2.name;

            team1pg1ov.Text = staticdatabase.teams.secilentakim.pg1.Overall.ToString();
            team1sg1ov.Text = staticdatabase.teams.secilentakim.sg1.Overall.ToString();
            team1sf1ov.Text = staticdatabase.teams.secilentakim.sf1.Overall.ToString();
            team1pf1ov.Text = staticdatabase.teams.secilentakim.pf1.Overall.ToString();
            team1c1ov.Text = staticdatabase.teams.secilentakim.c1.Overall.ToString();
            team1pg2ov.Text = staticdatabase.teams.secilentakim.pg2.Overall.ToString();
            team1sg2ov.Text = staticdatabase.teams.secilentakim.sg2.Overall.ToString();
            team1sf2ov.Text = staticdatabase.teams.secilentakim.sf2.Overall.ToString();
            team1pf2ov.Text = staticdatabase.teams.secilentakim.pf2.Overall.ToString();
            team1c2ov.Text = staticdatabase.teams.secilentakim.c2.Overall.ToString();

            team2pg1ov.Text = staticdatabase.lists.finalrakip.pg1.Overall.ToString();
            team2sg1ov.Text = staticdatabase.lists.finalrakip.sg1.Overall.ToString();
            team2sf1ov.Text = staticdatabase.lists.finalrakip.sf1.Overall.ToString();
            team2pf1ov.Text = staticdatabase.lists.finalrakip.pf1.Overall.ToString();
            team2c1ov.Text = staticdatabase.lists.finalrakip.c1.Overall.ToString();
            team2pg2ov.Text = staticdatabase.lists.finalrakip.pg2.Overall.ToString();
            team2sg2ov.Text = staticdatabase.lists.finalrakip.sg2.Overall.ToString();
            team2sf2ov.Text = staticdatabase.lists.finalrakip.sf2.Overall.ToString();
            team2pf2ov.Text = staticdatabase.lists.finalrakip.pf2.Overall.ToString();
            team2c2ov.Text = staticdatabase.lists.finalrakip.c2.Overall.ToString();

            pbhead1.Image = staticdatabase.teams.secilentakim.logo;
            pbhead2.Image = staticdatabase.lists.finalrakip.logo;
        }




        public void benibul()
        {
            if (staticdatabase.teams.play9.name == staticdatabase.teams.secilentakim.name || staticdatabase.teams.play10.name == staticdatabase.teams.secilentakim.name)
            {
                staticdatabase.teams.play13 = staticdatabase.teams.secilentakim;
                if (staticdatabase.teams.play11.playoffgalibiyet2 != 4 && staticdatabase.teams.play12.playoffgalibiyet2 != 4)
                {
                    if (staticdatabase.teams.play11.playoffgalibiyet2 >= staticdatabase.teams.play12.playoffgalibiyet2)
                    {
                        staticdatabase.teams.play11.playoffgalibiyet2 = 4;
                        staticdatabase.teams.play14 = staticdatabase.teams.play11;
                        if (staticdatabase.teams.play12.playoffgalibiyet2 < 2)
                        {
                            Random rnd = new Random();
                            int pos = rnd.Next(0, 3);
                            staticdatabase.teams.play12.playoffgalibiyet2 = staticdatabase.teams.play12.playoffgalibiyet2 + pos;
                        }
                    }
                    else
                    {
                        staticdatabase.teams.play12.playoffgalibiyet2 = 4;
                        staticdatabase.teams.play14 = staticdatabase.teams.play12;
                        if (staticdatabase.teams.play11.playoffgalibiyet2 < 2)
                        {
                            Random rnd = new Random();
                            int pos = rnd.Next(0, 3);
                            staticdatabase.teams.play11.playoffgalibiyet2 = staticdatabase.teams.play11.playoffgalibiyet2 + pos;
                        }
                    }
                    staticdatabase.lists.finalrakip = staticdatabase.teams.play14;
                    pbteam14.Image = staticdatabase.lists.finalrakip.logo;

                }
                if (staticdatabase.teams.play11.playoffgalibiyet2 == 4 || staticdatabase.teams.play12.playoffgalibiyet2 == 4)
                {
                    if (staticdatabase.teams.play11.playoffgalibiyet2 == 4)
                    {
                        staticdatabase.lists.finalrakip = staticdatabase.teams.play11;
                    }
                    else if (staticdatabase.teams.play12.playoffgalibiyet2 == 4)
                    {
                        staticdatabase.lists.finalrakip = staticdatabase.teams.play12;
                    }
                    pbteam14.Image = staticdatabase.lists.finalrakip.logo;
                }
            }
            else if (staticdatabase.teams.play11.name == staticdatabase.teams.secilentakim.name || staticdatabase.teams.play12.name == staticdatabase.teams.secilentakim.name)
            {
                staticdatabase.teams.play14 = staticdatabase.teams.secilentakim;
                if (staticdatabase.teams.play9.playoffgalibiyet2 != 4 && staticdatabase.teams.play10.playoffgalibiyet2 != 4)
                {
                    if (staticdatabase.teams.play9.playoffgalibiyet2 >= staticdatabase.teams.play10.playoffgalibiyet2)
                    {
                        staticdatabase.teams.play9.playoffgalibiyet2 = 4;
                        staticdatabase.teams.play13 = staticdatabase.teams.play9;
                        if (staticdatabase.teams.play10.playoffgalibiyet2 < 2)
                        {
                            Random rnd = new Random();
                            int pos = rnd.Next(0, 3);
                            staticdatabase.teams.play10.playoffgalibiyet2 = staticdatabase.teams.play10.playoffgalibiyet2 + pos;
                        }
                    }
                    else
                    {
                        staticdatabase.teams.play10.playoffgalibiyet2 = 4;
                        staticdatabase.teams.play14 = staticdatabase.teams.play10;
                        if (staticdatabase.teams.play9.playoffgalibiyet2 < 2)
                        {
                            Random rnd = new Random();
                            int pos = rnd.Next(0, 3);
                            staticdatabase.teams.play9.playoffgalibiyet2 = staticdatabase.teams.play9.playoffgalibiyet2 + pos;
                        }
                    }
                    staticdatabase.lists.finalrakip = staticdatabase.teams.play13;
                    pbteam13.Image = staticdatabase.lists.finalrakip.logo;

                }
                if (staticdatabase.teams.play9.playoffgalibiyet2 == 4 || staticdatabase.teams.play10.playoffgalibiyet2 == 4)
                {
                    if (staticdatabase.teams.play9.playoffgalibiyet2 == 4)
                    {
                        staticdatabase.lists.finalrakip = staticdatabase.teams.play9;
                    }
                    else if (staticdatabase.teams.play10.playoffgalibiyet2 == 4)
                    {
                        staticdatabase.lists.finalrakip = staticdatabase.teams.play10;
                    }
                    pbteam14.Image = staticdatabase.lists.finalrakip.logo;
                }
            }


        }

        public void tiklanantakimdoldur()
        {
            pbpg.Image = tiklanantakim.pg1.foto;
            pbsg.Image = tiklanantakim.sg1.foto;
            pbsf.Image = tiklanantakim.sf1.foto;
            pbpf.Image = tiklanantakim.pf1.foto;
            pbc.Image = tiklanantakim.c1.foto;
            pbpgyedek.Image = tiklanantakim.pg2.foto;
            pbsgyedek.Image = tiklanantakim.sg2.foto;
            pbsfyedek.Image = tiklanantakim.sf2.foto;
            pbpfyedek.Image = tiklanantakim.pf2.foto;
            pbcyedek.Image = tiklanantakim.c2.foto;
            lblsquadteamname.Text = tiklanantakim.name;
            pbseciliteamlogo.Image = tiklanantakim.logo;

            lblteamoverall.Text = tiklanantakim.Overallteam.ToString();
            lblteamoffoverall.Text = tiklanantakim.offoverallteam.ToString();
            lblteamdefoverall.Text = tiklanantakim.defoverallteam.ToString();
        }

        oyuncu tiklananoyuncu = new oyuncu();
        public void secilenoyuncudoldur()
        {
            lblplayername.Text = tiklananoyuncu.name;
            lblplayerpos.Text = tiklananoyuncu.pozisyon.ToString().ToUpper();
            lblplayerteam.Text = tiklanantakim.name;
            lblplayer3.Text = tiklananoyuncu.ucluk.ToString();
            lblplayer2.Text = tiklananoyuncu.ikilik.ToString();
            lblplayerasist.Text = tiklananoyuncu.asist.ToString();
            lblplayerblock.Text = tiklananoyuncu.block.ToString();
            lblplayerreb.Text = tiklananoyuncu.rebound.ToString();
            lblplayersteal.Text = tiklananoyuncu.steal.ToString();
            lbloffoverall.Text = tiklananoyuncu.Offoverall.ToString();
            lbldefoverall.Text = tiklananoyuncu.Defoverall.ToString();
            pbprofile.Image = tiklananoyuncu.foto;
        }



        private void btnnextmatch_Click(object sender, EventArgs e)
        {
            staticdatabase.lists.final = true;
            red1 frm = new red1();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        team tiklanantakim = new team();
        private void pbteam1_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play1;
            tiklanantakimdoldur();
        }

        private void pbteam8_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play8;
            tiklanantakimdoldur();
        }

        private void pbteam3_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play3;
            tiklanantakimdoldur();
        }

        private void pbteam6_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play6;
            tiklanantakimdoldur();
        }

        private void pbteam2_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play2;
            tiklanantakimdoldur();
        }

        private void pbteam7_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play7;
            tiklanantakimdoldur();
        }

        private void pbteam4_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play4;
            tiklanantakimdoldur();
        }

        private void pbteam5_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play5;
            tiklanantakimdoldur();
        }

        private void pbteam9_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play9;
            tiklanantakimdoldur();
        }

        private void pbteam10_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play10;
            tiklanantakimdoldur();
        }

        private void pbteam11_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play11;
            tiklanantakimdoldur();
        }

        private void pbteam12_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play12;
            tiklanantakimdoldur();
        }

        private void pbteam14_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play14;
            tiklanantakimdoldur();
        }

        private void pbteam13_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.play13;
            tiklanantakimdoldur();
        }

        private void pbsfyedek_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.sf2;
            secilenoyuncudoldur();

        }

        private void pbsgyedek_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.sg2;
            secilenoyuncudoldur();
        }

        private void pbcyedek_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.c2;
            secilenoyuncudoldur();
        }

        private void pbpgyedek_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.pg2;
            secilenoyuncudoldur();
        }

        private void pbpfyedek_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.pf2;
            secilenoyuncudoldur();
        }

        private void pbsg_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.sg1;
            secilenoyuncudoldur();
        }

        private void pbpg_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.pg1;
            secilenoyuncudoldur();
        }

        private void pbsf_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.sf1;
            secilenoyuncudoldur();
        }

        private void pbc_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.c1;
            secilenoyuncudoldur();
        }

        private void pbpf_Click(object sender, EventArgs e)
        {
            tiklananoyuncu = tiklanantakim.pf1;
            secilenoyuncudoldur();
        }
        tactics secilitaktik = new tactics();
        public void taktikyarat()
        {
            staticdatabase.teams.secilentakim.taktik1 = staticdatabase.lists.paceandspace;
            staticdatabase.teams.secilentakim.taktik2 = staticdatabase.lists.pickandroll;
            staticdatabase.teams.secilentakim.taktik3 = staticdatabase.lists.postup;
            staticdatabase.teams.secilentakim.standart = staticdatabase.lists.normal;
        }

        public void taktikbilgisi()
        {
            lblsecilitaktikisim.Text = secilitaktik.name;
            lblsecilitaktikpros.Text = secilitaktik.pros;
            lblsecilitaktikcons.Text = secilitaktik.cons;

        }

        public void secilitaktikler()
        {
            pbaktiftaktik1.Image = staticdatabase.teams.secilentakim.taktik1.resim;
            pbaktiftaktik2.Image = staticdatabase.teams.secilentakim.taktik2.resim;
            pbaktiftaktik3.Image = staticdatabase.teams.secilentakim.taktik3.resim;
        }
        public void buttonnormallestir()
        {
            btnnormal.Image = Resources.N;
            btniso.Image = Resources.ISO;
            btnpickroll.Image = Resources.PR;
            btnpost.Image = Resources.POST;
            btnpace.Image = Resources.PC;
            btnslow.Image = Resources.SLOW;
            btnuc.Image = Resources.ucluk1;
            btniki.Image = Resources.iki;
            btnpickandroll.Image = Resources.pickandroll;
        }
        public void btnpickgoster()
        {
            btnpick1.Visible = true;
            btnpick2.Visible = true;
            btnpick3.Visible = true;
            btnpick4.Visible = true;
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnnormal.Image = Resources.N2;
            secilitaktik = staticdatabase.lists.normal;
            taktikbilgisi();
            btnpickgoster();
        }

        private void btniso_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btniso.Image = Resources.ISO2;
            secilitaktik = staticdatabase.lists.isolation;
            taktikbilgisi();
            btnpickgoster();
        }

        private void btnpickroll_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnpickroll.Image = Resources.PR2;
            secilitaktik = staticdatabase.lists.pickandroll;
            taktikbilgisi();
            btnpickgoster();

        }

        private void btnpost_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnpost.Image = Resources.POST2;
            secilitaktik = staticdatabase.lists.postup;
            taktikbilgisi();
            btnpickgoster();
        }

        private void btnpace_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnpace.Image = Resources.PC2;
            secilitaktik = staticdatabase.lists.paceandspace;
            taktikbilgisi();
            btnpickgoster();
        }

        private void btnslow_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnslow.Image = Resources.SLOW2;
            secilitaktik = staticdatabase.lists.slow;
            taktikbilgisi();
            btnpickgoster();
        }
        private void btnuc_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnuc.Image = Resources.ucluk2;
            secilitaktik = staticdatabase.lists.three;
            taktikbilgisi();
            btnpickgoster();
        }

        private void btniki_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btniki.Image = Resources.iki2;
            secilitaktik = staticdatabase.lists.two;
            taktikbilgisi();
            btnpickgoster();
        }

        private void btnpickandroll_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnpickandroll.Image = Resources.pickandroll2;
            secilitaktik = staticdatabase.lists.pickandroll2;
            taktikbilgisi();
            btnpickgoster();
        }

        private void btnpick1_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim.taktik1 = secilitaktik;
            pbaktiftaktik1.Image = staticdatabase.teams.secilentakim.taktik1.resim;

        }

        private void btnpick2_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim.taktik2 = secilitaktik;
            pbaktiftaktik2.Image = staticdatabase.teams.secilentakim.taktik2.resim;
        }

        private void btnpick3_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim.taktik3 = secilitaktik;
            pbaktiftaktik3.Image = staticdatabase.teams.secilentakim.taktik3.resim;
        }

        private void btnpick4_Click(object sender, EventArgs e)
        {
            staticdatabase.teams.secilentakim.taktik4 = secilitaktik;
            pbaktiftaktik4.Image = staticdatabase.teams.secilentakim.taktik4.resim;
        }
        public void sarkisecimi()
        {

            if (sarki == 1)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Resources.sarki1);
                soundPlayer.PlayLooping();
            }
            else if (sarki == 2)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Resources.sarki2);
                soundPlayer.PlayLooping();
            }
            else if (sarki == 3)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Resources.sarki3);
                soundPlayer.PlayLooping();
            }
            else if (sarki == 4)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Resources.sarki4);
                soundPlayer.PlayLooping();
            }

        }
        int sarki = 0;
        SoundPlayer sound = new SoundPlayer();
        private void savebutonugizle()
        {
            btnnew.Visible = false;
            btnexit.Visible = false;
            btnnextmatch.Visible = false;
            lblsaveinfo.Visible = true;
            lblsaveinfo2.Visible = true;
        }
        private void savebutonugoster()
        {
            btnnew.Visible = true;
            btnexit.Visible = true;
            btnnextmatch.Visible = true;
            lblsaveinfo.Visible = false;
            lblsaveinfo2.Visible = false;
        }

        private void btnnew_Click(object sender, EventArgs e)
        {

            staticdatabase.lists.arkafon.Stop();
            staticdatabase.lists.arkafon.Dispose();
            sound.Stop();
            sound.Dispose();
            savebutonugizle();
            if (staticdatabase.lists.saveok < 2)
            {
                File.Delete("centersa.bin");
                File.Delete("playoffa.bin");
                File.Delete("playoff1a.bin");
                File.Delete("playoff2a.bin");
                File.Delete("listsa.bin");
                File.Delete("lists2a.bin");
                File.Delete("lists3a.bin");
                File.Delete("lists4a.bin");
                File.Delete("playersa.bin");
                File.Delete("pointguardsa.bin");
                File.Delete("powerforwardsa.bin");
                File.Delete("shootingguardsa.bin");
                File.Delete("smallforwardsa.bin");
                File.Delete("teamsa.bin");
                File.Delete("teams2a.bin");
                File.Delete("teams3a.bin");
                File.Delete("teams4a.bin");
                File.Delete("teams5a.bin");
                File.Delete("tradea.bin");




                File.Copy("centers.bin", "centersa.bin");
                File.Copy("playoff.bin", "playoffa.bin");
                File.Copy("playoff1.bin", "playoff1a.bin");
                File.Copy("playoff2.bin", "playoff2a.bin");
                File.Copy("lists.bin  ", "listsa.bin");
                File.Copy("lists2.bin", "lists2a.bin");
                File.Copy("lists3.bin", "lists3a.bin");
                File.Copy("lists4.bin", "lists4a.bin");
                File.Copy("players.bin", "playersa.bin");
                File.Copy("pointguards.bin", "pointguardsa.bin");
                File.Copy("powerforwards.bin", "powerforwardsa.bin");
                File.Copy("shootingguards.bin", "shootingguardsa.bin");
                File.Copy("smallforwards.bin", "smallforwardsa.bin");
                File.Copy("teams.bin", "teamsa.bin");
                File.Copy("teams2.bin", "teams2a.bin");
                File.Copy("teams3.bin", "teams3a.bin");
                File.Copy("teams4.bin", "teams4a.bin");
                File.Copy("teams5.bin", "teams5a.bin");
                File.Copy("trade.bin", "tradea.bin");


                File.Delete("centers.bin");
                File.Delete("playoff.bin");
                File.Delete("playoff1.bin");
                File.Delete("playoff2.bin");
                File.Delete("lists.bin");
                File.Delete("lists2.bin");
                File.Delete("lists3.bin");
                File.Delete("lists4.bin");
                File.Delete("players.bin");
                File.Delete("pointguards.bin");
                File.Delete("powerforwards.bin");
                File.Delete("shootingguards.bin");
                File.Delete("smallforwards.bin");
                File.Delete("teams.bin");
                File.Delete("teams2.bin");
                File.Delete("teams3.bin");
                File.Delete("teams4.bin");
                File.Delete("teams5.bin");
                File.Delete("trade.bin");
            }
            else if (staticdatabase.lists.saveok == 2)
            {
                File.Delete("centers.bin");
                File.Delete("playoff.bin");
                File.Delete("playoff1.bin");
                File.Delete("playoff2.bin");
                File.Delete("lists.bin");
                File.Delete("lists2.bin");
                File.Delete("lists3.bin");
                File.Delete("lists4.bin");
                File.Delete("players.bin");
                File.Delete("pointguards.bin");
                File.Delete("powerforwards.bin");
                File.Delete("shootingguards.bin");
                File.Delete("smallforwards.bin");
                File.Delete("teams.bin");
                File.Delete("teams2.bin");
                File.Delete("teams3.bin");
                File.Delete("teams4.bin");
                File.Delete("teams5.bin");
                File.Delete("trade.bin");


            }
            btnnew.Text = "PLEASE WAIT";

            timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            staticdatabase.centers.SaveState();


            staticdatabase.lists.SaveState();

            timer2.Start();
            timer1.Stop();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            staticdatabase.lists.SaveState2();

            staticdatabase.lists.SaveState3();
            lblsaveinfo.Text = "TIP:It's almost time to get the trophy! Keep fighting.";

            timer3.Start();
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            staticdatabase.lists.SaveState4();


            staticdatabase.players.SaveState();


            timer4.Start();
            timer3.Stop();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            staticdatabase.pointguards.SaveState();

            staticdatabase.powerforwards.SaveState();

            lblsaveinfo.Text = "TIP:Champions are always remembered, runners-ups never";

            timer5.Start();
            timer4.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            staticdatabase.shootingguards.SaveState();

            staticdatabase.smallforwards.SaveState();

            timer6.Start();
            timer5.Stop();
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            staticdatabase.teams.SaveState();

            staticdatabase.teams.SaveState2();

            lblsaveinfo.Text = $"TIP:If you become the champion, you will always be remembered as the coach of the {staticdatabase.teams.secilentakim.name}.";

            timer7.Start();
            timer6.Stop();
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            staticdatabase.teams.SaveState3();

            staticdatabase.teams.SaveState4();

            timer8.Start();
            timer7.Stop();
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            staticdatabase.teams.SaveState5();


            staticdatabase.lists.SaveStateForm6();
            Form5.SaveState();

            timer9.Start();
            timer8.Stop();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            staticdatabase.lists.SaveStateForm7();

            staticdatabase.lists.SaveStateForm8();
            btnnew.Text = "SAVED";
            savebutonugoster();

            timer9.Stop();
        }


    }
}
