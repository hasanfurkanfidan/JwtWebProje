using Hff.JwtProje.Entities.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hff.JwtProje.Business.Interfaces
{
   public interface IGenericService<TEntity>where TEntity:class,ITable,new()
    {
        Task<List<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Update(TEntity entity);
        Task Add(TEntity entity);
        Task Delete(int id);
    }
}
