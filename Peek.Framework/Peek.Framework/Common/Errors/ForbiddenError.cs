namespace Peek.Framework.Common.Errors
{
    public class ForbiddenError : GenericError
    {
        public ForbiddenError()
        {
            Code = Constants.Errors.ForbbidenCode;
            Message = Constants.Errors.ForbbidenMessage;
        }
    }
}
