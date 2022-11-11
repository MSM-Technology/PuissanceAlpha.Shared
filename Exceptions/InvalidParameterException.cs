using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class InvalidParameterException : ApiException
    {
        public InvalidParameterException(string message = "Invalid parameter(s).") : base(ErrorType.InvalidParameter, HttpStatusCode.BadRequest, message) { }
    }
}