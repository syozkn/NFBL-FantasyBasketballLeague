using Bigbang.classes;
using Bigbang.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;

namespace Bigbang.staticdatabase
{
    [Serializable]
    public static class lists
    {
        public static SoundPlayer arkafon = new SoundPlayer(Resources.sarki4);
        

        public static int saveload = 0;
        //başlangıç pozisyonlara göre oyuncu listeleri.
        public static List<oyuncu> pgs = new List<oyuncu>();
        public static List<oyuncu> sgs = new List<oyuncu>();
        public static List<oyuncu> sfs = new List<oyuncu>();
        public static List<oyuncu> pfs = new List<oyuncu>();
        public static List<oyuncu> cs = new List<oyuncu>();


        public static List<oyuncu> pgs2 = new List<oyuncu>();
        public static List<oyuncu> sgs2 = new List<oyuncu>();
        public static List<oyuncu> sfs2  = new List<oyuncu>();
        public static List<oyuncu> pfs2  = new List<oyuncu>();
        public static List<oyuncu> cs2  = new List<oyuncu>();

        public static int  butce;
        public static int  playoffmacsayisi     = 0;
        public static bool playoffiki       = false;
        public static bool lig              = false;
        public static bool playoff2mac      = false;
        public static bool final             = false;
        public static bool sarkivarmi           = false;
        public static int  kazan              = 0;
        public static int  kaybet             = 0;
        public static bool macsonuc             =false;

        public static bool macyapildimi = false;

        public static string fskor3 = "0";
        public static string fskor4 = "0";
        public static string fskor5 = "0";
        public static string fskor6 = "0";
        public static string fskor7 = "0";
        public static string fskor8 = "0";
        public static string fskor9 = "0";
        public static string fskor10 = "0";
        public static string fskor11 = "0";
        public static string fskor12 = "0";

        public static bool transfer = false;

        public static List<oyuncu> oyuncus = new List<oyuncu>();

        public static tactics normal        = new tactics();
        public static tactics isolation     = new tactics();
        public static tactics pickandroll   = new tactics();
        public static tactics postup        = new tactics();
        public static tactics paceandspace  = new tactics();
        public static tactics slow          = new tactics();
        public static tactics three         =new tactics();
        public static tactics two           =new tactics();
        public static tactics tactics       = new tactics();
        public static tactics pickandroll2 = new tactics();

        public static tactics zone= new tactics();
        public static tactics mantoman = new tactics();
        public static tactics doubleteam= new tactics();

        //FORM 6'DAN GELENLER
        public static team rakip = new team();
        public static bool birincieslesme = false;
        public static bool ikincieslesme = false;
        public static bool ucuncueslesme = false;
        public static bool dorduncueslesme = false;

        //FORM 7'DEN GELENLER
        public static team rakip2 = new team();

        //FORM 8'DEN GELENLER
        public static team finalrakip = new team();

        //saveiçin gerekenler
        public static int saveok=0;
        public static bool dosyavarmi = false;
        public static bool load = false;


