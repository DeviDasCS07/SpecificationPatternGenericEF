﻿using Core.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        IEnumerable<T> FindWithSpecificationPattern(ISpecification<T> specification = null);
    }
}
