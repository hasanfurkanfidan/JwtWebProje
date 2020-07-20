using Hff.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.Entities.Dtos.ProductDtos
{
   public class ProductUpdateDto:IDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
