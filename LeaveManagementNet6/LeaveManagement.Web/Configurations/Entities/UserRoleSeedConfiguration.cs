using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                        UserId = "408aa945-3d84-4421-8342-7269ec64d949"
                        
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                        UserId = "b8362b3f-9dd3-4d21-ba75-89566a4429ce"

                    }
                 );

        }
    }
}