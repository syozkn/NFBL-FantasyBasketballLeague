using Bigbang.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bigbang.staticdatabase;
using Bigbang.Properties;
using System.Runtime.Serialization.Formatters.Binary;

namespace Bigbang.staticdatabase
{
    [Serializable]
    public static class pointguards
    {
        public static oyuncu coraso     = new oyuncu();
        public static oyuncu dussunmu   = new oyuncu();
        public static oyuncu saimonz     = new oyuncu();
        public static oyuncu brownie     = new oyuncu();
        public static oyuncu yousef     = new oyuncu();
        public static oyuncu cory       = new oyuncu();
        public static oyuncu lallord     = new oyuncu();
        public static oyuncu reisel     = new oyuncu();
        public static oyuncu gorland     = new oyuncu();
        public static oyuncu milton     = new oyuncu();
        public static oyuncu fixer      = new oyuncu();
        public static oyuncu matchelli   = new oyuncu();
        public static oyuncu doric      = new oyuncu();
        public static oyuncu oneflet         = new oyuncu();
        public static oyuncu speedley    = new oyuncu();
        public static oyuncu mariant    = new oyuncu();
        public static oyuncu murat       = new oyuncu();
        public static oyuncu hearthen       = new oyuncu();
        public static oyuncu brick      = new oyuncu();
        public static oyuncu vacation       = new oyuncu();
        public static oyuncu pertier        = new oyuncu();
        public static oyuncu loverell        = new oyuncu();
        public static oyuncu flaterth       = new oyuncu();
        public static oyuncu breckton       = new oyuncu();
        public static oyuncu kounley         = new oyuncu();
        public static oyuncu merris         = new oyuncu();
        public static oyuncu biverlai        = new oyuncu();
        public static oyuncu eastriver       = new oyuncu();
        public static oyuncu dandiwie       = new oyuncu();
        public static oyuncu mccarter       = new oyuncu();
        public static oyuncu razy           = new oyuncu();
        public static oyuncu olabartan       = new oyuncu();
        public static oyuncu oldie      = new oyuncu();

