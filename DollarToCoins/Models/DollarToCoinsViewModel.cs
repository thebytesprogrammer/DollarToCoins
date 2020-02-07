using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace DollarToCoins.Models
{
    public class DollarToCoinsViewModel
    {
        [Required]
        [Display(Name = "Your Dollar Amount")]
        public string dollarAmount { get; set; }        
    }
}
