using FluentValidation;
using Hff.JwtProje.Business.Concrete;
using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.Business.ValidationRules.FluentValidation;
using Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Hff.JwtProje.DataAccess.Interfaces;
using Hff.JwtProje.Entities.Dtos.ProductDtos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.Business.Containers.MicrosoftIoc
{
   public static class CustomExtention
    {
        public static void AddDependenceis(this IServiceCollection services)
        {
            services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));
            services.AddScoped(typeof(IGenericDal<>), typeof(EfGenericRepository<>));
            services.AddScoped<IProductDal, EfProductRepository>();
            services.AddScoped<IProductService, ProductManager>();
            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserRepository>();
            services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
            services.AddScoped<IAppRolesService, AppRoleManager>();
            services.AddScoped<IAppRoleDal, EfAppRoleRepository>();
            services.AddScoped<IAppUserRoleService, AppUserRoleManager>();
            services.AddScoped<IAppUserRoleDal, EfAppUserRoleRepository>();
            services.AddTransient<IValidator<ProductAddDto>, ProductAddDtoValidator>();

        }
    }
}
