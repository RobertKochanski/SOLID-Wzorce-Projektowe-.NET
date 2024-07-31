namespace ChainOfResponsibility
{
    internal abstract class BaseHandler : IHandler
    {
        protected IHandler _next;

        protected BaseHandler(IHandler next)
        {
            _next = next;
        }

        public abstract void Handler(RequestContext requestContext);
    }
}
