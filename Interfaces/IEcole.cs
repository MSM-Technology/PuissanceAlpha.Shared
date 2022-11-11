using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceAlpha.Shared.Interfaces;

public interface IEcole
{

    int Id { get; set; }
    [Required]
    [MaxLength(128)] public string Nom { get; set; }

}