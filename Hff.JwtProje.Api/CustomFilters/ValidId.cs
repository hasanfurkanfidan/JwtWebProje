using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.DataAccess.Interfaces;
using Hff.JwtProje.Entities.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hff.JwtProje.Api.CustomFilters
{
    public class ValidId<TEntity>  : IActionFilter where TEntity:class,ITable,new()
    {
        private readonly IGenericService<TEntity> _genericService ;
        public ValidId(IGenericService<TEntity> genericService)
        {
            _genericService = genericService;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
          var dictionary =   context.ActionArguments.Where(p => p.Key == "id").FirstOrDefault();
          var checkedId = (int)dictionary.Value;
          var entity =   _genericService.GetById(checkedId).Result;
            if (entity == null)
            {
                context.Result = new NotFoundObjectResult($"{checkedId} bulunamadı");
            }



        }
    }
}
