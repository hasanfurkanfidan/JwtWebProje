using Hff.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hff.JwtProje.Entities.Dtos.ProductDtos
{
   public class ProductAddDto:IDto
    {
        
        public string Name { get; set; }
    }
}
