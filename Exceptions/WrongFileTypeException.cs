using System.Net;
using PuissanceAlpha.Shared.Enums;

namespace PuissanceAlpha.Shared.Exceptions
{
    public class WrongFileTypeException : ApiException
    {
        public WrongFileTypeException(string message = "Wrong file type.") : base(ErrorType.WrongFileType, HttpStatusCode.BadRequest, message) { }
    }
}