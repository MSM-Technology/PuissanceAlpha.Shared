using System.Runtime.Serialization;
using Newtonsoft.Json;
using PuissanceAlpha.Shared.Infrastructure;

namespace PuissanceAlpha.Shared.Enums;
[JsonConverter(typeof(StringEnumConverterHelper))]
public enum ErrorType
{
    [EnumMember(Value = "network_error")]
    NetworkError = 80,
    [EnumMember(Value = "invalid_parameter")]
    InvalidParameter = 81,
    [EnumMember(Value = "operation_invalide")]
    OperationInvalide = 86,
    [EnumMember(Value = "unauthorized_action")]
    UnauthorizedAction = 82,
    [EnumMember(Value = "not_found")]
    NotFound = 83,
    [EnumMember(Value = "forbidden")]
    Forbidden = 84,
    [EnumMember(Value = "conflict")]
    Conflict = 85,
    [EnumMember(Value = "invalid_token")]
    InvalidToken = 130,
    [EnumMember(Value = "expired_token")]
    ExpiredToken = 131,
    [EnumMember(Value = "missing_token")]
    MissingToken = 132,
    [EnumMember(Value = "deactivated_account")]
    DeactivatedAccount = 133,
    [EnumMember(Value = "pas_encore_ouvert")]
    PasEncoreOuvert = 134,
    [EnumMember(Value = "mail_not_sent")]
    MailNotSent = 180,

    [EnumMember(Value = "wrong_file_type")]
    WrongFileType = 230,
    [EnumMember(Value = "wrong_file_size")]
    WrongFileSize = 231,
}
