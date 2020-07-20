using FluentValidation;
using Hff.JwtProje.Entities.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.Business.ValidationRules.FluentValidation
{
   public class ProductAddDtoValidator:AbstractValidator<ProductAddDto>
    {
        public ProductAddDtoValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");

        }
    }
}
