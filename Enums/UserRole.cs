using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PuissanceAlpha.Shared.Infrastructure;

namespace PuissanceAlpha.Shared.Enums;

[JsonConverter(typeof(StringEnumConverterHelper))]
public enum UserRole
{
    [EnumMember(Value = "none")]
    None = 0,
    [Description("Candidat")]
    [EnumMember(Value = "user")] // Candidat
    User = 1,
    [Description("Ecole-Consult.")]
    [EnumMember(Value = "school_reader")]
    SchoolReader = 2,
    [Description("Admin. PA")]
    [EnumMember(Value = "admin")]
    Admin = 3,
    [Description("Ecole-Admin")]
    [EnumMember(Value = "school_admin")]
    SchoolAdmin = 4,
}