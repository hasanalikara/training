﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(UserIdentity.App_Start.IdentityConfig))]

namespace UserIdentity.App_Start
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=316888

            //app.UseCookieAuthentication
        }
    }
}