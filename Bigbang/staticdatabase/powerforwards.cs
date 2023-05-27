using Bigbang.classes;
using Bigbang.Properties;
using Bigbang.staticdatabase;
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
    public static class powerforwards
    {
        public static oyuncu gordon         = new oyuncu();
        public static oyuncu portis         = new oyuncu();
        public static oyuncu bogdan         = new oyuncu();
        public static oyuncu boucher         = new oyuncu();
        public static oyuncu wood           = new oyuncu();
        public static oyuncu sabonis        = new oyuncu();
        public static oyuncu dorian          = new oyuncu();
        public static oyuncu dgreen         = new oyuncu();
        public static oyuncu grant           = new oyuncu();
        public static oyuncu randle         = new oyuncu();
        public static oyuncu durant         = new oyuncu();
        public static oyuncu porzingis       = new oyuncu();
        public static oyuncu kuzma          = new oyuncu();
        public static oyuncu lebron         = new oyuncu();
        public static oyuncu mobley         = new oyuncu();
        public static oyuncu tucker         = new oyuncu();
        public static oyuncu siakam         = new oyuncu();
        public static oyuncu washington         = new oyuncu();
        public static oyuncu hachimura       = new oyuncu();
        public static oyuncu harris          = new oyuncu();
        public static oyuncu zion           = new oyuncu();
        public static oyuncu rokusevski      = new oyuncu();
        public static oyuncu saric           = new oyuncu();
        public static oyuncu rody           = new oyuncu();
        public static oyuncu jalensmith      = new oyuncu();
        public static oyuncu vanderbilt      = new oyuncu();
        public static oyuncu sochan         = new oyuncu();
        public static oyuncu olik            = new oyuncu();
        public static oyuncu lamar          = new oyuncu();
        public static oyuncu obi             = new oyuncu();


        public static void SaveState()
        {
            using (var stream = new FileStream("powerforwards.bin", FileMode.Create))  //1
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, gordon    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, portis    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, bogdan    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, boucher   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, wood      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, sabonis   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, dorian    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, dgreen    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, grant     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, randle    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, durant    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, porzingis );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kuzma     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, lebron    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, mobley    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, tucker    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, siakam    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, washington);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, hachimura );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, harris    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, zion      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, rokusevski);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, saric     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, rody      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, jalensmith);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, vanderbilt);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, sochan    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, olik      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, lamar     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, obi);
                stream.FlushAsync();
                stream.Close();
            }
        }
        public static void LoadState()
        {
            if (File.Exists("powerforwards.bin"))
            {
                using (var stream = new FileStream("powerforwards.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    gordon       = (oyuncu)formatter.Deserialize(stream);
                    portis       = (oyuncu)formatter.Deserialize(stream);
                    bogdan       = (oyuncu)formatter.Deserialize(stream);
                    boucher      = (oyuncu)formatter.Deserialize(stream);
                    wood         = (oyuncu)formatter.Deserialize(stream);
                    sabonis      = (oyuncu)formatter.Deserialize(stream);
                    dorian       = (oyuncu)formatter.Deserialize(stream);
                    dgreen       = (oyuncu)formatter.Deserialize(stream);
                    grant        = (oyuncu)formatter.Deserialize(stream);
                    randle       = (oyuncu)formatter.Deserialize(stream);
                    durant       = (oyuncu)formatter.Deserialize(stream);
                    porzingis    = (oyuncu)formatter.Deserialize(stream);
                    kuzma        = (oyuncu)formatter.Deserialize(stream);
                    lebron       = (oyuncu)formatter.Deserialize(stream);
                    mobley       = (oyuncu)formatter.Deserialize(stream);
                    tucker       = (oyuncu)formatter.Deserialize(stream);
                    siakam       = (oyuncu)formatter.Deserialize(stream);
                    washington   = (oyuncu)formatter.Deserialize(stream);
                    hachimura    = (oyuncu)formatter.Deserialize(stream);
                    harris       = (oyuncu)formatter.Deserialize(stream);
                    zion         = (oyuncu)formatter.Deserialize(stream);
                    rokusevski   = (oyuncu)formatter.Deserialize(stream);
                    saric        = (oyuncu)formatter.Deserialize(stream);
                    rody         = (oyuncu)formatter.Deserialize(stream);
                    jalensmith   = (oyuncu)formatter.Deserialize(stream);
                    vanderbilt   = (oyuncu)formatter.Deserialize(stream);
                    sochan       = (oyuncu)formatter.Deserialize(stream);
                    olik         = (oyuncu)formatter.Deserialize(stream);
                    lamar        = (oyuncu)formatter.Deserialize(stream);
                    obi = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }

        public static void LoadStatey()
        {
            if (File.Exists("powerforwardsa.bin"))
            {
                using (var stream = new FileStream("powerforwardsa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    gordon = (oyuncu)formatter.Deserialize(stream);
                    portis = (oyuncu)formatter.Deserialize(stream);
                    bogdan = (oyuncu)formatter.Deserialize(stream);
                    boucher = (oyuncu)formatter.Deserialize(stream);
                    wood = (oyuncu)formatter.Deserialize(stream);
                    sabonis = (oyuncu)formatter.Deserialize(stream);
                    dorian = (oyuncu)formatter.Deserialize(stream);
                    dgreen = (oyuncu)formatter.Deserialize(stream);
                    grant = (oyuncu)formatter.Deserialize(stream);
                    randle = (oyuncu)formatter.Deserialize(stream);
                    durant = (oyuncu)formatter.Deserialize(stream);
                    porzingis = (oyuncu)formatter.Deserialize(stream);
                    kuzma = (oyuncu)formatter.Deserialize(stream);
                    lebron = (oyuncu)formatter.Deserialize(stream);
                    mobley = (oyuncu)formatter.Deserialize(stream);
                    tucker = (oyuncu)formatter.Deserialize(stream);
                    siakam = (oyuncu)formatter.Deserialize(stream);
                    washington = (oyuncu)formatter.Deserialize(stream);
                    hachimura = (oyuncu)formatter.Deserialize(stream);
                    harris = (oyuncu)formatter.Deserialize(stream);
                    zion = (oyuncu)formatter.Deserialize(stream);
                    rokusevski = (oyuncu)formatter.Deserialize(stream);
                    saric = (oyuncu)formatter.Deserialize(stream);
                    rody = (oyuncu)formatter.Deserialize(stream);
                    jalensmith = (oyuncu)formatter.Deserialize(stream);
                    vanderbilt = (oyuncu)formatter.Deserialize(stream);
                    sochan = (oyuncu)formatter.Deserialize(stream);
                    olik = (oyuncu)formatter.Deserialize(stream);
                    lamar = (oyuncu)formatter.Deserialize(stream);
                    obi = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }


        public static void powerforwardyarat()
        {
            gordon.name = "A.GERDAN";
            gordon.foto = Resources.Aaron_Gordon;
            gordon.pozisyon = enums.position.pf;
            gordon.ucluk = 72;
            gordon.ikilik = 84;
            gordon.asist = 43;
            gordon.steal = 67;
            gordon.block = 80;
            gordon.rebound = 77;
            gordon.spec = enums.special.Normal;
           

            portis.name = "B.PARTOUS";
            portis.foto = Resources.Bobby_Portis;
            portis.pozisyon = enums.position.pf;
            portis.ucluk = 75;
            portis.ikilik = 82;
            portis.asist = 50;
            portis.steal = 41;
            portis.block = 59;
            portis.rebound = 93;
            portis.spec = enums.special.Battery;
            

            bogdan.name = "B.BOGACC";
            bogdan.foto = Resources.Bojan_Bogdanovic;
            bogdan.pozisyon = enums.position.pf;
            bogdan.ucluk = 93;
            bogdan.ikilik = 88;
            bogdan.asist = 46;
            bogdan.steal = 61;
            bogdan.block = 15;
            bogdan.rebound = 61;
            bogdan.spec = enums.special.Normal;
           

            boucher.name = "C.BACHELOR";
            boucher.foto = Resources.Chris_Boucher;
            boucher.pozisyon = enums.position.pf;
            boucher.ucluk = 63;
            boucher.ikilik = 70;
            boucher.asist = 10;
            boucher.steal = 67;
            boucher.block = 85;
            boucher.rebound = 75;
            boucher.spec = enums.special.Tower;
          

            wood.name = "C.WEEDY";
            wood.foto = Resources.Christian_Wood;
            wood.pozisyon = enums.position.pf;
            wood.ucluk = 78;
            wood.ikilik = 83;
            wood.asist = 31;
            wood.steal = 46;
            wood.block = 75;
            wood.rebound = 85;
            wood.spec = enums.special.Normal;
          

            sabonis.name = "D.SARONAS";
            sabonis.foto = Resources.Domantas_Sabonis;
            sabonis.pozisyon = enums.position.pf;
            sabonis.ucluk = 62;
            sabonis.ikilik = 87;
            sabonis.asist = 87;
            sabonis.steal = 74;
            sabonis.block = 75;
            sabonis.rebound = 93;
            sabonis.spec = enums.special.Normal;
         

            dorian.name = "D.F.SMOOTH";
            dorian.foto = Resources.Dorian_Finney_Smith;
            dorian.pozisyon = enums.position.pf;
            dorian.ucluk = 74;
            dorian.ikilik = 53;
            dorian.asist = 12;
            dorian.steal = 86;
            dorian.block = 76;
            dorian.rebound = 61;
            dorian.spec = enums.special.Normal;
          

            dgreen.name = "D.GREYON";
            dgreen.foto = Resources.Draymond_Green;
            dgreen.pozisyon = enums.position.pf;
            dgreen.ucluk = 51;
            dgreen.ikilik = 76;
            dgreen.asist = 91;
            dgreen.steal = 77;
            dgreen.block = 85;
            dgreen.rebound = 78;
            dgreen.spec = enums.special.Chef;
           

            grant.name = "J.CREANT";
            grant.foto = Resources.Jerami_Grant;
            grant.pozisyon = enums.position.pf;
            grant.ucluk = 92;
            grant.ikilik = 88;
            grant.asist = 46;
            grant.steal = 74;
            grant.block = 86;
            grant.rebound = 63;
            grant.spec = enums.special.Normal;
           

            randle.name = "J.RONDAL";
            randle.foto = Resources.Julius_Randle;
            randle.pozisyon = enums.position.pf;
            randle.ucluk = 92;
            randle.ikilik = 90;
            randle.asist = 62;
            randle.steal = 70;
            randle.block = 46;
            randle.rebound =89;
            randle.spec = enums.special.Normal;
           

            durant.name = "K.DORANTU";
            durant.foto = Resources.kevin_durant;
            durant.pozisyon = enums.position.pf;          
            durant.ucluk = 90;
            durant.ikilik = 98;
            durant.asist = 78;
            durant.steal = 72;
            durant.block = 93;
            durant.rebound = 85;
            durant.spec = enums.special.Closer;
          

            porzingis.name = "K.PORZAUNGAS";
            porzingis.foto = Resources.Kristaps_Porzingis;
            porzingis.pozisyon = enums.position.pf;
            porzingis.ucluk = 89;
            porzingis.ikilik = 90;
            porzingis.asist = 49;
            porzingis.steal = 78;
            porzingis.block = 93;
            porzingis.rebound = 90;
            porzingis.spec = enums.special.Normal;
           

            kuzma.name = "K.KAIZMAN";
            kuzma.foto = Resources.Kyle_Kuzma;
            kuzma.pozisyon = enums.position.pf;
            kuzma.ucluk = 91;
            kuzma.ikilik = 90;
            kuzma.asist = 61;
            kuzma.steal = 53;
            kuzma.block = 80;
            kuzma.rebound = 86;
            kuzma.spec = enums.special.Normal;
           

            lebron.name = "L.KING";
            lebron.foto = Resources.lebron;
            lebron.pozisyon = enums.position.pf;
            lebron.ucluk = 89;
            lebron.ikilik = 94;
            lebron.asist = 85;
            lebron.steal = 80;
            lebron.block = 83;
            lebron.rebound = 86;
            lebron.spec = enums.special.Closer;

      

            mobley.name = "R.MORLEY";
            mobley.foto = Resources.Mobley;
            mobley.pozisyon = enums.position.pf;
            mobley.ucluk = 55;
            mobley.ikilik = 77;
            mobley.asist = 43;
            mobley.steal = 81;
            mobley.block = 88;
            mobley.rebound = 93;
            mobley.spec = enums.special.Normal;
           

            tucker.name = "D.J.TOUCHER";
            tucker.foto = Resources.P_J__Tucker;
            tucker.pozisyon = enums.position.pf;
            tucker.ucluk = 44;
            tucker.ikilik = 34;
            tucker.asist = 13;
            tucker.steal = 63;
            tucker.block = 60;
            tucker.rebound = 66;
            tucker.spec = enums.special.Normal;
            

            washington.name = "D.J.CAPITAL";
            washington.foto = Resources.P_J__Washington;
            washington.pozisyon = enums.position.pf;
            washington.ucluk = 84;
            washington.ikilik = 82;
            washington.asist = 45;
            washington.steal = 74;
            washington.block = 89;
            washington.rebound = 72;
            washington.spec = enums.special.Normal;

            

            siakam.name = "P.SORAKA";
            siakam.foto = Resources.Pascal_Siakam;
            siakam.pozisyon = enums.position.pf;
            siakam.ucluk = 75;
            siakam.ikilik = 86;
            siakam.asist = 88;
            siakam.steal = 69;
            siakam.block = 64;
            siakam.rebound = 77;
            siakam.spec = enums.special.Chef;
           

            hachimura.name = "R.HANAMURA";
            hachimura.foto = Resources.Rui_Hachimura;
            hachimura.pozisyon = enums.position.pf;
            hachimura.ucluk = 51;
            hachimura.ikilik = 62;
            hachimura.asist = 21;
            hachimura.steal = 29;
            hachimura.block = 59;
            hachimura.rebound = 43;
            hachimura.spec = enums.special.Normal;
           

            harris.name = "T.HARASSO";
            harris.foto = Resources.Tobias_Harris;
            harris.pozisyon = enums.position.pf;
            harris.ucluk = 75;
            harris.ikilik = 71;
            harris.asist = 47;
            harris.steal = 90;
            harris.block = 74;
            harris.rebound = 80;
            harris.spec = enums.special.MoreandMore;
            

            zion.name = "Z.ALIMSON";
            zion.foto = Resources.zion_williamson;
            zion.pozisyon = enums.position.pf;
            zion.ucluk = 53;
            zion.ikilik = 93;
            zion.asist = 71;
            zion.steal = 84;
            zion.block = 84;
            zion.rebound = 79;
            zion.spec = enums.special.Normal;
           

            rokusevski.name = "A.ROSKI";
            rokusevski.foto = Resources.Aleksej_Pokusevski;
            rokusevski.pozisyon = enums.position.pf;
            rokusevski.ucluk = 23;
            rokusevski.ikilik = 63;
            rokusevski.asist = 33;
            rokusevski.steal = 74;
            rokusevski.block = 74;
            rokusevski.rebound = 79;
            rokusevski.spec = enums.special.Normal;

            

            saric.name = "D.BORIC";
            saric.foto = Resources.Dario_Saric;
            saric.pozisyon = enums.position.pf;
            saric.ucluk = 33;
            saric.ikilik = 53;
            saric.asist = 33;
            saric.steal = 84;
            saric.block = 84;
            saric.rebound = 84;
            saric.spec = enums.special.Normal;

            

            rody.name = "D.RODE";
            rody.foto = Resources.David_Roddy;
            rody.pozisyon = enums.position.pf;
            rody.ucluk = 23;
            rody.ikilik = 43;
            rody.asist = 63;
            rody.steal = 73;
            rody.block = 75;
            rody.rebound = 74;
            rody.spec = enums.special.Normal;


            jalensmith.name = "J.SMOTTHI";
            jalensmith.foto = Resources.Jalen_Smith;
            jalensmith.pozisyon = enums.position.pf;
            jalensmith.ucluk = 72;
            jalensmith.ikilik = 52;
            jalensmith.asist = 71;
            jalensmith.steal = 61;
            jalensmith.block = 72;
            jalensmith.rebound = 74;
            jalensmith.spec = enums.special.Normal;

            

            vanderbilt.name = "J.ONEHELLBILD";
            vanderbilt.foto = Resources.Jarred_Vanderbilt;
            vanderbilt.pozisyon = enums.position.pf;
            vanderbilt.ucluk = 61;
            vanderbilt.ikilik = 65;
            vanderbilt.asist = 63;
            vanderbilt.steal = 55;
            vanderbilt.block = 55;
            vanderbilt.rebound = 65;
            vanderbilt.spec = enums.special.Normal;

           

            sochan.name = "J.SOCKEN";
            sochan.foto = Resources.Jeremy_Sochan;
            sochan.pozisyon = enums.position.pf;
            sochan.ucluk = 43;
            sochan.ikilik = 53;
            sochan.asist = 43;
            sochan.steal = 55;
            sochan.block = 55;
            sochan.rebound = 75;
            sochan.spec = enums.special.Normal;

            

            olik.name = "K.OLIK";
            olik.foto = Resources.Kelly_Olynyk;
            olik.pozisyon = enums.position.pf;
            olik.ucluk = 43;
            olik.ikilik = 53;
            olik.asist = 43;
            olik.steal = 75;
            olik.block = 85;
            olik.rebound = 85;
            olik.spec = enums.special.Normal;

          

            lamar.name = "L.STEFAN";
            lamar.foto = Resources.Lamar_Stevens;
            lamar.pozisyon = enums.position.pf;
            lamar.ucluk = 63;
            lamar.ikilik = 67;
            lamar.asist = 53;
            lamar.steal = 65;
            lamar.block = 65;
            lamar.rebound = 75;
            lamar.spec = enums.special.Normal;

            

            obi.name = "O.TIPPEN";
            obi.foto = Resources.Obi_Toppin;
            obi.pozisyon = enums.position.pf;
            obi.ucluk = 63;
            obi.ikilik = 74;
            obi.asist = 74;
            obi.steal = 65;
            obi.block = 65;
            obi.rebound = 75;
            obi.spec = enums.special.Normal;

            lists.pfs.Add(durant);//1
            lists.pfs2.Add(durant);

            lists.pfs.Add(porzingis);//2
            lists.pfs2.Add(porzingis);

            lists.pfs.Add(zion); //3
            lists.pfs2.Add(zion);

            lists.pfs.Add(washington);//4
            lists.pfs2.Add(washington);

            lists.pfs.Add(grant);//5
            lists.pfs2.Add(grant);

            lists.pfs.Add(lebron);//6
            lists.pfs2.Add(lebron);

            lists.pfs.Add(kuzma);//7
            lists.pfs2.Add(kuzma);

            lists.pfs.Add(gordon);//8
            lists.pfs2.Add(gordon);

            lists.pfs.Add(sabonis);//9
            lists.pfs2.Add(sabonis);

            lists.pfs.Add(dgreen);//10
            lists.pfs2.Add(dgreen);

            lists.pfs.Add(mobley);//11
            lists.pfs2.Add(mobley);

            lists.pfs.Add(wood); //12
            lists.pfs2.Add(wood);

            lists.pfs.Add(boucher);//13
            lists.pfs2.Add(boucher);

            lists.pfs.Add(siakam); //14
            lists.pfs2.Add(siakam);

            lists.pfs.Add(harris); //15
            lists.pfs2.Add(harris);

            lists.pfs.Add(jalensmith); //16
            lists.pfs2.Add(jalensmith);

            lists.pfs.Add(portis);//17
            lists.pfs2.Add(portis);

            lists.pfs.Add(obi);  //18
            lists.pfs2.Add(obi);

            lists.pfs.Add(olik);//19
            lists.pfs2.Add(olik);

            lists.pfs.Add(rokusevski);//20
            lists.pfs2.Add(rokusevski);

            lists.pfs.Add(saric); //21
            lists.pfs2.Add(saric);

            lists.pfs.Add(randle);//22
            lists.pfs2.Add(randle);

            lists.pfs.Add(lamar);//23
            lists.pfs2.Add(lamar);

            lists.pfs.Add(bogdan);//24
            lists.pfs2.Add(bogdan);

            lists.pfs.Add(dorian); //25
            lists.pfs2.Add(dorian);

            lists.pfs.Add(hachimura); //26
            lists.pfs2.Add(hachimura);

            lists.pfs.Add(vanderbilt); //27
            lists.pfs2.Add(vanderbilt);


            lists.pfs.Add(rody); //28
            lists.pfs2.Add(rody);

            lists.pfs.Add(sochan); //29
            lists.pfs2.Add(sochan);

            lists.pfs.Add(tucker);//30
            lists.pfs2.Add(tucker);

        }
        
    }
}
