﻿using Music_API.Data.Context;
using System.Linq.Expressions;

namespace Music_API.Data.DAL
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private Music_API_Context Context { get; set; }
        private readonly DbSet<T> entities;

        public BaseRepository(Music_API_Context repositoryContext)
        {
            this.Context = repositoryContext;
            entities = Context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(string[] includes)
            => await includes.Aggregate(entities.AsQueryable(), (query, path) => query.Include(path)).ToListAsync();

        public async Task<IEnumerable<T>> GetMultipleByConditionAsync(Expression<Func<T, bool>> ex, string[] includes)
            => await includes.Aggregate(entities.Where(ex).AsQueryable(), (query, path) => query.Include(path)).ToListAsync();

        public async Task<T> GetSingleByConditionAsync(Expression<Func<T, bool>> ex, string[] includes)
            => await includes.Aggregate(entities.Where(ex).AsQueryable(), (query, path) => query.Include(path)).SingleOrDefaultAsync();

        public async Task<T> CreateAsync(T entity)
        {
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<T> UpdateAsync(T entity)
        {
            Context.Set<T>().Update(entity);
            await Context.SaveChangesAsync();

            return entity;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();

            return true;
        }
    }
}