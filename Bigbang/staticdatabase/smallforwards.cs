using Bigbang.classes;
using Bigbang.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bigbang.staticdatabase
{
    [Serializable]
    public static class smallforwards
    {
       public static oyuncu wiggins      = new oyuncu();
       public static oyuncu ingram       = new oyuncu();
       public static oyuncu osman        = new oyuncu();
       public static oyuncu hunter       = new oyuncu();
       public static oyuncu derozan      = new oyuncu();
       public static oyuncu vassell      = new oyuncu();
       public static oyuncu george       = new oyuncu();
       public static oyuncu brown        = new oyuncu();
       public static oyuncu tatum       = new oyuncu();
       public static oyuncu butler       = new oyuncu();
       public static oyuncu johnson      = new oyuncu();
       public static oyuncu oubre        = new oyuncu();
       public static oyuncu markkanen        = new oyuncu();
       public static oyuncu porter       = new oyuncu();
       public static oyuncu bridges         = new oyuncu();
       public static oyuncu batum       = new oyuncu();
       public static oyuncu annunoby         = new oyuncu();
       public static oyuncu saddiq      = new oyuncu();
       public static oyuncu reddish      = new oyuncu();
       public static oyuncu anthony         = new oyuncu();
       public static oyuncu jalen        = new oyuncu();
       public static oyuncu kawhi        = new oyuncu();
       public static oyuncu middleton    = new oyuncu();
       public static oyuncu otto        = new oyuncu();
       public static oyuncu osmane       = new oyuncu();
       public static oyuncu warren       = new oyuncu();
       public static oyuncu oneal        = new oyuncu();
       public static oyuncu prince       = new oyuncu();
       public static oyuncu craig       = new oyuncu();
       public static oyuncu wanabe       = new oyuncu();

        public static void SaveState()  //1
        {
            using (var stream = new FileStream("smallforwards.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, wiggins );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, ingram  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, osman   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, hunter  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, derozan );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, vassell );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, george  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, brown   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, tatum   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, butler  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, johnson );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oubre   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, markkanen);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, porter  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, bridges );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, batum   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, annunoby);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, saddiq  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, reddish );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, anthony );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, jalen   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kawhi   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, middleton);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, otto    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, osmane  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, warren  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oneal   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, prince  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, craig   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, wanabe);
                stream.FlushAsync();
                stream.Close();
            }

            
        }
        public static void LoadState()
        {
            if (File.Exists("smallforwards.bin"))
            {
                using (var stream = new FileStream("smallforwards.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    wiggins = (oyuncu)formatter.Deserialize(stream);
                    ingram = (oyuncu)formatter.Deserialize(stream);
                    osman = (oyuncu)formatter.Deserialize(stream);
                    hunter = (oyuncu)formatter.Deserialize(stream);
                    derozan = (oyuncu)formatter.Deserialize(stream);
                    vassell = (oyuncu)formatter.Deserialize(stream);
                    george = (oyuncu)formatter.Deserialize(stream);
                    brown = (oyuncu)formatter.Deserialize(stream);
                    tatum = (oyuncu)formatter.Deserialize(stream);
                    butler = (oyuncu)formatter.Deserialize(stream);
                    johnson = (oyuncu)formatter.Deserialize(stream);
                    oubre = (oyuncu)formatter.Deserialize(stream);
                    markkanen = (oyuncu)formatter.Deserialize(stream);
                    porter = (oyuncu)formatter.Deserialize(stream);
                    bridges = (oyuncu)formatter.Deserialize(stream);
                    batum = (oyuncu)formatter.Deserialize(stream);
                    annunoby = (oyuncu)formatter.Deserialize(stream);
                    saddiq = (oyuncu)formatter.Deserialize(stream);
                    reddish = (oyuncu)formatter.Deserialize(stream);
                    anthony = (oyuncu)formatter.Deserialize(stream);
                    jalen = (oyuncu)formatter.Deserialize(stream);
                    kawhi = (oyuncu)formatter.Deserialize(stream);
                    middleton = (oyuncu)formatter.Deserialize(stream);
                    otto = (oyuncu)formatter.Deserialize(stream);
                    osmane = (oyuncu)formatter.Deserialize(stream);
                    warren = (oyuncu)formatter.Deserialize(stream);
                    oneal = (oyuncu)formatter.Deserialize(stream);
                    prince = (oyuncu)formatter.Deserialize(stream);
                    craig = (oyuncu)formatter.Deserialize(stream);
                    wanabe = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }

        public static void LoadStatey()
        {
            if (File.Exists("smallforwardsa.bin"))
            {
                using (var stream = new FileStream("smallforwardsa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    wiggins = (oyuncu)formatter.Deserialize(stream);
                    ingram = (oyuncu)formatter.Deserialize(stream);
                    osman = (oyuncu)formatter.Deserialize(stream);
                    hunter = (oyuncu)formatter.Deserialize(stream);
                    derozan = (oyuncu)formatter.Deserialize(stream);
                    vassell = (oyuncu)formatter.Deserialize(stream);
                    george = (oyuncu)formatter.Deserialize(stream);
                    brown = (oyuncu)formatter.Deserialize(stream);
                    tatum = (oyuncu)formatter.Deserialize(stream);
                    butler = (oyuncu)formatter.Deserialize(stream);
                    johnson = (oyuncu)formatter.Deserialize(stream);
                    oubre = (oyuncu)formatter.Deserialize(stream);
                    markkanen = (oyuncu)formatter.Deserialize(stream);
                    porter = (oyuncu)formatter.Deserialize(stream);
                    bridges = (oyuncu)formatter.Deserialize(stream);
                    batum = (oyuncu)formatter.Deserialize(stream);
                    annunoby = (oyuncu)formatter.Deserialize(stream);
                    saddiq = (oyuncu)formatter.Deserialize(stream);
                    reddish = (oyuncu)formatter.Deserialize(stream);
                    anthony = (oyuncu)formatter.Deserialize(stream);
                    jalen = (oyuncu)formatter.Deserialize(stream);
                    kawhi = (oyuncu)formatter.Deserialize(stream);
                    middleton = (oyuncu)formatter.Deserialize(stream);
                    otto = (oyuncu)formatter.Deserialize(stream);
                    osmane = (oyuncu)formatter.Deserialize(stream);
                    warren = (oyuncu)formatter.Deserialize(stream);
                    oneal = (oyuncu)formatter.Deserialize(stream);
                    prince = (oyuncu)formatter.Deserialize(stream);
                    craig = (oyuncu)formatter.Deserialize(stream);
                    wanabe = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }

        public static void smallforwardyarat()
        {
            wiggins.name = "A.WOGGENS";
            wiggins.foto = Resources.Andrew_Wiggins;
            wiggins.pozisyon = enums.position.sf;
            
            wiggins.ucluk = 89;
            wiggins.ikilik = 80;
            wiggins.asist = 40;
            wiggins.steal = 88;
            wiggins.block = 81;
            wiggins.rebound = 68;
            wiggins.spec = enums.special.Normal;
          

            ingram.name = "B.ANAGRAM";
            ingram.foto = Resources.Brandon_Ingram;
            ingram.pozisyon = enums.position.sf;
            
            ingram.ucluk = 70;
            ingram.ikilik = 84;
            ingram.asist = 77;
            ingram.steal = 65;
            ingram.block = 67;
            ingram.rebound = 42;
            ingram.spec = enums.special.Normal;
           

            osman.name = "C.TURK";
            osman.foto = Resources.cedi_osman;
            osman.pozisyon = enums.position.sf;
            
            osman.ucluk = 71;
            osman.ikilik = 64;
            osman.asist = 41;
            osman.steal = 51;
            osman.block = 38;
            osman.rebound = 48;
            osman.spec = enums.special.Normal;

           

            hunter.name = "D.HOANTER";
            hunter.foto = Resources.DeAndre_Hunter;
            hunter.pozisyon = enums.position.sf;
            
            hunter.ucluk = 73;
            hunter.ikilik = 77;
            hunter.asist = 15;
            hunter.steal = 36;
            hunter.block = 30;
            hunter.rebound = 56;
            hunter.spec = enums.special.Normal;
           

            derozan.name = "D.DOZEREN";
            derozan.foto = Resources.DeMar_DeRozan;
            derozan.pozisyon = enums.position.sf;
            
            derozan.ucluk = 68;
            derozan.ikilik = 94;
            derozan.asist = 74;
            derozan.steal = 76;
            derozan.block = 75;
            derozan.rebound = 73;
            derozan.spec = enums.special.Chef;
            

            vassell.name = "D.VEYSELL";
            vassell.foto = Resources.Devin_Vassell;
            vassell.pozisyon = enums.position.sf;
            
            vassell.ucluk = 88;
            vassell.ikilik = 79;
            vassell.asist = 64;
            vassell.steal = 66;
            vassell.block = 60;
            vassell.rebound = 52;
            vassell.spec = enums.special.Normal;
            

            george.name = "P.COURGE";
            george.foto = Resources.george;
            george.pozisyon = enums.position.sf;
            
            george.ucluk = 88;
            george.ikilik = 85;
            george.asist = 75;
            george.steal = 88;
            george.block = 76;
            george.rebound = 70;
            george.spec = enums.special.Closer;
           

            brown.name = "J.BRAWNE";
            brown.foto = Resources.jaylen_brown;
            brown.pozisyon = enums.position.sf;
            
            brown.ucluk = 93;
            brown.ikilik = 93;
            brown.asist = 60;
            brown.steal = 82;
            brown.block = 75;
            brown.rebound = 84;
            brown.spec = enums.special.Tower;
            

            tatum.name = "J.TATUAN";
            tatum.foto = Resources.jayson_tatum;
            tatum.pozisyon = enums.position.sf;
            
            tatum.ucluk = 96;
            tatum.ikilik = 93;
            tatum.asist = 64;
            tatum.steal = 88;
            tatum.block = 89;
            tatum.rebound = 87;
            tatum.spec = enums.special.Closer;
            

            butler.name = "J.HUTLER";
            butler.foto = Resources.Jimmy_Butler;
            butler.pozisyon = enums.position.sf;
            
            butler.ucluk = 80;
            butler.ikilik = 88;
            butler.asist = 83;
            butler.steal = 87;
            butler.block = 69;
            butler.rebound = 68;
            butler.spec = enums.special.Clutch;
          

            johnson.name = "K.JOHANSON";
            johnson.foto = Resources.Keldon_Johnson;
            johnson.pozisyon = enums.position.sf;
            
            johnson.ucluk = 90;
            johnson.ikilik = 86;
            johnson.asist = 56;
            johnson.steal = 72;
            johnson.block = 25;
            johnson.rebound = 71;
            johnson.spec = enums.special.Normal;
            

            oubre.name = "K.EBRE";
            oubre.foto = Resources.Kelly_Oubre;
            oubre.pozisyon = enums.position.sf;
            
            oubre.ucluk = 91;
            oubre.ikilik = 90;
            oubre.asist = 15;
            oubre.steal = 94;
            oubre.block = 66;
            oubre.rebound = 76;
            oubre.spec = enums.special.Normal;
           

            markkanen.name = "L.MAKINEN";
            markkanen.foto = Resources.Lauri_Markkanen;
            markkanen.pozisyon = enums.position.sf;
            
            markkanen.ucluk = 89;
            markkanen.ikilik = 80;
            markkanen.asist = 39;
            markkanen.steal = 60;
            markkanen.block = 81;
            markkanen.rebound = 88;
            markkanen.spec = enums.special.Normal;
            

            porter.name = "M.DORTER.SN";
            porter.foto = Resources.Michael_Porter_Jr;
            porter.pozisyon = enums.position.sf;
            
            porter.ucluk = 77;
            porter.ikilik = 63;
            porter.asist = 19;
            porter.steal = 45;
            porter.block = 50;
            porter.rebound = 60;
            porter.spec = enums.special.Normal;
            

            bridges.name = "M.BRADGERS";
            bridges.foto = Resources.Mikal_Bridges;
            bridges.pozisyon = enums.position.sf;
          
            bridges.ucluk = 85;
            bridges.ikilik = 84;
            bridges.asist = 53;
            bridges.steal = 89;
            bridges.block = 88;
            bridges.rebound = 75;
            bridges.spec = enums.special.Normal;
           

            batum.name = "N.BALUUM";
            batum.foto = Resources.Nicolas_Batum;
            batum.pozisyon = enums.position.sf;
            
            batum.ucluk = 64;
            batum.ikilik = 37;
            batum.asist = 42;
            batum.steal = 61;
            batum.block = 87;
            batum.rebound = 68;
            batum.spec = enums.special.Normal;
           

            annunoby.name = "O.R.AYUNOB";
            annunoby.foto = Resources.OG_Anunoby;
            annunoby.pozisyon = enums.position.sf;
            
            annunoby.ucluk = 83;
            annunoby.ikilik = 88;
            annunoby.asist = 33;
            annunoby.steal = 96;
            annunoby.block = 87;
            annunoby.rebound = 80;
            annunoby.spec = enums.special.Normal;
            

            saddiq.name = "S.DOY";
            saddiq.foto = Resources.Saddiq_Bey;
            saddiq.pozisyon = enums.position.sf;
           
            saddiq.ucluk = 80;
            saddiq.ikilik = 76;
            saddiq.asist = 34;
            saddiq.steal = 80;
            saddiq.block = 41;
            saddiq.rebound = 65;
            saddiq.spec = enums.special.Normal;
         


            reddish.name = "C.RADUSH";
            reddish.foto = Resources.Cam_Reddish;
            reddish.pozisyon = enums.position.sf;
            
            reddish.ucluk = 60;
            reddish.ikilik = 51;
            reddish.asist = 45;
            reddish.steal = 55;
            reddish.block = 41;
            reddish.rebound = 35;
            reddish.spec = enums.special.Normal;
            

            anthony.name = "C.AINTON";
            anthony.foto = Resources.Cole_Anthony;
            anthony.pozisyon = enums.position.sf;
            anthony.ucluk = 45;
            anthony.ikilik = 46;
            anthony.asist = 45;
            anthony.steal = 58;
            anthony.block = 35;
            anthony.rebound = 35;
           
            anthony.spec = enums.special.Normal;

            jalen.name = "C.MCDONELS";
            jalen.foto = Resources.Jalen_McDaniels;
            jalen.pozisyon = enums.position.sf;
            jalen.ucluk = 75;
            jalen.ikilik = 75;
            jalen.asist = 65;
            jalen.steal = 65;
            jalen.block = 65;
            jalen.rebound = 35;
         
            jalen.spec = enums.special.Normal;

            kawhi.name = "K.LANER";
            kawhi.foto = Resources.Kawhi_Leonard;
            kawhi.pozisyon = enums.position.sf;
            kawhi.ucluk = 72;
            kawhi.ikilik = 90;
            kawhi.asist = 80;
            kawhi.steal = 95;
            kawhi.block = 94;
            kawhi.rebound = 85;
         
            kawhi.spec = enums.special.Tower;


            middleton.name = "K.MIDDLE";
            middleton.foto = Resources.Khris_Middleton;
            middleton.pozisyon = enums.position.sf;
            middleton.ucluk = 80;
            middleton.ikilik = 80;
            middleton.asist = 80;
            middleton.steal = 80;
            middleton.block = 80;
            middleton.rebound = 70;
         
            middleton.spec = enums.special.Normal;

            otto.name = "O.P.SENIOR";
            otto.foto = Resources.Otto_Porter_Jr;
            otto.pozisyon = enums.position.sf;
            otto.ucluk = 65;
            otto.ikilik = 75;
            otto.asist = 65;
            otto.steal = 75;
            otto.block = 65;
            otto.rebound = 70;
        
            otto.spec = enums.special.Normal;


            osmane.name = "O.DONG";
            osmane.foto = Resources.Ousmane_Dieng;
            osmane.pozisyon = enums.position.sf;
            osmane.ucluk = 53;
            osmane.ikilik = 55;
            osmane.asist = 60;
            osmane.steal = 55;
            osmane.block = 59;
            osmane.rebound = 65;
            
            osmane.spec = enums.special.Normal;

            warren.name = "O.WORDER";
            warren.foto = Resources.T_J__Warren;
            warren.pozisyon = enums.position.sf;
            warren.ucluk = 75;
            warren.ikilik = 55;
            warren.asist = 65;
            warren.steal = 50;
            warren.block = 52;
            warren.rebound = 43;
            
            warren.spec = enums.special.Normal;

            oneal.name = "R.OREAL";
            oneal.foto = Resources.Royce_ONeale;
            oneal.pozisyon = enums.position.sf;
            oneal.ucluk = 52;
            oneal.ikilik = 65;
            oneal.asist = 45;
            oneal.steal = 30;
            oneal.block = 52;
            oneal.rebound = 63;
           
            oneal.spec = enums.special.Normal;


            prince.name = "T.PRICE";
            prince.foto = Resources.Taurean_Prince;
            prince.pozisyon = enums.position.sf;
            prince.ucluk = 70;
            prince.ikilik = 65;
            prince.asist = 70;
            prince.steal = 62;
            prince.block = 62;
            prince.rebound = 80;
            
            prince.spec = enums.special.Normal;

            craig.name = "T.KRAYK";
            craig.foto = Resources.Torrey_Craig;
            craig.pozisyon = enums.position.sf;
            craig.ucluk = 55;
            craig.ikilik = 55;
            craig.asist =60;
            craig.steal = 52;
            craig.block = 52;
            craig.rebound = 54;
            
            craig.spec = enums.special.Normal;

            wanabe.name = "T.WANABI";
            wanabe.foto = Resources.Yuta_Watanabe;
            wanabe.pozisyon = enums.position.sf;
            wanabe.ucluk = 45;
            wanabe.ikilik = 45;
            wanabe.asist = 45;
            wanabe.steal = 75;
            wanabe.block = 54;
            wanabe.rebound = 54;
            
            wanabe.spec = enums.special.Normal;

            lists.sfs.Add(tatum);//1
            lists.sfs2.Add(tatum);

            lists.sfs.Add(kawhi);//2
            lists.sfs2.Add(kawhi);

            lists.sfs.Add(bridges);//3
            lists.sfs2.Add(bridges);

            lists.sfs.Add(wiggins);//4
            lists.sfs2.Add(wiggins);

            lists.sfs.Add(markkanen);//5
            lists.sfs2.Add(markkanen);

            lists.sfs.Add(annunoby);//6
            lists.sfs2.Add(annunoby);

            lists.sfs.Add(derozan);//7
            lists.sfs2.Add(derozan);

            lists.sfs.Add(brown);//8
            lists.sfs2.Add(brown);

            lists.sfs.Add(george);//9
            lists.sfs2.Add(george);

            lists.sfs.Add(middleton);//10
            lists.sfs2.Add(middleton);

            lists.sfs.Add(butler);//11
            lists.sfs2.Add(butler);

            lists.sfs.Add(oubre);//12
            lists.sfs2.Add(oubre);

            lists.sfs.Add(ingram);//13
            lists.sfs2.Add(ingram);

            lists.sfs.Add(batum);//14
            lists.sfs2.Add(batum);

            lists.sfs.Add(vassell); //15
            lists.sfs2.Add(vassell);

            lists.sfs.Add(jalen);//16
            lists.sfs2.Add(jalen);

            lists.sfs.Add(otto); //17
            lists.sfs2.Add(otto);

            lists.sfs.Add(porter); //18
            lists.sfs2.Add(porter);

            lists.sfs.Add(prince);//19
            lists.sfs2.Add(prince);

            lists.sfs.Add(warren);//20
            lists.sfs2.Add(warren);

            lists.sfs.Add(saddiq);//21
            lists.sfs2.Add(saddiq);

            lists.sfs.Add(oneal);//22
            lists.sfs2.Add(oneal);

            lists.sfs.Add(johnson);//23
            lists.sfs2.Add(johnson);

            lists.sfs.Add(osmane); //24
            lists.sfs2.Add(osmane);

            lists.sfs2.Add(osman);//25
            lists.sfs.Add(osman);

            lists.sfs.Add(craig);//26
            lists.sfs2.Add(craig);

            lists.sfs.Add(hunter);//27
            lists.sfs2.Add(hunter);

            lists.sfs.Add(reddish);//28
            lists.sfs2.Add(reddish);

            lists.sfs.Add(wanabe);//29
            lists.sfs2.Add(wanabe);

            lists.sfs.Add(anthony); //30
            lists.sfs2.Add(anthony);

            

        }
    }
}
