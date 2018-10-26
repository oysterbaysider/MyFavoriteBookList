using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsersApi.Models;

namespace UsersApi.Repositories
{
    interface IUsersRepository
    {
        Task CreateAsync(User user);

        Task<IEnumerable<User>> GetAllAds();

        Task<User> GetGuitarAD(string userId);

        Task<bool> Update(User user);
        Task<bool> Delete(string userId);
    }
}
