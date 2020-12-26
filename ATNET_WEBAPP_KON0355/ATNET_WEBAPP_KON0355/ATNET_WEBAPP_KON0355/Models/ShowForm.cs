using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ATNET_WEBAPP_KON0355.Models
{
    public class ShowForm
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Series { get; set; }

        public int Episodes { get; set; }

        public string Character { get; set; }
    }
}
