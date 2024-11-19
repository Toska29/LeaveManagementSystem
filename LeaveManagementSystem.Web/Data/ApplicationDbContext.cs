using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "a80f92ca-0961-4d0a-9576-1211a89b23f3",
                Name = "Employee",
                NormalizedName = "EMPLOYEE"
            },
            new IdentityRole
            {
                Id = "d1683113-5b67-4a62-b096-c619583c6195",
                Name = "Supervisor",
                NormalizedName = "SUPERVISOR"
            },
            new IdentityRole
            {
                Id = "b47ad046-1092-43bb-a2f0-e697bde302d2",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            builder.Entity<ApplicationUser>().HasData(
                new ApplicationUser
                {
                    Id = "d46ad749-c5cb-4e69-8e5a-e2e7e308e837",
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    NormalizedEmail = "ADMIN@GMAIL.COM",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    PasswordHash = passwordHasher.HashPassword(null, "Password2024"),
                    EmailConfirmed = true,
                    FirstName = "Default",
                    LastName = "Admin",
                    DateOfBirth = new DateOnly(2024, 11, 18)
                }
                );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    UserId = "d46ad749-c5cb-4e69-8e5a-e2e7e308e837",
                    RoleId = "b47ad046-1092-43bb-a2f0-e697bde302d2"
                }
                );
        }

        public DbSet<LeaveType> LeaveTypes { get; set; }
    }
}
