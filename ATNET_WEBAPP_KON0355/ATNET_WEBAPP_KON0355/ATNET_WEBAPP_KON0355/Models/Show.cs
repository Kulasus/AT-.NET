using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATNET_WEBAPP_KON0355.Models
{
    public class Show
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Episodes { get; set; }
        public int Series { get; set; }
        public string  Character{ get; set; }

        public static List<Show> savedShows = new List<Show>();

        public Show(int ID, string Name, int Episodes, int Series, string Character)
        {
            this.ID = ID;
            this.Name = Name;
            this.Episodes = Episodes;
            this.Series = Series;
            this.Character = Character;
            savedShows.Add(this);
        }
    }
}
