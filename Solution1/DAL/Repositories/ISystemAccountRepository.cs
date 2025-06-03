using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface ISystemAccountRepository
    {
        Task<IEnumerable<SystemAccount>> GetAllSystemAccountsAsync();
        Task<SystemAccount> GetSystemAccountByIdAsync(int id);
        Task AddSystemAccountAsync(SystemAccount systemAccount);
        Task UpdateSystemAccountAsync(SystemAccount systemAccount);
        Task DeleteSystemAccountAsync(int id);
    }
}
