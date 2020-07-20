using Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Context;
using Hff.JwtProje.DataAccess.Interfaces;
using Hff.JwtProje.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hff.JwtProje.DataAccess.Concrete.EntityFrameworkCore.Repositories
{
    public class EfGenericRepository<TEntity> : IGenericDal<TEntity> where TEntity : class, ITable, new()
    {
        public async Task Add(TEntity entity)
        {
            using (var context = new JwtContext())
            {
                context.Add(entity);
               await context.SaveChangesAsync();
            }
        }

        public async Task Delete(int id)
        {
            using var context = new JwtContext();
            context.Remove(id);
           await context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            using var context = new JwtContext();
            return await context.Set<TEntity>().ToListAsync();
        }

        public async Task<List<TEntity>> GetAllByFilter(Expression<Func<TEntity, bool>> filter)
        {
            using var context = new JwtContext();
            return await context.Set<TEntity>().Where(filter).ToListAsync();
        }

        public async Task<TEntity> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            var context = new JwtContext();
            return await context.Set<TEntity>().Where(filter).FirstOrDefaultAsync();

        }

        public async Task<TEntity> GetById(int id)
        {
            var context = new JwtContext();
            return await context.Set<TEntity>().FindAsync(id);

        }

        public async Task Update(TEntity entity)
        {
            var context = new JwtContext();
             context.Update(entity);
            await context.SaveChangesAsync();

        }
    }
}
