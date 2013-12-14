using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet.Identity.Dapper
{
    public class DapperUserStore : IUserStore<DapperUser>
    {
        // IUserStore

        public Task CreateAsync(DapperUser user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(DapperUser user)
        {
            throw new NotImplementedException();
        }

        public Task<DapperUser> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<DapperUser> FindByNameAsync(string userName)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(DapperUser user)
        {
            throw new NotImplementedException();
        }

        // IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}