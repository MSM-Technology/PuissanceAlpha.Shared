using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceAlpha.Shared.Interfaces;

public interface IProgrammeModel
{
    [Key]  int Id { get; set; }

    [MaxLength(256)]
    [Required]
    string Nom { get; set; }

    int EcoleId { get; set; }

    IEcole EcolePA { get; }
}