﻿using System.Linq.Expressions;

namespace Music_API.Data.DAL
{
    public interface IBaseRepository<T>
    {
        Task<IEnumerable<T>> GetAllAsync(string[] includes);

        Task<IEnumerable<T>> GetMultipleByConditionAsync(Expression<Func<T, bool>> ex, string[] includes);

        Task<T> GetSingleByConditionAsync(Expression<Func<T, bool>> ex, string[] includes);

        Task<T> CreateAsync(T entity);

        Task<T> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);
    }
}