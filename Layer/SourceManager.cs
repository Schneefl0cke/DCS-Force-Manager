using AssetsManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Layer
{
    public static class SourceManager
    {
        public static List<Player> Players =   new List<Player>();

        public static void SavePlayerList(string path)
        {
            path = Path.Combine(path);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));
            using(TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, Players);
            }
        }

        public static void LoadPlayerFile(string path)
        {
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Player>));

                using (TextReader writer = new StreamReader(path))
                {
                    Players = (List<Player>)serializer.Deserialize(writer);
                }
            }
        }
    }
}
