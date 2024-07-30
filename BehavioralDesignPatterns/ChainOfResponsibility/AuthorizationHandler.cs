using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AuthorizationHandler : BaseHandler
    {
        private Dictionary<int, int> entityOwners = new Dictionary<int, int>()
        {
            {100, 13},
            {101, 14},
            {102, 15}
        };

        public AuthorizationHandler(IHandler next) : base(next)
        {
            
        }

        public override void Handler(RequestContext requestContext)
        {
            Console.WriteLine("AuthorizationHandler");

            if (requestContext.Request.UserRole == "Admin") 
            {
                _next.Handler(requestContext);
                return;
            }

            if (entityOwners.TryGetValue(requestContext.Request.EntityId, out int ownerId))
            {
                if (ownerId == requestContext.Request.UserId)
                {
                    _next.Handler(requestContext);
                    return;
                }
            }

            requestContext.Response.IsSuccessful = false;
            requestContext.Response.Message = "User is not authorized";
        }
    }
}
