using Bigbang.classes;
using Bigbang.Properties;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Bigbang.staticdatabase
{
    [Serializable]
    public static class teams
    {
        public static team secilentakim         = new team();
        public static int  kadrokapasitesi       = 10;
        public static bool playoff              = false;
        public static bool playoff2          = false;
        public static bool elendi           = false;
        public static bool final             = false;


        public static team birds        = new team();
        public static team clowns        = new team();
        public static team cows      = new team();
        public static team dakers       = new team();
        public static team eggers       = new team();
        public static team goldens      = new team();
        public static team kings        = new team();
        public static team princes       = new team();
        public static team magicians         = new team();
        public static team musculars         = new team();
        public static team tradons       = new team();
        public static team wolfs        = new team();


        public static List<team> lig     =new List<team>();
        public static List<team> lig2   = new List<team>();


        public static int  siradakitakim     = 0;
        public static bool ligbasla     =false;
        public static int  macsayisi     = 0;
        public static int  skor1        = 0;
        public static int  skor2         = 0;

        public static team play1    = new team();
        public static team play2    = new team();
        public static team play3    = new team();
        public static team play4    = new team();
        public static team play5    = new team();
        public static team play6    = new team();
        public static team play7    = new team();
        public static team play8    = new team();
        public static team play9    = new team();
        public static team play10 = new team();
        public static team play11 = new team();
        public static team play12 = new team();
        public static team play13 = new team();
        public static team play14 = new team();


        public static void SaveState()
        {
            using (var stream = new FileStream("teams.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, secilentakim   );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);//1-2-3-4
                formatter.Serialize(stream, kadrokapasitesi);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, playoff        );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);//2-3-4
                formatter.Serialize(stream, playoff2       );//2-3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, elendi         );//2-3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, final );//2-3-4


                stream.Flush();
                stream.Close();
            }
        }
        public static void SaveState2()
        {
            using (var stream = new  FileStream("teams2.bin", FileMode.Create))  //1-2-3-4
            {
                var formatter = new  BinaryFormatter();
                formatter.Serialize(stream, birds);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, clowns);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, cows);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, dakers);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, eggers);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, goldens);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, kings);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, princes);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, magicians);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, musculars);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, tradons);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, wolfs);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);

                stream.FlushAsync();
                stream.Close();

            }
        }

        public static void SaveState3()
        {
            using (var stream = new FileStream("teams3.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, lig); //1
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);


                formatter.Serialize(stream, siradakitakim);  //1
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, ligbasla);   //1
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, macsayisi);  //1
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, skor1);   //1-2-3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, skor2);  //1-2-3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);


                stream.FlushAsync();
                stream.Close();

            }
        }
        public static void SaveState4()
        {
            using (var stream = new FileStream("teams4.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter(); 
                formatter.Serialize(stream, play1);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);//2-3-4
                formatter.Serialize(stream, play2);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play3);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play4);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play5);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play6);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play7);
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play8);




                stream.FlushAsync();
                stream.Close();

            }
        }

        public static void SaveState5()
        {
            using (var stream = new FileStream("teams5.bin", FileMode.Create))
            {
                var formatter = new BinaryFormatter();

                
                formatter.Serialize(stream, play9);   //3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play10);  //3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play11);  //3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play12);  //3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play13);  //3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, play14);  //3-4
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);



                stream.FlushAsync();
                stream.Close();

            }
        }
        public static void LoadState()
        {
            if (File.Exists("teams.bin"))
            {
                using (var stream = new FileStream("teams.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    secilentakim     = (team)formatter.Deserialize(stream);
                    kadrokapasitesi  = (int)formatter.Deserialize(stream);
                    playoff          = (bool)formatter.Deserialize(stream);
                    playoff2         = (bool)formatter.Deserialize(stream);
                    elendi           = (bool)formatter.Deserialize(stream);
                    final =             (bool)formatter.Deserialize(stream);
                            


                }
            }
        }
        public static void LoadStatey()
        {
            if (File.Exists("teamsa.bin"))
            {
                using (var stream = new FileStream("teamsa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    secilentakim = (team)formatter.Deserialize(stream);
                    kadrokapasitesi = (int)formatter.Deserialize(stream);
                    playoff = (bool)formatter.Deserialize(stream);
                    playoff2 = (bool)formatter.Deserialize(stream);
                    elendi = (bool)formatter.Deserialize(stream);
                    final = (bool)formatter.Deserialize(stream);



                }
            }
        }

        public static void LoadState2()
        {
            if (File.Exists("teams2.bin"))
            {
                using (var stream = new FileStream("teams2.bin", FileMode.Open))   
                {
                    var formatter = new BinaryFormatter();
                    birds = (team)formatter.Deserialize(stream);
                    clowns = (team)formatter.Deserialize(stream);
                    cows = (team)formatter.Deserialize(stream);
                    dakers = (team)formatter.Deserialize(stream);
                    eggers = (team)formatter.Deserialize(stream);
                    goldens = (team)formatter.Deserialize(stream);
                    kings = (team)formatter.Deserialize(stream);
                    princes = (team)formatter.Deserialize(stream);
                    magicians = (team)formatter.Deserialize(stream);
                    musculars = (team)formatter.Deserialize(stream);
                    tradons = (team)formatter.Deserialize(stream);
                    wolfs = (team)formatter.Deserialize(stream);

                }
            }
        }
        public static void LoadState2y()
        {
            if (File.Exists("teams2a.bin"))
            {
                using (var stream = new FileStream("teams2a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    birds = (team)formatter.Deserialize(stream);
                    clowns = (team)formatter.Deserialize(stream);
                    cows = (team)formatter.Deserialize(stream);
                    dakers = (team)formatter.Deserialize(stream);
                    eggers = (team)formatter.Deserialize(stream);
                    goldens = (team)formatter.Deserialize(stream);
                    kings = (team)formatter.Deserialize(stream);
                    princes = (team)formatter.Deserialize(stream);
                    magicians = (team)formatter.Deserialize(stream);
                    musculars = (team)formatter.Deserialize(stream);
                    tradons = (team)formatter.Deserialize(stream);
                    wolfs = (team)formatter.Deserialize(stream);

                }
            }
        }

        public static void LoadState3()
        {
            if (File.Exists("teams3.bin"))
            {
                using (var stream = new FileStream("teams3.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    lig = (List<team>)formatter.Deserialize(stream);
                    lig2.Clear();
                    foreach(team team in lig)
                    {
                        lig2.Add(team);

                    }
                    lig2.Add(secilentakim);
                    
                    


                    siradakitakim = (int)formatter.Deserialize(stream);
                    ligbasla = (bool)formatter.Deserialize(stream);
                    macsayisi = (int)formatter.Deserialize(stream);
                    skor1 = (int)formatter.Deserialize(stream);
                    skor2 = (int)formatter.Deserialize(stream);



                }
            }
        }

        public static void LoadState3y()
        {
            if (File.Exists("teams3a.bin"))
            {
                using (var stream = new FileStream("teams3a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    lig = (List<team>)formatter.Deserialize(stream);
                    lig2.Clear();
                    foreach (team team in lig)
                    {
                        lig2.Add(team);

                    }
                    lig2.Add(secilentakim);




                    siradakitakim = (int)formatter.Deserialize(stream);
                    ligbasla = (bool)formatter.Deserialize(stream);
                    macsayisi = (int)formatter.Deserialize(stream);
                    skor1 = (int)formatter.Deserialize(stream);
                    skor2 = (int)formatter.Deserialize(stream);



                }
            }
        }

        public static void LoadState4()
        {
            if (File.Exists("teams4.bin"))
            {
                using (var stream = new FileStream("teams4.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    play1 = (team)formatter.Deserialize(stream);
                    play2 = (team)formatter.Deserialize(stream);
                    play3 = (team)formatter.Deserialize(stream);
                    play4 = (team)formatter.Deserialize(stream);
                    play5 = (team)formatter.Deserialize(stream);
                    play6 = (team)formatter.Deserialize(stream);
                    play7 = (team)formatter.Deserialize(stream);
                    play8 = (team)formatter.Deserialize(stream);


                }
            }
        }

        public static void LoadState4y()
        {
            if (File.Exists("teams4a.bin"))
            {
                using (var stream = new FileStream("teams4a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    play1 = (team)formatter.Deserialize(stream);
                    play2 = (team)formatter.Deserialize(stream);
                    play3 = (team)formatter.Deserialize(stream);
                    play4 = (team)formatter.Deserialize(stream);
                    play5 = (team)formatter.Deserialize(stream);
                    play6 = (team)formatter.Deserialize(stream);
                    play7 = (team)formatter.Deserialize(stream);
                    play8 = (team)formatter.Deserialize(stream);


                }
            }
        }
        public static void LoadState5()
        {
            if (File.Exists("teams5.bin"))
            {
                using (var stream = new FileStream("teams5.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
              
                    
                    play9 = (team)formatter.Deserialize(stream);
                    play10 = (team)formatter.Deserialize(stream);
                    play11 = (team)formatter.Deserialize(stream);
                    play12 = (team)formatter.Deserialize(stream);
                    play13 = (team)formatter.Deserialize(stream);
                    play14 = (team)formatter.Deserialize(stream);

                }
            }
        }

        public static void LoadState5y()
        {
            if (File.Exists("teams5a.bin"))
            {
                using (var stream = new FileStream("teams5a.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();


                    play9 = (team)formatter.Deserialize(stream);
                    play10 = (team)formatter.Deserialize(stream);
                    play11 = (team)formatter.Deserialize(stream);
                    play12 = (team)formatter.Deserialize(stream);
                    play13 = (team)formatter.Deserialize(stream);
                    play14 = (team)formatter.Deserialize(stream);

                }
            }
        }




        public static void takimyarat()
        {
            
            
            birds.name = "BIRDS";
            birds.logo = Resources.Birds;
            lig.Add(birds);
            lig2.Add(birds);



            clowns.name = "CLOWNS";
            clowns.logo = Resources.Clowns;
            lig.Add(clowns);
            lig2.Add(clowns);

            cows.name = "COWS";
            cows.logo = Resources.Cows;
            lig.Add(cows);
            lig2.Add(cows);

            dakers.name = "DAKERS";
            dakers.logo = Resources.Dakers;
            lig.Add(dakers);
            lig2.Add(dakers);

            eggers.name = "EGGERS";
            eggers.logo = Resources.Eggers;
            lig.Add(eggers);
            lig2.Add(eggers);

            goldens.name = "GOLDENS";
            goldens.logo = Resources.Goldens;
            lig.Add(goldens);
            lig2.Add(goldens);

            kings.name = "KINGS";
            kings.logo = Resources.King;
            lig.Add(kings);
            lig2.Add(kings);

            princes.name = "PRINCES";
            princes.logo = Resources.kings;
            lig.Add(princes);
            lig2.Add(princes);

            magicians.name = "MAGICIANS";
            magicians.logo = Resources.Magicians;
            lig.Add(magicians);
            lig2.Add(magicians);

            musculars.name = "MUSCULARS";
            musculars.logo = Resources.musculars;
            lig.Add(musculars);
            lig2.Add(musculars);

            tradons.name = "TRADONS";
            tradons.logo = Resources.Trodons;
            lig.Add(tradons);
            lig2.Add(tradons);

            wolfs.name = "WOLFS";
            wolfs.logo = Resources.Wolfs;
            lig.Add(wolfs);
            lig2.Add(wolfs);

            


        }




    }
}
