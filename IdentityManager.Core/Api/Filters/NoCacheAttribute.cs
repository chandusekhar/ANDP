﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Filters;

namespace Thinktecture.IdentityManager.Core.Api.Filters
{
    class NoCacheAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
            if (actionExecutedContext.Response.IsSuccessStatusCode)
            {
                var cc = new System.Net.Http.Headers.CacheControlHeaderValue();
                cc.NoStore = true;
                cc.NoCache = true;
                cc.Private = true;
                cc.MaxAge = TimeSpan.Zero;
                actionExecutedContext.Response.Headers.CacheControl = cc;
            }
        }
    }
}
