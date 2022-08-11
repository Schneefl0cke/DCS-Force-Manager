using Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Layer
{
    public static class CampaignHandler
    {
        public static Campaign Campaign = new Campaign();

        public static void SavePlayerList(string path)
        {
            path = Path.Combine(path);

            XmlSerializer serializer = new XmlSerializer(typeof(Campaign));
            using (TextWriter writer = new StreamWriter(path))
            {
                serializer.Serialize(writer, Campaign);
            }
        }

        public static void LoadPlayerFile(string path)
        {
            if (File.Exists(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Campaign));

                using (TextReader writer = new StreamReader(path))
                {
                    Campaign = (Campaign)serializer.Deserialize(writer);
                }
            }
        }

        //Analyze Campaign Mission (like single mission)

        //Analyze all Campaigns (concat all lists, then like single mission), increase counter
    }
}
