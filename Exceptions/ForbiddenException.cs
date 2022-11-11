using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions;

public class ForbiddenException : ApiException
{
    public ForbiddenException(string message = "Forbidden.") : base(ErrorType.Forbidden, HttpStatusCode.Forbidden, message) { }
}