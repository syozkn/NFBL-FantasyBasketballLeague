using Bigbang.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bigbang
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }


        private int secim = 0;

        private void Form9_Load(object sender, EventArgs e)
        {
            lblinfo.Text = "Welcome to a new NFBL season. I am John. I will guide you until you get used to the team.";
            pbteam.Image = staticdatabase.teams.secilentakim.logo;
            lblteam.Text = staticdatabase.teams.secilentakim.name;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            secim++;
            if (secim == 1)
                button2.Visible = true;
            else if(secim==28)
            {
                btnnext.ForeColor = Color.Green;
                btnnext.Text = "GO!";

            }
            else if(secim==29)
            {
                Form2 frm = new Form2();
                this.Hide();
                frm.ShowDialog();
                this.Dispose();

            }

            yazilar();
        }



        private void yazilar()
        {
            
            if(secim==1)
            {
                lblinfo.Text = "Listen closely to what I'm about to tell you. NFBL is a competitive basketball league where each team is given an equal budget...";
            }
            else if(secim==2) { lblinfo.Text = "where you can improve your squad by trading players during the season."; }
            else if(secim==3) { lblinfo.Text = "You chose your team! You are ready to compete! Now I will tell you how to do this!"; }
            else if (secim == 4) { lblinfo.Text = "Let's start with the things to consider when drafting players. what do you say?"; }
            else if (secim == 5) { lblinfo.Text = "This is a typical player profile window!";
                gpplayer.Visible = true;
            }
            else if (secim == 5) { lblinfo.Text = "Look carefully at the player stats section of the table!"; }
            else if (secim == 6) { lblinfo.Text = "The stats on the left of the table show the attacking power of the player.";
                lbluc.ForeColor= Color.Red;
                lbliki.ForeColor = Color.Red;
                lblasist.ForeColor= Color.Red;

            }
            else if (secim == 7) { lblinfo.Text = "The stats to the right of the table show the player's defensive strength.";
                lbluc.ForeColor = Color.Orange;
                lbliki.ForeColor = Color.Orange;
                lblasist.ForeColor = Color.Orange;
                lblblock.ForeColor = Color.Red;
                lblsteal.ForeColor = Color.Red;
                lblrebound.ForeColor = Color.Red;
                }
            else if(secim == 8) { lblinfo.Text = "For example, the 3PTS stat shows how well the player can shoot three-pointers and is out of 100.";
                lblblock.ForeColor = Color.Orange;
                lblsteal.ForeColor = Color.Orange;
                lblrebound.ForeColor = Color.Orange;
                lbluc.ForeColor = Color.Red;
            }
            else if(secim == 9) { lblinfo.Text = "2pts shows how well he scores two points and assists shows how many positions he has secured to other players.";
                lbluc.ForeColor = Color.Orange;
                lbliki.ForeColor = Color.Red;
                lblasist.ForeColor = Color.Red;
            }
            else if(secim == 10) { lblinfo.Text = "The block stat shows how well he defends the shot.";
                lbliki.ForeColor = Color.Orange;
                lblasist.ForeColor = Color.Orange;
                lblblock.ForeColor = Color.Red;
            }
            else if (secim == 11) { lblinfo.Text = "If your block stat is good, you increase the chance of the opponent failing when he shoots."; }
            else if (secim == 12) { lblinfo.Text = "If you have good stealing skills, you can have the ball before the opponent shoots.";
                lblblock.ForeColor = Color.Orange;
                lblsteal.ForeColor= Color.Red;

            }
            else if(secim == 13) { lblinfo.Text = "And rebound, thanks to this feature, you can take an offensive rebound and attack again. \n Likewise, you do not give this chance to the opposing team.";
                    lblsteal.ForeColor = Color.Orange;
                    lblrebound.ForeColor = Color.Red;
                }
            else if (secim == 14) { lblinfo.Text = "Simply put, when he shoots, the score is compared to the attacking player's \n shooting ability versus the defender's blocking ability."; }
            else if (secim == 15) { lblinfo.Text = "This is the player's salary. If you want to play him, you have to sacrifice that money.";
                lblrebound.ForeColor = Color.Orange;
                lblsalary.ForeColor= Color.Red;


            }
            else if (secim == 16) { lblinfo.Text = "After each regular season game in the NFBL, your team earns money based on whether you win or lose."; }
            else if (secim == 17) { lblinfo.Text = " While the starting budget is 150M, you can strengthen your team throughout the league with the money you earn afterwards."; }
            else if (secim == 18) { lblinfo.Text = " You can add new players to your team by clicking the -go to transfer screen- button from the transfers window in the main menu.";
                gpfreeagents.Visible = true ;
                lblsalary.ForeColor = Color.Orange;



            }

            else if (secim == 19) { lblinfo.Text = "The regular season lasts 9 games and once it's done you can't trade anymore.  \n So make sure your team is strong enough before you get to the playoffs."; }
            else if (secim == 20) { lblinfo.Text = "This is the tactic selection window. You can see the advantages and disadvantages of each tactic by pressing on it.";
                gbtactics.Visible = true ;
            }
            else if (secim == 21) { lblinfo.Text = "You can only choose 3 tactics before each match. So make sure you choose tactics according to your opponent's situation."; }
            else if (secim == 22) { lblinfo.Text = "Each player has a position. You can play the players in different positions during the match,\n  but the form may decrease depending on the difference with the original position.";
                groupBox1.Visible = true;
            }
            else if (secim == 23) { lblinfo.Text = "As the player plays in the match, their stamina decreases. If the player  get tired,\n his performance will also decrease.";
                pil1.Visible = true;
            }
            else if (secim == 24) { lblinfo.Text = "so try to make frequent substitutions and keep your squad fresh..."; }
            else if (secim == 25) { lblinfo.Text = "All teams in the NFBL league build their teams from scratch at the start of the season.";
                groupBox3.Visible = true;
            }
            else if (secim == 27) { lblinfo.Text = "For this reason, make sure that you set up and develop your team well."; }
            else if (secim == 28) { lblinfo.Text = "I HOPE YOU LEARNED A LOT OF THINGS. YOU'LL DISCOVER THE REST. LET'S GO!"; }










        }

        private void pbteam_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            this.Hide();
            frm.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secim--;
            if (secim <= 1)
                secim = 1;
            yazilar();
        }
    }
}
