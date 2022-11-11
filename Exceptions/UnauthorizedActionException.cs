using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class UnauthorizedActionException : ApiException
    {
        public UnauthorizedActionException(string message = "Unauthorized action(s).") : base(ErrorType.UnauthorizedAction, HttpStatusCode.Unauthorized, message) { }
    }
}