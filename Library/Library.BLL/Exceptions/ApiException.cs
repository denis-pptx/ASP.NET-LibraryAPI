namespace Library.BLL.Exceptions;

public class ApiException : Exception
{
    public HttpStatusCode StatusCode { get; }
    public ApiException(HttpStatusCode statusCode, string message) 
        : base(message)
    {
        StatusCode = statusCode;   
    }
}
