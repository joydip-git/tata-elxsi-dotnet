using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleOldWebApp
{
    public class RequestModule : IHttpModule
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
            context.AuthenticateRequest += Context_AuthenticateRequest;
            context.AuthorizeRequest += Context_AuthorizeRequest;

            context.PostAuthorizeRequest += Context_PostAuthorizeRequest;
            context.PostAuthenticateRequest += Context_PostAuthenticateRequest;
            context.EndRequest += Context_EndRequest;
        }

        private void Context_PostAuthenticateRequest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Context_PostAuthorizeRequest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Context_BeginRequest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Context_EndRequest(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Context_AuthorizeRequest(object sender, EventArgs e)
        {
           //authorization
        }

        private void Context_AuthenticateRequest(object sender, EventArgs e)
        {            
            //authenticate
        }
    }
}