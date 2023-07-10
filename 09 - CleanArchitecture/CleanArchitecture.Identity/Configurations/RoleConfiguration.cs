

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.Identity.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
               new IdentityRole
               {
                   Id = "05bc6c8b-363e-4131-ac5a-d99e23e3d6f4",
                   Name = "Admin",
                   NormalizedName = "ADMIN"
               },
                new IdentityRole
                {
                    Id = "27a1935a-bb60-4ab5-b3aa-42a5b2b751a1",
                    Name = "Operator",
                    NormalizedName = "OPERATOR"
                }
            );
        }
    }
}
