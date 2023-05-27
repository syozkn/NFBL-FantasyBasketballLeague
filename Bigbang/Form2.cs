using Bigbang.classes;
using Bigbang.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bigbang.staticdatabase;
using NAudio.Gui;

namespace Bigbang
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void oyuncumaaslarisifirlama()
        {
            staticdatabase.players.oyuncu1.salary = 0;
            staticdatabase.players.oyuncu2.salary = 0;
            staticdatabase.players.oyuncu3.salary = 0;
            staticdatabase.players.oyuncu4.salary = 0;
            staticdatabase.players.oyuncu5.salary = 0;
            staticdatabase.players.oyuncu6.salary = 0;
            staticdatabase.players.oyuncu7.salary = 0;
            staticdatabase.players.oyuncu8.salary = 0;
            staticdatabase.players.oyuncu9.salary = 0;
            staticdatabase.players.oyuncu10.salary = 0;

        }


        private void Form2_Load(object sender, EventArgs e)
        {

            pbteamlogo.Image = staticdatabase.teams.secilentakim.logo;
            lblteamname.Text = staticdatabase.teams.secilentakim.name;
            List<oyuncu> kadro = new List<oyuncu>(10);
            staticdatabase.teams.secilentakim.kadro = kadro;
            staticdatabase.lists.butce = 200;
            lblbudget.Text = staticdatabase.teams.secilentakim.salary.ToString();
            oyuncumaaslari();
            oyuncumaaslarisifirlama();
            lblinfo.Text = "Welcome to the player draft screen. Click the begin draft button to get started!";








        }
        void oyuncumaaslari()
        {
            pg1.salary = 0;
            pg2.salary = 0;
            sg1.salary = 0;
            sg2.salary = 0;
            sf1.salary = 0;
            sf2.salary = 0;
            pf1.salary = 0;
            pf2.salary = 0;
            c1.salary = 0;
            c2.salary = 0;
            gecicikadro.Add(pg1);
            gecicikadro.Add(pg2);
            gecicikadro.Add(sg1);
            gecicikadro.Add(sg2);
            gecicikadro.Add(sf1);
            gecicikadro.Add(sf2);
            gecicikadro.Add(pf1);
            gecicikadro.Add(pf2);
            gecicikadro.Add(c1);
            gecicikadro.Add(c2);
        }


        void labelgoster()
        {
            lbldraft1.Visible = true;
            lbldraft2.Visible = true;
            lbldraft3.Visible = true;
            lbldraft4.Visible = true;
            lbldraft5.Visible = true;
            lbldraft6.Visible = true;
            lbldraft7.Visible = true;
            lbldraft8.Visible = true;


        }

        Random random = new Random();
        int secim1;
        int secim2;
        int secim3;
        int secim4;
        int secim5;
        int secim6;
        int secim7;
        int secim8;
        oyuncu draftpg1;
        oyuncu draftpg2;
        oyuncu draftpg3;
        oyuncu draftpg4;
        oyuncu draftpg5;
        oyuncu draftpg6;
        oyuncu draftpg7;
        oyuncu draftpg8;
        int draftpos = 0;

        bool pgsecildimi = false;
        public void pickbutonlarigorunmez()
        {
            btnpick5.Visible = false;
            btnsubs.Visible = false;


        }

        public void butonrenkleri()
        {
            btnpointguard.BackColor = Color.Black;
            btnpointguard.ForeColor = Color.Orange;
            btnshootingguard.BackColor = Color.Black;
            btnshootingguard.ForeColor = Color.Orange;
            btnsmallforwards.BackColor = Color.Black;
            btnsmallforwards.ForeColor = Color.Orange;
            btnpowerforwards.BackColor = Color.Black;
            btnpowerforwards.ForeColor = Color.Orange;
            btncenters.BackColor = Color.Black;
            btncenters.ForeColor = Color.Orange;
            btnyedekpg.BackColor = Color.Black;
            btnyedekpg.ForeColor = Color.Orange;
            btnyedeksg.BackColor = Color.Black;
            btnyedeksg.ForeColor = Color.Orange;
            btnyedeksf.BackColor = Color.Black;
            btnyedeksf.ForeColor = Color.Orange;
            btnyedekpf.BackColor = Color.Black;
            btnyedekpf.ForeColor = Color.Orange;
            btnyedekc.BackColor = Color.Black;
            btnyedekc.ForeColor = Color.Orange;




        }

        public void arrowlar()
        {
            pbarrow1a.Image = null;
            pbarrow1b.Image = null;
            pbarrow2a.Image = null;
            pbarrow2b.Image = null;
            pbarrow3a.Image = null;
            pbarrow3b.Image = null;
            pbarrow4a.Image = null;
            pbarrow4b.Image = null;
            pbarrow5a.Image = null;
            pbarrow5b.Image = null;


        }
        private void btnpointguard_Click(object sender, EventArgs e)
        {
            labelgoster();
            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
           

            pbarrow1a.Image = Resources.greenarrow;
            pbarrow1b.Image = Resources.bluearrow;
            btnpointguard.BackColor = Color.Orange;
            btnpointguard.ForeColor = Color.Black;
            oyuncusecimiinfo();



            #region pointguarddraft
            if (pgsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft1.Image = staticdatabase.lists.pgs[secim1].foto;
                draftpg1 = staticdatabase.lists.pgs[secim1];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft2.Image = staticdatabase.lists.pgs[secim2].foto;
                draftpg2 = staticdatabase.lists.pgs[secim2];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft3.Image = staticdatabase.lists.pgs[secim3].foto;
                draftpg3 = staticdatabase.lists.pgs[secim3];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft4.Image = staticdatabase.lists.pgs[secim4].foto;
                draftpg4 = staticdatabase.lists.pgs[secim4];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft5.Image = staticdatabase.lists.pgs[secim5].foto;
                draftpg5 = staticdatabase.lists.pgs[secim5];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft6.Image = staticdatabase.lists.pgs[secim6].foto;
                draftpg6 = staticdatabase.lists.pgs[secim6];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft7.Image = staticdatabase.lists.pgs[secim7].foto;
                draftpg7 = staticdatabase.lists.pgs[secim7];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft8.Image = staticdatabase.lists.pgs[secim8].foto;
                draftpg8 = staticdatabase.lists.pgs[secim8];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim8]);
                pgsecildimi = true;
            }
            else if (pgsecildimi == true)
            {
                pbdraft1.Image = draftpg1.foto;
                pbdraft2.Image = draftpg2.foto;
                pbdraft3.Image = draftpg3.foto;
                pbdraft4.Image = draftpg4.foto;
                pbdraft5.Image = draftpg5.foto;
                pbdraft6.Image = draftpg6.foto;
                pbdraft7.Image = draftpg7.foto;
                pbdraft8.Image = draftpg8.foto;



            }
            lbldraft1.Text = draftpg1.name;
            lbldraft2.Text = draftpg2.name;
            lbldraft3.Text = draftpg3.name;
            lbldraft4.Text = draftpg4.name;
            lbldraft5.Text = draftpg5.name;
            lbldraft6.Text = draftpg6.name;
            lbldraft7.Text = draftpg7.name;
            lbldraft8.Text = draftpg8.name;
            #endregion
            draftpos = 1;
        }
        oyuncu draftsg1;
        oyuncu draftsg2;
        oyuncu draftsg3;
        oyuncu draftsg4;
        oyuncu draftsg5;
        oyuncu draftsg6;
        oyuncu draftsg7;
        oyuncu draftsg8;
        bool sgsecildimi = false;
        private void btnshootingguard_Click(object sender, EventArgs e)
        {
            labelgoster();

            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
         
            pbarrow2a.Image = Resources.greenarrow;
            pbarrow2b.Image = Resources.bluearrow;
            btnshootingguard.BackColor = Color.Orange;
            btnshootingguard.ForeColor = Color.Black;
            oyuncusecimiinfo();
            secimbasladimi= true;

            #region shootingguarddraft
            if (sgsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft1.Image = staticdatabase.lists.sgs[secim1].foto;
                draftsg1 = staticdatabase.lists.sgs[secim1];
                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft2.Image = staticdatabase.lists.sgs[secim2].foto;
                draftsg2 = staticdatabase.lists.sgs[secim2];
                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft3.Image = staticdatabase.lists.sgs[secim3].foto;
                draftsg3 = staticdatabase.lists.sgs[secim3];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft4.Image = staticdatabase.lists.sgs[secim4].foto;
                draftsg4 = staticdatabase.lists.sgs[secim4];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft5.Image = staticdatabase.lists.sgs[secim5].foto;
                draftsg5 = staticdatabase.lists.sgs[secim5];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft6.Image = staticdatabase.lists.sgs[secim6].foto;
                draftsg6 = staticdatabase.lists.sgs[secim6];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft7.Image = staticdatabase.lists.sgs[secim7].foto;
                draftsg7 = staticdatabase.lists.sgs[secim7];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft8.Image = staticdatabase.lists.sgs[secim8].foto;
                draftsg8 = staticdatabase.lists.sgs[secim8];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim8]);
                sgsecildimi = true;
            }
            else if (sgsecildimi == true)
            {
                pbdraft1.Image = draftsg1.foto;
                pbdraft2.Image = draftsg2.foto;
                pbdraft3.Image = draftsg3.foto;
                pbdraft4.Image = draftsg4.foto;
                pbdraft5.Image = draftsg5.foto;
                pbdraft6.Image = draftsg6.foto;
                pbdraft7.Image = draftsg7.foto;
                pbdraft8.Image = draftsg8.foto;


            }
            lbldraft1.Text = draftsg1.name;
            lbldraft2.Text = draftsg2.name;
            lbldraft3.Text = draftsg3.name;
            lbldraft4.Text = draftsg4.name;
            lbldraft5.Text = draftsg5.name;
            lbldraft6.Text = draftsg6.name;
            lbldraft7.Text = draftsg7.name;
            lbldraft8.Text = draftsg8.name;
            #endregion
            draftpos = 2;
        }
        oyuncu draftsf1;
        oyuncu draftsf2;
        oyuncu draftsf3;
        oyuncu draftsf4;
        oyuncu draftsf5;
        oyuncu draftsf6;
        oyuncu draftsf7;
        oyuncu draftsf8;
        bool sfsecildimi = false;
        private void btnsmallforwards_Click(object sender, EventArgs e)
        {
            labelgoster();
            secimbasladimi = true;

            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
           
            pbarrow3a.Image = Resources.greenarrow;
            pbarrow3b.Image = Resources.bluearrow;
            btnsmallforwards.BackColor = Color.Orange;
            btnsmallforwards.ForeColor = Color.Black;
            oyuncusecimiinfo();


            #region smallforwarddraft
            if (sfsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft1.Image = staticdatabase.lists.sfs[secim1].foto;
                draftsf1 = staticdatabase.lists.sfs[secim1];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft2.Image = staticdatabase.lists.sfs[secim2].foto;
                draftsf2 = staticdatabase.lists.sfs[secim2];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft3.Image = staticdatabase.lists.sfs[secim3].foto;
                draftsf3 = staticdatabase.lists.sfs[secim3];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft4.Image = staticdatabase.lists.sfs[secim4].foto;
                draftsf4 = staticdatabase.lists.sfs[secim4];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft5.Image = staticdatabase.lists.sfs[secim5].foto;
                draftsf5 = staticdatabase.lists.sfs[secim5];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft6.Image = staticdatabase.lists.sfs[secim6].foto;
                draftsf6 = staticdatabase.lists.sfs[secim6];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft7.Image = staticdatabase.lists.sfs[secim7].foto;
                draftsf7 = staticdatabase.lists.sfs[secim7];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft8.Image = staticdatabase.lists.sfs[secim8].foto;
                draftsf8 = staticdatabase.lists.sfs[secim8];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim8]);
                sfsecildimi = true;
            }
            else if (sfsecildimi == true)
            {
                pbdraft1.Image = draftsf1.foto;
                pbdraft2.Image = draftsf2.foto;
                pbdraft3.Image = draftsf3.foto;
                pbdraft4.Image = draftsf4.foto;
                pbdraft5.Image = draftsf5.foto;
                pbdraft6.Image = draftsf6.foto;
                pbdraft7.Image = draftsf7.foto;
                pbdraft8.Image = draftsf8.foto;


            }
            lbldraft1.Text = draftsf1.name;
            lbldraft2.Text = draftsf2.name;
            lbldraft3.Text = draftsf3.name;
            lbldraft4.Text = draftsf4.name;
            lbldraft5.Text = draftsf5.name;
            lbldraft6.Text = draftsf6.name;
            lbldraft7.Text = draftsf7.name;
            lbldraft8.Text = draftsf8.name;

            #endregion
            draftpos = 3;
        }
        oyuncu draftpf1;
        oyuncu draftpf2;
        oyuncu draftpf3;
        oyuncu draftpf4;
        oyuncu draftpf5;
        oyuncu draftpf6;
        oyuncu draftpf7;
        oyuncu draftpf8;
        bool pfsecildimi = false;
        private void btnpowerforwards_Click(object sender, EventArgs e)
        {
            labelgoster();
            secimbasladimi = true;

            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
           
            pbarrow4a.Image = Resources.greenarrow;
            pbarrow4b.Image = Resources.bluearrow;
            btnpowerforwards.BackColor = Color.Orange;
            btnpowerforwards.ForeColor = Color.Black;
            oyuncusecimiinfo();


            #region powerforwarddraft
            if (pfsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft1.Image = staticdatabase.lists.pfs[secim1].foto;
                draftpf1 = staticdatabase.lists.pfs[secim1];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft2.Image = staticdatabase.lists.pfs[secim2].foto;
                draftpf2 = staticdatabase.lists.pfs[secim2];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft3.Image = staticdatabase.lists.pfs[secim3].foto;
                draftpf3 = staticdatabase.lists.pfs[secim3];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft4.Image = staticdatabase.lists.pfs[secim4].foto;
                draftpf4 = staticdatabase.lists.pfs[secim4];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft5.Image = staticdatabase.lists.pfs[secim5].foto;
                draftpf5 = staticdatabase.lists.pfs[secim5];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft6.Image = staticdatabase.lists.pfs[secim6].foto;
                draftpf6 = staticdatabase.lists.pfs[secim6];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft7.Image = staticdatabase.lists.pfs[secim7].foto;
                draftpf7 = staticdatabase.lists.pfs[secim7];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft8.Image = staticdatabase.lists.pfs[secim8].foto;
                draftpf8 = staticdatabase.lists.pfs[secim8];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim8]);
                pfsecildimi = true;
            }
            else if (pfsecildimi == true)
            {
                pbdraft1.Image = draftpf1.foto;
                pbdraft2.Image = draftpf2.foto;
                pbdraft3.Image = draftpf3.foto;
                pbdraft4.Image = draftpf4.foto;
                pbdraft5.Image = draftpf5.foto;
                pbdraft6.Image = draftpf6.foto;
                pbdraft7.Image = draftpf7.foto;
                pbdraft8.Image = draftpf8.foto;


            }
            lbldraft1.Text = draftpf1.name;
            lbldraft2.Text = draftpf2.name;
            lbldraft3.Text = draftpf3.name;
            lbldraft4.Text = draftpf4.name;
            lbldraft5.Text = draftpf5.name;
            lbldraft6.Text = draftpf6.name;
            lbldraft7.Text = draftpf7.name;
            lbldraft8.Text = draftpf8.name;
            #endregion
            draftpos = 4;
        }
        oyuncu draftc1;
        oyuncu draftc2;
        oyuncu draftc3;
        oyuncu draftc4;
        oyuncu draftc5;
        oyuncu draftc6;
        oyuncu draftc7;
        oyuncu draftc8;
        bool csecildimi = false;

        private void btncenters_Click(object sender, EventArgs e)
        {
            labelgoster();
            secimbasladimi = true;
            pickbutonlarigorunmez();
            arrowlar();
           
            pbarrow5a.Image = Resources.greenarrow;
            pbarrow5b.Image = Resources.bluearrow;

            butonrenkleri();
            btncenters.BackColor = Color.Orange;
            btncenters.ForeColor = Color.Black;
            oyuncusecimiinfo();


            #region centerdraft
            if (csecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft1.Image = staticdatabase.lists.cs[secim1].foto;
                draftc1 = staticdatabase.lists.cs[secim1];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft2.Image = staticdatabase.lists.cs[secim2].foto;
                draftc2 = staticdatabase.lists.cs[secim2];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft3.Image = staticdatabase.lists.cs[secim3].foto;
                draftc3 = staticdatabase.lists.cs[secim3];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft4.Image = staticdatabase.lists.cs[secim4].foto;
                draftc4 = staticdatabase.lists.cs[secim4];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft5.Image = staticdatabase.lists.cs[secim5].foto;
                draftc5 = staticdatabase.lists.cs[secim5];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft6.Image = staticdatabase.lists.cs[secim6].foto;
                draftc6 = staticdatabase.lists.cs[secim6];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft7.Image = staticdatabase.lists.cs[secim7].foto;
                draftc7 = staticdatabase.lists.cs[secim7];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft8.Image = staticdatabase.lists.cs[secim8].foto;
                draftc8 = staticdatabase.lists.cs[secim8];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim8]);
                csecildimi = true;
            }
            else if (csecildimi == true)
            {
                pbdraft1.Image = draftc1.foto;
                pbdraft2.Image = draftc2.foto;
                pbdraft3.Image = draftc3.foto;
                pbdraft4.Image = draftc4.foto;
                pbdraft5.Image = draftc5.foto;
                pbdraft6.Image = draftc6.foto;
                pbdraft7.Image = draftc7.foto;
                pbdraft8.Image = draftc8.foto;


            }
            lbldraft1.Text = draftc1.name;
            lbldraft2.Text = draftc2.name;
            lbldraft3.Text = draftc3.name;
            lbldraft4.Text = draftc4.name;
            lbldraft5.Text = draftc5.name;
            lbldraft6.Text = draftc6.name;
            lbldraft7.Text = draftc7.name;
            lbldraft8.Text = draftc8.name;
            #endregion
            draftpos = 5;
        }

        private void btndraft_Click(object sender, EventArgs e)
        {
            btncenters.Visible = true;
            btnpointguard.Visible = true;
            btnpowerforwards.Visible = true;
            btnshootingguard.Visible = true;
            btnsmallforwards.Visible = true;
            btnyedekpg.Visible = true;
            btnyedeksg.Visible = true;
            btnyedeksf.Visible = true;
            btnyedekpf.Visible = true;
            btnyedekc.Visible = true;
            //pickbutonlari();

            btndraft.Visible = false;
            lblinfo.Text = "You can see the currently available players by pressing the position keys in the SQUAD window.";

        }

        public void oyuncusecimiinfo()
        {
            lblinfo.Text = "Click on the photo of the player you want to learn about the stats";
        }
       

    oyuncu secilen = new oyuncu();
        public void profilegoster()
        {
            lblname.Visible = true;
            lblpos.Visible = true;
            lblsalary.Visible = true;
            lblblock.Visible = true;
            lblasist.Visible = true;
            lbliki.Visible = true;
            lbluc.Visible = true;
            lblsteal.Visible = true;
            lblrebound.Visible = true;
            lbldolar.Visible = true;
            lbloverall.Visible = true;
            lbldefoverall.Visible = true;
            lbloffoverall.Visible = true;



        }
        oyuncu secilenoyuncu = new oyuncu();
        public void profiledoldur(oyuncu oyuncu)
        {
            pbprofile.Image = oyuncu.foto;
            lblname.Text = oyuncu.name;
            lblsalary.Text = Convert.ToString(oyuncu.salary);
            lblblock.Text = Convert.ToString(oyuncu.block);
            lblasist.Text = Convert.ToString(oyuncu.asist);
            lbliki.Text = Convert.ToString(oyuncu.ikilik);
            lbluc.Text = Convert.ToString(oyuncu.ucluk);
            lblsteal.Text = Convert.ToString(oyuncu.steal);
            lblrebound.Text = Convert.ToString(oyuncu.rebound);
            lblpos.Text = oyuncu.pozisyon.ToString().ToUpper();
            lbloverall.Text = oyuncu.Overall.ToString();
            lbldefoverall.Text = oyuncu.Defoverall.ToString();
            lbloffoverall.Text = oyuncu.Offoverall.ToString();
            secilenoyuncu = oyuncu;





        }

        private bool secimbasladimi = false;

        #region draftprofile
        public void fotograftiklama()
        {
            lblinfo.Text = "From the Player Profile screen, you can add the player to your squad for the top 5 or substitutes.";
        }
        private void pbdraft1_Click(object sender, EventArgs e)
        {
            #region pb1
           if(secimbasladimi==true)
            {
                fotograftiklama();
                profilegoster();
                pickbutonlari();
                if (draftpos == 1)
                {


                    profiledoldur(draftpg1);




                }
                if (draftpos == 2)
                {



                    profiledoldur(draftsg1);
                }
                if (draftpos == 3)
                {



                    profiledoldur(draftsf1);
                }
                if (draftpos == 4)
                {



                    profiledoldur(draftpf1);
                }
                if (draftpos == 5)
                {



                    profiledoldur(draftc1);
                }

                #endregion
            }

        }

        private void pbdraft2_Click(object sender, EventArgs e)
        {
           if(secimbasladimi==true)
            {
                fotograftiklama();
                profilegoster();
                pickbutonlari();

                if (draftpos == 1)
                {


                    profiledoldur(draftpg2);
                }
                if (draftpos == 2)
                {
                    profiledoldur(draftsg2);


                }
                if (draftpos == 3)
                {


                    profiledoldur(draftsf2);

                }
                if (draftpos == 4)
                {
                    profiledoldur(draftpf2);


                }
                if (draftpos == 5)
                {
                    profiledoldur(draftc2);


                }
            }
            
        }


        private void pbdraft3_Click(object sender, EventArgs e)
        {
           if(secimbasladimi==true)
            {
                fotograftiklama();
                profilegoster();
                pickbutonlari();

                if (draftpos == 1)
                {
                    profiledoldur(draftpg3);


                }
                if (draftpos == 2)
                {
                    profiledoldur(draftsg3);


                }
                if (draftpos == 3)
                {
                    profiledoldur(draftsf3);


                }
                if (draftpos == 4)
                {
                    profiledoldur(draftpf3);


                }
                if (draftpos == 5)
                {
                    profiledoldur(draftc3);


                }
            }

        }

        private void pbdraft4_Click(object sender, EventArgs e)
        {
           if(secimbasladimi== true)
            {
                fotograftiklama();
                profilegoster();
                pickbutonlari();

                if (draftpos == 1)
                {
                    profiledoldur(draftpg4);


                }
                if (draftpos == 2)
                {
                    profiledoldur(draftsg4);


                }
                if (draftpos == 3)
                {
                    profiledoldur(draftsf4);


                }
                if (draftpos == 4)
                {
                    profiledoldur(draftpf4);


                }
                if (draftpos == 5)
                {
                    profiledoldur(draftc4);


                }
            }
        }

        private void pbdraft5_Click(object sender, EventArgs e)
        {
            if(secimbasladimi== true)
            {
                fotograftiklama();
                profilegoster();
                pickbutonlari();

                if (draftpos == 1)
                {
                    profiledoldur(draftpg5);


                }
                if (draftpos == 2)
                {
                    profiledoldur(draftsg5);


                }
                if (draftpos == 3)
                {
                    profiledoldur(draftsf5);


                }
                if (draftpos == 4)
                {
                    profiledoldur(draftpf5);


                }
                if (draftpos == 5)
                {
                    profiledoldur(draftc5);


                }
            }
 
        }

        private void pbdraft6_Click(object sender, EventArgs e)
        {
            if(secimbasladimi== true) {
                fotograftiklama();
                profilegoster();
                pickbutonlari();

                if (draftpos == 1)
                {
                    profiledoldur(draftpg6);


                }
                if (draftpos == 2)
                {
                    profiledoldur(draftsg6);


                }
                if (draftpos == 3)
                {
                    profiledoldur(draftsf6);


                }
                if (draftpos == 4)
                {
                    profiledoldur(draftpf6);


                }
                if (draftpos == 5)
                {
                    profiledoldur(draftc6);


                }
            }
        }

        private void pbdraft7_Click(object sender, EventArgs e)
        {
            if (secimbasladimi == true)
            {
                fotograftiklama();
                profilegoster();
                pickbutonlari();

                if (draftpos == 1)
                {
                    profiledoldur(draftpg7);


                }
                if (draftpos == 2)
                {
                    profiledoldur(draftsg7);
                }
                if (draftpos == 3)
                {
                    profiledoldur(draftsf7);


                }
                if (draftpos == 4)
                {
                    profiledoldur(draftpf7);


                }
                if (draftpos == 5)
                {
                    profiledoldur(draftc7);


                }
            }
        }

        private void pbdraft8_Click(object sender, EventArgs e)
        {
           if(secimbasladimi==true)
            {
                fotograftiklama();
                profilegoster();
                pickbutonlari();

                if (draftpos == 1)
                {
                    profiledoldur(draftpg8);


                }
                if (draftpos == 2)
                {
                    profiledoldur(draftsg8);


                }
                if (draftpos == 3)
                {
                    profiledoldur(draftsf8);


                }
                if (draftpos == 4)
                {
                    profiledoldur(draftpf8);


                }
                if (draftpos == 5)
                {
                    profiledoldur(draftc8);


                }
            }
        }
        #endregion
        oyuncu pg1 = new oyuncu();
        oyuncu pg2 = new oyuncu();
        oyuncu sg1 = new oyuncu();
        oyuncu sg2 = new oyuncu();
        oyuncu sf1 = new oyuncu();
        oyuncu sf2 = new oyuncu();
        oyuncu pf1 = new oyuncu();
        oyuncu pf2 = new oyuncu();
        oyuncu c1 = new oyuncu();
        oyuncu c2 = new oyuncu();
        List<oyuncu> gecicikadro = new List<oyuncu>();
        int butce = staticdatabase.teams.secilentakim.salary;

        public void butcehesapla()
        {
            butce = staticdatabase.teams.secilentakim.salary;
            int harcananbutce = (pg1.salary + sg1.salary + sf1.salary + pf1.salary + c1.salary+ pg2.salary + sg2.salary + sf2.salary + pf2.salary + c2.salary);
            butce = butce - harcananbutce;
            lblbudget.Text = butce.ToString();
            if(butce>=0)
            {
                lblbudget.ForeColor = Color.Green;

            }
            else
                lblbudget.ForeColor = Color.Red;
            


        }
        oyuncu a1 =new oyuncu();
        oyuncu a2 = new oyuncu();
        oyuncu a3 = new oyuncu();
        oyuncu a4 = new oyuncu();
        oyuncu a5 = new oyuncu();
        oyuncu a6 = new oyuncu();
        oyuncu a7 = new oyuncu();
        oyuncu a8 = new oyuncu();
        oyuncu a9 = new oyuncu();
        oyuncu a10 = new oyuncu();

        private void btnpick5_Click(object sender, EventArgs e)
        {

            lblinfo.Text = "Great! Now fill your entire squad as much as you can afford.";
            if (secilenoyuncu.pozisyon.ToString()=="pg")
            {
                    pg1 = secilenoyuncu;
                    pbpg.Image = secilenoyuncu.foto;
                    pbcheckpg1.Image = Resources.check100;
                    staticdatabase.players.oyuncu1 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }
            if(secilenoyuncu.pozisyon.ToString()=="sg")
            {

                    sg1 = secilenoyuncu;
                    pbsg.Image = secilenoyuncu.foto;
                    pbchecksg1.Image = Resources.check100;
                    staticdatabase.players.oyuncu2 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }
            if (secilenoyuncu.pozisyon.ToString() == "sf")
            {
                    sf1 = secilenoyuncu;
                    pbsf.Image = secilenoyuncu.foto;
                    pbchecksf1.Image = Resources.check100;
                    staticdatabase.players.oyuncu3 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }
            if (secilenoyuncu.pozisyon.ToString() == "pf")
            {
                    pf1 = secilenoyuncu;
                    pbpf.Image = secilenoyuncu.foto;
                    pbcheckpf1.Image = Resources.check100;
                    staticdatabase.players.oyuncu4 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }
            if (secilenoyuncu.pozisyon.ToString() == "cent")
            {
                    c1 = secilenoyuncu;
                    pbcenter.Image = secilenoyuncu.foto;
                    pbcheckc1.Image = Resources.check100;
                    staticdatabase.players.oyuncu5 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }

        }
        
        private void btnsubs_Click(object sender, EventArgs e)
        {
            if (secilenoyuncu.pozisyon.ToString() == "pg")
            {

                    pg2 = secilenoyuncu;
                    pbpg2.Image = secilenoyuncu.foto;
                    pbcheckpg2.Image = Resources.check100;
                    staticdatabase.players.oyuncu6 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
    





            }
            if (secilenoyuncu.pozisyon.ToString() == "sg")
            {

                    sg2 = secilenoyuncu;
                    pbsg2.Image = secilenoyuncu.foto;
                    pbchecksg2.Image = Resources.check100;
                    staticdatabase.players.oyuncu7 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();

            }
            if (secilenoyuncu.pozisyon.ToString() == "sf")
            {

                    sf2 = secilenoyuncu;
                    pbsf2.Image = secilenoyuncu.foto;
                    pbchecksf2.Image = Resources.check100;
                    staticdatabase.players.oyuncu8 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }
            if (secilenoyuncu.pozisyon.ToString() == "pf")
            {

                    pf2 = secilenoyuncu;
                    pbpf2.Image = secilenoyuncu.foto;
                    pbcheckpf2.Image = Resources.check100;
                    staticdatabase.players.oyuncu9 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }
            if (secilenoyuncu.pozisyon.ToString() == "cent")
            {

                    c2 = secilenoyuncu;
                    pbcenter2.Image = secilenoyuncu.foto;
                    pbcheckc2.Image = Resources.check100;
                    staticdatabase.players.oyuncu10 = secilenoyuncu;
                    butcehesapla();
                    overallhesapla();
            }
        }




        public void pickbutonlari()
        {
            btnpick5.Visible = true;
            btnsubs.Visible = true;
            


        }
        private void btnpick1_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnpick2_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnpick3_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnpick4_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnpick_5_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnpick6_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnpick7_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnpick8_Click(object sender, EventArgs e)
        {
            pickbutonlari();
        }

        private void btnsubmitteam_Click(object sender, EventArgs e)
        {
            if (staticdatabase.players.oyuncu1.name != null && staticdatabase.players.oyuncu2.name != null && staticdatabase.players.oyuncu3.name != null && staticdatabase.players.oyuncu4.name != null && staticdatabase.players.oyuncu5.name != null && staticdatabase.players.oyuncu6.name != null && staticdatabase.players.oyuncu7.name != null && staticdatabase.players.oyuncu8.name != null && staticdatabase.players.oyuncu9.name != null && staticdatabase.players.oyuncu10.name != null)
                
            {
                if (staticdatabase.players.oyuncu1.name != staticdatabase.players.oyuncu6.name && staticdatabase.players.oyuncu2.name != staticdatabase.players.oyuncu7.name && staticdatabase.players.oyuncu3.name != staticdatabase.players.oyuncu8.name && staticdatabase.players.oyuncu4.name != staticdatabase.players.oyuncu9.name && staticdatabase.players.oyuncu5.name != staticdatabase.players.oyuncu10.name)
                {
                    if (butce >= 0)
                    {
                        #region secilenoyuncularilistedencikar
                        for (int i = 0; i <= staticdatabase.lists.pgs2.Count - 1; i++)
                        {
                            if (staticdatabase.players.oyuncu1.name == staticdatabase.lists.pgs2[i].name || staticdatabase.players.oyuncu6.name == staticdatabase.lists.pgs2[i].name)
                            {

                                staticdatabase.lists.pgs2.Remove(staticdatabase.lists.pgs2[i]);
                            }
                        }

                        for (int i = 0; i <= staticdatabase.lists.sgs2.Count - 1; i++)
                        {
                            if (staticdatabase.players.oyuncu2.name == staticdatabase.lists.sgs2[i].name || staticdatabase.players.oyuncu7.name == staticdatabase.lists.sgs2[i].name)
                            {

                                staticdatabase.lists.sgs2.Remove(staticdatabase.lists.sgs2[i]);
                            }
                        }
                        for (int i = 0; i <= staticdatabase.lists.sfs2.Count - 1; i++)
                        {
                            if (staticdatabase.players.oyuncu3.name == staticdatabase.lists.sfs2[i].name || staticdatabase.players.oyuncu8.name == staticdatabase.lists.sfs2[i].name)
                            {

                                staticdatabase.lists.sfs2.Remove(staticdatabase.lists.sfs2[i]);
                            }
                        }

                        for (int i = 0; i <= staticdatabase.lists.pfs2.Count - 1; i++)
                        {
                            if (staticdatabase.players.oyuncu4.name == staticdatabase.lists.pfs2[i].name || staticdatabase.players.oyuncu9.name == staticdatabase.lists.pfs2[i].name)
                            {

                                staticdatabase.lists.pfs2.Remove(staticdatabase.lists.pfs2[i]);
                            }
                        }

                        for (int i = 0; i <= staticdatabase.lists.cs2.Count - 1; i++)
                        {
                            if (staticdatabase.players.oyuncu5.name == staticdatabase.lists.cs2[i].name || staticdatabase.players.oyuncu10.name == staticdatabase.lists.cs2[i].name)
                            {

                                staticdatabase.lists.cs2.Remove(staticdatabase.lists.cs2[i]);
                            }
                        }

                        staticdatabase.teams.secilentakim.pg1 = staticdatabase.players.oyuncu1;
                        staticdatabase.teams.secilentakim.sg1 = staticdatabase.players.oyuncu2;
                        staticdatabase.teams.secilentakim.sf1 = staticdatabase.players.oyuncu3;
                        staticdatabase.teams.secilentakim.pf1 = staticdatabase.players.oyuncu4;
                        staticdatabase.teams.secilentakim.c1 = staticdatabase.players.oyuncu5;
                        staticdatabase.teams.secilentakim.pg2 = staticdatabase.players.oyuncu6;
                        staticdatabase.teams.secilentakim.sg2 = staticdatabase.players.oyuncu7;
                        staticdatabase.teams.secilentakim.sf2 = staticdatabase.players.oyuncu8;
                        staticdatabase.teams.secilentakim.pf2 = staticdatabase.players.oyuncu9;
                        staticdatabase.teams.secilentakim.c2 = staticdatabase.players.oyuncu10;
                        staticdatabase.teams.secilentakim.salary = butce;
                        Form3 frm = new Form3();
                        this.Hide();
                        frm.ShowDialog();
                        this.Dispose();
                    }
                    else
                    {
                        lblinfo.Text = "You don't have enough cap space to continue.";
                    }


                }

                else
                {
                    lblinfo.Text = "You can not pick same player twice";
                }
            }
        
              else
            {

                lblinfo.Text = "You need to fill the entire roster to continue!";
            }



        }








        #endregion
        public void overallhesapla()
        {

            double overall= (pg1.Overall + sg1.Overall + sf1.Overall + pf1.Overall + c1.Overall + pg2.Overall + sg2.Overall + sf2.Overall + pf2.Overall + c2.Overall)/10;
            double offoverall = (pg1.Offoverall + sg1.Offoverall + sf1.Offoverall + pf1.Offoverall + c1.Offoverall + pg2.Offoverall + sg2.Offoverall + sf2.Offoverall + pf2.Offoverall + c2.Offoverall) / 10;
            double defoverall= (pg1.Defoverall + sg1.Defoverall + sf1.Defoverall + pf1.Defoverall + c1.Defoverall + pg2.Defoverall + sg2.Defoverall + sf2.Defoverall + pf2.Defoverall + c2.Defoverall) / 10;
            lblteamoverall.Text=Convert.ToString(overall);
            lblteamoffoverall.Text = Convert.ToString(offoverall);
            lblteamdefoverall.Text = Convert.ToString(defoverall);


        }
        private void btnyedekpg_Click(object sender, EventArgs e)
        {
            labelgoster();
            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
         

            pbarrow1a.Image = Resources.greenarrow;
            pbarrow1b.Image = Resources.bluearrow;
            btnyedekpg.BackColor = Color.Orange;
            btnyedekpg.ForeColor = Color.Black;
            oyuncusecimiinfo();
            secimbasladimi = true;




            #region pointguarddraft
            if (pgsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft1.Image = staticdatabase.lists.pgs[secim1].foto;
                draftpg1 = staticdatabase.lists.pgs[secim1];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft2.Image = staticdatabase.lists.pgs[secim2].foto;
                draftpg2 = staticdatabase.lists.pgs[secim2];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft3.Image = staticdatabase.lists.pgs[secim3].foto;
                draftpg3 = staticdatabase.lists.pgs[secim3];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft4.Image = staticdatabase.lists.pgs[secim4].foto;
                draftpg4 = staticdatabase.lists.pgs[secim4];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft5.Image = staticdatabase.lists.pgs[secim5].foto;
                draftpg5 = staticdatabase.lists.pgs[secim5];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft6.Image = staticdatabase.lists.pgs[secim6].foto;
                draftpg6 = staticdatabase.lists.pgs[secim6];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft7.Image = staticdatabase.lists.pgs[secim7].foto;
                draftpg7 = staticdatabase.lists.pgs[secim7];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.pgs.Count);
                pbdraft8.Image = staticdatabase.lists.pgs[secim8].foto;
                draftpg8 = staticdatabase.lists.pgs[secim8];

                staticdatabase.lists.pgs.Remove(staticdatabase.lists.pgs[secim8]);
                pgsecildimi = true;
            }
            else if (pgsecildimi == true)
            {
                pbdraft1.Image = draftpg1.foto;
                pbdraft2.Image = draftpg2.foto;
                pbdraft3.Image = draftpg3.foto;
                pbdraft4.Image = draftpg4.foto;
                pbdraft5.Image = draftpg5.foto;
                pbdraft6.Image = draftpg6.foto;
                pbdraft7.Image = draftpg7.foto;
                pbdraft8.Image = draftpg8.foto;



            }
            lbldraft1.Text = draftpg1.name;
            lbldraft2.Text = draftpg2.name;
            lbldraft3.Text = draftpg3.name;
            lbldraft4.Text = draftpg4.name;
            lbldraft5.Text = draftpg5.name;
            lbldraft6.Text = draftpg6.name;
            lbldraft7.Text = draftpg7.name;
            lbldraft8.Text = draftpg8.name;
            #endregion
            draftpos = 1;
        }

        private void btnyedeksg_Click(object sender, EventArgs e)
        {
            labelgoster();
            secimbasladimi = true;


            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
           
            pbarrow2a.Image = Resources.greenarrow;
            pbarrow2b.Image = Resources.bluearrow;
            btnyedeksg.BackColor = Color.Orange;
            btnyedeksg.ForeColor = Color.Black;

            #region shootingguarddraft
            if (sgsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft1.Image = staticdatabase.lists.sgs[secim1].foto;
                draftsg1 = staticdatabase.lists.sgs[secim1];
                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft2.Image = staticdatabase.lists.sgs[secim2].foto;
                draftsg2 = staticdatabase.lists.sgs[secim2];
                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft3.Image = staticdatabase.lists.sgs[secim3].foto;
                draftsg3 = staticdatabase.lists.sgs[secim3];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft4.Image = staticdatabase.lists.sgs[secim4].foto;
                draftsg4 = staticdatabase.lists.sgs[secim4];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft5.Image = staticdatabase.lists.sgs[secim5].foto;
                draftsg5 = staticdatabase.lists.sgs[secim5];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft6.Image = staticdatabase.lists.sgs[secim6].foto;
                draftsg6 = staticdatabase.lists.sgs[secim6];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft7.Image = staticdatabase.lists.sgs[secim7].foto;
                draftsg7 = staticdatabase.lists.sgs[secim7];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.sgs.Count);
                pbdraft8.Image = staticdatabase.lists.sgs[secim8].foto;
                draftsg8 = staticdatabase.lists.sgs[secim8];

                staticdatabase.lists.sgs.Remove(staticdatabase.lists.sgs[secim8]);
                sgsecildimi = true;
            }
            else if (sgsecildimi == true)
            {
                pbdraft1.Image = draftsg1.foto;
                pbdraft2.Image = draftsg2.foto;
                pbdraft3.Image = draftsg3.foto;
                pbdraft4.Image = draftsg4.foto;
                pbdraft5.Image = draftsg5.foto;
                pbdraft6.Image = draftsg6.foto;
                pbdraft7.Image = draftsg7.foto;
                pbdraft8.Image = draftsg8.foto;


            }
            lbldraft1.Text = draftsg1.name;
            lbldraft2.Text = draftsg2.name;
            lbldraft3.Text = draftsg3.name;
            lbldraft4.Text = draftsg4.name;
            lbldraft5.Text = draftsg5.name;
            lbldraft6.Text = draftsg6.name;
            lbldraft7.Text = draftsg7.name;
            lbldraft8.Text = draftsg8.name;
            #endregion
            draftpos = 2;
            oyuncusecimiinfo();
        }

        private void btnyedeksf_Click(object sender, EventArgs e)
        {
            labelgoster();
            secimbasladimi = true;

            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
            
            pbarrow3a.Image = Resources.greenarrow;
            pbarrow3b.Image = Resources.bluearrow;
            btnyedeksf.BackColor = Color.Orange;
            btnyedeksf.ForeColor = Color.Black;
            oyuncusecimiinfo();


            #region smallforwarddraft
            if (sfsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft1.Image = staticdatabase.lists.sfs[secim1].foto;
                draftsf1 = staticdatabase.lists.sfs[secim1];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft2.Image = staticdatabase.lists.sfs[secim2].foto;
                draftsf2 = staticdatabase.lists.sfs[secim2];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft3.Image = staticdatabase.lists.sfs[secim3].foto;
                draftsf3 = staticdatabase.lists.sfs[secim3];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft4.Image = staticdatabase.lists.sfs[secim4].foto;
                draftsf4 = staticdatabase.lists.sfs[secim4];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft5.Image = staticdatabase.lists.sfs[secim5].foto;
                draftsf5 = staticdatabase.lists.sfs[secim5];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft6.Image = staticdatabase.lists.sfs[secim6].foto;
                draftsf6 = staticdatabase.lists.sfs[secim6];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft7.Image = staticdatabase.lists.sfs[secim7].foto;
                draftsf7 = staticdatabase.lists.sfs[secim7];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.sfs.Count);
                pbdraft8.Image = staticdatabase.lists.sfs[secim8].foto;
                draftsf8 = staticdatabase.lists.sfs[secim8];
                staticdatabase.lists.sfs.Remove(staticdatabase.lists.sfs[secim8]);
                sfsecildimi = true;
            }
            else if (sfsecildimi == true)
            {
                pbdraft1.Image = draftsf1.foto;
                pbdraft2.Image = draftsf2.foto;
                pbdraft3.Image = draftsf3.foto;
                pbdraft4.Image = draftsf4.foto;
                pbdraft5.Image = draftsf5.foto;
                pbdraft6.Image = draftsf6.foto;
                pbdraft7.Image = draftsf7.foto;
                pbdraft8.Image = draftsf8.foto;


            }
            lbldraft1.Text = draftsf1.name;
            lbldraft2.Text = draftsf2.name;
            lbldraft3.Text = draftsf3.name;
            lbldraft4.Text = draftsf4.name;
            lbldraft5.Text = draftsf5.name;
            lbldraft6.Text = draftsf6.name;
            lbldraft7.Text = draftsf7.name;
            lbldraft8.Text = draftsf8.name;

            #endregion
            draftpos = 3;
        }

        private void btnyedekpf_Click(object sender, EventArgs e)
        {
            labelgoster();
            secimbasladimi = true;

            butonrenkleri();
            pickbutonlarigorunmez();
            arrowlar();
            
            pbarrow4a.Image = Resources.greenarrow;
            pbarrow4b.Image = Resources.bluearrow;
            btnyedekpf.BackColor = Color.Orange;
            btnyedekpf.ForeColor = Color.Black;


            #region powerforwarddraft
            if (pfsecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft1.Image = staticdatabase.lists.pfs[secim1].foto;
                draftpf1 = staticdatabase.lists.pfs[secim1];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft2.Image = staticdatabase.lists.pfs[secim2].foto;
                draftpf2 = staticdatabase.lists.pfs[secim2];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft3.Image = staticdatabase.lists.pfs[secim3].foto;
                draftpf3 = staticdatabase.lists.pfs[secim3];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft4.Image = staticdatabase.lists.pfs[secim4].foto;
                draftpf4 = staticdatabase.lists.pfs[secim4];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft5.Image = staticdatabase.lists.pfs[secim5].foto;
                draftpf5 = staticdatabase.lists.pfs[secim5];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft6.Image = staticdatabase.lists.pfs[secim6].foto;
                draftpf6 = staticdatabase.lists.pfs[secim6];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft7.Image = staticdatabase.lists.pfs[secim7].foto;
                draftpf7 = staticdatabase.lists.pfs[secim7];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.pfs.Count);
                pbdraft8.Image = staticdatabase.lists.pfs[secim8].foto;
                draftpf8 = staticdatabase.lists.pfs[secim8];
                staticdatabase.lists.pfs.Remove(staticdatabase.lists.pfs[secim8]);
                pfsecildimi = true;
            }
            else if (pfsecildimi == true)
            {
                pbdraft1.Image = draftpf1.foto;
                pbdraft2.Image = draftpf2.foto;
                pbdraft3.Image = draftpf3.foto;
                pbdraft4.Image = draftpf4.foto;
                pbdraft5.Image = draftpf5.foto;
                pbdraft6.Image = draftpf6.foto;
                pbdraft7.Image = draftpf7.foto;
                pbdraft8.Image = draftpf8.foto;


            }
            lbldraft1.Text = draftpf1.name;
            lbldraft2.Text = draftpf2.name;
            lbldraft3.Text = draftpf3.name;
            lbldraft4.Text = draftpf4.name;
            lbldraft5.Text = draftpf5.name;
            lbldraft6.Text = draftpf6.name;
            lbldraft7.Text = draftpf7.name;
            lbldraft8.Text = draftpf8.name;
            #endregion
            oyuncusecimiinfo();
            draftpos = 4;
        }

        private void btnyedekc_Click(object sender, EventArgs e)
        {
            labelgoster();
            secimbasladimi = true;
            pickbutonlarigorunmez();
            arrowlar();
           
            pbarrow5a.Image = Resources.greenarrow;
            pbarrow5b.Image = Resources.bluearrow;

            butonrenkleri();
            btnyedekc.BackColor = Color.Orange;
            btnyedekc.ForeColor = Color.Black;
            oyuncusecimiinfo();


            #region centerdraft
            if (csecildimi == false)
            {
                secim1 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft1.Image = staticdatabase.lists.cs[secim1].foto;
                draftc1 = staticdatabase.lists.cs[secim1];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim1]);

                secim2 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft2.Image = staticdatabase.lists.cs[secim2].foto;
                draftc2 = staticdatabase.lists.cs[secim2];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim2]);

                secim3 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft3.Image = staticdatabase.lists.cs[secim3].foto;
                draftc3 = staticdatabase.lists.cs[secim3];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim3]);

                secim4 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft4.Image = staticdatabase.lists.cs[secim4].foto;
                draftc4 = staticdatabase.lists.cs[secim4];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim4]);

                secim5 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft5.Image = staticdatabase.lists.cs[secim5].foto;
                draftc5 = staticdatabase.lists.cs[secim5];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim5]);

                secim6 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft6.Image = staticdatabase.lists.cs[secim6].foto;
                draftc6 = staticdatabase.lists.cs[secim6];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim6]);

                secim7 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft7.Image = staticdatabase.lists.cs[secim7].foto;
                draftc7 = staticdatabase.lists.cs[secim7];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim7]);

                secim8 = random.Next(0, staticdatabase.lists.cs.Count);
                pbdraft8.Image = staticdatabase.lists.cs[secim8].foto;
                draftc8 = staticdatabase.lists.cs[secim8];
                staticdatabase.lists.cs.Remove(staticdatabase.lists.cs[secim8]);
                csecildimi = true;
            }
            else if (csecildimi == true)
            {
                pbdraft1.Image = draftc1.foto;
                pbdraft2.Image = draftc2.foto;
                pbdraft3.Image = draftc3.foto;
                pbdraft4.Image = draftc4.foto;
                pbdraft5.Image = draftc5.foto;
                pbdraft6.Image = draftc6.foto;
                pbdraft7.Image = draftc7.foto;
                pbdraft8.Image = draftc8.foto;


            }
            lbldraft1.Text = draftc1.name;
            lbldraft2.Text = draftc2.name;
            lbldraft3.Text = draftc3.name;
            lbldraft4.Text = draftc4.name;
            lbldraft5.Text = draftc5.name;
            lbldraft6.Text = draftc6.name;
            lbldraft7.Text = draftc7.name;
            lbldraft8.Text = draftc8.name;
            #endregion
            draftpos = 5;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
