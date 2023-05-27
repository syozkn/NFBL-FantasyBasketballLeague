using Bigbang.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigbang
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public int capspace = 0;
        private void Form5_Load(object sender, EventArgs e)
        {
            bizimtakim();

            if (staticdatabase.lists.transfer == true)
            {
                rastgeleoyuncusecimi();
            }
            capspace = staticdatabase.teams.secilentakim.salary;
            gelenoyuncular();
            infolabel();
            tradebutongoster();
            staticdatabase.lists.macyapildimi = true;
            oyuncusecimi = false;
            
        }


        public void infolabel()
        {
            lblinfo.Text = "Select players to trade by clicking pictures";
            lblcapspace.Text = capspace.ToString();
        }




        oyuncu solsecilen=new oyuncu();

        public void bizimtakim()
        {
            pictureBox1.Image = staticdatabase.teams.secilentakim.pg1.foto;
            pictureBox2.Image = staticdatabase.teams.secilentakim.sg1.foto;
            pictureBox3.Image = staticdatabase.teams.secilentakim.sf1.foto;
            pictureBox4.Image = staticdatabase.teams.secilentakim.pf1.foto;
            pictureBox5.Image = staticdatabase.teams.secilentakim.c1.foto;
            pictureBox6.Image = staticdatabase.teams.secilentakim.pg2.foto;
            pictureBox7.Image = staticdatabase.teams.secilentakim.sg2.foto;
            pictureBox8.Image = staticdatabase.teams.secilentakim.sf2.foto;
            pictureBox9.Image = staticdatabase.teams.secilentakim.pf2.foto;
            pictureBox10.Image = staticdatabase.teams.secilentakim.c2.foto;

            labelisim1.Text = staticdatabase.teams.secilentakim.pg1.name;
            labelisim2.Text = staticdatabase.teams.secilentakim.sg1.name;
            labelisim3.Text = staticdatabase.teams.secilentakim.sf1.name;
            labelisim4.Text = staticdatabase.teams.secilentakim.pf1.name;
            labelisim5.Text = staticdatabase.teams.secilentakim.c1.name;
            labelisim6.Text = staticdatabase.teams.secilentakim.pg2.name;
            labelisim7.Text = staticdatabase.teams.secilentakim.sg2.name;
            labelisim8.Text = staticdatabase.teams.secilentakim.sf2.name;
            labelisim9.Text = staticdatabase.teams.secilentakim.pf2.name;
            labelisim10.Text = staticdatabase.teams.secilentakim.c2.name;

            labelwage1.Text = staticdatabase.teams.secilentakim.pg1.salary.ToString();
            labelwage2.Text = staticdatabase.teams.secilentakim.sg1.salary.ToString();
            labelwage3.Text = staticdatabase.teams.secilentakim.sf1.salary.ToString();
            labelwage4.Text = staticdatabase.teams.secilentakim.pf1.salary.ToString();
            labelwage5.Text = staticdatabase.teams.secilentakim.c1.salary.ToString();
            labelwage6.Text = staticdatabase.teams.secilentakim.pg2.salary.ToString();
            labelwage7.Text = staticdatabase.teams.secilentakim.sg2.salary.ToString();
            labelwage8.Text = staticdatabase.teams.secilentakim.sf2.salary.ToString();
            labelwage9.Text = staticdatabase.teams.secilentakim.pf2.salary.ToString();
            labelwage10.Text = staticdatabase.teams.secilentakim.c2.salary.ToString();

            labelpos1.Text= staticdatabase.teams.secilentakim.pg1.pozisyon.ToString();
            labelpos2.Text = staticdatabase.teams.secilentakim.sg1.pozisyon.ToString();
            labelpos3.Text = staticdatabase.teams.secilentakim.sf1.pozisyon.ToString();
            labelpos4.Text = staticdatabase.teams.secilentakim.pf1.pozisyon.ToString();
            labelpos5.Text = staticdatabase.teams.secilentakim.c1.pozisyon.ToString();
            labelpos6.Text = staticdatabase.teams.secilentakim.pg2.pozisyon.ToString();
            labelpos7.Text = staticdatabase.teams.secilentakim.sg2.pozisyon.ToString();
            labelpos8.Text = staticdatabase.teams.secilentakim.sf2.pozisyon.ToString();
            labelpos9.Text = staticdatabase.teams.secilentakim.pf2.pozisyon.ToString();
            labelpos10.Text = staticdatabase.teams.secilentakim.c2.pozisyon.ToString();

            labeloverall1.Text = staticdatabase.teams.secilentakim.pg1.Overall.ToString();
            labeloverall2.Text = staticdatabase.teams.secilentakim.sg1.Overall.ToString();
            labeloverall3.Text = staticdatabase.teams.secilentakim.sf1.Overall.ToString();
            labeloverall4.Text = staticdatabase.teams.secilentakim.pf1.Overall.ToString();
            labeloverall5.Text = staticdatabase.teams.secilentakim.c1.Overall.ToString();
            labeloverall6.Text = staticdatabase.teams.secilentakim.pg2.Overall.ToString();
            labeloverall7.Text = staticdatabase.teams.secilentakim.sg2.Overall.ToString();
            labeloverall8.Text = staticdatabase.teams.secilentakim.sf2.Overall.ToString();
            labeloverall9.Text = staticdatabase.teams.secilentakim.pf2.Overall.ToString();
            labeloverall10.Text = staticdatabase.teams.secilentakim.c2.Overall.ToString();

        }

        public void gelenoyuncular()
        {
            pbsag1.Image = o1.foto;
            pbsag2.Image = o2.foto;
            pbsag3.Image = o3.foto;
            pbsag4.Image = o4.foto;
            pbsag5.Image= o5.foto;
            groupBox2.Text = o1.name;
            groupBox3.Text = o2.name;
            groupBox4.Text = o3.name;
            groupBox5.Text = o4.name;
            groupBox6.Text = o5.name;
        }
        int secildi = 0;
        int eksi = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.pg1;
            solsecim();
            secildi = 1;
            solsecildimi = true;
            tradebutongoster();
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.sg1;
            solsecim();
            secildi = 2;
            solsecildimi=true;
            tradebutongoster();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.sf1;
            solsecim();
            secildi = 3;
            solsecildimi = true;
            tradebutongoster();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.pf1;
            solsecim();
            secildi = 4;
            solsecildimi = true;
            tradebutongoster();

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.c1;
            solsecim();
            secildi = 5;
            solsecildimi = true;
            tradebutongoster();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.pg2;
            solsecim();
            secildi = 6;
            solsecildimi = true;
            tradebutongoster();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.sg2;
            solsecim();
            secildi = 7;
            solsecildimi = true;
            tradebutongoster();

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.sf2;
            solsecim();
            secildi = 8;
            solsecildimi = true;
            tradebutongoster();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.pf2;
            solsecim();
            secildi = 9;
            solsecildimi = true;
            tradebutongoster();

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            solsecilen = staticdatabase.teams.secilentakim.c2;
            solsecim();
            secildi = 10;
            solsecildimi = true;
            tradebutongoster();

        }


        public void solsecim()
        {
            pbsol.Image = solsecilen.foto;
            sol2.Text= solsecilen.ikilik.ToString();
            sol3.Text = solsecilen.ucluk.ToString();
            solasist.Text = solsecilen.asist.ToString();
            solblock.Text = solsecilen.block.ToString();
            solrebound.Text = solsecilen.steal.ToString();
            solsteal.Text = solsecilen.steal.ToString();
            solmaas.Text = solsecilen.salary.ToString();
            solname.Text = solsecilen.name;
            solpos.Text = solsecilen.pozisyon.ToString();
            eksi = solsecilen.salary;
        }
        bool solsecildimi = false;
        bool sagsecildimi = false;
        public void tradebutongoster()
        {
            if (solsecildimi is true && sagsecildimi is true)
            {
                btntrade.Visible = true;
                int gerek=sagsecilen.salary - solsecilen.salary;
                lblcalc.Text = $"You need {gerek}M Cap Space for this Trade";
            }
            else
                btntrade.Visible = false;


        }
        public bool oyuncusecimi = false;
        public static oyuncu o1 = new oyuncu();
        public static oyuncu o2 = new oyuncu();
        public static oyuncu o3 = new oyuncu();
        public static oyuncu o4 = new oyuncu();
        public static oyuncu o5 = new oyuncu();

        public static void SaveState()
        {
            using (var stream = new FileStream("trade.bin", FileMode.Create))   //-1
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, o1);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, o2);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, o3);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, o4);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, o5);
                stream.FlushAsync();
            }
        }
        public static void LoadState() 
        {
            if (File.Exists("trade.bin"))
            {
                using (var stream = new FileStream("trade.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    o1 = (oyuncu)formatter.Deserialize(stream);
                    o2 = (oyuncu)formatter.Deserialize(stream);
                    o3 = (oyuncu)formatter.Deserialize(stream);
                    o4 = (oyuncu)formatter.Deserialize(stream);
                    o5 = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }
        public static void LoadStatey()
        {
            if (File.Exists("tradea.bin"))
            {
                using (var stream = new FileStream("tradea.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    o1 = (oyuncu)formatter.Deserialize(stream);
                    o2 = (oyuncu)formatter.Deserialize(stream);
                    o3 = (oyuncu)formatter.Deserialize(stream);
                    o4 = (oyuncu)formatter.Deserialize(stream);
                    o5 = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }


        public void rastgeleoyuncusecimi()
        {
            Random rand = new Random();
            int secim = rand.Next(0, staticdatabase.lists.oyuncus.Count - 1);
            o1 = staticdatabase.lists.oyuncus[secim];
            staticdatabase.lists.oyuncus.RemoveAt(secim);
            secim = rand.Next(0, staticdatabase.lists.oyuncus.Count - 1);
            o2 = staticdatabase.lists.oyuncus[secim];
            staticdatabase.lists.oyuncus.RemoveAt(secim);
            secim = rand.Next(0, staticdatabase.lists.oyuncus.Count - 1);
            o3 = staticdatabase.lists.oyuncus[secim];
            staticdatabase.lists.oyuncus.RemoveAt(secim);
            secim = rand.Next(0, staticdatabase.lists.oyuncus.Count - 1);
            o4 = staticdatabase.lists.oyuncus[secim];
            staticdatabase.lists.oyuncus.RemoveAt(secim);
            secim = rand.Next(0, staticdatabase.lists.oyuncus.Count - 1);
            o5 = staticdatabase.lists.oyuncus[secim];
            staticdatabase.lists.oyuncus.RemoveAt(secim);
            oyuncusecimi = true;


        }
        oyuncu sagsecilen = new oyuncu();
        int sagsecildi = 0;
        int arti = 0;
        private void pbsag1_Click(object sender, EventArgs e)
        {
            sagsecilen = o1;
            sagsecim();
            sagsecildi = 1;
            sagsecildimi = true;
            tradebutongoster();
        }

        private void pbsag2_Click(object sender, EventArgs e)
        {
            sagsecilen = o2;
            sagsecim();
            sagsecildi = 2;
            sagsecildimi = true;
            tradebutongoster();
        }

        private void pbsag3_Click(object sender, EventArgs e)
        {
            sagsecilen = o3;
            sagsecim();
            sagsecildi = 3;
            sagsecildimi = true;
            tradebutongoster();
        }

        private void pbsag4_Click(object sender, EventArgs e)
        {
            sagsecilen = o4;
            sagsecim(); 
            sagsecildi = 4;
            sagsecildimi = true;
            tradebutongoster();
        }

        private void pbsag5_Click(object sender, EventArgs e)
        {
            sagsecilen = o5;
            sagsecim();
            sagsecildi = 5;
            sagsecildimi = true;
            tradebutongoster();
        }

        public void sagsecim()
        {
            sag3.Text = sagsecilen.ucluk.ToString();
            sag2.Text = sagsecilen.ikilik.ToString();
            sagasist.Text = sagsecilen.asist.ToString();
            sagrebound.Text = sagsecilen.rebound.ToString();
            sagblock.Text= sagsecilen.block.ToString();
            sagsteal.Text=sagsecilen.steal.ToString();
            sagmaas.Text = sagsecilen.salary.ToString();
            sagpos.Text = sagsecilen.pozisyon.ToString();

            gpsag.Text = sagsecilen.name.ToString();
            pbsag.Image = sagsecilen.foto;
            arti = sagsecilen.salary;
        }

        private void btntrade_Click(object sender, EventArgs e)
        {
            solsecildimi = false;
            sagsecildimi = false;
            
            tradebutongoster();
            oyuncu gecici = new oyuncu();
            oyuncu gecici2 = new oyuncu();
            if (capspace - sagsecilen.salary + solsecilen.salary >= 0)
            {
                if (secildi == 1)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.pg1 = gecici2;
                    bizimtakim();



                }
                else if (secildi == 2)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.sg1 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 3)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.sf1 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 4)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.pf1 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 5)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.c1 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 6)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.pg2 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 7)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.sg2 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 8)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.sf2 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 9)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.pf2 = gecici2;
                    bizimtakim();

                }
                else if (secildi == 10)
                {
                    gecici = solsecilen;
                    gecici2 = sagsecilen;
                    staticdatabase.teams.secilentakim.c2 = gecici2;
                    bizimtakim();

                }
                if (sagsecildi == 1)
                {
                    o1 = gecici;
                    gelenoyuncular();
                }
                else if (sagsecildi == 2)
                {
                    o2 = gecici;
                    gelenoyuncular();
                }
                else if (sagsecildi == 3)
                {
                    o3 = gecici;
                    gelenoyuncular();
                }
                else if (sagsecildi == 4)
                {
                    o4 = gecici;
                    gelenoyuncular();
                }
                else if (sagsecildi == 5)
                {
                    o5 = gecici; ;
                    gelenoyuncular();
                }
                capspace = capspace - sagsecilen.salary + solsecilen.salary;
                lblcapspace.Text = capspace.ToString();
                lblinfo.Text = "Trade successful";
                lblinfo.ForeColor = Color.Green;

            }

            else
            {
                lblinfo.Text = "Your cap space is not enough for this trade";
                lblinfo.ForeColor = Color.Red;
            }

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            staticdatabase.lists.transfer = false;
            staticdatabase.teams.secilentakim.salary = capspace;
            bool varmi = false;
            
            foreach (oyuncu item in staticdatabase.lists.oyuncus)
            {
                if (o1.name == item.name) 
                varmi = true;
            }
            if (varmi == false)
            {
                staticdatabase.lists.oyuncus.Add(o1);
            }
            varmi = false;
            foreach (oyuncu item in staticdatabase.lists.oyuncus)
            {
                if (o2.name == item.name)
                    varmi = true;
            }
            if (varmi == false)
            {
                staticdatabase.lists.oyuncus.Add(o2);
            }
            varmi= false;
            foreach (oyuncu item in staticdatabase.lists.oyuncus)
            {
                if (o3.name == item.name)
                    varmi = true;
            }
            if (varmi == false)
            {
                staticdatabase.lists.oyuncus.Add(o3);
            }
            varmi = false;
            foreach (oyuncu item in staticdatabase.lists.oyuncus)
            {
                if (o4.name == item.name)
                    varmi = true;
            }
            if (varmi == false)
            {
                staticdatabase.lists.oyuncus.Add(o4);
            }
            varmi = false;
            foreach (oyuncu item in staticdatabase.lists.oyuncus)
            {
                if (o5.name == item.name)
                    varmi = true;
            }
            if (varmi == false)
            {
                staticdatabase.lists.oyuncus.Add(o5);
            }
            
            
                

            Form3 frm = new Form3();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
            
        }




    }
}
