namespace ChainOfResponsibility
{
    internal interface IHandler
    {
        void Handler(RequestContext requestContext);
    }
}
