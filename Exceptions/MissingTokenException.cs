using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class MissingTokenException : ApiException
    {
        public MissingTokenException(string message = "Missing token.") : base(ErrorType.MissingToken, HttpStatusCode.Forbidden, message) { }
    }
}