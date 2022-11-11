using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using PuissanceAlpha.Shared.Infrastructure;

namespace PuissanceAlpha.Shared.Enums;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[JsonConverter(typeof(StringEnumConverterHelper))]
public enum UserGender
{
    /// <summary>
    /// Les descriptions sont utilisés dans la classe EnumHelper
    /// Sert notamment pour l'export user (transformer l'enum en texte)
    /// </summary>
    [Description("Non précisé")]
    [EnumMember(Value = "none")]
    None = 0,

    [Description("Masculin")]
    [EnumMember(Value = "male")]
    Male = 1,

    [Description("Féminin")]
    [EnumMember(Value = "female")]
    Female = 2,
}