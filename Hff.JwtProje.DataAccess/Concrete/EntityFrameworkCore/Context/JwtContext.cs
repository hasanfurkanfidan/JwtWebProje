using Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using Hff.JwtProje.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Context
{
   public class JwtContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-3VB3SSC\\MSSQLSERVERLAST;database=JwtProje;integrated security = true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new AppUserRoleMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new AppUserMap());
        }
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppRole> AppRoles { get; set; }

        public DbSet<AppUserRole> AppUserRoles { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}