        public static void SaveState()
        {
            using (var stream = new FileStream("pointguards.bin", FileMode.Create))  //1
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, coraso    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, dussunmu  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, saimonz   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, brownie   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, yousef     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, cory      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, lallord   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, reisel     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, gorland   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, milton    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, fixer      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, matchelli );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, doric     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oneflet    );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, speedley  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, mariant   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, murat      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, hearthen  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, brick     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, vacation   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, pertier   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, loverell  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, flaterth   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, breckton  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kounley   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, merris     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, biverlai  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, eastriver );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, dandiwie   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, mccarter  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, razy      );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, olabartan  );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oldie);
                stream.FlushAsync();
                stream.Close();

            }
        }

        public static void LoadState()
        {
            if (File.Exists("pointguards.bin"))
            {
                using (var stream = new FileStream("pointguards.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    coraso     = (oyuncu)formatter.Deserialize(stream);
                    dussunmu   = (oyuncu)formatter.Deserialize(stream);
                    saimonz    = (oyuncu)formatter.Deserialize(stream);
                    brownie    = (oyuncu)formatter.Deserialize(stream);
                    yousef     = (oyuncu)formatter.Deserialize(stream);
                    cory       = (oyuncu)formatter.Deserialize(stream);
                    lallord    = (oyuncu)formatter.Deserialize(stream);
                    reisel     = (oyuncu)formatter.Deserialize(stream);
                    gorland    = (oyuncu)formatter.Deserialize(stream);
                    milton     = (oyuncu)formatter.Deserialize(stream);
                    fixer      = (oyuncu)formatter.Deserialize(stream);
                    matchelli  = (oyuncu)formatter.Deserialize(stream);
                    doric      = (oyuncu)formatter.Deserialize(stream);
                    oneflet    = (oyuncu)formatter.Deserialize(stream);
                    speedley   = (oyuncu)formatter.Deserialize(stream);
                    mariant    = (oyuncu)formatter.Deserialize(stream);
                    murat      = (oyuncu)formatter.Deserialize(stream);
                    hearthen   = (oyuncu)formatter.Deserialize(stream);
                    brick      = (oyuncu)formatter.Deserialize(stream);
                    vacation   = (oyuncu)formatter.Deserialize(stream);
                    pertier    = (oyuncu)formatter.Deserialize(stream);
                    loverell   = (oyuncu)formatter.Deserialize(stream);
                    flaterth   = (oyuncu)formatter.Deserialize(stream);
                    breckton   = (oyuncu)formatter.Deserialize(stream);
                    kounley    = (oyuncu)formatter.Deserialize(stream);
                    merris     = (oyuncu)formatter.Deserialize(stream);
                    biverlai   = (oyuncu)formatter.Deserialize(stream);
                    eastriver  = (oyuncu)formatter.Deserialize(stream);
                    dandiwie   = (oyuncu)formatter.Deserialize(stream);
                    mccarter   = (oyuncu)formatter.Deserialize(stream);
                    razy       = (oyuncu)formatter.Deserialize(stream);
                    olabartan  = (oyuncu)formatter.Deserialize(stream);
                    oldie = (oyuncu)formatter.Deserialize(stream);
                    
                }
            }
        }

        public static void LoadStatey()
        {
            if (File.Exists("pointguardsa.bin"))
            {
                using (var stream = new FileStream("pointguardsa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    coraso = (oyuncu)formatter.Deserialize(stream);
                    dussunmu = (oyuncu)formatter.Deserialize(stream);
                    saimonz = (oyuncu)formatter.Deserialize(stream);
                    brownie = (oyuncu)formatter.Deserialize(stream);
                    yousef = (oyuncu)formatter.Deserialize(stream);
                    cory = (oyuncu)formatter.Deserialize(stream);
                    lallord = (oyuncu)formatter.Deserialize(stream);
                    reisel = (oyuncu)formatter.Deserialize(stream);
                    gorland = (oyuncu)formatter.Deserialize(stream);
                    milton = (oyuncu)formatter.Deserialize(stream);
                    fixer = (oyuncu)formatter.Deserialize(stream);
                    matchelli = (oyuncu)formatter.Deserialize(stream);
                    doric = (oyuncu)formatter.Deserialize(stream);
                    oneflet = (oyuncu)formatter.Deserialize(stream);
                    speedley = (oyuncu)formatter.Deserialize(stream);
                    mariant = (oyuncu)formatter.Deserialize(stream);
                    murat = (oyuncu)formatter.Deserialize(stream);
                    hearthen = (oyuncu)formatter.Deserialize(stream);
                    brick = (oyuncu)formatter.Deserialize(stream);
                    vacation = (oyuncu)formatter.Deserialize(stream);
                    pertier = (oyuncu)formatter.Deserialize(stream);
                    loverell = (oyuncu)formatter.Deserialize(stream);
                    flaterth = (oyuncu)formatter.Deserialize(stream);
                    breckton = (oyuncu)formatter.Deserialize(stream);
                    kounley = (oyuncu)formatter.Deserialize(stream);
                    merris = (oyuncu)formatter.Deserialize(stream);
                    biverlai = (oyuncu)formatter.Deserialize(stream);
                    eastriver = (oyuncu)formatter.Deserialize(stream);
                    dandiwie = (oyuncu)formatter.Deserialize(stream);
                    mccarter = (oyuncu)formatter.Deserialize(stream);
                    razy = (oyuncu)formatter.Deserialize(stream);
                    olabartan = (oyuncu)formatter.Deserialize(stream);
                    oldie = (oyuncu)formatter.Deserialize(stream);

                }
            }
        }



        public static void pointguardyarat()
        {
          
            coraso.name = "L.CORASO";
            coraso.foto = Resources._1Alex_Caruso;
            coraso.pozisyon = enums.position.pg;
            coraso.ucluk = 53;
            coraso.ikilik = 40;
            coraso.asist = 79;
            coraso.steal = 93;
            coraso.block = 82;
            coraso.rebound = 39;
            coraso.spec = enums.special.Normal;
            




           
            dussunmu.name = "A.DOSUNO";
            dussunmu.foto = Resources._2Ayo_Dosunmu;
            dussunmu.pozisyon = enums.position.pg;
            dussunmu.ucluk = 66;
            dussunmu.ikilik = 71;
            dussunmu.asist = 61;
            dussunmu.steal = 66;
            dussunmu.block = 63;
            dussunmu.rebound = 51;
            dussunmu.spec = enums.special.Normal;


           
            saimonz.name = "B.SAIMON";
            saimonz.foto = Resources._3Ben_Simmons;
            
            saimonz.pozisyon = enums.position.pg;
            saimonz.ucluk = 12;
            saimonz.ikilik = 72;
            saimonz.asist = 90;
            saimonz.steal = 83;
            saimonz.block = 85;
            saimonz.rebound = 69;
            saimonz.spec = enums.special.Elbow;

         
            brownie.name = "B.BROWNIE";
            brownie.foto = Resources._4bruce_brown;
            
            brownie.pozisyon = enums.position.pg;
            brownie.ucluk = 72;
            brownie.ikilik = 73;
            brownie.asist = 76;
            brownie.steal = 86;
            brownie.block = 76;
            brownie.rebound = 68;
            brownie.spec = enums.special.Elbow;

            
            yousef.name = "C.YOUSEF";
            yousef.foto = Resources._5Cory_Joseph;
            
            yousef.pozisyon = enums.position.pg;
            yousef.ucluk = 48;
            yousef.ikilik = 42;
            yousef.asist = 89;
            yousef.steal = 35;
            yousef.block = 55;
            yousef.rebound = 15;
            yousef.spec = enums.special.Normal;

            cory.name = "B.SHARP";
            cory.foto = Resources._6curry;
            
            cory.pozisyon = enums.position.pg;
            cory.ucluk = 98;
            cory.ikilik = 91;
            cory.asist = 88;
            cory.steal = 81;
            cory.block = 71;
            cory.rebound = 81;
            cory.spec = enums.special.Chef;

            //lilard değiş
           
            lallord.name = "E.LALLORD";
            lallord.foto = Resources._7Damian_Lillard;
           
            lallord.pozisyon = enums.position.pg;
            lallord.ucluk = 85;
            lallord.ikilik = 82;
            lallord.asist = 89;
            lallord.steal = 84;
            lallord.block = 75;
            lallord.rebound = 71;
            lallord.spec = enums.special.Closer;

            reisel.name = "D.A.REISEL";
            reisel.foto = Resources._8DAngelo_Russell;
           
            reisel.pozisyon = enums.position.pg;
            reisel.ucluk = 88;
            reisel.ikilik = 82;
            reisel.asist = 87;
            reisel.steal = 91;
            reisel.block = 77;
            reisel.rebound = 48;
            reisel.spec = enums.special.Normal;

          
            gorland.name = "D.GIRLLAND";
            gorland.foto = Resources._9darius_garland;
            
            gorland.pozisyon = enums.position.pg;
            gorland.ucluk = 88;
            gorland.ikilik = 83;
            gorland.asist = 91;
            gorland.steal = 84;
            gorland.block = 53;
            gorland.rebound = 24;
            gorland.spec = enums.special.Normal;

          
            milton.name = "D.MILTON";
            milton.foto = Resources._10De_Anthony_Melton;
          
            milton.pozisyon = enums.position.pg;
            milton.ucluk = 81;
            milton.ikilik = 66;
            milton.asist = 64;
            milton.steal = 96;
            milton.block = 73;
            milton.rebound = 63;
            milton.spec = enums.special.Normal;

        
            fixer.name = "D.FIXER";
            fixer.foto = Resources._11Dearon_Fox;
            
            fixer.pozisyon = enums.position.pg;
            fixer.ucluk = 84;
            fixer.ikilik = 88;
            fixer.asist = 85;
            fixer.steal = 80;
            fixer.block = 72;
            fixer.rebound = 64;
            fixer.spec = enums.special.Normal;

           
            matchelli.name = "B.MATCHELLI";
            matchelli.foto = Resources._12donawan_mitchell;
           
            matchelli.pozisyon = enums.position.pg;
            matchelli.ucluk = 96;
            matchelli.ikilik = 91;
            matchelli.asist = 73;
            matchelli.steal = 91;
            matchelli.block = 69;
            matchelli.rebound = 59;
            coraso.spec = enums.special.Elbow;

          
            doric.name = "L.DORIC";
            doric.foto = Resources.doncic;
            
            doric.pozisyon = enums.position.pg;
            doric.ucluk = 94;
            doric.ikilik = 96;
            doric.asist = 92;
            doric.steal = 93;
            doric.block = 79;
            doric.rebound = 87;
            doric.spec = enums.special.Chef;

           
            oneflet.name = "F.ONEFLET";
            oneflet.foto = Resources.Fred_VanVleet;
            
            oneflet.pozisyon = enums.position.pg;
            oneflet.ucluk = 84;
            oneflet.ikilik = 70;
            oneflet.asist = 85;
            oneflet.steal = 91;
            oneflet.block = 70;
            oneflet.rebound = 41;
            oneflet.spec = enums.special.Normal;

            
            speedley.name = "I.SPEEDLEY";
            speedley.foto = Resources.Immanuel_Quickley;
            
            speedley.pozisyon = enums.position.pg;
            speedley.ucluk = 71;
            speedley.ikilik = 67;
            speedley.asist = 71;
            speedley.steal = 82;
            speedley.block = 54;
            speedley.rebound = 69;
            speedley.spec = enums.special.Normal;

           
            mariant.name = "J.MARIANT";
            mariant.foto = Resources.ja_morant;
            
            mariant.pozisyon = enums.position.pg;
            mariant.ucluk = 77;
            mariant.ikilik = 94;
            mariant.asist = 92;
            mariant.steal = 83;
            mariant.block = 62;
            mariant.rebound = 76;
            mariant.spec = enums.special.Clutch;

           
            murat.name = "J.MURATT";
            murat.foto = Resources.Jamal_Murray;
            
            murat.pozisyon = enums.position.pg;
            murat.ucluk = 81;
            murat.ikilik = 84;
            murat.asist = 83;
            murat.steal = 73;
            murat.block = 65;
            murat.rebound = 50;
            murat.spec = enums.special.Normal;

            //harden bak
       
            hearthen.name = "J.HEARTHEN";
            hearthen.foto = Resources.james_harden;
            
            hearthen.pozisyon = enums.position.pg;
            hearthen.ucluk = 80;
            hearthen.ikilik = 84;
            hearthen.asist = 94;
            hearthen.steal = 75;
            hearthen.block = 75;
            hearthen.rebound = 47;
            hearthen.spec = enums.special.MoreandMore;

            
            brick.name = "J.ALL";
            brick.foto = Resources.John_Wall;
            
            brick.pozisyon = enums.position.pg;
            brick.ucluk = 80;
            brick.ikilik = 80;
            brick.asist = 93;
            brick.steal = 73;
            brick.block = 63;
            brick.rebound = 31;
            brick.spec = enums.special.MoreandMore;

          
            vacation.name = "J.VACATION";
            vacation.foto = Resources.Jrue_Holiday;
            
            vacation.pozisyon = enums.position.pg;
            vacation.ucluk = 83;
            vacation.ikilik = 82;
            vacation.asist = 91;
            vacation.steal = 90;
            vacation.block = 66;
            vacation.rebound = 67;
            vacation.spec = enums.special.Normal;
            vacation.spec = enums.special.Normal;

           
            pertier.name = "C.PERTOER";
            pertier.foto = Resources.Kevin_Porter;
           
            pertier.pozisyon = enums.position.pg;
            pertier.ucluk = 86;
            pertier.ikilik = 86;
            pertier.asist = 83;
            pertier.steal = 90;
            pertier.block = 72;
            pertier.rebound = 74;
            pertier.spec = enums.special.Normal;


            loverell.name = "K.LOVELY";
            loverell.foto = Resources.Kyle_Lowry;
            
            loverell.pozisyon = enums.position.pg;
            loverell.ucluk = 87;
            loverell.ikilik = 69;
            loverell.asist = 82;
            loverell.steal = 90;
            loverell.block = 78;
            loverell.rebound = 72;
            loverell.spec = enums.special.Normal;

            //irving maaş
          
            flaterth.name = "K.FLATEARTH";
            flaterth.foto = Resources.Kyrie_Irving;
            
            flaterth.pozisyon = enums.position.pg;
            flaterth.ucluk = 83;
            flaterth.ikilik = 90;
            flaterth.asist = 89;
            flaterth.steal = 64;
            flaterth.block = 74;
            flaterth.rebound = 57;
            flaterth.spec = enums.special.Chef;


          
            breckton.name = "M.BRECKTON";
            breckton.foto = Resources.Malcolm_Brogdon;
            
            breckton.pozisyon = enums.position.pg;
            breckton.ucluk = 78;
            breckton.ikilik = 71;
            breckton.asist = 81;
            breckton.steal = 47;
            breckton.block = 50;
            breckton.rebound = 58;
            breckton.spec = enums.special.Normal;


            
            kounley.name = "M.KOUNLEY";
            kounley.foto = Resources.Mike_Conley;
            
            kounley.pozisyon = enums.position.pg;
            kounley.ucluk = 67;
            kounley.ikilik = 48;
            kounley.asist = 93;
            kounley.steal = 73;
            kounley.block = 58;
            kounley.rebound = 24;
            kounley.spec = enums.special.Normal;

           
            merris.name = "M.MERRIS";
            merris.foto = Resources.Monte_Morris;
            
            merris.pozisyon = enums.position.pg;
            merris.ucluk = 65;
            merris.ikilik = 62;
            merris.asist = 86;
            merris.steal = 62;
            merris.block = 47;
            merris.rebound = 47;
            merris.spec = enums.special.Elbow;

            
            biverlai.name = "P.BIVERLAI";
            biverlai.foto = Resources.Patrick_Beverley;
            
            biverlai.pozisyon = enums.position.pg;
            biverlai.ucluk = 53;
            biverlai.ikilik = 43;
            biverlai.asist = 58;
            biverlai.steal = 71;
            biverlai.block = 68;
            biverlai.rebound = 43;
            biverlai.spec = enums.special.Normal;

           
            eastriver.name = "R.EASTBRICK";
            eastriver.foto = Resources.Russell_Westbrook;
            
            eastriver.pozisyon = enums.position.pg;
            eastriver.ucluk = 74;
            eastriver.ikilik = 80;
            eastriver.asist = 93;
            eastriver.steal = 84;
            eastriver.block = 79;
            eastriver.rebound = 75;
            eastriver.spec = enums.special.Clutch;

            
            dandiwie.name = "S.DANDIWIE";
            dandiwie.foto = Resources.Spencer_Dinwiddie;
            
            dandiwie.pozisyon = enums.position.pg;
            dandiwie.ucluk = 89;
            dandiwie.ikilik = 79;
            dandiwie.asist = 81;
            dandiwie.steal = 84;
            dandiwie.block = 57;
            dandiwie.rebound = 80;
            dandiwie.spec = enums.special.Normal;

           
            mccarter.name = "T.B.MCORNEL";
            mccarter.foto = Resources.T_J__McConnell;
            
            mccarter.pozisyon = enums.position.pg;
            mccarter.ucluk = 35;
            mccarter.ikilik = 52;
            mccarter.asist = 92;
            mccarter.steal = 88;
            mccarter.block = 65;
            mccarter.rebound = 31;
            mccarter.spec = enums.special.Normal;

            
            razy.name = "T.RAYZER";
            razy.foto = Resources.Terry_Rozier;
            
            razy.pozisyon = enums.position.pg;
            razy.ucluk = 86;
            razy.ikilik = 84;
            razy.asist = 79;
            razy.steal = 54;
            razy.block = 41;
            razy.rebound = 59;
            razy.spec = enums.special.Normal;


            
            olabartan.name = "T.HOLABART";
            olabartan.foto = Resources.Tyrese_Haliburton;
           
            olabartan.pozisyon = enums.position.pg;
            olabartan.ucluk = 91;
            olabartan.ikilik = 86;
            olabartan.asist = 96;
            olabartan.steal = 94;
            olabartan.block = 58;
            olabartan.rebound = 64;
            olabartan.spec = enums.special.Normal;


            
            oldie.name = "T.OLDIE";
            oldie.foto = Resources.young;
            
            oldie.pozisyon = enums.position.pg;
            oldie.ucluk = 90;
            oldie.ikilik = 93;
            oldie.asist = 93;
            oldie.steal = 70;
            oldie.block = 59;
            oldie.rebound = 40;
            oldie.spec = enums.special.Clutch;

            lists.pgs.Add(pointguards.doric);
            lists.pgs2.Add(doric);//1


            lists.pgs.Add(pointguards.cory);//2
            lists.pgs2.Add(cory);

            lists.pgs.Add(pointguards.flaterth);//3
            lists.pgs2.Add(flaterth);

            lists.pgs.Add(pointguards.matchelli);//4
            lists.pgs2.Add(matchelli);

            lists.pgs.Add(pointguards.reisel);//5
            lists.pgs2.Add(reisel);

            lists.pgs.Add(pointguards.fixer);//6
            lists.pgs2.Add(fixer);

            lists.pgs.Add(pointguards.pertier); //7
            lists.pgs2.Add(pertier);

            lists.pgs.Add(pointguards.lallord);//8
            lists.pgs2.Add(lallord);

            lists.pgs2.Add(oldie);
            lists.pgs.Add(pointguards.oldie); //9

            lists.pgs.Add(pointguards.hearthen);//10
            lists.pgs2.Add(hearthen);

            lists.pgs.Add(pointguards.saimonz);//11
            lists.pgs2.Add(saimonz);

            lists.pgs.Add(pointguards.olabartan);//12
            lists.pgs2.Add(olabartan);


            lists.pgs.Add(pointguards.loverell);//13
            lists.pgs2.Add(loverell);

            lists.pgs.Add(pointguards.mariant);//14
            lists.pgs2.Add(mariant);

            lists.pgs.Add(pointguards.eastriver); //15
            lists.pgs2.Add(eastriver);

            lists.pgs.Add(pointguards.vacation); //16
            lists.pgs2.Add(vacation);

            lists.pgs.Add(pointguards.murat);//17
            lists.pgs2.Add(murat);

            lists.pgs.Add(pointguards.dandiwie); //18
            lists.pgs2.Add(dandiwie);

            lists.pgs.Add(pointguards.gorland);//19
            lists.pgs2.Add(gorland);

            lists.pgs.Add(pointguards.oneflet);//20
            lists.pgs2.Add(oneflet);

            lists.pgs.Add(pointguards.brick);//21
            lists.pgs2.Add(brick);

            lists.pgs.Add(pointguards.brownie);//22
            lists.pgs2.Add(brownie);

            lists.pgs.Add(pointguards.milton);//23
            lists.pgs2.Add(milton);

            lists.pgs.Add(pointguards.razy);//24
            lists.pgs2.Add(razy);

            lists.pgs2.Add(dussunmu);//25
            lists.pgs.Add(dussunmu);

            lists.pgs.Add(pointguards.breckton); //26
            lists.pgs2.Add(breckton);

            lists.pgs.Add(pointguards.speedley);//27
            lists.pgs2.Add(speedley);

            lists.pgs2.Add(coraso);//28
            lists.pgs.Add(coraso);

            lists.pgs.Add(pointguards.merris); //29
            lists.pgs2.Add(merris);

            lists.pgs.Add(pointguards.kounley); //30
            lists.pgs2.Add(kounley);

            lists.pgs.Add(pointguards.mccarter); //31
            lists.pgs2.Add(mccarter);

            lists.pgs.Add(pointguards.yousef);//32
            lists.pgs2.Add(yousef);

            lists.pgs.Add(pointguards.biverlai); //33
            lists.pgs2.Add(biverlai);

            




        }



    }
}
