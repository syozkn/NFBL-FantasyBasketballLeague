using Bigbang.classes;
using Bigbang.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bigbang.staticdatabase
{
    [Serializable]
    public static class shootingguards
    {
       public static oyuncu simons       = new oyuncu();
       public static oyuncu beal         = new oyuncu();
       public static oyuncu hield        = new oyuncu();
       public static oyuncu levert       = new oyuncu();
       public static oyuncu mccollum        = new oyuncu();
       public static oyuncu murray       = new oyuncu();
       public static oyuncu bane            = new oyuncu();
       public static oyuncu booker       = new oyuncu();
       public static oyuncu brooks       = new oyuncu();
       public static oyuncu trent           = new oyuncu();
       public static oyuncu ivey             = new oyuncu();
       public static oyuncu brunson      = new oyuncu();
       public static oyuncu green        = new oyuncu();
       public static oyuncu clarkson         = new oyuncu();
       public static oyuncu poole       = new oyuncu();
       public static oyuncu hart         = new oyuncu();
       public static oyuncu kcp         = new oyuncu();
       public static oyuncu heurter         = new oyuncu();
       public static oyuncu klay        = new oyuncu();
       public static oyuncu walker       = new oyuncu();
       public static oyuncu beasley      = new oyuncu();
       public static oyuncu monk            = new oyuncu();
       public static oyuncu smart        = new oyuncu();
       public static oyuncu powell          = new oyuncu();
       public static oyuncu barett           = new oyuncu();
       public static oyuncu seth            = new oyuncu();
       public static oyuncu shai         = new oyuncu();
       public static oyuncu hardaway         = new oyuncu();
       public static oyuncu herro           = new oyuncu();
       public static oyuncu maxey                 = new oyuncu();
       public static oyuncu lavine      = new oyuncu();


        public static void SaveState()  //1
        {
            using (var stream = new FileStream("shootingguards.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, simons  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, beal    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, hield   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, levert  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, mccollum);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, murray  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, bane    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, booker  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, brooks  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, trent   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, ivey    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, brunson );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, green   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, clarkson);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, poole   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, hart    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kcp     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, heurter );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, klay    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, walker  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, beasley );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, monk    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, smart   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, powell  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, barett  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, seth    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, shai    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, hardaway);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, herro   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, maxey   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, lavine);
                stream.FlushAsync();
                stream.Close();

            }
        }

        public static void LoadState()
        {
            if (File.Exists("shootingguards.bin"))
            {
                using (var stream = new FileStream("shootingguards.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                   simons   = (oyuncu)formatter.Deserialize(stream);
                   beal     = (oyuncu)formatter.Deserialize(stream);
                   hield    = (oyuncu)formatter.Deserialize(stream);
                   levert   = (oyuncu)formatter.Deserialize(stream);
                    mccollum = (oyuncu)formatter.Deserialize(stream);
                     murray   = (oyuncu)formatter.Deserialize(stream);
                     bane     = (oyuncu)formatter.Deserialize(stream);
                     booker   = (oyuncu)formatter.Deserialize(stream);
                     brooks   = (oyuncu)formatter.Deserialize(stream);
                     trent    = (oyuncu)formatter.Deserialize(stream);
                     ivey     = (oyuncu)formatter.Deserialize(stream);
                     brunson  = (oyuncu)formatter.Deserialize(stream);
                     green    = (oyuncu)formatter.Deserialize(stream);
                     clarkson = (oyuncu)formatter.Deserialize(stream);
                    poole = (oyuncu)formatter.Deserialize(stream);
                    hart     = (oyuncu)formatter.Deserialize(stream);
                    kcp      = (oyuncu)formatter.Deserialize(stream);
                    heurter  = (oyuncu)formatter.Deserialize(stream);
                    klay     = (oyuncu)formatter.Deserialize(stream);
                    walker   = (oyuncu)formatter.Deserialize(stream);
                    beasley  = (oyuncu)formatter.Deserialize(stream);
                    monk     = (oyuncu)formatter.Deserialize(stream);
                    smart    = (oyuncu)formatter.Deserialize(stream);
                    powell   = (oyuncu)formatter.Deserialize(stream);
                    barett = (oyuncu)formatter.Deserialize(stream);
                    seth     = (oyuncu)formatter.Deserialize(stream);
                    shai     = (oyuncu)formatter.Deserialize(stream);
                    hardaway = (oyuncu)formatter.Deserialize(stream);
                    herro    = (oyuncu)formatter.Deserialize(stream);
                    maxey    = (oyuncu)formatter.Deserialize(stream);
                    lavine = (oyuncu)formatter.Deserialize(stream);

                }
            }
        }

        public static void LoadStatey()
        {
            if (File.Exists("shootingguardsa.bin"))
            {
                using (var stream = new FileStream("shootingguardsa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    simons = (oyuncu)formatter.Deserialize(stream);
                    beal = (oyuncu)formatter.Deserialize(stream);
                    hield = (oyuncu)formatter.Deserialize(stream);
                    levert = (oyuncu)formatter.Deserialize(stream);
                    mccollum = (oyuncu)formatter.Deserialize(stream);
                    murray = (oyuncu)formatter.Deserialize(stream);
                    bane = (oyuncu)formatter.Deserialize(stream);
                    booker = (oyuncu)formatter.Deserialize(stream);
                    brooks = (oyuncu)formatter.Deserialize(stream);
                    trent = (oyuncu)formatter.Deserialize(stream);
                    ivey = (oyuncu)formatter.Deserialize(stream);
                    brunson = (oyuncu)formatter.Deserialize(stream);
                    green = (oyuncu)formatter.Deserialize(stream);
                    clarkson = (oyuncu)formatter.Deserialize(stream);
                    poole = (oyuncu)formatter.Deserialize(stream);
                    hart = (oyuncu)formatter.Deserialize(stream);
                    kcp = (oyuncu)formatter.Deserialize(stream);
                    heurter = (oyuncu)formatter.Deserialize(stream);
                    klay = (oyuncu)formatter.Deserialize(stream);
                    walker = (oyuncu)formatter.Deserialize(stream);
                    beasley = (oyuncu)formatter.Deserialize(stream);
                    monk = (oyuncu)formatter.Deserialize(stream);
                    smart = (oyuncu)formatter.Deserialize(stream);
                    powell = (oyuncu)formatter.Deserialize(stream);
                    barett = (oyuncu)formatter.Deserialize(stream);
                    seth = (oyuncu)formatter.Deserialize(stream);
                    shai = (oyuncu)formatter.Deserialize(stream);
                    hardaway = (oyuncu)formatter.Deserialize(stream);
                    herro = (oyuncu)formatter.Deserialize(stream);
                    maxey = (oyuncu)formatter.Deserialize(stream);
                    lavine = (oyuncu)formatter.Deserialize(stream);

                }
            }
        }

        public static void shootingguardyarat()
        {
            simons.name = "A.ZAMONS";
            simons.foto = Resources.anfernee_simons;
            simons.pozisyon = enums.position.sg;
            
            simons.ucluk = 85;
            simons.ikilik = 75;
            simons.asist = 67;
            simons.steal = 78;
            simons.block = 66;
            simons.rebound = 41;
            simons.spec = enums.special.Normal;
           ;

            beal.name = "B.BAYEL";
            beal.foto = Resources.bradley_beal;
            beal.pozisyon = enums.position.sg;
           
            beal.ucluk = 85;
            beal.ikilik = 85;
            beal.asist = 79;
            beal.steal = 76;
            beal.block = 75;
            beal.rebound = 39;
            beal.spec = enums.special.MoreandMore;
           

            hield.name = "B.HAYELD";
            hield.foto = Resources.Buddy_Hield;
            hield.pozisyon = enums.position.sg;
            
            hield.ucluk = 94;
            hield.ikilik = 78;
            hield.asist = 49;
            hield.steal = 86;
            hield.block = 74;
            hield.rebound = 72;
            hield.spec = enums.special.Normal;
           

            levert.name = "C.LOYARD";
            levert.foto = Resources.Caris_LeVert;
            levert.pozisyon = enums.position.sg;
            
            levert.ucluk = 74;
            levert.ikilik = 68;
            levert.asist = 77;
            levert.steal = 61;
            levert.block = 36;
            levert.rebound = 60;
            levert.spec = enums.special.Battery;
           

            mccollum.name = "D.J.MCDONALD";
            mccollum.foto = Resources.CJ_McCollum;
            mccollum.pozisyon = enums.position.sg;
            
            mccollum.ucluk = 82;
            mccollum.ikilik = 81;
            mccollum.asist = 83;
            mccollum.steal = 81;
            mccollum.block = 85;
            mccollum.rebound = 63;
            mccollum.spec = enums.special.Battery;
           

            murray.name = "D.J.MURRAT";
            murray.foto = Resources.Dejounte_Murray;
            murray.pozisyon = enums.position.sg;
            
            murray.ucluk = 88;
            murray.ikilik = 89;
            murray.asist = 84;
            murray.steal = 94;
            murray.block = 86;
            murray.rebound = 74;
            murray.spec = enums.special.Normal;
            

            bane.name = "D.BANNED";
            bane.foto = Resources.desmond_bane;
            bane.pozisyon = enums.position.sg;
           
            bane.ucluk = 79;
            bane.ikilik = 67;
            bane.asist = 75;
            bane.steal = 36;
            bane.block = 46;
            bane.rebound = 35;
            bane.spec = enums.special.Battery;
           

            booker.name = "D.CHOOKER";
            booker.foto = Resources.devin_booker;
            booker.pozisyon = enums.position.sg;
            
            booker.ucluk = 93;
            booker.ikilik = 93;
            booker.asist = 82;
            booker.steal = 83;
            booker.block = 81;
            booker.rebound = 71;
            booker.spec = enums.special.Clutch;
            

            brooks.name = "D.BROKER";
            brooks.foto = Resources.Dillon_Brooks;
            brooks.pozisyon = enums.position.sg;
            
            brooks.ucluk = 85;
            brooks.ikilik = 81;
            brooks.asist = 57;
            brooks.steal = 75;
            brooks.block = 53;
            brooks.rebound = 51;
            brooks.spec = enums.special.Normal;
           

            trent.name = "G.DREAMT SN";
            trent.foto = Resources.Gary_Trent_Jr_;
            trent.pozisyon = enums.position.sg;
            
            trent.ucluk = 87;
            trent.ikilik = 78;
            trent.asist = 23;
            trent.steal = 93;
            trent.block = 55;
            trent.rebound = 25;
            trent.spec = enums.special.Normal;
            


            ivey.name = "J.AVEY";
            ivey.foto = Resources.Jaden_Ivey;
            ivey.pozisyon = enums.position.sg;
            
            ivey.ucluk = 79;
            ivey.ikilik = 79;
            ivey.asist = 72;
            ivey.steal = 85;
            ivey.block = 71;
            ivey.rebound = 66;
            ivey.spec = enums.special.Normal;
            

            brunson.name = "J.BRANDON";
            brunson.foto = Resources.jalen_Brunson;
            brunson.pozisyon = enums.position.sg;
            
            brunson.ucluk = 80;
            brunson.ikilik = 83;
            brunson.asist = 85;
            brunson.steal = 82;
            brunson.block = 61;
            brunson.rebound = 57;
            brunson.spec = enums.special.Chef;
            

            green.name = "J.GREENIES";
            green.foto = Resources.jalen_green;
            green.pozisyon = enums.position.sg;
            
            green.ucluk = 90;
            green.ikilik = 89;
            green.asist = 65;
            green.steal = 73;
            green.block = 65;
            green.rebound = 62;
            green.spec = enums.special.Normal;
            

            clarkson.name = "K.KLARKBOY";
            clarkson.foto = Resources.Jordan_Clarkson;
            clarkson.pozisyon = enums.position.sg;
            
            clarkson.ucluk = 93;
            clarkson.ikilik = 88;
            clarkson.asist = 78;
            clarkson.steal = 46;
            clarkson.block = 74;
            clarkson.rebound = 64;
            clarkson.spec = enums.special.Normal;
           

            poole.name = "J.POLE";
            poole.foto = Resources.Jordan_Poole;
            poole.pozisyon = enums.position.sg;
            
            poole.ucluk = 90;
            poole.ikilik = 84;
            poole.asist = 81;
            poole.steal = 76;
            poole.block = 75;
            poole.rebound = 35;
            poole.spec = enums.special.Normal;
            

            hart.name = "J.HEART";
            hart.foto = Resources.Josh_Hart;
            hart.pozisyon = enums.position.sg;
            
            hart.ucluk = 59;
            hart.ikilik = 67;
            hart.asist = 67;
            hart.steal = 92;
            hart.block = 50;
            hart.rebound = 86;
            hart.spec = enums.special.Normal;
           

            kcp.name = "K.C.ROPE";
            kcp.foto = Resources.Kentavious_Caldwell_Pope;
            kcp.pozisyon = enums.position.sg;
            
            kcp.ucluk = 80;
            kcp.ikilik = 62;
            kcp.asist = 41;
            kcp.steal = 88;
            kcp.block = 79;
            kcp.rebound = 41;
            kcp.spec = enums.special.Normal;
            

            heurter.name = "K.HARTER";
            heurter.foto = Resources.Kevin_Huerter;
            heurter.pozisyon = enums.position.sg;
            
            heurter.ucluk = 89;
            heurter.ikilik = 74;
            heurter.asist = 61;
            heurter.steal = 85;
            heurter.block = 75;
            heurter.rebound = 53;
            heurter.spec = enums.special.Normal;
            

            klay.name = "K.SPLASH";
            klay.foto = Resources.Klay_Thompson;
            klay.pozisyon = enums.position.sg;
            
            klay.ucluk = 87;
            klay.ikilik = 84;
            klay.asist = 70;
            klay.steal = 60;
            klay.block = 79;
            klay.rebound = 71;
            klay.spec = enums.special.Closer;
            

            walker.name = "L.TALKER";
            walker.foto = Resources.Lonnie_Walker_IV;
            walker.pozisyon = enums.position.sg;
            
            walker.ucluk = 82;
            walker.ikilik = 78;
            walker.asist = 28;
            walker.steal = 69;
            walker.block = 74;
            walker.rebound = 30;
            walker.spec = enums.special.Normal;
            

            beasley.name = "M.BEASTLY";
            beasley.foto = Resources.Malik_Beasley;
            beasley.pozisyon = enums.position.sg;
            
            beasley.ucluk = 91;
            beasley.ikilik = 71;
            beasley.asist = 32;
            beasley.steal = 87;
            beasley.block = 73;
            beasley.rebound = 67;
            beasley.spec = enums.special.Battery;
            

            monk.name = "M.DANK";
            monk.foto = Resources.malik_monk;
            monk.pozisyon = enums.position.sg;
            
            monk.ucluk = 83;
            monk.ikilik = 76;
            monk.asist = 84;
            monk.steal = 65;
            monk.block = 41;
            monk.rebound = 53;
            monk.spec = enums.special.Normal;
           

            smart.name = "M.CLEVER";
            smart.foto = Resources.Marcus_Smart;
            smart.pozisyon = enums.position.sg;
            
            smart.ucluk = 85;
            smart.ikilik = 85;
            smart.asist = 91;
            smart.steal = 89;
            smart.block = 90;
            smart.rebound = 44;
            smart.spec = enums.special.Tower;
            

            powell.name = "N.POWER";
            powell.foto = Resources.Norman_Powell;
            powell.pozisyon = enums.position.sg;
            
            powell.ucluk = 76;
            powell.ikilik = 74;
            powell.asist = 34;
            powell.steal = 68;
            powell.block = 72;
            powell.rebound = 39;
            powell.spec = enums.special.Normal;
            

            barett.name = "D.J.BART";
            barett.foto = Resources.RJ_Barrett;
            barett.pozisyon = enums.position.sg;
            
            barett.ucluk = 85;
            barett.ikilik = 88;
            barett.asist = 54;
            barett.steal = 65;
            barett.block = 65;
            barett.rebound = 78;
            barett.spec = enums.special.Normal;
           

            seth.name = "S.SHARP";
            seth.foto = Resources.Seth_Curry;
            seth.pozisyon = enums.position.sg;
            
            seth.ucluk = 85;
            seth.ikilik = 32;
            seth.asist = 62;
            seth.steal = 45;
            seth.block = 55;
            seth.rebound = 49;
            seth.spec = enums.special.MoreandMore;
            

            shai.name = "T.G.ALEX";
            shai.foto = Resources.Shai_Gilgeous_Alexande;
            shai.pozisyon = enums.position.sg;
           
            shai.ucluk = 81;
            shai.ikilik = 96;
            shai.asist = 82;
            shai.steal = 93;
            shai.block = 80;
            shai.rebound = 65;
            shai.spec = enums.special.Normal;
           

            hardaway.name = "T.PAREDAY JR";
            hardaway.foto = Resources.Tim_Hardaway_Jr;
            hardaway.pozisyon = enums.position.sg;
            
            hardaway.ucluk = 86;
            hardaway.ikilik = 61;
            hardaway.asist = 43;
            hardaway.steal = 75;
            hardaway.block = 52;
            hardaway.rebound = 38;
            hardaway.spec = enums.special.Battery;
            

            herro.name = "T.HELLO";
            herro.foto = Resources.Tyler_Herro;
            herro.pozisyon = enums.position.sg;
           
            herro.ucluk = 84;
            herro.ikilik = 77;
            herro.asist = 69;
            herro.steal = 63;
            herro.block = 82;
            herro.rebound = 72;
            herro.spec = enums.special.Battery;
            

            maxey.name = "T.MAXIMUM";
            maxey.foto = Resources.tyrese_maxey;
            maxey.pozisyon = enums.position.sg;
            
            maxey.ucluk = 80;
            maxey.ikilik = 76;
            maxey.asist = 68;
            maxey.steal = 59;
            maxey.block = 61;
            maxey.rebound = 30;
            maxey.spec = enums.special.Normal;
           

            lavine.name = "Z.LAWON";
            lavine.foto = Resources.Zach_LaVine;
            lavine.pozisyon = enums.position.sg;
            
            lavine.ucluk = 89;
            lavine.ikilik = 86;
            lavine.asist = 68;
            lavine.steal = 85;
            lavine.block = 75;
            lavine.rebound = 60;
            lavine.spec = enums.special.Closer;



            lists.sgs.Add(shai);//1
            lists.sgs2.Add(shai);

            lists.sgs.Add(booker);//2
            lists.sgs2.Add(booker);

            lists.sgs.Add(smart);//3
            lists.sgs2.Add(smart);

            lists.sgs.Add(murray);//4
            lists.sgs2.Add(murray);

            lists.sgs.Add(klay);//5
            lists.sgs2.Add(klay);

            lists.sgs.Add(lavine); //6
            lists.sgs2.Add(lavine);

            lists.sgs.Add(clarkson);//7
            lists.sgs2.Add(clarkson);

            lists.sgs.Add(hield);//8
            lists.sgs2.Add(hield);

            lists.sgs.Add(beal);//9
            lists.sgs2.Add(beal);

            lists.sgs.Add(barett); //21 -------------------------------
            lists.sgs2.Add(barett);

            lists.sgs.Add(poole);//10
            lists.sgs2.Add(poole);

            lists.sgs.Add(mccollum);//11
            lists.sgs2.Add(mccollum);

            lists.sgs.Add(herro);//12
            lists.sgs2.Add(herro);

            lists.sgs.Add(green);//13
            lists.sgs2.Add(green);

            lists.sgs.Add(heurter);//14
            lists.sgs2.Add(heurter);

            lists.sgs.Add(beasley);//15
            lists.sgs2.Add(beasley);

            lists.sgs.Add(walker);//16
            lists.sgs2.Add(walker);

            lists.sgs.Add(ivey);//17
            lists.sgs2.Add(ivey);

            lists.sgs.Add(simons); //18
            lists.sgs2.Add(simons);

            lists.sgs.Add(brunson); //19
            lists.sgs2.Add(brunson);

            lists.sgs.Add(kcp);//20
            lists.sgs2.Add(kcp);


            lists.sgs.Add(hardaway);//22
            lists.sgs2.Add(hardaway);

            lists.sgs.Add(powell);//23
            lists.sgs2.Add(powell);

            lists.sgs.Add(trent);//24
            lists.sgs2.Add(trent);

            lists.sgs.Add(monk);//25
            lists.sgs2.Add(monk);

            lists.sgs.Add(brooks);//26
            lists.sgs2.Add(brooks);

            lists.sgs.Add(maxey); //27
            lists.sgs2.Add(maxey);

            lists.sgs.Add(bane);//28
            lists.sgs2.Add(bane);

            lists.sgs.Add(levert);//29
            lists.sgs2.Add(levert);

            lists.sgs.Add(hart);//30
            lists.sgs2.Add(hart);

            lists.sgs.Add(seth);//31
            lists.sgs2.Add(seth);



        }


    }
}
