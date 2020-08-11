using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyLifeStory.Entities.BlogEntities;
using MyLifeStory.Entities.ChatEntities;
using MyLifeStory.Entities.Identity;

namespace MyLifeStory.DAL
{
	public class LifeStoryContext: IdentityDbContext<ApplicationUser, ApplicationRole, string,
        IdentityUserClaim<string>,
        ApplicationUserRole, IdentityUserLogin<string>,
        IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
		public LifeStoryContext(DbContextOptions<LifeStoryContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

		public DbSet<BlogPost> BlogPosts { get; set; }
		public DbSet<PostTheme> PostThemes { get; set; }
		public DbSet<UserSubscription> UserSubscriptions { get; set; }
		public DbSet<ChatMessage> ChatMessages { get; set; }
		public DbSet<ChatRoom> ChatRooms { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);

			builder.Entity<ApplicationUserRole>(userRole =>
			{
				userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

				userRole.HasOne(ur => ur.Role)
					.WithMany(r => r.UserRoles)
					.HasForeignKey(ur => ur.RoleId)
					.IsRequired();

				userRole.HasOne(ur => ur.User)
					.WithMany(r => r.UserRoles)
					.HasForeignKey(ur => ur.UserId)
					.IsRequired();
			});
		}
	}
}
