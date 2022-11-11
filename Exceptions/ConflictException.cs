using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class ConflictException : ApiException
    {
        public ConflictException(string message = "Conflit.") : base(ErrorType.Conflict, HttpStatusCode.Conflict, message) { }
    }
}
