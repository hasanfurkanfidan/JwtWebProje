using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.DataAccess.Interfaces;
using Hff.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.Business.Concrete
{
   public class AppUserManager:GenericManager<AppUser>,IAppUserService
    {
        public AppUserManager(IGenericDal<AppUser>genericDal):base(genericDal)
        {

        }
    }
}
