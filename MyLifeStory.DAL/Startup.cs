using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyLifeStory.DAL.Repositories;
using MyLifeStory.DAL.Repositories.Interfaces;
using MyLifeStory.Entities.Identity;

namespace MyLifeStory.DAL
{
    public static class Startup
    {
        public static void AddDataAccessLayerDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<LifeStoryContext>(options => options.UseMySql(connectionString));

            services.AddIdentity<ApplicationUser, ApplicationRole>()
               .AddEntityFrameworkStores<LifeStoryContext>()
               .AddDefaultTokenProviders();

            services.AddScoped<IBlogPostRepository, BlogPostRepository>();
        }
    }
}
