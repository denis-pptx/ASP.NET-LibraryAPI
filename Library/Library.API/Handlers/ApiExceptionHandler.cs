using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace Library.API.Handlers;

public class ApiExceptionHandler(ProblemDetailsFactory problemDetailsFactory) : IExceptionHandler
{
    private readonly ProblemDetailsFactory _problemDetailsFactory = problemDetailsFactory;

    public async ValueTask<bool> TryHandleAsync(
        HttpContext httpContext, 
        Exception exception, 
        CancellationToken cancellationToken)
    {
        if (exception is not ApiException apiException)
        {
            return false;
        }

        var problemDetails = _problemDetailsFactory.CreateProblemDetails(httpContext, 
            statusCode: (int)apiException.StatusCode, 
            detail: apiException.Message);

        httpContext.Response.StatusCode = (int)apiException.StatusCode;

        await httpContext.Response
            .WriteAsJsonAsync(problemDetails, cancellationToken);

        return true;
    }
}
