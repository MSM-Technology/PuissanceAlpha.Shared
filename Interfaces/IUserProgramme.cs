using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuissanceAlpha.Shared.Interfaces;

public interface IUserProgramme
{
    int ProgrammeId { get; set; }

    int UserId { get; set; }
}