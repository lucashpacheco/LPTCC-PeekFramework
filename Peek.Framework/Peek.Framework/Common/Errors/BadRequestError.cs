namespace Peek.Framework.Common.Errors
{
    public class BadRequestError : GenericError
    {
        public BadRequestError()
        {
            Code = Constants.Errors.BadRequestCode;
            Message = Constants.Errors.BadRequestMessage;
        }
    }
}
