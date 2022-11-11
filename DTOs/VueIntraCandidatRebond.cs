using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceAlpha.Shared.DTOs;

public class VueIntraCandidatRebond
{
        
    public string SimpleCode { get; set; }
    [Required]
    public string Nom { get; set; }
    [Required]
    public string Prenom { get; set; }
    [StringLength(1,MinimumLength = 1)]
    public string Genre { get; set; }
}