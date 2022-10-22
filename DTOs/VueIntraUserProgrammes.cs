using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.DTOs;

public class VueIntraUserProgrammes
{
    public VueIntraUserProgrammes()
    {
    }

    /// <summary>
    /// Indique si cela contient tout les users et les users programmes
    /// </summary>
    [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
    public bool ToutEffacerAvantUpdate { get; set; }

    public List<VueUserProgrammes> Utilisateurs { get; set; } = new();

    /// <summary>
    /// Pour verification, non requis en envoi
    /// </summary>
    public List<VueIntraProgramme> Programmes { get; set; } =new ();

    /*public void AjouterUser(UserModel userModel)
    {
        VueUserProgrammes vup = new VueUserProgrammes(userModel);
        Utilisateurs.Add(vup);
    }*/
}

public class VueUserProgrammes
{
    public VueUserProgrammes()
    {
    }
    /*
    public VueUserProgrammes(UserModel user)
    {
        Email=user.Email;
        Nom = user.LastName;
        Prenom=user.FirstName;
        Role = user.Role;
        ProgrammeIds = user.UserProgrammes.Select(x => x.ProgrammeId).ToList();
    }
    */
    [Required]
    public string Email { get; set; }

    public string? Nom { get; set; }

    public string? Prenom { get; set; }

    public UserRole? Role { get; set; }

    public List<int> ProgrammeIds { get; set; } = new();
}

public class VueIntraProgramme
{
    public int Id { get; set; }

    public string Nom { get; set; }

    public string Ecole { get; set; }

    public int EcoleId { get; set; }

    public VueIntraProgramme()
    {
    }
    /*public VueIntraProgramme(ProgrammeModel programme)
    {
        Id = programme.Id;
        Nom=programme.Nom;
        Ecole = programme.Ecole.Nom;
        EcoleId = programme.EcoleId;
    }

    public static List<VueIntraProgramme> FromProgrammes(IEnumerable<ProgrammeModel> programmes)
    {
        List<VueIntraProgramme> vue = new();
        foreach (ProgrammeModel p in programmes)
        {
            vue.Add(new VueIntraProgramme(p));
        }

        return vue;
    }*/
}

public class VueResultatMajProgramme
{
    public List<string> Logs { get; set; }=new ();
    public int UtilisateursAffectes { get; set; }
}