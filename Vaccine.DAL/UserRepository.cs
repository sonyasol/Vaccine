using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Core;
using Vaccine.Core.Dtos;
using Vaccine.Core.IRepositories;

namespace Vaccine.DAL
{
    public class UserRepository : IUserRepository
    {
        private DataContext _dataContext;

        public UserRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public List<UserDto> GetAll()
        {
            var result = _dataContext.Users.OrderBy(v => v.Name).ToList();
            return result;
        }
    }
        
}
