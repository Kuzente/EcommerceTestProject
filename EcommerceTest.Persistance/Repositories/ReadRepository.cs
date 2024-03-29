﻿using EcommerceTest.Application.Repositories;
using EcommerceTest.Domain.Entities.Common;
using EcommerceTest.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceTest.Persistance.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly EcommerceDbContext _context;
        public ReadRepository(EcommerceDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetByIdAsync(string id) => await Table.FirstOrDefaultAsync(p => p.ID == Guid.Parse(id));
    }
}
