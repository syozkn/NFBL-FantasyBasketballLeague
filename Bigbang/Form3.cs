using Bigbang.classes;
using Bigbang.Properties;
using Bigbang.staticdatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bigbang
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void oyuncutopla()
        {
            for (int i = 0; i < staticdatabase.lists.pgs2.Count-1; i++)
            {
                staticdatabase.lists.oyuncus.Add(staticdatabase.lists.pgs2[i]);
            }
            for (int i = 0; i < staticdatabase.lists.sgs2.Count - 1; i++)
            {
                staticdatabase.lists.oyuncus.Add(staticdatabase.lists.sgs2[i]);
            }
            for (int i = 0; i < staticdatabase.lists.sfs2.Count - 1; i++)
            {
                staticdatabase.lists.oyuncus.Add(staticdatabase.lists.sfs2[i]);
            }
            for (int i = 0; i < staticdatabase.lists.pfs2.Count - 1; i++)
            {
                staticdatabase.lists.oyuncus.Add(staticdatabase.lists.pfs2[i]);
            }
            for (int i = 0; i < staticdatabase.lists.cs2.Count - 1; i++)
            {
                staticdatabase.lists.oyuncus.Add(staticdatabase.lists.cs2[i]);
            }
        }
        
        public  void taktikyarat()
        {
            staticdatabase.teams.secilentakim.taktik1 = staticdatabase.lists.paceandspace;
            staticdatabase.teams.secilentakim.taktik2 = staticdatabase.lists.pickandroll;
            staticdatabase.teams.secilentakim.taktik3 = staticdatabase.lists.postup;
            staticdatabase.teams.secilentakim.taktik4 = staticdatabase.lists.isolation;
            staticdatabase.teams.secilentakim.standart = staticdatabase.lists.normal;
        }

        private void taktikresimleri()
        {
            pbstandarttaktik.Image = staticdatabase.teams.secilentakim.standart.resim;
            pbaktiftaktik1.Image = staticdatabase.teams.secilentakim.taktik1.resim;
            pbaktiftaktik2.Image = staticdatabase.teams.secilentakim.taktik2.resim;
            pbaktiftaktik3.Image = staticdatabase.teams.secilentakim.taktik3.resim;
            pbaktiftaktik4.Image = staticdatabase.teams.secilentakim.taktik4.resim;

        }

        public void secilitaktikler()
        {
            pbaktiftaktik1.Image = staticdatabase.teams.secilentakim.taktik1.resim;
            pbaktiftaktik2.Image = staticdatabase.teams.secilentakim.taktik2.resim;
            pbaktiftaktik3.Image = staticdatabase.teams.secilentakim.taktik3.resim;
        }

        public static tactics secilitaktik = new tactics();

        public void taktikbilgisi()
        {
            lblsecilitaktikisim.Text = secilitaktik.name;
            lblsecilitaktikpros.Text = secilitaktik.pros;
            lblsecilitaktikcons.Text = secilitaktik.cons;
            
        }
        public void sarkisecimi()
        {
            
            if(sarki==1)
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
            else if(sarki == 4)
            {
                SoundPlayer soundPlayer = new SoundPlayer(Resources.sarki4);
                soundPlayer.PlayLooping();
            }

        }

        SoundPlayer sound = new SoundPlayer();
        int sarki = 0;
        public void guncelleme()
        {
            if(staticdatabase.lists.macsonuc==true)
            {
                lblinfo.Text = "Great Win Tonight. Great Effort!";
                lblinfo2.Text = $"Added to your {staticdatabase.lists.kazan}M budget for winning your last game.";
                lblinfo3.Text = "Free players are available. You can go to the trade center to trade.";
                lblinfo.ForeColor = Color.Green;
                lblinfo2.ForeColor = Color.Green;
                lblinfo3.ForeColor = Color.Green;
            }
            else if(staticdatabase.lists.macsonuc == false)
            {
                lblinfo.Text = "Unfortunately we lost tonight, but we will continue to improve!";
                lblinfo2.Text = $"Added to your {staticdatabase.lists.kaybet}M budget for losing your last game.";
                lblinfo3.Text = "Free agent players are available. You can go to the trade center to trade.";
                lblinfo.ForeColor = Color.Green;
                lblinfo2.ForeColor = Color.Green;
                lblinfo3.ForeColor = Color.Green;
            }
            if(staticdatabase.teams.macsayisi==9)
            {
                lblinfo.Text = "The league is now complete. This is your last chance to improve your team";
                lblinfo2.Text = $"Be sure to take one last look at your roster before you head into the playoffs.";
                lblinfo3.Text = "Free agent players are available. You can go to the trade center to trade.";
                lblinfo.ForeColor = Color.Green;
                lblinfo2.ForeColor = Color.Green;
                lblinfo3.ForeColor = Color.Green;

            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            staticdatabase.lists.saveload = 1;

            if (staticdatabase.teams.macsayisi == 0)
            {
                btntransfer.Visible=false;
            }
            else if(staticdatabase.teams.macsayisi != 0)
            {
                btntransfer.Visible = true;
                guncelleme();


            }
            if(staticdatabase.lists.sarkivarmi==true)
            {
                Random rnd = new Random();
                sarki = rnd.Next(1, 5);
                sarkisecimi();
            }
            staticdatabase.lists.sarkivarmi = false;


            if (staticdatabase.teams.ligbasla == false)
            { 
                takimdraftlari();
                oyuncutopla();
                taktikyarat();

            }
            fikstur();
            secilitaktikler();
            btnpickgizle();
            taktikresimleri();
            
            
            
            tiklanantakim = staticdatabase.teams.secilentakim;
            takimtiklama();
            pbcomingteam1.Image = staticdatabase.teams.secilentakim.logo;
            pbcoming2.Image = staticdatabase.teams.lig[staticdatabase.teams.siradakitakim].logo;
            lblcoming1.Text= staticdatabase.teams.secilentakim.name;
            lblcoming2.Text = staticdatabase.teams.lig[staticdatabase.teams.siradakitakim].name;
            if (staticdatabase.teams.macsayisi != 0)
            {
                maclariyap();
            }


            takimlogolari();

            statsdoldur();
            lblbudget.Text = staticdatabase.teams.secilentakim.salary.ToString();

            if(staticdatabase.teams.macsayisi == 9)//------------------------------------------------------------------------------
            {
                btnnextmatch.Text = "GO TO PLAYOFF";
                
                pbcoming2.Visible = false;
                pbcomingteam1.Visible = false;
                lblcoming1.Visible = false;
                lblcoming2.Visible = false;
                lbl1win.Visible = false;
                lbl2win.Visible = false;
                lbl1lose.Visible = false;
                lbl2lose.Visible = false;
                lbl1overall.Visible = false;
                lbl2overall.Visible = false;

            }
            for (int i = 0; i <= staticdatabase.teams.lig2.Count - 1; i++)
            {
                lvstandings.Items.Add((staticdatabase.teams.lig2[i].ToString()));
            }





        }

        public void takimlogolari()
        {
            pbseciliteamlogo.Image = staticdatabase.teams.secilentakim.logo;
            pbsenintakim.Image= staticdatabase.teams.secilentakim.logo;
            pbteam0.Image = staticdatabase.teams.lig[0].logo;
            pbteam1.Image = staticdatabase.teams.lig[1].logo;
            pbteam2.Image = staticdatabase.teams.lig[2].logo;
            pbteam3.Image = staticdatabase.teams.lig[3].logo;
            pbteam4.Image = staticdatabase.teams.lig[4].logo;
            pbteam5.Image = staticdatabase.teams.lig[5].logo;
            pbteam6.Image = staticdatabase.teams.lig[6].logo;
            pbteam7.Image = staticdatabase.teams.lig[7].logo;
            pbteam8.Image = staticdatabase.teams.lig[8].logo;
            pbteam9.Image = staticdatabase.teams.lig[9].logo;
            pbteam10.Image = staticdatabase.teams.lig[10].logo;
            lbl1win.Text = Convert.ToString(staticdatabase.teams.secilentakim.win) ;
            lbl1lose.Text = Convert.ToString(staticdatabase.teams.secilentakim.lose);
            lbl2win.Text = Convert.ToString(staticdatabase.teams.lig[staticdatabase.teams.siradakitakim].win);
            lbl2lose.Text = Convert.ToString(staticdatabase.teams.lig[staticdatabase.teams.siradakitakim].lose);
            lbl1overall.Text = Convert.ToString(staticdatabase.teams.secilentakim.Overallteam);
            lbl2overall.Text = Convert.ToString(staticdatabase.teams.lig[staticdatabase.teams.siradakitakim].Overallteam);




        }

        public void takimdraftlari()
        {

            foreach (var takim in staticdatabase.teams.lig)
            {
                Random r = new Random();
                int pg1sec=r.Next(0, staticdatabase.lists.pgs2.Count/2);
                takim.pg1 = staticdatabase.lists.pgs2[pg1sec];
                staticdatabase.lists.pgs2.Remove(staticdatabase.lists.pgs2[pg1sec]);

                
                int pg2sec = r.Next(staticdatabase.lists.pgs2.Count / 2, staticdatabase.lists.pgs2.Count);
                takim.pg2 = staticdatabase.lists.pgs2[pg2sec];
                staticdatabase.lists.pgs2.Remove(staticdatabase.lists.pgs2[pg2sec]);

                int sg1sec=r.Next(0, staticdatabase.lists.sgs2.Count/2);
                takim.sg1 = staticdatabase.lists.sgs2[sg1sec];
                staticdatabase.lists.sgs2.Remove(staticdatabase.lists.sgs2[sg1sec]);

                int sg2sec = r.Next(staticdatabase.lists.sgs2.Count / 2, staticdatabase.lists.sgs2.Count);
                takim.sg2 = staticdatabase.lists.sgs2[sg2sec];
                staticdatabase.lists.sgs2.Remove(staticdatabase.lists.sgs2[sg2sec]);

                int sf1sec = r.Next(0, staticdatabase.lists.sfs2.Count/2);
                takim.sf1 = staticdatabase.lists.sfs2[sf1sec];
                staticdatabase.lists.sfs2.Remove(staticdatabase.lists.sfs2[sf1sec]);

                int sf2sec = r.Next(staticdatabase.lists.sfs2.Count / 2, staticdatabase.lists.sfs2.Count);
                takim.sf2 = staticdatabase.lists.sfs2[sf2sec];
                staticdatabase.lists.sfs2.Remove(staticdatabase.lists.sfs2[sf2sec]);

                int pf1sec=r.Next(0, staticdatabase.lists.pfs2.Count/2);
                takim.pf1 = staticdatabase.lists.pfs2[pf1sec];
                staticdatabase.lists.pfs2.Remove(staticdatabase.lists.pfs2[pf1sec]);

                int pf2sec = r.Next(staticdatabase.lists.pfs2.Count / 2, staticdatabase.lists.pfs2.Count);
                takim.pf2 = staticdatabase.lists.pfs2[pf2sec];
                staticdatabase.lists.pfs2.Remove(staticdatabase.lists.pfs2[pf2sec]);

                int c1sec = r.Next(0, staticdatabase.lists.cs2.Count/2);
                takim.c1 = staticdatabase.lists.cs2[c1sec];
                staticdatabase.lists.cs2.Remove(staticdatabase.lists.cs2[c1sec]);

                int c2sec = r.Next(staticdatabase.lists.cs2.Count / 2, staticdatabase.lists.cs2.Count);
                takim.c2 = staticdatabase.lists.cs2[c2sec];
                staticdatabase.lists.cs2.Remove(staticdatabase.lists.cs2[c2sec]);
            }
            staticdatabase.teams.ligbasla = true;





        }
        public static team tiklanantakim = new team();
        //profiler a oyuncu aktarmak için oyuncular.
        oyuncu oyuncupg1 = new oyuncu();
        oyuncu oyuncusg1 = new oyuncu();
        oyuncu oyuncusf1 = new oyuncu();
        oyuncu oyuncupf1 = new oyuncu();
        oyuncu oyuncuc1 = new oyuncu();
        oyuncu secilen = new oyuncu();


        public void profileracma(oyuncu secilen)
        {
            pbprofile.Image = secilen.foto;
            lblplayername.Text = secilen.name.ToUpper();
            lblplayerpos.Text = Convert.ToString(secilen.pozisyon).ToUpper();
            lblplayerteam.Text = tiklanantakim.name;
            lblplayerasist.Text=Convert.ToString(secilen.asist);
            lblplayerblock.Text = Convert.ToString(secilen.block);
            lblplayerreb.Text = Convert.ToString(secilen.rebound);
            lblplayersteal.Text= Convert.ToString(secilen.steal);
            lblplayer3.Text = Convert.ToString(secilen.ucluk);
            lblplayer2.Text = Convert.ToString(secilen.ikilik);
            lbloffoverall.Text = Convert.ToString(secilen.Offoverall);
            lbldefoverall.Text = Convert.ToString(secilen.Defoverall);
            lbloverall.Text = Convert.ToString(secilen.Overall);
            lblsalary.Text = Convert.ToString(secilen.salary);




        }
        

        public void takimtiklama()
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
            pbseciliteamlogo.Image=tiklanantakim.logo;
            oyuncupg1 = tiklanantakim.pg1;
            oyuncusg1 = tiklanantakim.sg1;
            oyuncusf1 = tiklanantakim.sf1;
            oyuncupf1 = tiklanantakim.pf1;
            oyuncuc1 = tiklanantakim.c1;
            lblteamoverall.Text = tiklanantakim.Overallteam.ToString();
            lblteamoffoverall.Text = tiklanantakim.offoverallteam.ToString();
            lblteamdefoverall.Text = tiklanantakim.defoverallteam.ToString();

            lbl1.Text = tiklanantakim.pg1.name;
            lbl2.Text = tiklanantakim.sg1.name;
            lbl3.Text = tiklanantakim.sf1.name;
            lbl4.Text = tiklanantakim.pf1.name;
            lbl5.Text = tiklanantakim.c1.name;
            lbl6.Text = tiklanantakim.pg2.name;
            lbl7.Text = tiklanantakim.sg2.name;
            lbl8.Text = tiklanantakim.sf2.name;
            lbl9.Text = tiklanantakim.pf2.name;
            lbl10.Text =tiklanantakim.c2.name;
            if (staticdatabase.teams.macsayisi != 0)
            {
                lblptspg1.Text = tiklanantakim.pg1.tekpoint.ToString();
                lblptssg1.Text = tiklanantakim.sg1.tekpoint.ToString();
                lblptssf1.Text = tiklanantakim.sf1.tekpoint.ToString();
                lblptspf1.Text = tiklanantakim.pf1.tekpoint.ToString();
                lblptsc1.Text = tiklanantakim.c1.tekpoint   .ToString();
                lblptspg2.Text = tiklanantakim.pg2.tekpoint .ToString();
                lblptssg2.Text = tiklanantakim.sg2.tekpoint .ToString();
                lblptssf2.Text = tiklanantakim.sf2.tekpoint .ToString();
                lblptspf2.Text = tiklanantakim.pf2.tekpoint .ToString();
                lblptsc2.Text = tiklanantakim.c2.tekpoint.ToString();
                skor1.Text = staticdatabase.teams.skor1.ToString();
                skor2.Text=staticdatabase.teams.skor2.ToString();

                lblpg1ast.Text= tiklanantakim.pg1.tekasist.ToString();
                lblsg1ast.Text = tiklanantakim.sg1.tekasist.ToString();
                lblsf1ast.Text = tiklanantakim.sf1.tekasist.ToString();
                lblpf1ast.Text = tiklanantakim.pf1.tekasist.ToString();
                lblc1ast.Text = tiklanantakim.c1.tekasist.ToString();
                lblpg2ast.Text = tiklanantakim.pg2.tekasist.ToString();
                lblsg2ast.Text = tiklanantakim.sg2.tekasist.ToString();
                lblsf2ast.Text = tiklanantakim.sf2.tekasist.ToString();
                lblpf2ast.Text = tiklanantakim.pf2.tekasist.ToString();
                lblc2ast.Text = tiklanantakim.c2.tekasist.ToString();

                lblpg1reb.Text = tiklanantakim.pg1.tekrebound.ToString();
                lblsg1reb.Text = tiklanantakim.sg1.tekrebound.ToString();
                lblsf1reb.Text = tiklanantakim.sf1.tekrebound.ToString();
                lblpf1reb.Text = tiklanantakim.pf1.tekrebound.ToString();
                lblc1reb.Text = tiklanantakim.c1.tekrebound.ToString();
                lblpg2reb.Text = tiklanantakim.pg2.tekrebound.ToString();
                lblsg2reb.Text = tiklanantakim.sg2.tekrebound.ToString();
                lblsf2reb.Text = tiklanantakim.sf2.tekrebound.ToString();
                lblpf2reb.Text = tiklanantakim.pf2.tekrebound.ToString();
                lblc2reb.Text = tiklanantakim.c2.tekrebound.ToString();

                lblpg1blk.Text = tiklanantakim.pg1.tekblock.ToString();
                lblsg1blk.Text = tiklanantakim.sg1.tekblock.ToString();
                lblsf1blk.Text = tiklanantakim.sf1.tekblock.ToString();
                lblpf1blk.Text = tiklanantakim.pf1.tekblock.ToString();
                lblc1blk.Text = tiklanantakim.c1.tekblock.ToString();
                lblpg2blk.Text = tiklanantakim.pg2.tekblock.ToString();
                lblsg2blk.Text = tiklanantakim.sg2.tekblock.ToString();
                lblsf2blk.Text = tiklanantakim.sf2.tekblock.ToString();
                lblpf2blk.Text = tiklanantakim.pf2.tekblock.ToString();
                lblc2blk.Text = tiklanantakim.c2.tekblock.ToString();


                lblpg1stl.Text = tiklanantakim.pg1.teksteal.ToString();
                lblsg1stl.Text = tiklanantakim.sg1.teksteal.ToString();
                lblsf1stl.Text = tiklanantakim.sf1.teksteal.ToString();
                lblpf1stl.Text = tiklanantakim.pf1.teksteal.ToString();
                lblc1stl.Text = tiklanantakim.c1.teksteal.ToString();
                lblpg2stl.Text = tiklanantakim.pg2.teksteal.ToString();
                lblsg2stl.Text = tiklanantakim.sg2.teksteal.ToString();
                lblsf2stl.Text = tiklanantakim.sf2.teksteal.ToString();
                lblpf2stl.Text = tiklanantakim.pf2.teksteal.ToString();
                lblc2stl.Text = tiklanantakim.c2.teksteal.ToString();
            }

        }

        public void budgetgoster()
        {
            if (tiklanantakim.name != staticdatabase.teams.secilentakim.name)
            {
                lblbudget.Visible = false;
            }
            else if (tiklanantakim.name == staticdatabase.teams.secilentakim.name)
            {
                lblbudget.Visible = true;
                lblbudget.Text = staticdatabase.teams.secilentakim.salary.ToString();
            }
        }

        private void pbteam0_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[0];
            takimtiklama();
            budgetgoster();
       
        }
        private void pbteam1_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[1];
            takimtiklama();
            budgetgoster();
        }
        private void pbteam2_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[2];
            takimtiklama();
            budgetgoster();
        }



        private void pbteam3_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[3];
            takimtiklama();
            budgetgoster();
        }

        private void pbteam4_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[4];
            takimtiklama();
            budgetgoster();
        }

        private void pbteam5_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[5];
            takimtiklama();
            budgetgoster();
        }

        private void pbteam6_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[6];
            takimtiklama();
            budgetgoster();
        }

        private void pbteam7_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[7];
            takimtiklama();
            budgetgoster();
        }

        private void pbteam8_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[8];
            takimtiklama();
            budgetgoster();
        }

        private void pbteam9_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[9];
            takimtiklama();
            budgetgoster();
        }

        private void pbteam10_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.lig[10];
            takimtiklama();
            budgetgoster();
        }

        private void pbsenintakim_Click(object sender, EventArgs e)
        {
            tiklanantakim = staticdatabase.teams.secilentakim;
            takimtiklama();
            budgetgoster();
        }

        private void pbpg_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.pg1;
            profileracma(secilen);
        }

        private void pbsg_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.sg1;
            profileracma(secilen);
        }

        private void pbsf_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.sf1;
            profileracma(secilen);

        }

        private void pbpf_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.pf1;
            profileracma(secilen);
        }

        private void pbc_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.c1;
            profileracma(secilen);
            
        }

        private void pbpgyedek_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.pg2;
            profileracma(secilen);
        }

        private void pbsgyedek_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.sg2;
            profileracma(secilen);
        }

        private void pbsfyedek_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.sf2;
            profileracma(secilen);

        }

        private void pbcyedek_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.c2;
            profileracma(secilen);
        }

        private void pbpfyedek_Click(object sender, EventArgs e)
        {
            secilen = tiklanantakim.pf2;
            profileracma(secilen);
        }

        private void gpsquad_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private bool devam = true;
        private void btnnextmatch_Click(object sender, EventArgs e)
        {
            if (staticdatabase.teams.macsayisi == 9) //---------------------------------------------------------------------------------------------------------
            {
                playoffyolu();
                if (devam == true)
                {
                    Form6 frm6 = new Form6();
                    this.Hide();
                    frm6.ShowDialog();
                    this.Close();
                }
            }
            else
            {
                staticdatabase.lists.transfer = true;

                red1 frm = new red1();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();
            }
        }

        public void fikstur()
        {
            if(staticdatabase.teams.macsayisi==0)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[0].name;

                lblfiks3.Text = staticdatabase.teams.lig[1].name;
                lblfiks4.Text = staticdatabase.teams.lig[3].name;

                lblfiks5.Text = staticdatabase.teams.lig[7].name;
                lblfiks6.Text = staticdatabase.teams.lig[9].name;

                lblfiks7.Text = staticdatabase.teams.lig[10].name;
                lblfiks8.Text = staticdatabase.teams.lig[6].name;

                lblfiks9.Text = staticdatabase.teams.lig[8].name;
                lblfiks10.Text = staticdatabase.teams.lig[2].name;

                lblfiks11.Text = staticdatabase.teams.lig[5].name;
                lblfiks12.Text = staticdatabase.teams.lig[4].name;
            }
            else if (staticdatabase.teams.macsayisi == 1)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[0].name;

                lblfiks3.Text = staticdatabase.teams.lig[1].name;
                lblfiks4.Text = staticdatabase.teams.lig[3].name;

                lblfiks5.Text = staticdatabase.teams.lig[7].name;
                lblfiks6.Text = staticdatabase.teams.lig[9].name;

                lblfiks7.Text = staticdatabase.teams.lig[10].name;
                lblfiks8.Text = staticdatabase.teams.lig[6].name;

                lblfiks9.Text = staticdatabase.teams.lig[8].name;
                lblfiks10.Text = staticdatabase.teams.lig[2].name;

                lblfiks11.Text = staticdatabase.teams.lig[5].name;
                lblfiks12.Text = staticdatabase.teams.lig[4].name;
            }
            else if (staticdatabase.teams.macsayisi == 2)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[1].name;

                lblfiks3.Text = staticdatabase.teams.lig[10].name;
                lblfiks4.Text = staticdatabase.teams.lig[5].name;

                lblfiks5.Text = staticdatabase.teams.lig[8].name;
                lblfiks6.Text = staticdatabase.teams.lig[9].name;

                lblfiks7.Text = staticdatabase.teams.lig[2].name;
                lblfiks8.Text = staticdatabase.teams.lig[0].name;

                lblfiks9.Text = staticdatabase.teams.lig[6].name;
                lblfiks10.Text = staticdatabase.teams.lig[3].name;

                lblfiks11.Text = staticdatabase.teams.lig[7].name;
                lblfiks12.Text = staticdatabase.teams.lig[4].name;
            }
            else if (staticdatabase.teams.macsayisi == 3)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[2].name;

                lblfiks3.Text = staticdatabase.teams.lig[5].name;
                lblfiks4.Text = staticdatabase.teams.lig[0].name;

                lblfiks5.Text = staticdatabase.teams.lig[9].name;
                lblfiks6.Text = staticdatabase.teams.lig[3].name;

                lblfiks7.Text = staticdatabase.teams.lig[10].name;
                lblfiks8.Text = staticdatabase.teams.lig[4].name;

                lblfiks9.Text = staticdatabase.teams.lig[8].name;
                lblfiks10.Text = staticdatabase.teams.lig[1].name;

                lblfiks11.Text = staticdatabase.teams.lig[7].name;
                lblfiks12.Text = staticdatabase.teams.lig[6].name;
            }
            else if (staticdatabase.teams.macsayisi == 4)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[3].name;

                lblfiks3.Text = staticdatabase.teams.lig[8].name;
                lblfiks4.Text = staticdatabase.teams.lig[5].name;

                lblfiks5.Text = staticdatabase.teams.lig[2].name;
                lblfiks6.Text = staticdatabase.teams.lig[10].name;

                lblfiks7.Text = staticdatabase.teams.lig[6].name;
                lblfiks8.Text = staticdatabase.teams.lig[9].name;

                lblfiks9.Text = staticdatabase.teams.lig[7].name;
                lblfiks10.Text = staticdatabase.teams.lig[0].name;

                lblfiks11.Text = staticdatabase.teams.lig[1].name;
                lblfiks12.Text = staticdatabase.teams.lig[4].name;
            }
            else if (staticdatabase.teams.macsayisi == 5)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[4].name;

                lblfiks3.Text = staticdatabase.teams.lig[5].name;
                lblfiks4.Text = staticdatabase.teams.lig[1].name;

                lblfiks5.Text = staticdatabase.teams.lig[3].name;
                lblfiks6.Text = staticdatabase.teams.lig[7].name;

                lblfiks7.Text = staticdatabase.teams.lig[0].name;
                lblfiks8.Text = staticdatabase.teams.lig[6].name;

                lblfiks9.Text = staticdatabase.teams.lig[9].name;
                lblfiks10.Text = staticdatabase.teams.lig[2].name;

                lblfiks11.Text = staticdatabase.teams.lig[10].name;
                lblfiks12.Text = staticdatabase.teams.lig[8].name;
            }
            else if (staticdatabase.teams.macsayisi == 6)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[5].name;

                lblfiks3.Text = staticdatabase.teams.lig[7].name;
                lblfiks4.Text = staticdatabase.teams.lig[1].name;

                lblfiks5.Text = staticdatabase.teams.lig[4].name;
                lblfiks6.Text = staticdatabase.teams.lig[6].name;

                lblfiks7.Text = staticdatabase.teams.lig[3].name;
                lblfiks8.Text = staticdatabase.teams.lig[2].name;

                lblfiks9.Text = staticdatabase.teams.lig[0].name;
                lblfiks10.Text = staticdatabase.teams.lig[8].name;

                lblfiks11.Text = staticdatabase.teams.lig[10].name;
                lblfiks12.Text = staticdatabase.teams.lig[9].name;
            }
            else if (staticdatabase.teams.macsayisi == 7)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[6].name;

                lblfiks3.Text = staticdatabase.teams.lig[7].name;
                lblfiks4.Text = staticdatabase.teams.lig[5].name;

                lblfiks5.Text = staticdatabase.teams.lig[1].name;
                lblfiks6.Text = staticdatabase.teams.lig[2].name;

                lblfiks7.Text = staticdatabase.teams.lig[4].name;
                lblfiks8.Text = staticdatabase.teams.lig[8].name;

                lblfiks9.Text = staticdatabase.teams.lig[3].name;
                lblfiks10.Text = staticdatabase.teams.lig[10].name;

                lblfiks11.Text = staticdatabase.teams.lig[0].name;
                lblfiks12.Text = staticdatabase.teams.lig[9].name;
            }
            else if (staticdatabase.teams.macsayisi == 8)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[7].name;

                lblfiks3.Text = staticdatabase.teams.lig[5].name;
                lblfiks4.Text = staticdatabase.teams.lig[9].name;

                lblfiks5.Text = staticdatabase.teams.lig[10].name;
                lblfiks6.Text = staticdatabase.teams.lig[0].name;

                lblfiks7.Text = staticdatabase.teams.lig[8].name;
                lblfiks8.Text = staticdatabase.teams.lig[3].name;

                lblfiks9.Text = staticdatabase.teams.lig[2].name;
                lblfiks10.Text = staticdatabase.teams.lig[4].name;

                lblfiks11.Text = staticdatabase.teams.lig[6].name;
                lblfiks12.Text = staticdatabase.teams.lig[1].name;
            }

            else if (staticdatabase.teams.macsayisi == 9)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[8].name;

                lblfiks3.Text = staticdatabase.teams.lig[6].name;
                lblfiks4.Text = staticdatabase.teams.lig[5].name;

                lblfiks5.Text = staticdatabase.teams.lig[7].name;
                lblfiks6.Text = staticdatabase.teams.lig[2].name;

                lblfiks7.Text = staticdatabase.teams.lig[1].name;
                lblfiks8.Text = staticdatabase.teams.lig[10].name;

                lblfiks9.Text = staticdatabase.teams.lig[4].name;
                lblfiks10.Text = staticdatabase.teams.lig[9].name;

                lblfiks11.Text = staticdatabase.teams.lig[3].name;
                lblfiks12.Text = staticdatabase.teams.lig[0].name;
            }
            else if (staticdatabase.teams.macsayisi == 10)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[9].name;

                lblfiks3.Text = staticdatabase.teams.lig[2].name;
                lblfiks4.Text = staticdatabase.teams.lig[5].name;

                lblfiks5.Text = staticdatabase.teams.lig[6].name;
                lblfiks6.Text = staticdatabase.teams.lig[8].name;

                lblfiks7.Text = staticdatabase.teams.lig[7].name;
                lblfiks8.Text = staticdatabase.teams.lig[10].name;

                lblfiks9.Text = staticdatabase.teams.lig[1].name;
                lblfiks10.Text = staticdatabase.teams.lig[0].name;

                lblfiks11.Text = staticdatabase.teams.lig[4].name;
                lblfiks12.Text = staticdatabase.teams.lig[3].name;
            }
            else if (staticdatabase.teams.macsayisi == 11)
            {
                lblfiks1.Text = staticdatabase.teams.secilentakim.name;
                lblfiks2.Text = staticdatabase.teams.lig[10].name;

                lblfiks3.Text = staticdatabase.teams.lig[5].name;
                lblfiks4.Text = staticdatabase.teams.lig[3].name;

                lblfiks5.Text = staticdatabase.teams.lig[0].name;
                lblfiks6.Text = staticdatabase.teams.lig[4].name;

                lblfiks7.Text = staticdatabase.teams.lig[9].name;
                lblfiks8.Text = staticdatabase.teams.lig[1].name;

                lblfiks9.Text = staticdatabase.teams.lig[8].name;
                lblfiks10.Text = staticdatabase.teams.lig[7].name;

                lblfiks11.Text = staticdatabase.teams.lig[2].name;
                lblfiks12.Text = staticdatabase.teams.lig[6].name;

            }


            fskor3.Text=staticdatabase.lists.fskor3;
            fskor4.Text = staticdatabase.lists.fskor4;
            fskor5.Text = staticdatabase.lists.fskor5;
            fskor6.Text = staticdatabase.lists.fskor6;
            fskor7.Text = staticdatabase.lists.fskor7;
            fskor8.Text = staticdatabase.lists.fskor8;
            fskor9.Text = staticdatabase.lists.fskor9;
            fskor10.Text = staticdatabase.lists.fskor10;
            fskor11.Text = staticdatabase.lists.fskor11;
            fskor12.Text = staticdatabase.lists.fskor12;


        }
        
        public void maclariyap()
        {



            if (staticdatabase.lists.macyapildimi==false)
            {
                if (staticdatabase.teams.macsayisi == 1)
                {
                    macsim(staticdatabase.teams.lig[1], staticdatabase.teams.lig[3]);
                    fskor3.Text = staticdatabase.teams.lig[1].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[3].skor.ToString();
                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[9]);
                    fskor5.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[9].skor.ToString();
                    macsim(staticdatabase.teams.lig[10], staticdatabase.teams.lig[6]);
                    fskor7.Text = staticdatabase.teams.lig[10].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[6].skor.ToString();
                    macsim(staticdatabase.teams.lig[8], staticdatabase.teams.lig[2]);
                    fskor9.Text = staticdatabase.teams.lig[8].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[2].skor.ToString();
                    macsim(staticdatabase.teams.lig[5], staticdatabase.teams.lig[4]);
                    fskor11.Text = staticdatabase.teams.lig[5].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[4].skor.ToString();
                }
                if (staticdatabase.teams.macsayisi == 2)
                {
                    macsim(staticdatabase.teams.lig[10], staticdatabase.teams.lig[5]);
                    fskor3.Text = staticdatabase.teams.lig[10].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[5].skor.ToString();

                    macsim(staticdatabase.teams.lig[8], staticdatabase.teams.lig[9]);
                    fskor5.Text = staticdatabase.teams.lig[8].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[9].skor.ToString();

                    macsim(staticdatabase.teams.lig[2], staticdatabase.teams.lig[0]);
                    fskor7.Text = staticdatabase.teams.lig[2].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[0].skor.ToString();

                    macsim(staticdatabase.teams.lig[6], staticdatabase.teams.lig[3]);
                    fskor9.Text = staticdatabase.teams.lig[6].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[3].skor.ToString();

                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[4]);
                    fskor11.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[4].skor.ToString();
                }
                if (staticdatabase.teams.macsayisi == 3)
                {
                    macsim(staticdatabase.teams.lig[5], staticdatabase.teams.lig[0]);
                    fskor3.Text = staticdatabase.teams.lig[5].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[0].skor.ToString();

                    macsim(staticdatabase.teams.lig[9], staticdatabase.teams.lig[3]);
                    fskor5.Text = staticdatabase.teams.lig[9].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[3].skor.ToString();

                    macsim(staticdatabase.teams.lig[10], staticdatabase.teams.lig[4]);
                    fskor7.Text = staticdatabase.teams.lig[10].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[4].skor.ToString();

                    macsim(staticdatabase.teams.lig[8], staticdatabase.teams.lig[1]);
                    fskor9.Text = staticdatabase.teams.lig[8].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[1].skor.ToString();

                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[6]);
                    fskor11.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[6].skor.ToString();

                }
                if (staticdatabase.teams.macsayisi == 4)
                {
                    macsim(staticdatabase.teams.lig[8], staticdatabase.teams.lig[5]);
                    fskor3.Text = staticdatabase.teams.lig[8].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[5].skor.ToString();

                    macsim(staticdatabase.teams.lig[2], staticdatabase.teams.lig[10]);
                    fskor5.Text = staticdatabase.teams.lig[2].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[10].skor.ToString();

                    macsim(staticdatabase.teams.lig[6], staticdatabase.teams.lig[9]);
                    fskor7.Text = staticdatabase.teams.lig[6].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[9].skor.ToString();

                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[0]);
                    fskor9.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[0].skor.ToString();

                    macsim(staticdatabase.teams.lig[1], staticdatabase.teams.lig[4]);
                    fskor11.Text = staticdatabase.teams.lig[1].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[4].skor.ToString();


                }
                if (staticdatabase.teams.macsayisi == 5)
                {
                    macsim(staticdatabase.teams.lig[5], staticdatabase.teams.lig[1]);
                    fskor3.Text = staticdatabase.teams.lig[5].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[1].skor.ToString();

                    macsim(staticdatabase.teams.lig[3], staticdatabase.teams.lig[7]);
                    fskor5.Text = staticdatabase.teams.lig[3].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[7].skor.ToString();

                    macsim(staticdatabase.teams.lig[0], staticdatabase.teams.lig[6]);
                    fskor7.Text = staticdatabase.teams.lig[0].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[6].skor.ToString();

                    macsim(staticdatabase.teams.lig[9], staticdatabase.teams.lig[2]);
                    fskor9.Text = staticdatabase.teams.lig[9].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[2].skor.ToString();

                    macsim(staticdatabase.teams.lig[10], staticdatabase.teams.lig[8]);
                    fskor11.Text = staticdatabase.teams.lig[10].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[8].skor.ToString();

                }
                if (staticdatabase.teams.macsayisi == 6)
                {

                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[1]);
                    fskor3.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[1].skor.ToString();

                    macsim(staticdatabase.teams.lig[4], staticdatabase.teams.lig[6]);
                    fskor5.Text = staticdatabase.teams.lig[4].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[6].skor.ToString();

                    macsim(staticdatabase.teams.lig[3], staticdatabase.teams.lig[2]);
                    fskor7.Text = staticdatabase.teams.lig[3].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[2].skor.ToString();

                    macsim(staticdatabase.teams.lig[0], staticdatabase.teams.lig[8]);
                    fskor9.Text = staticdatabase.teams.lig[0].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[8].skor.ToString();

                    macsim(staticdatabase.teams.lig[10], staticdatabase.teams.lig[9]);
                    fskor11.Text = staticdatabase.teams.lig[10].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[9].skor.ToString();


                }
                if (staticdatabase.teams.macsayisi == 7)
                {

                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[5]);
                    fskor3.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[5].skor.ToString();

                    macsim(staticdatabase.teams.lig[1], staticdatabase.teams.lig[2]);
                    fskor5.Text = staticdatabase.teams.lig[1].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[2].skor.ToString();

                    macsim(staticdatabase.teams.lig[4], staticdatabase.teams.lig[8]);
                    fskor7.Text = staticdatabase.teams.lig[4].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[8].skor.ToString();

                    macsim(staticdatabase.teams.lig[3], staticdatabase.teams.lig[10]);
                    fskor9.Text = staticdatabase.teams.lig[3].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[10].skor.ToString();

                    macsim(staticdatabase.teams.lig[0], staticdatabase.teams.lig[9]);
                    fskor11.Text = staticdatabase.teams.lig[0].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[9].skor.ToString();


                }
                if (staticdatabase.teams.macsayisi == 8)
                {

                    macsim(staticdatabase.teams.lig[5], staticdatabase.teams.lig[9]);
                    fskor3.Text = staticdatabase.teams.lig[5].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[9].skor.ToString();

                    macsim(staticdatabase.teams.lig[10], staticdatabase.teams.lig[0]);
                    fskor5.Text = staticdatabase.teams.lig[10].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[0].skor.ToString();

                    macsim(staticdatabase.teams.lig[8], staticdatabase.teams.lig[3]);
                    fskor7.Text = staticdatabase.teams.lig[8].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[3].skor.ToString();

                    macsim(staticdatabase.teams.lig[2], staticdatabase.teams.lig[4]);
                    fskor9.Text = staticdatabase.teams.lig[2].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[4].skor.ToString();

                    macsim(staticdatabase.teams.lig[6], staticdatabase.teams.lig[1]);
                    fskor11.Text = staticdatabase.teams.lig[6].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[1].skor.ToString();

                }

                if (staticdatabase.teams.macsayisi == 9)
                {

                    macsim(staticdatabase.teams.lig[6], staticdatabase.teams.lig[5]);
                    fskor3.Text = staticdatabase.teams.lig[6].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[5].skor.ToString();

                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[2]);
                    fskor5.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[2].skor.ToString();

                    macsim(staticdatabase.teams.lig[1], staticdatabase.teams.lig[10]);
                    fskor7.Text = staticdatabase.teams.lig[1].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[10].skor.ToString();

                    macsim(staticdatabase.teams.lig[4], staticdatabase.teams.lig[9]);
                    fskor9.Text = staticdatabase.teams.lig[4].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[9].skor.ToString();

                    macsim(staticdatabase.teams.lig[3], staticdatabase.teams.lig[0]);
                    fskor11.Text = staticdatabase.teams.lig[3].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[0].skor.ToString();
                }

                if (staticdatabase.teams.macsayisi == 10)
                {

                    macsim(staticdatabase.teams.lig[2], staticdatabase.teams.lig[5]);
                    fskor3.Text = staticdatabase.teams.lig[2].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[5].skor.ToString();

                    macsim(staticdatabase.teams.lig[6], staticdatabase.teams.lig[8]);
                    fskor5.Text = staticdatabase.teams.lig[6].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[8].skor.ToString();

                    macsim(staticdatabase.teams.lig[7], staticdatabase.teams.lig[10]);
                    fskor7.Text = staticdatabase.teams.lig[7].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[10].skor.ToString();

                    macsim(staticdatabase.teams.lig[1], staticdatabase.teams.lig[0]);
                    fskor9.Text = staticdatabase.teams.lig[1].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[0].skor.ToString();

                    macsim(staticdatabase.teams.lig[4], staticdatabase.teams.lig[3]);
                    fskor11.Text = staticdatabase.teams.lig[4].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[3].skor.ToString();
                }

                if (staticdatabase.teams.macsayisi == 11)
                {

                    macsim(staticdatabase.teams.lig[5], staticdatabase.teams.lig[3]);
                    fskor3.Text = staticdatabase.teams.lig[5].skor.ToString();
                    fskor4.Text = staticdatabase.teams.lig[3].skor.ToString();

                    macsim(staticdatabase.teams.lig[0], staticdatabase.teams.lig[4]);
                    fskor5.Text = staticdatabase.teams.lig[0].skor.ToString();
                    fskor6.Text = staticdatabase.teams.lig[4].skor.ToString();

                    macsim(staticdatabase.teams.lig[9], staticdatabase.teams.lig[1]);
                    fskor7.Text = staticdatabase.teams.lig[9].skor.ToString();
                    fskor8.Text = staticdatabase.teams.lig[1].skor.ToString();

                    macsim(staticdatabase.teams.lig[8], staticdatabase.teams.lig[7]);
                    fskor9.Text = staticdatabase.teams.lig[8].skor.ToString();
                    fskor10.Text = staticdatabase.teams.lig[7].skor.ToString();

                    macsim(staticdatabase.teams.lig[2], staticdatabase.teams.lig[6]);
                    fskor11.Text = staticdatabase.teams.lig[2].skor.ToString();
                    fskor12.Text = staticdatabase.teams.lig[6].skor.ToString();

                }

               
            }
            staticdatabase.lists.fskor3 = fskor3.Text;
            staticdatabase.lists.fskor4 = fskor4.Text;
            staticdatabase.lists.fskor5 = fskor5.Text;
            staticdatabase.lists.fskor6 = fskor6.Text;
            staticdatabase.lists.fskor7 = fskor7.Text;
            staticdatabase.lists.fskor8 = fskor8.Text;
            staticdatabase.lists.fskor9 = fskor9.Text;
            staticdatabase.lists.fskor10 = fskor10.Text;
            staticdatabase.lists.fskor11 = fskor11.Text;
            staticdatabase.lists.fskor12 = fskor12.Text;




        }




        public void statsdoldur()
        {
            lbl1.Text = staticdatabase.teams.secilentakim.pg1.name;
            lbl2.Text = staticdatabase.teams.secilentakim.sg1.name;
            lbl3.Text = staticdatabase.teams.secilentakim.sf1.name;
            lbl4.Text = staticdatabase.teams.secilentakim.pf1.name;
            lbl5.Text = staticdatabase.teams.secilentakim.c1.name;
            lbl6.Text = staticdatabase.teams.secilentakim.pg2.name;
            lbl7.Text = staticdatabase.teams.secilentakim.sg2.name;
            lbl8.Text = staticdatabase.teams.secilentakim.sf2.name;
            lbl9.Text = staticdatabase.teams.secilentakim.pf2.name;
            lbl10.Text = staticdatabase.teams.secilentakim.c2.name;
        }


        public void playoffyolu()
        {
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[0].Text == takim.ToString())
                    staticdatabase.teams.play1 = takim;
            }
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[1].Text == takim.ToString())
                    staticdatabase.teams.play2 = takim;
            }
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[2].Text == takim.ToString())
                    staticdatabase.teams.play3 = takim;
            }
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[3].Text == takim.ToString())
                    staticdatabase.teams.play4 = takim;
            }
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[4].Text == takim.ToString())
                    staticdatabase.teams.play5 = takim;
            }
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[5].Text == takim.ToString())
                    staticdatabase.teams.play6 = takim;
            }
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[6].Text == takim.ToString())
                    staticdatabase.teams.play7 = takim;
            }
            foreach (var takim in staticdatabase.teams.lig2)
            {
                if (lvstandings.Items[7].Text == takim.ToString())
                    staticdatabase.teams.play8 = takim;
            }
            staticdatabase.lists.lig = true;

            if(staticdatabase.teams.secilentakim.name!= staticdatabase.teams.play1.name && staticdatabase.teams.secilentakim.name != staticdatabase.teams.play2.name&& staticdatabase.teams.secilentakim.name != staticdatabase.teams.play3.name && staticdatabase.teams.secilentakim.name != staticdatabase.teams.play4.name && staticdatabase.teams.secilentakim.name != staticdatabase.teams.play5.name && staticdatabase.teams.secilentakim.name != staticdatabase.teams.play6.name && staticdatabase.teams.secilentakim.name != staticdatabase.teams.play7.name && staticdatabase.teams.secilentakim.name != staticdatabase.teams.play8.name)
            {
                devam = false;
                Form11 frm6 = new Form11();
                this.Hide();
                frm6.ShowDialog();
                this.Dispose();


            }

        }

       
        
        public void macsim(team takim1, team takim2)
        {
            double pg1sayi = (((takim1.pg1.ikilik + takim1.pg1.ucluk) ) - ((takim2.pg1.block + takim2.pg1.steal)));
            
            if(pg1sayi<10)
            {
                Random rand=new Random();
                pg1sayi=rand.Next(7,12);
            }
            if(pg1sayi>40)
            {
                Random rand = new Random();
                pg1sayi = rand.Next(20, 45);

            }


            double sg1sayi = (((takim1.sg1.ikilik + takim1.sg1.ucluk) ) - ((takim2.sg1.block + takim2.sg1.steal)));
            if (sg1sayi < 10)
            {
                Random rand = new Random();
                sg1sayi = rand.Next(7, 12);
            }
            if (sg1sayi > 40)
            {
                Random rand = new Random();
                sg1sayi = rand.Next(20, 45);

            }
            double sf1sayi = (((takim1.sf1.ikilik + takim1.sf1.ucluk) ) - ((takim2.sf1.block + takim2.sf1.steal)) );
            if (sf1sayi < 10)
            {
                Random rand = new Random();
                sf1sayi = rand.Next(7, 12);
            }
            if (sf1sayi > 40)
            {
                Random rand = new Random();
                sf1sayi = rand.Next(20, 45);

            }

            double pf1sayi = (((takim1.pf1.ikilik + takim1.pf1.ucluk) ) - ((takim2.pf1.block + takim2.pf1.steal)));
            if (pf1sayi < 10)
            {
                Random rand = new Random();
                pf1sayi = rand.Next(7, 12);
            }
            if (pf1sayi > 40)
            {
                Random rand = new Random();
                pf1sayi = rand.Next(20, 45);

            }


            double c1sayi = (((takim1.c1.ikilik + takim1.c1.ucluk) ) - ((takim2.c1.block + takim2.c1.steal)));
            if (c1sayi < 10)
            {
                Random rand = new Random();
                c1sayi = rand.Next(7, 12);
            }
            if (c1sayi > 40)
            {
                Random rand = new Random();
                c1sayi = rand.Next(20, 45);

            }

            takim1.pg1.tekpoint=Convert.ToInt32(pg1sayi);
            takim1.sg1.tekpoint = Convert.ToInt32(sg1sayi);
            takim1.sf1.tekpoint = Convert.ToInt32 (sf1sayi);
            takim1.pf1.tekpoint = Convert.ToInt32 (pf1sayi);
            takim1.c1.tekpoint= Convert.ToInt32 (c1sayi);
            Random rnd=new Random();
            takim1.pg2.tekpoint = rnd.Next(0, (takim1.pg1.tekpoint / 2));
            takim1.sg2.tekpoint = rnd.Next(0, (takim1.sg1.tekpoint / 2));
            takim1.sf2.tekpoint = rnd.Next(0, (takim1.sf1.tekpoint / 2));
            takim1.pf2.tekpoint = rnd.Next(0, (takim1.pf1.tekpoint / 2));
            takim1.c2.tekpoint = rnd.Next(0, (takim1.c1.tekpoint / 2));




            takim1.skor = takim1.pg1.tekpoint + takim1.sg1.tekpoint + takim1.sf1.tekpoint + takim1.pf1.tekpoint + takim1.c1.tekpoint + takim1.pg2.tekpoint + takim1.sg2.tekpoint + takim1.sf2.tekpoint + takim1.pf2.tekpoint + takim1.c2.tekpoint;

            if(takim1.skor>150)
            {
                takim1.pg1.tekpoint = takim1.pg1.tekpoint - (takim1.pg1.tekpoint / 2);
                takim1.sg1.tekpoint = takim1.sg1.tekpoint - (takim1.sg1.tekpoint / 2);
                takim1.sf1.tekpoint = takim1.sf1.tekpoint - (takim1.sf1.tekpoint / 2);
                takim1.pf1.tekpoint = takim1.pf1.tekpoint - (takim1.pf1.tekpoint / 2);
                takim1.c1.tekpoint = takim1.c1.tekpoint -   (takim1.c1.tekpoint / 2);
            }
            if(takim1.skor<70)
            {
                takim1.pg1.tekpoint = takim1.pg1.tekpoint+8;
                takim1.sg1.tekpoint = takim1.sg1.tekpoint+8;
                takim1.sf1.tekpoint = takim1.sf1.tekpoint+8;
                takim1.pf1.tekpoint = takim1.pf1.tekpoint+8;
                takim1.c1.tekpoint = takim1.c1.tekpoint + 8;
            }

            takim1.skor = takim1.pg1.tekpoint + takim1.sg1.tekpoint + takim1.sf1.tekpoint + takim1.pf1.tekpoint + takim1.c1.tekpoint + takim1.pg2.tekpoint + takim1.sg2.tekpoint + takim1.sf2.tekpoint + takim1.pf2.tekpoint + takim1.c2.tekpoint;



            double rpg1sayi = (((takim2.pg1.ikilik + takim2.pg1.ucluk) ) - ((takim1.pg1.block + takim1.pg1.steal)));
            if (rpg1sayi < 10)
            {
                Random rand = new Random();
                rpg1sayi = rand.Next(7, 12);
            }

            if (rpg1sayi > 40)
            {
                Random rand = new Random();
                rpg1sayi = rand.Next(20, 45);

            }

            double rsg1sayi = (((takim2.sg1.ikilik + takim2.sg1.ucluk)) - ((takim1.sg1.block + takim1.sg1.steal)));
            if (rsg1sayi < 10)
            {
                Random rand = new Random();
                rsg1sayi = rand.Next(7, 12);
            }
            if (rsg1sayi > 40)
            {
                Random rand = new Random();
                rsg1sayi = rand.Next(20, 45);
            }

           

            double rsf1sayi = (((takim2.sf1.ikilik + takim2.sf1.ucluk) ) - ((takim1.sf1.block + takim1.sf1.steal)));
            if (rsf1sayi < 10)
            {
                Random rand = new Random();
                rsf1sayi = rand.Next(7, 12);
            }
            if (rsf1sayi > 40)
            {
                Random rand = new Random();
                rsf1sayi = rand.Next(20, 45);

            }
            double rpf1sayi = (((takim2.pf1.ikilik + takim2.pf1.ucluk) ) - ((takim1.pf1.block + takim1.pf1.steal)));
            if (rpf1sayi < 10)
            {
                Random rand = new Random();
                rpf1sayi = rand.Next(7, 12);
            }
            if (rpf1sayi > 40)
            {
                Random rand = new Random();
                rpf1sayi = rand.Next(20, 45);

            }

            

            double rc1sayi = (((takim2.c1.ikilik + takim2.c1.ucluk) ) - ((takim1.c1.block + takim1.c1.steal)));

            if (rc1sayi < 10)
            {
                Random rand = new Random();
                rc1sayi = rand.Next(7, 12);
            }

            if (rc1sayi > 40)
            {
                Random rand = new Random();
                rc1sayi = rand.Next(20, 45);

            }

            takim2.pg1.tekpoint = Convert.ToInt32 (rpg1sayi);
            takim2.sg1.tekpoint = Convert.ToInt32(rsg1sayi);
            takim2.sf1.tekpoint = Convert.ToInt32(rsf1sayi);
            takim2.pf1.tekpoint = Convert.ToInt32( rpf1sayi);
            takim2.c1.tekpoint = Convert.ToInt32(rc1sayi);
            
            takim2.pg2.tekpoint = rnd.Next(0, (takim2.pg1.tekpoint / 2));
            takim2.sg2.tekpoint = rnd.Next(0, (takim2.sg1.tekpoint / 2));
            takim2.sf2.tekpoint = rnd.Next(0, (takim2.sf1.tekpoint / 2));
            takim2.pf2.tekpoint = rnd.Next(0, (takim2.pf1.tekpoint / 2));
            takim2.c2.tekpoint = rnd.Next(0, (takim2.c1.tekpoint / 2));


                 
            takim2.skor = takim2.pg1.tekpoint + takim2.sg1.tekpoint + takim2.sf1.tekpoint + takim2.pf1.tekpoint + takim2.c1.tekpoint + takim2.pg2.tekpoint + takim2.sg2.tekpoint + takim2.sf2.tekpoint + takim2.pf2.tekpoint + takim2.c2.tekpoint;

            if (takim2.skor > 150)
            {
                takim2.pg1.tekpoint = takim2.pg1.tekpoint - (takim2.pg1.tekpoint / 2); 
                takim2.sg1.tekpoint = takim2.sg1.tekpoint - (takim2.sg1.tekpoint / 2);
                takim2.sf1.tekpoint = takim2.sf1.tekpoint - (takim2.sf1.tekpoint / 2);
                takim2.pf1.tekpoint = takim2.pf1.tekpoint - (takim2.pf1.tekpoint / 2);
                takim2.c1.tekpoint = takim2.c1.tekpoint  -  (takim2.c1.tekpoint / 2);
            }
            if (takim2.skor < 70)
            {
                takim2.pg1.tekpoint = takim2.pg1.tekpoint+8;
                takim2.sg1.tekpoint = takim2.sg1.tekpoint+8;
                takim2.sf1.tekpoint = takim2.sf1.tekpoint+8;
                takim2.pf1.tekpoint = takim2.pf1.tekpoint+8;
                takim2.c1.tekpoint = takim2.c1.tekpoint + 8;
            }

            takim2.skor = takim2.pg1.tekpoint + takim2.sg1.tekpoint + takim2.sf1.tekpoint + takim2.pf1.tekpoint + takim2.c1.tekpoint + takim2.pg2.tekpoint + takim2.sg2.tekpoint + takim2.sf2.tekpoint + takim2.pf2.tekpoint + takim2.c2.tekpoint;



            if (takim1.skor > takim2.skor)
            {
                takim1.win++;
                takim2.lose++;
            }
            else if (takim1.skor < takim2.skor)
            {
                takim1.lose++;
                takim2.win++;
            }
            else
            {
                takim1.pg1.tekpoint++;
                takim1.skor++;
                takim1.win++;
                takim2.lose++;
            }


            takim2.pg1.tpoint = takim2.pg1.tpoint + takim2.pg1.tekpoint;
            takim2.sg1.tpoint = takim2.sg1.tpoint + takim2.sg1.tekpoint;
            takim2.sf1.tpoint = takim2.sf1.tpoint + takim2.sf1.tekpoint;
            takim2.pf1.tpoint = takim2.pf1.tpoint + takim2.pf1.tekpoint;
            takim2.c1.tpoint = takim2.c1.tpoint + takim2.c1.tekpoint;
            takim2.pg2.tpoint = takim2.pg2.tpoint + takim2.pg2.tekpoint;
            takim2.sg2.tpoint = takim2.sg2.tpoint + takim2.sg2.tekpoint;
            takim2.sf2.tpoint = takim2.sf2.tpoint + takim2.sf2.tekpoint;
            takim2.pf2.tpoint = takim2.pf2.tpoint + takim2.pf2.tekpoint;
            takim2.c2.tpoint = takim2.c2.tpoint + takim2.c2.tekpoint;

            takim1.pg1.tpoint = takim1.pg1.tpoint + takim1.pg1.tekpoint;
            takim1.sg1.tpoint = takim1.sg1.tpoint + takim1.sg1.tekpoint;
            takim1.sf1.tpoint = takim1.sf1.tpoint + takim1.sf1.tekpoint;
            takim1.pf1.tpoint = takim1.pf1.tpoint + takim1.pf1.tekpoint;
            takim1.c1.tpoint = takim1.c1.tpoint + takim1.c1.tekpoint;
            takim1.pg2.tpoint = takim1.pg2.tpoint + takim1.pg2.tekpoint;
            takim1.sg2.tpoint = takim1.sg2.tpoint + takim1.sg2.tekpoint;
            takim1.sf2.tpoint = takim1.sf2.tpoint + takim1.sf2.tekpoint;
            takim1.pf2.tpoint = takim1.pf2.tpoint + takim1.pf2.tekpoint;
            takim1.c2.tpoint = takim1.c2.tpoint + takim1.c2.tekpoint;

            //asist
            Random r = new Random();
            takim1.pg1.tekasist = r.Next((takim1.pg1.asist / 10) - 2, (takim1.pg1.asist / 10) + 4);
            if (takim1.pg1.tekasist <= 0)
                takim1.pg1.tekasist = 0;
            takim1.sg1.tekasist = r.Next((takim1.sg1.asist / 10) - 3, (takim1.sg1.asist / 10) + 4);
            if (takim1.sg1.tekasist <= 0)
                takim1.sg1.tekasist = 0;
            takim1.sf1.tekasist = r.Next((takim1.sf1.asist / 10) - 3, (takim1.sf1.asist / 10) + 3);
            if (takim1.sf1.tekasist <= 0)
                takim1.sf1.tekasist = 0;
            takim1.pf1.tekasist = r.Next((takim1.pf1.asist / 10) - 3, (takim1.pf1.asist / 10) + 2);
            if (takim1.pf1.tekasist <= 0)
                takim1.pf1.tekasist = 0;
            takim1.c1.tekasist = r.Next((takim1.c1.asist / 10) - 3, (takim1.c1.asist / 10) + 1);
            if (takim1.c1.tekasist <= 0)
                takim1.c1.tekasist = 0;
            takim1.pg2.tekasist = r.Next((takim1.pg2.asist / 10) - 3, (takim1.pg2.asist / 10) );
            if (takim1.pg2.tekasist <= 0)
                takim1.pg2.tekasist = 0;
            takim1.sg2.tekasist = r.Next((takim1.sg2.asist / 10) - 3, (takim1.sg2.asist / 10) );
            if (takim1.sg2.tekasist <= 0)
                takim1.sg2.tekasist = 0;
            takim1.sf2.tekasist = r.Next((takim1.sf2.asist / 10) - 3, (takim1.sf2.asist / 10) );
            if (takim1.sf2.tekasist <= 0)
                takim1.sf2.tekasist = 0;
            takim1.pf2.tekasist = r.Next((takim1.pf2.asist / 10) - 3, (takim1.pf2.asist / 10) );
            if (takim1.pf2.tekasist <= 0)
                takim1.pf2.tekasist = 0;
            takim1.c2.tekasist = r.Next((takim1.c2.asist / 10) - 3, (takim1.c2.asist / 10) );
            if (takim1.c2.tekasist <= 0)
                takim1.c2.tekasist = 0;

            takim2.pg1.tekasist = r.Next((takim2.pg1.asist / 10) - 3, (takim2.pg1.asist / 10) + 4);
            if (takim2.pg1.tekasist <= 0)
                takim2.pg1.tekasist = 0;
            takim2.sg1.tekasist = r.Next((takim2.sg1.asist / 10) - 3, (takim2.sg1.asist / 10) + 4);
            if (takim2.sg1.tekasist <= 0)
                takim2.sg1.tekasist = 0;
            takim2.sf1.tekasist = r.Next((takim2.sf1.asist / 10) - 3, (takim2.sf1.asist / 10) + 3);
            if (takim2.sf1.tekasist <= 0)
                takim2.sf1.tekasist = 0;
            takim2.pf1.tekasist = r.Next((takim2.pf1.asist / 10) - 3, (takim2.pf1.asist / 10) + 2);
            if (takim2.pf1.tekasist <= 0)
                takim2.pf1.tekasist = 0;
            takim2.c1.tekasist = r.Next((takim2.c1.asist / 10) - 3, (takim2.c1.asist / 10) + 1);
            if (takim2.c1.tekasist <= 0)
                takim2.c1.tekasist = 0;
            takim2.pg2.tekasist = r.Next((takim2.pg2.asist / 10) - 3, (takim2.pg2.asist / 10) );
            if (takim2.pg2.tekasist <= 0)
                takim2.pg2.tekasist = 0;
            takim2.sg2.tekasist = r.Next((takim2.sg2.asist / 10) - 3, (takim2.sg2.asist / 10) );
            if (takim2.sg2.tekasist <= 0)
                takim2.sg2.tekasist = 0;
            takim2.sf2.tekasist = r.Next((takim2.sf2.asist / 10) - 3, (takim2.sf2.asist / 10) );
            if (takim2.sf2.tekasist <= 0)
                takim2.sf2.tekasist = 0;
            takim2.pf2.tekasist = r.Next((takim2.pf2.asist / 10) - 3, (takim2.pf2.asist / 10) );
            if (takim2.pf2.tekasist <= 0)
                takim2.pf2.tekasist = 0;
            takim2.c2.tekasist = r.Next((takim2.c2.asist / 10) - 3, (takim2.c2.asist / 10) );
            if (takim2.c2.tekasist <= 0)
                takim2.c2.tekasist = 0;



            //rebound

            takim1.pg1.tekrebound = r.Next((takim1.pg1.rebound / 10) - 3, (takim1.pg1.rebound / 10));
            if (takim1.pg1.tekrebound <= 0)
                takim1.pg1.tekrebound = 0;
            takim1.sg1.tekrebound = r.Next((takim1.sg1.rebound / 10) - 3, (takim1.sg1.rebound / 10) );
            if (takim1.sg1.tekrebound <= 0)
                takim1.sg1.tekrebound = 0;
            takim1.sf1.tekrebound = r.Next((takim1.sf1.rebound / 10) - 3, (takim1.sf1.rebound / 10) + 1);
            if (takim1.sf1.tekrebound <= 0)
                takim1.sf1.tekrebound = 0;
            takim1.pf1.tekrebound = r.Next((takim1.pf1.rebound / 10) - 3, (takim1.pf1.rebound / 10) + 3);
            if (takim1.pf1.tekrebound <= 0)
                takim1.pf1.tekrebound = 0;
            takim1.c1.tekrebound = r.Next((takim1.c1.rebound / 10) - 3, (takim1.c1.rebound / 10) + 5);
            if (takim1.c1.tekrebound <= 0)
                takim1.c1.tekrebound = 0;
            takim1.pg2.tekrebound = r.Next((takim1.pg2.rebound / 10) - 3, (takim1.pg2.rebound / 10));
            if (takim1.pg2.tekrebound <= 0)
                takim1.pg2.tekrebound = 0;
            takim1.sg2.tekrebound = r.Next((takim1.sg2.rebound / 10) - 3, (takim1.sg2.rebound / 10));
            if (takim1.sg2.tekrebound <= 0)
                takim1.sg2.tekrebound = 0;
            takim1.sf2.tekrebound = r.Next((takim1.sf2.rebound / 10) - 3, (takim1.sf2.rebound / 10));
            if (takim1.sf2.tekrebound <= 0)
                takim1.sf2.tekrebound = 0;
            takim1.pf2.tekrebound = r.Next((takim1.pf2.rebound / 10) - 3, (takim1.pf2.rebound / 10));
            if (takim1.pf2.tekrebound <= 0)
                takim1.pf2.tekrebound = 0;
            takim1.c2.tekrebound = r.Next((takim1.c2.rebound / 10) - 3, (takim1.c2.rebound / 10)+1);
            if (takim1.c2.tekrebound <= 0)
                takim1.c2.tekrebound = 0;

            takim2.pg1.tekrebound = r.Next((takim2.pg1.rebound / 10) - 3, (takim2.pg1.rebound / 10));
            if (takim2.pg1.tekrebound <= 0)
                takim2.pg1.tekrebound = 0;
            takim2.sg1.tekrebound = r.Next((takim2.sg1.rebound / 10) - 3, (takim2.sg1.rebound / 10));
            if (takim2.sg1.tekrebound <= 0)
                takim2.sg1.tekrebound = 0;
            takim2.sf1.tekrebound = r.Next((takim2.sf1.rebound / 10) - 3, (takim2.sf1.rebound / 10) + 1);
            if (takim2.sf1.tekrebound <= 0)
                takim2.sf1.tekrebound = 0;
            takim2.pf1.tekrebound = r.Next((takim2.pf1.rebound / 10) - 3, (takim2.pf1.rebound / 10) + 3);
            if (takim2.pf1.tekrebound <= 0)
                takim2.pf1.tekrebound = 0;
            takim2.c1.tekrebound = r.Next((takim2.c1.rebound / 10) - 3, (takim2.c1.rebound / 10) + 5);
            if (takim2.c1.tekrebound <= 0)
                takim2.c1.tekrebound = 0;
            takim2.pg2.tekrebound = r.Next((takim2.pg2.rebound / 10) - 3, (takim2.pg2.rebound / 10));
            if (takim2.pg2.tekrebound <= 0)
                takim2.pg2.tekrebound = 0;
            takim2.sg2.tekrebound = r.Next((takim2.sg2.rebound / 10) - 3, (takim2.sg2.rebound / 10));
            if (takim2.sg2.tekrebound <= 0)
                takim2.sg2.tekrebound = 0;
            takim2.sf2.tekrebound = r.Next((takim2.sf2.rebound / 10) - 3, (takim2.sf2.rebound / 10));
            if (takim2.sf2.tekrebound <= 0)
                takim2.sf2.tekrebound = 0;
            takim2.pf2.tekrebound = r.Next((takim2.pf2.rebound / 10) - 3, (takim2.pf2.rebound / 10));
            if (takim2.pf2.tekrebound <= 0)
                takim2.pf2.tekrebound = 0;
            takim2.c2.tekrebound = r.Next((takim2.c2.asist / 10) - 3, (takim2.c2.asist / 10)+1);
            if (takim2.c2.tekrebound <= 0)
                takim2.c2.tekrebound = 0;


            //block

            takim1.pg1.tekblock = r.Next((takim1.pg1.block / 20) - 5, (takim1.pg1.block / 20));
            if (takim1.pg1.tekblock <= 0)
                takim1.pg1.tekblock = 0;
            takim1.sg1.tekblock = r.Next((takim1.sg1.block / 20) - 5, (takim1.sg1.block / 20));
            if (takim1.sg1.tekblock <= 0)
                takim1.sg1.tekblock = 0;
            takim1.sf1.tekblock = r.Next((takim1.sf1.block / 20) - 5, (takim1.sf1.block / 20) );
            if (takim1.sf1.tekblock <= 0)
                takim1.sf1.tekblock = 0;
            takim1.pf1.tekblock = r.Next((takim1.pf1.block / 20) - 5, (takim1.pf1.block / 20) );
            if (takim1.pf1.tekblock <= 0)
                takim1.pf1.tekblock = 0;
            takim1.c1.tekblock = r.Next((takim1.c1.block / 20) - 5, (takim1.c1.block / 20) );
            if (takim1.c1.tekblock <= 0)
                takim1.c1.tekblock = 0;
            takim1.pg2.tekblock = r.Next((takim1.pg2.block / 40) - 5, (takim1.pg2.block / 40));
            if (takim1.pg2.tekblock <= 0)
                takim1.pg2.tekblock = 0;
            takim1.sg2.tekblock = r.Next((takim1.sg2.block / 40) - 5, (takim1.sg2.block / 40));
            if (takim1.sg2.tekblock <= 0)
                takim1.sg2.tekblock = 0;
            takim1.sf2.tekblock = r.Next((takim1.sf2.block / 40) - 5, (takim1.sf2.block / 40));
            if (takim1.sf2.tekblock <= 0)
                takim1.sf2.tekblock = 0;
            takim1.pf2.tekblock = r.Next((takim1.pf2.block / 40) - 5, (takim1.pf2.block / 40));
            if (takim1.pf2.tekblock <= 0)
                takim1.pf2.tekblock = 0;
            takim1.c2.tekblock = r.Next((takim1.c2.block / 40) - 5, (takim1.c2.block / 40) );
            if (takim1.c2.tekblock <= 0)
                takim1.c2.tekblock = 0;


            takim2.pg1.tekblock = r.Next((takim2.pg1.rebound / 20) - 5, (takim2.pg1.rebound / 20));
            if (takim2.pg1.tekblock <= 0)
                takim2.pg1.tekblock = 0;
            takim2.sg1.tekblock = r.Next((takim2.sg1.rebound / 20) - 5, (takim2.sg1.rebound / 20));
            if (takim2.sg1.tekblock <= 0)
                takim2.sg1.tekblock = 0;
            takim2.sf1.tekblock = r.Next((takim2.sf1.rebound / 20) - 5, (takim2.sf1.rebound / 20) );
            if (takim2.sf1.tekblock <= 0)
                takim2.sf1.tekblock = 0;
            takim2.pf1.tekblock = r.Next((takim2.pf1.rebound / 20) - 5, (takim2.pf1.rebound / 20) );
            if (takim2.pf1.tekblock <= 0)
                takim2.pf1.tekblock = 0;
            takim2.c1.tekblock = r.Next((takim2.c1.rebound / 20) - 5, (takim2.c1.rebound / 20) );
            if (takim2.c1.tekblock <= 0)
                takim2.c1.tekblock = 0;
            takim2.pg2.tekblock = r.Next((takim2.pg2.rebound / 40)-5 , (takim2.pg2.rebound / 40));
            if (takim2.pg2.tekblock <= 0)
                takim2.pg2.tekblock = 0;
            takim2.sg2.tekblock = r.Next((takim2.sg2.rebound / 40)-5 , (takim2.sg2.rebound / 40));
            if (takim2.sg2.tekblock <= 0)
                takim2.sg2.tekblock = 0;
            takim2.sf2.tekblock = r.Next((takim2.sf2.rebound / 40)-5 , (takim2.sf2.rebound / 40));
            if (takim2.sf2.tekblock <= 0)
                takim2.sf2.tekblock = 0;
            takim2.pf2.tekblock = r.Next((takim2.pf2.rebound / 40)-5 , (takim2.pf2.rebound / 40));
            if (takim2.pf2.tekblock <= 0)
                takim2.pf2.tekblock = 0;
            takim2.c2.tekblock = r.Next((takim2.c2.asist / 40)-5 , (takim2.c2.asist / 40) );
            if (takim2.c2.tekblock <= 0)
                takim2.c2.tekblock = 0;

            //steal

            takim2.pg1.teksteal = r.Next((takim2.pg1.steal / 17) - 5, (takim2.pg1.steal / 17));
            if (takim2.pg1.teksteal <= 0)
                takim2.pg1.teksteal = 0;
            takim2.sg1.teksteal = r.Next((takim2.sg1.steal / 17) - 5, (takim2.sg1.steal / 17));
            if (takim2.sg1.teksteal <= 0)
                takim2.sg1.teksteal = 0;
            takim2.sf1.teksteal = r.Next((takim2.sf1.steal / 17) - 5, (takim2.sf1.steal / 17));
            if (takim2.sf1.teksteal <= 0)
                takim2.sf1.teksteal = 0;
            takim2.pf1.teksteal = r.Next((takim2.pf1.steal / 17) - 5, (takim2.pf1.steal / 17) );
            if (takim2.pf1.teksteal <= 0)
                takim2.pf1.teksteal = 0;
            takim2.c1.teksteal = r.Next((takim2.c1.steal / 17) - 5, (takim2.c1.steal / 17) );
            if (takim2.c1.teksteal <= 0)
                takim2.c1.teksteal = 0;
            takim2.pg2.teksteal = r.Next((takim2.pg2.steal / 17) - 8, (takim2.pg2.steal / 17));
            if (takim2.pg2.teksteal <= 0)
                takim2.pg2.teksteal = 0;
            takim2.sg2.teksteal = r.Next((takim2.sg2.steal / 17) - 8, (takim2.sg2.steal / 17));
            if (takim2.sg2.teksteal <= 0)
                takim2.sg2.teksteal = 0;
            takim2.sf2.teksteal = r.Next((takim2.sf2.steal / 17) - 8, (takim2.sf2.steal / 17));
            if (takim2.sf2.teksteal <= 0)
                takim2.sf2.teksteal = 0;
            takim2.pf2.teksteal = r.Next((takim2.pf2.steal / 17) - 8, (takim2.pf2.steal / 17));
            if (takim2.pf2.teksteal <= 0)
                takim2.pf2.teksteal = 0;
            takim2.c2.teksteal = r.Next((takim2.c2.steal / 17) - 8, (takim2.c2.steal / 17));
            if (takim2.c2.teksteal <= 0)
                takim2.c2.teksteal = 0;

            takim1.pg1.teksteal = r.Next((takim1.pg1.steal / 17) - 5, (takim1.pg1.steal / 17));
            if (takim1.pg1.teksteal <= 0)
                takim1.pg1.teksteal = 0;
            takim1.sg1.teksteal = r.Next((takim1.sg1.steal / 17) - 5, (takim1.sg1.steal / 17));
            if (takim1.sg1.teksteal <= 0)
                takim1.sg1.teksteal = 0;
            takim1.sf1.teksteal = r.Next((takim1.sf1.steal / 17) - 5, (takim1.sf1.steal / 17));
            if (takim1.sf1.teksteal <= 0)
                takim1.sf1.teksteal = 0;
            takim1.pf1.teksteal = r.Next((takim1.pf1.steal / 17) - 5, (takim1.pf1.steal / 17));
            if (takim1.pf1.teksteal <= 0)
                takim1.pf1.teksteal = 0;
            takim1.c1.teksteal = r.Next((takim1.c1.steal / 17) - 5, (takim1.c1.steal / 17));
            if (takim1.c1.teksteal <= 0)
                takim1.c1.teksteal = 0;
            takim1.pg2.teksteal = r.Next((takim1.pg2.steal / 17) - 8, (takim1.pg2.steal / 17));
            if (takim1.pg2.teksteal <= 0)
                takim1.pg2.teksteal = 0;
            takim1.sg2.teksteal = r.Next((takim1.sg2.steal / 17) - 8, (takim1.sg2.steal / 17));
            if (takim1.sg2.teksteal <= 0)
                takim1.sg2.teksteal = 0;
            takim1.sf2.teksteal = r.Next((takim1.sf2.steal / 17) - 8, (takim1.sf2.steal / 17));
            if (takim1.sf2.teksteal <= 0)
                takim1.sf2.teksteal = 0;
            takim1.pf2.teksteal = r.Next((takim1.pf2.steal / 17) - 8, (takim1.pf2.steal / 17));
            if (takim1.pf2.teksteal <= 0)
                takim1.pf2.teksteal = 0;
            takim1.c2.teksteal = r.Next((takim1.c2.steal / 17) - 8, (takim1.c2.steal / 17));
            if (takim1.c2.teksteal <= 0)
                takim1.c2.teksteal = 0;


        }

        public void btnpickgizle()
        {
            btnpick1.Visible = false;
            btnpick2.Visible = false;
            btnpick3.Visible = false;
            btnpick4.Visible = false;
        }
        public void btnpickgoster()
        {
            btnpick1.Visible = true;
            btnpick2.Visible = true;
            btnpick3.Visible = true;
            btnpick4.Visible = true;
        }
        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void lblbudget_Click(object sender, EventArgs e)
        {

        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            btnnormal.Image = Resources.N2;
            secilitaktik = staticdatabase.lists.normal;
            taktikbilgisi();
            btnpickgoster();
        }

        public void buttonnormallestir()
        {
            btnnormal.Image = Resources.N;
            btniso.Image = Resources.ISO;
            btnpickroll.Image = Resources.PR;
            btnpost.Image = Resources.POST;
            btnpace.Image = Resources.PC;
            btnslow.Image = Resources.SLOW;
            pictureBox6.Image = Resources.ucluk1;
            pbikilik.Image= Resources.iki;
            pbpickandroll.Image = Resources.pickandroll;
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

        private void gpsquad_Enter_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pbsaha_Click(object sender, EventArgs e)
        {

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

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            pictureBox6.Image = Resources.ucluk2;
            secilitaktik = staticdatabase.lists.three;
            taktikbilgisi();
            btnpickgoster();
        }
        private void pbikilik_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            pbikilik.Image = Resources.iki2;
            secilitaktik = staticdatabase.lists.two;
            taktikbilgisi();
            btnpickgoster();

        }
        private void pbpickandroll_Click(object sender, EventArgs e)
        {
            buttonnormallestir();
            pbpickandroll.Image = Resources.pickandroll2;
            secilitaktik = staticdatabase.lists.pickandroll2;
            taktikbilgisi();
            btnpickgoster();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
       


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Form3 frm = new Form3();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }
        private void aktifbutonsakla()
        {
            btnnew.Visible = false;
            btnexit.Visible = false;
            btntransfer.Visible = false;
            btnnextmatch.Visible = false;
        }
        private void aktifbutongoster()
        {
            btnnew.Visible = true;
            btnexit.Visible = true;
            if(staticdatabase.teams.macsayisi != 0)
            {
                btntransfer.Visible = true;
            }
            btnnextmatch.Visible = true;
        }
        private void macsonucgizle()
        {
            lblfiks1.Visible = false;
            lblfiks2.Visible = false;
            lblfiks3.Visible = false;
            lblfiks4.Visible = false;
            lblfiks5.Visible = false;
            lblfiks6.Visible = false;
            lblfiks7.Visible = false;
            lblfiks8.Visible = false;
            lblfiks9.Visible = false;
            lblfiks10.Visible = false;
            lblfiks11.Visible = false;
            lblfiks12.Visible = false;
            skor1.Visible = false;
            skor2.Visible = false;
            fskor3.Visible = false;
            fskor4.Visible = false;
            fskor5.Visible = false;
            fskor6.Visible = false;
            fskor7.Visible = false;
            fskor8.Visible = false;
            fskor9.Visible = false;
            fskor10.Visible = false;
            fskor11.Visible = false;
            fskor12.Visible = false;
            lblsaveinfo.Visible = true;
            lblsaveinfo2.Visible = true;

        }
        private void macsonucgoster()
        {
            lblfiks1.Visible = true;
            lblfiks2.Visible = true;
            lblfiks3.Visible = true;
            lblfiks4.Visible = true;
            lblfiks5.Visible = true;
            lblfiks6.Visible = true;
            lblfiks7.Visible = true;
            lblfiks8.Visible = true;
            lblfiks9.Visible = true;
            lblfiks10.Visible = true;
            lblfiks11.Visible = true;
            lblfiks12.Visible = true;
            skor1.Visible = true;
            skor2.Visible = true;
            fskor3.Visible = true;
            fskor4.Visible = true;
            fskor5.Visible = true;
            fskor6.Visible = true;
            fskor7.Visible = true;
            fskor8.Visible = true;
            fskor9.Visible = true;
            fskor10.Visible = true;
            fskor11.Visible = true;
            fskor12.Visible = true;
            lblsaveinfo.Visible = false;
            lblsaveinfo2.Visible = false;

        }


        private void btnnew_Click(object sender, EventArgs e)
        {
            staticdatabase.lists.arkafon.Stop();
            staticdatabase.lists.arkafon.Dispose();
            sound.Stop();
            sound.Dispose();
            macsonucgizle();
            aktifbutonsakla();
            if (staticdatabase.lists.saveok <2)
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
            else if(staticdatabase.lists.saveok == 2)
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

            lblsaveinfo.Text = "TIP:The players on the transfer screen are renewed every week, check every week to find a player that works for you.";

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
            lblsaveinfo.Text = "TIP:You never know when and where problems will arise, try to save your game often";

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
            lblsaveinfo.Text = "TIP:Don't like your squad?Every time you play in the NFBL,all squads are built from scratch.";

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
            lblsaveinfo.Text = "TIP:Center performance of a PG player is AWFUL but acceptable if you play him as SG.";

            timer9.Start();
            timer8.Stop();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            staticdatabase.lists.SaveStateForm7();

            staticdatabase.lists.SaveStateForm8();
            btnnew.Text = "SAVED";


            sarkisecimi();
            aktifbutongoster();
            macsonucgoster();

            timer9.Stop();
        }

        private void pbcoming2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            
        }
    }

      
    
}
