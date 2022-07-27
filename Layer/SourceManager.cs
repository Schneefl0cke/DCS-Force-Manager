using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer
{
    public static class SourceManager
    {
        public static List<string> PlayerNames = new List<string>();

        public static void SavePlayerList(string path)
        {
            path = Path.Combine(path);
            var playerNames = "";
            foreach (var player in PlayerNames)
                playerNames += player + ';';

            using (StreamWriter output = new StreamWriter(path))
            {
                foreach (var player in PlayerNames)
                {
                    output.WriteLine(player + ';');
                }
            }
        }

        public static void LoadPlayerFile(string path)
        {
            var fileContent = File.ReadAllText(path);
            var players = fileContent.Split(';');
            foreach (var player in players)
                PlayerNames.Add(player);
        }
    }
}
