using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Application.Interfaces.AppUserInterfaces;
using UdemyCarBook.Domain.Entities;
using UdemyCarBook.Persistence.Context;

namespace UdemyCarBook.Persistence.Repositories.AppUserRepositories
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly CarBookContext _context;
        public AppUserRepository(CarBookContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(AppUser entity)
        {
            _context.Set<AppUser>().Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<List<AppUser>> GetAllAsync()
        {
            return await _context.Set<AppUser>().ToListAsync();
        }

        public List<AppUser> GetAllWithAppRoleName()
        {
            return _context.AppUsers
                .Include(x => x.AppRole) 
                .ToList();
        }

        public async Task<List<AppUser>> GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<AppUser> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task RemoveAsync(AppUser entity)
        {
            _context.Set<AppUser>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(AppUser entity)
        {
            _context.Set<AppUser>().Update(entity);
            await _context.SaveChangesAsync();
        }

        Task<AppUser?> IRepository<AppUser>.GetByFilterAsync(Expression<Func<AppUser, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
