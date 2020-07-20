using Hff.JwtProje.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AppRoleMap : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).HasMaxLength(100);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired();
            builder.HasMany(p => p.AppUserRoles).WithOne(p => p.AppRole).HasForeignKey(p => p.AppRoleId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
