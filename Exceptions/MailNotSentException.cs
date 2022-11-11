using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class MailNotSentException : ApiException
    {
        public MailNotSentException(string message = "Mail sending failed.") : base(ErrorType.MailNotSent, HttpStatusCode.ServiceUnavailable, message) { }
    }
}