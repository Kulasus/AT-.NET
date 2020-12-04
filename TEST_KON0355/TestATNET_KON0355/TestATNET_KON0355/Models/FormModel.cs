using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestATNET_KON0355.Models
{
    public class FormModel
    {
        [Display(Name = "Jméno")]
        [Required(ErrorMessage = "Jméno je povinné.")]
        public string jmeno { get; set; }
        [Display(Name = "Přijmení")]
        [Required(ErrorMessage = "Přijmení je povinné.")]
        public string prijmeni { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email je povinný.")]
        [EmailAddress]
        public string email { get; set; }
        [Display(Name = "Věk")]
        [Required(ErrorMessage = "Věk je povinný.")]
        public int vek { get; set; }
        [Display(Name = "Text")]
        [Required(ErrorMessage = "Text je povinný.")]
        public string text { get; set; }
    }
}
