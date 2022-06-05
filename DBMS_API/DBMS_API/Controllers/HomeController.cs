using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    [Route("/error")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public IActionResult Error([FromServices] IConfiguration configuration)
    {
        var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
        int statusCode;
        string title;
        string fullError = configuration.GetSection("AllowFullError").Get<bool>() ? context.Error.ToString() : null;

        switch (context.Error)
        {
            case ArgumentNullException ae:
                statusCode = 404;
                title = $"Объект не найден";
                break;
            case InvalidOperationException ioe:
                statusCode = 400;
                title = $"Bad request";
                break;
            case NotSupportedException nse:
                statusCode = 405;
                title = $"Method Not Allowed";
                break;
            case NotImplementedException nie:
                statusCode = 501;
                title = $"Not Implemented";
                break;
            default:
                statusCode = 500;
                title = "Internal Server Error";
                break;
        }

        return Problem(
            title: title,
            statusCode: statusCode,
            detail: fullError);
    }
}