﻿using Hff.JwtProje.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.Business.Interfaces
{
   public interface IJwtService
    {
        public string CreateJwtToken(AppUser appUser, List<AppRole> roles);

    }
}
