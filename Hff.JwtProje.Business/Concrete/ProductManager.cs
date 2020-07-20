using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.DataAccess.Interfaces;
using Hff.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.Business.Concrete
{
   public class ProductManager:GenericManager<Product>,IProductService
    {

        public ProductManager(IGenericDal<Product> genericDal):base(genericDal)
        {
                
        }
    }
}
