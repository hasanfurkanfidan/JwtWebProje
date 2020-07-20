using Hff.JwtProje.DataAccess.Interfaces;
using Hff.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
   public class EfProductRepository:EfGenericRepository<Product>,IProductDal
    {
    }
}
