using HardwareInventory.Infrastructure;
using HardwareInventory.Infrastructure.Domain;
using HardwareInventory.Services.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareInventory.Services.Logics
{
    public class UserService: IUserService
    {
        public DataContext _context;
        public UserService(DataContext context) {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            var objs = await _context.Users.ToListAsync();
            return objs.AsEnumerable();
        }

        public async Task<User> GetUser(int id)
        {
            var obj = await _context.Users.FindAsync(id);
            return obj;
        }
    }
}
