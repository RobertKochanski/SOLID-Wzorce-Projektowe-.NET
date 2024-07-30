namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var requestContext = new RequestContext()
            {
                Request = new Request()
                {
                    EntityId = 101,
                    UserId = 14,
                    UserRole = "User"
                },
                Response = new Response()
            };

            var resultHandler = new ResultHandler(null);
            var validationHandler = new ValidationHandler(resultHandler);
            var authorizationHandler = new AuthorizationHandler(validationHandler);

            authorizationHandler.Handler(requestContext);

            Console.WriteLine($"IsSuccessful: {requestContext.Response.IsSuccessful}");
            Console.WriteLine($"Message: {requestContext.Response.Message}");
            Console.WriteLine($"Data: {requestContext.Response.Data}");
        }
    }
}
