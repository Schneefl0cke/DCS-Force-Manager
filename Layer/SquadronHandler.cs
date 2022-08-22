using AssetsManager;
using SquadronManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Layer
{
    public static class SquadronHandler
    {
        public static List<Squadron> Squadrons = new List<Squadron>();

        public static void SavePlayerList(string path)
        {
            path = Path.Combine(path);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Squadron>));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, Squadrons);
            }
        }

        public static void LoadPlayerFile(string path)
        {
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Squadron>));

                using (TextReader writer = new StreamReader(path))
                {
                    Squadrons = (List<Squadron>)serializer.Deserialize(writer);
                }
            }
        }
    }
}
