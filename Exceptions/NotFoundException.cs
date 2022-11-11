using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class NotFoundException : ApiException
    {
        public NotFoundException(Guid id, string message = "Not found (id:'{0}').") : base(ErrorType.NotFound, HttpStatusCode.NotFound, string.Format(message, id)) { }

        public NotFoundException(int id, string message = "Not found (id:'{0}').") : base(ErrorType.NotFound, HttpStatusCode.NotFound, string.Format(message, id)) { }

        public NotFoundException(string message = "Not found.") : base(ErrorType.NotFound, HttpStatusCode.NotFound, message) { }
    }
}