﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransporteParticularWeb.Services.Generic
{
    public interface IGenericService<TEntity>
         where TEntity : class
    {
        System.Threading.Tasks.Task<TEntity> AddAsync(TEntity resource);
        System.Threading.Tasks.Task<TEntity> UpdateAsync(TEntity resource, object key);
        System.Threading.Tasks.Task<TEntity> GetAsync(object key);
        System.Threading.Tasks.Task<TEntity> DeleteAsync(TEntity resource);
        System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<TEntity>> GetAllAsync();
    }
}
