﻿using _2.Data.DbContexts;
using _2.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace _2.Data.Repositories
{
    public class AllRepositories<TEntity> : IAllRepositories<TEntity> where TEntity : class
    {
        private DoAnNhanhDbContext _dbContext;
        public DbSet<TEntity> Entities { get; set; }
        public AllRepositories(DoAnNhanhDbContext doannhanhDbContext)
        {
            this._dbContext = doannhanhDbContext;
            this.Entities = _dbContext.Set<TEntity>();
        }
        public async Task<TEntity> AddOneAsyn(TEntity entity)
        {
            await this.Entities.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> AddManyAsyn(IEnumerable<TEntity> entity)
        {
            Collection<TEntity> result = new Collection<TEntity>();
            foreach (var item in entity) // thêm từng cái 1
            {
                Collection<TEntity> collects = result;
                collects.Add(await this.AddOneAsyn(item));
            }
            return (TEntity)(IEnumerable<TEntity>)result;
        }

        public async Task<TEntity> DeleteOneAsyn(TEntity entity)
        {
            await Task.FromResult<TEntity>(this.Entities.Remove(entity).Entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> DeleteManyAsyn(IEnumerable<TEntity> entity)
        {
            Collection<TEntity> result = new Collection<TEntity>();
            foreach (var item in entity) // thêm từng cái 1
            {
                Collection<TEntity> collects = result;
                collects.Add(await this.DeleteOneAsyn(item));
            }
            return (TEntity)(IEnumerable<TEntity>)result;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await Entities.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await Entities.FindAsync(id);
        }

        public async Task<TEntity> UpdateOneAsyn(TEntity entity)
        {
            _dbContext.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<TEntity>> UpdateManyAsyn(IEnumerable<TEntity> entity)
        {
            Collection<TEntity> result = new Collection<TEntity>();
            foreach (var item in entity) // thêm từng cái 1
            {
                Collection<TEntity> collects = result;
                collects.Add(await this.UpdateOneAsyn(item));
            }
            return (IEnumerable<TEntity>)result;
        }
    }
}
