using Hff.JwtProje.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
   public class AppUserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasIndex(p => new { p.AppUserId, p.AppRoleId }).IsUnique();

        }
    }
}
