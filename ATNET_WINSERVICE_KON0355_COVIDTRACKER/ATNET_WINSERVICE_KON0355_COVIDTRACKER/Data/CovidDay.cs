using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ATNET_WINSERVICE_KON0355_COVIDTRACKER.Data
{
    /// <summary>
    /// Represents covid cases of one day
    /// </summary>
    class CovidDay
    {
        [JsonProperty("datum")]
        private DateTime date { get; set; }

        /// <summary>
        /// Represents new covid cases
        /// </summary>
        [JsonProperty("prirustkovy_pocet_nakazenych")]
        public int newCases { get; set; }

        /// <summary>
        /// Represents total covid cases to this day
        /// </summary>
        [JsonProperty("kumulativni_pocet_nakazenych")]
        public int totalCases { get; set; }


        public CovidDay(DateTime date, int newCases, int totalCases)
        {
            this.date = date;
            this.newCases = newCases;
            this.totalCases = totalCases;
        }

    }

}
