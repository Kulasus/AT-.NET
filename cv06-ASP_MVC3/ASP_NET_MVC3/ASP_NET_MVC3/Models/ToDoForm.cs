using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_NET_MVC3.Models
{
    public class ToDoForm
    {
        [Required(ErrorMessage = "Musíte zadat text úkolu.")]
        [Display(Name = "Úkol")]
        public string Text { get; set; }
    }
}
