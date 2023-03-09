using Microsoft.AspNetCore.Mvc;
using Mlt.Api.Base.Exceptions;

namespace Mlt.Api.Base.Controllers;

[ApiController, Route("[controller]")]
public class BaseController : ControllerBase
{
    public BaseController()
    { }

    protected async Task<IActionResult> HandleServiceCallErrorsAsync<T>(Func<Task<T>> asyncServiceCall)
    {
        try
        {
            return new OkObjectResult(await asyncServiceCall.Invoke());
        }
        catch (NotFoundException)
        {
            return new NotFoundResult();
        }
        catch (UnauthorizedAccessException e)
        {
            return new UnauthorizedObjectResult($"Call to {Request.Path} returned {e.Message}");
        }
        catch (HttpRequestException e)
        {
            return new BadRequestObjectResult($"Call to {Request.Path} returned {e.Message}");
        }
        catch (Exception e)
        {
            return new BadRequestObjectResult($"Call to {Request.Path} returned {e.Message}");
        }
    }
}