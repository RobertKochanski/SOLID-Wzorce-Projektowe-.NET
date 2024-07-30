﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
