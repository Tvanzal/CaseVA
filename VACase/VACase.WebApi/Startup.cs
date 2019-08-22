using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using MySql.Data.MySqlClient;
using Owin;

[assembly: OwinStartup(typeof(VACase.WebApi.Startup))]

namespace VACase.WebApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            DbConfiguration.SetConfiguration(new MySqlConfiguration());
        }
    }
}
