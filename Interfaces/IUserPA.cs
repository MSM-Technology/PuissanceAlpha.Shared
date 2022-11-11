using PuissanceAlpha.Shared.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceAlpha.Shared.Interfaces;

public interface IUserPA
{
    int Id { get; set; }
    UserRole Role { get; set; }

    [MaxLength(256)]
    string? Email { get; set; }

    UserGender? Gender { get; set; }

    [MaxLength(64)]
    string FirstName { get; set; }

    [MaxLength(64)]
    string LastName { get; set; }

    List<IUserProgramme> Programmes { get;  }
}