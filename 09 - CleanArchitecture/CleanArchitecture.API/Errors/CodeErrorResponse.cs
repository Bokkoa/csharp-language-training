namespace CleanArchitecture.API.Errors
{
    public class CodeErrorResponse
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }

        public CodeErrorResponse(int statusCode, string? message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageStatusCode(statusCode);
        }

        private string GetDefaultMessageStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "The selected request has errors",
                401 => "You dont have permissions to this resource",
                404 => "The resource was not found",
                500 => "Errors on server",
                _ => ""
            };
        }
    }
}
