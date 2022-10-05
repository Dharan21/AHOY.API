using AHOY.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AHOY.Infrastructure
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext Context;
        private readonly DbSet<TEntity> Entities;
        public Repository(DbContext dbContext)
        {
            this.Context = dbContext;
            Entities = Context.Set<TEntity>();
        }
        public async Task<List<TEntity>> GetAll()
        {
            return await Entities.ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Entities.FindAsync(id);
        }

        public async Task Create(TEntity entity)
        {
            await Entities.AddAsync(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Delete(int id)
        {
            var entity = await Context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                return null;
            }

            Context.Set<TEntity>().Remove(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> FindAsync(Expression<Func<TEntity, bool>> match)
        {
            return await Entities.Where(match).FirstOrDefaultAsync();
        }
        public async Task<List<TEntity>> FindAllAsync(Expression<Func<TEntity, bool>> match)
        {
            return await Entities.Where(match).ToListAsync();
        }

        public void Dispose()
        { }
    }
}
