using Hff.JwtProje.Business.Interfaces;
using Hff.JwtProje.DataAccess.Interfaces;
using Hff.JwtProje.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JwtProje.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity : class, ITable, new()
    {
        private readonly IGenericDal<TEntity> _genericDal;
        public GenericManager(IGenericDal<TEntity> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task Add(TEntity entity)
        {
           await _genericDal.Add(entity);
        }

        public async Task Delete(int id)
        {
           await _genericDal.Delete(id);
        }

        public async Task<List<TEntity>> GetAll()
        {
          return await _genericDal.GetAll();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await _genericDal.GetById(id);
        }

        public async Task Update(TEntity entity)
        {
             await _genericDal.Update(entity);
        }
    }
}
