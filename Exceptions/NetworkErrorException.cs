using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class NetworkErrorException : ApiException
    {
        public NetworkErrorException(string message = "Internal network error.") : base(ErrorType.NetworkError, HttpStatusCode.InternalServerError, message) { }
    }
}