namespace Peek.Framework.Common.Errors
{
    public class UnauthorizedError : GenericError
    {
        public UnauthorizedError()
        {
            Code = Constants.Errors.UnauthorizedCode;
            Message = Constants.Errors.UnauthorizedMessage;
        }
    }
}
