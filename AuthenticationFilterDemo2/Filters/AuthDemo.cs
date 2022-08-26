using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc.Filters;
using System.Web.Mvc;

namespace AuthenticationFilterDemo2.Filters
{
    public class AuthDemo : ActionFilterAttribute, IAuthenticationFilter
    {
        public void OnAuthentication(AuthenticationContext filterContext)
        {
            if(!filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                filterContext.Result=new HttpUnauthorizedResult();  
            }
        }

        public void OnAuthenticationChallenge(AuthenticationChallengeContext filterContext)
        {
           if(filterContext == null || filterContext.Result is HttpUnauthorizedResult)
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "UnAuthentication"
                };
            }
           else
            {
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Authenticated"
                };
            }
        }
    }
}