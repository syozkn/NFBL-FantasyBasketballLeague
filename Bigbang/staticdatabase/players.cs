using Bigbang.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Bigbang.staticdatabase
{
    [Serializable]
    public static  class players
    {
        public static void SaveState()
        {
            using (var stream = new FileStream("players.bin", FileMode.Create)) //gerek yok
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, oyuncu1   );
                stream. FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu2     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu3     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu4     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu5     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu6     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu7     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu8     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu9     );
                stream.FlushAsync();
                stream.Seek(0, SeekOrigin.End);
                formatter.Serialize(stream, oyuncu10);
                stream.FlushAsync();
                stream.Close();

            }
        }

        public static void LoadState()
        {
            if (File.Exists("players.bin"))
            {
                using (var stream = new FileStream("players.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    oyuncu1 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu2 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu3 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu4 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu5 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu6 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu7 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu8 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu9 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu10 = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }
        public static void LoadStatey()
        {
            if (File.Exists("playersa.bin"))
            {
                using (var stream = new FileStream("playersa.bin", FileMode.Open))
                {
                    var formatter = new BinaryFormatter();
                    oyuncu1 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu2 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu3 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu4 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu5 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu6 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu7 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu8 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu9 = (oyuncu)formatter.Deserialize(stream);
                    oyuncu10 = (oyuncu)formatter.Deserialize(stream);
                }
            }
        }






        public static oyuncu oyuncu1 = new oyuncu();
        public static oyuncu oyuncu2 = new oyuncu();
        public static oyuncu oyuncu3 = new oyuncu();
        public static oyuncu oyuncu4 = new oyuncu();
        public static oyuncu oyuncu5 = new oyuncu();
        public static oyuncu oyuncu6 = new oyuncu();
        public static oyuncu oyuncu7 = new oyuncu();
        public static oyuncu oyuncu8 = new oyuncu();
        public static oyuncu oyuncu9 = new oyuncu();
        public static oyuncu oyuncu10 = new oyuncu();




        
    }

    


}
