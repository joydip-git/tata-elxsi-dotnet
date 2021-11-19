using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleOldWebApp
{
    public class RequestHandler : IHttpHandler
    {
        public bool IsReusable => throw new NotImplementedException();

        public void ProcessRequest(HttpContext context)
        {
            //code to process request of a resource
        }
    }
}