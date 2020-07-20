using Hff.JwtProje.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Mapping
{
    public class AppUserMap : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.UserName).HasMaxLength(100);
            builder.HasIndex(p => p.UserName).IsUnique();
            builder.Property(p => p.Password).HasMaxLength(100);
            builder.Property(p => p.FullName).HasMaxLength(50);
            builder.Property(p => p.UserName).IsRequired();
            builder.Property(p => p.Password).IsRequired();
            builder.HasMany(p => p.AppUserRoles).WithOne(p => p.AppUser).HasForeignKey(p=>p.AppUserId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
