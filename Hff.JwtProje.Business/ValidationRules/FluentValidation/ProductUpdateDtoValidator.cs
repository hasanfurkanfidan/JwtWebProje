using FluentValidation;
using Hff.JwtProje.Entities.Concrete;
using Hff.JwtProje.Entities.Dtos.ProductDtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.JwtProje.Business.ValidationRules.FluentValidation
{
   public class ProductUpdateDtoValidator:AbstractValidator<ProductUpdateDto>
    {
        public ProductUpdateDtoValidator()
        {

            RuleFor(p => p.Id).InclusiveBetween(0, int.MaxValue);
            RuleFor(p => p.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");

        }
    }
}
