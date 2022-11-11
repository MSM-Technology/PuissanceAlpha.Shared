using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class InvalidTokenException : ApiException
    {
        public InvalidTokenException(string message = "Invalid token.") : base(ErrorType.InvalidToken, HttpStatusCode.BadRequest, message) { }
    }
}