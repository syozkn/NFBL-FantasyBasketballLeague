using Bigbang.classes;
using Bigbang.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigbang
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();


        }

        private void Form6_Load(object sender, EventArgs e)
        {
            baslangic();



        }

        private void baslangic()
        {

            staticdatabase.lists.saveload = 2;
            staticdatabase.teams.playoff = true;
            tiklanantakim = staticdatabase.teams.secilentakim;
            lblcoming1.Text = staticdatabase.teams.secilentakim.name;
            lbl1overall.Text = staticdatabase.teams.secilentakim.Overallteam.ToString();
            benibul();

            tiklanantakimdoldur();
            playofftablosu();
            fiksturdolur();
            benimtakimnext();
            galibiyetgoster();
            if (staticdatabase.lists.playoffmacsayisi != 0 && staticdatabase.lists.load == false)
            {
                ilkturmaclariyap();
                skorlariyaz();
            }
            if (staticdatabase.lists.load == true)
            {
                skorlariyaz();
            }




            playofftablosuikincitur();
            lbl2overall.Text = staticdatabase.lists.rakip.Overallteam.ToString();

            Random rnd = new Random();
            sarki = rnd.Next(1, 5);
            sarkisecimi();
            ilkturgalibiyetyaz();
            taktiktablosu();
            staticdatabase.lists.load = false;
        }

        private void taktiktablosu()
        {
            pbaktiftaktik1.Image = staticdatabase.teams.secilentakim.taktik1.resim;
            pbaktiftaktik2.Image = staticdatabase.teams.secilentakim.taktik2.resim;
            pbaktiftaktik3.Image = staticdatabase.teams.secilentakim.taktik3.resim;
            pbaktiftaktik4.Image = staticdatabase.teams.secilentakim.taktik4.resim;
        }


        tactics secilitaktik = new tactics();
        public void benibul()
        {
            if (staticdatabase.teams.play1.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play1 = staticdatabase.teams.secilentakim;
            else if (staticdatabase.teams.play2.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play2 = staticdatabase.teams.secilentakim;
            else if (staticdatabase.teams.play3.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play3 = staticdatabase.teams.secilentakim;
            else if (staticdatabase.teams.play4.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play4 = staticdatabase.teams.secilentakim;
            else if (staticdatabase.teams.play5.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play5 = staticdatabase.teams.secilentakim;
            else if (staticdatabase.teams.play6.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play6 = staticdatabase.teams.secilentakim;
            else if (staticdatabase.teams.play7.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play7 = staticdatabase.teams.secilentakim;
            else if (staticdatabase.teams.play8.name == staticdatabase.teams.secilentakim.name)
                staticdatabase.teams.play8 = staticdatabase.teams.secilentakim;




        }


        public void playofftablosuikincitur()
        {
            if (staticdatabase.teams.play9.logo != null)
                pbteam9.Image = staticdatabase.teams.play9.logo;
            if (staticdatabase.teams.play10.logo != null)
                pbteam10.Image = staticdatabase.teams.play10.logo;
            if (staticdatabase.teams.play11.logo != null)
                pbteam11.Image = staticdatabase.teams.play11.logo;
            if (staticdatabase.teams.play12.logo != null)
                pbteam12.Image = staticdatabase.teams.play12.logo;
        }






        public void ilkturgalibiyetyaz()
        {
            tur1t1.Text = staticdatabase.teams.play1.playoffgalibiyet.ToString();
            tur1t2.Text = staticdatabase.teams.play2.playoffgalibiyet.ToString();
            tur1t3.Text = staticdatabase.teams.play3.playoffgalibiyet.ToString();
            tur1t4.Text = staticdatabase.teams.play4.playoffgalibiyet.ToString();
            tur1t5.Text = staticdatabase.teams.play5.playoffgalibiyet.ToString();
            tur1t6.Text = staticdatabase.teams.play6.playoffgalibiyet.ToString();
            tur1t7.Text = staticdatabase.teams.play7.playoffgalibiyet.ToString();
            tur1t8.Text = staticdatabase.teams.play8.playoffgalibiyet.ToString();


        }

        private void PLAYOFF_Enter(object sender, EventArgs e)
        {

        }




        public void galibiyetgoster()
        {
            lblteamgalibiyet1.Text = staticdatabase.teams.secilentakim.playoffgalibiyet.ToString();
            lblteamgalibiyet2.Text = staticdatabase.lists.rakip.playoffgalibiyet.ToString();

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

        Random rnd = new Random();
        int galibiyet = 0;


        public void ilkturmaclariyap()
        {

            if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play1.name && staticdatabase.teams.play1.playoffgalibiyet != 4 && staticdatabase.teams.play8.playoffgalibiyet != 4)
            {
                if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play8.name)
                {

                    Random r1 = new Random();
                    galibiyet = r1.Next(0, 10);
                    if (galibiyet >= 2)
                    {
                        staticdatabase.teams.play1.playoffgalibiyet++;
                        staticdatabase.teams.play1.skor = r1.Next(108, 125);
                        staticdatabase.teams.play8.skor = r1.Next(89, 108);
                    }
                    else
                    {
                        staticdatabase.teams.play8.playoffgalibiyet++;
                        staticdatabase.teams.play8.skor = r1.Next(108, 125);
                        staticdatabase.teams.play1.skor = r1.Next(89, 108);
                    }
                }
            }
            if (staticdatabase.teams.play1.playoffgalibiyet == 4 || staticdatabase.teams.play8.playoffgalibiyet == 4 || staticdatabase.lists.birincieslesme == false)
            {
                if (staticdatabase.teams.play1.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play9 = staticdatabase.teams.play1;
                    staticdatabase.teams.play1.playoffgalibiyet = 4;
                    pbteam9.Image = staticdatabase.teams.play9.logo;
                }

                if (staticdatabase.teams.play8.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play9 = staticdatabase.teams.play8;
                    staticdatabase.teams.play8.playoffgalibiyet = 4;
                    pbteam9.Image = staticdatabase.teams.play9.logo;
                }
                lblfiks1.Visible = false;
                lblfiks2.Visible = false;
                skor1.Visible = false;
                skor2.Visible = false;
                staticdatabase.lists.birincieslesme = true;
            }


            if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play3.name && staticdatabase.teams.play3.playoffgalibiyet != 4 && staticdatabase.teams.play6.playoffgalibiyet != 4)
            {
                if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play6.name)
                {
                    Random r2 = new Random();
                    galibiyet = r2.Next(0, 10);

                    if (galibiyet >= 4)
                    {
                        staticdatabase.teams.play3.playoffgalibiyet++;
                        staticdatabase.teams.play3.skor = r2.Next(108, 125);
                        staticdatabase.teams.play6.skor = r2.Next(89, 108);
                    }
                    else
                    {
                        staticdatabase.teams.play6.playoffgalibiyet++;
                        staticdatabase.teams.play6.skor = r2.Next(108, 125);
                        staticdatabase.teams.play3.skor = r2.Next(89, 108);
                    }
                }
            }
            if (staticdatabase.teams.play3.playoffgalibiyet == 4 || staticdatabase.teams.play6.playoffgalibiyet == 4 || staticdatabase.lists.ikincieslesme == false)
            {
                if (staticdatabase.teams.play3.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play10 = staticdatabase.teams.play3;
                    staticdatabase.teams.play3.playoffgalibiyet = 4;
                    pbteam10.Image = staticdatabase.teams.play10.logo;
                }

                if (staticdatabase.teams.play6.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play10 = staticdatabase.teams.play6;
                    staticdatabase.teams.play3.playoffgalibiyet = 4;
                    pbteam10.Image = staticdatabase.teams.play10.logo;
                }
                lblfiks5.Visible = false;
                lblfiks6.Visible = false;
                fskor5.Visible = false;
                fskor6.Visible = false;
                staticdatabase.lists.ikincieslesme = true;

            }
            if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play2.name && staticdatabase.teams.play2.playoffgalibiyet != 4 && staticdatabase.teams.play7.playoffgalibiyet != 4)
            {
                if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play7.name)
                {
                    Random r3 = new Random();
                    galibiyet = r3.Next(0, 10);
                    if (galibiyet >= 3)
                    {
                        staticdatabase.teams.play2.playoffgalibiyet++;
                        staticdatabase.teams.play2.skor = r3.Next(108, 125);
                        staticdatabase.teams.play7.skor = r3.Next(89, 108);
                    }
                    else
                    {
                        staticdatabase.teams.play7.playoffgalibiyet++;
                        staticdatabase.teams.play7.skor = r3.Next(108, 125);
                        staticdatabase.teams.play2.skor = r3.Next(89, 108);
                    }
                }
            }
            if (staticdatabase.teams.play2.playoffgalibiyet == 4 || staticdatabase.teams.play7.playoffgalibiyet == 4 || staticdatabase.lists.ucuncueslesme == false)
            {
                if (staticdatabase.teams.play2.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play11 = staticdatabase.teams.play2;
                    staticdatabase.teams.play2.playoffgalibiyet = 4;
                    pbteam11.Image = staticdatabase.teams.play11.logo;
                }

                if (staticdatabase.teams.play7.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play11 = staticdatabase.teams.play7;
                    staticdatabase.teams.play7.playoffgalibiyet = 4;
                    pbteam11.Image = staticdatabase.teams.play11.logo;
                }
                lblfiks3.Visible = false;
                lblfiks4.Visible = false;
                fskor3.Visible = false;
                fskor4.Visible = false;
                staticdatabase.lists.ucuncueslesme = true;


            }
            if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play4.name && staticdatabase.teams.play4.playoffgalibiyet != 4 && staticdatabase.teams.play5.playoffgalibiyet != 4)
            {
                if (staticdatabase.teams.secilentakim.name != staticdatabase.teams.play5.name)
                {
                    Random r4 = new Random();
                    galibiyet = r4.Next(0, 10);
                    if (galibiyet >= 5)
                    {
                        staticdatabase.teams.play4.playoffgalibiyet++;
                        staticdatabase.teams.play4.skor = r4.Next(108, 125);
                        staticdatabase.teams.play5.skor = r4.Next(89, 108);
                    }
                    else
                    {
                        staticdatabase.teams.play5.playoffgalibiyet++;
                        staticdatabase.teams.play5.skor = r4.Next(108, 125);
                        staticdatabase.teams.play4.skor = r4.Next(89, 108);
                    }
                }
            }
            if (staticdatabase.teams.play4.playoffgalibiyet == 4 || staticdatabase.teams.play5.playoffgalibiyet == 4 || staticdatabase.lists.dorduncueslesme == false)
            {
                if (staticdatabase.teams.play4.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play12 = staticdatabase.teams.play4;
                    staticdatabase.teams.play4.playoffgalibiyet = 4;
                    pbteam12.Image = staticdatabase.teams.play12.logo;
                }

                if (staticdatabase.teams.play5.playoffgalibiyet == 4)
                {
                    staticdatabase.teams.play12 = staticdatabase.teams.play5;
                    staticdatabase.teams.play5.playoffgalibiyet = 4;
                    pbteam12.Image = staticdatabase.teams.play12.logo;
                }
                lblfiks7.Visible = false;
                lblfiks8.Visible = false;
                fskor7.Visible = false;
                fskor8.Visible = false;
                staticdatabase.lists.dorduncueslesme = true;
            }
        }





        public void playofftablosu()
        {
            pbteam1.Image = staticdatabase.teams.play1.logo;
            pbteam2.Image = staticdatabase.teams.play2.logo;
            pbteam3.Image = staticdatabase.teams.play3.logo;
            pbteam4.Image = staticdatabase.teams.play4.logo;
            pbteam5.Image = staticdatabase.teams.play5.logo;
            pbteam6.Image = staticdatabase.teams.play6.logo;
            pbteam7.Image = staticdatabase.teams.play7.logo;
            pbteam8.Image = staticdatabase.teams.play8.logo;
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

        public void skorlariyaz()
        {
            skor1.Text = staticdatabase.teams.play1.skor.ToString();
            skor2.Text = staticdatabase.teams.play8.skor.ToString();

            fskor3.Text = staticdatabase.teams.play2.skor.ToString();
            fskor4.Text = staticdatabase.teams.play7.skor.ToString();

            fskor5.Text = staticdatabase.teams.play3.skor.ToString();
            fskor6.Text = staticdatabase.teams.play6.skor.ToString();

            fskor7.Text = staticdatabase.teams.play4.skor.ToString();
            fskor8.Text = staticdatabase.teams.play5.skor.ToString();

        }

        public void fiksturdolur()
        {
            lblfiks1.Text = staticdatabase.teams.play1.name;
            lblfiks2.Text = staticdatabase.teams.play8.name;

            lblfiks3.Text = staticdatabase.teams.play2.name;
            lblfiks4.Text = staticdatabase.teams.play7.name;

            lblfiks5.Text = staticdatabase.teams.play3.name;
            lblfiks6.Text = staticdatabase.teams.play6.name;

            lblfiks7.Text = staticdatabase.teams.play4.name;
            lblfiks8.Text = staticdatabase.teams.play5.name;
        }






        public void benimtakimnext()
        {
            pbcomingteam1.Image = staticdatabase.teams.secilentakim.logo;
            if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play1.name)
            {
                pbcoming2.Image = staticdatabase.teams.play8.logo;
                lblcoming2.Text = staticdatabase.teams.play8.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play8;
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play2.name)
            {
                pbcoming2.Image = staticdatabase.teams.play7.logo;
                lblcoming2.Text = staticdatabase.teams.play7.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play7;
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play3.name)
            {
                pbcoming2.Image = staticdatabase.teams.play6.logo;
                lblcoming2.Text = staticdatabase.teams.play6.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play6;
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play4.name)
            {
                pbcoming2.Image = staticdatabase.teams.play5.logo;
                lblcoming2.Text = staticdatabase.teams.play5.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play5;
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play5.name)
            {
                pbcoming2.Image = staticdatabase.teams.play4.logo;
                lblcoming2.Text = staticdatabase.teams.play4.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play4;
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play6.name)
            {
                pbcoming2.Image = staticdatabase.teams.play3.logo;
                lblcoming2.Text = staticdatabase.teams.play3.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play3;
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play7.name)
            {
                pbcoming2.Image = staticdatabase.teams.play2.logo;
                lblcoming2.Text = staticdatabase.teams.play2.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play2;
            }
            else if (staticdatabase.teams.secilentakim.name == staticdatabase.teams.play8.name)
            {
                pbcoming2.Image = staticdatabase.teams.play1.logo;
                lblcoming2.Text = staticdatabase.teams.play1.name;
                staticdatabase.lists.rakip = staticdatabase.teams.play1;
            }
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
            staticdatabase.lists.load = false;
            red1 frm = new red1();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }
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
            pbaktiftaktik4.Image = staticdatabase.teams.secilentakim.taktik4.resim;
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

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
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

        SoundPlayer sound = new SoundPlayer();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tur1t2_Click(object sender, EventArgs e)
        {

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

            lblsaveinfo.Text = "TIP:Playoff Series Are BO7";

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

            lblsaveinfo.Text = "TIP:Just because a player has a good offense doesn't mean he's always going to score.";

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

            lblsaveinfo.Text = "TIP:If your best player has come across a tough defender, the force switch tactic is a good way to boost his performance.";

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

            lblsaveinfo.Text = "TIP: Playing high-paced basketball with a team that doesn't have good passing skills is like suicide.";

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnew_Click_1(object sender, EventArgs e)
        {
            staticdatabase.lists.arkafon.Stop();
            staticdatabase.lists.arkafon.Dispose();
            sound.Stop();
            sound.Dispose();
            lblsaveinfo.Text = string.Empty;
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

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnextmatch_Click_1(object sender, EventArgs e)
        {
            staticdatabase.lists.load = false;
            red1 frm = new red1();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }
    }
}
