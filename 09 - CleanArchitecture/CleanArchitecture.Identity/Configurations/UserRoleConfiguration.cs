
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "05bc6c8b-363e-4131-ac5a-d99e23e3d6f4",
                    UserId = "f70035d8-e72b-49b9-8f7f-d855a1bb6e55"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "27a1935a-bb60-4ab5-b3aa-42a5b2b751a1",
                    UserId = "5dc119f5-bf54-4254-a97b-1182393b4d88"
                }
            );
        }
    }
}
