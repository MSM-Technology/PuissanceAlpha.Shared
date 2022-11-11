using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class DeactivatedAccountException : ApiException
    {
        public DeactivatedAccountException(string message = "Deactivated account.") : base(ErrorType.DeactivatedAccount, HttpStatusCode.Unauthorized, message) { }
    }
}