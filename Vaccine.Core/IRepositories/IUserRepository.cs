using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vaccine.Core.Dtos;

namespace Vaccine.Core.IRepositories
{
    public interface IUserRepository
    {
        public List<UserDto> GetAll();
    }
}
