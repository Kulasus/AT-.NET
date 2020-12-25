using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ATNET_WEBAPP_KON0355.Models
{
    public class Show
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Episodes { get; set; }
        public int Series { get; set; }
        public string  Character{ get; set; }

        public static List<Show> showsList = new List<Show>();

        public Show(int ID, string Name, int Episodes, int Series, string Character)
        {
            this.ID = ID;
            this.Name = Name;
            this.Episodes = Episodes;
            this.Series = Series;
            this.Character = Character;
            showsList.Add(this);
        }

        public static void loadShowsFromJson()
        {
            using (StreamReader file = File.OpenText(@"D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\shows.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                showsList = (List<Show>)serializer.Deserialize(file, typeof(List<Show>));
            }
        }
    }
}
