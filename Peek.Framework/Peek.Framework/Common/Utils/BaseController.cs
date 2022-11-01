using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Peek.Framework.Common.Responses;

namespace Peek.Framework.Common.Utils
{
    public class BaseController : ControllerBase
    {
        protected ActionResult CustomResponse<T>(ResponseBase<T> response)
        {
            if (response.Errors != null && response.Errors.Any())
            {
                if (response.Errors.Contains(Constants.Errors.UnauthorizedMessage))
                    return Unauthorized();

                if (response.Errors.Contains(Constants.Errors.ForbbidenMessage))

                    if (response.Errors.Contains(Constants.Errors.NotfoundMessage))
                        return NotFound();

                return BadRequest(new
                {
                    success = response.Success,
                    errors = response.Errors.Select(n => n)
                });
            }

            return Ok(new
            {
                success = response.Success,
                data = response.Data
            });
        }
    }
}