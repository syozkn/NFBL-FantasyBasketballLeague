using Bigbang.classes;
using Bigbang.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bigbang.staticdatabase
{
    [Serializable]
    public static class centers

    {

       
         
        public static oyuncu horford = new oyuncu();
       public static oyuncu davis = new oyuncu();
       public static oyuncu adebayo = new oyuncu();
       public static oyuncu lopez = new oyuncu();
       public static oyuncu capela = new oyuncu();
       public static oyuncu ayton = new oyuncu();
       public static oyuncu jordan = new oyuncu();
       public static oyuncu zubac = new oyuncu();
       public static oyuncu poetl = new oyuncu();
       public static oyuncu allen = new oyuncu();
       public static oyuncu embiid = new oyuncu();
       public static oyuncu jokic = new oyuncu();
       public static oyuncu nurkic = new oyuncu();
       public static oyuncu towns = new oyuncu();
       public static oyuncu love = new oyuncu();
       public static oyuncu plumle = new oyuncu();
       public static oyuncu harell = new oyuncu();
       public static oyuncu turner = new oyuncu();
       
       public static oyuncu gobert = new oyuncu();
       public static oyuncu adams = new oyuncu();
       public static oyuncu wendell = new oyuncu();
       public static oyuncu yannis = new oyuncu();
        public static oyuncu alexlen = new oyuncu();
        public static oyuncu issiah = new oyuncu();
        public static oyuncu stewart = new oyuncu();
        public static oyuncu wiseman = new oyuncu();
        public static oyuncu mcgee = new oyuncu();
        public static oyuncu kornet = new oyuncu();
        public static oyuncu naz = new oyuncu();
        public static oyuncu robin = new oyuncu();
        public static oyuncu kessler = new oyuncu();
        public static void SaveState()
        {
            using (var stream = new FileStream("centers.bin", FileMode.Create))   //-1
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, horford);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, davis);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, adebayo);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, lopez);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, capela);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, ayton);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, jordan);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, zubac);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, poetl);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, allen);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, embiid);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, jokic);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, nurkic);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, towns);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, love);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, plumle);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, harell);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, turner);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                
                
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, gobert);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, adams);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, wendell);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, yannis);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, alexlen);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, issiah);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, stewart);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, wiseman);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, mcgee);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kornet);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, naz);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, robin);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kessler);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);

                stream.Flush();
                stream.Close();

            }
           
        }
        public static void LoadState()
        {
            if (File.Exists("centers.bin"))
            {
                using (var stream = new FileStream("centers.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    horford = (oyuncu)formatter.Deserialize(stream);
                    davis = (oyuncu)formatter.Deserialize(stream);
                    adebayo = (oyuncu)formatter.Deserialize(stream);
                    lopez = (oyuncu)formatter.Deserialize(stream);
                    capela = (oyuncu)formatter.Deserialize(stream);
                    ayton = (oyuncu)formatter.Deserialize(stream);
                    jordan = (oyuncu)formatter.Deserialize(stream);
                    zubac = (oyuncu)formatter.Deserialize(stream);
                    poetl = (oyuncu)formatter.Deserialize(stream);
                    allen = (oyuncu)formatter.Deserialize(stream);
                    embiid = (oyuncu)formatter.Deserialize(stream);
                    jokic = (oyuncu)formatter.Deserialize(stream);
                    nurkic = (oyuncu)formatter.Deserialize(stream);
                    towns = (oyuncu)formatter.Deserialize(stream);
                    love = (oyuncu)formatter.Deserialize(stream);
                    plumle = (oyuncu)formatter.Deserialize(stream);
                    harell = (oyuncu)formatter.Deserialize(stream);
                    turner = (oyuncu)formatter.Deserialize(stream);
                    
                    gobert = (oyuncu)formatter.Deserialize(stream);
                    adams = (oyuncu)formatter.Deserialize(stream);
                    wendell = (oyuncu)formatter.Deserialize(stream);
                    yannis = (oyuncu)formatter.Deserialize(stream);
                    alexlen = (oyuncu)formatter.Deserialize(stream);
                    issiah = (oyuncu)formatter.Deserialize(stream);
                    stewart = (oyuncu)formatter.Deserialize(stream);
                    wiseman = (oyuncu)formatter.Deserialize(stream);
                    mcgee = (oyuncu)formatter.Deserialize(stream);
                    kornet = (oyuncu)formatter.Deserialize(stream);
                    naz = (oyuncu)formatter.Deserialize(stream);
                    robin = (oyuncu)formatter.Deserialize(stream);
                    kessler = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }

        public static void LoadStatey()
        {
            if (File.Exists("centersa.bin"))
            {
                using (var stream = new FileStream("centersa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    horford = (oyuncu)formatter.Deserialize(stream);
                    davis = (oyuncu)formatter.Deserialize(stream);
                    adebayo = (oyuncu)formatter.Deserialize(stream);
                    lopez = (oyuncu)formatter.Deserialize(stream);
                    capela = (oyuncu)formatter.Deserialize(stream);
                    ayton = (oyuncu)formatter.Deserialize(stream);
                    jordan = (oyuncu)formatter.Deserialize(stream);
                    zubac = (oyuncu)formatter.Deserialize(stream);
                    poetl = (oyuncu)formatter.Deserialize(stream);
                    allen = (oyuncu)formatter.Deserialize(stream);
                    embiid = (oyuncu)formatter.Deserialize(stream);
                    jokic = (oyuncu)formatter.Deserialize(stream);
                    nurkic = (oyuncu)formatter.Deserialize(stream);
                    towns = (oyuncu)formatter.Deserialize(stream);
                    love = (oyuncu)formatter.Deserialize(stream);
                    plumle = (oyuncu)formatter.Deserialize(stream);
                    harell = (oyuncu)formatter.Deserialize(stream);
                    turner = (oyuncu)formatter.Deserialize(stream);
                    
                    gobert = (oyuncu)formatter.Deserialize(stream);
                    adams = (oyuncu)formatter.Deserialize(stream);
                    wendell = (oyuncu)formatter.Deserialize(stream);
                    yannis = (oyuncu)formatter.Deserialize(stream);
                    alexlen = (oyuncu)formatter.Deserialize(stream);
                    issiah = (oyuncu)formatter.Deserialize(stream);
                    stewart = (oyuncu)formatter.Deserialize(stream);
                    wiseman = (oyuncu)formatter.Deserialize(stream);
                    mcgee = (oyuncu)formatter.Deserialize(stream);
                    kornet = (oyuncu)formatter.Deserialize(stream);
                    naz = (oyuncu)formatter.Deserialize(stream);
                    robin = (oyuncu)formatter.Deserialize(stream);
                    kessler = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }

        public static void centeryarat()
        {
            horford.name = "A.HAIRFORD";
            horford.foto = Resources.Al_Horford;
            horford.pozisyon = enums.position.cent;
            horford.ucluk = 70;
            horford.ikilik = 54;
            horford.asist = 53;
            horford.steal = 44;
            horford.block = 72;
            horford.rebound = 71;
            horford.spec = enums.special.Tower;
          

            davis.name = "A.DAVID";
            davis.foto = Resources.anthony_davis;
            davis.pozisyon = enums.position.cent;
            davis.ucluk = 64;
            davis.ikilik = 94;
            davis.asist = 72;
            davis.steal = 89;
            davis.block = 84;
            davis.rebound = 96;
            davis.spec = enums.special.Closer;
            

            adebayo.name = "B.ADOBALA";
            adebayo.foto = Resources.Bam_Adebayo;
            adebayo.pozisyon = enums.position.cent;
            adebayo.ucluk = 34;
            adebayo.ikilik = 92;
            adebayo.asist = 58;
            adebayo.steal = 80;
            adebayo.block = 70;
            adebayo.rebound = 89;
            adebayo.spec = enums.special.Tower;
            

            lopez.name = "B.LEPAZZO";
            lopez.foto = Resources.Brook_Lopez;
            lopez.pozisyon = enums.position.cent;
            lopez.ucluk = 84;
            lopez.ikilik = 75;
            lopez.asist = 14;
            lopez.steal = 57;
            lopez.block = 80;
            lopez.rebound = 77;
            lopez.spec = enums.special.Normal;
            

            capela.name = "C.CABALO";
            capela.foto = Resources.Clint_Capela;
            capela.pozisyon = enums.position.cent;
            capela.ucluk = 15;
            capela.ikilik = 80;
            capela.asist = 10;
            capela.steal = 64;
            capela.block = 80;
            capela.rebound = 96;
            capela.spec = enums.special.Tower;
            

            ayton.name = "D.OYTAN";
            ayton.foto = Resources.Deandre_Ayton;
            ayton.pozisyon = enums.position.cent;
            ayton.ucluk = 47;
            ayton.ikilik = 89;
            ayton.asist = 46;
            ayton.steal = 56;
            ayton.block = 74;
            ayton.rebound = 90;
            ayton.spec = enums.special.Tower;
            

            jordan.name = "D.JERDON";
            jordan.foto = Resources.DeAndre_Jordan;
            jordan.pozisyon = enums.position.cent;
            jordan.ucluk = 25;
            jordan.ikilik = 47;
            jordan.asist = 37;
            jordan.steal = 23;
            jordan.block = 65;
            jordan.rebound = 85;
            jordan.spec = enums.special.Normal;
            

            zubac.name = "I.YUBAZ";
            zubac.foto = Resources.Ivica_Zubac;
            zubac.pozisyon = enums.position.cent;
            zubac.ucluk = 14;
            zubac.ikilik = 78;
            zubac.asist = 16;
            zubac.steal = 53;
            zubac.block = 77;
            zubac.rebound = 98;
            zubac.spec = enums.special.Normal;
           

            poetl.name = "J.POETRY";
            poetl.foto = Resources.Jakob_Poeltl;
            poetl.pozisyon = enums.position.cent;
            poetl.ucluk = 14;
            poetl.ikilik = 76;
            poetl.asist = 70;
            poetl.steal = 69;
            poetl.block = 73;
            poetl.rebound = 85;
            poetl.spec = enums.special.Normal;
            

            allen.name = "J.ELLAN";
            allen.foto = Resources.Jarrett_Allen;
            allen.pozisyon = enums.position.cent;
            allen.ucluk = 14;
            allen.ikilik = 77;
            allen.asist = 16;
            allen.steal = 56;
            allen.block = 70;
            allen.rebound = 87;
            allen.spec = enums.special.Normal;
           

            embiid.name = "J.OMBED";
            embiid.foto = Resources.Joel_Embiid;
            embiid.pozisyon = enums.position.cent;
            embiid.ucluk = 76;
            embiid.ikilik = 95;
            embiid.asist = 73;
            embiid.steal = 72;
            embiid.block = 78;
            embiid.rebound = 84;
            embiid.spec = enums.special.Closer;
            

            jokic.name = "N.JOEKR";
            jokic.foto = Resources.jokic;
            jokic.pozisyon = enums.position.cent;
            jokic.ucluk = 73;
            jokic.ikilik = 92;
            jokic.asist = 94;
            jokic.steal = 87;
            jokic.block = 71;
            jokic.rebound = 89;
            jokic.spec = enums.special.Chef;
           

            nurkic.name = "Y.NARTUC";
            nurkic.foto = Resources.Jusuf_Nurkic;
            nurkic.pozisyon = enums.position.cent;
            nurkic.ucluk = 64;
            nurkic.ikilik = 79;
            nurkic.asist = 57;
            nurkic.steal = 68;
            nurkic.block = 75;
            nurkic.rebound = 89;
            nurkic.spec = enums.special.Normal;
            

            towns.name = "K.A.CITY";
            towns.foto = Resources.Karl_Anthony_Towns;
            towns.pozisyon = enums.position.cent;
            towns.ucluk = 85;
            towns.ikilik = 89;
            towns.asist = 80;
            towns.steal = 63;
            towns.block = 66;
            towns.rebound = 82;
            towns.spec = enums.special.Clutch;
            

            love.name = "K.LOUVE";
            love.foto = Resources.Kevin_Love;
            love.pozisyon = enums.position.cent;
            love.ucluk = 68;
            love.ikilik = 45;
            love.asist = 65;
            love.steal = 21;
            love.block = 40;
            love.rebound = 73;
            love.spec = enums.special.Normal;
            

            plumle.name = "M.PLAMLA";
            plumle.foto = Resources.Mason_Plumlee;
            plumle.pozisyon = enums.position.cent;
            plumle.ucluk = 14;
            plumle.ikilik = 74;
            plumle.asist = 78;
            plumle.steal = 67;
            plumle.block = 67;
            plumle.rebound = 92;
            plumle.spec = enums.special.Normal;
            

            harell.name = "M.HORELD";
            harell.foto = Resources.Montrezl_Harrell;
            harell.pozisyon = enums.position.cent;
            harell.ucluk = 11;
            harell.ikilik = 46;
            harell.asist = 30;
            harell.steal = 26;
            harell.block = 60;
            harell.rebound = 38;
            harell.spec = enums.special.Normal;
           

            turner.name = "M.TORNIER";
            turner.foto = Resources.Myles_Turner;
            turner.pozisyon = enums.position.cent;
            turner.ucluk = 77;
            turner.ikilik = 78;
            turner.asist = 24;
            turner.steal = 50;
            turner.block = 82;
            turner.rebound = 81;
            turner.spec = enums.special.Tower;
           

          
            
            //gobert bak
            gobert.name = "R.BORET";
            gobert.foto = Resources.Rudy_Gobert;
            gobert.pozisyon = enums.position.cent;
            gobert.ucluk = 15;
            gobert.ikilik =90;
            gobert.asist = 40;
            gobert.steal = 77;
            gobert.block = 82;
            gobert.rebound = 94;
            gobert.spec = enums.special.Tower;
            

            adams.name = "S.EVE";
            adams.foto = Resources.Steven_Adams;
            adams.pozisyon = enums.position.cent;
            adams.ucluk = 13;
            adams.ikilik = 68;
            adams.asist = 54;
            adams.steal = 72;
            adams.block = 77;
            adams.rebound = 93;
            adams.spec = enums.special.Normal;
            

            wendell.name = "W.C.SENIOR";
            wendell.foto = Resources.Wendell_Carter_Jr;
            wendell.pozisyon = enums.position.cent;
            wendell.ucluk = 61;
            wendell.ikilik = 68;
            wendell.asist = 60;
            wendell.steal = 41;
            wendell.block = 55;
            wendell.rebound = 74;
            wendell.spec = enums.special.Normal;
            

            yannis.name = "Y.GREEK";
            yannis.foto = Resources.yannis;
            yannis.pozisyon = enums.position.cent;
            yannis.ucluk = 77;
            yannis.ikilik = 98;
            yannis.asist = 81;
            yannis.steal = 72;
            yannis.block = 82;
            yannis.rebound = 91;
            yannis.spec = enums.special.Closer;
            

            alexlen.name = "A.LAYN";
            alexlen.foto = Resources.Alex_Len;
            alexlen.pozisyon = enums.position.cent;
            alexlen.ucluk = 22;
            alexlen.ikilik = 65;
            alexlen.asist = 32;
            alexlen.steal = 23;
            alexlen.block = 62;
            alexlen.rebound = 74;
            alexlen.spec = enums.special.Normal;

           

            

            issiah.name = "I.HORSTIN";
            issiah.foto = Resources.Isaiah_Hartenstein;
            issiah.pozisyon = enums.position.cent;
            issiah.ucluk = 12;
            issiah.ikilik = 72;
            issiah.asist = 22;
            issiah.steal = 13;
            issiah.block = 63;
            issiah.rebound = 78;
            issiah.spec = enums.special.Normal;

            

            stewart.name = "I.STEFARD";
            stewart.foto = Resources.Isaiah_Stewart;
            stewart.pozisyon = enums.position.cent;
            stewart.ucluk = 12;
            stewart.ikilik = 55;
            stewart.asist = 32;
            stewart.steal = 32;
            stewart.block = 60;
            stewart.rebound = 80;
            stewart.spec = enums.special.Normal;

           

            wiseman.name = "J.WASHMAN";
            wiseman.foto = Resources.James_Wiseman;
            wiseman.pozisyon = enums.position.cent;
            wiseman.ucluk = 12;
            wiseman.ikilik = 75;
            wiseman.asist = 32;
            wiseman.steal = 65;
            wiseman.block = 65;
            wiseman.rebound = 85;
            wiseman.spec = enums.special.Normal;

            

            mcgee.name = "J.MCREA";
            mcgee.foto = Resources.JaVale_McGee;
            mcgee.pozisyon = enums.position.cent;
            mcgee.ucluk = 12;
            mcgee.ikilik = 60;
            mcgee.asist = 32;
            mcgee.steal = 65;
            mcgee.block = 73;
            mcgee.rebound = 85;
            mcgee.spec = enums.special.Battery;

            

            kornet.name = "L.CORNETTO";
            kornet.foto = Resources.Luke_Kornet;
            kornet.pozisyon = enums.position.cent;
            kornet.ucluk = 10;
            kornet.ikilik = 60;
            kornet.asist = 22;
            kornet.steal = 65;
            kornet.block = 55;
            kornet.rebound = 55;
            kornet.spec = enums.special.Normal;

            

            naz.name = "N.REDD";
            naz.foto = Resources.Naz_Reid;
            naz.pozisyon = enums.position.cent;
            naz.ucluk = 15;
            naz.ikilik = 68;
            naz.asist = 22;
            naz.steal = 55;
            naz.block = 63;
            naz.rebound = 75;
            naz.spec = enums.special.Normal;

            

            robin.name = "R.LEPAZZO";
            robin.foto = Resources.Robin_Lopez;
            robin.pozisyon = enums.position.cent;
            robin.ucluk = 65;
            robin.ikilik = 73;
            robin.asist = 65;
            robin.steal = 55;
            robin.block = 66;
            robin.rebound = 73;
            robin.spec = enums.special.Normal;

            

            kessler.name = "W.KOFHER";
            kessler.foto = Resources.Walker_Kessler;
            kessler.pozisyon = enums.position.cent;
            kessler.ucluk = 25;
            kessler.ikilik = 63;
            kessler.asist = 55;
            kessler.steal = 55;
            kessler.block = 58;
            kessler.rebound = 77;
            kessler.spec = enums.special.Normal;


            lists.cs.Add(yannis);//1
            lists.cs2.Add(yannis);

            lists.cs.Add(davis);//2
            lists.cs2.Add(davis);

            lists.cs.Add(embiid);//3
            lists.cs2.Add(embiid);

            lists.cs.Add(gobert);//4
            lists.cs2.Add(gobert);

            lists.cs.Add(lopez);//5
            lists.cs2.Add(lopez);

            lists.cs.Add(ayton);//6
            lists.cs2.Add(ayton);

            lists.cs.Add(adebayo);//7
            lists.cs2.Add(adebayo);

            lists.cs.Add(capela);//8
            lists.cs2.Add(capela);

            lists.cs.Add(jokic); //9
            lists.cs2.Add(jokic);

            lists.cs.Add(turner);//10
            lists.cs2.Add(turner);

            lists.cs.Add(zubac);//11
            lists.cs2.Add(zubac);

            lists.cs.Add(nurkic);//12
            lists.cs2.Add(nurkic);

            lists.cs.Add(towns);//13
            lists.cs2.Add(towns);


            lists.cs.Add(poetl);//15
            lists.cs2.Add(poetl);

            lists.cs.Add(allen);
            lists.cs2.Add(allen);

            lists.cs.Add(adams);//16
            lists.cs2.Add(adams);

            lists.cs.Add(horford); //17
            lists.cs2.Add(horford);

            lists.cs.Add(plumle);//18
            lists.cs2.Add(plumle);

            lists.cs.Add(robin); //19
            lists.cs2.Add(robin);

            lists.cs.Add(wiseman);//20
            lists.cs2.Add(wiseman);

            lists.cs.Add(issiah);//21
            lists.cs2.Add(issiah);

            lists.cs.Add(mcgee); //22
            lists.cs2.Add(mcgee);

            lists.cs.Add(naz);  //23
            lists.cs2.Add(naz);

            lists.cs.Add(alexlen);//24
            lists.cs2.Add(alexlen);

            lists.cs.Add(kessler);//25
            lists.cs2.Add(kessler);

            lists.cs.Add(wendell);//26
            lists.cs2.Add(wendell);

            lists.cs.Add(kornet); //27
            lists.cs2.Add(kornet);

            lists.cs.Add(jordan);//28
            lists.cs2.Add(jordan);

            lists.cs.Add(stewart); //29
            lists.cs2.Add(stewart);

            lists.cs.Add(harell);//30
            lists.cs2.Add(harell);

            lists.cs.Add(love); //31
            lists.cs2.Add(love);

            

           


        }
    }
}
