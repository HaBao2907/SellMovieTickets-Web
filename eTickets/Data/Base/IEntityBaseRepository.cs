﻿using eTickets.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public interface IEntityBaseRepository<T> where T : class, IEntityBase, new() 
    {
        Task<IEnumerable<T>> GetAllAsync();

        //Method
        Task<T> GetByIdAsync(int id);
        Task AddAsync(T entity);
        Task UpdateAsync (int id, T entity);
        Task DeleteAsync(int id);
    }
}
