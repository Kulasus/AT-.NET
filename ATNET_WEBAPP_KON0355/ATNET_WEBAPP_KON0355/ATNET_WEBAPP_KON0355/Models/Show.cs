using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using ATNET_WEBAPP_KON0355.Exceptions;
using System.Diagnostics;

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

        private static Random rand = new Random();


        public Show(string Name, int Episodes, int Series, string Character)
        {
            this.ID = generateId();
            this.Name = Name;
            this.Episodes = Episodes;
            this.Series = Series;
            this.Character = Character;
            addShow(this);
        }

        [JsonConstructor]
        public Show(int ID, string Name, int Episodes, int Series, string Character)
        {
            this.ID = ID;
            this.Name = Name;
            this.Episodes = Episodes;
            this.Series = Series;
            this.Character = Character;
            addShow(this);
        }

        public static bool updateShow(ShowForm newShow)
        {
            deleteShowFromJson(newShow.ID);
            Show dummy = new Show(newShow.ID, newShow.Name, newShow.Episodes, newShow.Series, newShow.Character);
            return true;
        }

        public static void loadShowsFromJson()
        {
            try
            {
                using (StreamReader file = File.OpenText(@"D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\shows.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    showsList = (List<Show>)serializer.Deserialize(file, typeof(List<Show>));
                }
            }
            catch(IOException e)
            {
                Debug.WriteLine(e.ToString());
            }

        }

        public static bool deleteShowFromJson(int showId)
        {
            //LAMBDA 1
            if(showsList.Remove(showsList.Find(x => x.ID == showId)))
            {
                saveShowsToJson();
                return true;
            }
            else
            {
                //CUSTOM EXCEPTION 1
                throw new ShowNotFoundException("Bad ID");
            }
        }

        private static void saveShowsToJson()
        {
            try
            {
                using (StreamWriter file = File.CreateText(@"D:\Coding\AT-.NET-GIT\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\ATNET_WEBAPP_KON0355\shows.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, showsList);
                }
            }
            catch(IOException e)
            {
                Debug.WriteLine(e.ToString());
            }
        }

        public static void addShow(Show newShow)
        {
            showsList.Add(newShow);
            sortShows();
            saveShowsToJson();
        }

        private static void sortShows()
        {
            //LAMBDA 2
            showsList.OrderBy(x => x.ID);
        }

        public static bool containsById(int showId)
        {
            //LAMBDA 3
            return showsList.Where(x => x.ID == showId).ToList().Count == 1;
        }

        public static Show getOneById(int showId)
        {
            //LAMBDA 4
            return showsList.Find(x => x.ID == showId);
        }

        private static int generateId()
        {
            int ret;
            do
            {
                ret = rand.Next();
            }
            while (getOneById(ret) != null);
            return ret;
        }
    }
}
