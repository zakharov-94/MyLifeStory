using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyLifeStory.DAL
{
    public static class Startup
    {
        public static void AddDataAccessLayerDependencies(this IServiceCollection services)
        {
            //services.AddDbContext<LifeStoryContext>(_ => new );


        }
    }
}
