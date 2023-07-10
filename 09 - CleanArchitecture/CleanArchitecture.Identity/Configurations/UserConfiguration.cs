

using CleanArchitecture.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "f70035d8-e72b-49b9-8f7f-d855a1bb6e55",
                    Email = "admin@localhost.com",
                    NormalizedEmail = "admin@localhost.com",
                    Name = "Kone",
                    Surname = "Blaz",
                    UserName = "Bokkoa",
                    NormalizedUserName = "Bokkoa",
                    PasswordHash = hasher.HashPassword(null, "Bokkoa2023$"),
                    EmailConfirmed = true,
                },
                  new ApplicationUser
                  {
                      Id = "5dc119f5-bf54-4254-a97b-1182393b4d88",
                      Email = "juanperez@localhost.com",
                      NormalizedEmail = "juanperez@localhost.com",
                      Name = "Juan",
                      Surname = "Perez",
                      UserName = "juanperez",
                      NormalizedUserName = "juanperez",
                      PasswordHash = hasher.HashPassword(null, "Bokkoa2023$"),
                      EmailConfirmed = true,
                  }
                );
        }
    }
}
