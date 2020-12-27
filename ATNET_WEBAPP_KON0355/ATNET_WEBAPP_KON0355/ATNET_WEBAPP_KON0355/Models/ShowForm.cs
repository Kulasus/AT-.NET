
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ATNET_WEBAPP_KON0355.Models
{
    public class ShowForm
    {
        public int ID { get; set; }

        [Display(Name = "Name", ResourceType = (typeof(GlobalizationResources.Resources)))]
        public string Name { get; set; }

        [Display(Name = "Series", ResourceType = (typeof(GlobalizationResources.Resources)))]
        public int Series { get; set; }

        [Display(Name = "Episodes", ResourceType = (typeof(GlobalizationResources.Resources)))]
        public int Episodes { get; set; }

        [Display(Name = "FavChar", ResourceType = (typeof(GlobalizationResources.Resources)))]
        public string Character { get; set; }
    }
}