        public static void SaveStateForm6()     //2
        {
            using (var stream = new FileStream("playoff.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, rakip);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, birincieslesme);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, ikincieslesme);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, ucuncueslesme);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, dorduncueslesme);
                stream.FlushAsync();
                stream.Close();

            }
        }

        public static void LoadStateForm6()
        {
            if (File.Exists("playoff.bin"))
            {
                using (var stream = new FileStream("playoff.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    rakip = (team)formatter.Deserialize(stream);
                    birincieslesme = (bool)formatter.Deserialize(stream);
                    ikincieslesme = (bool)formatter.Deserialize(stream);
                    ucuncueslesme = (bool)formatter.Deserialize(stream);
                    dorduncueslesme = (bool)formatter.Deserialize(stream);
                }
            }
        }

        public static void LoadStateForm6y()
        {
            if (File.Exists("playoffa.bin"))
            {
                using (var stream = new FileStream("playoffa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    rakip = (team)formatter.Deserialize(stream);
                    birincieslesme = (bool)formatter.Deserialize(stream);
                    ikincieslesme = (bool)formatter.Deserialize(stream);
                    ucuncueslesme = (bool)formatter.Deserialize(stream);
                    dorduncueslesme = (bool)formatter.Deserialize(stream);
                }
            }
        }

        public static void SaveStateForm7() //3
        {
            using (var stream = new FileStream("playoff1.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, rakip);
                stream.FlushAsync();
                stream.Close();

            }
        }
        public static void LoadStateForm7()
        {
            if (File.Exists("playoff1.bin"))
            {
                using (var stream = new FileStream("playoff1.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    rakip = (team)formatter.Deserialize(stream);

                }
            }
        }

        public static void LoadStateForm7y()
        {
            if (File.Exists("playoff1a.bin"))
            {
                using (var stream = new FileStream("playoff1a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    rakip = (team)formatter.Deserialize(stream);

                }
            }
        }
        public static void SaveStateForm8() //4
        {
            using (var stream = new FileStream("playoff2.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, finalrakip);
                
                stream.FlushAsync();
                stream.Close();

            }
        }
        public static void LoadStateForm8()
        {
            if (File.Exists("playoff2.bin"))
            {
                using (var stream = new FileStream("playoff2.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    finalrakip = (team)formatter.Deserialize(stream);
                    

                }
            }
        }
        public static void LoadStateForm8y()
        {
            if (File.Exists("playoff2a.bin"))
            {
                using (var stream = new FileStream("playoff2a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    finalrakip = (team)formatter.Deserialize(stream);
                    

                }
            }
        }



        public static void SaveState() //1
        {
            using (var stream = new FileStream("lists.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, pgs);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, sgs);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, sfs);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, pfs);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, cs);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, pgs2);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, sgs2);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, sfs2);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, pfs2);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, cs2);
                stream.FlushAsync();
                stream.Close();








            }
        }
        public static void SaveState2()  
        {
            using (var stream = new FileStream("lists2.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, butce);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, playoffmacsayisi);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, playoffiki);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, lig);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, playoff2mac);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, final);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, sarkivarmi);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kazan);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kaybet);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, macsonuc);
                stream.FlushAsync();
                stream.Close();
            }
        }
        public static void SaveState3()
        {
            using (var stream = new FileStream("lists3.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, macyapildimi);

                formatter.Serialize(stream, fskor3);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor4);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor5);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor6);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor7);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor8);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor9);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor10);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor11);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fskor12);
                stream.FlushAsync();
                stream.Close();

            }
        }
        public static void SaveState4()    
        {
            using (var stream = new FileStream("lists4.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                stream.FlushAsync();
                
                formatter.Serialize(stream, transfer);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);

                formatter.Serialize(stream, oyuncus);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);

                formatter.Serialize(stream, normal);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, isolation);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, pickandroll);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, postup);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, paceandspace);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, slow);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, three);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, two);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, saveload);
                stream.FlushAsync();
                stream.Close();



            }
        }






        public static void LoadState()
        {
            if (File.Exists("lists.bin"))
            {
                using (var stream = new FileStream("lists.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    pgs  = (List<oyuncu>)formatter.Deserialize(stream);
                    sgs  = (List<oyuncu>)formatter.Deserialize(stream);
                    sfs = (List<oyuncu>)formatter.Deserialize(stream);
                    pfs = (List<oyuncu>)formatter.Deserialize(stream);
                    cs = (List<oyuncu>)formatter.Deserialize(stream);
                    pgs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    sgs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    sfs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    pfs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    cs2 = (List<oyuncu>)formatter.Deserialize(stream);
                  
                }                 
            }
        }
        public static void LoadStatey()
        {
            if (File.Exists("listsa.bin"))
            {
                using (var stream = new FileStream("listsa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    pgs = (List<oyuncu>)formatter.Deserialize(stream);
                    sgs = (List<oyuncu>)formatter.Deserialize(stream);
                    sfs = (List<oyuncu>)formatter.Deserialize(stream);
                    pfs = (List<oyuncu>)formatter.Deserialize(stream);
                    cs = (List<oyuncu>)formatter.Deserialize(stream);
                    pgs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    sgs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    sfs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    pfs2 = (List<oyuncu>)formatter.Deserialize(stream);
                    cs2 = (List<oyuncu>)formatter.Deserialize(stream);

                }
            }
        }
        public static void LoadState2()
        {
            if (File.Exists("lists2.bin"))
            {
                using (var stream = new FileStream("lists2.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    butce = (int)formatter.Deserialize(stream);
                    playoffmacsayisi = (int)formatter.Deserialize(stream);
                    playoffiki = (bool)formatter.Deserialize(stream);
                    lig = (bool)formatter.Deserialize(stream);
                    playoff2mac = (bool)formatter.Deserialize(stream);
                    final = (bool)formatter.Deserialize(stream);
                    sarkivarmi = (bool)formatter.Deserialize(stream);
                    kazan = (int)formatter.Deserialize(stream);
                    kaybet = (int)formatter.Deserialize(stream);
                    macsonuc = (bool)formatter.Deserialize(stream);

                }
            }
        }
        public static void LoadState2y()
        {
            if (File.Exists("lists2a.bin"))
            {
                using (var stream = new FileStream("lists2a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    butce = (int)formatter.Deserialize(stream);
                    playoffmacsayisi = (int)formatter.Deserialize(stream);
                    playoffiki = (bool)formatter.Deserialize(stream);
                    lig = (bool)formatter.Deserialize(stream);
                    playoff2mac = (bool)formatter.Deserialize(stream);
                    final = (bool)formatter.Deserialize(stream);
                    sarkivarmi = (bool)formatter.Deserialize(stream);
                    kazan = (int)formatter.Deserialize(stream);
                    kaybet = (int)formatter.Deserialize(stream);
                    macsonuc = (bool)formatter.Deserialize(stream);

                }
            }
        }
        public static void LoadState3()
        {
            if (File.Exists("lists3.bin"))
            {
                using (var stream = new FileStream("lists3.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    macyapildimi = (bool)formatter.Deserialize(stream);

                    fskor3 = (string)formatter.Deserialize(stream);
                    fskor4 = (string)formatter.Deserialize(stream);
                    fskor5 = (string)formatter.Deserialize(stream);
                    fskor6 = (string)formatter.Deserialize(stream);
                    fskor7 = (string)formatter.Deserialize(stream);
                    fskor8 = (string)formatter.Deserialize(stream);
                    fskor9 = (string)formatter.Deserialize(stream);
                    fskor10 = (string)formatter.Deserialize(stream);
                    fskor11 = (string)formatter.Deserialize(stream);
                    fskor12 = (string)formatter.Deserialize(stream);


                }
            }
        }
        public static void LoadState3y()
        {
            if (File.Exists("lists3a.bin"))
            {
                using (var stream = new FileStream("lists3a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    macyapildimi = (bool)formatter.Deserialize(stream);

                    fskor3 = (string)formatter.Deserialize(stream);
                    fskor4 = (string)formatter.Deserialize(stream);
                    fskor5 = (string)formatter.Deserialize(stream);
                    fskor6 = (string)formatter.Deserialize(stream);
                    fskor7 = (string)formatter.Deserialize(stream);
                    fskor8 = (string)formatter.Deserialize(stream);
                    fskor9 = (string)formatter.Deserialize(stream);
                    fskor10 = (string)formatter.Deserialize(stream);
                    fskor11 = (string)formatter.Deserialize(stream);
                    fskor12 = (string)formatter.Deserialize(stream);


                }
            }
        }
        public static void LoadState4()
        {
            if (File.Exists("lists4.bin"))
            {
                using (var stream = new FileStream("lists4.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    transfer = (bool)formatter.Deserialize(stream);

                    oyuncus = (List<oyuncu>)formatter.Deserialize(stream);

                    normal = (tactics)formatter.Deserialize(stream);
                    isolation = (tactics)formatter.Deserialize(stream);
                    pickandroll = (tactics)formatter.Deserialize(stream);
                    postup = (tactics)formatter.Deserialize(stream);
                    paceandspace = (tactics)formatter.Deserialize(stream);
                    slow = (tactics)formatter.Deserialize(stream);
                    three = (tactics)formatter.Deserialize(stream);
                    two = (tactics)formatter.Deserialize(stream);
                    saveload = (int)formatter.Deserialize(stream);

                }
            }
        }
        public static void LoadState4y()
        {
            if (File.Exists("lists4a.bin"))
            {
                using (var stream = new FileStream("lists4a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    transfer = (bool)formatter.Deserialize(stream);

                    oyuncus = (List<oyuncu>)formatter.Deserialize(stream);

                    normal = (tactics)formatter.Deserialize(stream);
                    isolation = (tactics)formatter.Deserialize(stream);
                    pickandroll = (tactics)formatter.Deserialize(stream);
                    postup = (tactics)formatter.Deserialize(stream);
                    paceandspace = (tactics)formatter.Deserialize(stream);
                    slow = (tactics)formatter.Deserialize(stream);
                    three = (tactics)formatter.Deserialize(stream);
                    two = (tactics)formatter.Deserialize(stream);
                    saveload = (int)formatter.Deserialize(stream);

                }
            }
        }



        public static void createtactic()
        {
            normal.name = "NORMAL";
            normal.resim = Resources.N;
            normal.resim2 = Resources.N2;
            normal.pros = "Standart offense and defense";
            normal.cons = "Standart offense and defense";

            isolation.name = "ISOLATION";
            isolation.resim = Resources.ISO;
            isolation.resim2 = Resources.ISO2;
            isolation.pros = "Allows attacking with the selected player";
            isolation.cons = "The selected player's stamina drops more";

            pickandroll.name = "FORCE SWITCH";
            pickandroll.resim = Resources.PR;
            pickandroll.resim2 = Resources.PR2;
            pickandroll.pros = "Players to attack someone different from their pos";
            pickandroll.cons = "A player in another position can defend him better.";

            postup.name = "POST UP";
            postup.resim = Resources.POST;
            postup.resim2 = Resources.POST2;
            postup.pros = "Allows one-on-one attacking with C or PF players.";
            postup.cons = "Creates an extra stamina drop on the attacking player.";

            paceandspace.name = "PACE and SPACE";
            paceandspace.resim = Resources.PC;
            paceandspace.resim2 = Resources.PC2;
            paceandspace.pros = "Allows faster attack, creates more empty shoot";
            paceandspace.cons = "Increase turnover rate";

            slow.name = "SLOW TEMPO";
            slow.resim = Resources.SLOW;
            slow.resim2 = Resources.SLOW2;
            slow.pros = "Allows slower attack, decreases turnover rate";
            slow.cons = "It means fewer attacks, ";

            three.name = "3 POINTER";
            three.resim = Resources.ucluk1;
            three.resim2 =Resources.ucluk2;
            three.pros = "Team tries to shoot more from distance";
            three.cons = "Extra stamina loss per shoot";

            two.name = "INSIDE PLAY";
            two.resim = Resources.iki;
            two.resim2 = Resources.iki2;
            two.pros = "Team tries to play inside with 2 pointers";
            two.cons = "Extra stamina loss per shoot";

            pickandroll2.name = "PICK AND ROLL";
            pickandroll2.resim = Resources.pickandroll;
            pickandroll2.resim2 = Resources.pickandroll2;
            pickandroll2.pros = "Collab. with a teammate increases the probability of scoring";
            pickandroll2.cons = "The supporting player also loses extra stamina.";


            zone.name = "ZONE DEFENSE";
            zone.resim = Resources.zone;
            zone.resim2 = Resources.zone2;
            zone.pros = "Makes it difficult for the opponent to score inside.";
            zone.cons = "Makes it easier for the opponent to find an outside shot.";

            mantoman.name = "MAN TO MAN";
            mantoman.resim = Resources.mantoman;
            mantoman.resim2 = Resources.mantoman2;
            mantoman.pros = "The players play man-to-man defense.";
            mantoman.cons = "The players play man-to-man defense.";

            doubleteam.name = "DOUBLE TEAM";
            doubleteam.resim = Resources.doubleteam;
            doubleteam.resim2 = Resources.doubleteam2;
            doubleteam.pros = "It makes it difficult for the selected player score.";
            doubleteam.cons = "It creates space for other players.";









        }


    }
}
