using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class WrongFileSizeException : ApiException
    {
        public WrongFileSizeException(string message = "Wrong file size.") : base(ErrorType.WrongFileSize, HttpStatusCode.BadRequest, message) { }
    }
}