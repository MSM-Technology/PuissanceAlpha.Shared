using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class OperationInvalideException : ApiException
    {
        public OperationInvalideException(string message = "Opération invalide") : base(ErrorType.OperationInvalide, HttpStatusCode.UnprocessableEntity, message) { }
    }
}