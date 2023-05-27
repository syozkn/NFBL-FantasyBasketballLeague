using Bigbang.classes;
using Bigbang.Properties;
using Bigbang.staticdatabase;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Bigbang
{
    public partial class red1 : Form
    {
        public red1()
        {
            InitializeComponent();
        }

        oyuncu asoyuncu = new oyuncu();
        oyuncu yedekoyuncu = new oyuncu();
        public void secilenoyuncuas(oyuncu oyuncu)
        {
            lblp13pts.Text = Convert.ToString(oyuncu.ucluk);
            lblp12pts.Text = Convert.ToString(oyuncu.ikilik);
            lbl1ast.Text = Convert.ToString(oyuncu.asist);
            lbl1blk.Text = Convert.ToString(oyuncu.block);
            lbl1reb.Text = Convert.ToString(oyuncu.rebound);
            lbl1stl.Text = Convert.ToString(oyuncu.steal);
            pbsecilen1.Image = oyuncu.foto;
            lblplayer1name.Text = oyuncu.name;
            lblplayer1pos.Text = Convert.ToString(oyuncu.pozisyon);
            lbluclukgiren.Text = Convert.ToString(oyuncu.Sgirenucluk);
            lblucluktoplam.Text = Convert.ToString(oyuncu.Stoplamucluk);
            lblikilikgiren.Text = Convert.ToString(oyuncu.Sgirenikilik);
            lblikiliktoplam.Text=Convert.ToString(oyuncu.Stoplamikilik);
            asoyuncu = oyuncu;





        }

        public void secilenoyuncuyedek(oyuncu oyuncu)
        {
            lbl23pts.Text = Convert.ToString(oyuncu.ucluk);
            lbl22pts.Text = Convert.ToString(oyuncu.ikilik);
            lbl2ast.Text = Convert.ToString(oyuncu.asist);
            lbl2blk.Text = Convert.ToString(oyuncu.block);
            lbl2reb.Text = Convert.ToString(oyuncu.rebound);
            lbl2stl.Text = Convert.ToString(oyuncu.steal);
            pbsecilen2.Image = oyuncu.foto;
            lblplayer2name.Text = oyuncu.name;
            lblplayer2pos.Text = Convert.ToString(oyuncu.pozisyon);
            lblyedekuclukgiren.Text = Convert.ToString(oyuncu.Sgirenucluk);
            lblyedektoplamucluk.Text = Convert.ToString(oyuncu.Stoplamucluk);
            lblyedekikilikgiren.Text = Convert.ToString(oyuncu.Sgirenikilik);
            lblyedektoplamikilik.Text = Convert.ToString(oyuncu.Stoplamikilik);
            yedekoyuncu = oyuncu;
        }

        private void pbteam2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }
        public team team1 = new team();
        public team team2 = new team();
        
        private void Form4_Load(object sender, EventArgs e)
        {
            SoundPlayer ses= new SoundPlayer(Resources.arenamac);
            ses.Stop();
            gptactic2.Visible = false;
            takimyarat();
            oyunculariata();

            oyuncuresimleri();
            yedekpozisyonlari();
            statssifirla();
            oyuncustatsyenile();
            staticdatabase.lists.macyapildimi = false;
            taktikleriyerlestir();
            isoplayer = akadro[0];
            pbtaktiknormal.Image = team1.standart.resim2;
            mantomanayarlari();
            normaltaktikayarlari();


        }

    




        List<oyuncu> akadro = new List<oyuncu>();
        List<oyuncu> ykadro = new List<oyuncu>();
        List<oyuncu> rakadro = new List<oyuncu>();
        
        oyuncu oyuncu1 = new oyuncu();
        oyuncu oyuncu2 = new oyuncu();
        oyuncu oyuncu3 = new oyuncu();
        oyuncu oyuncu4 = new oyuncu();
        oyuncu oyuncu5 = new oyuncu();
        oyuncu oyuncu6 = new oyuncu();
        oyuncu oyuncu7 = new oyuncu();
        oyuncu oyuncu8 = new oyuncu();
        oyuncu oyuncu9 = new oyuncu();
        oyuncu oyuncu10 = new oyuncu();
        oyuncu oyuncu11 = new oyuncu();
        oyuncu oyuncu12 = new oyuncu();
        oyuncu oyuncu13 = new oyuncu();
        oyuncu oyuncu14 = new oyuncu();
        oyuncu oyuncu15 = new oyuncu();
        oyuncu oyuncu16 = new oyuncu();
        oyuncu oyuncu17 = new oyuncu();
        oyuncu oyuncu18 = new oyuncu();
        oyuncu oyuncu19 = new oyuncu();
        oyuncu oyuncu20 = new oyuncu();
        oyuncu gecicias = new oyuncu();
        oyuncu geciciyedek = new oyuncu();

        public void oyunculariata()
        {

            akadro.Add(team1.pg1);
            akadro.Add(team1.sg1);
            akadro.Add(team1.sf1);
            akadro.Add(team1.pf1);
            akadro.Add(team1.c1);
            ykadro.Add(team1.pg2);
            ykadro.Add(team1.sg2);
            ykadro.Add(team1.sf2);
            ykadro.Add(team1.pf2);
            ykadro.Add(team1.c2);
            rakadro.Add (team2.pg1);
            rakadro.Add (team2.sg1);
            rakadro.Add (team2.sf1);
            rakadro.Add (team2.pf1);
            rakadro.Add(team2.c1);
            rakadro.Add(team2.pg2);
            rakadro.Add(team2.sg2);
            rakadro.Add(team2.sf2);
            rakadro.Add(team2.pf2);
            rakadro.Add(team2.c2);
            rakadro[0].Asyedek = "AS";
            rakadro[1].Asyedek = "AS";
            rakadro[2].Asyedek = "AS";
            rakadro[3].Asyedek = "AS";
            rakadro[4].Asyedek = "AS";
            rakadro[5].Asyedek = "YEDEK";
            rakadro[6].Asyedek = "YEDEK";
            rakadro[7].Asyedek = "YEDEK";
            rakadro[8].Asyedek = "YEDEK";
            rakadro[9].Asyedek = "YEDEK";


        }
        public void oyuncuresimleri()
        {
            pbplayer1.Image = akadro[0].foto;
            pbplayer2.Image = akadro[1].foto;
            pbplayer3.Image = akadro[2].foto;
            pbplayer4.Image = akadro[3].foto;
            pbplayer5.Image = akadro[4].foto;
            pbplayer6.Image = ykadro[0].foto;
            pbplayer7.Image = ykadro[1].foto;
            pbplayer8.Image = ykadro[2].foto;
            pbplayer9.Image = ykadro[3].foto;
            pbplayer10.Image = ykadro[4].foto;
            pbplayer11.Image = rakadro[0].foto;
            pbplayer12.Image = rakadro[1].foto;
            pbplayer13.Image = rakadro[2].foto;
            pbplayer14.Image = rakadro[3].foto;
            pbplayer15.Image = rakadro[4].foto;
            pbplayer16.Image = rakadro[5].foto;
            pbplayer17.Image = rakadro[6].foto;
            pbplayer18.Image = rakadro[7].foto;
            pbplayer19.Image = rakadro[8].foto;
            pbplayer20.Image = rakadro[9].foto;
            lblpgname.Text = akadro[0].name;
            lblsgname.Text = akadro[1].name;
            lblsfname.Text = akadro[2].name;
            lblpfname.Text = akadro[3].name;
            lblcname.Text = akadro[4].name;
            lblrpg.Text = rakadro[0].name;
            lblrsg.Text = rakadro[1].name;
            lblrsf.Text = rakadro[2].name;
            lblrpf.Text = rakadro[3].name;
            lblrc.Text = rakadro[4].name;
        }
        public void yedekpozisyonlari()
        {
            lbly0.Text = Convert.ToString(ykadro[0].pozisyon).ToUpper();
            lbly1.Text = Convert.ToString(ykadro[1].pozisyon).ToUpper();
            lbly2.Text = Convert.ToString(ykadro[2].pozisyon).ToUpper();
            lbly3.Text = Convert.ToString(ykadro[3].pozisyon).ToUpper();
            lbly4.Text = Convert.ToString(ykadro[4].pozisyon).ToUpper();


        }

        public void takimyarat()
        {
            team1 = staticdatabase.teams.secilentakim;
            if (staticdatabase.lists.lig == false)
            {
                team2 = staticdatabase.teams.lig[staticdatabase.teams.siradakitakim];
            }
            
            
            if (staticdatabase.teams.playoff == true)
            {
                team2 = staticdatabase.lists.rakip;
            }
            if(staticdatabase.lists.playoffiki == true)
            {
                team2 = staticdatabase.lists.rakip2;
            }
            if (staticdatabase.lists.final == true)
            {
                team2 = staticdatabase.lists.finalrakip;
            }
            pbteam1.Image = team1.logo;
            pbteam2.Image = team2.logo;

        }

        public void oyuncustatsyenile()
        {
            s1point.Text = akadro[0].SPoint.ToString();
            s2point.Text = akadro[1].SPoint.ToString();
            s3point.Text = akadro[2].SPoint.ToString();
            s4point.Text = akadro[3].SPoint.ToString();
            s5point.Text = akadro[4].SPoint.ToString();
            r1point.Text = rakadro[0].SPoint.ToString();
            r2point.Text = rakadro[1].SPoint.ToString();
            r3point.Text = rakadro[2].SPoint.ToString();
            r4point.Text = rakadro[3].SPoint.ToString();
            r5point.Text = rakadro[4].SPoint.ToString();

            s1asist.Text = akadro[0].SAsist.ToString();
            s2asist.Text = akadro[1].SAsist.ToString();
            s3asist.Text = akadro[2].SAsist.ToString();
            s4asist.Text = akadro[3].SAsist.ToString();
            s5asist.Text = akadro[4].SAsist.ToString();
            r1asist.Text = rakadro[0].SAsist.ToString();
            r2asist.Text = rakadro[1].SAsist.ToString();
            r3asist.Text = rakadro[2].SAsist.ToString();
            r4asist.Text = rakadro[3].SAsist.ToString();
            r5asist.Text = rakadro[4].SAsist.ToString();

            s1block.Text = akadro[0].SBlock.ToString();
            s2block.Text = akadro[1].SBlock.ToString();
            s3block.Text = akadro[2].SBlock.ToString();
            s4block.Text = akadro[3].SBlock.ToString();
            s5block.Text = akadro[4].SBlock.ToString();
            r1block.Text = rakadro[0].SBlock.ToString();
            r2block.Text = rakadro[1].SBlock.ToString();
            r3block.Text = rakadro[2].SBlock.ToString();
            r4block.Text = rakadro[3].SBlock.ToString();
            r5block.Text = rakadro[4].SBlock.ToString();

            s1reb.Text = akadro[0].SRebound.ToString();
            s2reb.Text = akadro[1].SRebound.ToString();
            s3reb.Text = akadro[2].SRebound.ToString();
            s4reb.Text = akadro[3].SRebound.ToString();
            s5reb.Text = akadro[4].SRebound.ToString();
            r1reb.Text = rakadro[0].SRebound.ToString();
            r2reb.Text = rakadro[1].SRebound.ToString();
            r3reb.Text = rakadro[2].SRebound.ToString();
            r4reb.Text = rakadro[3].SRebound.ToString();
            r5reb.Text = rakadro[4].SRebound.ToString();

            s1steal.Text = akadro[0].SSteal.ToString();
            s2steal.Text = akadro[1].SSteal.ToString();
            s3steal.Text = akadro[2].SSteal.ToString();
            s4steal.Text = akadro[3].SSteal.ToString();
            s5steal.Text = akadro[4].SSteal.ToString();
            r1steal.Text = rakadro[0].SSteal.ToString();
            r2steal.Text = rakadro[1].SSteal.ToString();
            r3steal.Text = rakadro[2].SSteal.ToString();
            r4steal.Text = rakadro[3].SSteal.ToString();
            r5steal.Text = rakadro[4].SSteal.ToString();

        }
        public bool sec1 = false;
        public bool sec2 = false;
        public void oyuncudegistirbutonu()
        {
            if (sec1 == true && sec2 is true)
            {
                btnsubs.Visible = true;
            }
        }

        private void pbplayer1_Click(object sender, EventArgs e)
        {
            secilenoyuncuas(akadro[0]);
            isoplayer = akadro[0];
            sec1 = true;
            oyuncudegistirbutonu();
            if(isolation==true)
            {
                isotemizle();
                iso1.Visible = true;
            }


        }

        private void isotemizle()
        {
            iso1.Visible = false;
            iso2.Visible = false;
            iso3.Visible = false;
            iso4.Visible = false;
            iso5.Visible = false;


        }

        private void pbplayer2_Click(object sender, EventArgs e)
        {
            secilenoyuncuas(akadro[1]);
            isoplayer = akadro[1];
            sec1 = true;
            oyuncudegistirbutonu();
            if (isolation == true)
            {
                isotemizle();
                iso2.Visible = true;
            }
        }

        private void pbplayer3_Click(object sender, EventArgs e)
        {
            secilenoyuncuas(akadro[2]);
            isoplayer = akadro[2];
            sec1 = true;
            oyuncudegistirbutonu();
            if (isolation == true)
            {
                isotemizle();
                iso3.Visible = true;
            }
        }

        private void pbplayer4_Click(object sender, EventArgs e)
        {
            secilenoyuncuas(akadro[3]);
            isoplayer = akadro[3];
            sec1 = true;
            oyuncudegistirbutonu();
            if (isolation == true)
            {
                isotemizle();
                iso4.Visible = true;
            }
        }

        private void pbplayer5_Click(object sender, EventArgs e)
        {
            secilenoyuncuas(akadro[4]);
            isoplayer = akadro[4];
            sec1 = true;
            oyuncudegistirbutonu();
            if (isolation == true)
            {
                isotemizle();
                iso5.Visible= true;
            }
        }

        private void pbplayer6_Click(object sender, EventArgs e)
        {
            secilenoyuncuyedek(ykadro[0]);
            sec2 = true;
            oyuncudegistirbutonu();
        }

        private void pbplayer7_Click(object sender, EventArgs e)
        {
            secilenoyuncuyedek(ykadro[1]);
            sec2 = true;
            oyuncudegistirbutonu();
        }

        private void pbplayer8_Click(object sender, EventArgs e)
        {
            secilenoyuncuyedek(ykadro[2]);
            sec2 = true;
            oyuncudegistirbutonu();
        }

        private void pbplayer9_Click(object sender, EventArgs e)
        {
            secilenoyuncuyedek(ykadro[3]);
            sec2 = true;
            oyuncudegistirbutonu();
        }

        private void pbplayer10_Click(object sender, EventArgs e)
        {
            secilenoyuncuyedek(ykadro[4]);
            sec2 = true;
            oyuncudegistirbutonu();

        }

        public  WaveOut soundFx;
        public  AudioFileReader _audioFile;
        
        private void btnsubs_Click(object sender, EventArgs e)
        {
            var importer = new RawSourceWaveStream(Properties.Resources.subs2, new WaveFormat());
            soundFx = new WaveOut();
            soundFx.Init(importer);
            soundFx.Play();
           

            gecicias = asoyuncu;
            geciciyedek = yedekoyuncu;
            oyuncu gecicias2 = new oyuncu();
            
               
            for(int i=0; i<=ykadro.Count-1; i++)
            {
                if(geciciyedek.name==ykadro[i].name)
                {
                    
                    ykadro[i] = gecicias;
                    secilenoyuncuyedek(ykadro[i]);
                    pbgiren1.Image = ykadro[i].foto;
                 

                }
                
            }
            for(int i=0; i<=akadro.Count-1; i++)
            {
                if(gecicias.name==akadro[i].name)
                {
                    akadro[i] = geciciyedek;
                    secilenoyuncuas(akadro[i]);
                    pbcikan1.Image = akadro[i].foto;
                  

                }
            }

            gpsub1goster();
            oyuncuresimleri();
            yedekpozisyonlari();
            oyuncustatsyenile();
            staminagoster();
            isoplayer = akadro[0];
            timersub1.Start();

        }
        
        private void gpsub1goster()
        {
            gpsub1.Visible = true;
        }
        private void gpsub1gizle()
        {
            gpsub1.Visible = false;
        }
        private void gpsub2goster()
        {
            gpsub2.Visible = true;
        }
        private void gpsub2gizle()
        {
            gpsub2.Visible = false;
        }

        

        public void statssifirla()
        {
             akadro[0].SPoint=0;
             akadro[1].SPoint=0;
             akadro[2].SPoint=0;
             akadro[3].SPoint=0;
             akadro[4].SPoint=0;
            ykadro[0].SPoint = 0;
            ykadro[1].SPoint = 0;
            ykadro[2].SPoint = 0;
            ykadro[3].SPoint = 0;
            ykadro[4].SPoint = 0;
            rakadro[0].SPoint=0;
             rakadro[1].SPoint=0;
             rakadro[2].SPoint=0;
             rakadro[3].SPoint=0;
             rakadro[4].SPoint=0;

            akadro[0].SAsist=0;
            akadro[1].SAsist=0;
            akadro[2].SAsist=0;
            akadro[3].SAsist=0;
            akadro[4].SAsist = 0;
            ykadro[0].SAsist = 0;
            ykadro[1].SAsist = 0;
            ykadro[2].SAsist = 0;
            ykadro[3].SAsist = 0;
            ykadro[4].SAsist = 0;
            rakadro[0].SAsist=0;
            rakadro[1].SAsist=0;
            rakadro[2].SAsist=0;
            rakadro[3].SAsist=0;
            rakadro[4].SAsist =0;

            akadro[0].SBlock=0;
            akadro[1].SBlock=0;
            akadro[2].SBlock=0;
            akadro[3].SBlock=0;
            akadro[4].SBlock = 0;
            ykadro[0].SBlock = 0;
            ykadro[1].SBlock = 0;
            ykadro[2].SBlock = 0;
            ykadro[3].SBlock = 0;
            ykadro[4].SBlock = 0;
            rakadro[0].SBlock=0;
            rakadro[1].SBlock=0;
            rakadro[2].SBlock=0;
            rakadro[3].SBlock=0;
            rakadro[4].SBlock = 0;

            akadro[0].SRebound=0;
            akadro[1].SRebound=0;
            akadro[2].SRebound=0;
            akadro[3].SRebound=0;
            akadro[4].SRebound = 0;
            ykadro[0].SRebound = 0;
            ykadro[1].SRebound = 0;
            ykadro[2].SRebound = 0;
            ykadro[3].SRebound = 0;
            ykadro[4].SRebound = 0;
            rakadro[0].SRebound=0;
            rakadro[1].SRebound=0;
            rakadro[2].SRebound=0;
            rakadro[3].SRebound=0;
            rakadro[4].SRebound=0;

            akadro[0].SSteal=0;
            akadro[1].SSteal=0;
            akadro[2].SSteal=0;
            akadro[3].SSteal=0;
            akadro[4].SSteal=0;
            ykadro[0].SSteal = 0;
            ykadro[1].SSteal = 0;
            ykadro[2].SSteal = 0;
            ykadro[3].SSteal = 0;
            ykadro[4].SSteal = 0;
            rakadro[0].SSteal=0;
            rakadro[1].SSteal=0;
            rakadro[2].SSteal=0;
            rakadro[3].SSteal=0;
            rakadro[4].SSteal=0;

            akadro[0].stamina = 0;
            akadro[1].stamina = 0;
            akadro[2].stamina = 0;
            akadro[3].stamina = 0;
            akadro[4].stamina = 0;
            ykadro[0].stamina = 0;
            ykadro[1].stamina = 0;
            ykadro[2].stamina = 0;
            ykadro[3].stamina = 0;
            ykadro[4].stamina = 0;

            rakadro[0].stamina = 0;
            rakadro[1].stamina = 0;
            rakadro[2].stamina = 0;
            rakadro[3].stamina = 0;
            rakadro[4].stamina = 0;
            rakadro[5].stamina = 0;
            rakadro[6].stamina = 0;
            rakadro[7].stamina = 0;
            rakadro[8].stamina = 0;
            rakadro[9].stamina = 0;

            akadro[0].Sgirenikilik = 0;
            akadro[1].Sgirenikilik = 0;
            akadro[2].Sgirenikilik = 0;
            akadro[3].Sgirenikilik = 0;
            akadro[4].Sgirenikilik = 0;
            ykadro[0].Sgirenikilik = 0;
            ykadro[1].Sgirenikilik = 0;
            ykadro[2].Sgirenikilik = 0;
            ykadro[3].Sgirenikilik = 0;
            ykadro[4].Sgirenikilik = 0;

            akadro[0].Sgirenucluk = 0;
            akadro[1].Sgirenucluk = 0;
            akadro[2].Sgirenucluk = 0;
            akadro[3].Sgirenucluk = 0;
            akadro[4].Sgirenucluk = 0;
            ykadro[0].Sgirenucluk = 0;
            ykadro[1].Sgirenucluk = 0;
            ykadro[2].Sgirenucluk = 0;
            ykadro[3].Sgirenucluk = 0;
            ykadro[4].Sgirenucluk = 0;

            akadro[0].Stoplamikilik = 0;
            akadro[1].Stoplamikilik = 0;
            akadro[2].Stoplamikilik = 0;
            akadro[3].Stoplamikilik = 0;
            akadro[4].Stoplamikilik = 0;
            ykadro[0].Stoplamikilik = 0;
            ykadro[1].Stoplamikilik = 0;
            ykadro[2].Stoplamikilik = 0;
            ykadro[3].Stoplamikilik = 0;
            ykadro[4].Stoplamikilik = 0;

            akadro[0].Stoplamucluk = 0;
            akadro[1].Stoplamucluk = 0;
            akadro[2].Stoplamucluk = 0;
            akadro[3].Stoplamucluk = 0;
            akadro[4].Stoplamucluk = 0;
            ykadro[0].Stoplamucluk = 0;
            ykadro[1].Stoplamucluk = 0;
            ykadro[2].Stoplamucluk = 0;
            ykadro[3].Stoplamucluk = 0;
            ykadro[4].Stoplamucluk = 0;



        }

        private void label74_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click(object sender, EventArgs e)
        {

        }

        private void label72_Click(object sender, EventArgs e)
        {

        }

        private void label101_Click(object sender, EventArgs e)
        {

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            gptactic2.Visible = true;
            btnstart.Visible = false;
            SoundPlayer arkafon=new SoundPlayer(Resources.arenamac);
            arkafon.Play();

            
            lblsonuc.BackColor = Color.Black;
            gpolay.Visible = true;
            if (periyot != 5 || periyot !>5)//5 olacak
            {
                timer1.Start();
                timer3.Start();
            }
            else
            {
              if(skora!=skorb)
              {
                    
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();

                    staticdatabase.teams.siradakitakim++;
                    staticdatabase.teams.macsayisi++;

                    if (skora > skorb)
                    {
                        team1.win++;
                        team2.lose++;
                        team1.salary = team1.salary + staticdatabase.lists.kazan;
                        staticdatabase.lists.macsonuc = true;
                    }
                    else if (skorb > skora)
                    {
                        team1.lose++;
                        team2.win++;
                        team1.salary = team1.salary + staticdatabase.lists.kaybet;
                        staticdatabase.lists.macsonuc = false;
                    }
                    staticdatabase.teams.skor1 = skora;
                    staticdatabase.teams.skor2 = skorb;
                    staticdatabase.lists.sarkivarmi = true;


                    sonstatsekle();
                    if (staticdatabase.teams.playoff == true && staticdatabase.lists.playoffiki == false)
                    {
                        staticdatabase.teams.secilentakim.skor = skora;
                        staticdatabase.lists.rakip.skor = skorb;
                        if (skora > skorb)
                        {
                            team1.playoffgalibiyet++;

                        }
                        else if (skorb > skora)
                        {
                            team2.playoffgalibiyet++;
                        }
                        if (team1.playoffgalibiyet == 4)
                        {
                            staticdatabase.teams.playoff2 = true;
                            staticdatabase.lists.birincieslesme = true;
                            staticdatabase.lists.ikincieslesme = true;
                            staticdatabase.lists.ucuncueslesme = true;
                            staticdatabase.lists.dorduncueslesme = true;

                        }
                        if (team2.playoffgalibiyet == 4)
                        {
                            staticdatabase.teams.elendi = true;
                        }

                        staticdatabase.lists.playoffmacsayisi++;
                        if (staticdatabase.teams.elendi == false && team1.playoffgalibiyet == 4)
                        {
                            
                            Form7 frm2 = new Form7();
                            this.Hide();
                            frm2.ShowDialog();
                            this.Dispose();
                        }

                        else if (staticdatabase.teams.elendi == true)
                        {
                            Form11 frm1 = new Form11();
                            this.Hide();
                            frm1.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            Form6 frm2 = new Form6();
                            this.Hide();
                            frm2.ShowDialog();
                            this.Dispose();
                        }


                    }
                    else if (staticdatabase.teams.playoff == false)
                    {
                        Form3 frm = new Form3();
                      
                            this.Hide();
                            frm.ShowDialog();
                            this.Dispose();
                        

                    }
                    if (staticdatabase.teams.playoff == true && staticdatabase.lists.playoffiki == true && staticdatabase.teams.final == false)
                    {
                        staticdatabase.teams.secilentakim.skor = skora;
                        staticdatabase.lists.rakip2.skor = skorb;
                        if (skora > skorb)
                        {
                            team1.playoffgalibiyet2++;

                        }
                        else if (skorb > skora)
                        {
                            team2.playoffgalibiyet2++;
                        }

                        if (team1.playoffgalibiyet2 == 4)
                        {
                            staticdatabase.teams.final = true;
                            Form8 frm3 = new Form8();
                            this.Hide();
                            frm3.ShowDialog();
                            this.Dispose();
                        }
                        else if (team2.playoffgalibiyet2 == 4)
                        {
                            Form11 frm1 = new Form11();
                            this.Hide();
                            frm1.ShowDialog();
                            this.Dispose();
                        }
                        else
                        {
                            Form7 frm2 = new Form7();
                            this.Hide();
                            frm2.ShowDialog();
                            this.Dispose();
                        }


                    }
                    if (staticdatabase.teams.final == true)
                    {
                        if (skora > skorb)
                        {
                            team1.finalgalibiyet++;

                        }
                        else if (skorb > skora)
                        {
                            team2.finalgalibiyet++;
                        }

                        if (team1.finalgalibiyet == 4 || team2.finalgalibiyet == 4)
                        {
                            if (team1.finalgalibiyet == 4)
                            {
                                Form12 frm3 = new Form12();
                                this.Hide();
                                frm3.ShowDialog();
                                this.Dispose();

                            }

                            else
                            {
                                Form1 frm2 = new Form1();
                                this.Hide();
                                frm2.ShowDialog();
                                this.Dispose();
                            }
                        }
                        else if (team1.finalgalibiyet != 4 || team2.finalgalibiyet != 4)
                        {
                            Form8 frm2 = new Form8();
                            this.Hide();
                            frm2.ShowDialog();
                            this.Dispose();
                        }

                    }
                    else
                    {

                        timer1.Start();
                        timer3.Start();
                        suredak = 4;


                    }


                }
              
            }
        }
        
        public void sonstatsekle()
        {
            team1.pg1.tpoint = team1 .pg1.tpoint + team1.pg1.SPoint;
            team1.sg1.tpoint = team1 .sg1.tpoint + team1.sg1.SPoint;
            team1.sf1.tpoint = team1 .sf1.tpoint + team1.sf1.SPoint;
            team1.pf1.tpoint = team1 .pf1.tpoint + team1.pf1.SPoint;
            team1.c1.tpoint = team1.c1.tpoint + team1.c1.SPoint;
            team1.pg2.tpoint = team1.pg2.tpoint + team1.pg2.SPoint;
            team1.sg2.tpoint = team1.sg2.tpoint + team1.sg2.SPoint;
            team1.sf2.tpoint = team1.sf2.tpoint + team1.sf2.SPoint;
            team1.pf2.tpoint = team1.pf2.tpoint + team1.pf2.SPoint;
            team1.c2.tpoint = team1.c2.tpoint + team1.c2.SPoint;

            team2.pg1.tpoint = team2.pg1.tpoint + team2.pg1.SPoint;
            team2.sg1.tpoint = team2.sg1.tpoint + team2.sg1.SPoint;
            team2.sf1.tpoint = team2.sf1.tpoint + team2.sf1.SPoint;
            team2.pf1.tpoint = team2.pf1.tpoint + team2.pf1.SPoint;
            team2.c1.tpoint = team2.c1.tpoint + team2.c1.SPoint;
            team2.pg2.tpoint = team2.pg2.tpoint + team2.pg2.SPoint;
            team2.sg2.tpoint = team2.sg2.tpoint + team2.sg2.SPoint;
            team2.sf2.tpoint = team2.sf2.tpoint + team2.sf2.SPoint;
            team2.pf2.tpoint = team2.pf2.tpoint + team2.pf2.SPoint;
            team2.c2.tpoint = team2.c2.tpoint + team2.c2.SPoint;

            team1.pg1.tekpoint = team1.pg1.SPoint;
            team1.sg1.tekpoint = team1.sg1.SPoint;
            team1.sf1.tekpoint = team1.sf1.SPoint;
            team1.pf1.tekpoint = team1.pf1.SPoint;
            team1.c1.tekpoint = team1.c1.SPoint;
            team1.pg2.tekpoint =team1.pg2.SPoint;
            team1.sg2.tekpoint =team1.sg2.SPoint;
            team1.sf2.tekpoint =team1.sf2.SPoint;
            team1.pf2.tekpoint = team1.pf2.SPoint;
            team1.c2.tekpoint = team1.c2.SPoint;

            team2.pg1.tekpoint =team2.pg1.SPoint;
            team2.sg1.tekpoint =team2.sg1.SPoint;
            team2.sf1.tekpoint =team2.sf1.SPoint;
            team2.pf1.tekpoint = team2.pf1.SPoint;
            team2.c1.tekpoint = team2.c1.SPoint;
            team2.pg2.tekpoint = team2.pg2.SPoint;
            team2.sg2.tekpoint = team2.sg2.SPoint;
            team2.sf2.tekpoint = team2.sf2.SPoint;
            team2.pf2.tekpoint = team2.pf2.SPoint;
            team2.c2.tekpoint = team2.c2.SPoint;

            team1.pg1.tekasist = team1.pg1.SAsist;
            team1.sg1.tekasist = team1.sg1.SAsist;
            team1.sf1.tekasist = team1.sf1.SAsist;
            team1.pf1.tekasist = team1.pf1.SAsist;
            team1.c1.tekasist = team1.c1.SAsist;
            team1.pg2.tekasist = team1.pg2.SAsist;
            team1.sg2.tekasist = team1.sg2.SAsist;
            team1.sf2.tekasist = team1.sf2.SAsist;
            team1.pf2.tekasist = team1.pf2.SAsist;
            team1.c2.tekasist = team1.c2.SAsist;

            team2.pg1.tekasist = team2.pg1.SAsist;
            team2.sg1.tekasist = team2.sg1.SAsist;
            team2.sf1.tekasist = team2.sf1.SAsist;
            team2.pf1.tekasist = team2.pf1.SAsist;
            team2.c1.tekasist = team2.c1.SAsist;
            team2.pg2.tekasist = team2.pg2.SAsist;
            team2.sg2.tekasist = team2.sg2.SAsist;
            team2.sf2.tekasist = team2.sf2.SAsist;
            team2.pf2.tekasist = team2.pf2.SAsist;
            team2.c2.tekasist = team2.c2.SAsist;

            team1.pg1.teksteal = team1.pg1.SSteal;
            team1.sg1.teksteal = team1.sg1.SSteal;
            team1.sf1.teksteal = team1.sf1.SSteal;
            team1.pf1.teksteal = team1.pf1.SSteal;
            team1.c1.teksteal = team1.c1.SSteal;
            team1.pg2.teksteal = team1.pg2.SSteal;
            team1.sg2.teksteal = team1.sg2.SSteal;
            team1.sf2.teksteal = team1.sf2.SSteal;
            team1.pf2.teksteal = team1.pf2.SSteal;
            team1.c2.teksteal = team1.c2.SSteal;

            team2.pg1.teksteal = team2.pg1.SSteal;
            team2.sg1.teksteal = team2.sg1.SSteal;
            team2.sf1.teksteal = team2.sf1.SSteal;
            team2.pf1.teksteal = team2.pf1.SSteal;
            team2.c1.teksteal = team2.c1.SSteal;
            team2.pg2.teksteal = team2.pg2.SSteal;
            team2.sg2.teksteal = team2.sg2.SSteal;
            team2.sf2.teksteal = team2.sf2.SSteal;
            team2.pf2.teksteal = team2.pf2.SSteal;
            team2.c2.teksteal = team2.c2.SSteal;

            team1.pg1.tekrebound = team1.pg1.SRebound;
            team1.sg1.tekrebound = team1.sg1.SRebound;
            team1.sf1.tekrebound = team1.sf1.SRebound;
            team1.pf1.tekrebound = team1.pf1.SRebound;
            team1.c1.tekrebound = team1.c1.SRebound;
            team1.pg2.tekrebound = team1.pg2.SRebound;
            team1.sg2.tekrebound = team1.sg2.SRebound;
            team1.sf2.tekrebound = team1.sf2.SRebound;
            team1.pf2.tekrebound = team1.pf2.SRebound;
            team1.c2.tekrebound = team1.c2.SRebound;

            team2.pg1.tekrebound = team2.pg1.SRebound;
            team2.sg1.tekrebound = team2.sg1.SRebound;
            team2.sf1.tekrebound = team2.sf1.SRebound;
            team2.pf1.tekrebound = team2.pf1.SRebound;
            team2.c1.tekrebound = team2.c1.SRebound;
            team2.pg2.tekrebound = team2.pg2.SRebound;
            team2.sg2.tekrebound = team2.sg2.SRebound;
            team2.sf2.tekrebound = team2.sf2.SRebound;
            team2.pf2.tekrebound = team2.pf2.SRebound;
            team2.c2.tekrebound = team2.c2.SRebound;

            team1.pg1.tekblock = team1.pg1.SBlock;
            team1.sg1.tekblock = team1.sg1.SBlock;
            team1.sf1.tekblock = team1.sf1.SBlock;
            team1.pf1.tekblock = team1.pf1.SBlock;
            team1.c1.tekblock = team1.c1.SBlock;
            team1.pg2.tekblock = team1.pg2.SBlock;
            team1.sg2.tekblock = team1.sg2.SBlock;
            team1.sf2.tekblock = team1.sf2.SBlock;
            team1.pf2.tekblock = team1.pf2.SBlock;
            team1.c2.tekblock = team1.c2.SBlock;

            team2.pg1.tekblock = team2.pg1.SBlock;
            team2.sg1.tekblock = team2.sg1.SBlock;
            team2.sf1.tekblock = team2.sf1.SBlock;
            team2.pf1.tekblock = team2.pf1.SBlock;
            team2.c1.tekblock = team2.c1.SBlock;
            team2.pg2.tekblock = team2.pg2.SBlock;
            team2.sg2.tekblock = team2.sg2.SBlock;
            team2.sf2.tekblock = team2.sf2.SBlock;
            team2.pf2.tekblock = team2.pf2.SBlock;
            team2.c2.tekblock = team2.c2.SBlock;


        }



        public void skorboardyenile()
        {
            skor1.Text = skora.ToString();
            skor2.Text = skorb.ToString();

        }
        public void staminagoster()
        {

            if(akadro[0].stamina<6)
            {
                pil1.Image = Resources._5;
            }
            else if(akadro[0].stamina<12)
            {
                pil1.Image = Resources._4;
            }
            else if (akadro[0].stamina < 18)
            {
                pil1.Image = Resources._3;
            }
            else if (akadro[0].stamina <24)
            {
                pil1.Image = Resources._2;
            }
            else
                pil1.Image=Resources._1;

            if (akadro[1].stamina < 6)
            {
                pil2.Image = Resources._5;
            }
            else if (akadro[1].stamina < 12)
            {
                pil2.Image = Resources._4;
            }
            else if (akadro[1].stamina < 18)
            {
                pil2.Image = Resources._3;
            }
            else if (akadro[1].stamina < 24)
            {
                pil2.Image = Resources._2;
            }
            else
                pil2.Image = Resources._1;
            if (akadro[2].stamina < 6)
            {
                pil3.Image = Resources._5;
            }
            else if (akadro[2].stamina < 12)
            {
                pil3.Image = Resources._4;
            }
            else if (akadro[2].stamina < 18)
            {
                pil3.Image = Resources._3;
            }
            else if (akadro[2].stamina < 24)
            {
                pil3.Image = Resources._2;
            }
            else
                pil3.Image = Resources._1;
            if (akadro[3].stamina < 6)
            {
                pil4.Image = Resources._5;
            }
            else if (akadro[3].stamina < 12)
            {
                pil4.Image = Resources._4;
            }
            else if (akadro[3].stamina < 18)
            {
                pil4.Image = Resources._3;
            }
            else if (akadro[3].stamina < 24)
            {
                pil4.Image = Resources._2;
            }
            else
                pil4.Image = Resources._1;
            if (akadro[4].stamina < 6)
            {
                pil5.Image = Resources._5;
            }
            else if (akadro[4].stamina < 12)
            {
                pil5.Image = Resources._4;
            }
            else if (akadro[4].stamina < 18)
            {
                pil5.Image = Resources._3;
            }
            else if (akadro[4].stamina < 24)
            {
                pil5.Image = Resources._2;
            }
            else
                pil5.Image = Resources._1;
            if (ykadro[0].stamina < 6)
            {
                pil6.Image = Resources._5;
            }
            else if (ykadro[0].stamina < 12)
            {
                pil6.Image = Resources._4;
            }
            else if (ykadro[0].stamina < 18)
            {
                pil6.Image = Resources._3;
            }
            else if (ykadro[0].stamina < 24)
            {
                pil6.Image = Resources._2;
            }
            else
                pil6.Image = Resources._1;
            if (ykadro[1].stamina < 6)
            {
                pil7.Image = Resources._5;
            }
            else if (ykadro[1].stamina < 12)
            {
                pil7.Image = Resources._4;
            }
            else if (ykadro[1].stamina < 18)
            {
                pil7.Image = Resources._3;
            }
            else if (ykadro[1].stamina < 24)
            {
                pil7.Image = Resources._2;
            }
            else
                pil7.Image = Resources._1;
            if (ykadro[2].stamina < 6)
            {
                pil8.Image = Resources._5;
            }
            else if (ykadro[2].stamina < 12)
            {
                pil8.Image = Resources._4;
            }
            else if (ykadro[2].stamina < 18)
            {
                pil8.Image = Resources._3;
            }
            else if (ykadro[2].stamina < 24)
            {
                pil8.Image = Resources._2;
            }
            else
                pil8.Image = Resources._1;
            if (ykadro[3].stamina < 6)
            {
                pil9.Image = Resources._5;
            }
            else if (ykadro[3].stamina < 12)
            {
                pil9.Image = Resources._4;
            }
            else if (ykadro[3].stamina < 18)
            {
                pil9.Image = Resources._3;
            }
            else if (ykadro[3].stamina < 24)
            {
                pil9.Image = Resources._2;
            }
            else
                pil9.Image = Resources._1;
            if (ykadro[4].stamina < 6)
            {
                pil10.Image = Resources._5;
            }
            else if (ykadro[4].stamina < 12)
            {
                pil10.Image = Resources._4;
            }
            else if (ykadro[4].stamina < 18)
            {
                pil10.Image = Resources._3;
            }
            else if (ykadro[4].stamina < 24)
            {
                pil10.Image = Resources._2;
            }
            else
                pil10.Image = Resources._1;



        }
        int takimrebounda = 0;
        int takimreboundb = 0;
        public void rebound()
        {
            takimrebounda = (akadro[0].rebound * 8) + (akadro[1].rebound * 9) + (akadro[2].rebound * 10) + (akadro[3].rebound * 11) + (akadro[4].rebound * 12) / 50;
            takimreboundb= (rakadro[0].rebound * 8) + (rakadro[1].rebound * 9) + (rakadro[2].rebound * 10) + (rakadro[3].rebound * 11) + (rakadro[4].rebound * 12) / 50;
        }
        oyuncu reboundalan = new oyuncu();
        public void reboundcua()
        {
            int toplamreb = (akadro[0].rebound * 8) + (akadro[1].rebound * 9) + (akadro[2].rebound * 10) + (akadro[3].rebound * 11) + (akadro[4].rebound * 12);
            Random rnd = new Random();
            int sec= rnd.Next(0, toplamreb);
            if (sec < (akadro[0].rebound * 8))
                reboundalan = akadro[0];
            else if (sec < (akadro[0].rebound * 8) + (akadro[1].rebound * 9))
                reboundalan = akadro[1];
            else if (sec < (akadro[0].rebound * 8) + (akadro[1].rebound * 9) + (akadro[2].rebound * 10))
                reboundalan = akadro[2];
            else if (sec < (akadro[0].rebound * 8) + (akadro[1].rebound * 9) + (akadro[2].rebound * 10) + (akadro[3].rebound * 11))
                reboundalan = akadro[3];
            else
                reboundalan = akadro[4];
         }
        public void reboundcub()
        {
            int toplamreb = (rakadro[0].rebound * 8) + (rakadro[1].rebound * 9) + (rakadro[2].rebound * 10) + (rakadro[3].rebound * 11) + (rakadro[4].rebound * 12);
            Random rnd = new Random();
            int sec = rnd.Next(0, toplamreb);
            if (sec < (rakadro[0].rebound * 8))
                reboundalan = rakadro[0];
            else if (sec < (rakadro[0].rebound * 8) + (rakadro[1].rebound * 9))
                reboundalan = rakadro[1];
            else if (sec < (rakadro[0].rebound * 8) + (rakadro[1].rebound * 9) + (rakadro[2].rebound * 10))
                reboundalan = akadro[2];
            else if (sec < (rakadro[0].rebound * 8) + (rakadro[1].rebound * 9) + (rakadro[2].rebound * 10) + (rakadro[3].rebound * 11))
                reboundalan = rakadro[3];
            else
                reboundalan = rakadro[4];
        }




        oyuncu atak = new oyuncu();
        oyuncu defans = new oyuncu();
        public void hucumcusec()
        {
            int hucummax = akadro[0].ikilik + akadro[0].ucluk + akadro[1].ikilik + akadro[1].ucluk + akadro[2].ikilik + akadro[2].ucluk + akadro[3].ikilik + akadro[3].ucluk + akadro[4].ikilik + akadro[4].ucluk;
            Random rand = new Random();
            int secim=rand.Next(0, hucummax);
            if (secim <= akadro[0].ikilik + akadro[0].ucluk)
            {
                atak = akadro[0];
                defans = rakadro[0];
            }
            else if (secim <= akadro[0].ikilik + akadro[0].ucluk + akadro[1].ikilik + akadro[1].ucluk)
            {
                atak = akadro[1];
                defans = rakadro[1];
            }
            else if (secim <= akadro[0].ikilik + akadro[0].ucluk + akadro[1].ikilik + akadro[1].ucluk + akadro[2].ikilik + akadro[2].ucluk)
            {
                atak = akadro[2];
                defans = rakadro[2];
            }
            else if (secim <= akadro[0].ikilik + akadro[0].ucluk + akadro[1].ikilik + akadro[1].ucluk + akadro[2].ikilik + akadro[2].ucluk + akadro[3].ikilik + akadro[3].ucluk)
            {
                atak = akadro[3];
                defans = rakadro[3];
            }
            else
            {
                atak = akadro[4];
                defans=rakadro[4];
            }
        }

        public void hucumcusecb()
        {
            int hucummax = rakadro[0].ikilik + rakadro[0].ucluk + rakadro[1].ikilik + rakadro[1].ucluk + rakadro[2].ikilik + rakadro[2].ucluk + rakadro[3].ikilik + rakadro[3].ucluk + rakadro[4].ikilik + rakadro[4].ucluk;
            Random rand = new Random();
            int secim = rand.Next(0, hucummax);
            if (secim <= rakadro[0].ikilik + rakadro[0].ucluk)
            {
                atak = rakadro[0];
                defans = akadro[0];
            }
            else if (secim <= rakadro[0].ikilik + rakadro[0].ucluk + rakadro[1].ikilik + rakadro[1].ucluk)
            {
                atak = rakadro[1];
                defans = akadro[1];
            }
            else if (secim <= rakadro[0].ikilik + rakadro[0].ucluk + rakadro[1].ikilik + rakadro[1].ucluk + rakadro[2].ikilik + rakadro[2].ucluk)
            {
                atak = rakadro[2];
                defans = akadro[2];
            }
            else if (secim <= rakadro[0].ikilik + rakadro[0].ucluk + rakadro[1].ikilik + rakadro[1].ucluk + rakadro[2].ikilik + rakadro[2].ucluk + rakadro[3].ikilik + rakadro[3].ucluk)
            {
                atak = rakadro[3];
                defans = akadro[3];
            }
            else
            {
                atak = rakadro[4];
                defans = akadro[4];
            }
        }
        int asistortalamaa = 0;
        int asistortalamab = 0;
        public void asistort()
        {
            asistortalamaa = (akadro[0].asist + akadro[1].asist + akadro[2].asist + akadro[3].asist + akadro[4].asist) / 5;
            asistortalamab = (rakadro[0].asist + rakadro[1].asist + rakadro[2].asist + rakadro[3].asist + rakadro[4].asist) / 5;
        }

        public void staminaa()
        {

            Random r = new Random();
            int oyuncu = r.Next(0, 5);
            akadro[oyuncu].stamina = akadro[oyuncu].stamina + 4;



            foreach(oyuncu item in ykadro)
            {
                item.stamina=item.stamina-2;
                if(item.stamina < 0)
                { item.stamina = 0; }
            }
        }

        public void staminab()
        {

            Random r = new Random();
            int oyuncu = r.Next(0, 5);
            rakadro[oyuncu].stamina = rakadro[oyuncu].stamina + 3;

            rakadro[5].stamina=rakadro[5].stamina-2;
            rakadro[6].stamina=rakadro[5].stamina-2;
            rakadro[7].stamina=rakadro[5].stamina-2;
            rakadro[8].stamina=rakadro[5].stamina-2;
            rakadro[9].stamina = rakadro[5].stamina - 2;
            if (rakadro[5].stamina<0)
                rakadro[5].stamina = 0;
            if (rakadro[6].stamina < 0)
                rakadro[6].stamina = 0;
            if (rakadro[7].stamina < 0)
                rakadro[7].stamina = 0;
            if (rakadro[8].stamina < 0)
                rakadro[8].stamina = 0;
            if (rakadro[9].stamina < 0)
                rakadro[9].stamina = 0;
        }

        public void oransinirlayici()
        {
            //if(atak.Xpoint3>=3)
            //    atak.Xpoint3 = 3;
            //if (atak.Xpoint3 <= -3)
            //    atak.Xpoint3 = -3;
            if (atak.Xpoint >= 3)
                atak.Xpoint = 3;
            if (atak.Xpoint <= -3)
                atak.Xpoint = -3;


        }
        oyuncu asistci = new oyuncu();
        public void asistsecicia()
        {
            int toplam = akadro[0].asist + akadro[1].asist + akadro[2].asist + akadro[3].asist + akadro[4].asist;
            Random r = new Random();
            int secici=r.Next(0, toplam);
            if (secici < akadro[0].asist)
                asistci = akadro[0];
            else if (secici < akadro[0].asist + akadro[1].asist)
                asistci = akadro[1];
            else if (secici < akadro[0].asist + akadro[1].asist + akadro[2].asist)
                asistci = akadro[2];
            else if (secici < akadro[0].asist + akadro[1].asist + akadro[2].asist + akadro[3].asist)
                asistci = akadro[3];
            else
                asistci= akadro[4];
        }

        public void asistsecicib()
        {
            int toplam = rakadro[0].asist + rakadro[1].asist + rakadro[2].asist + rakadro[3].asist + rakadro[4].asist;
            Random r = new Random();
            int secici = r.Next(0, toplam);
            if (secici < rakadro[0].asist)
                asistci = rakadro[0];
            else if (secici < rakadro[0].asist + rakadro[1].asist)
                asistci = rakadro[1];
            else if (secici < rakadro[0].asist + rakadro[1].asist + rakadro[2].asist)
                asistci = akadro[2];
            else if (secici < rakadro[0].asist + rakadro[1].asist + rakadro[2].asist + rakadro[3].asist)
                asistci = rakadro[3];
            else
                asistci = rakadro[4];



        }
        public void oyuncudegisikligises()
        {
            var importer = new RawSourceWaveStream(Properties.Resources.subs2, new WaveFormat());
            soundFx = new WaveOut();
            soundFx.Init(importer);
            soundFx.Play();
        }

        public void oyuncudegisikligi()
        {
           
            if (rakadro[0].stamina>15 && rakadro[0].Asyedek=="AS")
            {
                oyuncu gecici = new oyuncu();
                gecici = rakadro[0];
                rakadro[0] = rakadro[5];
                rakadro[5]=gecici;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[0].foto;
                pbcikan2.Image = rakadro[5].foto;
                gpsub2goster();
                timersub2.Start();
                
               
              



            }

            if (rakadro[0].stamina > 8 && rakadro[0].Asyedek == "YEDEK")
            {
                oyuncu gecici = new oyuncu();
                gecici = rakadro[0];
                rakadro[0] = rakadro[5];
                rakadro[5] = gecici;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[0].foto;
                pbcikan2.Image = rakadro[5].foto;
                gpsub2goster();
                timersub2.Start();




            }
            
            if (rakadro[1].stamina > 15 && rakadro[1].Asyedek == "AS")
            {
                oyuncu gecici2 = new oyuncu();
                gecici2 = rakadro[1];
                rakadro[1] = rakadro[6];
                rakadro[6] = gecici2;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[1].foto;
                pbcikan2.Image = rakadro[6].foto;
                gpsub2goster();
                timersub2.Start();



            }
            if (rakadro[1].stamina > 8 && rakadro[1].Asyedek == "YEDEK")
            {
                oyuncu gecici2 = new oyuncu();
                gecici2 = rakadro[1];
                rakadro[1] = rakadro[6];
                rakadro[6] = gecici2;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[1].foto;
                pbcikan2.Image = rakadro[6].foto;
                gpsub2goster();
                timersub2.Start();



            }
            if (rakadro[2].stamina > 15 && rakadro[2].Asyedek == "AS")
            {
                oyuncu gecici3 = new oyuncu();
                gecici3 = rakadro[2];
                rakadro[2] = rakadro[7];
                rakadro[7] = gecici3;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[2].foto;
                pbcikan2.Image = rakadro[7].foto;
                gpsub2goster();
                timersub2.Start();

            }
            if (rakadro[2].stamina > 8 && rakadro[2].Asyedek == "YEDEK")
            {
                oyuncu gecici3 = new oyuncu();
                gecici3 = rakadro[2];
                rakadro[2] = rakadro[7];
                rakadro[7] = gecici3;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[2].foto;
                pbcikan2.Image = rakadro[7].foto;
                gpsub2goster();
                timersub2.Start();

            }

            if (rakadro[3].stamina > 15 && rakadro[3].Asyedek == "AS" )
            {
                oyuncu gecici4 = new oyuncu();
                gecici4 = rakadro[3];
                rakadro[3] = rakadro[8];
                rakadro[8] = gecici4;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[3].foto;
                pbcikan2.Image = rakadro[8].foto;
                gpsub2goster();
                timersub2.Start();


            }
            if (rakadro[3].stamina > 8 && rakadro[3].Asyedek == "YEDEK")
            {
                oyuncu gecici4 = new oyuncu();
                gecici4 = rakadro[3];
                rakadro[3] = rakadro[8];
                rakadro[8] = gecici4;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[3].foto;
                pbcikan2.Image = rakadro[8].foto;
                gpsub2goster();
                timersub2.Start();


            }
            if (rakadro[4].stamina > 15 && rakadro[4].Asyedek == "AS")
            {
                oyuncu gecici = new oyuncu();
                gecici = rakadro[4];
                rakadro[4] = rakadro[9];
                rakadro[9] = gecici;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[4].foto;
                pbcikan2.Image = rakadro[9].foto;
                gpsub2goster();
                timersub2.Start();

            }
            if (rakadro[4].stamina > 8 && rakadro[4].Asyedek == "YEDEK")
            {
                oyuncu gecici = new oyuncu();
                gecici = rakadro[4];
                rakadro[4] = rakadro[9];
                rakadro[9] = gecici;
                oyuncudegisikligises();
                pbgiren2.Image = rakadro[4].foto;
                pbcikan2.Image = rakadro[9].foto;
                gpsub2goster();
                timersub2.Start();

            }

         
        }



        int poslimit=0;
        public void pozisyonsınırlayici()
        {
            if (atak == akadro[0])
            {
                if (atak.pozisyon == enums.position.pg)
                    poslimit = 0;
                else if (atak.pozisyon == enums.position.sg)
                    poslimit = 10;
                else if (atak.pozisyon == enums.position.sf)
                    poslimit = 20;
                else if (atak.pozisyon == enums.position.pf)
                    poslimit = 30;
                else if (atak.pozisyon == enums.position.cent)
                    poslimit = 40;
            }
            else if (atak == akadro[1])
            {
                if (atak.pozisyon == enums.position.pg)
                    poslimit = 10;
                else if (atak.pozisyon == enums.position.sg)
                    poslimit = 0;
                else if (atak.pozisyon == enums.position.sf)
                    poslimit = 10;
                else if (atak.pozisyon == enums.position.pf)
                    poslimit = 20;
                else if (atak.pozisyon == enums.position.cent)
                    poslimit = 30;
            }
            else if (atak == akadro[2])
            {
                if (atak.pozisyon == enums.position.pg)
                    poslimit = 20;
                else if (atak.pozisyon == enums.position.sg)
                    poslimit = 10;
                else if (atak.pozisyon == enums.position.sf)
                    poslimit = 0;
                else if (atak.pozisyon == enums.position.pf)
                    poslimit = 10;
                else if (atak.pozisyon == enums.position.cent)
                    poslimit = 20;
            }
            else if (atak == akadro[3])
            {
                if (atak.pozisyon == enums.position.pg)
                    poslimit = 30;
                else if (atak.pozisyon == enums.position.sg)
                    poslimit = 20;
                else if (atak.pozisyon == enums.position.sf)
                    poslimit = 10;
                else if (atak.pozisyon == enums.position.pf)
                    poslimit = 0;
                else if (atak.pozisyon == enums.position.cent)
                    poslimit = 10;
            }
            else if (atak == akadro[4])
            {
                if (atak.pozisyon == enums.position.pg)
                    poslimit = 40;
                else if (atak.pozisyon == enums.position.sg)
                    poslimit = 30;
                else if (atak.pozisyon == enums.position.sf)
                    poslimit = 20;
                else if (atak.pozisyon == enums.position.pf)
                    poslimit = 10;
                else if (atak.pozisyon == enums.position.cent)
                    poslimit = 0;
            }


        }

        public void spikerikilikgirdi()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 21);
            if (secim == 1)
                lblspiker.Text = $"Nice footwork by {atak.name} and good. Over the {defans.name}";
            else if(secim==2)
                lblspiker.Text = $"Mid range shot, goooood! {atak.name}";
            else if (secim == 3)
                lblspiker.Text = $"{atak.name} hammers it down!! Over the {defans.name}";
            else if( secim==4)
                lblspiker.Text = $"{atak.name} and one hand SLAM! Over the {defans.name}";
            else if (secim == 5)
                lblspiker.Text = $"{atak.name} finds the point Over the {defans.name}";
            else if (secim == 6)
                lblspiker.Text = $"Close shot by {atak.name}, and yes!";
            else if (secim == 7)
                lblspiker.Text = $"{atak.name} finds the space and finishes it.";
            else if (secim == 8)
                lblspiker.Text = $"{atak.name} finds the net. That was 2 point. Over the {defans.name}";
            else if (secim == 9)
                lblspiker.Text = $"Nice play by {atak.name} and 2 point basket.";
            else if (secim == 10)
                lblspiker.Text = $"{atak.name} finds the space,asist by {asistci.name}.";
            else if (secim == 11)
                lblspiker.Text = $"{atak.name}! Baaang. 2 point basket..Over the {defans.name}";
            else if (secim == 12)
                lblspiker.Text = $"{atak.name} finds the net from mid range. Nice shot!";
            else if (secim == 14)
                lblspiker.Text = $"Nice shot from {atak.name} from mid range. Over the {defans.name}";
            else if (secim == 15)
                lblspiker.Text = $"Fastbreak and yes! Finds the target ";
            else if (secim == 16)
                lblspiker.Text = $"{atak.name} finds his pace. Great shot for 2.Over the {defans.name}";
            else if (secim == 17)
                lblspiker.Text = $"Inside, {atak.name}. Yes! Over the {defans.name}";
            else if (secim == 18)
                lblspiker.Text = $"{atak.name} on the dribble. Scores. ";
            else if (secim == 19)
                lblspiker.Text = $"Crossover, stepback. Mid Range. Yeeees. Over the {defans.name}";
            else if (secim == 20)
                lblspiker.Text = $"{atak.name} on the drive, falling awaaay. Yes.  ";
            if(secim==3 && secim==4)
            {
                slamses();
            }
            else 
            {
                sayises();
            }

            lblspiker.ForeColor = Color.LawnGreen;
        }

        public void ikilikgirdiasist()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 14);
            if (secim == 1)
            {
                lblspiker.Text = $"Nice footwork by {atak.name} and good.Asist by {asistci.name}";
                sayises();
            }
            else if (secim == 2)
            {
                lblspiker.Text = $"Mid range shot, goooood! {atak.name}.Asist by {asistci.name} ";
                sayises();
            }
            else if (secim == 3)
            {
                lblspiker.Text = $"{atak.name} hammers it down!! Great asist by {asistci.name}";
                slamses();
            }
            else if (secim == 4)
            {
                lblspiker.Text = $"{atak.name} and one hand SLAM! Nice asist: {asistci.name} ";
                slamses();
            }
            else if (secim == 5)
            {
                lblspiker.Text = $"{atak.name} finds the point over {defans.name}";
                sayises();
            }
            else if (secim == 6)
            {
                lblspiker.Text = $"Close shot by {atak.name}, and yes! {asistci.name} found him.";
                sayises();
            }
            else if (secim == 7)
            {
                lblspiker.Text = $"{atak.name} finds the space and finished it.{asistci.name}! Great Asist.";
                sayises();
            }
            else if (secim == 8)
            {
                lblspiker.Text = $"Asist by {asistci.name}, {atak.name}  finds the net. That was 2 point.";
                sayises();
            }
            else if (secim == 9)
            {
                lblspiker.Text = $"Nice play by {atak.name} and {asistci.name}.  2 point basket.";
                sayises();
            }
            else if (secim == 10)
            {
                lblspiker.Text = $"Inside, {atak.name}. Yes. Great Asist by {asistci.name} ";
                sayises();
            }
            else if (secim == 11)
            {
                lblspiker.Text = $"{atak.name} on the dribble. Scores. ";
                sayises();
            }
            else if (secim == 12)
            {
                lblspiker.Text = $"Crossover, stepback. Mid Range. Yeeees. ";
                sayises();
            }
            else if (secim == 13)
            {
                lblspiker.Text = $"{atak.name} on the drive, falling awaaay. Yes.";
                sayises();
            }

            lblspiker.ForeColor = Color.LawnGreen;
        }

        public void uclukgirdispiker()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 21);
            if (secim == 1)
                lblspiker.Text = $"{atak.name} from downtown.";
            else if (secim == 2)
                lblspiker.Text = $"{atak.name} from long range. Yes! ";
            else if (secim == 3)
                lblspiker.Text = $"3 point shot from {atak.name}, Yes! Counted.";
            else if (secim == 4)
                lblspiker.Text = $"{atak.name} finds the open from long range! Yes. ";
            else if (secim == 5)
                lblspiker.Text = $"Stepback from {atak.name}, BAAAANG!";
            else if (secim == 6)
                lblspiker.Text = $"{atak.name} from three! Yes.";
            else if (secim == 7)
                lblspiker.Text = $"{atak.name}, very long range! Yeees!";
            else if (secim == 8)
                lblspiker.Text = $"{atak.name} from inside the 28 footline. Yes.";
            else if (secim == 9)
                lblspiker.Text = $"Crossover, stepback. From downtown. Yes.";
            else if (secim == 10)
                lblspiker.Text = $"{atak.name} from long range!!! Omg yes!. Are you kiddin me? ";
            else if (secim == 11)
                lblspiker.Text = $"{atak.name} on the dribble. Scores. ";
            else if (secim == 12)
                lblspiker.Text = $"From downtown. Baaaaang. What a shot from {atak.name}! ";
            else if (secim == 13)
                lblspiker.Text = $"{atak.name} on the drive, falling awaaay. Yes.";
            else if (secim == 14)
                lblspiker.Text = $"{atak.name}, very long range! Yeees! Over the {defans.name}";
            else if (secim == 15)
                lblspiker.Text = $"{atak.name} from inside the 28 footline. Yes.Over the {defans.name}";
            else if (secim == 16)
                lblspiker.Text = $"Crossover, stepback. From downtown. Yes.";
            else if (secim == 17)
                lblspiker.Text = $"{atak.name} from long range!!! Omg yes!. Are you kiddin me? ";
            else if (secim == 18)
                lblspiker.Text = $"{atak.name} on the dribble. Scores. Over the {defans.name} ";
            else if (secim == 19)
                lblspiker.Text = $"From downtown. Baaaaang. What a shot from {atak.name}! ";
            else if (secim == 20)
                lblspiker.Text = $"{atak.name} on the drive, falling awaaay. Over the {defans.name}";
            uclukses();

            lblspiker.ForeColor = Color.LawnGreen;
        }

        public void uclukgirdispikerasist()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 21);
            if (secim == 1)
                lblspiker.Text = $"{atak.name} from downtown.Asist by {asistci.name}";
            else if (secim == 2)
                lblspiker.Text = $"{atak.name} from long range. Yes! Great asist by {asistci.name} ";
            else if (secim == 3)
                lblspiker.Text = $"3 point shot from {atak.name}, Yes! Counted.";
            else if (secim == 4)
                lblspiker.Text = $"{atak.name} finds the open from long range! Yes. ";
            else if (secim == 5)
                lblspiker.Text = $"Stepback from {atak.name}, BAAAANG!";
            else if (secim == 6)
                lblspiker.Text = $"{atak.name} from three! Yes.Nice asist {asistci.name}";
            else if (secim == 7)
                lblspiker.Text = $"{atak.name}, very long range! Yeees!";
            else if (secim == 8)
                lblspiker.Text = $"{atak.name} from inside the 28 footline. Yes.";
            else if (secim == 9)
                lblspiker.Text = $"Crossover, stepback. From downtown. Yes.";
            else if (secim == 10)
                lblspiker.Text = $"{atak.name} from long range!!! Omg yes!. Are you kiddin me? ";
            else if (secim == 11)
                lblspiker.Text = $"{atak.name} on the dribble. Scores. Asist by {asistci.name} ";
            else if (secim == 12)
                lblspiker.Text = $"From downtown. Baaaaang. What a shot from {atak.name}! ";
            else if (secim == 13)
                lblspiker.Text = $"{atak.name} on the drive, falling awaaay. Yes. 3 point play.";
            else if (secim == 14)
                lblspiker.Text = $"{atak.name}, very long range! Yeees! Over the {defans.name}";
            else if (secim == 15)
                lblspiker.Text = $"{atak.name} from inside the 28 footline. Yes.Over the {defans.name}";
            else if (secim == 16)
                lblspiker.Text = $"Crossover, stepback. From downtown. Yes.{asistci.name} found him";
            else if (secim == 17)
                lblspiker.Text = $"{atak.name} from long range!!! Omg yes!. Are you kiddin me? ";
            else if (secim == 18)
                lblspiker.Text = $"{atak.name} on the dribble. Scores. Over the {defans.name} ";
            else if (secim == 19)
                lblspiker.Text = $"From downtown. Baaaaang. What a shot from {atak.name}! ";
            else if (secim == 20)
                lblspiker.Text = $"{atak.name} on the drive, falling awaaay. Over the {defans.name}";
            uclukses();

            lblspiker.ForeColor = Color.LawnGreen;
        }



        public void ikilikkactispiker()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 15);
            if (secim == 1)
                lblspiker.Text = $"{atak.name} from mid range. Missed. Rebounded by {reboundalan.name}";
            else if (secim == 2)
                lblspiker.Text = $"{atak.name}’s footwork, miss.  ";
            else if (secim == 3)
                lblspiker.Text = $"{atak.name} try to spin, no. Great defense from {defans.name}";
            else if (secim == 4)
                lblspiker.Text = $"{atak.name} finds a space but no. Oh god how can he missed it. ";
            else if (secim == 5)
                lblspiker.Text = $"{atak.name} fast shoot and no. Missed! {reboundalan.name} gets the rebound";
            else if (secim == 6)
                lblspiker.Text = $"Great defense from {defans.name}, {atak.name} couldnt find it.";
            else if (secim == 7)
                lblspiker.Text = $"Mid range shot from {atak.name} , no good.Rebound:  {reboundalan.name}";
            else if (secim == 8)
                lblspiker.Text = $"{atak.name} close shot. No! Missed it.";
            else if (secim == 9)
                lblspiker.Text = $"2 point play by {atak.name}, miss… Nice rebound by {reboundalan.name}";
            else if (secim == 10)
                lblspiker.Text = $"Jump shot by {atak.name}, short. Rebounded by {reboundalan.name} ";
            else if (secim == 11)
                lblspiker.Text = $"Inside {atak.name}, No. Great defense from {defans.name} ";
            else if (secim == 12)
                lblspiker.Text = $"{atak.name} on the drive, falling awaaay. No. Rebound:  {reboundalan.name}  ";
            else if (secim == 13)
                lblspiker.Text = $"{defans.name} forced him jumpshot and short.";
            else if (secim == 14)
                lblspiker.Text = $"Jump shot {atak.name}, nice defense by {defans.name}.";

            lblspiker.ForeColor = Color.OrangeRed;
        }

        public void uclukkactispiker()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 18);
            if (secim == 1)
                lblspiker.Text = $"{atak.name} from downtown. No. Not this time.";
            else if (secim == 2)
                lblspiker.Text = $"{atak.name} from downtown, missed it.  ";
            else if (secim == 3)
                lblspiker.Text = $"{atak.name} from long range. Short.";
            else if (secim == 4)
                lblspiker.Text = $"3 point from {atak.name}, no missed the shot.Rebounded by {reboundalan.name} ";
            else if (secim == 5)
                lblspiker.Text = $"{atak.name} finds the open from long range! Short.Rebounded by {reboundalan.name}";
            else if (secim == 6)
                lblspiker.Text = $"Stepback from {atak.name}. Great defense from {defans.name}.";
            else if (secim == 7)
                lblspiker.Text = $"{atak.name} from three! No missed it.Rebounded by {reboundalan.name}";
            else if (secim == 8)
                lblspiker.Text = $"{atak.name}, very long range! Bad shot.";
            else if (secim == 9)
                lblspiker.Text = $"{atak.name} from inside the 28 footline. No good. Rebounded by {reboundalan.name}";
            else if (secim == 10)
                lblspiker.Text = $"Crossover, stepback. From downtown. No good. ";
            else if (secim == 11)
                lblspiker.Text = $"{atak.name} from long range!!!No missed it.Rebounded by {reboundalan.name} ";
            else if (secim == 12)
                lblspiker.Text = $"Nice team work, but no. How can he missed it? Rebounded by {reboundalan.name}  ";
            else if (secim == 13)
                lblspiker.Text = $"{defans.name} forced him jumpshot and short.";
            else if (secim == 14)
                lblspiker.Text = $"Jump shot {atak.name}, nice defense by {defans.name}.Rebounded by {reboundalan.name}";
            else if (secim == 15)
                lblspiker.Text = $"{atak.name} finds the open from long range! Short Defended by {defans.name}.";
            else if (secim == 16)
                lblspiker.Text = $"Hard defense by {defans.name}. 3 point shot missed. Rebounded by {reboundalan.name}";
            else if(secim==17)
                lblspiker.Text = $"Wow. Great defense from {defans.name}.Rebounded by {reboundalan.name}";

            lblspiker.ForeColor = Color.OrangeRed;

        }

        public void uclukhucumrebound()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 8);
            if (secim == 1)
                lblspiker.Text = $"{atak.name} from downtown.No.But {reboundalan.name} takes the offensive rebound";
            else if (secim == 2)
                lblspiker.Text = $"{atak.name} from downtown,missed. {reboundalan.name} takes the offensive rebound  ";
            else if (secim == 3)
                lblspiker.Text = $"{atak.name}, very long range! Bad shot.Offensive rebounded by {reboundalan.name}.";
            else if (secim == 4)
                lblspiker.Text = $"3 point shot from {atak.name}, no missed the shot.Offensive rebounded by {reboundalan.name}. ";
            else if (secim == 5)
                lblspiker.Text = $"{defans.name} forced him jumpshot and short.But {reboundalan.name} takes the offensive rebound";
            else if (secim == 6)
                lblspiker.Text = $"Stepback from {atak.name}. Great defense from {defans.name} but {reboundalan.name} takes the offensive rebound.";
            else if (secim == 7)
                lblspiker.Text = $"{atak.name} from three! No missed it.{reboundalan.name} got the offensive rebound";

            lblspiker.ForeColor = Color.Yellow;


        }

        public void ikilikhucumrebound()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 8);
            if (secim == 1)
                lblspiker.Text = $"{atak.name} from Mid-Range.No.But {reboundalan.name} takes the offensive rebound";
            else if (secim == 2)
                lblspiker.Text = $"{atak.name} from inside,missed. {reboundalan.name} takes the offensive rebound  ";
            else if (secim == 3)
                lblspiker.Text = $"{atak.name} one and one play but no. {reboundalan.name} takes the offensive.";
            else if (secim == 4)
                lblspiker.Text = $"2 point shot from {atak.name} No missed the shot!!Offensive rebounded by {reboundalan.name}. ";
            else if (secim == 5)
                lblspiker.Text = $"{defans.name} forced him jumpshot and short.But {reboundalan.name} takes the offensive rebound";
            else if (secim == 6)
                lblspiker.Text = $"Stepback from {atak.name}. Great defense from {defans.name} but {reboundalan.name} takes the offensive rebound.";
            else if (secim == 7)
                lblspiker.Text = $"{atak.name} from two!No missed it.{reboundalan.name} got the offensive rebound";

            lblspiker.ForeColor = Color.Yellow;


        }

        public void stealspiker()
        {
            Random rnd = new Random();
            int secim = rnd.Next(1, 8);
            if (secim == 1)
                lblspiker.Text = $"{atak.name} lost the ball. Stolen by {defans.name}";
            else if (secim == 2)
                lblspiker.Text = $"{defans.name} stole the ball. Chance to fastbreak. ";
            else if (secim == 3)
                lblspiker.Text = $"Turnover from {atak.name}.";
            else if (secim == 4)
                lblspiker.Text = $"Oh turnover. {atak.name} lost the ball. ";
            else if (secim == 5)
                lblspiker.Text = $"Nice defense by {defans.name}. {atak.name} lost the ball.";
            else if (secim == 6)
                lblspiker.Text = $"Bad pass from {atak.name}. {defans.name} has the ball now..";
            else if (secim == 7)
                lblspiker.Text = $"Poor pass. {defans.name} stole it";

            lblspiker.ForeColor = Color.OrangeRed;
         }
        int skora = 0;
        int skorb = 0;
        bool hucumreboundu = false;

        public void aataktv()
        {
            pbatakimi.Image = atak.foto;
            pbbtakimi.Image = defans.foto;
            lbloyuncu1.Text = atak.name;
            lbloyuncu2.Text= defans.name;
            lbltur1.Text = "OFF";
            lbltur2.Text = "DEF";
            lbl1point.Text = atak.Offoverall.ToString();
            lbl2point.Text = defans.Defoverall.ToString();
            lbltur1.ForeColor = Color.Green;
            lbltur2.ForeColor = Color.Red;
            lbl1point.ForeColor = Color.Green;
            lbl2point.ForeColor = Color.Red;
        }
        
        public void sayises()
        {
            var importer = new RawSourceWaveStream(Properties.Resources.slamdunk1, new WaveFormat());
            soundFx = new WaveOut();
            soundFx.Init(importer);
            soundFx.Play();
         }
        public void slamses()
        {
            var importer = new RawSourceWaveStream(Properties.Resources.slam5, new WaveFormat());
            soundFx = new WaveOut();
            soundFx.Init(importer);
            soundFx.Play();


        }

        public void kactises()
        {
            var importer = new RawSourceWaveStream(Properties.Resources.kacirdi, new WaveFormat());
            soundFx = new WaveOut();
            soundFx.Init(importer);
            soundFx.Play();
        }

        public void uclukses()
        {
            var importer = new RawSourceWaveStream(Properties.Resources.ucluk, new WaveFormat());
            soundFx = new WaveOut();
            soundFx.Init(importer);
            soundFx.Play();
        }

        private void gorunmezyap()
        {
            lbl1.Visible=false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
        }


        private int ucluk = 9;

        private void secilihucumcua()
        {
            if (atak.name == akadro[0].name)
            {
                pick1a.Image = Resources.top;
                pick1a.Visible = true; 
            }
            else if (atak.name == akadro[1].name)
            {
                pick2a.Image = Resources.top;
                pick2a.Visible = true;
            }
            else if (atak.name == akadro[2].name)
            {
                pick3a.Image = Resources.top;
                pick3a.Visible = true; 
            }
            else if (atak.name == akadro[3].name)
            {
                pick4a.Image = Resources.top;
                pick4a.Visible = true;
            }
            else if (atak.name == akadro[4].name)
            {
                pick5a.Image = Resources.top;
                pick5a.Visible = true;
            }
        }

        private void secilihucumcub()
        {
            if (atak.name == rakadro[0].name)
            {
                pick1b.Image = Resources.top;
                pick1b.Visible = true;
            }
            else if (atak.name == rakadro[1].name)
            {
                pick2b.Image = Resources.top;
                pick2b.Visible = true;
            }
            else if (atak.name == rakadro[2].name)
            {
                pick3b.Image = Resources.top;
                pick3b.Visible = true;
            }
            else if (atak.name == rakadro[3].name)
            {
                pick4b.Image = Resources.top;
                pick4b.Visible = true;
            }
            else if (atak.name == rakadro[4].name)
            {
                pick5b.Image = Resources.top;
                pick5b.Visible = true;
            }
        }
        private void secilisavunmacia()
        {
            if (defans.name == rakadro[0].name)
            {
                pick1b.Image = Resources.hand;
                pick1b.Visible = true;
            }
            else if (defans.name == rakadro[1].name)
            {
                pick2b.Image = Resources.hand;
                pick2b.Visible = true;
            }
            else if (defans.name == rakadro[2].name)
            {
                pick3b.Image = Resources.hand;
                pick3b.Visible = true;
            }
            else if (defans.name == rakadro[3].name)
            {
                pick4b.Image = Resources.hand;
                pick4b.Visible = true;
            }
            else if (defans.name == rakadro[4].name)
            {
                pick5b.Image = Resources.hand;
                pick5b.Visible = true;
            }
        }
        private void secilisavunmacib()
        {
            if (defans.name == akadro[0].name)
            {
                pick1a.Image = Resources.hand;
                pick1a.Visible = true;
            }
            else if (defans.name == akadro[1].name)
            {
                pick2a.Image = Resources.hand;
                pick2a.Visible = true;
            }
            else if (defans.name == akadro[2].name)
            {
                pick3a.Image = Resources.hand;
                pick3a.Visible = true;
            }
            else if (defans.name == akadro[3].name)
            {
                pick4a.Image = Resources.hand;
                pick4a.Visible = true;
            }
            else if (defans.name == akadro[4].name)
            {
                pick5a.Image = Resources.hand;
                pick5a.Visible = true;
            }
        }

        private void hucumisaretsifirla()
        {
            pick1a.Visible = false;
            pick2a.Visible = false;
            pick3a.Visible = false;
            pick4a.Visible = false;
            pick5a.Visible = false;
        }
        private void defansisaretsifirla()
        {
            pick1b.Visible = false;
            pick2b.Visible = false;
            pick3b.Visible = false;
            pick4b.Visible = false;
            pick5b.Visible = false;

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            hucumisaretsifirla();
            defansisaretsifirla();


            lblsonuc.BackColor = Color.Black;
            if (hucumreboundu == true)
            {
                hucumreboundu = false;
                Random rnd=new Random();
                int spiker = rnd.Next(1, 6);
                if(spiker==1)
                    lblspiker.Text = $"{team2.name} gearing up for the attack again!";
                else if (spiker==2)
                    lblspiker.Text = $"{team2.name} will attack again";
                else if (spiker == 3)
                    lblspiker.Text = $"{team2.name} has another chance to attack";
                else if (spiker == 4)
                    lblspiker.Text = $"{team2.name} setting up another play";
                else if (spiker == 5)
                    lblspiker.Text = $"{team2.name} has another chance ";

                goto Sonaatla;

            }
            staminaa();
            hucumcusec();
            if(secilitaktik.name==staticdatabase.lists.isolation.name)
            {
                isoayarlari();
            }
            if(secilitaktik.name == staticdatabase.lists.pickandroll.name)
            {
                pickandrollayarlari();
            }
            if(secilitaktik.name == staticdatabase.lists.postup.name)
            {
                postupayarlari();
            }
            if(secilitaktik.name == staticdatabase.lists.paceandspace.name)
            {
                paceandspaceayarlari();
            }
            if(secilitaktik.name == staticdatabase.lists.slow.name)
            {
                slowayarlari();
            }
            if(secilitaktik.name == staticdatabase.lists.three.name)
            {
                uclukayarlari();
            }
            if(secilitaktik.name == staticdatabase.lists.normal.name)
            {
                normalayarlari();
            }
            if(secilitaktik.name== staticdatabase.lists.pickandroll2.name)
            {
                pickandroll2();
            }



            staminagoster();
            oransinirlayici();
            oyuncudegisikligi();
            oyuncuresimleri();
            pozisyonsınırlayici();
            hucumisaretsifirla();
            defansisaretsifirla();
            secilihucumcua();
            secilisavunmacia();
            lblyon.Text = "=>";
            int sinir = 100;
            if((skorb-skora)>20)
            {
                sinir = 120;
            }
            else if((skorb-skora)>10)
            {
                sinir = 110;
            }
            aataktv();

            int stealsecici = 0;
            for (int i = 0; i < 15; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(atak.asist, 120);
                int b = rnd.Next(defans.steal, 120);
                if (a > b)
                {
                    stealsecici++;
                }
            }
            if (stealsecici < steal)
            {
                stealspiker();
                
                lblsonuc2.Text = "Turnover!!!";
                lblsonuc2.ForeColor = Color.Red;
                defans.SSteal++;
                hucumreboundu = false;
               

                goto Sonaatla;
            }
            int ucluksecici = 0;
            for (int i = 0; i < 15; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(atak.ucluk, 110);
                int b = rnd.Next(atak.ikilik, 110);
                if (a > b)
                {
                    ucluksecici++;
                }
            }
            if (secilitaktik == staticdatabase.lists.postup)
            {
                ucluksecici = 0;
            }

            if (ucluksecici >= ucluk + atak.Xpoint3)
            {
                //ucluksecildi

                atak.Xpoint3++;
                int uclukgirdimi = 0;
                for (int j = 0; j < 15; j++)
                {
                    Random rnd = new Random();
                    int a = rnd.Next(atak.ucluk-atak.stamina-poslimit, sinir);
                    int b = rnd.Next(defans.block, 100);
                    if (a > b)
                    {
                        uclukgirdimi++;
                    }
                }
                if (uclukgirdimi > ucluks + atak.Xpoint)
                {
                    
                    atak.Xpoint++;
                    atak.SPoint = atak.SPoint + 3;
                    atak.Sgirenucluk++;
                    atak.Stoplamucluk++;
                    skora = skora + 3;
                    asistsecicia();
                    if (asistci.name != atak.name)
                    {
                        asistci.SAsist++;
                        uclukgirdispikerasist();
                        hucumreboundu = false;
                        
                        
                        lblsonuc2.Text = "+3 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;
                       


                    }
                    else
                    {
                        
                        uclukgirdispiker();
                       


                        lblsonuc2.Text = "+3 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;



                    }
                    hucumreboundu = false;

                    goto Sonaatla;
                }
                else
                {


                    atak.Xpoint--;
                    atak.Stoplamucluk++;
                    
                    int reboundsecici = 0;
                    for(int i=0;i<15;i++)
                    {
                        Random rnd = new Random();
                        int a = rnd.Next(takimrebounda, 110);
                        int b = rnd.Next(takimreboundb, 110);
                        if(a>b)
                        {
                            reboundsecici++;
                        }
                        
                    }
                    if(reboundsecici>10)
                    {
                        reboundcua();
                        uclukhucumrebound();
                        hucumreboundu = true;
                        
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;
             


                    }
                    else
                    {
                        reboundcub();
                        uclukkactispiker();
                        hucumreboundu = false;
                        reboundalan.SRebound++;
                        
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;


                    }


                    goto Sonaatla;
                }
            }
            else if (ucluksecici < 9 + atak.Xpoint3)
            {
                //ikiliksecildi

                atak.Xpoint3--;
                int ikilikgirdimi = 0;
                for (int j = 0; j < 15; j++)
                {
                    Random rnd = new Random();
                    int a = rnd.Next(atak.ikilik-atak.stamina- poslimit, sinir);
                    int b = rnd.Next(defans.block, 100);
                    if (a > b)
                    {
                        ikilikgirdimi++;
                    }
                }
                if (ikilikgirdimi > ikiliks + atak.Xpoint)
                {
                    
                    atak.Xpoint++;
                    atak.SPoint = atak.SPoint + 2;
                    atak.Stoplamikilik++;
                    atak.Sgirenikilik++;
                    asistsecicia();
                    if(atak.name!=asistci.name)
                    {
                        ikilikgirdiasist();
                        asistci.SAsist++;
                        hucumreboundu = false;
                        
                        lblsonuc2.Text = "+2 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;


                    }
                    else
                    {
                        spikerikilikgirdi();
                        hucumreboundu = false;
                        
                        lblsonuc2.Text = "+2 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;


                    }
                    
                    skora = skora + 2;
                    goto Sonaatla;
                }
                else
                {
                    
                    atak.Xpoint--;
                    atak.Stoplamikilik++;
                    
                    int reboundsecici = 0;

                    for (int i = 0; i < 15; i++)
                    {
                        Random rnd = new Random();
                        int a = rnd.Next(takimrebounda, 110);
                        int b = rnd.Next(takimreboundb, 110);
                        if (a > b)
                        {
                            reboundsecici++;
                        }

                    }
                    if (reboundsecici > 10)
                    {
                        reboundcua();
                        ikilikhucumrebound();
                        hucumreboundu = true;
                        reboundalan.SRebound++;
                        
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;


                    }
                    else
                    {
                        reboundcub();
                        ikilikkactispiker();
                        reboundalan.SRebound++;
                        hucumreboundu = false;
                        
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;


                    }

                    goto Sonaatla;
                }

            }
        Sonaatla:
            skorboardyenile();
            oyuncustatsyenile();
            timer2.Start();
            timer1.Stop();

            
        }

        public void btakimiatak()
        {
            pbatakimi.Image = defans.foto;
            pbbtakimi.Image = atak.foto;
            lbloyuncu1.Text = defans.name;
            lbloyuncu2.Text = atak.name;
            lbltur1.Text = "DEF";
            lbltur2.Text = "OFF";
            lbl1point.Text = defans.steal.ToString();
            lbl2point.Text = atak.Overall.ToString();
            lbltur1.ForeColor = Color.Red;
            lbltur2.ForeColor = Color.Green;
            lbl1point.ForeColor = Color.Red;
            lbl2point.ForeColor = Color.Green;

        }

        private int ucluksiniri = 8;
        private int ikiliksiniri = 7;
        private void timer2_Tick(object sender, EventArgs e)
            {
            hucumisaretsifirla();
            defansisaretsifirla();

            lblsonuc.BackColor = Color.Black;

            if (hucumreboundu == true)
            {
                hucumreboundu = false;
                Random rnd = new Random();
                int spiker = rnd.Next(1, 6);
                if (spiker == 1)
                    lblspiker.Text = $"{team1.name} gearing up for the attack again!";
                else if (spiker == 2)
                    lblspiker.Text = $"{team1.name} will attack again";
                else if (spiker == 3)
                    lblspiker.Text = $"{team1.name} has another chance to attack";
                else if (spiker == 4)
                    lblspiker.Text = $"{team1.name} setting up another play";
                else if (spiker == 5)
                    lblspiker.Text = $"{team1.name} has another chance ";


                goto Sonaatla;

            }
            staminab();
            hucumcusecb();
            oransinirlayici();
            btakimiatak();
            lblyon.Text = "<=";


            defansisaretsifirla();
            secilihucumcub();
            secilisavunmacib();
            

            int sinir = 100;
            if ((skora - skorb) > 20)
            {
                sinir = 120;
            }
            else if ((skora - skorb) > 10)
            {
                sinir = 110;
            }
            int stealsecici = 0;
            for (int i = 0; i < 15; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(atak.asist, 120);
                int b = rnd.Next(defans.steal, 120);
                if (a > b)
                {
                    stealsecici++;
                }
            }
            if (stealsecici < 3)
            {
                stealspiker();


                defans.SSteal++;
                hucumreboundu = false;
                lblsonuc2.Text = "Turnover";
                lblsonuc2.ForeColor = Color.Red;
                
                goto Sonaatla;
            }
            if(doubleteam==true)
            {
                doubleteamayarlari();
            }


            int ucluksecici = 0;
            for (int i = 0; i < 15; i++)
            {
                Random rnd = new Random();
                int a = rnd.Next(atak.ucluk, 110);
                int b = rnd.Next(atak.ikilik, 110);
                if (a > b)
                {
                    ucluksecici++;
                }
            }
            if (ucluksecici >= 9 + atak.Xpoint3)
            {
                //ucluksecildi

                atak.Xpoint3++;
                int uclukgirdimi = 0;
                for (int j = 0; j < 15; j++)
                {
                    Random rnd = new Random();
                    int a = rnd.Next(atak.ucluk-atak.stamina, sinir);
                    int b = rnd.Next(defans.block, 100);
                    if (a > b)
                    {
                        uclukgirdimi++;
                    }
                }
                if (uclukgirdimi > ucluksiniri + atak.Xpoint)
                {
                    
                    atak.Xpoint++;
                    atak.SPoint = atak.SPoint + 3;
                    atak.Sgirenucluk++;
                    atak.Stoplamucluk++;
                    skorb = skorb + 3;
                    asistsecicib();
                    if(atak.name!=asistci.name)
                    {
                       
                        uclukgirdispikerasist();
                        asistci.SAsist++;
                        hucumreboundu = false;
                        

                        lblsonuc2.Text = "+3 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;




                    }
                    else
                    {

                      
                        uclukgirdispiker();
                        

                        hucumreboundu = false;
                        lblsonuc2.Text = "+3 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;



                    }


                    goto Sonaatla;
                }
                else
                {
                    
                    atak.Xpoint--;
                    atak.Stoplamucluk++;
                    int reboundsecici = 0;

                    for (int i = 0; i < 15; i++)
                    {
                        Random rnd = new Random();
                        int a = rnd.Next(takimreboundb, 110);
                        int b = rnd.Next(takimrebounda, 110);
                        if (a > b)
                        {
                            reboundsecici++;
                        }

                    }
                    if (reboundsecici > 10)
                    {
                        reboundcub();
                        uclukhucumrebound();
                        hucumreboundu = true;
                        reboundalan.SRebound++;
                        
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;



                    }
                    else
                    {
                        reboundcua();
                        uclukkactispiker();
                        hucumreboundu = false;
                        reboundalan.SRebound++;
                      
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;



                    }


                    goto Sonaatla;
                }
            }
            else if (ucluksecici < 9 + atak.Xpoint3)
            {
                //ikiliksecildi
                atak.Xpoint3--;

                int ikilikgirdimi = 0;
                for (int j = 0; j < 15; j++)
                {
                    Random rnd = new Random();
                    int a = rnd.Next(atak.ikilik-atak.stamina, sinir);
                    int b = rnd.Next(defans.block, 100);
                    if (a > b)
                    {
                        ikilikgirdimi++;
                    }
                }
                if (ikilikgirdimi > ikiliksiniri + atak.Xpoint)
                {
 
                    
                    atak.Xpoint++;
                    atak.SPoint = atak.SPoint + 2;
                    atak.Stoplamikilik++;
                    atak.Sgirenikilik++;
                    asistsecicib();
                    if(asistci.name!=atak.name)
                    {
                        ikilikgirdiasist();
                        asistci.SAsist++;
                        hucumreboundu = false;
                        
                        lblsonuc2.Text = "+2 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;

                    }
                    else
                    {
                        spikerikilikgirdi();
                        
                        hucumreboundu = false;
                        lblsonuc2.Text = "+2 Point";
                        lblsonuc2.ForeColor = Color.GreenYellow;

                    }
                    
                    skorb = skorb + 2;
                    goto Sonaatla;
                }
                else
                {
                    
                    atak.Xpoint--;
                    atak.Stoplamikilik++;
                    int reboundsecici = 0;

                    for (int i = 0; i < 15; i++)
                    {
                        Random rnd = new Random();
                        int a = rnd.Next(takimreboundb, 110);
                        int b = rnd.Next(takimrebounda, 110);
                        if (a > b)
                        {
                            reboundsecici++;
                        }

                    }
                    if (reboundsecici > 10)
                    {
                        reboundcub();
                        ikilikhucumrebound(); 
                        
                        hucumreboundu = true;
                        reboundalan.SRebound++;
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;


                    }
                    else
                    {
                        reboundcua();
                        ikilikkactispiker();
                        
                        hucumreboundu = false;
                        reboundalan.SRebound++;
                        lblsonuc2.Text = "Miss!!";
                        lblsonuc2.ForeColor = Color.OrangeRed;
 


                    }


                    goto Sonaatla;
                }

            }
        Sonaatla:
            skorboardyenile();
            oyuncustatsyenile();
            timer1.Start();
            timer2.Stop();

        }
        int suredak = 11;
        int suresan = 59;
        int periyot = 1;
        private void timer3_Tick(object sender, EventArgs e)
        {
            lblperiyot.Text = $"{periyot} P";
            suresan--;
            if(suresan == 0)
            {
                suresan = 59;
                suredak--;
            }
            lblmin.Text=suredak.ToString();
            lblsec.Text=suresan.ToString();
            if(suredak==0 && suredak==0)
            {
                
                timer4.Start();
                timer3.Stop();
                suresan = 59;
                
            }

        }

        private void timer4_Tick(object sender, EventArgs e)
        {

            timer3.Stop();
            suresan--;
            lblsec.Text = suresan.ToString();
            if(suresan==0 )
            {
                btnstart.Visible = true;
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                lblspiker.Text = $"{periyot}. Quarter is over! What a match";
                periyot++;
                lblsec.Text = "00";
                lblmin.Text = "12";
                suresan = 59;
                suredak = 11;
                timer4.Stop();
            }
            



        }
        public bool isolation = false;
        public bool pickandroll = false;
        public bool postup = false;
        public bool pace = false;
        public bool slow = false;

        private void taktikbutonsifirla()
        {
            pbtaktiknormal.Image = team1.standart.resim;
            pbtaktik1.Image = team1.taktik1.resim;
            pbtaktik2.Image = team1.taktik2.resim;
            pbtaktik3.Image = team1.taktik3.resim;
            pbtactic4.Image = team1.taktik4.resim;

        }

        private void offtaktikekran()
        {
            pbaktifoff.Image = secilitaktik.resim;
            offtacticpros.Text = secilitaktik.pros;
            offtacticcons.Text=secilitaktik.cons;

        }

        
        private void pbtaktiknormal_Click(object sender, EventArgs e)
        {

            normaltaktikayarlari();

        }
        private void normaltaktikayarlari()
        {
            taktikbutonsifirla();
            normalayarlari();

            secilitaktik = team1.standart;
            pbtaktiknormal.Image = team1.standart.resim2;
            offtaktikekran();
            isoresimsifirlama();
        }


        private void pbtaktik1_Click(object sender, EventArgs e)
        {
            taktikbutonsifirla();
            normalayarlari();
            pbtaktiknormal.Image = team1.standart.resim;
            secilitaktik = team1.taktik1;
            pbtaktik1.Image = team1.taktik1.resim2;
            lblaktiftaktik.Text = team1.taktik1.name;
            offtaktikekran();
            if(secilitaktik.name==staticdatabase.lists.isolation.name)
            {
                isoresim();
            }
            else
            {
                isoresimsifirlama();
            }
        }

        private void pbtaktik2_Click(object sender, EventArgs e)
        {
            taktikbutonsifirla();
            normalayarlari();
            pbtaktiknormal.Image = team1.standart.resim;
            secilitaktik = team1.taktik2;
            pbtaktik2.Image = team1.taktik2.resim2;
            lblaktiftaktik.Text = team1.taktik2.name;
            offtaktikekran();
            if (secilitaktik.name == staticdatabase.lists.isolation.name)
            {
                isoresim();
            }
            else
            {
                isoresimsifirlama();
            }
        }

        private void pbtaktik3_Click(object sender, EventArgs e)
        {
            taktikbutonsifirla();
            normalayarlari();
            pbtaktiknormal.Image = team1.standart.resim;
            secilitaktik = team1.taktik3;
            pbtaktik3.Image = team1.taktik3.resim2;
            lblaktiftaktik.Text = team1.taktik3.name;
            offtaktikekran();
            if (secilitaktik.name == staticdatabase.lists.isolation.name)
            {
                isoresim();
            }
            else
            {
                isoresimsifirlama();
            }
        }

        private void pbtactic4_Click(object sender, EventArgs e)
        {
            taktikbutonsifirla();
            normalayarlari();
            pbtaktiknormal.Image = team1.standart.resim;
            secilitaktik = team1.taktik4;
            pbtactic4.Image = team1.taktik4.resim2;
            lblaktiftaktik.Text = team1.taktik4.name;
            offtaktikekran();
            if (secilitaktik.name == staticdatabase.lists.isolation.name)
            {
                isoresim();
            }
            else
            {
                isoresimsifirlama();
            }
        }

        tactics secilitaktik = new tactics();
        public void taktikleriyerlestir()
        {
            pbtaktiknormal.Image = team1.standart.resim;
            pbtaktik1.Image = team1.taktik1.resim;
            pbtaktik2.Image = team1.taktik2.resim;
            pbtaktik3.Image = team1.taktik3.resim;
            pbtactic4.Image = team1.taktik4.resim;
            secilitaktik = team1.standart;
            lblaktiftaktik.Text = team1.standart.name;
        }
        oyuncu isoplayer = new oyuncu();

        public void normalayarlari()
        {
            secilitaktik = team1.standart;
            pbtaktiknormal.Image = team1.standart.resim2;
            lblaktiftaktik.Text = team1.standart.name;
            timer1.Interval = 2500;
            timer2.Interval = 2500;
            ucluk = 9;
            steal = 3;
            ucluks = 8;
            ikiliks = 7;
            isolation = false;
            pictureboxborderduzelt();

        }

        private void pictureboxborderduzelt()
        {
            pbplayer1.BorderStyle = BorderStyle.None;
            pbplayer2.BorderStyle = BorderStyle.None;
            pbplayer3.BorderStyle = BorderStyle.None;
            pbplayer4.BorderStyle = BorderStyle.None;
            pbplayer5.BorderStyle = BorderStyle.None;

        }
        
        public void isoayarlari()
        {
            isolation = true;
            atak = isoplayer;
            if (atak is null)
            {
                atak = akadro[0];
                pbplayer1.BorderStyle = BorderStyle.Fixed3D;
            }
            isoresim();

            atak.stamina += 3;
            
        }
        private void isoresim()
        {
            if (isoplayer.name == akadro[0].name)
            {
                iso1.Visible = true;
            }
            else if (isoplayer.name == akadro[1].name)
            {
                iso2.Visible = true;
            }
            else if (isoplayer.name == akadro[2].name)
            {
                iso3.Visible = true;
            }
            else if (isoplayer.name == akadro[3].name)
            {
                iso4.Visible = true;
            }
            else if (isoplayer.name == akadro[4].name)
            {
                iso5.Visible = true;
            }
        }
        private void isoresimsifirlama()
        {
            iso1.Visible = false;
            iso2.Visible = false;
            iso3.Visible = false;
            iso4.Visible = false;
            iso5.Visible = false;
        }


        public void pickandrollayarlari()
        {
           
            Random rand = new Random();
            int secim = rand.Next(0, 5);
            if (secim == 0)
                defans = rakadro[0];
            else if(secim== 1)
                defans= rakadro[1];
            else if(secim== 2)
                defans=rakadro[2];
            else if(secim== 3)
                defans= rakadro[3];
            else if(secim== 4)
                defans= rakadro[4];
            atak.stamina++;
        }
        public void postupayarlari()
        {
           
            Random rand = new Random();
            int secim = rand.Next(3, 5);
            if (secim == 3)
            {
                atak = akadro[3];
                defans = rakadro[3];
            }
            else if (secim == 4)
            { atak = akadro[4];
                defans = rakadro[4];
            }

            atak.stamina++;
        }

        private int steal = 3;
        private int ucluks = 8;
        private int ikiliks = 7;
        public void paceandspaceayarlari()
        {
            steal = 7;
            timer1.Interval = 2500;
            timer2.Interval = 1700;
            ucluks = 7;
            ikiliks = 6;
        }
        public void slowayarlari()
        {
            
            timer1.Interval = 2500;
            timer2.Interval = 3500;
        }

        private void uclukayarlari()
        {
            
            ucluk = 6;
            atak.stamina++;


        }

        private void pickandroll2()
        {
            Random random = new Random();
            int secim=random.Next(0,5);
            if (secim == 0)
            {
                akadro[0].stamina++;
            }
            else if (secim == 1)
            {
                akadro[1].stamina++;
            }
            else if (secim == 2)
            {
                akadro[2].stamina++;
            }
            else if (secim == 3)
            {
                akadro[3].stamina++;
            }
            else if (secim == 4)
            {
                akadro[4].stamina++;
            }
            ucluks = 7;
            ikiliks = 6;
        }


        private void pbatakimi_Click(object sender, EventArgs e)
        {

        }

        private void pbefekt_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label73_Click_1(object sender, EventArgs e)
        {

        }

        private void doubleteamsıfır()
        {
            dt1.Visible = false;
            dt2.Visible = false;
            dt3.Visible = false;
            dt4.Visible = false;
            dt5.Visible = false;
        }
        private bool doubleteam = false;
        private void doubleteamayarlari()
        {
            
            if (doubleteamoyuncu.name == atak.name)
            {
                ucluksiniri = 10;
                ikiliksiniri = 9;
            }
            else
            {
                ucluksiniri = 6;
                ikiliksiniri = 5;
            }
           
        }
        private void doubleteamresimgoster()
        {
            if (doubleteamoyuncu.name == rakadro[0].name)
            {
                dt1.Visible = true;
            }
            else if(doubleteamoyuncu.name == rakadro[1].name)
            {
                dt2.Visible = true;
            }
            else if (doubleteamoyuncu.name == rakadro[2].name)
            {
                dt3.Visible = true;
            }
            else if (doubleteamoyuncu.name == rakadro[3].name)
            {
                dt4.Visible = true;
            }
            else if (doubleteamoyuncu.name == rakadro[4].name)
            {
                dt5.Visible = true;
            }

        }


        private void pbplayer11_Click(object sender, EventArgs e)
        {
            doubleteamoyuncu = rakadro[0];
            doubleteamsıfır();
            if(doubleteam==true)
            {
                dt1.Visible=true;
            }

            
        }

        private void pbplayer12_Click(object sender, EventArgs e)
        {
            doubleteamoyuncu = rakadro[1];
            doubleteamsıfır();
            if (doubleteam == true)
            {
                dt2.Visible = true;
            }

        }

        private void pbplayer13_Click(object sender, EventArgs e)
        {
            doubleteamoyuncu = rakadro[2];
            doubleteamsıfır();
            if (doubleteam == true)
            {
                dt3.Visible = true;
            }

        }

        private void pbplayer14_Click(object sender, EventArgs e)
        {
            doubleteamoyuncu = rakadro[3];
            doubleteamsıfır();
            if (doubleteam == true)
            {
                dt4.Visible = true;
            }

        }

        private void pbplayer15_Click(object sender, EventArgs e)
        {
            doubleteamoyuncu = rakadro[4];
            doubleteamsıfır();
            if (doubleteam == true)
            {
                dt5.Visible = true;
            }

        }

        private void gpsub2_Enter(object sender, EventArgs e)
        {

        }

        private void timersub1_Tick(object sender, EventArgs e)
        {
            gpsub1gizle();
            timersub1.Stop();
        }

        private void timersub2_Tick(object sender, EventArgs e)
        {
            gpsub2gizle();
            timersub2.Stop();
        }

        tactics deftactic = new tactics();


        private void pbmantoman_Click(object sender, EventArgs e)
        {

            mantomanayarlari();
            

        }

        private void mantomanayarlari()
        {
            defpbsifirla();
            pbmantoman.Image = Resources.mantoman2;
            deftactic = staticdatabase.lists.mantoman;
            deftaktikekran();
            ucluksiniri = 8;
            ikiliksiniri = 7;
            doubleteam = false;
            zonedef = false;
            mantoman = true;
            doubleteamsıfır();
        }
        private bool zonedef = false;
        private bool mantoman = true;
        private void pbzone_Click(object sender, EventArgs e)
        {
            defpbsifirla();
            pbzone.Image= Resources.zone2;
            deftactic = staticdatabase.lists.zone;
            deftaktikekran();
            ikiliksiniri = 9;
            ucluksiniri = 6;
            doubleteam = false;
            zonedef = true;
            mantoman = false;
            doubleteamsıfır();
        }
        oyuncu doubleteamoyuncu = new oyuncu();
        private void pbdoubleteam_Click(object sender, EventArgs e)
        {
            defpbsifirla();
            pbdoubleteam.Image= Resources.doubleteam2;
            deftactic = staticdatabase.lists.doubleteam;
            deftaktikekran();

            doubleteam = true;
            zonedef = false;
            mantoman = false;
            doubleteamoyuncu = rakadro[0];
            doubleteamresimgoster();
        }
        private void defpbsifirla()
        {
            pbmantoman.Image = Resources.mantoman;
            pbzone.Image = Resources.zone;
            pbdoubleteam.Image = Resources.doubleteam;
        }
        private void deftaktikekran()
        {
            pbaktifdef.Image = deftactic.resim;
            lbldefsecilitaktikpros.Text = deftactic.pros;
            lbldefsecilitaktikcons.Text=deftactic.cons;
            lblaktifdef.Text = deftactic.name;
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
