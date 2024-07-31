namespace ChainOfResponsibility
{
    internal class ResultHandler : BaseHandler
    {
        public ResultHandler(IHandler next) : base(next)
        {
        }

        public override void Handler(RequestContext requestContext)
        {
            Console.WriteLine("ResultHandler");

            requestContext.Response.IsSuccessful = true;
            requestContext.Response.Data = "some value";
        }
    }
}
