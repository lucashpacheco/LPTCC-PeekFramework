namespace Peek.Framework.Common.Errors
{
    public class NotFoundError : GenericError
    {
        public NotFoundError()
        {
            Code = Constants.Errors.ForbbidenCode;
            Message = Constants.Errors.ForbbidenMessage;
        }
    }
}
