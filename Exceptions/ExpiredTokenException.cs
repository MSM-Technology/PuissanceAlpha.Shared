using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class ExpiredTokenException : ApiException
    {
        public ExpiredTokenException(string message = "Expired token.") : base(ErrorType.ExpiredToken, HttpStatusCode.Unauthorized, message) { }
    }
}